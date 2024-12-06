using ATS_API.Buildings;
using ATS_API.Helpers;
using Eremite.Model;
using UnityEngine;

namespace ExampleMod;

public partial class Plugin
{
    private void CreateDecorations()
    {
        var tinyHearth = new DecorationBuildingBuilder(PluginInfo.PLUGIN_GUID, "TinyHearth", "TinyHearth.png", DecorationTierTypes.DecorationTier_2);
        tinyHearth.SetDefaultVisualIcon("TinyHearthDisplay.png");
        tinyHearth.SetDisplayName("Tiny Hearth");
        tinyHearth.SetLabel("Decorations");
        tinyHearth.AddRequiredGoods((9, GoodsTypes.Mat_Processed_Planks));
        tinyHearth.SetDecorationScore(4);
        tinyHearth.SetCustomModel(TinyHearthAssetBundle.LoadAsset<GameObject>("TinyHearth"));
        
        var humanMaleDead = new DecorationBuildingBuilder(PluginInfo.PLUGIN_GUID, "HumanMaleDead", "HumanMaleDead.png", DecorationTierTypes.DecorationTier_3);
        humanMaleDead.SetDefaultVisualIcon("HumanMaleDeadDisplay.png");
        humanMaleDead.SetDisplayName("Dead Human Male");
        humanMaleDead.SetLabel("Decorations");
        humanMaleDead.AddRequiredGoods((5, GoodsTypes.Food_Raw_Meat));
        humanMaleDead.SetDecorationScore(1);
        humanMaleDead.SetFootPrint(1, 1, FieldType.Ruins);
        humanMaleDead.SetCustomModel(TinyHearthAssetBundle.LoadAsset<GameObject>("HumanMaleDead"));
    }
}