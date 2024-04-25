using System.Collections.Generic;
using System.Collections.ObjectModel;
using ATS_API.Helpers;
using ATS_API.Relics;
using ATS_API.Traders;
using Eremite;
using Eremite.Model;
using UnityEngine;

namespace ATS_API.Goods;

public static class GoodsManager
{
    public class NewGood
    {
        public class TraderDetails
        {
            public int Amount = 30;
            public int Weight = 100;
        }
        
        public class RelicDetails
        {
            public EffectsTableEntity RelicGoodEffect;
        }
        
        public GoodModel goodModel;
        public bool SoldToTrader;
        public TraderDetails SoldByTrader;
        public List<RelicDetails> RelicRewards = new List<RelicDetails>();
    }
    
    public static IReadOnlyList<NewGood> NewEffects => new ReadOnlyCollection<NewGood>(s_newGoods);
    
    private static List<NewGood> s_newGoods = new List<NewGood>();
    
    private static ArraySync<GoodModel, NewGood> s_goods = new("New Goods");
    
    private static bool s_instantiated = false;
    private static bool s_dirty = false;
    private static GoodCategoryModel[] s_categories;
    
    public static NewGood New(string guid, string name, string iconPath)
    {
        GoodModel goodModel = ScriptableObject.CreateInstance<GoodModel>();
        goodModel.icon = TextureHelper.GetImageAsSprite(iconPath, TextureHelper.SpriteType.EffectIcon);
        goodModel.prefab = null; // Add enum to specify what the model is? 
        goodModel.pilePrefab = null; // Add enum to specify what the model is?
        goodModel.category = null; // Change this when we sync
        goodModel.tags = [];
        goodModel.consoleId = name;
        goodModel.order = 4;
        goodModel.isActive = true;
        goodModel.isOnHUD = true;
        goodModel.showStorageAmount = true;
        goodModel.eatable = false;
        goodModel.eatingFullness = 1.0f;
        goodModel.canBeBurned = false;
        goodModel.burningTime = 1.0f;
        goodModel.tradingSellValue = 1.8f;
        goodModel.tradingBuyValue = 3.0f;

        return Add(guid, name, goodModel);
    }

    private static NewGood Add(string guid, string name, GoodModel goodModel)
    {
        goodModel.name = guid + "_" + name;
        NewGood newGood = new NewGood
        {
            goodModel = goodModel,
        };
        s_newGoods.Add(newGood);
        s_dirty = true;

        return newGood;
    }

    internal static void Instantiate()
    {
        s_instantiated = true;
        s_dirty = true;
        SyncGoods();
    }
    
    public static void Tick()
    {
        if(s_dirty)
        {
            s_dirty = false;
            SyncGoods();
        }
    }

    private static void SyncGoods()
    {
        if (!s_instantiated)
        {
            return;
        }

        Plugin.Log.LogInfo("GoodsManager.Sync: " + s_newGoods.Count + " new goods");

        
        Settings settings = SO.Settings;
        foreach (NewGood model in s_newGoods)
        {
            // Dunno what categories are for but we need them due to the lookupByCategory
            model.goodModel.category = settings.Goods[0].category;
            Plugin.Log.LogInfo($"Assigning new good {model.goodModel.name} category {model.goodModel.category.name}");
        }
        
        var added = s_goods.Sync(ref settings.Goods, settings.goodsCache, s_newGoods, a => a.goodModel);
        Plugin.Log.LogInfo($"Syncing {added.Count} with the trader");
        foreach (NewGood model in added)
        {
            TraderManager.SyncNewGood(model);
            RelicManager.SyncNewGood(model);
        }
    }
}