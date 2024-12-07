using System.Collections.Generic;
using System.Linq;
using ATS_API.Helpers;
using Eremite.Model;
using Eremite.Model.Sound;
using UnityEngine;

namespace ATS_API.NaturalResource;

public class NewNaturalResource : ASyncable<NaturalResourceModel>
{
    public class ExtraProducedGood
    {
        public GoodsTypes ProductionGoodType;
        public int ProductionAmount;
        public float Chance; // 0 -> 1
    }
    
    public NaturalResourceModel Model;
    public NaturalResourceTypes ID;
    public string Guid;
    public string RawName;

    public GoodsTypes ProductionGoodType = GoodsTypes.Mat_Raw_Wood;
    public int ProductionAmount = 1;
    
    public List<ExtraProducedGood> ExtraProducedGoods = new List<ExtraProducedGood>();
    public List<SoundModel> GatheringSounds = new List<SoundModel>();
    public List<SoundModel> FallSounds = new List<SoundModel>();
    
    public List<NaturalResourcePrefabBuilder> Prefabs = new();

    public override bool Sync()
    {
        base.Sync();

        Model.production = new GoodRef()
        {
            good = ProductionGoodType.ToGoodModel(),
            amount = ProductionAmount,
        };
        Model.refGood = Model.production.good;
        
        Model.extraProduction = new GoodRefChance[ExtraProducedGoods.Count];
        for (int i = 0; i < ExtraProducedGoods.Count; i++)
        {
            Model.extraProduction[i] = new GoodRefChance()
            {
                good = ExtraProducedGoods[i].ProductionGoodType.ToGoodModel(),
                amount = ExtraProducedGoods[i].ProductionAmount,
                chance = ExtraProducedGoods[i].Chance,
            };
        }
        
        Model.prefabs = Prefabs.Select(a=>a.CreatePrefab()).ToArray();


        NaturalResourceModel template = NaturalResourceTypes.Woodlands_Tree.ToNaturalResourceModel();
        Model.label = template.label;

        if (GatheringSounds.NullOrEmpty())
        {
            Model.gatheringSound = template.gatheringSound;
        }
        else
        {
            Model.gatheringSound = ScriptableObject.CreateInstance<SoundRef>();
            Model.gatheringSound.sounds = GatheringSounds.ToArray();
            Model.gatheringSound.useWieghts = true;
        }
        
        if (FallSounds.NullOrEmpty())
        {
            Model.gatheringSound = template.finalSound;
        }
        else
        {
            Model.finalSound = ScriptableObject.CreateInstance<SoundRef>();
            Model.finalSound.sounds = FallSounds.ToArray();
            Model.finalSound.useWieghts = true;
        }
        
        return true;
    }
}