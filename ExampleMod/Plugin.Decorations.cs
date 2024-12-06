using ATS_API.Buildings;
using ATS_API.Helpers;
using UnityEngine;

namespace ExampleMod;

public partial class Plugin
{
    private void CreateDecorations()
    {
        var decoration = new DecorationBuildingBuilder(PluginInfo.PLUGIN_GUID, "Decoration", "TinyHearth.png", DecorationTierTypes.DecorationTier_2);
        decoration.SetDefaultVisualIcon("TinyHearthDisplay.png");
        decoration.SetDisplayName("Tiny Hearth");
        decoration.SetLabel("Decorations");
        decoration.AddRequiredGoods((1, GoodsTypes.Mat_Raw_Wood));
        decoration.SetDecorationScore(4);
        decoration.SetCustomModel(TinyHearthAssetBundle.LoadAsset<GameObject>("TinyHearth"));
    }
}