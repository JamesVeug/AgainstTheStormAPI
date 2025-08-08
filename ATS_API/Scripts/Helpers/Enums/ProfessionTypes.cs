using System;
using System.Linq;
using System.Collections.Generic;
using UnityEngine.Pool;
using Eremite;
using Eremite.Model;

// ReSharper disable All

namespace ATS_API.Helpers;

/// <summary>
/// Generated using Version 1.7.5R
/// </summary>
public enum ProfessionTypes
{
	/// <summary>
	/// Placeholder for an unknown ProfessionTypes. Typically, seen if a method failed to find some data .
	/// </summary>
	Unknown = -1,
	
	/// <summary>
	/// Placeholder for no ProfessionTypes. Typically, seen if nothing is defined or failed to parse a string to a ProfessionTypes.
	/// </summary>
	None = 0,
	
	/// <summary>
	/// Alchemist
	/// </summary>
	/// <name>Alchemist</name>
	Alchemist = 1,

	/// <summary>
	/// Apothecary
	/// </summary>
	/// <name>Apothecary</name>
	Apothecary = 2,

	/// <summary>
	/// Artisan
	/// </summary>
	/// <name>Artisan</name>
	Artisan = 3,

	/// <summary>
	/// Baker
	/// </summary>
	/// <name>Baker</name>
	Baker = 4,

	/// <summary>
	/// Bath House Worker
	/// </summary>
	/// <name>Bath House worker</name>
	Bath_House_Worker = 5,

	/// <summary>
	/// Beanery Worker
	/// </summary>
	/// <name>Beanery Worker</name>
	Beanery_Worker = 6,

	/// <summary>
	/// Blight Fighter
	/// </summary>
	/// <name>BlightFighter</name>
	BlightFighter = 7,

	/// <summary>
	/// Brewer
	/// </summary>
	/// <name>Brewery Worker</name>
	Brewery_Worker = 8,

	/// <summary>
	/// Brickyard Worker
	/// </summary>
	/// <name>Brickyard Worker</name>
	Brickyard_Worker = 9,

	/// <summary>
	/// Builder
	/// </summary>
	/// <name>Builder</name>
	Builder = 10,

	/// <summary>
	/// Cook
	/// </summary>
	/// <name>Butcher</name>
	Butcher = 11,

	/// <summary>
	/// Cannery Worker
	/// </summary>
	/// <name>Cannery Worker</name>
	Cannery_Worker = 12,

	/// <summary>
	/// Carpenter
	/// </summary>
	/// <name>Carpenter</name>
	Carpenter = 13,

	/// <summary>
	/// Cellar Worker
	/// </summary>
	/// <name>Cellar worker</name>
	Cellar_Worker = 14,

	/// <summary>
	/// Clan Steward
	/// </summary>
	/// <name>Clan Mamber</name>
	Clan_Mamber = 15,

	/// <summary>
	/// Clay Pit Digger
	/// </summary>
	/// <name>Clay Pit Workshop Worker</name>
	Clay_Pit_Workshop_Worker = 16,

	/// <summary>
	/// Clay Pit Digger
	/// </summary>
	/// <name>Claypit Digger</name>
	Claypit_Digger = 17,

	/// <summary>
	/// Cobbler
	/// </summary>
	/// <name>Cobbler</name>
	Cobbler = 18,

	/// <summary>
	/// Cook
	/// </summary>
	/// <name>Cook</name>
	Cook = 19,

	/// <summary>
	/// Cooper
	/// </summary>
	/// <name>Cooper</name>
	Cooper = 20,

	/// <summary>
	/// Craftsman
	/// </summary>
	/// <name>Craftsman</name>
	Craftsman = 21,

	/// <summary>
	/// Distillery Worker
	/// </summary>
	/// <name>Distillery Worker</name>
	Distillery_Worker = 22,

	/// <summary>
	/// Druid
	/// </summary>
	/// <name>Druid</name>
	Druid = 23,

	/// <summary>
	/// Engineer
	/// </summary>
	/// <name>Engineer</name>
	Engineer = 80,

	/// <summary>
	/// Explorer
	/// </summary>
	/// <name>Explorer</name>
	Explorer = 24,

	/// <summary>
	/// Factory Worker
	/// </summary>
	/// <name>Factory Worker</name>
	Factory_Worker = 25,

	/// <summary>
	/// Farmer
	/// </summary>
	/// <name>Farmer</name>
	Farmer = 26,

	/// <summary>
	/// Finesmith
	/// </summary>
	/// <name>Finesmith</name>
	Finesmith = 27,

	/// <summary>
	/// Firekeeper
	/// </summary>
	/// <name>FireKeeper</name>
	FireKeeper = 28,

	/// <summary>
	/// Fisherman
	/// </summary>
	/// <name>Fisherman</name>
	Fisherman = 29,

	/// <summary>
	/// Forager
	/// </summary>
	/// <name>Forager</name>
	Forager = 30,

	/// <summary>
	/// Furnace Worker
	/// </summary>
	/// <name>Furnace worker</name>
	Furnace_Worker = 31,

	/// <summary>
	/// Pump Operator
	/// </summary>
	/// <name>Geologist</name>
	Geologist = 32,

	/// <summary>
	/// Granary Worker
	/// </summary>
	/// <name>Granary worker</name>
	Granary_Worker = 33,

	/// <summary>
	/// Greenhouse Worker
	/// </summary>
	/// <name>Greenhouse Worker</name>
	Greenhouse_Worker = 34,

	/// <summary>
	/// Greenhouse Worker
	/// </summary>
	/// <name>Greenhouse Workshop Worker</name>
	Greenhouse_Workshop_Worker = 35,

	/// <summary>
	/// Grill Worker
	/// </summary>
	/// <name>Grill Worker</name>
	Grill_Worker = 36,

	/// <summary>
	/// Guild Member
	/// </summary>
	/// <name>Guild member</name>
	Guild_Member = 37,

	/// <summary>
	/// Harvester
	/// </summary>
	/// <name>Harvester</name>
	Harvester = 38,

	/// <summary>
	/// Hauler
	/// </summary>
	/// <name>Hauler</name>
	Hauler = 39,

	/// <summary>
	/// Herbalist
	/// </summary>
	/// <name>Herbalist</name>
	Herbalist = 40,

	/// <summary>
	/// Kiln Worker
	/// </summary>
	/// <name>Kiln worker</name>
	Kiln_Worker = 41,

	/// <summary>
	/// Leatherworker
	/// </summary>
	/// <name>Leatherworker</name>
	Leatherworker = 42,

	/// <summary>
	/// Librarian
	/// </summary>
	/// <name>Librarian</name>
	Librarian = 43,

	/// <summary>
	/// Lumber Mill Worker
	/// </summary>
	/// <name>Lumbermill worker</name>
	Lumbermill_Worker = 44,

	/// <summary>
	/// Manufactory Worker
	/// </summary>
	/// <name>Manufacturer</name>
	Manufacturer = 45,

	/// <summary>
	/// Miller
	/// </summary>
	/// <name>Mill worker</name>
	Mill_Worker = 46,

	/// <summary>
	/// Miner
	/// </summary>
	/// <name>Miner</name>
	Miner = 47,

	/// <summary>
	/// Monk
	/// </summary>
	/// <name>Monk</name>
	Monk = 48,

	/// <summary>
	/// Supplier
	/// </summary>
	/// <name>Outfitter</name>
	Outfitter = 49,

	/// <summary>
	/// Brick Oven Worker
	/// </summary>
	/// <name>Oven worker</name>
	Oven_Worker = 50,

	/// <summary>
	/// Pantry Worker
	/// </summary>
	/// <name>Pantry worker</name>
	Pantry_Worker = 51,

	/// <summary>
	/// Press Worker
	/// </summary>
	/// <name>Press Worker</name>
	Press_Worker = 52,

	/// <summary>
	/// Priest
	/// </summary>
	/// <name>Priest</name>
	Priest = 53,

	/// <summary>
	/// Provisioner
	/// </summary>
	/// <name>Provisioner</name>
	Provisioner = 54,

	/// <summary>
	/// Rain Collector Worker
	/// </summary>
	/// <name>Rain Catcher Worker</name>
	Rain_Catcher_Worker = 55,

	/// <summary>
	/// Rain Collector Worker
	/// </summary>
	/// <name>Rain Collector Worker</name>
	Rain_Collector_Worker = 56,

	/// <summary>
	/// Rancher
	/// </summary>
	/// <name>Rancher</name>
	Rancher = 57,

	/// <summary>
	/// Scavenger
	/// </summary>
	/// <name>Scavenger</name>
	Scavenger = 58,

	/// <summary>
	/// Scout
	/// </summary>
	/// <name>Scout</name>
	Scout = 59,

	/// <summary>
	/// Scribe
	/// </summary>
	/// <name>Scribe</name>
	Scribe = 60,

	/// <summary>
	/// Seller
	/// </summary>
	/// <name>Seller</name>
	Seller = 61,

	/// <summary>
	/// Clothier
	/// </summary>
	/// <name>Sewer</name>
	Sewer = 62,

	/// <summary>
	/// Smelter
	/// </summary>
	/// <name>Smelter</name>
	Smelter = 63,

	/// <summary>
	/// Smith
	/// </summary>
	/// <name>Smith</name>
	Smith = 64,

	/// <summary>
	/// Smokehouse Worker
	/// </summary>
	/// <name>Smokehouse worker</name>
	Smokehouse_Worker = 65,

	/// <summary>
	/// Speaker
	/// </summary>
	/// <name>Speaker</name>
	Speaker = 66,

	/// <summary>
	/// Stamping Mill Worker
	/// </summary>
	/// <name>Stamping Mill Worker</name>
	Stamping_Mill_Worker = 67,

	/// <summary>
	/// Dockworker
	/// </summary>
	/// <name>Stevedore</name>
	Stevedore = 68,

	/// <summary>
	/// Stonecutter
	/// </summary>
	/// <name>Stonecutter</name>
	Stonecutter = 69,

	/// <summary>
	/// Supplier
	/// </summary>
	/// <name>Supplier</name>
	Supplier = 70,

	/// <summary>
	/// Teadoctor
	/// </summary>
	/// <name>Teadoctor</name>
	Teadoctor = 71,

	/// <summary>
	/// Teahouse Worker
	/// </summary>
	/// <name>Teahouse Worker</name>
	Teahouse_Worker = 72,

	/// <summary>
	/// Tinctury Worker
	/// </summary>
	/// <name>Tinctury Worker</name>
	Tinctury_Worker = 73,

	/// <summary>
	/// Tinkerer
	/// </summary>
	/// <name>Tinkerer</name>
	Tinkerer = 74,

	/// <summary>
	/// Toolshop Worker
	/// </summary>
	/// <name>Toolshop Worker</name>
	Toolshop_Worker = 75,

	/// <summary>
	/// Trapper
	/// </summary>
	/// <name>Trapper</name>
	Trapper = 76,

	/// <summary>
	/// Waiter
	/// </summary>
	/// <name>Waiter</name>
	Waiter = 77,

	/// <summary>
	/// Waiter
	/// </summary>
	/// <name>Waiter - Funeral Event</name>
	Waiter_Funeral_Event = 81,

	/// <summary>
	/// Weaver
	/// </summary>
	/// <name>Weaver</name>
	Weaver = 78,

	/// <summary>
	/// Woodcutter
	/// </summary>
	/// <name>Woodcutter</name>
	Woodcutter = 79,



	/// <summary>
	/// The total number of vanilla ProfessionTypes in the game.
	/// </summary>
	[Obsolete("Use ProfessionTypesExtensions.Count(). ProfessionTypes.MAX requires rebuilding your project everytime the API adds/removes enums.", true)]
	MAX = 81
}

/// <summary>
/// Extension methods for the ProfessionTypes enum to simplify getting and converting data to various types.
/// </summary>
public static class ProfessionTypesExtensions
{
	/// <summary>
	/// Returns how many enum values are in ProfessionTypes.
	/// </summary>
	public static int Count()
	{
		return TypeToInternalName.Count;
	}
	
	/// <summary>
	/// Returns an array of all vanilla and modded ProfessionTypes.
	/// </summary>
	public static ProfessionTypes[] All()
	{
		ProfessionTypes[] all = new ProfessionTypes[TypeToInternalName.Count];
		TypeToInternalName.Keys.CopyTo(all, 0);
		return all;
	}
	
	/// <summary>
	/// Returns the name or internal ID of the model that will be used in the game.
	/// Every ProfessionTypes should have a unique name as to distinguish it from others.
	/// If no name is found, it will return ProfessionTypes.Alchemist in the enum and log an error.
	/// </summary>
	public static string ToName(this ProfessionTypes type)
	{
		if (TypeToInternalName.TryGetValue(type, out var name))
		{
			return name;
		}

		APILogger.LogError($"Cannot find name of ProfessionTypes: " + type);
		return TypeToInternalName[ProfessionTypes.Alchemist];
	}
	
	/// <summary>
	/// Returns a ProfessionTypes associated with the given name.
	/// Every ProfessionTypes should have a unique name as to distinguish it from others.
	/// If no ProfessionTypes is found, it will return ProfessionTypes.Unknown and log a warning.
	/// </summary>
	public static ProfessionTypes ToProfessionTypes(this string name)
	{
		foreach (KeyValuePair<ProfessionTypes,string> pair in TypeToInternalName)
		{
			if (pair.Value == name)
			{
				return pair.Key;
			}
		}

		APILogger.LogWarning("Cannot find ProfessionTypes with name: " + name + "\n" + Environment.StackTrace);
		return ProfessionTypes.Unknown;
	}
	
	/// <summary>
	/// Returns a ProfessionModel associated with the given name.
	/// ProfessionModel contain all the data that will be used in the game.
	/// Every ProfessionModel should have a unique name as to distinguish it from others.
	/// If no ProfessionModel is found, it will return null and log an error.
	/// </summary>
	public static Eremite.Model.ProfessionModel ToProfessionModel(this string name)
	{
		Eremite.Model.ProfessionModel model = SO.Settings.Professions.FirstOrDefault(a=>a.name == name);
		if (model != null)
		{
			return model;
		}
	
		APILogger.LogError("Cannot find ProfessionModel for ProfessionTypes with name: " + name);
		return null;
	}

	/// <summary>
	/// Returns a ProfessionModel associated with the given ProfessionTypes.
	/// ProfessionModel contain all the data that will be used in the game.
	/// Every ProfessionModel should have a unique name as to distinguish it from others.
	/// If no ProfessionModel is found, it will return null and log an error.
	/// </summary>
	public static Eremite.Model.ProfessionModel ToProfessionModel(this ProfessionTypes types)
	{
		return types.ToName().ToProfessionModel();
	}
	
	/// <summary>
	/// Returns an array of ProfessionModel associated with the given ProfessionTypes.
	/// ProfessionModel contain all the data that will be used in the game.
	/// Every ProfessionModel should have a unique name as to distinguish it from others.
	/// If a ProfessionModel is not found, the element will be replaced with null and an error will be logged.
	/// </summary>
	public static Eremite.Model.ProfessionModel[] ToProfessionModelArray(this IEnumerable<ProfessionTypes> collection)
	{
		int count = collection.Count();
		Eremite.Model.ProfessionModel[] array = new Eremite.Model.ProfessionModel[count];
		int i = 0;
		foreach (ProfessionTypes element in collection)
		{
			array[i++] = element.ToProfessionModel();
		}

		return array;
	}
	
	/// <summary>
	/// Returns an array of ProfessionModel associated with the given ProfessionTypes.
	/// ProfessionModel contain all the data that will be used in the game.
	/// Every ProfessionModel should have a unique name as to distinguish it from others.
	/// If a ProfessionModel is not found, the element will be replaced with null and an error will be logged.
	/// </summary>
	public static Eremite.Model.ProfessionModel[] ToProfessionModelArray(this IEnumerable<string> collection)
	{
		int count = collection.Count();
		Eremite.Model.ProfessionModel[] array = new Eremite.Model.ProfessionModel[count];
		int i = 0;
		foreach (string element in collection)
		{
			array[i++] = element.ToProfessionModel();
		}

		return array;
	}
	
	/// <summary>
	/// Returns an array of ProfessionModel associated with the given ProfessionTypes.
	/// ProfessionModel contain all the data that will be used in the game.
	/// Every ProfessionModel should have a unique name as to distinguish it from others.
	/// If a ProfessionModel is not found, it will not be included in the array.
	/// </summary>
	public static Eremite.Model.ProfessionModel[] ToProfessionModelArrayNoNulls(this IEnumerable<string> collection)
	{
		using(ListPool<Eremite.Model.ProfessionModel>.Get(out List<Eremite.Model.ProfessionModel> list))
		{
			foreach (string element in collection)
			{
				Eremite.Model.ProfessionModel model = element.ToProfessionModel();
				if (model != null)
				{
					list.Add(model);
				}
			}
			return list.ToArray();
		}
	}
	
	/// <summary>
	/// Returns an array of ProfessionModel associated with the given ProfessionTypes.
	/// ProfessionModel contain all the data that will be used in the game.
	/// Every ProfessionModel should have a unique name as to distinguish it from others.
	/// If a ProfessionModel is not found, it will not be included in the array.
	/// </summary>
	public static Eremite.Model.ProfessionModel[] ToProfessionModelArrayNoNulls(this IEnumerable<ProfessionTypes> collection)
	{
		using(ListPool<Eremite.Model.ProfessionModel>.Get(out List<Eremite.Model.ProfessionModel> list))
		{
			foreach (ProfessionTypes element in collection)
			{
				Eremite.Model.ProfessionModel model = element.ToProfessionModel();
				if (model != null)
				{
					list.Add(model);
				}
			}
			return list.ToArray();
		}
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
		{ ProfessionTypes.Engineer, "Engineer" },                                     // Engineer
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
		{ ProfessionTypes.Waiter_Funeral_Event, "Waiter - Funeral Event" },           // Waiter
		{ ProfessionTypes.Weaver, "Weaver" },                                         // Weaver
		{ ProfessionTypes.Woodcutter, "Woodcutter" },                                 // Woodcutter

	};
}
