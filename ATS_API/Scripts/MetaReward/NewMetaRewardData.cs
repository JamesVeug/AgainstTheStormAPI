using ATS_API.Helpers;
using Eremite.Model.Meta;

namespace ATS_API.MetaRewards;

public class NewMetaRewardData : ASyncable<MetaRewardModel>
{
    private readonly string guid;
    private readonly string rawName;
    
    public MetaRewardModel Model;

    public GoodsTypes GoodsTypes = GoodsTypes.None;
    public EffectTypes EffectType = EffectTypes.None;

    public NewMetaRewardData(string guid, string name)
    {
        this.guid = guid;
        this.rawName = name;
    }

    public override void PostSync()
    {
        base.PostSync();
        
        if (Model is EmbarkGoodMetaRewardModel embarkGoodMetaRewardModel)
        {
            embarkGoodMetaRewardModel.good.good = GoodsTypes.ToGoodModel();
        }
        else if (Model is EmbarkEffectMetaRewardModel embarkEffectMetaRewardModel)
        {
            embarkEffectMetaRewardModel.effect = EffectType.ToEffectModel();
        }
    }
}