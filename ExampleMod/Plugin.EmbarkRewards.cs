using ATS_API.Helpers;
using ATS_API.MetaRewards;

namespace ExampleMod;

public partial class Plugin
{
    private void CreateEmbarkRewards()
    {
        var artifactEmbarkReward = new EmbarkGoodMetaRewardBuilder(PluginInfo.PLUGIN_GUID, "Ancient Tablet Embark Reward");
        artifactEmbarkReward.SetGood(GoodsTypes.Valuable_Ancient_Tablet, 5);
        artifactEmbarkReward.SetCostRange(3, 6);
        
        var alePerMinuteEmbarkReward = new EmbarkEffectMetaRewardBuilder(PluginInfo.PLUGIN_GUID, "3 ale per minute Embark Reward");
        alePerMinuteEmbarkReward.SetEffect(EffectTypes.Ale_3pm);
        alePerMinuteEmbarkReward.SetCostRange(3, 5);
        
        var lpgReward = new EmbarkGoodMetaRewardBuilder(PluginInfo.PLUGIN_GUID, "LPG Embark Reward");
        lpgReward.SetGood(lpg.NewGood.id, 20);
        lpgReward.SetCostRange(4, 5);

        var moddingToolsReward = new EmbarkEffectMetaRewardBuilder(PluginInfo.PLUGIN_GUID, "Modding Tools Embark Reward");
        moddingToolsReward.SetEffect(ModdingToolsBuilder.EffectType);
        moddingToolsReward.SetCostRange(6, 9);
    }
}