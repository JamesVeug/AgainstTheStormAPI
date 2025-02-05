﻿using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using ATS_API.Helpers;
using ATS_API.Relics;
using ATS_API.Traders;
using Eremite;
using Eremite.Model;
using UnityEngine;

namespace ATS_API.Goods;

public static class GoodsManager
{
    public static IReadOnlyList<NewGood> NewGoods => new ReadOnlyCollection<NewGood>(s_newGoods);
    public static IReadOnlyDictionary<GoodsTypes, NewGood> NewGoodsLookup => new ReadOnlyDictionary<GoodsTypes, NewGood>(s_newGoodsLookup);
    
    private static List<NewGood> s_newGoods = new List<NewGood>();
    private static Dictionary<GoodsTypes, NewGood> s_newGoodsLookup = new Dictionary<GoodsTypes, NewGood>();
    
    private static ArraySync<GoodModel, NewGood> s_goods = new("New Goods");
    
    private static bool s_instantiated = false;
    private static bool s_dirty = false;
    private static GoodCategoryModel[] s_categories;
    
    public static NewGood New(string guid, string name, string iconPath)
    {
        GoodModel goodModel = ScriptableObject.CreateInstance<GoodModel>();
        goodModel.icon = TextureHelper.GetImageAsSprite(iconPath, TextureHelper.SpriteType.GoodIcon);
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

        NewGood good = Add(guid, name, goodModel);
        TextMeshProManager.Add(goodModel.icon.texture, goodModel.name);
        return good;
    }

    public static NewGood Add(string guid, string name, GoodModel goodModel)
    {
        goodModel.name = guid + "_" + name;
        APILogger.IsFalse(s_newGoods.Any(a=>a.goodModel.name == goodModel.name), $"Adding Good with name {goodModel.name} that already exists!");
        
        GoodsTypes id = GUIDManager.Get<GoodsTypes>(guid, name);
        GoodsTypesExtensions.TypeToInternalName[id] = goodModel.name;
        NewGood newGood = new NewGood
        {
            goodModel = goodModel,
            id = id,
            guid = guid,
            rawName = name
        };
        s_newGoods.Add(newGood);
        s_newGoodsLookup.Add(id, newGood);
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

        APILogger.LogInfo("GoodsManager.Sync: " + s_newGoods.Count + " new goods");

        
        Settings settings = SO.Settings;
        var added = s_goods.Sync(ref settings.Goods, settings.goodsCache, s_newGoods, a => a.goodModel);
        foreach (NewGood model in added)
        {
            TraderManager.PostSyncNewGood(model);
            RelicManager.PostSyncNewGood(model);
        }
    }
}