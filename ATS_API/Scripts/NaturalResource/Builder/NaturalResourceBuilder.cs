using ATS_API.Helpers;
using Eremite.Model.Sound;
using Eremite.Sound;
using UnityEngine;

namespace ATS_API.NaturalResource;

public partial class NaturalResourceBuilder
{
    public string Name => newModel.Model.name; // myguid_itemName
    public NewNaturalResource NewNaturalResource => newModel;
    
    private readonly string guid; // myGuid
    private readonly string name; // itemName
    private readonly NewNaturalResource newModel;
    
    public NaturalResourceBuilder(string guid, string name)
    {
        this.guid = guid;
        this.name = name;
        newModel = NaturalResourceManager.New(guid, name);
    }
    
    public NaturalResourceBuilder SetCharges(int charges)
    {
        newModel.Model.charges = charges;
        return this;
    }
    
    public NaturalResourceBuilder SetProduction(GoodsTypes goodsTypes, int amount)
    {
        newModel.ProductionGoodType = goodsTypes;
        newModel.ProductionAmount = amount;
        return this;
    }
    
    /// <summary>
    /// Add extra production to the natural resource
    /// </summary>
    /// <param name="goodsTypes">Type of goods to produce</param>
    /// <param name="amount">How much to get</param>
    /// <param name="chance">Between 0 and 1. 1 for 100%</param>
    /// <returns></returns>
    public NaturalResourceBuilder AddExtraProduction(GoodsTypes goodsTypes, int amount, float chance)
    {
        newModel.ExtraProducedGoods.Add(new NewNaturalResource.ExtraProducedGood()
        {
            ProductionGoodType = goodsTypes,
            ProductionAmount = amount,
            Chance = chance,
        });
        return this;
    }
    
    public NaturalResourceBuilder AddPrefab(NaturalResourcePrefabBuilder naturalResourcePrefab)
    {
        newModel.Prefabs.Add(naturalResourcePrefab);
        return this;
    }
    
    public NaturalResourceBuilder AddGatherSound(string soundFile, float volume=1f, float pitch=1f, float randomVolume=0f, float randomPitch=0.04f, int maxSoundsInOnePlace=3, int weight=1, bool stopOnPause=false)
    {
        AudioClip audioPath = AudioHelpers.LoadAudioClip(guid, soundFile);
        if (audioPath == null)
        {
            return this;
        }
        
        SoundModel soundModel = audioPath.ToSoundModel(volume, pitch, randomVolume, randomPitch, maxSoundsInOnePlace, weight, stopOnPause);
        newModel.GatheringSounds.Add(soundModel);
        return this;
    }
    
    public NaturalResourceBuilder AddFallSound(string soundFile, float volume=1f, float pitch=1f, float randomVolume=0f, float randomPitch=0.04f, int maxSoundsInOnePlace=3, int weight=1, bool stopOnPause=false)
    {
        AudioClip audioPath = AudioHelpers.LoadAudioClip(guid, soundFile);
        if (audioPath == null)
        {
            return this;
        }
        
        SoundModel soundModel = audioPath.ToSoundModel(volume, pitch, randomVolume, randomPitch, maxSoundsInOnePlace, weight, stopOnPause);
        newModel.FallSounds.Add(soundModel);
        return this;
    }
}