using System.Collections.Generic;
using ATS_API.Helpers;
using Eremite.Model;

namespace ATS_API.Races;

public class NewRaceData : ASyncable<RaceModel>
{
    public RaceModel RaceModel;
    public RaceTypes ID;
    public List<string> needs = new List<string>();
    public string racialHousingNeed;
    public List<RaceCharacteristicRef> characteristics = new List<RaceCharacteristicRef>();
    public ResolveEffectTypes HungerEffect = ResolveEffectTypes.Hunger_Penalty;
    public Availability WorkPlaces = new Availability();

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
        
        // racialHousingNeed
        if (!string.IsNullOrEmpty(racialHousingNeed))
        {
            NeedModel needModel = racialHousingNeed.ToNeedModel();
            if (needModel != null)
            {
                RaceModel.racialHousingNeed = needModel;
            }
            else
            {
                Plugin.Log.LogError($"Failed to find need {racialHousingNeed} for new race {RaceModel.name}");
            }
        }
        
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
    }

    public override string ToString()
    {
        return $"NewRace({(RaceModel == null ? "null" : RaceModel.name)})";
    }
}