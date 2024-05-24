using System.Collections.Generic;
using System.Linq;
using Eremite;
using Eremite.Model.Trade;

namespace ATS_API.Helpers;

// Generated using Version 1.3.4R
public enum TraderTypes
{
    Unknown = -1,
    None,
	API_ExampleMod_WildBill,         // Wild Bill
	Trader_Glade01,                  // Alune Soulgazer
	Trader_Glade02,                  // Gex Runescale
	Trader_Glade03,                  // Ruenhar Blightclaw
	Trader0_General,                 // Sahilda
	Trader1_FirstDawnCompany,        // Zhorg
	Trader2_BrassOrder,              // Old Farluf
	Trader3_Ancient,                 // Sothur The Ancient
	Trader4_VanguardOfTheStolenKeys, // Vliss Greybone
	Trader5_RoyalTradingCompany,     // Sir Renwald Redmane
	Trader6_WanderingMerchant,       // Xiadani Stormfeather
	Trader7_Trickster,               // Dullahan Warlander

    MAX
}

public static class TraderTypesExtensions
{
	public static string ToName(this TraderTypes type)
	{
		if (TypeToInternalName.TryGetValue(type, out var name))
		{
			return name;
		}

		Plugin.Log.LogError($"Cannot find name of TraderTypes: " + type);
		return TypeToInternalName[TraderTypes.API_ExampleMod_WildBill];
	}
	
	public static TraderModel ToTraderModel(this string name)
    {
        TraderModel model = SO.Settings.traders.FirstOrDefault(a=>a.name == name);
        if (model != null)
        {
            return model;
        }
    
        Plugin.Log.LogError("Cannot find TraderModel for TraderTypes with name: " + name);
        return null;
    }

	public static TraderModel ToTraderModel(this TraderTypes types)
	{
		return types.ToName().ToTraderModel();
	}
	
	public static TraderModel[] ToTraderModelArray(this IEnumerable<TraderTypes> collection)
    {
        int count = collection.Count();
        TraderModel[] array = new TraderModel[count];
        int i = 0;
        foreach (TraderTypes element in collection)
        {
            string elementName = element.ToName();
            array[i++] = SO.Settings.traders.FirstOrDefault(a=>a.name == elementName);
        }

        return array;
    }

	internal static readonly Dictionary<TraderTypes, string> TypeToInternalName = new()
	{
		{ TraderTypes.Trader_Glade01, "Trader - Glade 01" },                                       // Alune Soulgazer
		{ TraderTypes.Trader_Glade02, "Trader - Glade 02" },                                       // Gex Runescale
		{ TraderTypes.Trader_Glade03, "Trader - Glade 03" },                                       // Ruenhar Blightclaw
		{ TraderTypes.Trader0_General, "Trader 0 - General" },                                     // Sahilda
		{ TraderTypes.Trader1_FirstDawnCompany, "Trader 1 - First Dawn Company" },                 // Zhorg
		{ TraderTypes.Trader2_BrassOrder, "Trader 2 - Brass Order" },                              // Old Farluf
		{ TraderTypes.Trader3_Ancient, "Trader 3 - Ancient" },                                     // Sothur The Ancient
		{ TraderTypes.Trader4_VanguardOfTheStolenKeys, "Trader 4 - Vanguard of the Stolen Keys" }, // Vliss Greybone
		{ TraderTypes.Trader5_RoyalTradingCompany, "Trader 5 - Royal Trading Company" },           // Sir Renwald Redmane
		{ TraderTypes.Trader6_WanderingMerchant, "Trader 6 - Wandering Merchant" },                // Xiadani Stormfeather
		{ TraderTypes.Trader7_Trickster, "Trader 7 - Trickster" },                                 // Dullahan Warlander
	};
}
