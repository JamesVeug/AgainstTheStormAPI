using ATS_API.MetaRewards;

namespace ExampleMod;

public partial class Plugin
{
    private void CreateEmbarkRewards()
    {
        var lpgReward = new EmbarkGoodMetaRewardBuilder(PluginInfo.PLUGIN_GUID, "LPG Embark Reward");
        lpgReward.SetGood(lpg.NewGood.id, 20);
        lpgReward.SetCostRange(4, 5);

        var moddingToolsReward = new EmbarkEffectMetaRewardBuilder(PluginInfo.PLUGIN_GUID, "Modding Tools Embark Reward");
        moddingToolsReward.SetEffect(ModdingToolsBuilder.EffectType);
        moddingToolsReward.SetCostRange(6, 9);
    }
}