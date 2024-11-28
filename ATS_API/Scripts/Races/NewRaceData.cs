using System;
using System.Collections.Generic;
using System.Reflection;
using ATS_API.Helpers;
using Eremite;
using Eremite.Buildings;
using Eremite.Model;

namespace ATS_API.Races;

public class NewRaceData : ASyncable<RaceModel>
{
    public RaceModel RaceModel;
    public RaceTypes ID;
    public List<string> needs = new List<string>();
    public List<RaceCharacteristicRef> characteristics = new List<RaceCharacteristicRef>();
    public ResolveEffectTypes HungerEffect = ResolveEffectTypes.Hunger_Penalty;
    public Availability RaceWorkPlaceAvailability = new Availability();

    public override bool Sync()
    {
        return true;
    }

    public override void PostSync()
    {
        // characteristics
        RaceModel.characteristics = new RaceCharacteristicModel[characteristics.Count];
        for (int i = 0; i < characteristics.Count; i++)
        { 
            RaceCharacteristicRef characteristicRef = characteristics[i];
            RaceCharacteristicModel characteristicModel = new RaceCharacteristicModel();
            if(characteristicRef.Tag != BuildingTagTypes.None)
                characteristicModel.tag = characteristicRef.Tag.ToBuildingTagModel();
            
            if(characteristicRef.Effect != VillagerPerkTypes.None)
                characteristicModel.effect = characteristicRef.Effect.ToVillagerPerkModel();
            
            if(characteristicRef.GlobalEffect != EffectTypes.None)
                characteristicModel.globalEffect = characteristicRef.GlobalEffect.ToEffectModel();
            
            if(characteristicRef.BuildingPerk != BuildingPerkTypes.None)
                characteristicModel.buildingPerk = characteristicRef.BuildingPerk.ToBuildingPerkModel();
            RaceModel.characteristics[i] = characteristicModel;
        }
        
        RaceModel.hungerEffect = HungerEffect.ToResolveEffectModel();
        
        // needs
        List<NeedModel> needModels = new List<NeedModel>();
        foreach (string need in needs)
        {
            NeedModel needModel = need.ToNeedModel();
            if (needModel == null)
            {
                Plugin.Log.LogError($"Failed to find need {need} for new race {RaceModel.name}");
                continue;
            }
            needModels.Add(needModel);
        }
        RaceModel.needs = needModels.ToArray();
        
        
        RaceModel template = RaceTypes.Harpy.ToRaceModel();
        if(RaceModel.femalePrefab == null)
            RaceModel.femalePrefab = template.femalePrefab;
        if(RaceModel.malePrefab == null)
            RaceModel.malePrefab = template.malePrefab;
        if(RaceModel.femaleNames == null)
            RaceModel.femaleNames = template.femaleNames;
        if(RaceModel.maleNames == null)
            RaceModel.maleNames = template.maleNames;
        if(RaceModel.deathEffects == null)
            RaceModel.deathEffects = template.deathEffects;
        if(RaceModel.hungerEffect == null)
            RaceModel.hungerEffect = template.hungerEffect;
        if(RaceModel.homelessPenalty == null)
            RaceModel.homelessPenalty = template.homelessPenalty;
        if(RaceModel.hostilityPenalty == null)
            RaceModel.hostilityPenalty = template.hostilityPenalty;
        if(RaceModel.characteristics == null)
            RaceModel.characteristics = [];
        if(RaceModel.resilienceLabel == null)
            RaceModel.resilienceLabel = template.resilienceLabel;

        if (RaceWorkPlaceAvailability.WorkPlaces.Count > 0)
        {
            foreach (BuildingModel buildingModel in SO.Settings.Buildings)
            {
                if (buildingModel is HouseModel houseModel)
                {
                    // Add this race to the house so they can sleep in it
                    if (houseModel.housingRaces.Length > 1)
                    {
                        if (!houseModel.housingRaces.Contains(RaceModel))
                        {
                            // Add this race to the list
                            RaceModel[] newRaces = new RaceModel[houseModel.housingRaces.Length + 1];
                            Array.Copy(houseModel.housingRaces, newRaces, houseModel.housingRaces.Length);
                            newRaces[newRaces.Length - 1] = RaceModel;
                            houseModel.housingRaces = newRaces;
                        }
                    }
                }
                else
                {
                    if (!RaceWorkPlaceAvailability.HasWorkPlace(buildingModel.name))
                    {
                        continue;
                    }

                    if (TryGetWorkPlaceList(buildingModel, out WorkplaceModel[] workplaces))
                    {
                        foreach (WorkplaceModel model in workplaces)
                        {
                            if (!model.allowedRaces.Contains(RaceModel))
                            {
                                // Race not added. We need to add it
                                RaceModel[] newRaces = new RaceModel[model.allowedRaces.Length + 1];
                                Array.Copy(model.allowedRaces, newRaces, model.allowedRaces.Length);
                                newRaces[newRaces.Length - 1] = RaceModel;
                                model.allowedRaces = newRaces;
                            }
                        }
                    }
                }
            }
        }
    }

    public override string ToString()
    {
        return $"NewRace({(RaceModel == null ? "null" : RaceModel.name)})";
    }
    
    private Dictionary<Type, FieldInfo> _workPlaceListCache = new Dictionary<Type, FieldInfo>();
    private bool TryGetWorkPlaceList(BuildingModel buildingModel, out WorkplaceModel[] workPlaces)
    {
        if (_workPlaceListCache.TryGetValue(buildingModel.GetType(), out FieldInfo info))
        {
            if (info == null)
            {
                workPlaces = null;
                return false;
            }
            
            workPlaces = (WorkplaceModel[]) info.GetValue(buildingModel);
            return true;
        }
        
        // Get all fields and check for one that is a WorkplaceModel[]
        FieldInfo[] fields = buildingModel.GetType().GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
        foreach (FieldInfo field in fields)
        {
            if (field.FieldType == typeof(WorkplaceModel[]))
            {
                _workPlaceListCache[buildingModel.GetType()] = field;
                workPlaces = (WorkplaceModel[]) field.GetValue(buildingModel);
                return true;
            }
        }

        _workPlaceListCache[buildingModel.GetType()] = null;
        workPlaces = null;
        return false;
    }
}