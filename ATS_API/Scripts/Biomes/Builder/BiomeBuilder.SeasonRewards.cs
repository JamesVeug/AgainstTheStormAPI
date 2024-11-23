using System.Linq;
using ATS_API.Helpers;
using Eremite.Model;

namespace ATS_API.Biomes;

public partial class BiomeBuilder
{
    public void SetSeasonDuration(SeasonTypes seasonType, int time)
    {
        NewBiome.seasonData.Find(a=>a.season == seasonType).duration = time;
    }
    
    /// <summary>
    /// Used when the player wants to decline the cornerstones.
    /// </summary>
    /// <param name="goodsTypes"></param>
    /// <param name="amount"></param>
    public void SetDeclinedSeasonalRewardsReward(GoodsTypes goodsTypes, int amount)
    {
        NewBiome.declineSeasonRewardsReward.goodType = goodsTypes;
        NewBiome.declineSeasonRewardsReward.amount = amount;
    }

    /// <summary>
    /// Adds a reward as a possible cornerstone it can get at the end of a seasons quarter.
    /// </summary>
    /// <param name="effect"></param>
    /// <param name="chance">Between 1 and 100</param>
    /// <param name="year">Which year this reward can be obtained. Default: 1</param>
    /// <param name="quarter">Which quarter of the year the reward can be obtained. Default: First</param>
    /// <param name="season">Which season can the player get the reward from. default: Drizzle</param>
    public void AddSeasonalReward(EffectTypes effect, ushort chance = 50, int year = 1, SeasonQuarter quarter = SeasonQuarter.First,
        Season season = Season.Drizzle)
    {
        NewBiome.SeasonRewards rewards =
            NewBiome.seasonRewards.FirstOrDefault(a => a.Year == year && a.Quarter == quarter && a.Season == season);
        if (rewards == null)
        {
            rewards = new NewBiome.SeasonRewards
            {
                Year = year,
                Quarter = quarter,
                Season = season
            };
            NewBiome.seasonRewards.Add(rewards);
        }


        NewBiome.WeightedEffectType effectType = new NewBiome.WeightedEffectType
        {
            effectType = effect,
            weight = chance
        };
        rewards.Effects.Add(effectType);
    }

    /// <summary>
    /// Cornerstones the player will always be able to choose from
    /// </summary>
    public void AddGuaranteedSeasonalReward(EffectTypes effect, int year = 1, SeasonQuarter quarter = SeasonQuarter.First,
        Season season = Season.Drizzle)
    {
        NewBiome.SeasonRewards rewards =
            NewBiome.seasonRewards.FirstOrDefault(a => a.Year == year && a.Quarter == quarter && a.Season == season);
        if (rewards == null)
        {
            rewards = new NewBiome.SeasonRewards
            {
                Year = year,
                Quarter = quarter,
                Season = season
            };
            NewBiome.seasonRewards.Add(rewards);
        }

        rewards.GuaranteedEffects.Add(effect);
    }
}