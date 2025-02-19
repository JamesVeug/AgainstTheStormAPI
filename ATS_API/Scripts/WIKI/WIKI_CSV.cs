using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using ATS_API.Scripts.DeveloperConsole;
using Eremite;
using Eremite.Buildings;
using Eremite.Model;
using Eremite.Model.Effects;
using Eremite.Model.Orders;

namespace ATS_API;

public partial class WIKI
{
    
    /// <summary>
    /// Exports a bunch of data to CSV files so it can be loaded in excel or something
    /// TODO: Only works for Relics atm. Make it work for everything
    /// </summary>
    public static void ExportCSVs()
    {
        APILogger.LogInfo("Exporting CSVs...");
        ExportRelicsAsCSV();
        ExportOrdersAsCSV();
        APILogger.LogInfo("Exporting CSVs... Done!");
    }

    public static void ExportMDs()
    {
        APILogger.LogInfo("Exporting MDs...");
        ExportEffectInfo();
        DeveloperConsole.ExportAllCommands();
        APILogger.LogInfo("Exporting MDs... Done!");
    }

    private static void ExportOrdersAsCSV()
    {
        CSVBuilder csv = new CSVBuilder();
        
        var sortedOrders = MB.Settings.orders
            .Where(o=>o.tiers.Length > 0)
            .OrderBy(a => a.name);
        
        int maxLogics = sortedOrders.Max(a => a.logicsSets.Length);
        foreach (OrderModel order in sortedOrders)
        {
            csv.AddValue("ID", order.name, 1);
            csv.AddValue("Name", order.displayName.GetText(), 2);
            csv.AddValue("Tiers", string.Join("-", order.tiers.Select(a=>a.name)).ToString(), 3);
            
            // for (int i = 0; i < order.logicsSets.Length; i++)
            // {
            //     csv.AddValue("objective_" + (i+1), order.logicsSets[i].logics, 5 + i);
            // }
            
            csv.AddValue("FailTime", order.timeToFail > 0 ? order.timeToFail.ToString("F2") : "", 3);
            csv.AddValue("Reputation", ((ReputationEffectModel)order.reputationReward).amount.ToString(), 4);

            for (int i = 0; i < order.rewards1.Length; i++)
            {
                csv.AddValue("Reward_1_" + (i+1), order.rewards1[i].effect.Name, 10 + i);
            }
            for (int i = 0; i < order.rewards2.Length; i++)
            {
                csv.AddValue("Reward_2_" + (i+1), order.rewards2[i].effect.Name, 20 + i);
            }
            for (int i = 0; i < order.rewards3.Length; i++)
            {
                csv.AddValue("Reward_3_" + (i+1), order.rewards3[i].effect.Name, 30 + i);
            }
            csv.NextRow();
        }

        csv.SaveAsCSV(Path.Combine(Plugin.ExportPath, "CSV", "Orders.csv"));
    }

    private static void ExportRelicsAsCSV()
    {
        CSVBuilder csv = new CSVBuilder();

        HashSet<Type> rewardTypes = new HashSet<Type>();

        var sortedRelics = MB.Settings.Relics.OrderBy(a => a.name).Distinct();
        foreach (RelicModel relic in sortedRelics)
        {
            csv.AddValue("ID", relic.name, 1);
            csv.AddValue("Name", relic.displayName.GetText(), 2);
            csv.AddValue("Description", relic.description.GetText(), 3);
            csv.AddValue("DangerLevel", relic.dangerLevel.ToString(), 4);
            csv.AddValue("Category", relic.category.name, 5);
            csv.AddValue("Profession", relic.profession.name, 6);


            for (var i = 0; i < relic.difficulties.Length; i++)
            {
                var difficulty = relic.difficulties[i];
                for (var j = 0; j < difficulty.decisions.Length; j++)
                {
                    var decision = difficulty.decisions[j];
                    string decisionKey = $"Difficulty_{difficulty.difficulty + 1}_decision_{j + 1}";
                    csv.AddValue(decisionKey + "_workingTime", decision.workingTime.ToString("F"), 7);
                    csv.AddValue(decisionKey + "_decisionType", decision.decisionTag?.name, 8);

                    List<string> requiredGoods = new List<string>();
                    for (var k = 0; k < decision.requriedGoods.sets.Length; k++)
                    {
                        var set = decision.requriedGoods.sets[k];
                        for (var l = 0; l < set.goods.Length; l++)
                        {
                            var goodRef = set.goods[l];
                            requiredGoods.Add(goodRef.amount + ":" + goodRef.good.name);
                        }
                    }
                    csv.AddValue(decisionKey + $"_requiredGoods", requiredGoods.Count > 0 ? string.Join(", ", requiredGoods) : "", 9);

                    string workingEffects = string.Join(":",decision.workingEffects.Select(a => a.name));
                    csv.AddValue(decisionKey + $"_workingEffects", workingEffects, 10);
                }
            }
            
            for (var i = 0; i < relic.effectsTiers.Length; i++)
            {
                EffectStep effectModel = relic.effectsTiers[i];
                string header = "EffectTier_" + (i + 1);
                
                // Time TO Start
                csv.AddValue(header + "_TTS", ((int)effectModel.timeToStart).ToString(), 11);

                // Effect
                for (var j = 0; j < effectModel.effect.Length; j++)
                {
                    var model = effectModel.effect[j];
                    csv.AddValue(header + "_Effect_" + (j+1), model.name, 12);
                }
            }

            for (var i = 0; i < relic.activeEffects.Length; i++)
            {
                var effectModel = relic.activeEffects[i];
                csv.AddValue("ActiveEffect_" + (i + 1), relic.category.name + ":" + effectModel.GetType().Name, 13);
            }

            int rewardID = 0;
            foreach (EffectsTable decision in relic.decisionsRewards)
            {
                // Vector2Int amounts = decision.amounts;
                foreach (EffectsTableEntity reward in decision.effects)
                {
                    EffectModel effectModel = reward.effect;
                    csv.AddValue("Reward_" + (rewardID + 1),
                        effectModel.name + ":" + reward.chance + ":" + effectModel.GetType().Name, 14);

                    rewardTypes.Add(effectModel.GetType());
                    rewardID++;
                }
            }

            csv.NextRow();
        }

        csv.SaveAsCSV(Path.Combine(Plugin.ExportPath, "CSV", "Relics.csv"));
    }
}