using ATS_API.Helpers;
using UnityEngine;

namespace ATS_API.Biomes;

public partial class BiomeBuilder
{
    public void SetNewcomerInterval(int seconds)
    {
        newBiome.newcomersInterval = seconds;
    }

    /// <summary>
    /// How many newcomers arrive every interval 
    /// </summary>
    /// <param name="baseAmount">Starting amount</param>
    /// <param name="scaledAmount">How many extra newcomers arrive per year</param>
    public void SetNewcomerAmount(Vector2Int baseAmount, Vector2 scaledAmount)
    {
        newBiome.newcomersBaseAmount = baseAmount;
        newBiome.newcomersExtraAmount = scaledAmount;
    }

    /// <summary>
    /// How many goods the newcomers bring.
    /// Commonly 1-3
    /// </summary>
    public void SetNewcomerAmountOfGoods(int min, int max)
    {
        newBiome.newcomerAmountOfGoods = new Vector2Int(min, max);
    }

    /// <summary>
    /// Add a race that can arrive in this biome
    /// </summary>
    /// <param name="race">Race that can arrive</param>
    /// <param name="weight">0-100</param>
    public void AddNewcomerRace(RaceTypes race, float weight)
    {
        newBiome.newcomersRaces.Add(new NewBiome.WeightedRace()
        {
            race = race,
            chance = weight
        });
    }

    /// <summary>
    /// Adds a good that newcomers can bring
    /// </summary>
    public void AddNewcomerGood(GoodsTypes good, int amount)
    {
        newBiome.newcomersGoodsAmount.Add(new NewBiome.GoodsTypeAmount()
        {
            goodType = good,
            amount = amount
        });
    }
}