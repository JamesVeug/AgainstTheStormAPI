using ATS_API.Goods;
using ATS_API.Helpers;
using Eremite.Model;
using Eremite.Model.Effects;

namespace ATS_API.Effects;

public class NewEffectData : ASyncable<EffectModel>
{
    public string Guid;
    public string Name;
    public EffectModel EffectModel;
    public Availability Availability = new Availability();
    public bool IsCornerstone = false;
    public int Chance = 10; // 1-100
    public object MetaData;

    public override void Sync(EffectModel model)
    {
        if (model is GoodsRawProductionEffectModel goodsRawProductionEffectModel)
        {
            if (MetaData is GoodsProductionEffectBuilder.GoodProductionEffectBuildMetaData metaData)
            {
                goodsRawProductionEffectModel.good = metaData.Good.GetGoodRef();
            }
            else if(MetaData != null)
            {
                Plugin.Log.LogError($"{model.name} MetaData is not GoodsProductionEffectBuilder.GoodProductionEffectBuildMetaData");
            }
        }
        if (model is GoodsEffectModel goodsEffectModel)
        {
            if (MetaData is GoodsEffectBuilder.GoodEffectBuildMetaData metaData)
            {
                goodsEffectModel.good = metaData.GoodsToGive.GetGoodRef();
            }
            else if(MetaData != null)
            {
                Plugin.Log.LogError($"{model.name} MetaData is not GoodsEffectBuilder.GoodEffectBuildMetaData");
            }
        }
    }
}