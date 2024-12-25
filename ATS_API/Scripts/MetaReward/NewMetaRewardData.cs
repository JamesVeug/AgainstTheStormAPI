using System;
using System.Linq;
using ATS_API.Helpers;
using Eremite.Model.Meta;

namespace ATS_API.MetaRewards;

public class NewMetaRewardData : ASyncable<MetaRewardModel>
{
    public readonly string guid;
    public readonly string rawName;
    
    public MetaRewardModel Model;

    public GoodsTypes GoodsTypes = GoodsTypes.None;
    public EffectTypes EffectType = EffectTypes.None;

    public NewMetaRewardData(string guid, string name, MetaRewardModel model)
    {
        this.guid = guid;
        this.rawName = name;
        this.Model = model;
    }

    public override void PostSync()
    {
        base.PostSync();
        
        if (Model is EmbarkGoodMetaRewardModel embarkGoodMetaRewardModel)
        {
            if (embarkGoodMetaRewardModel.good.good == null)
            {
                if (GoodsTypes != GoodsTypes.None)
                {
                    embarkGoodMetaRewardModel.good.good = GoodsTypes.ToGoodModel();
                }
                else
                {
                    APILogger.LogError(
                        $"Tried syncing new EmbarkGoodMetaRewardModel ({Model.name}) but GoodsTypes was not assigned!");
                }
            }
        }
        else if (Model is EmbarkEffectMetaRewardModel embarkEffectMetaRewardModel)
        {
            embarkEffectMetaRewardModel.effect = EffectType.ToEffectModel();
        }
        else
        {
            throw new NotSupportedException("Unsupported MetaRewardModel type.\n" + Environment.StackTrace);
        }
    }

    public static NewMetaRewardData FromModel(MetaRewardModel model)
    {
        NewMetaRewardData data = MetaRewardManager.NewMetaRewards.FirstOrDefault(a => a.Model == model);
        if (data != null)
        {
            return data;
        }

        NewMetaRewardData newMetaRewardData = new NewMetaRewardData("", model.name, model);
        
        if (model is EmbarkGoodMetaRewardModel embarkGoodMetaRewardModel)
        {
            newMetaRewardData.GoodsTypes = embarkGoodMetaRewardModel.good?.good?.name.ToGoodsTypes() ?? GoodsTypes.None;
        }
        else if (model is EmbarkEffectMetaRewardModel embarkEffectMetaRewardModel)
        {
            newMetaRewardData.EffectType = embarkEffectMetaRewardModel.effect?.name.ToEffectTypes() ?? EffectTypes.None;
        }
        else
        {
            throw new NotSupportedException("Unsupported MetaRewardModel type\n" + Environment.StackTrace);
        }
        
        return newMetaRewardData;
    }
}