using System.Collections.Generic;
using System.Linq;
using Eremite;
using Eremite.Model;

namespace ATS_API.Helpers;

// Generated using Version 1.3.4R
public enum ProfessionTypes
{
    Unknown = -1,
    None,
	Alchemist,                // Alchemist
	Apothecary,               // Apothecary
	Artisan,                  // Artisan
	Baker,                    // Baker
	BathHouseWorker,          // Bath House Worker
	BeaneryWorker,            // Beanery Worker
	BlightFighter,            // Blight Fighter
	BreweryWorker,            // Brewer
	BrickyardWorker,          // Brickyard Worker
	Builder,                  // Builder
	Butcher,                  // Cook
	Carpenter,                // Carpenter
	CellarWorker,             // Cellar Worker
	ClanMamber,               // Clan Steward
	ClaypitDigger,            // Clay Pit Digger
	ClayPitWorkshopWorker,    // Clay Pit Digger
	Cook,                     // Cook
	Cooper,                   // Cooper
	Craftsman,                // Craftsman
	DistilleryWorker,         // Distillery Worker
	Druid,                    // Druid
	Explorer,                 // Explorer
	FactoryWorker,            // Factory Worker
	Farmer,                   // Farmer
	Finesmith,                // Finesmith
	FireKeeper,               // Firekeeper
	Forager,                  // Forager
	FurnaceWorker,            // Furnace Worker
	Geologist,                // Pump Operator
	GranaryWorker,            // Granary Worker
	GreenhouseWorker,         // Greenhouse Worker
	GreenhouseWorkshopWorker, // Greenhouse Worker
	GrillWorker,              // Grill Worker
	GuildMember,              // Guild Member
	Harvester,                // Harvester
	Hauler,                   // Hauler
	Herbalist,                // Herbalist
	KilnWorker,               // Kiln Worker
	Leatherworker,            // Leatherworker
	Librarian,                // Librarian
	LumbermillWorker,         // Lumber Mill Worker
	Manufacturer,             // Manufactory Worker
	MillWorker,               // Miller
	Miner,                    // Miner
	Monk,                     // Monk
	Outfitter,                // Supplier
	OvenWorker,               // Brick Oven Worker
	PantryWorker,             // Pantry Worker
	PressWorker,              // Press Worker
	Priest,                   // Priest
	Provisioner,              // Provisioner
	RainCatcherWorker,        // Rain Collector Worker
	RainCollectorWorker,      // Rain Collector Worker
	Rancher,                  // Rancher
	Scavenger,                // Scavenger
	Scout,                    // Scout
	Scribe,                   // Scribe
	Seller,                   // Seller
	Sewer,                    // Clothier
	Smelter,                  // Smelter
	Smith,                    // Smith
	SmokehouseWorker,         // Smokehouse Worker
	Speaker,                  // Speaker
	StampingMillWorker,       // Stamping Mill Worker
	Stonecutter,              // Stonecutter
	Supplier,                 // Supplier
	Teadoctor,                // Teadoctor
	TeahouseWorker,           // Teahouse Worker
	TincturyWorker,           // Tinctury Worker
	Tinkerer,                 // Tinkerer
	ToolshopWorker,           // Toolshop Worker
	Trapper,                  // Trapper
	Waiter,                   // Waiter
	Weaver,                   // Weaver
	Woodcutter,               // Woodcutter

    MAX
}

public static class ProfessionTypesExtensions
{
	public static string ToName(this ProfessionTypes type)
	{
		if (TypeToInternalName.TryGetValue(type, out var name))
		{
			return name;
		}

		Plugin.Log.LogError($"Cannot find name of ProfessionTypes: " + type);
		return TypeToInternalName[ProfessionTypes.Alchemist];
	}
	
	public static ProfessionModel ToProfessionModel(this string name)
    {
        ProfessionModel model = SO.Settings.Professions.FirstOrDefault(a=>a.name == name);
        if (model != null)
        {
            return model;
        }
    
        Plugin.Log.LogError("Cannot find ProfessionModel for ProfessionTypes with name: " + name);
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
            string elementName = element.ToName();
            array[i++] = SO.Settings.Professions.FirstOrDefault(a=>a.name == elementName);
        }

        return array;
    }

	internal static readonly Dictionary<ProfessionTypes, string> TypeToInternalName = new()
	{
		{ ProfessionTypes.Alchemist, "Alchemist" },                                 // Alchemist
		{ ProfessionTypes.Apothecary, "Apothecary" },                               // Apothecary
		{ ProfessionTypes.Artisan, "Artisan" },                                     // Artisan
		{ ProfessionTypes.Baker, "Baker" },                                         // Baker
		{ ProfessionTypes.BathHouseWorker, "Bath House worker" },                   // Bath House Worker
		{ ProfessionTypes.BeaneryWorker, "Beanery Worker" },                        // Beanery Worker
		{ ProfessionTypes.BlightFighter, "BlightFighter" },                         // Blight Fighter
		{ ProfessionTypes.BreweryWorker, "Brewery Worker" },                        // Brewer
		{ ProfessionTypes.BrickyardWorker, "Brickyard Worker" },                    // Brickyard Worker
		{ ProfessionTypes.Builder, "Builder" },                                     // Builder
		{ ProfessionTypes.Butcher, "Butcher" },                                     // Cook
		{ ProfessionTypes.Carpenter, "Carpenter" },                                 // Carpenter
		{ ProfessionTypes.CellarWorker, "Cellar worker" },                          // Cellar Worker
		{ ProfessionTypes.ClanMamber, "Clan Mamber" },                              // Clan Steward
		{ ProfessionTypes.ClaypitDigger, "Claypit Digger" },                        // Clay Pit Digger
		{ ProfessionTypes.ClayPitWorkshopWorker, "Clay Pit Workshop Worker" },      // Clay Pit Digger
		{ ProfessionTypes.Cook, "Cook" },                                           // Cook
		{ ProfessionTypes.Cooper, "Cooper" },                                       // Cooper
		{ ProfessionTypes.Craftsman, "Craftsman" },                                 // Craftsman
		{ ProfessionTypes.DistilleryWorker, "Distillery Worker" },                  // Distillery Worker
		{ ProfessionTypes.Druid, "Druid" },                                         // Druid
		{ ProfessionTypes.Explorer, "Explorer" },                                   // Explorer
		{ ProfessionTypes.FactoryWorker, "Factory Worker" },                        // Factory Worker
		{ ProfessionTypes.Farmer, "Farmer" },                                       // Farmer
		{ ProfessionTypes.Finesmith, "Finesmith" },                                 // Finesmith
		{ ProfessionTypes.FireKeeper, "FireKeeper" },                               // Firekeeper
		{ ProfessionTypes.Forager, "Forager" },                                     // Forager
		{ ProfessionTypes.FurnaceWorker, "Furnace worker" },                        // Furnace Worker
		{ ProfessionTypes.Geologist, "Geologist" },                                 // Pump Operator
		{ ProfessionTypes.GranaryWorker, "Granary worker" },                        // Granary Worker
		{ ProfessionTypes.GreenhouseWorker, "Greenhouse Worker" },                  // Greenhouse Worker
		{ ProfessionTypes.GreenhouseWorkshopWorker, "Greenhouse Workshop Worker" }, // Greenhouse Worker
		{ ProfessionTypes.GrillWorker, "Grill Worker" },                            // Grill Worker
		{ ProfessionTypes.GuildMember, "Guild member" },                            // Guild Member
		{ ProfessionTypes.Harvester, "Harvester" },                                 // Harvester
		{ ProfessionTypes.Hauler, "Hauler" },                                       // Hauler
		{ ProfessionTypes.Herbalist, "Herbalist" },                                 // Herbalist
		{ ProfessionTypes.KilnWorker, "Kiln worker" },                              // Kiln Worker
		{ ProfessionTypes.Leatherworker, "Leatherworker" },                         // Leatherworker
		{ ProfessionTypes.Librarian, "Librarian" },                                 // Librarian
		{ ProfessionTypes.LumbermillWorker, "Lumbermill worker" },                  // Lumber Mill Worker
		{ ProfessionTypes.Manufacturer, "Manufacturer" },                           // Manufactory Worker
		{ ProfessionTypes.MillWorker, "Mill worker" },                              // Miller
		{ ProfessionTypes.Miner, "Miner" },                                         // Miner
		{ ProfessionTypes.Monk, "Monk" },                                           // Monk
		{ ProfessionTypes.Outfitter, "Outfitter" },                                 // Supplier
		{ ProfessionTypes.OvenWorker, "Oven worker" },                              // Brick Oven Worker
		{ ProfessionTypes.PantryWorker, "Pantry worker" },                          // Pantry Worker
		{ ProfessionTypes.PressWorker, "Press Worker" },                            // Press Worker
		{ ProfessionTypes.Priest, "Priest" },                                       // Priest
		{ ProfessionTypes.Provisioner, "Provisioner" },                             // Provisioner
		{ ProfessionTypes.RainCatcherWorker, "Rain Catcher Worker" },               // Rain Collector Worker
		{ ProfessionTypes.RainCollectorWorker, "Rain Collector Worker" },           // Rain Collector Worker
		{ ProfessionTypes.Rancher, "Rancher" },                                     // Rancher
		{ ProfessionTypes.Scavenger, "Scavenger" },                                 // Scavenger
		{ ProfessionTypes.Scout, "Scout" },                                         // Scout
		{ ProfessionTypes.Scribe, "Scribe" },                                       // Scribe
		{ ProfessionTypes.Seller, "Seller" },                                       // Seller
		{ ProfessionTypes.Sewer, "Sewer" },                                         // Clothier
		{ ProfessionTypes.Smelter, "Smelter" },                                     // Smelter
		{ ProfessionTypes.Smith, "Smith" },                                         // Smith
		{ ProfessionTypes.SmokehouseWorker, "Smokehouse worker" },                  // Smokehouse Worker
		{ ProfessionTypes.Speaker, "Speaker" },                                     // Speaker
		{ ProfessionTypes.StampingMillWorker, "Stamping Mill Worker" },             // Stamping Mill Worker
		{ ProfessionTypes.Stonecutter, "Stonecutter" },                             // Stonecutter
		{ ProfessionTypes.Supplier, "Supplier" },                                   // Supplier
		{ ProfessionTypes.Teadoctor, "Teadoctor" },                                 // Teadoctor
		{ ProfessionTypes.TeahouseWorker, "Teahouse Worker" },                      // Teahouse Worker
		{ ProfessionTypes.TincturyWorker, "Tinctury Worker" },                      // Tinctury Worker
		{ ProfessionTypes.Tinkerer, "Tinkerer" },                                   // Tinkerer
		{ ProfessionTypes.ToolshopWorker, "Toolshop Worker" },                      // Toolshop Worker
		{ ProfessionTypes.Trapper, "Trapper" },                                     // Trapper
		{ ProfessionTypes.Waiter, "Waiter" },                                       // Waiter
		{ ProfessionTypes.Weaver, "Weaver" },                                       // Weaver
		{ ProfessionTypes.Woodcutter, "Woodcutter" },                               // Woodcutter
	};
}
