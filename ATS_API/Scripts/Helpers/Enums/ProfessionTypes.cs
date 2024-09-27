using System;
using System.Collections.Generic;
using System.Linq;
using Eremite;
using Eremite.Model;

namespace ATS_API.Helpers;

// Generated using Version 1.4.4R
public enum ProfessionTypes
{
	Unknown = -1,
	None,
	Alchemist,                  // Alchemist
	Apothecary,                 // Apothecary
	Artisan,                    // Artisan
	Baker,                      // Baker
	Bath_House_Worker,          // Bath House Worker
	Beanery_Worker,             // Beanery Worker
	BlightFighter,              // Blight Fighter
	Brewery_Worker,             // Brewer
	Brickyard_Worker,           // Brickyard Worker
	Builder,                    // Builder
	Butcher,                    // Cook
	Cannery_Worker,             // Cannery Worker
	Carpenter,                  // Carpenter
	Cellar_Worker,              // Cellar Worker
	Clan_Mamber,                // Clan Steward
	Clay_Pit_Workshop_Worker,   // Clay Pit Digger
	Claypit_Digger,             // Clay Pit Digger
	Cobbler,                    // Cobbler
	Cook,                       // Cook
	Cooper,                     // Cooper
	Craftsman,                  // Craftsman
	Distillery_Worker,          // Distillery Worker
	Druid,                      // Druid
	Explorer,                   // Explorer
	Factory_Worker,             // Factory Worker
	Farmer,                     // Farmer
	Finesmith,                  // Finesmith
	FireKeeper,                 // Firekeeper
	Fisherman,                  // Fisherman
	Forager,                    // Forager
	Furnace_Worker,             // Furnace Worker
	Geologist,                  // Pump Operator
	Granary_Worker,             // Granary Worker
	Greenhouse_Worker,          // Greenhouse Worker
	Greenhouse_Workshop_Worker, // Greenhouse Worker
	Grill_Worker,               // Grill Worker
	Guild_Member,               // Guild Member
	Harvester,                  // Harvester
	Hauler,                     // Hauler
	Herbalist,                  // Herbalist
	Kiln_Worker,                // Kiln Worker
	Leatherworker,              // Leatherworker
	Librarian,                  // Librarian
	Lumbermill_Worker,          // Lumber Mill Worker
	Manufacturer,               // Manufactory Worker
	Mill_Worker,                // Miller
	Miner,                      // Miner
	Monk,                       // Monk
	Outfitter,                  // Supplier
	Oven_Worker,                // Brick Oven Worker
	Pantry_Worker,              // Pantry Worker
	Press_Worker,               // Press Worker
	Priest,                     // Priest
	Provisioner,                // Provisioner
	Rain_Catcher_Worker,        // Rain Collector Worker
	Rain_Collector_Worker,      // Rain Collector Worker
	Rancher,                    // Rancher
	Scavenger,                  // Scavenger
	Scout,                      // Scout
	Scribe,                     // Scribe
	Seller,                     // Seller
	Sewer,                      // Clothier
	Smelter,                    // Smelter
	Smith,                      // Smith
	Smokehouse_Worker,          // Smokehouse Worker
	Speaker,                    // Speaker
	Stamping_Mill_Worker,       // Stamping Mill Worker
	Stevedore,                  // Dockworker
	Stonecutter,                // Stonecutter
	Supplier,                   // Supplier
	Teadoctor,                  // Teadoctor
	Teahouse_Worker,            // Teahouse Worker
	Tinctury_Worker,            // Tinctury Worker
	Tinkerer,                   // Tinkerer
	Toolshop_Worker,            // Toolshop Worker
	Trapper,                    // Trapper
	Waiter,                     // Waiter
	Weaver,                     // Weaver
	Woodcutter,                 // Woodcutter


	MAX = 79
}

public static class ProfessionTypesExtensions
{
	private static ProfessionTypes[] s_All = null;
	public static ProfessionTypes[] All()
	{
		if (s_All == null)
		{
			s_All = new ProfessionTypes[79];
			for (int i = 0; i < 79; i++)
			{
				s_All[i] = (ProfessionTypes)(i+1);
			}
		}
		return s_All;
	}
	
	public static string ToName(this ProfessionTypes type)
	{
		if (TypeToInternalName.TryGetValue(type, out var name))
		{
			return name;
		}

		Plugin.Log.LogError($"Cannot find name of ProfessionTypes: " + type + "\n" + Environment.StackTrace);
		return TypeToInternalName[ProfessionTypes.Alchemist];
	}
	
	public static ProfessionTypes ToProfessionTypes(this string name)
	{
		foreach (KeyValuePair<ProfessionTypes,string> pair in TypeToInternalName)
		{
			if (pair.Value == name)
			{
				return pair.Key;
			}
		}

		Plugin.Log.LogWarning("Cannot find ProfessionTypes with name: " + name + "\n" + Environment.StackTrace);
		return ProfessionTypes.Unknown;
	}
	
	public static ProfessionModel ToProfessionModel(this string name)
	{
		ProfessionModel model = SO.Settings.Professions.FirstOrDefault(a=>a.name == name);
		if (model != null)
		{
			return model;
		}
	
		Plugin.Log.LogError("Cannot find ProfessionModel for ProfessionTypes with name: " + name + "\n" + Environment.StackTrace);
		return null;
	}

	public static ProfessionModel ToProfessionModel(this ProfessionTypes types)
	{
		return types.ToName().ToProfessionModel();
	}
	
	public static ProfessionModel[] ToProfessionModelArray(this IEnumerable<ProfessionTypes> collection)
	{
		int count = collection.Count();
		ProfessionModel[] array = new ProfessionModel[count];
		int i = 0;
		foreach (ProfessionTypes element in collection)
		{
			array[i++] = element.ToProfessionModel();
		}

		return array;
	}
	
	public static ProfessionModel[] ToProfessionModelArray(this IEnumerable<string> collection)
	{
		int count = collection.Count();
		ProfessionModel[] array = new ProfessionModel[count];
		int i = 0;
		foreach (string element in collection)
		{
			array[i++] = element.ToProfessionModel();
		}

		return array;
	}

	internal static readonly Dictionary<ProfessionTypes, string> TypeToInternalName = new()
	{
		{ ProfessionTypes.Alchemist, "Alchemist" },                                   // Alchemist
		{ ProfessionTypes.Apothecary, "Apothecary" },                                 // Apothecary
		{ ProfessionTypes.Artisan, "Artisan" },                                       // Artisan
		{ ProfessionTypes.Baker, "Baker" },                                           // Baker
		{ ProfessionTypes.Bath_House_Worker, "Bath House worker" },                   // Bath House Worker
		{ ProfessionTypes.Beanery_Worker, "Beanery Worker" },                         // Beanery Worker
		{ ProfessionTypes.BlightFighter, "BlightFighter" },                           // Blight Fighter
		{ ProfessionTypes.Brewery_Worker, "Brewery Worker" },                         // Brewer
		{ ProfessionTypes.Brickyard_Worker, "Brickyard Worker" },                     // Brickyard Worker
		{ ProfessionTypes.Builder, "Builder" },                                       // Builder
		{ ProfessionTypes.Butcher, "Butcher" },                                       // Cook
		{ ProfessionTypes.Cannery_Worker, "Cannery Worker" },                         // Cannery Worker
		{ ProfessionTypes.Carpenter, "Carpenter" },                                   // Carpenter
		{ ProfessionTypes.Cellar_Worker, "Cellar worker" },                           // Cellar Worker
		{ ProfessionTypes.Clan_Mamber, "Clan Mamber" },                               // Clan Steward
		{ ProfessionTypes.Clay_Pit_Workshop_Worker, "Clay Pit Workshop Worker" },     // Clay Pit Digger
		{ ProfessionTypes.Claypit_Digger, "Claypit Digger" },                         // Clay Pit Digger
		{ ProfessionTypes.Cobbler, "Cobbler" },                                       // Cobbler
		{ ProfessionTypes.Cook, "Cook" },                                             // Cook
		{ ProfessionTypes.Cooper, "Cooper" },                                         // Cooper
		{ ProfessionTypes.Craftsman, "Craftsman" },                                   // Craftsman
		{ ProfessionTypes.Distillery_Worker, "Distillery Worker" },                   // Distillery Worker
		{ ProfessionTypes.Druid, "Druid" },                                           // Druid
		{ ProfessionTypes.Explorer, "Explorer" },                                     // Explorer
		{ ProfessionTypes.Factory_Worker, "Factory Worker" },                         // Factory Worker
		{ ProfessionTypes.Farmer, "Farmer" },                                         // Farmer
		{ ProfessionTypes.Finesmith, "Finesmith" },                                   // Finesmith
		{ ProfessionTypes.FireKeeper, "FireKeeper" },                                 // Firekeeper
		{ ProfessionTypes.Fisherman, "Fisherman" },                                   // Fisherman
		{ ProfessionTypes.Forager, "Forager" },                                       // Forager
		{ ProfessionTypes.Furnace_Worker, "Furnace worker" },                         // Furnace Worker
		{ ProfessionTypes.Geologist, "Geologist" },                                   // Pump Operator
		{ ProfessionTypes.Granary_Worker, "Granary worker" },                         // Granary Worker
		{ ProfessionTypes.Greenhouse_Worker, "Greenhouse Worker" },                   // Greenhouse Worker
		{ ProfessionTypes.Greenhouse_Workshop_Worker, "Greenhouse Workshop Worker" }, // Greenhouse Worker
		{ ProfessionTypes.Grill_Worker, "Grill Worker" },                             // Grill Worker
		{ ProfessionTypes.Guild_Member, "Guild member" },                             // Guild Member
		{ ProfessionTypes.Harvester, "Harvester" },                                   // Harvester
		{ ProfessionTypes.Hauler, "Hauler" },                                         // Hauler
		{ ProfessionTypes.Herbalist, "Herbalist" },                                   // Herbalist
		{ ProfessionTypes.Kiln_Worker, "Kiln worker" },                               // Kiln Worker
		{ ProfessionTypes.Leatherworker, "Leatherworker" },                           // Leatherworker
		{ ProfessionTypes.Librarian, "Librarian" },                                   // Librarian
		{ ProfessionTypes.Lumbermill_Worker, "Lumbermill worker" },                   // Lumber Mill Worker
		{ ProfessionTypes.Manufacturer, "Manufacturer" },                             // Manufactory Worker
		{ ProfessionTypes.Mill_Worker, "Mill worker" },                               // Miller
		{ ProfessionTypes.Miner, "Miner" },                                           // Miner
		{ ProfessionTypes.Monk, "Monk" },                                             // Monk
		{ ProfessionTypes.Outfitter, "Outfitter" },                                   // Supplier
		{ ProfessionTypes.Oven_Worker, "Oven worker" },                               // Brick Oven Worker
		{ ProfessionTypes.Pantry_Worker, "Pantry worker" },                           // Pantry Worker
		{ ProfessionTypes.Press_Worker, "Press Worker" },                             // Press Worker
		{ ProfessionTypes.Priest, "Priest" },                                         // Priest
		{ ProfessionTypes.Provisioner, "Provisioner" },                               // Provisioner
		{ ProfessionTypes.Rain_Catcher_Worker, "Rain Catcher Worker" },               // Rain Collector Worker
		{ ProfessionTypes.Rain_Collector_Worker, "Rain Collector Worker" },           // Rain Collector Worker
		{ ProfessionTypes.Rancher, "Rancher" },                                       // Rancher
		{ ProfessionTypes.Scavenger, "Scavenger" },                                   // Scavenger
		{ ProfessionTypes.Scout, "Scout" },                                           // Scout
		{ ProfessionTypes.Scribe, "Scribe" },                                         // Scribe
		{ ProfessionTypes.Seller, "Seller" },                                         // Seller
		{ ProfessionTypes.Sewer, "Sewer" },                                           // Clothier
		{ ProfessionTypes.Smelter, "Smelter" },                                       // Smelter
		{ ProfessionTypes.Smith, "Smith" },                                           // Smith
		{ ProfessionTypes.Smokehouse_Worker, "Smokehouse worker" },                   // Smokehouse Worker
		{ ProfessionTypes.Speaker, "Speaker" },                                       // Speaker
		{ ProfessionTypes.Stamping_Mill_Worker, "Stamping Mill Worker" },             // Stamping Mill Worker
		{ ProfessionTypes.Stevedore, "Stevedore" },                                   // Dockworker
		{ ProfessionTypes.Stonecutter, "Stonecutter" },                               // Stonecutter
		{ ProfessionTypes.Supplier, "Supplier" },                                     // Supplier
		{ ProfessionTypes.Teadoctor, "Teadoctor" },                                   // Teadoctor
		{ ProfessionTypes.Teahouse_Worker, "Teahouse Worker" },                       // Teahouse Worker
		{ ProfessionTypes.Tinctury_Worker, "Tinctury Worker" },                       // Tinctury Worker
		{ ProfessionTypes.Tinkerer, "Tinkerer" },                                     // Tinkerer
		{ ProfessionTypes.Toolshop_Worker, "Toolshop Worker" },                       // Toolshop Worker
		{ ProfessionTypes.Trapper, "Trapper" },                                       // Trapper
		{ ProfessionTypes.Waiter, "Waiter" },                                         // Waiter
		{ ProfessionTypes.Weaver, "Weaver" },                                         // Weaver
		{ ProfessionTypes.Woodcutter, "Woodcutter" },                                 // Woodcutter

	};
}
