using System.Collections.Generic;
using System.Linq;
using ATS_API.Ascension;
using ATS_API.Helpers;
using Eremite;
using Eremite.Model;
using UnityEngine;

namespace ATS_API.Difficulties;

public class NewDifficulty : ASyncable<DifficultyModel>
{
    public DifficultyModel difficultyModel;
    public DifficultyTypes id;
    public string guid;
    public string rawName;
    
    public bool copyModifiersFromPreviousDifficulty = false;
    public List<NewAscensionModifierModel> ascensionModifiers = new List<NewAscensionModifierModel>();

    public override void PostSync()
    {
        base.PostSync();

        DifficultyModel closestDifficultyModel = null;
        foreach (DifficultyModel model in SO.Settings.difficulties)
        {
            if(difficultyModel.isAscension != model.isAscension)
                continue;
            
            if (model.index >= difficultyModel.index)
            {
                continue;
            }
            
            if (closestDifficultyModel == null || model.index > closestDifficultyModel.index)
            {
                closestDifficultyModel = model;
            }
        }

        if (closestDifficultyModel == null)
        {
            Plugin.Log.LogError($"Could not find a difficulty model to copy from for {difficultyModel.name}");
            difficultyModel.modifiers = ascensionModifiers.Select(a=>
            {
                if(a.Model.effect == null && a.EffectTypes != EffectTypes.None)
                {
                    a.Model.effect = a.EffectTypes.ToEffectModel();
                }
                
                if(a.ShortDescription != null)
                {
                    a.Model.shortDesc = a.ShortDescription;
                }
                if(a.Model.shortDesc == null)
                {
                    a.Model.shortDesc = a.Model.effect.description;
                }
                return a.Model;
            }).ToArray();
            return;
        }

        if (difficultyModel.icon == null)
        {
            difficultyModel.icon = closestDifficultyModel.icon;
        }

        if (difficultyModel.inGameSeal == null)
        {
            difficultyModel.inGameSeal = closestDifficultyModel.inGameSeal;
        }

        // Blightrot
        if(Mathf.Approximately(difficultyModel.blightFootprintRate, float.MinValue))
        {
            difficultyModel.blightFootprintRate = closestDifficultyModel.blightFootprintRate;
        }
        if(Mathf.Approximately(difficultyModel.blightCorruptionRate, float.MinValue))
        {
            difficultyModel.blightCorruptionRate = closestDifficultyModel.blightCorruptionRate;
        }
        
        // Rewards
        if(Mathf.Approximately(difficultyModel.rewardsMultiplier, float.MinValue))
        {
            difficultyModel.rewardsMultiplier = closestDifficultyModel.rewardsMultiplier + 0.01f;
        }
        if(Mathf.Approximately(difficultyModel.expMultiplier, float.MinValue))
        {
            difficultyModel.expMultiplier = closestDifficultyModel.expMultiplier + 0.01f;
        }
        if(Mathf.Approximately(difficultyModel.scoreMultiplier, float.MinValue))
        {
            difficultyModel.scoreMultiplier = closestDifficultyModel.scoreMultiplier + 0.01f;
        }
        if(Mathf.Approximately(difficultyModel.sealFramentsForWin, float.MinValue))
        {
            // Starts at 5 at prestige 1 and goes up 7 difficulties fragments goes up by 1
            difficultyModel.sealFramentsForWin = 5 + (difficultyModel.index - 4) / 5;
        }
        
        // Seasonal Effects
        if(difficultyModel.difficultyBudget == int.MinValue)
        {
            difficultyModel.difficultyBudget = closestDifficultyModel.difficultyBudget;
        }
        if(difficultyModel.positiveEffects == int.MinValue)
        {
            difficultyModel.positiveEffects = closestDifficultyModel.positiveEffects;
        }
        if(difficultyModel.negativeEffects == int.MinValue)
        {
            difficultyModel.negativeEffects = closestDifficultyModel.negativeEffects;
        }
        if(difficultyModel.minEffectCost == int.MinValue)
        {
            difficultyModel.minEffectCost = closestDifficultyModel.minEffectCost;
        }
        if(difficultyModel.maxEffectCost == int.MinValue)
        {
            difficultyModel.maxEffectCost = closestDifficultyModel.maxEffectCost;
        }
        
        // Others
        if(difficultyModel.preparationPointsPenalty == int.MinValue)
        {
            difficultyModel.preparationPointsPenalty = -4 - (difficultyModel.index - 4) / 6;
        }
        
        // Modifiers
        List<AscensionModifierModel> modifiers = new List<AscensionModifierModel>();
        if (copyModifiersFromPreviousDifficulty)
        {
            modifiers.AddRange(closestDifficultyModel.modifiers);
        }
        modifiers.AddRange(ascensionModifiers.Select(a =>
        {
            if(a.Model.effect == null && a.EffectTypes != EffectTypes.None)
            {
                a.Model.effect = a.EffectTypes.ToEffectModel();
            }
            
            if(a.ShortDescription != null)
            {
                a.Model.shortDesc = a.ShortDescription;
            }
            if(a.Model.shortDesc == null)
            {
                a.Model.shortDesc = a.Model.effect.description;
            }
            return a.Model;
        }));
        difficultyModel.modifiers = modifiers.ToArray();
    }
}