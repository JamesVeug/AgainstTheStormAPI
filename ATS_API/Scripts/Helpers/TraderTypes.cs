using System.Collections.Generic;

namespace ATS_API.Helpers;

public enum TraderTypes
{
    Sahilda,              // Trader 0 - General
    Aline_Soulgaser,      // Trader - Glade 01
    Gex_Runescale,        // Trader - Glade 02
    Renhar_Blightclaw,    // Trader - Glade 03
    Zhorg,                // Trader 1 - First Dawn Company
    Old_Farluf,           // Trader 2 - Brass Order
    Sothur_The_Ancient,   // Trader 3 - Ancient
    Viss_Greybone,        // Trader 4 - Vanguard of the Stolen Keys
    Sir_Renwald_Redmane,  // Trader 5 - Royal Trading Company
    Xiadani_Stormfeather, // Trader 6 - Wandering Merchant
    Trickster,            // Trader 7 - Trickster
}

public static class TraderTypesExtensions
{
    public static string ToName(this TraderTypes type)
    {
        if (TypeToInternalName.TryGetValue(type, out var name))
        {
            return name;
        }

        Plugin.Log.LogError($"Cannot find name of trader type: " + type);
        return TraderTypes.Sahilda.ToName();
    }

    internal static readonly Dictionary<TraderTypes, string> TypeToInternalName = new Dictionary<TraderTypes, string>()
    {
        { TraderTypes.Sahilda, "Trader 0 - General" },
        { TraderTypes.Aline_Soulgaser, "Trader - Glade 01" },
        { TraderTypes.Gex_Runescale, "Trader - Glade 02" },
        { TraderTypes.Renhar_Blightclaw, "Trader - Glade 03" },
        { TraderTypes.Zhorg, "Trader 1 - First Dawn Company" },
        { TraderTypes.Old_Farluf, "Trader 2 - Brass Order" },
        { TraderTypes.Sothur_The_Ancient, "Trader 3 - Ancient" },
        { TraderTypes.Viss_Greybone, "Trader 4 - Vanguard of the Stolen Keys" },
        { TraderTypes.Sir_Renwald_Redmane, "Trader 5 - Royal Trading Company" },
        { TraderTypes.Xiadani_Stormfeather, "Trader 6 - Wandering Merchant" },
        { TraderTypes.Trickster, "Trader 7 - Trickster" },
    };
}