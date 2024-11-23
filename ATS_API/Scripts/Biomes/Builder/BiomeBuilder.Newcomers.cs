using ATS_API.Helpers;
using UnityEngine;

namespace ATS_API.Biomes;

public partial class BiomeBuilder
{
    public BiomeBuilder SetNewcomerInterval(int seconds)
    {
        newBiome.newcomersInterval = seconds;
        return this;
    }

    /// <summary>
    /// How many newcomers arrive every interval 
    /// </summary>
    /// <param name="baseAmount">Starting amount</param>
    /// <param name="scaledAmount">How many extra newcomers arrive per year</param>
    public BiomeBuilder SetNewcomerAmount(Vector2Int baseAmount, Vector2 scaledAmount)
    {
        newBiome.newcomersBaseAmount = baseAmount;
        newBiome.newcomersExtraAmount = scaledAmount;
        return this;
    }

    /// <summary>
    /// How many goods the newcomers bring.
    /// Commonly 1-3
    /// </summary>
    public BiomeBuilder SetNewcomerAmountOfGoods(int min, int max)
    {
        newBiome.newcomerAmountOfGoods = new Vector2Int(min, max);
        return this;
    }

    /// <summary>
    /// Add a race that can arrive in this biome
    /// </summary>
    /// <param name="race">Race that can arrive</param>
    /// <param name="weight">0-100</param>
    public BiomeBuilder AddNewcomerRace(RaceTypes race, float weight)
    {
        newBiome.newcomersRaces.Add(new NewBiome.WeightedRace()
        {
            race = race,
            chance = weight
        });
        return this;
    }

    /// <summary>
    /// Adds a good that newcomers can bring
    /// </summary>
    public BiomeBuilder AddNewcomerGood(GoodsTypes good, int amount)
    {
        newBiome.newcomersGoodsAmount.Add(new NewBiome.GoodsTypeAmount()
        {
            goodType = good,
            amount = amount
        });
        return this;
    }
}