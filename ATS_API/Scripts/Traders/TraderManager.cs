using ATS_API.Goods;
using ATS_API.Helpers;
using Eremite;
using Eremite.Model;
using Eremite.Model.Trade;

namespace ATS_API.Traders;

public static class TraderManager
{
    // public static IReadOnlyList<TraderModel> NewTraders => new ReadOnlyCollection<TraderModel>(s_newTraders);
    //
    // private static List<TraderModel> s_newTraders = new List<TraderModel>();

    // private static ArraySync<TraderModel> s_traders = new("New Traders");

    private static bool s_instantiated = false;
    private static bool s_dirty = false;

    // public static TraderModel New(string guid, string name, string displayName, string description, string iconPath)
    // {
    //     TraderModel TraderModel = ScriptableObject.CreateInstance<TraderModel>();
    //     TraderModel.displayName = LocalizationManager.ToLocaText(guid, name, "displayName", displayName);
    //     TraderModel.description = LocalizationManager.ToLocaText(guid, name, "description", description);
    //     TraderModel.icon = TextureHelper.GetImageAsSprite(iconPath, TextureHelper.SpriteType.EffectIcon);
    //     TraderModel.newsIcon = TextureHelper.GetImageAsSprite(iconPath, TextureHelper.SpriteType.EffectIcon);
    //     TraderModel.label = null; // Add enum to specify what the model is?
    //
    //     Add(guid, name, TraderModel);
    //     return TraderModel;
    // }
    //
    // private static void Add(string guid, string name, TraderModel TraderModel)
    // {
    //     TraderModel.name = guid + "_" + name;
    //     s_newTraders.Add(TraderModel);
    //     s_dirty = true;
    // }

    internal static void Instantiate()
    {
        s_instantiated = true;
        s_dirty = true;
        SyncTrader();
    }

    public static void Tick()
    {
        if (s_dirty)
        {
            s_dirty = false;
            SyncTrader();
        }
    }

    private static void SyncTrader()
    {
        if (!s_instantiated)
        {
            return;
        }


    }

    public static void SyncNewGood(GoodsManager.NewGood model)
    {
        if (model.SoldByTrader != null || model.SoldToTrader)
        {
            // TODO: Add filter by trader name
            foreach (TraderModel traderModel in MB.Settings.traders)
            {
                if (model.SoldByTrader != null)
                {
                    if (model.SoldByTrader.Weight >= 100)
                    {
                        GoodRef goodRef = new GoodRef()
                        {
                            good = model.goodModel,
                            amount = model.SoldByTrader.Amount
                        };
                        ArrayExtensions.AddElement(ref traderModel.guaranteedOfferedGoods, goodRef);
                    }
                    else
                    {
                        GoodRefWeight goodRef = new GoodRefWeight()
                        {
                            good = model.goodModel,
                            amount = model.SoldByTrader.Amount,
                            weight = model.SoldByTrader.Weight
                        };
                        ArrayExtensions.AddElement(ref traderModel.offeredGoods, goodRef);
                    }

                    Plugin.Log.LogInfo($"{model.goodModel.name} is offered by {traderModel.name}!");
                }

                if (model.SoldToTrader)
                {
                    ArrayExtensions.AddElement(ref traderModel.desiredGoods, model.goodModel);
                    Plugin.Log.LogInfo($"{model.goodModel.name} is desired by {traderModel.name}!");
                }
            }
        }
    }
}