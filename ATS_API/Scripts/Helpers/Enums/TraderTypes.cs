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
	API_ExampleMod_Wild_Bill,               // Wild Bill
	Trader___Glade_01,                      // Alune Soulgazer
	Trader___Glade_02,                      // Gex Runescale
	Trader___Glade_03,                      // Ruenhar Blightclaw
	Trader_0___General,                     // Sahilda
	Trader_1___First_Dawn_Company,          // Zhorg
	Trader_2___Brass_Order,                 // Old Farluf
	Trader_3___Ancient,                     // Sothur The Ancient
	Trader_4___Vanguard_Of_The_Stolen_Keys, // Vliss Greybone
	Trader_5___Royal_Trading_Company,       // Sir Renwald Redmane
	Trader_6___Wandering_Merchant,          // Xiadani Stormfeather
	Trader_7___Trickster,                   // Dullahan Warlander

    MAX = 12
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
		return TypeToInternalName[TraderTypes.API_ExampleMod_Wild_Bill];
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
		{ TraderTypes.API_ExampleMod_Wild_Bill, "API_ExampleMod_Wild Bill" },                             // Wild Bill
		{ TraderTypes.Trader___Glade_01, "Trader - Glade 01" },                                           // Alune Soulgazer
		{ TraderTypes.Trader___Glade_02, "Trader - Glade 02" },                                           // Gex Runescale
		{ TraderTypes.Trader___Glade_03, "Trader - Glade 03" },                                           // Ruenhar Blightclaw
		{ TraderTypes.Trader_0___General, "Trader 0 - General" },                                         // Sahilda
		{ TraderTypes.Trader_1___First_Dawn_Company, "Trader 1 - First Dawn Company" },                   // Zhorg
		{ TraderTypes.Trader_2___Brass_Order, "Trader 2 - Brass Order" },                                 // Old Farluf
		{ TraderTypes.Trader_3___Ancient, "Trader 3 - Ancient" },                                         // Sothur The Ancient
		{ TraderTypes.Trader_4___Vanguard_Of_The_Stolen_Keys, "Trader 4 - Vanguard of the Stolen Keys" }, // Vliss Greybone
		{ TraderTypes.Trader_5___Royal_Trading_Company, "Trader 5 - Royal Trading Company" },             // Sir Renwald Redmane
		{ TraderTypes.Trader_6___Wandering_Merchant, "Trader 6 - Wandering Merchant" },                   // Xiadani Stormfeather
		{ TraderTypes.Trader_7___Trickster, "Trader 7 - Trickster" },                                     // Dullahan Warlander
	};
}
