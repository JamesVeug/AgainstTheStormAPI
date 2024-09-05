using ATS_API.Helpers;
using Eremite.Model;

namespace ATS_API.Races;

public partial class RaceBuilder
{
    public RaceBuilder AddCharacteristic(BuildingTagTypes buildingTagTypes, VillagerPerkTypes effect)
    {
        newRaceData.characteristics.Add(new RaceCharacteristicRef
        {
            Tag = buildingTagTypes,
            Effect = effect
        });
        return this;
    }
    
    public RaceBuilder AddCharacteristic(BuildingTagTypes buildingTagTypes, EffectTypes effect)
    {
        newRaceData.characteristics.Add(new RaceCharacteristicRef
        {
            Tag = buildingTagTypes,
            GlobalEffect = effect
        });
        return this;
    }
    
    public RaceBuilder AddCharacteristic(RaceCharacteristicModel characteristic)
    {
        newRaceData.characteristics.Add(new RaceCharacteristicRef()
        {
            Tag = characteristic.tag.name.ToBuildingTagTypes(),
            Effect = characteristic.effect.name.ToVillagerPerkTypes(),
            GlobalEffect = characteristic.globalEffect.name.ToEffectTypes(),
            BuildingPerk = characteristic.buildingPerk.name.ToBuildingPerkTypes()
        });
        return this;
    }

    public RaceBuilder AddCharacteristics(params RaceCharacteristicModel[] characteristics)
    {
        foreach (var characteristic in characteristics)
        {
            AddCharacteristic(characteristic);
        }
        return this;
    }

    public RaceBuilder SetCharacteristics(params RaceCharacteristicModel[] characteristics)
    {
        newRaceData.characteristics.Clear();
        return AddCharacteristics(characteristics);
    }
}