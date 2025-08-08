using System;
using System.Linq;
using System.Collections.Generic;
using UnityEngine.Pool;
using Eremite;
using Eremite.Model.Orders;

// ReSharper disable All

namespace ATS_API.Helpers;

/// <summary>
/// Generated using Version 1.8.10R
/// </summary>
public enum OrderTypes
{
	/// <summary>
	/// Placeholder for an unknown OrderTypes. Typically, seen if a method failed to find some data .
	/// </summary>
	Unknown = -1,
	
	/// <summary>
	/// Placeholder for no OrderTypes. Typically, seen if nothing is defined or failed to parse a string to a OrderTypes.
	/// </summary>
	None = 0,
	
	/// <summary>
	/// Essence of Wealth
	/// </summary>
	/// <name>Amber and Luxury LOW</name>
	Amber_And_Luxury_LOW = 1,

	/// <summary>
	/// Crystal Feathers
	/// </summary>
	/// <name>Amber Transaction</name>
	Amber_Transaction = 2,

	/// <summary>
	/// Crystal Feathers
	/// </summary>
	/// <name>Amber Transaction HIGH</name>
	Amber_Transaction_HIGH = 3,

	/// <summary>
	/// Crystal Feathers
	/// </summary>
	/// <name>Amber Transaction LOW</name>
	Amber_Transaction_LOW = 4,

	/// <summary>
	/// Forbidden Essence
	/// </summary>
	/// <name>Ancient Tablets</name>
	Ancient_Tablets = 5,

	/// <summary>
	/// Forbidden Essence
	/// </summary>
	/// <name>Ancient Tablets HIGH</name>
	Ancient_Tablets_HIGH = 6,

	/// <summary>
	/// Forbidden Essence
	/// </summary>
	/// <name>Ancient Tablets LOW</name>
	Ancient_Tablets_LOW = 7,

	/// <summary>
	/// Heart of the Forest
	/// </summary>
	/// <name>Caches</name>
	Caches = 8,

	/// <summary>
	/// Heart of the Forest
	/// </summary>
	/// <name>Caches HIGH</name>
	Caches_HIGH = 9,

	/// <summary>
	/// Heart of the Forest
	/// </summary>
	/// <name>Caches LOW</name>
	Caches_LOW = 10,

	/// <summary>
	/// Essence of Corruption
	/// </summary>
	/// <name>CystsBurned</name>
	CystsBurned = 11,

	/// <summary>
	/// Heart of Amber
	/// </summary>
	/// <name>Deliver Packs</name>
	Deliver_Packs = 12,

	/// <summary>
	/// Heart of Amber
	/// </summary>
	/// <name>Deliver Packs HIGH</name>
	Deliver_Packs_HIGH = 13,

	/// <summary>
	/// Heart of Amber
	/// </summary>
	/// <name>Deliver Packs LOW</name>
	Deliver_Packs_LOW = 14,

	/// <summary>
	/// Metal Feathers
	/// </summary>
	/// <name>Deliver Tools</name>
	Deliver_Tools = 15,

	/// <summary>
	/// Metal Feathers
	/// </summary>
	/// <name>Deliver Tools HIGH</name>
	Deliver_Tools_HIGH = 16,

	/// <summary>
	/// Stormbird Feathers
	/// </summary>
	/// <name>Discover Forbidden LOW</name>
	Discover_Forbidden_LOW = 17,

	/// <summary>
	/// Mechanical Heart
	/// </summary>
	/// <name>Engines Connected</name>
	Engines_Connected = 18,

	/// <summary>
	/// Mechanical Heart
	/// </summary>
	/// <name>Engines Connected HIGH</name>
	Engines_Connected_HIGH = 19,

	/// <summary>
	/// Heart of the Ancient Flame
	/// </summary>
	/// <name>Heart Parts and Sacrifice LOW</name>
	Heart_Parts_And_Sacrifice_LOW = 20,

	/// <summary>
	/// Amber Trade
	/// </summary>
	/// <name>I Amber</name>
	/// <usabilityTags>[Tag] Trade</usabilityTags>
	I_Amber = 21,

	/// <summary>
	/// Call to Arms
	/// </summary>
	/// <name>I Blighfuel</name>
	/// <usabilityTags>[Tag] Blight</usabilityTags>
	I_Blighfuel = 22,

	/// <summary>
	/// Blue Metal
	/// </summary>
	/// <name>I Blue Metal</name>
	I_Blue_Metal = 23,

	/// <summary>
	/// Botanist
	/// </summary>
	/// <name>I Botanist</name>
	/// <usabilityTags>[Tag] Requires Fertile Soil</usabilityTags>
	I_Botanist = 24,

	/// <summary>
	/// Clearing Glades
	/// </summary>
	/// <name>I Clearing Glades</name>
	I_Clearing_Glades = 25,

	/// <summary>
	/// Rain Protection
	/// </summary>
	/// <name>I Clothing</name>
	I_Clothing = 26,

	/// <summary>
	/// The Purge
	/// </summary>
	/// <name>I Cysts</name>
	/// <usabilityTags>[Tag] Rainpunk, [Tag] Blight</usabilityTags>
	I_Cysts = 27,

	/// <summary>
	/// Cyst Cultivation
	/// </summary>
	/// <name>I Cysts amount</name>
	/// <usabilityTags>[Tag] Rainpunk, [Tag] Blight</usabilityTags>
	I_Cysts_Amount = 28,

	/// <summary>
	/// Egg Collection
	/// </summary>
	/// <name>I Eggs</name>
	I_Eggs = 29,

	/// <summary>
	/// Start Your Engines
	/// </summary>
	/// <name>I Engines</name>
	/// <usabilityTags>[Tag] Rainpunk</usabilityTags>
	I_Engines = 30,

	/// <summary>
	/// Farm Life
	/// </summary>
	/// <name>I Farm Life</name>
	/// <usabilityTags>[Tag] Requires Fertile Soil</usabilityTags>
	I_Farm_Life = 31,

	/// <summary>
	/// Foragers' Camp
	/// </summary>
	/// <name>I Foragers Camp</name>
	I_Foragers_Camp = 32,

	/// <summary>
	/// Funding the Expedition
	/// </summary>
	/// <name>I Funding the Expedition</name>
	I_Funding_The_Expedition = 33,

	/// <summary>
	/// Garden Life
	/// </summary>
	/// <name>I Garden Life</name>
	/// <usabilityTags>[Tag] Requires Fertile Soil</usabilityTags>
	I_Garden_Life = 34,

	/// <summary>
	/// Herbalist
	/// </summary>
	/// <name>I Herbalist</name>
	I_Herbalist = 35,

	/// <summary>
	/// No Place Like Home
	/// </summary>
	/// <name>I Houses</name>
	/// <usabilityTags>[Tag] Lizzard, [Tag] Harpy</usabilityTags>
	I_Houses = 36,

	/// <summary>
	/// Safe Place
	/// </summary>
	/// <name>I Houses v2</name>
	/// <usabilityTags>[Tag] Beaver, [Tag] Human</usabilityTags>
	I_Houses_V2 = 37,

	/// <summary>
	/// Dwellings
	/// </summary>
	/// <name>I Houses v3</name>
	/// <usabilityTags>[Tag] Fox, [Tag] Bat</usabilityTags>
	I_Houses_V3 = 392,

	/// <summary>
	/// Hunters
	/// </summary>
	/// <name>I Hunters</name>
	I_Hunters = 38,

	/// <summary>
	/// Meat Lover
	/// </summary>
	/// <name>I Jerky</name>
	I_Jerky = 39,

	/// <summary>
	/// Metal Veins
	/// </summary>
	/// <name>I Metal Veins</name>
	I_Metal_Veins = 40,

	/// <summary>
	/// Raising the Stakes
	/// </summary>
	/// <name>I Multiply Routes</name>
	/// <usabilityTags>[Tag] Trade</usabilityTags>
	I_Multiply_Routes = 41,

	/// <summary>
	/// Hydraulics
	/// </summary>
	/// <name>I Pipes</name>
	/// <usabilityTags>[Tag] Rainpunk</usabilityTags>
	I_Pipes = 42,

	/// <summary>
	/// Healthy Breakfast
	/// </summary>
	/// <name>I Porridge</name>
	/// <usabilityTags>[Tag] Fox, [Tag] Human</usabilityTags>
	I_Porridge = 43,

	/// <summary>
	/// Beginner Engineer
	/// </summary>
	/// <name>I Pump</name>
	I_Pump = 44,

	/// <summary>
	/// Ranch Life
	/// </summary>
	/// <name>I Ranch Life</name>
	I_Ranch_Life = 45,

	/// <summary>
	/// The Guild
	/// </summary>
	/// <name>I Resolve Beavers</name>
	/// <usabilityTags>[Tag] Beaver</usabilityTags>
	I_Resolve_Beavers = 46,

	/// <summary>
	/// The Pack
	/// </summary>
	/// <name>I Resolve Foxes</name>
	/// <usabilityTags>[Tag] Fox</usabilityTags>
	I_Resolve_Foxes = 47,

	/// <summary>
	/// The Collegium
	/// </summary>
	/// <name>I Resolve Frogs</name>
	/// <usabilityTags>[Tag] Frog</usabilityTags>
	I_Resolve_Frogs = 48,

	/// <summary>
	/// The Flock
	/// </summary>
	/// <name>I Resolve Harpies</name>
	/// <usabilityTags>[Tag] Harpy</usabilityTags>
	I_Resolve_Harpies = 49,

	/// <summary>
	/// People's Resolve
	/// </summary>
	/// <name>I Resolve Humans</name>
	/// <usabilityTags>[Tag] Human</usabilityTags>
	I_Resolve_Humans = 50,

	/// <summary>
	/// The Clan
	/// </summary>
	/// <name>I Resolve Lizards</name>
	/// <usabilityTags>[Tag] Lizzard</usabilityTags>
	I_Resolve_Lizards = 51,

	/// <summary>
	/// Reconnaissance
	/// </summary>
	/// <name>I Ruins</name>
	I_Ruins = 52,

	/// <summary>
	/// Salt Miner
	/// </summary>
	/// <name>I Salt</name>
	I_Salt = 53,

	/// <summary>
	/// Barbecue
	/// </summary>
	/// <name>I Skewers</name>
	I_Skewers = 54,

	/// <summary>
	/// Problem Solver
	/// </summary>
	/// <name>I Solve Any Relic</name>
	I_Solve_Any_Relic = 55,

	/// <summary>
	/// Tick Tock
	/// </summary>
	/// <name>I Solve Dangerous Relic</name>
	I_Solve_Dangerous_Relic = 56,

	/// <summary>
	/// Basic Ingredient
	/// </summary>
	/// <name>I Storm Water</name>
	I_Storm_Water = 57,

	/// <summary>
	/// Determined Bats
	/// </summary>
	/// <name>I TO Bat Resolve</name>
	/// <usabilityTags>[Tag] Bat</usabilityTags>
	I_TO_Bat_Resolve = 393,

	/// <summary>
	/// Joyful Beavers
	/// </summary>
	/// <name>I TO Beaver Resolve</name>
	/// <usabilityTags>[Tag] Beaver</usabilityTags>
	I_TO_Beaver_Resolve = 58,

	/// <summary>
	/// Zealous Scouts
	/// </summary>
	/// <name>I TO Dangerous Relics</name>
	I_TO_Dangerous_Relics = 59,

	/// <summary>
	/// Joyful Foxes
	/// </summary>
	/// <name>I TO Fox Resolve</name>
	/// <usabilityTags>[Tag] Fox</usabilityTags>
	I_TO_Fox_Resolve = 60,

	/// <summary>
	/// Joyful Frogs
	/// </summary>
	/// <name>I TO Frog Resolve</name>
	/// <usabilityTags>[Tag] Frog</usabilityTags>
	I_TO_Frog_Resolve = 61,

	/// <summary>
	/// Joyful Harpies
	/// </summary>
	/// <name>I TO Harpy Resolve</name>
	/// <usabilityTags>[Tag] Harpy</usabilityTags>
	I_TO_Harpy_Resolve = 62,

	/// <summary>
	/// Speedy Real Estate
	/// </summary>
	/// <name>I TO HUB</name>
	I_TO_HUB = 63,

	/// <summary>
	/// Joyful Humans
	/// </summary>
	/// <name>I TO Human Resolve</name>
	/// <usabilityTags>[Tag] Human</usabilityTags>
	I_TO_Human_Resolve = 64,

	/// <summary>
	/// Joyful Lizards
	/// </summary>
	/// <name>I TO Lizard Resolve</name>
	/// <usabilityTags>[Tag] Lizzard</usabilityTags>
	I_TO_Lizard_Resolve = 65,

	/// <summary>
	/// Hurried Expedition
	/// </summary>
	/// <name>I TO Relic Resolve</name>
	I_TO_Relic_Resolve = 66,

	/// <summary>
	/// Call of the Ruins
	/// </summary>
	/// <name>I TO Ruins and Glades</name>
	I_TO_Ruins_And_Glades = 67,

	/// <summary>
	/// Quick Transaction
	/// </summary>
	/// <name>I TO Sold Amber</name>
	/// <usabilityTags>[Tag] Trade</usabilityTags>
	I_TO_Sold_Amber = 68,

	/// <summary>
	/// Impetuous Explorer
	/// </summary>
	/// <name>I TO Solve Relics</name>
	I_TO_Solve_Relics = 69,

	/// <summary>
	/// Supply Thy Neighbor
	/// </summary>
	/// <name>I TO Trade Routes With Value</name>
	I_TO_Trade_Routes_With_Value = 70,

	/// <summary>
	/// Businessman
	/// </summary>
	/// <name>I Trade Routes</name>
	/// <usabilityTags>[Tag] Trade</usabilityTags>
	I_Trade_Routes = 71,

	/// <summary>
	/// Booming Economy
	/// </summary>
	/// <name>I Trader Value Sold</name>
	/// <usabilityTags>[Tag] Trade</usabilityTags>
	I_Trader_Value_Sold = 72,

	/// <summary>
	/// Water Extraction
	/// </summary>
	/// <name>I Upgrade Pump</name>
	/// <usabilityTags>[Tag] Rainpunk</usabilityTags>
	I_Upgrade_Pump = 73,

	/// <summary>
	/// Fill the Engines
	/// </summary>
	/// <name>I Water</name>
	/// <usabilityTags>[Tag] Rainpunk</usabilityTags>
	I_Water = 74,

	/// <summary>
	/// Exploration
	/// </summary>
	/// <name>IA Glades</name>
	IA_Glades = 75,

	/// <summary>
	/// Shelters
	/// </summary>
	/// <name>IA Shelters</name>
	IA_Shelters = 76,

	/// <summary>
	/// Housing Estate
	/// </summary>
	/// <name>IA TO Build Shelters</name>
	IA_TO_Build_Shelters = 77,

	/// <summary>
	/// Distant Journey
	/// </summary>
	/// <name>IA TO Discover Glades</name>
	IA_TO_Discover_Glades = 78,

	/// <summary>
	/// Woodcutters
	/// </summary>
	/// <name>IA Woodcutters Camp</name>
	IA_Woodcutters_Camp = 79,

	/// <summary>
	/// The Grove
	/// </summary>
	/// <name>IB Beavers</name>
	/// <usabilityTags>[Tag] Beaver, [Tag] Requires Fertile Soil</usabilityTags>
	IB_Beavers = 80,

	/// <summary>
	/// Big Delivery
	/// </summary>
	/// <name>IB Building Packs</name>
	IB_Building_Packs = 81,

	/// <summary>
	/// Camps
	/// </summary>
	/// <name>IB Camps</name>
	IB_Camps = 82,

	/// <summary>
	/// Rich Harvest
	/// </summary>
	/// <name>IB Crops</name>
	IB_Crops = 83,

	/// <summary>
	/// People of the Forest
	/// </summary>
	/// <name>IB Foxes</name>
	/// <usabilityTags>[Tag] Fox</usabilityTags>
	IB_Foxes = 84,

	/// <summary>
	/// Architects
	/// </summary>
	/// <name>IB Frogs</name>
	/// <usabilityTags>[Tag] Frog</usabilityTags>
	IB_Frogs = 85,

	/// <summary>
	/// The Nest
	/// </summary>
	/// <name>IB Harpies</name>
	/// <usabilityTags>[Tag] Harpy</usabilityTags>
	IB_Harpies = 86,

	/// <summary>
	/// Help From the Queen
	/// </summary>
	/// <name>IB Humans</name>
	/// <usabilityTags>[Tag] Human, [Tag] Requires Fertile Soil</usabilityTags>
	IB_Humans = 87,

	/// <summary>
	/// Trappers
	/// </summary>
	/// <name>IB Lizards</name>
	/// <usabilityTags>[Tag] Lizzard</usabilityTags>
	IB_Lizards = 88,

	/// <summary>
	/// Basic Logistics
	/// </summary>
	/// <name>IB Paths</name>
	IB_Paths = 89,

	/// <summary>
	/// Delivery
	/// </summary>
	/// <name>IB Provisions and Crops</name>
	/// <usabilityTags>[Tag] Trade</usabilityTags>
	IB_Provisions_And_Crops = 90,

	/// <summary>
	/// Relics
	/// </summary>
	/// <name>IB Tablet</name>
	IB_Tablet = 91,

	/// <summary>
	/// Three Packs
	/// </summary>
	/// <name>IB Three Packs</name>
	IB_Three_Packs = 92,

	/// <summary>
	/// Quick Packaging
	/// </summary>
	/// <name>IB TO Three Packs</name>
	IB_TO_Three_Packs = 93,

	/// <summary>
	/// Trading Post
	/// </summary>
	/// <name>IB Trading Post</name>
	/// <usabilityTags>[Tag] Trade</usabilityTags>
	IB_Trading_Post = 94,

	/// <summary>
	/// Wood Delivery
	/// </summary>
	/// <name>IB Wood</name>
	IB_Wood = 95,

	/// <summary>
	/// Advanced Trading
	/// </summary>
	/// <name>II Advanced Trading</name>
	II_Advanced_Trading = 96,

	/// <summary>
	/// Aid for the Bat Clan
	/// </summary>
	/// <name>II Aid for the Bat Faction</name>
	/// <usabilityTags>[Tag] Bat</usabilityTags>
	II_Aid_For_The_Bat_Faction = 394,

	/// <summary>
	/// Aid For the Beaver Clan
	/// </summary>
	/// <name>II Aid for the Beaver Faction</name>
	/// <usabilityTags>[Tag] Beaver</usabilityTags>
	II_Aid_For_The_Beaver_Faction = 97,

	/// <summary>
	/// Aid for the Fox Pack
	/// </summary>
	/// <name>II Aid for the Fox Faction</name>
	/// <usabilityTags>[Tag] Fox</usabilityTags>
	II_Aid_For_The_Fox_Faction = 98,

	/// <summary>
	/// Aid for the Frog Clan
	/// </summary>
	/// <name>II Aid for the Frog Faction</name>
	/// <usabilityTags>[Tag] Frog</usabilityTags>
	II_Aid_For_The_Frog_Faction = 99,

	/// <summary>
	/// Aiding the Flock
	/// </summary>
	/// <name>II Aid for the Harpy Faction</name>
	/// <usabilityTags>[Tag] Harpy</usabilityTags>
	II_Aid_For_The_Harpy_Faction = 100,

	/// <summary>
	/// Aid for the Human Clan
	/// </summary>
	/// <name>II Aid for the Human Faction</name>
	/// <usabilityTags>[Tag] Human</usabilityTags>
	II_Aid_For_The_Human_Faction = 101,

	/// <summary>
	/// Aid for the Lizard Clan
	/// </summary>
	/// <name>II Aid for the Lizard Faction</name>
	/// <usabilityTags>[Tag] Lizzard</usabilityTags>
	II_Aid_For_The_Lizard_Faction = 102,

	/// <summary>
	/// Pottery and Wine
	/// </summary>
	/// <name>II Artisan</name>
	II_Artisan = 103,

	/// <summary>
	/// Bat Influx
	/// </summary>
	/// <name>II Bat Influx</name>
	/// <usabilityTags>[Tag] Bat</usabilityTags>
	II_Bat_Influx = 395,

	/// <summary>
	/// Bat Population
	/// </summary>
	/// <name>II Bat Population</name>
	/// <usabilityTags>[Tag] Bat</usabilityTags>
	II_Bat_Population = 396,

	/// <summary>
	/// Beaver Influx
	/// </summary>
	/// <name>II Beaver Influx</name>
	/// <usabilityTags>[Tag] Beaver</usabilityTags>
	II_Beaver_Influx = 104,

	/// <summary>
	/// Beaver Population
	/// </summary>
	/// <name>II Beaver Population</name>
	/// <usabilityTags>[Tag] Beaver</usabilityTags>
	II_Beaver_Population = 105,

	/// <summary>
	/// Fighting the Storm
	/// </summary>
	/// <name>II Blight Post</name>
	/// <usabilityTags>[Tag] Blight</usabilityTags>
	II_Blight_Post = 106,

	/// <summary>
	/// Happy Brewing
	/// </summary>
	/// <name>II Brewery</name>
	II_Brewery = 107,

	/// <summary>
	/// Clothing the People
	/// </summary>
	/// <name>II Coats</name>
	II_Coats = 108,

	/// <summary>
	/// Restoration
	/// </summary>
	/// <name>II Convert</name>
	II_Convert = 109,

	/// <summary>
	/// Advanced Farming
	/// </summary>
	/// <name>II Crops</name>
	/// <usabilityTags>[Tag] Requires Fertile Soil</usabilityTags>
	II_Crops = 110,

	/// <summary>
	/// Firestarter
	/// </summary>
	/// <name>II Cysts</name>
	/// <usabilityTags>[Tag] Blight</usabilityTags>
	II_Cysts = 111,

	/// <summary>
	/// Risky Expedition
	/// </summary>
	/// <name>II Dangerous Glades</name>
	II_Dangerous_Glades = 112,

	/// <summary>
	/// Rain Engines
	/// </summary>
	/// <name>II Engines</name>
	/// <usabilityTags>[Tag] Rainpunk</usabilityTags>
	II_Engines = 113,

	/// <summary>
	/// Algal Bloom
	/// </summary>
	/// <name>II Fishing Trial M S NB</name>
	II_Fishing_Trial_M_S_NB = 114,

	/// <summary>
	/// Scaling Up
	/// </summary>
	/// <name>II Fishing Trial RW CF S</name>
	II_Fishing_Trial_RW_CF_S = 115,

	/// <summary>
	/// Out Fishing
	/// </summary>
	/// <name>II Fishing Trial SO M CRW NB</name>
	II_Fishing_Trial_SO_M_CRW_NB = 116,

	/// <summary>
	/// Fox Influx
	/// </summary>
	/// <name>II Fox Influx</name>
	/// <usabilityTags>[Tag] Fox</usabilityTags>
	II_Fox_Influx = 117,

	/// <summary>
	/// Fox Population
	/// </summary>
	/// <name>II Fox Population</name>
	/// <usabilityTags>[Tag] Fox</usabilityTags>
	II_Fox_Population = 118,

	/// <summary>
	/// Frog Influx
	/// </summary>
	/// <name>II Frog Influx</name>
	/// <usabilityTags>[Tag] Frog</usabilityTags>
	II_Frog_Influx = 119,

	/// <summary>
	/// Frog Population
	/// </summary>
	/// <name>II Frog Population</name>
	/// <usabilityTags>[Tag] Frog</usabilityTags>
	II_Frog_Population = 120,

	/// <summary>
	/// Important Delivery
	/// </summary>
	/// <name>II Fuel and Building</name>
	II_Fuel_And_Building = 121,

	/// <summary>
	/// Into the Wilds
	/// </summary>
	/// <name>II Glades</name>
	II_Glades = 122,

	/// <summary>
	/// Into the Unknown
	/// </summary>
	/// <name>II Glades in Time</name>
	II_Glades_In_Time = 123,

	/// <summary>
	/// Happy Beavers
	/// </summary>
	/// <name>II Happy Beavers</name>
	/// <usabilityTags>[Tag] Beaver, [Tag] Trade</usabilityTags>
	II_Happy_Beavers = 124,

	/// <summary>
	/// Happy Foxes
	/// </summary>
	/// <name>II Happy Foxes</name>
	/// <usabilityTags>[Tag] Fox</usabilityTags>
	II_Happy_Foxes = 125,

	/// <summary>
	/// Happy Frogs
	/// </summary>
	/// <name>II Happy Frogs</name>
	/// <usabilityTags>[Tag] Frog, [Tag] Rainpunk</usabilityTags>
	II_Happy_Frogs = 126,

	/// <summary>
	/// Happy Harpies
	/// </summary>
	/// <name>II Happy Harpies</name>
	/// <usabilityTags>[Tag] Harpy</usabilityTags>
	II_Happy_Harpies = 127,

	/// <summary>
	/// Happy Humans
	/// </summary>
	/// <name>II Happy Humans</name>
	/// <usabilityTags>[Tag] Human</usabilityTags>
	II_Happy_Humans = 128,

	/// <summary>
	/// Happy Lizards
	/// </summary>
	/// <name>II Happy Lizards</name>
	/// <usabilityTags>[Tag] Lizzard</usabilityTags>
	II_Happy_Lizards = 129,

	/// <summary>
	/// Harpy Influx
	/// </summary>
	/// <name>II Harpy Influx</name>
	/// <usabilityTags>[Tag] Harpy</usabilityTags>
	II_Harpy_Influx = 130,

	/// <summary>
	/// Harpy Population
	/// </summary>
	/// <name>II Harpy Population</name>
	/// <usabilityTags>[Tag] Harpy</usabilityTags>
	II_Harpy_Population = 131,

	/// <summary>
	/// More Houses
	/// </summary>
	/// <name>II Human Houses</name>
	II_Human_Houses = 132,

	/// <summary>
	/// Human Influx
	/// </summary>
	/// <name>II Human Influx</name>
	/// <usabilityTags>[Tag] Human</usabilityTags>
	II_Human_Influx = 133,

	/// <summary>
	/// Human Population
	/// </summary>
	/// <name>II Human Population</name>
	/// <usabilityTags>[Tag] Human</usabilityTags>
	II_Human_Population = 134,

	/// <summary>
	/// Meat Diet
	/// </summary>
	/// <name>II Jerky</name>
	II_Jerky = 135,

	/// <summary>
	/// Meat Treats
	/// </summary>
	/// <name>II Jerky For Time</name>
	II_Jerky_For_Time = 136,

	/// <summary>
	/// Judgment
	/// </summary>
	/// <name>II Judgement</name>
	/// <usabilityTags>[Tag] Bat</usabilityTags>
	II_Judgement = 397,

	/// <summary>
	/// Lizard Influx
	/// </summary>
	/// <name>II Lizard Influx</name>
	/// <usabilityTags>[Tag] Lizzard</usabilityTags>
	II_Lizard_Influx = 137,

	/// <summary>
	/// Lizard Population
	/// </summary>
	/// <name>II Lizard Population</name>
	/// <usabilityTags>[Tag] Lizzard</usabilityTags>
	II_Lizard_Population = 138,

	/// <summary>
	/// Luxurious Delivery
	/// </summary>
	/// <name>II Luxury Packs</name>
	II_Luxury_Packs = 139,

	/// <summary>
	/// Building Materials
	/// </summary>
	/// <name>II Means of Production</name>
	II_Means_Of_Production = 140,

	/// <summary>
	/// Stacking Amber
	/// </summary>
	/// <name>II Multiply Routes</name>
	/// <usabilityTags>[Tag] Trade</usabilityTags>
	II_Multiply_Routes = 141,

	/// <summary>
	/// Feast
	/// </summary>
	/// <name>II Offering Butcher</name>
	II_Offering_Butcher = 142,

	/// <summary>
	/// Outposts
	/// </summary>
	/// <name>II Outpost</name>
	II_Outpost = 143,

	/// <summary>
	/// Infrastructure
	/// </summary>
	/// <name>II Paths</name>
	II_Paths = 144,

	/// <summary>
	/// Population Influx
	/// </summary>
	/// <name>II Population Influx</name>
	II_Population_Influx = 145,

	/// <summary>
	/// Water Delivery
	/// </summary>
	/// <name>II Rainwater</name>
	/// <usabilityTags>[Tag] Rainpunk</usabilityTags>
	II_Rainwater = 146,

	/// <summary>
	/// Profit Margin
	/// </summary>
	/// <name>II Route Value</name>
	/// <usabilityTags>[Tag] Trade</usabilityTags>
	II_Route_Value = 147,

	/// <summary>
	/// Seller
	/// </summary>
	/// <name>II Routes</name>
	/// <usabilityTags>[Tag] Trade</usabilityTags>
	II_Routes = 148,

	/// <summary>
	/// Sacrificing
	/// </summary>
	/// <name>II Sacrifice</name>
	II_Sacrifice = 149,

	/// <summary>
	/// Making Connections
	/// </summary>
	/// <name>II Standing</name>
	/// <usabilityTags>[Tag] Trade</usabilityTags>
	II_Standing = 150,

	/// <summary>
	/// Ancient Artifacts
	/// </summary>
	/// <name>II Tablets</name>
	II_Tablets = 151,

	/// <summary>
	/// Work Break
	/// </summary>
	/// <name>II TO Cut NOTrees</name>
	II_TO_Cut_NOTrees = 152,

	/// <summary>
	/// Need for Timber
	/// </summary>
	/// <name>II TO Cut Trees</name>
	II_TO_Cut_Trees = 153,

	/// <summary>
	/// Adventurous Viceroy
	/// </summary>
	/// <name>II TO Discover Dangerous Glades</name>
	II_TO_Discover_Dangerous_Glades = 154,

	/// <summary>
	/// Forager's Trial
	/// </summary>
	/// <name>II TO Forager Trial - CRW AT</name>
	/// <usabilityTags>[Tag] Requires Fertile Soil</usabilityTags>
	II_TO_Forager_Trial_CRW_AT = 155,

	/// <summary>
	/// Forager's Trial
	/// </summary>
	/// <name>II TO Forager Trial - RW</name>
	/// <usabilityTags>[Tag] Requires Fertile Soil</usabilityTags>
	II_TO_Forager_Trial_RW = 156,

	/// <summary>
	/// Forager's Trial
	/// </summary>
	/// <name>II TO Forager Trial - SO</name>
	/// <usabilityTags>[Tag] Requires Fertile Soil</usabilityTags>
	II_TO_Forager_Trial_SO = 157,

	/// <summary>
	/// Stonecutter's Trial
	/// </summary>
	/// <name>II TO Gathering Stone</name>
	/// <usabilityTags>[Tag] Requires Fertile Soil</usabilityTags>
	II_TO_Gathering_Stone = 158,

	/// <summary>
	/// Venturesome Leader
	/// </summary>
	/// <name>II TO Glades Discovery</name>
	II_TO_Glades_Discovery = 159,

	/// <summary>
	/// Herbalist's Trial
	/// </summary>
	/// <name>II TO Herbalist Trial - CRW</name>
	II_TO_Herbalist_Trial_CRW = 160,

	/// <summary>
	/// Herbalist's Trial
	/// </summary>
	/// <name>II TO Herbalist Trial - RW SF</name>
	II_TO_Herbalist_Trial_RW_SF = 161,

	/// <summary>
	/// Herbalist's Trial
	/// </summary>
	/// <name>II TO Herbalist Trial - SO</name>
	II_TO_Herbalist_Trial_SO = 162,

	/// <summary>
	/// Bat Colony
	/// </summary>
	/// <name>II TO Homes for Bats</name>
	/// <usabilityTags>[Tag] Bat</usabilityTags>
	II_TO_Homes_For_Bats = 398,

	/// <summary>
	/// Beaver Colony
	/// </summary>
	/// <name>II TO Homes for Beavers</name>
	/// <usabilityTags>[Tag] Beaver</usabilityTags>
	II_TO_Homes_For_Beavers = 163,

	/// <summary>
	/// Homes For Foxes
	/// </summary>
	/// <name>II TO Homes for Foxes</name>
	/// <usabilityTags>[Tag] Fox</usabilityTags>
	II_TO_Homes_For_Foxes = 164,

	/// <summary>
	/// Frog Colony
	/// </summary>
	/// <name>II TO Homes for Frogs</name>
	/// <usabilityTags>[Tag] Frog</usabilityTags>
	II_TO_Homes_For_Frogs = 165,

	/// <summary>
	/// Harpy Colony
	/// </summary>
	/// <name>II TO Homes for Harpies</name>
	/// <usabilityTags>[Tag] Harpy</usabilityTags>
	II_TO_Homes_For_Harpies = 166,

	/// <summary>
	/// Human Colony
	/// </summary>
	/// <name>II TO Homes for Humans</name>
	/// <usabilityTags>[Tag] Human</usabilityTags>
	II_TO_Homes_For_Humans = 167,

	/// <summary>
	/// Lizard Colony
	/// </summary>
	/// <name>II TO Homes for Lizards</name>
	/// <usabilityTags>[Tag] Lizzard</usabilityTags>
	II_TO_Homes_For_Lizards = 168,

	/// <summary>
	/// Outpost
	/// </summary>
	/// <name>II TO HUBs</name>
	II_TO_HUBs = 169,

	/// <summary>
	/// Efficiency Test
	/// </summary>
	/// <name>II TO Lumbermill</name>
	II_TO_Lumbermill = 170,

	/// <summary>
	/// Sacrificial Ceremony
	/// </summary>
	/// <name>II TO Sacrificies</name>
	II_TO_Sacrificies = 171,

	/// <summary>
	/// Trapper's Trial
	/// </summary>
	/// <name>II TO Trappers Trial - CF SF</name>
	II_TO_Trappers_Trial_CF_SF = 172,

	/// <summary>
	/// Trapper's Trial
	/// </summary>
	/// <name>II TO Trappers Trial - RW M</name>
	II_TO_Trappers_Trial_RW_M = 173,

	/// <summary>
	/// Trade Connections
	/// </summary>
	/// <name>II Trade Connections</name>
	/// <usabilityTags>[Tag] Trade</usabilityTags>
	II_Trade_Connections = 174,

	/// <summary>
	/// Rainpunk Engineer
	/// </summary>
	/// <name>II Use Water</name>
	/// <usabilityTags>[Tag] Rainpunk</usabilityTags>
	II_Use_Water = 175,

	/// <summary>
	/// Royal Gardens
	/// </summary>
	/// <name>III Aesthethics</name>
	III_Aesthethics = 176,

	/// <summary>
	/// Cups and Glasses
	/// </summary>
	/// <name>III Ale and Tavern</name>
	III_Ale_And_Tavern = 177,

	/// <summary>
	/// Charity Fair
	/// </summary>
	/// <name>III Amber and Market</name>
	III_Amber_And_Market = 178,

	/// <summary>
	/// Lost Knowledge
	/// </summary>
	/// <name>III Ancient Tablets</name>
	III_Ancient_Tablets = 179,

	/// <summary>
	/// Archaeology
	/// </summary>
	/// <name>III Archaeology</name>
	III_Archaeology = 180,

	/// <summary>
	/// Bat Relatives
	/// </summary>
	/// <name>III Bat Relatives</name>
	/// <usabilityTags>[Tag] Bat</usabilityTags>
	III_Bat_Relatives = 399,

	/// <summary>
	/// Beaver Relatives
	/// </summary>
	/// <name>III Beaver Relatives</name>
	/// <usabilityTags>[Tag] Beaver</usabilityTags>
	III_Beaver_Relatives = 181,

	/// <summary>
	/// Building the Citadel
	/// </summary>
	/// <name>III Building Packs</name>
	III_Building_Packs = 182,

	/// <summary>
	/// New Clothes
	/// </summary>
	/// <name>III Coats NeedForTime</name>
	III_Coats_NeedForTime = 183,

	/// <summary>
	/// Industry
	/// </summary>
	/// <name>III Copper</name>
	III_Copper = 184,

	/// <summary>
	/// Profitable Trade
	/// </summary>
	/// <name>III Costly Route</name>
	/// <usabilityTags>[Tag] Trade</usabilityTags>
	III_Costly_Route = 185,

	/// <summary>
	/// Pyromania
	/// </summary>
	/// <name>III Cysts</name>
	/// <usabilityTags>[Tag] Blight</usabilityTags>
	III_Cysts = 186,

	/// <summary>
	/// Agriculture
	/// </summary>
	/// <name>III Farmfields</name>
	/// <usabilityTags>[Tag] Requires Fertile Soil</usabilityTags>
	III_Farmfields = 187,

	/// <summary>
	/// The Forum
	/// </summary>
	/// <name>III Forum</name>
	/// <usabilityTags>[Tag] Frog</usabilityTags>
	III_Forum = 188,

	/// <summary>
	/// Fox Relatives
	/// </summary>
	/// <name>III Fox Relatives</name>
	/// <usabilityTags>[Tag] Fox</usabilityTags>
	III_Fox_Relatives = 189,

	/// <summary>
	/// Frog Relatives
	/// </summary>
	/// <name>III Frog Relatives</name>
	/// <usabilityTags>[Tag] Frog</usabilityTags>
	III_Frog_Relatives = 190,

	/// <summary>
	/// Upgraded Living
	/// </summary>
	/// <name>III Frog Upgrades</name>
	/// <usabilityTags>[Tag] Frog</usabilityTags>
	III_Frog_Upgrades = 191,

	/// <summary>
	/// Trailblazing
	/// </summary>
	/// <name>III Glades</name>
	III_Glades = 192,

	/// <summary>
	/// Hasty Explorer
	/// </summary>
	/// <name>III Glades in Time</name>
	/// <usabilityTags>[Tag] Rainpunk</usabilityTags>
	III_Glades_In_Time = 193,

	/// <summary>
	/// Harpy Relatives
	/// </summary>
	/// <name>III Harpy Relatives</name>
	/// <usabilityTags>[Tag] Harpy</usabilityTags>
	III_Harpy_Relatives = 194,

	/// <summary>
	/// Cleanliness
	/// </summary>
	/// <name>III Higene</name>
	/// <usabilityTags>[Tag] Harpy</usabilityTags>
	III_Higene = 195,

	/// <summary>
	/// Advanced District
	/// </summary>
	/// <name>III Hub</name>
	III_Hub = 196,

	/// <summary>
	/// Human Relatives
	/// </summary>
	/// <name>III Human Relatives</name>
	/// <usabilityTags>[Tag] Human</usabilityTags>
	III_Human_Relatives = 197,

	/// <summary>
	/// Basic Rights
	/// </summary>
	/// <name>III Leisure for Time</name>
	III_Leisure_For_Time = 198,

	/// <summary>
	/// Lizard Relatives
	/// </summary>
	/// <name>III Lizard Relatives</name>
	/// <usabilityTags>[Tag] Lizzard</usabilityTags>
	III_Lizard_Relatives = 199,

	/// <summary>
	/// Lost in the Woods
	/// </summary>
	/// <name>III Lost Villagers</name>
	III_Lost_Villagers = 200,

	/// <summary>
	/// Luxury
	/// </summary>
	/// <name>III Luxury</name>
	/// <usabilityTags>[Tag] Beaver</usabilityTags>
	III_Luxury = 201,

	/// <summary>
	/// Rations for the Citadel
	/// </summary>
	/// <name>III Provisions and Crops</name>
	III_Provisions_And_Crops = 202,

	/// <summary>
	/// Water Industry
	/// </summary>
	/// <name>III Pump Upgrade</name>
	/// <usabilityTags>[Tag] Rainpunk</usabilityTags>
	III_Pump_Upgrade = 203,

	/// <summary>
	/// Advanced Logistics
	/// </summary>
	/// <name>III Rain Collector</name>
	III_Rain_Collector = 204,

	/// <summary>
	/// Religion
	/// </summary>
	/// <name>III Religion</name>
	III_Religion = 205,

	/// <summary>
	/// Bat Villagers
	/// </summary>
	/// <name>III Resolve Bats</name>
	/// <usabilityTags>[Tag] Bat</usabilityTags>
	III_Resolve_Bats = 400,

	/// <summary>
	/// Beaver Resolve
	/// </summary>
	/// <name>III Resolve Beavers</name>
	/// <usabilityTags>[Tag] Beaver</usabilityTags>
	III_Resolve_Beavers = 206,

	/// <summary>
	/// Fox Villagers
	/// </summary>
	/// <name>III Resolve Foxes</name>
	/// <usabilityTags>[Tag] Fox</usabilityTags>
	III_Resolve_Foxes = 207,

	/// <summary>
	/// Frog Resolve
	/// </summary>
	/// <name>III Resolve Frogs</name>
	/// <usabilityTags>[Tag] Frog</usabilityTags>
	III_Resolve_Frogs = 208,

	/// <summary>
	/// Harpy Villagers
	/// </summary>
	/// <name>III Resolve Harpies</name>
	/// <usabilityTags>[Tag] Harpy</usabilityTags>
	III_Resolve_Harpies = 209,

	/// <summary>
	/// Human Villagers
	/// </summary>
	/// <name>III Resolve Humans</name>
	/// <usabilityTags>[Tag] Human</usabilityTags>
	III_Resolve_Humans = 210,

	/// <summary>
	/// Lizard Villagers
	/// </summary>
	/// <name>III Resolve Lizards</name>
	/// <usabilityTags>[Tag] Lizzard</usabilityTags>
	III_Resolve_Lizards = 211,

	/// <summary>
	/// Fair Exchange
	/// </summary>
	/// <name>III Route Value</name>
	/// <usabilityTags>[Tag] Trade</usabilityTags>
	III_Route_Value = 212,

	/// <summary>
	/// Export
	/// </summary>
	/// <name>III Routes</name>
	/// <usabilityTags>[Tag] Trade</usabilityTags>
	III_Routes = 213,

	/// <summary>
	/// Income Tax
	/// </summary>
	/// <name>III Routes And Amber</name>
	/// <usabilityTags>[Tag] Trade</usabilityTags>
	III_Routes_And_Amber = 214,

	/// <summary>
	/// Aesthetics
	/// </summary>
	/// <name>III Royal Gardens</name>
	III_Royal_Gardens = 215,

	/// <summary>
	/// Ruins
	/// </summary>
	/// <name>III Ruins</name>
	III_Ruins = 216,

	/// <summary>
	/// Salty Delivery
	/// </summary>
	/// <name>III Salt</name>
	III_Salt = 217,

	/// <summary>
	/// Brotherhood
	/// </summary>
	/// <name>III Scrolls and Temple</name>
	III_Scrolls_And_Temple = 218,

	/// <summary>
	/// Gifts for the Queen
	/// </summary>
	/// <name>III Send to Citadel</name>
	III_Send_To_Citadel = 219,

	/// <summary>
	/// Training
	/// </summary>
	/// <name>III Service Bats</name>
	/// <usabilityTags>[Tag] Bat</usabilityTags>
	III_Service_Bats = 401,

	/// <summary>
	/// Healing
	/// </summary>
	/// <name>III Service Harpy</name>
	/// <usabilityTags>[Tag] Harpy</usabilityTags>
	III_Service_Harpy = 220,

	/// <summary>
	/// Religious Rites
	/// </summary>
	/// <name>III Service Human</name>
	/// <usabilityTags>[Tag] Human</usabilityTags>
	III_Service_Human = 221,

	/// <summary>
	/// Arena
	/// </summary>
	/// <name>III Service Lizard</name>
	/// <usabilityTags>[Tag] Lizzard</usabilityTags>
	III_Service_Lizard = 222,

	/// <summary>
	/// Serving Ale
	/// </summary>
	/// <name>III Serving Ale</name>
	III_Serving_Ale = 223,

	/// <summary>
	/// Open or send caches
	/// </summary>
	/// <name>III Solve Chests</name>
	III_Solve_Chests = 224,

	/// <summary>
	/// Profitable Caution
	/// </summary>
	/// <name>III Solve Dangerous Relic</name>
	III_Solve_Dangerous_Relic = 225,

	/// <summary>
	/// Good Friends
	/// </summary>
	/// <name>III Standing</name>
	/// <usabilityTags>[Tag] Trade</usabilityTags>
	III_Standing = 226,

	/// <summary>
	/// Basic Packages
	/// </summary>
	/// <name>III TO Basic Packs</name>
	III_TO_Basic_Packs = 227,

	/// <summary>
	/// Building Rush
	/// </summary>
	/// <name>III TO Building Packs</name>
	III_TO_Building_Packs = 228,

	/// <summary>
	/// Chest Chaser
	/// </summary>
	/// <name>III TO Chest Chaser</name>
	III_TO_Chest_Chaser = 229,

	/// <summary>
	/// Foolhardy Man
	/// </summary>
	/// <name>III TO Dangerous Stuff</name>
	III_TO_Dangerous_Stuff = 230,

	/// <summary>
	/// Coal Fever
	/// </summary>
	/// <name>III TO Digging Coal</name>
	III_TO_Digging_Coal = 231,

	/// <summary>
	/// Copper Fever
	/// </summary>
	/// <name>III TO Digging Ore</name>
	/// <usabilityTags>Metal Tag</usabilityTags>
	III_TO_Digging_Ore = 232,

	/// <summary>
	/// Salt Fever
	/// </summary>
	/// <name>III TO Digging Salt</name>
	/// <usabilityTags>Metal Tag</usabilityTags>
	III_TO_Digging_Salt = 233,

	/// <summary>
	/// Let It Rain
	/// </summary>
	/// <name>III TO Engines and Water</name>
	/// <usabilityTags>[Tag] Rainpunk</usabilityTags>
	III_TO_Engines_And_Water = 234,

	/// <summary>
	/// Disturbing the Ancients
	/// </summary>
	/// <name>III TO Explore and Deliver</name>
	III_TO_Explore_And_Deliver = 235,

	/// <summary>
	/// Devilish Curiosity
	/// </summary>
	/// <name>III TO Forbidden Glade</name>
	III_TO_Forbidden_Glade = 236,

	/// <summary>
	/// Forest Fascination
	/// </summary>
	/// <name>III TO Glades and Tools</name>
	III_TO_Glades_And_Tools = 237,

	/// <summary>
	/// Wealthy Trader
	/// </summary>
	/// <name>III TO Rich Trader</name>
	/// <usabilityTags>[Tag] Trade</usabilityTags>
	III_TO_Rich_Trader = 238,

	/// <summary>
	/// Into the Ruins
	/// </summary>
	/// <name>III TO Ruins and Planks</name>
	III_TO_Ruins_And_Planks = 239,

	/// <summary>
	/// Bling-Bling
	/// </summary>
	/// <name>III TO Shiny</name>
	III_TO_Shiny = 240,

	/// <summary>
	/// Thirsty Trader
	/// </summary>
	/// <name>III TO Thirsty Trader</name>
	/// <usabilityTags>[Tag] Trade</usabilityTags>
	III_TO_Thirsty_Trader = 241,

	/// <summary>
	/// The Source
	/// </summary>
	/// <name>III TO Water Used</name>
	/// <usabilityTags>[Tag] Rainpunk</usabilityTags>
	III_TO_Water_Used = 242,

	/// <summary>
	/// Trade and Industry
	/// </summary>
	/// <name>III Trade and Spark</name>
	/// <usabilityTags>[Tag] Trade</usabilityTags>
	III_Trade_And_Spark = 243,

	/// <summary>
	/// Trading Goods
	/// </summary>
	/// <name>III TradePacks</name>
	III_TradePacks = 244,

	/// <summary>
	/// Booming Economy
	/// </summary>
	/// <name>III Trader Value Sold</name>
	/// <usabilityTags>[Tag] Trade</usabilityTags>
	III_Trader_Value_Sold = 245,

	/// <summary>
	/// Lumps of Coal
	/// </summary>
	/// <name>III Upgrade Mine - Coal</name>
	III_Upgrade_Mine_Coal = 246,

	/// <summary>
	/// Ore Mining
	/// </summary>
	/// <name>III Upgrade Mine - Copper</name>
	III_Upgrade_Mine_Copper = 247,

	/// <summary>
	/// Power of the Storm
	/// </summary>
	/// <name>III Use Blue Water</name>
	/// <usabilityTags>[Tag] Rainpunk</usabilityTags>
	III_Use_Blue_Water = 248,

	/// <summary>
	/// Power of the Drizzle
	/// </summary>
	/// <name>III Use Green Water</name>
	/// <usabilityTags>[Tag] Rainpunk</usabilityTags>
	III_Use_Green_Water = 249,

	/// <summary>
	/// Power of the Clearance
	/// </summary>
	/// <name>III Use Yellow Water</name>
	/// <usabilityTags>[Tag] Rainpunk</usabilityTags>
	III_Use_Yellow_Water = 250,

	/// <summary>
	/// Luxury Goods
	/// </summary>
	/// <name>III Valuables</name>
	III_Valuables = 251,

	/// <summary>
	/// Varied Delivery
	/// </summary>
	/// <name>III Varied Delivery</name>
	III_Varied_Delivery = 252,

	/// <summary>
	/// Liquid Luck
	/// </summary>
	/// <name>III Wine and Guild House</name>
	/// <usabilityTags>[Tag] Beaver</usabilityTags>
	III_Wine_And_Guild_House = 253,

	/// <summary>
	/// Folks Gotta Eat!
	/// </summary>
	/// <name>IV 2 Complex Food for Time</name>
	IV_2_Complex_Food_For_Time = 254,

	/// <summary>
	/// Pyromancer
	/// </summary>
	/// <name>IV Cysts</name>
	/// <usabilityTags>[Tag] Blight</usabilityTags>
	IV_Cysts = 255,

	/// <summary>
	/// Playing With Fire
	/// </summary>
	/// <name>IV Dangerous Glades</name>
	IV_Dangerous_Glades = 256,

	/// <summary>
	/// All at Once
	/// </summary>
	/// <name>IV Glades in Time</name>
	IV_Glades_In_Time = 257,

	/// <summary>
	/// Peddler
	/// </summary>
	/// <name>IV Peddler</name>
	/// <usabilityTags>[Tag] Trade</usabilityTags>
	IV_Peddler = 258,

	/// <summary>
	/// Infused Rainwater
	/// </summary>
	/// <name>IV Rainwater</name>
	/// <usabilityTags>[Tag] Rainpunk</usabilityTags>
	IV_Rainwater = 259,

	/// <summary>
	/// The Cult of Fire
	/// </summary>
	/// <name>IV Religion for Time</name>
	IV_Religion_For_Time = 260,

	/// <summary>
	/// Export Hub
	/// </summary>
	/// <name>IV Route Value</name>
	/// <usabilityTags>[Tag] Trade</usabilityTags>
	IV_Route_Value = 261,

	/// <summary>
	/// Trade Baron
	/// </summary>
	/// <name>IV Routes</name>
	/// <usabilityTags>[Tag] Trade</usabilityTags>
	IV_Routes = 262,

	/// <summary>
	/// Fearless
	/// </summary>
	/// <name>IV TO Fearless</name>
	IV_TO_Fearless = 263,

	/// <summary>
	/// Ultimate Challenge
	/// </summary>
	/// <name>IV TO Forbidden Glade</name>
	IV_TO_Forbidden_Glade = 264,

	/// <summary>
	/// Greedy Merchant
	/// </summary>
	/// <name>IV TO Greedy Merchant</name>
	/// <usabilityTags>[Tag] Trade</usabilityTags>
	IV_TO_Greedy_Merchant = 265,

	/// <summary>
	/// Trading Master
	/// </summary>
	/// <name>IV TO Trading Master</name>
	/// <usabilityTags>[Tag] Trade</usabilityTags>
	IV_TO_Trading_Master = 266,

	/// <summary>
	/// Trade and Luxury
	/// </summary>
	/// <name>IV Trade and Luxury Packs</name>
	IV_Trade_And_Luxury_Packs = 267,

	/// <summary>
	/// Rainpunk Enthusiast
	/// </summary>
	/// <name>IV Use Water</name>
	IV_Use_Water = 268,

	/// <summary>
	/// Funding an Outpost
	/// </summary>
	/// <name>IVA Building and Crops Packs</name>
	IVA_Building_And_Crops_Packs = 269,

	/// <summary>
	/// Focus on Farming
	/// </summary>
	/// <name>IVA Farmfields</name>
	/// <usabilityTags>[Tag] Requires Fertile Soil</usabilityTags>
	IVA_Farmfields = 270,

	/// <summary>
	/// Luxuries for the Citadel
	/// </summary>
	/// <name>IVA Luxury Goods</name>
	IVA_Luxury_Goods = 271,

	/// <summary>
	/// Master of Exploration
	/// </summary>
	/// <name>IVA Master of Exploration</name>
	IVA_Master_Of_Exploration = 272,

	/// <summary>
	/// Advanced Outposts
	/// </summary>
	/// <name>IVA Outpost</name>
	IVA_Outpost = 273,

	/// <summary>
	/// Pastries
	/// </summary>
	/// <name>IVA Pastries</name>
	IVA_Pastries = 274,

	/// <summary>
	/// Serving the People
	/// </summary>
	/// <name>IVA Serving the People</name>
	IVA_Serving_The_People = 275,

	/// <summary>
	/// Stone Roads
	/// </summary>
	/// <name>IVA Stone Roads</name>
	IVA_Stone_Roads = 276,

	/// <summary>
	/// Deeper into the Wilds
	/// </summary>
	/// <name>IVA Tablets</name>
	IVA_Tablets = 277,

	/// <summary>
	/// Great Expansion
	/// </summary>
	/// <name>IVA TO Bonfire</name>
	IVA_TO_Bonfire = 278,

	/// <summary>
	/// Advanced Cuisine
	/// </summary>
	/// <name>IVA TO Cooking</name>
	IVA_TO_Cooking = 279,

	/// <summary>
	/// Time of Courage
	/// </summary>
	/// <name>IVA TO Glades Tablets Relics</name>
	IVA_TO_Glades_Tablets_Relics = 280,

	/// <summary>
	/// Large Parcel
	/// </summary>
	/// <name>IVA TO Packing</name>
	IVA_TO_Packing = 281,

	/// <summary>
	/// Ravenous Axes
	/// </summary>
	/// <name>IVA TO Wood and Packs</name>
	IVA_TO_Wood_And_Packs = 282,

	/// <summary>
	/// Goods for the Citadel
	/// </summary>
	/// <name>IVA Trade Goods</name>
	IVA_Trade_Goods = 283,

	/// <summary>
	/// Wood and Provisions
	/// </summary>
	/// <name>IVA Wood</name>
	IVA_Wood = 284,

	/// <summary>
	/// Bat Majority
	/// </summary>
	/// <name>IVB Bat Majority</name>
	/// <usabilityTags>[Tag] Bat</usabilityTags>
	IVB_Bat_Majority = 402,

	/// <summary>
	/// Beaver Majority
	/// </summary>
	/// <name>IVB Beaver Majority</name>
	/// <usabilityTags>[Tag] Beaver</usabilityTags>
	IVB_Beaver_Majority = 285,

	/// <summary>
	/// Brawling
	/// </summary>
	/// <name>IVB Brawling</name>
	IVB_Brawling = 286,

	/// <summary>
	/// Builder's Tools
	/// </summary>
	/// <name>IVB Builders Tools</name>
	/// <usabilityTags>[Tag] Requires Fertile Soil</usabilityTags>
	IVB_Builders_Tools = 287,

	/// <summary>
	/// Knowledge
	/// </summary>
	/// <name>IVB Education</name>
	IVB_Education = 288,

	/// <summary>
	/// Fox Majority
	/// </summary>
	/// <name>IVB Fox Majority</name>
	/// <usabilityTags>[Tag] Fox</usabilityTags>
	IVB_Fox_Majority = 289,

	/// <summary>
	/// Frog Majority
	/// </summary>
	/// <name>IVB Frog Majority</name>
	/// <usabilityTags>[Tag] Frog</usabilityTags>
	IVB_Frog_Majority = 290,

	/// <summary>
	/// Harpy Majority
	/// </summary>
	/// <name>IVB Harpy Majority</name>
	/// <usabilityTags>[Tag] Harpy</usabilityTags>
	IVB_Harpy_Majority = 291,

	/// <summary>
	/// Human Majority
	/// </summary>
	/// <name>IVB Human Majority</name>
	/// <usabilityTags>[Tag] Human</usabilityTags>
	IVB_Human_Majority = 292,

	/// <summary>
	/// Leisure
	/// </summary>
	/// <name>IVB Leisure</name>
	IVB_Leisure = 293,

	/// <summary>
	/// Lizard Majority
	/// </summary>
	/// <name>IVB Lizard Majority</name>
	/// <usabilityTags>[Tag] Lizzard</usabilityTags>
	IVB_Lizard_Majority = 294,

	/// <summary>
	/// Rainproof Coats
	/// </summary>
	/// <name>IVB Rainproof Coats</name>
	IVB_Rainproof_Coats = 295,

	/// <summary>
	/// Expensive Delivery
	/// </summary>
	/// <name>IVB Rich Delivery</name>
	IVB_Rich_Delivery = 296,

	/// <summary>
	/// Construction Work
	/// </summary>
	/// <name>IVB TO Building Tools</name>
	IVB_TO_Building_Tools = 297,

	/// <summary>
	/// Technological Progress
	/// </summary>
	/// <name>IVB TO Engines Amount</name>
	/// <usabilityTags>[Tag] Rainpunk</usabilityTags>
	IVB_TO_Engines_Amount = 298,

	/// <summary>
	/// Food Provision
	/// </summary>
	/// <name>IVB TO Food Provision</name>
	IVB_TO_Food_Provision = 299,

	/// <summary>
	/// Travel Rations
	/// </summary>
	/// <name>IVB Travel Rations</name>
	IVB_Travel_Rations = 300,

	/// <summary>
	/// Utopia
	/// </summary>
	/// <name>IVB Utopia</name>
	IVB_Utopia = 301,

	/// <summary>
	/// Queen's Feathers
	/// </summary>
	/// <name>Needs Served</name>
	Needs_Served = 302,

	/// <summary>
	/// Queen's Feathers
	/// </summary>
	/// <name>Needs Served HIGH</name>
	Needs_Served_HIGH = 303,

	/// <summary>
	/// Queen's Feathers
	/// </summary>
	/// <name>Needs Served LOW</name>
	Needs_Served_LOW = 304,

	/// <summary></summary>
	/// <name>[R] Ghost Assault Trader</name>
	R_Ghost_Assault_Trader = 305,

	/// <summary></summary>
	/// <name>[R] Ghost Cut Trees</name>
	R_Ghost_Cut_Trees = 306,

	/// <summary></summary>
	/// <name>[R] Ghost Decorations Aesthetics</name>
	R_Ghost_Decorations_Aesthetics = 307,

	/// <summary></summary>
	/// <name>[R] Ghost Decorations Harmony</name>
	R_Ghost_Decorations_Harmony = 308,

	/// <summary></summary>
	/// <name>[R] Ghost Discover DangGlades</name>
	R_Ghost_Discover_DangGlades = 309,

	/// <summary></summary>
	/// <name>[R] Ghost Discover DangGlades in Time</name>
	R_Ghost_Discover_DangGlades_In_Time = 310,

	/// <summary></summary>
	/// <name>[R] Ghost Engines</name>
	R_Ghost_Engines = 311,

	/// <summary></summary>
	/// <name>[R] Ghost Exile Villagers</name>
	/// <usabilityTags>[Tag] Bat</usabilityTags>
	R_Ghost_Exile_Villagers = 403,

	/// <summary></summary>
	/// <name>[R] Ghost Forbid Needs Beavers</name>
	/// <usabilityTags>[Tag] Beaver</usabilityTags>
	R_Ghost_Forbid_Needs_Beavers = 312,

	/// <summary></summary>
	/// <name>[R] Ghost Forbid Needs Foxes</name>
	/// <usabilityTags>[Tag] Fox</usabilityTags>
	R_Ghost_Forbid_Needs_Foxes = 313,

	/// <summary></summary>
	/// <name>[R] Ghost Forbid Needs Harpies</name>
	/// <usabilityTags>[Tag] Harpy</usabilityTags>
	R_Ghost_Forbid_Needs_Harpies = 314,

	/// <summary></summary>
	/// <name>[R] Ghost Forbid Needs Humans</name>
	/// <usabilityTags>[Tag] Human</usabilityTags>
	R_Ghost_Forbid_Needs_Humans = 315,

	/// <summary></summary>
	/// <name>[R] Ghost Forbid Needs Lizards</name>
	/// <usabilityTags>[Tag] Lizzard</usabilityTags>
	R_Ghost_Forbid_Needs_Lizards = 316,

	/// <summary></summary>
	/// <name>[R] Ghost Generate Cysts</name>
	R_Ghost_Generate_Cysts = 317,

	/// <summary></summary>
	/// <name>[R] Ghost Hostility High</name>
	R_Ghost_Hostility_High = 318,

	/// <summary></summary>
	/// <name>[R] Ghost Hostility Low</name>
	R_Ghost_Hostility_Low = 319,

	/// <summary></summary>
	/// <name>[R] Ghost Housing Needs</name>
	R_Ghost_Housing_Needs = 320,

	/// <summary></summary>
	/// <name>[R] Ghost HUBs upgrade</name>
	R_Ghost_HUBs_Upgrade = 321,

	/// <summary></summary>
	/// <name>[R] Ghost Human Houses</name>
	R_Ghost_Human_Houses = 322,

	/// <summary></summary>
	/// <name>[R] Ghost Keep Goods</name>
	R_Ghost_Keep_Goods = 323,

	/// <summary></summary>
	/// <name>[R] Ghost Keep Villagers</name>
	R_Ghost_Keep_Villagers = 324,

	/// <summary></summary>
	/// <name>[R] Ghost Leisure</name>
	R_Ghost_Leisure = 325,

	/// <summary></summary>
	/// <name>[R] Ghost Luxury</name>
	/// <usabilityTags>[Tag] Beaver</usabilityTags>
	R_Ghost_Luxury = 326,

	/// <summary></summary>
	/// <name>[R] Ghost Rebuild Ruins</name>
	R_Ghost_Rebuild_Ruins = 327,

	/// <summary></summary>
	/// <name>[R] Ghost Religion</name>
	R_Ghost_Religion = 328,

	/// <summary></summary>
	/// <name>[R] Ghost Remove Cysts</name>
	R_Ghost_Remove_Cysts = 329,

	/// <summary></summary>
	/// <name>[R] Ghost Resolve Foxes</name>
	/// <usabilityTags>[Tag] Fox</usabilityTags>
	R_Ghost_Resolve_Foxes = 330,

	/// <summary></summary>
	/// <name>[R] Ghost Resolve Harpies</name>
	/// <usabilityTags>[Tag] Harpy</usabilityTags>
	R_Ghost_Resolve_Harpies = 331,

	/// <summary></summary>
	/// <name>[R] Ghost Resolve Lizards</name>
	/// <usabilityTags>[Tag] Lizzard</usabilityTags>
	R_Ghost_Resolve_Lizards = 332,

	/// <summary></summary>
	/// <name>[R] Ghost Sacrifice Goods</name>
	R_Ghost_Sacrifice_Goods = 333,

	/// <summary></summary>
	/// <name>[R] Ghost Salvage Ruins</name>
	R_Ghost_Salvage_Ruins = 334,

	/// <summary></summary>
	/// <name>[R] Ghost Send Goods to Citadel</name>
	R_Ghost_Send_Goods_To_Citadel = 335,

	/// <summary></summary>
	/// <name>[R] Ghost Service Needs</name>
	R_Ghost_Service_Needs = 336,

	/// <summary></summary>
	/// <name>[R] Ghost Solve DangRelics</name>
	R_Ghost_Solve_DangRelics = 337,

	/// <summary></summary>
	/// <name>[R] Ghost Starve Beavers</name>
	/// <usabilityTags>[Tag] Beaver</usabilityTags>
	R_Ghost_Starve_Beavers = 338,

	/// <summary></summary>
	/// <name>[R] Ghost Starve Frogs</name>
	/// <usabilityTags>[Tag] Frog</usabilityTags>
	R_Ghost_Starve_Frogs = 404,

	/// <summary></summary>
	/// <name>[R] Ghost Starve Humans</name>
	/// <usabilityTags>[Tag] Human</usabilityTags>
	R_Ghost_Starve_Humans = 339,

	/// <summary></summary>
	/// <name>[R] Ghost Trade Routes</name>
	R_Ghost_Trade_Routes = 340,

	/// <summary></summary>
	/// <name>[R] Ghost Trade Routes with Value</name>
	R_Ghost_Trade_Routes_With_Value = 341,

	/// <summary></summary>
	/// <name>[R] Ghost Trade Routes with Value Many</name>
	R_Ghost_Trade_Routes_With_Value_Many = 342,

	/// <summary></summary>
	/// <name>[R] Ghost Upgrade Houses</name>
	R_Ghost_Upgrade_Houses = 343,

	/// <summary></summary>
	/// <name>[R] Ghost Upgrade Mine</name>
	R_Ghost_Upgrade_Mine = 405,

	/// <summary></summary>
	/// <name>[R] Ghost Use Water</name>
	/// <usabilityTags>[Tag] Rainpunk</usabilityTags>
	R_Ghost_Use_Water = 344,

	/// <summary>
	/// Blood of the Stag
	/// </summary>
	/// <name>Rep from Events</name>
	Rep_From_Events = 345,

	/// <summary>
	/// Blood of the Stag
	/// </summary>
	/// <name>Rep from Events HIGH</name>
	Rep_From_Events_HIGH = 346,

	/// <summary>
	/// Blood of the Stag
	/// </summary>
	/// <name>Rep from Events LOW</name>
	Rep_From_Events_LOW = 347,

	/// <summary>
	/// Mortal Blood
	/// </summary>
	/// <name>Rep from Resolve</name>
	Rep_From_Resolve = 348,

	/// <summary>
	/// Mortal Blood
	/// </summary>
	/// <name>Rep from Resolve HIGH</name>
	Rep_From_Resolve_HIGH = 349,

	/// <summary>
	/// Mortal Blood
	/// </summary>
	/// <name>Rep from Resolve LOW</name>
	Rep_From_Resolve_LOW = 350,

	/// <summary>
	/// Fire Essence
	/// </summary>
	/// <name>Resolve</name>
	Resolve = 351,

	/// <summary>
	/// Fire Essence
	/// </summary>
	/// <name>Resolve HIGH</name>
	Resolve_HIGH = 352,

	/// <summary>
	/// Fire Essence
	/// </summary>
	/// <name>Resolve LOW</name>
	Resolve_LOW = 353,

	/// <summary>
	/// Golden Blood
	/// </summary>
	/// <name>Standing</name>
	Standing = 354,

	/// <summary>
	/// Golden Blood
	/// </summary>
	/// <name>Standing HIGH</name>
	Standing_HIGH = 355,

	/// <summary>
	/// Brewing Ale
	/// </summary>
	/// <name>T II Brewery</name>
	T_II_Brewery = 356,

	/// <summary>
	/// Farming
	/// </summary>
	/// <name>T II Farm</name>
	T_II_Farm = 357,

	/// <summary>
	/// Provisions
	/// </summary>
	/// <name>T II Provisions</name>
	T_II_Provisions = 358,

	/// <summary>
	/// High Society
	/// </summary>
	/// <name>T II Resolve</name>
	T_II_Resolve = 359,

	/// <summary>
	/// Smokehouse
	/// </summary>
	/// <name>T II Smokehouse</name>
	T_II_Smokehouse = 360,

	/// <summary>
	/// A Place for Rest
	/// </summary>
	/// <name>T II Tavern</name>
	T_II_Tavern = 361,

	/// <summary>
	/// First Yield
	/// </summary>
	/// <name>T II Trapper</name>
	T_II_Trapper = 362,

	/// <summary>
	/// Home & Hearth
	/// </summary>
	/// <name>T II Woodcutters Camp</name>
	T_II_Woodcutters_Camp = 363,

	/// <summary>
	/// Get Rich
	/// </summary>
	/// <name>T III Amber</name>
	T_III_Amber = 364,

	/// <summary>
	/// High Resolve
	/// </summary>
	/// <name>T III Beavers Resolve</name>
	T_III_Beavers_Resolve = 365,

	/// <summary>
	/// Collecting Berries
	/// </summary>
	/// <name>T III Berries</name>
	T_III_Berries = 366,

	/// <summary>
	/// Happy Meal
	/// </summary>
	/// <name>T III Food</name>
	T_III_Food = 367,

	/// <summary>
	/// Fulfilling Needs
	/// </summary>
	/// <name>T III Guild House</name>
	T_III_Guild_House = 368,

	/// <summary>
	/// Buying & Selling
	/// </summary>
	/// <name>T III Packs</name>
	T_III_Packs = 369,

	/// <summary>
	/// Catching Rainwater
	/// </summary>
	/// <name>T III Rain</name>
	T_III_Rain = 370,

	/// <summary>
	/// Surviving Requires Sacrifice
	/// </summary>
	/// <name>T III Sacrifice</name>
	T_III_Sacrifice = 371,

	/// <summary>
	/// Traders & Currency
	/// </summary>
	/// <name>T III Trading Post</name>
	T_III_Trading_Post = 372,

	/// <summary>
	/// Winemaking
	/// </summary>
	/// <name>T III Wine</name>
	T_III_Wine = 373,

	/// <summary>
	/// Blight Fighters
	/// </summary>
	/// <name>T IV Blightpost</name>
	T_IV_Blightpost = 374,

	/// <summary>
	/// Finders Keepers
	/// </summary>
	/// <name>T IV Caches</name>
	T_IV_Caches = 375,

	/// <summary>
	/// Stay in Shape
	/// </summary>
	/// <name>T IV Clan Hall</name>
	T_IV_Clan_Hall = 376,

	/// <summary>
	/// Rainpunk Technology
	/// </summary>
	/// <name>T IV Engines</name>
	T_IV_Engines = 377,

	/// <summary>
	/// Forbidden Fruit
	/// </summary>
	/// <name>T IV Frobidden</name>
	T_IV_Frobidden = 378,

	/// <summary>
	/// Metallurgy
	/// </summary>
	/// <name>T IV Metal</name>
	T_IV_Metal = 379,

	/// <summary>
	/// Mining Basics
	/// </summary>
	/// <name>T IV Mine</name>
	T_IV_Mine = 380,

	/// <summary>
	/// Pipe Manufacturing
	/// </summary>
	/// <name>T IV Pipes</name>
	T_IV_Pipes = 381,

	/// <summary>
	/// Water Extraction
	/// </summary>
	/// <name>T IV Pump</name>
	T_IV_Pump = 382,

	/// <summary>
	/// Effects of Technology
	/// </summary>
	/// <name>T IV Water & Cysts</name>
	T_IV_Water_And_Cysts = 383,

	/// <summary>
	/// Building Blocks
	/// </summary>
	/// <name>TI Building Blocks</name>
	TI_Building_Blocks = 384,

	/// <summary>
	/// Ancient Tablets
	/// </summary>
	/// <name>TI Deep Exploration</name>
	TI_Deep_Exploration = 385,

	/// <summary>
	/// Food Supplies
	/// </summary>
	/// <name>TI Forager</name>
	TI_Forager = 386,

	/// <summary>
	/// Exploring the Wilds
	/// </summary>
	/// <name>TI Glades</name>
	TI_Glades = 387,

	/// <summary>
	/// Harvesters' Camp
	/// </summary>
	/// <name>TI Scavenger</name>
	TI_Scavenger = 388,

	/// <summary>
	/// Stonecutters' Camp
	/// </summary>
	/// <name>TI Stonecutter</name>
	TI_Stonecutter = 389,

	/// <summary>
	/// Woodcutters' Camps
	/// </summary>
	/// <name>TI Woodcutters Camp</name>
	TI_Woodcutters_Camp = 390,

	/// <summary>
	/// Golden Blood
	/// </summary>
	/// <name>Trade Packs and Perks LOW</name>
	Trade_Packs_And_Perks_LOW = 391,



	/// <summary>
	/// The total number of vanilla OrderTypes in the game.
	/// </summary>
	[Obsolete("Use OrderTypesExtensions.Count(). OrderTypes.MAX requires rebuilding your project everytime the API adds/removes enums.", true)]
	MAX = 406
}

/// <summary>
/// Extension methods for the OrderTypes enum to simplify getting and converting data to various types.
/// </summary>
public static class OrderTypesExtensions
{
	/// <summary>
	/// Returns how many enum values are in OrderTypes.
	/// </summary>
	public static int Count()
	{
		return TypeToInternalName.Count;
	}
	
	/// <summary>
	/// Returns an array of all vanilla and modded OrderTypes.
	/// </summary>
	public static OrderTypes[] All()
	{
		OrderTypes[] all = new OrderTypes[TypeToInternalName.Count];
		TypeToInternalName.Keys.CopyTo(all, 0);
		return all;
	}
	
	/// <summary>
	/// Returns the name or internal ID of the model that will be used in the game.
	/// Every OrderTypes should have a unique name as to distinguish it from others.
	/// If no name is found, it will return OrderTypes.Amber_And_Luxury_LOW in the enum and log an error.
	/// </summary>
	public static string ToName(this OrderTypes type)
	{
		if (TypeToInternalName.TryGetValue(type, out var name))
		{
			return name;
		}

		APILogger.LogError($"Cannot find name of OrderTypes: " + type);
		return TypeToInternalName[OrderTypes.Amber_And_Luxury_LOW];
	}
	
	/// <summary>
	/// Returns a OrderTypes associated with the given name.
	/// Every OrderTypes should have a unique name as to distinguish it from others.
	/// If no OrderTypes is found, it will return OrderTypes.Unknown and log a warning.
	/// </summary>
	public static OrderTypes ToOrderTypes(this string name)
	{
		foreach (KeyValuePair<OrderTypes,string> pair in TypeToInternalName)
		{
			if (pair.Value == name)
			{
				return pair.Key;
			}
		}

		APILogger.LogWarning("Cannot find OrderTypes with name: " + name + "\n" + Environment.StackTrace);
		return OrderTypes.Unknown;
	}
	
	/// <summary>
	/// Returns a OrderModel associated with the given name.
	/// OrderModel contain all the data that will be used in the game.
	/// Every OrderModel should have a unique name as to distinguish it from others.
	/// If no OrderModel is found, it will return null and log an error.
	/// </summary>
	public static Eremite.Model.Orders.OrderModel ToOrderModel(this string name)
	{
		Eremite.Model.Orders.OrderModel model = SO.Settings.orders.FirstOrDefault(a=>a.name == name);
		if (model != null)
		{
			return model;
		}
	
		APILogger.LogError("Cannot find OrderModel for OrderTypes with name: " + name);
		return null;
	}

	/// <summary>
	/// Returns a OrderModel associated with the given OrderTypes.
	/// OrderModel contain all the data that will be used in the game.
	/// Every OrderModel should have a unique name as to distinguish it from others.
	/// If no OrderModel is found, it will return null and log an error.
	/// </summary>
	public static Eremite.Model.Orders.OrderModel ToOrderModel(this OrderTypes types)
	{
		return types.ToName().ToOrderModel();
	}
	
	/// <summary>
	/// Returns an array of OrderModel associated with the given OrderTypes.
	/// OrderModel contain all the data that will be used in the game.
	/// Every OrderModel should have a unique name as to distinguish it from others.
	/// If a OrderModel is not found, the element will be replaced with null and an error will be logged.
	/// </summary>
	public static Eremite.Model.Orders.OrderModel[] ToOrderModelArray(this IEnumerable<OrderTypes> collection)
	{
		int count = collection.Count();
		Eremite.Model.Orders.OrderModel[] array = new Eremite.Model.Orders.OrderModel[count];
		int i = 0;
		foreach (OrderTypes element in collection)
		{
			array[i++] = element.ToOrderModel();
		}

		return array;
	}
	
	/// <summary>
	/// Returns an array of OrderModel associated with the given OrderTypes.
	/// OrderModel contain all the data that will be used in the game.
	/// Every OrderModel should have a unique name as to distinguish it from others.
	/// If a OrderModel is not found, the element will be replaced with null and an error will be logged.
	/// </summary>
	public static Eremite.Model.Orders.OrderModel[] ToOrderModelArray(this IEnumerable<string> collection)
	{
		int count = collection.Count();
		Eremite.Model.Orders.OrderModel[] array = new Eremite.Model.Orders.OrderModel[count];
		int i = 0;
		foreach (string element in collection)
		{
			array[i++] = element.ToOrderModel();
		}

		return array;
	}
	
	/// <summary>
	/// Returns an array of OrderModel associated with the given OrderTypes.
	/// OrderModel contain all the data that will be used in the game.
	/// Every OrderModel should have a unique name as to distinguish it from others.
	/// If a OrderModel is not found, it will not be included in the array.
	/// </summary>
	public static Eremite.Model.Orders.OrderModel[] ToOrderModelArrayNoNulls(this IEnumerable<string> collection)
	{
		using(ListPool<Eremite.Model.Orders.OrderModel>.Get(out List<Eremite.Model.Orders.OrderModel> list))
		{
			foreach (string element in collection)
			{
				Eremite.Model.Orders.OrderModel model = element.ToOrderModel();
				if (model != null)
				{
					list.Add(model);
				}
			}
			return list.ToArray();
		}
	}
	
	/// <summary>
	/// Returns an array of OrderModel associated with the given OrderTypes.
	/// OrderModel contain all the data that will be used in the game.
	/// Every OrderModel should have a unique name as to distinguish it from others.
	/// If a OrderModel is not found, it will not be included in the array.
	/// </summary>
	public static Eremite.Model.Orders.OrderModel[] ToOrderModelArrayNoNulls(this IEnumerable<OrderTypes> collection)
	{
		using(ListPool<Eremite.Model.Orders.OrderModel>.Get(out List<Eremite.Model.Orders.OrderModel> list))
		{
			foreach (OrderTypes element in collection)
			{
				Eremite.Model.Orders.OrderModel model = element.ToOrderModel();
				if (model != null)
				{
					list.Add(model);
				}
			}
			return list.ToArray();
		}
	}
	
	internal static readonly Dictionary<OrderTypes, string> TypeToInternalName = new()
	{
		{ OrderTypes.Amber_And_Luxury_LOW, "Amber and Luxury LOW" },                                   // Essence of Wealth
		{ OrderTypes.Amber_Transaction, "Amber Transaction" },                                         // Crystal Feathers
		{ OrderTypes.Amber_Transaction_HIGH, "Amber Transaction HIGH" },                               // Crystal Feathers
		{ OrderTypes.Amber_Transaction_LOW, "Amber Transaction LOW" },                                 // Crystal Feathers
		{ OrderTypes.Ancient_Tablets, "Ancient Tablets" },                                             // Forbidden Essence
		{ OrderTypes.Ancient_Tablets_HIGH, "Ancient Tablets HIGH" },                                   // Forbidden Essence
		{ OrderTypes.Ancient_Tablets_LOW, "Ancient Tablets LOW" },                                     // Forbidden Essence
		{ OrderTypes.Caches, "Caches" },                                                               // Heart of the Forest
		{ OrderTypes.Caches_HIGH, "Caches HIGH" },                                                     // Heart of the Forest
		{ OrderTypes.Caches_LOW, "Caches LOW" },                                                       // Heart of the Forest
		{ OrderTypes.CystsBurned, "CystsBurned" },                                                     // Essence of Corruption
		{ OrderTypes.Deliver_Packs, "Deliver Packs" },                                                 // Heart of Amber
		{ OrderTypes.Deliver_Packs_HIGH, "Deliver Packs HIGH" },                                       // Heart of Amber
		{ OrderTypes.Deliver_Packs_LOW, "Deliver Packs LOW" },                                         // Heart of Amber
		{ OrderTypes.Deliver_Tools, "Deliver Tools" },                                                 // Metal Feathers
		{ OrderTypes.Deliver_Tools_HIGH, "Deliver Tools HIGH" },                                       // Metal Feathers
		{ OrderTypes.Discover_Forbidden_LOW, "Discover Forbidden LOW" },                               // Stormbird Feathers
		{ OrderTypes.Engines_Connected, "Engines Connected" },                                         // Mechanical Heart
		{ OrderTypes.Engines_Connected_HIGH, "Engines Connected HIGH" },                               // Mechanical Heart
		{ OrderTypes.Heart_Parts_And_Sacrifice_LOW, "Heart Parts and Sacrifice LOW" },                 // Heart of the Ancient Flame
		{ OrderTypes.I_Amber, "I Amber" },                                                             // Amber Trade
		{ OrderTypes.I_Blighfuel, "I Blighfuel" },                                                     // Call to Arms
		{ OrderTypes.I_Blue_Metal, "I Blue Metal" },                                                   // Blue Metal
		{ OrderTypes.I_Botanist, "I Botanist" },                                                       // Botanist
		{ OrderTypes.I_Clearing_Glades, "I Clearing Glades" },                                         // Clearing Glades
		{ OrderTypes.I_Clothing, "I Clothing" },                                                       // Rain Protection
		{ OrderTypes.I_Cysts, "I Cysts" },                                                             // The Purge
		{ OrderTypes.I_Cysts_Amount, "I Cysts amount" },                                               // Cyst Cultivation
		{ OrderTypes.I_Eggs, "I Eggs" },                                                               // Egg Collection
		{ OrderTypes.I_Engines, "I Engines" },                                                         // Start Your Engines
		{ OrderTypes.I_Farm_Life, "I Farm Life" },                                                     // Farm Life
		{ OrderTypes.I_Foragers_Camp, "I Foragers Camp" },                                             // Foragers' Camp
		{ OrderTypes.I_Funding_The_Expedition, "I Funding the Expedition" },                           // Funding the Expedition
		{ OrderTypes.I_Garden_Life, "I Garden Life" },                                                 // Garden Life
		{ OrderTypes.I_Herbalist, "I Herbalist" },                                                     // Herbalist
		{ OrderTypes.I_Houses, "I Houses" },                                                           // No Place Like Home
		{ OrderTypes.I_Houses_V2, "I Houses v2" },                                                     // Safe Place
		{ OrderTypes.I_Houses_V3, "I Houses v3" },                                                     // Dwellings
		{ OrderTypes.I_Hunters, "I Hunters" },                                                         // Hunters
		{ OrderTypes.I_Jerky, "I Jerky" },                                                             // Meat Lover
		{ OrderTypes.I_Metal_Veins, "I Metal Veins" },                                                 // Metal Veins
		{ OrderTypes.I_Multiply_Routes, "I Multiply Routes" },                                         // Raising the Stakes
		{ OrderTypes.I_Pipes, "I Pipes" },                                                             // Hydraulics
		{ OrderTypes.I_Porridge, "I Porridge" },                                                       // Healthy Breakfast
		{ OrderTypes.I_Pump, "I Pump" },                                                               // Beginner Engineer
		{ OrderTypes.I_Ranch_Life, "I Ranch Life" },                                                   // Ranch Life
		{ OrderTypes.I_Resolve_Beavers, "I Resolve Beavers" },                                         // The Guild
		{ OrderTypes.I_Resolve_Foxes, "I Resolve Foxes" },                                             // The Pack
		{ OrderTypes.I_Resolve_Frogs, "I Resolve Frogs" },                                             // The Collegium
		{ OrderTypes.I_Resolve_Harpies, "I Resolve Harpies" },                                         // The Flock
		{ OrderTypes.I_Resolve_Humans, "I Resolve Humans" },                                           // People's Resolve
		{ OrderTypes.I_Resolve_Lizards, "I Resolve Lizards" },                                         // The Clan
		{ OrderTypes.I_Ruins, "I Ruins" },                                                             // Reconnaissance
		{ OrderTypes.I_Salt, "I Salt" },                                                               // Salt Miner
		{ OrderTypes.I_Skewers, "I Skewers" },                                                         // Barbecue
		{ OrderTypes.I_Solve_Any_Relic, "I Solve Any Relic" },                                         // Problem Solver
		{ OrderTypes.I_Solve_Dangerous_Relic, "I Solve Dangerous Relic" },                             // Tick Tock
		{ OrderTypes.I_Storm_Water, "I Storm Water" },                                                 // Basic Ingredient
		{ OrderTypes.I_TO_Bat_Resolve, "I TO Bat Resolve" },                                           // Determined Bats
		{ OrderTypes.I_TO_Beaver_Resolve, "I TO Beaver Resolve" },                                     // Joyful Beavers
		{ OrderTypes.I_TO_Dangerous_Relics, "I TO Dangerous Relics" },                                 // Zealous Scouts
		{ OrderTypes.I_TO_Fox_Resolve, "I TO Fox Resolve" },                                           // Joyful Foxes
		{ OrderTypes.I_TO_Frog_Resolve, "I TO Frog Resolve" },                                         // Joyful Frogs
		{ OrderTypes.I_TO_Harpy_Resolve, "I TO Harpy Resolve" },                                       // Joyful Harpies
		{ OrderTypes.I_TO_HUB, "I TO HUB" },                                                           // Speedy Real Estate
		{ OrderTypes.I_TO_Human_Resolve, "I TO Human Resolve" },                                       // Joyful Humans
		{ OrderTypes.I_TO_Lizard_Resolve, "I TO Lizard Resolve" },                                     // Joyful Lizards
		{ OrderTypes.I_TO_Relic_Resolve, "I TO Relic Resolve" },                                       // Hurried Expedition
		{ OrderTypes.I_TO_Ruins_And_Glades, "I TO Ruins and Glades" },                                 // Call of the Ruins
		{ OrderTypes.I_TO_Sold_Amber, "I TO Sold Amber" },                                             // Quick Transaction
		{ OrderTypes.I_TO_Solve_Relics, "I TO Solve Relics" },                                         // Impetuous Explorer
		{ OrderTypes.I_TO_Trade_Routes_With_Value, "I TO Trade Routes With Value" },                   // Supply Thy Neighbor
		{ OrderTypes.I_Trade_Routes, "I Trade Routes" },                                               // Businessman
		{ OrderTypes.I_Trader_Value_Sold, "I Trader Value Sold" },                                     // Booming Economy
		{ OrderTypes.I_Upgrade_Pump, "I Upgrade Pump" },                                               // Water Extraction
		{ OrderTypes.I_Water, "I Water" },                                                             // Fill the Engines
		{ OrderTypes.IA_Glades, "IA Glades" },                                                         // Exploration
		{ OrderTypes.IA_Shelters, "IA Shelters" },                                                     // Shelters
		{ OrderTypes.IA_TO_Build_Shelters, "IA TO Build Shelters" },                                   // Housing Estate
		{ OrderTypes.IA_TO_Discover_Glades, "IA TO Discover Glades" },                                 // Distant Journey
		{ OrderTypes.IA_Woodcutters_Camp, "IA Woodcutters Camp" },                                     // Woodcutters
		{ OrderTypes.IB_Beavers, "IB Beavers" },                                                       // The Grove
		{ OrderTypes.IB_Building_Packs, "IB Building Packs" },                                         // Big Delivery
		{ OrderTypes.IB_Camps, "IB Camps" },                                                           // Camps
		{ OrderTypes.IB_Crops, "IB Crops" },                                                           // Rich Harvest
		{ OrderTypes.IB_Foxes, "IB Foxes" },                                                           // People of the Forest
		{ OrderTypes.IB_Frogs, "IB Frogs" },                                                           // Architects
		{ OrderTypes.IB_Harpies, "IB Harpies" },                                                       // The Nest
		{ OrderTypes.IB_Humans, "IB Humans" },                                                         // Help From the Queen
		{ OrderTypes.IB_Lizards, "IB Lizards" },                                                       // Trappers
		{ OrderTypes.IB_Paths, "IB Paths" },                                                           // Basic Logistics
		{ OrderTypes.IB_Provisions_And_Crops, "IB Provisions and Crops" },                             // Delivery
		{ OrderTypes.IB_Tablet, "IB Tablet" },                                                         // Relics
		{ OrderTypes.IB_Three_Packs, "IB Three Packs" },                                               // Three Packs
		{ OrderTypes.IB_TO_Three_Packs, "IB TO Three Packs" },                                         // Quick Packaging
		{ OrderTypes.IB_Trading_Post, "IB Trading Post" },                                             // Trading Post
		{ OrderTypes.IB_Wood, "IB Wood" },                                                             // Wood Delivery
		{ OrderTypes.II_Advanced_Trading, "II Advanced Trading" },                                     // Advanced Trading
		{ OrderTypes.II_Aid_For_The_Bat_Faction, "II Aid for the Bat Faction" },                       // Aid for the Bat Clan
		{ OrderTypes.II_Aid_For_The_Beaver_Faction, "II Aid for the Beaver Faction" },                 // Aid For the Beaver Clan
		{ OrderTypes.II_Aid_For_The_Fox_Faction, "II Aid for the Fox Faction" },                       // Aid for the Fox Pack
		{ OrderTypes.II_Aid_For_The_Frog_Faction, "II Aid for the Frog Faction" },                     // Aid for the Frog Clan
		{ OrderTypes.II_Aid_For_The_Harpy_Faction, "II Aid for the Harpy Faction" },                   // Aiding the Flock
		{ OrderTypes.II_Aid_For_The_Human_Faction, "II Aid for the Human Faction" },                   // Aid for the Human Clan
		{ OrderTypes.II_Aid_For_The_Lizard_Faction, "II Aid for the Lizard Faction" },                 // Aid for the Lizard Clan
		{ OrderTypes.II_Artisan, "II Artisan" },                                                       // Pottery and Wine
		{ OrderTypes.II_Bat_Influx, "II Bat Influx" },                                                 // Bat Influx
		{ OrderTypes.II_Bat_Population, "II Bat Population" },                                         // Bat Population
		{ OrderTypes.II_Beaver_Influx, "II Beaver Influx" },                                           // Beaver Influx
		{ OrderTypes.II_Beaver_Population, "II Beaver Population" },                                   // Beaver Population
		{ OrderTypes.II_Blight_Post, "II Blight Post" },                                               // Fighting the Storm
		{ OrderTypes.II_Brewery, "II Brewery" },                                                       // Happy Brewing
		{ OrderTypes.II_Coats, "II Coats" },                                                           // Clothing the People
		{ OrderTypes.II_Convert, "II Convert" },                                                       // Restoration
		{ OrderTypes.II_Crops, "II Crops" },                                                           // Advanced Farming
		{ OrderTypes.II_Cysts, "II Cysts" },                                                           // Firestarter
		{ OrderTypes.II_Dangerous_Glades, "II Dangerous Glades" },                                     // Risky Expedition
		{ OrderTypes.II_Engines, "II Engines" },                                                       // Rain Engines
		{ OrderTypes.II_Fishing_Trial_M_S_NB, "II Fishing Trial M S NB" },                             // Algal Bloom
		{ OrderTypes.II_Fishing_Trial_RW_CF_S, "II Fishing Trial RW CF S" },                           // Scaling Up
		{ OrderTypes.II_Fishing_Trial_SO_M_CRW_NB, "II Fishing Trial SO M CRW NB" },                   // Out Fishing
		{ OrderTypes.II_Fox_Influx, "II Fox Influx" },                                                 // Fox Influx
		{ OrderTypes.II_Fox_Population, "II Fox Population" },                                         // Fox Population
		{ OrderTypes.II_Frog_Influx, "II Frog Influx" },                                               // Frog Influx
		{ OrderTypes.II_Frog_Population, "II Frog Population" },                                       // Frog Population
		{ OrderTypes.II_Fuel_And_Building, "II Fuel and Building" },                                   // Important Delivery
		{ OrderTypes.II_Glades, "II Glades" },                                                         // Into the Wilds
		{ OrderTypes.II_Glades_In_Time, "II Glades in Time" },                                         // Into the Unknown
		{ OrderTypes.II_Happy_Beavers, "II Happy Beavers" },                                           // Happy Beavers
		{ OrderTypes.II_Happy_Foxes, "II Happy Foxes" },                                               // Happy Foxes
		{ OrderTypes.II_Happy_Frogs, "II Happy Frogs" },                                               // Happy Frogs
		{ OrderTypes.II_Happy_Harpies, "II Happy Harpies" },                                           // Happy Harpies
		{ OrderTypes.II_Happy_Humans, "II Happy Humans" },                                             // Happy Humans
		{ OrderTypes.II_Happy_Lizards, "II Happy Lizards" },                                           // Happy Lizards
		{ OrderTypes.II_Harpy_Influx, "II Harpy Influx" },                                             // Harpy Influx
		{ OrderTypes.II_Harpy_Population, "II Harpy Population" },                                     // Harpy Population
		{ OrderTypes.II_Human_Houses, "II Human Houses" },                                             // More Houses
		{ OrderTypes.II_Human_Influx, "II Human Influx" },                                             // Human Influx
		{ OrderTypes.II_Human_Population, "II Human Population" },                                     // Human Population
		{ OrderTypes.II_Jerky, "II Jerky" },                                                           // Meat Diet
		{ OrderTypes.II_Jerky_For_Time, "II Jerky For Time" },                                         // Meat Treats
		{ OrderTypes.II_Judgement, "II Judgement" },                                                   // Judgment
		{ OrderTypes.II_Lizard_Influx, "II Lizard Influx" },                                           // Lizard Influx
		{ OrderTypes.II_Lizard_Population, "II Lizard Population" },                                   // Lizard Population
		{ OrderTypes.II_Luxury_Packs, "II Luxury Packs" },                                             // Luxurious Delivery
		{ OrderTypes.II_Means_Of_Production, "II Means of Production" },                               // Building Materials
		{ OrderTypes.II_Multiply_Routes, "II Multiply Routes" },                                       // Stacking Amber
		{ OrderTypes.II_Offering_Butcher, "II Offering Butcher" },                                     // Feast
		{ OrderTypes.II_Outpost, "II Outpost" },                                                       // Outposts
		{ OrderTypes.II_Paths, "II Paths" },                                                           // Infrastructure
		{ OrderTypes.II_Population_Influx, "II Population Influx" },                                   // Population Influx
		{ OrderTypes.II_Rainwater, "II Rainwater" },                                                   // Water Delivery
		{ OrderTypes.II_Route_Value, "II Route Value" },                                               // Profit Margin
		{ OrderTypes.II_Routes, "II Routes" },                                                         // Seller
		{ OrderTypes.II_Sacrifice, "II Sacrifice" },                                                   // Sacrificing
		{ OrderTypes.II_Standing, "II Standing" },                                                     // Making Connections
		{ OrderTypes.II_Tablets, "II Tablets" },                                                       // Ancient Artifacts
		{ OrderTypes.II_TO_Cut_NOTrees, "II TO Cut NOTrees" },                                         // Work Break
		{ OrderTypes.II_TO_Cut_Trees, "II TO Cut Trees" },                                             // Need for Timber
		{ OrderTypes.II_TO_Discover_Dangerous_Glades, "II TO Discover Dangerous Glades" },             // Adventurous Viceroy
		{ OrderTypes.II_TO_Forager_Trial_CRW_AT, "II TO Forager Trial - CRW AT" },                     // Forager's Trial
		{ OrderTypes.II_TO_Forager_Trial_RW, "II TO Forager Trial - RW" },                             // Forager's Trial
		{ OrderTypes.II_TO_Forager_Trial_SO, "II TO Forager Trial - SO" },                             // Forager's Trial
		{ OrderTypes.II_TO_Gathering_Stone, "II TO Gathering Stone" },                                 // Stonecutter's Trial
		{ OrderTypes.II_TO_Glades_Discovery, "II TO Glades Discovery" },                               // Venturesome Leader
		{ OrderTypes.II_TO_Herbalist_Trial_CRW, "II TO Herbalist Trial - CRW" },                       // Herbalist's Trial
		{ OrderTypes.II_TO_Herbalist_Trial_RW_SF, "II TO Herbalist Trial - RW SF" },                   // Herbalist's Trial
		{ OrderTypes.II_TO_Herbalist_Trial_SO, "II TO Herbalist Trial - SO" },                         // Herbalist's Trial
		{ OrderTypes.II_TO_Homes_For_Bats, "II TO Homes for Bats" },                                   // Bat Colony
		{ OrderTypes.II_TO_Homes_For_Beavers, "II TO Homes for Beavers" },                             // Beaver Colony
		{ OrderTypes.II_TO_Homes_For_Foxes, "II TO Homes for Foxes" },                                 // Homes For Foxes
		{ OrderTypes.II_TO_Homes_For_Frogs, "II TO Homes for Frogs" },                                 // Frog Colony
		{ OrderTypes.II_TO_Homes_For_Harpies, "II TO Homes for Harpies" },                             // Harpy Colony
		{ OrderTypes.II_TO_Homes_For_Humans, "II TO Homes for Humans" },                               // Human Colony
		{ OrderTypes.II_TO_Homes_For_Lizards, "II TO Homes for Lizards" },                             // Lizard Colony
		{ OrderTypes.II_TO_HUBs, "II TO HUBs" },                                                       // Outpost
		{ OrderTypes.II_TO_Lumbermill, "II TO Lumbermill" },                                           // Efficiency Test
		{ OrderTypes.II_TO_Sacrificies, "II TO Sacrificies" },                                         // Sacrificial Ceremony
		{ OrderTypes.II_TO_Trappers_Trial_CF_SF, "II TO Trappers Trial - CF SF" },                     // Trapper's Trial
		{ OrderTypes.II_TO_Trappers_Trial_RW_M, "II TO Trappers Trial - RW M" },                       // Trapper's Trial
		{ OrderTypes.II_Trade_Connections, "II Trade Connections" },                                   // Trade Connections
		{ OrderTypes.II_Use_Water, "II Use Water" },                                                   // Rainpunk Engineer
		{ OrderTypes.III_Aesthethics, "III Aesthethics" },                                             // Royal Gardens
		{ OrderTypes.III_Ale_And_Tavern, "III Ale and Tavern" },                                       // Cups and Glasses
		{ OrderTypes.III_Amber_And_Market, "III Amber and Market" },                                   // Charity Fair
		{ OrderTypes.III_Ancient_Tablets, "III Ancient Tablets" },                                     // Lost Knowledge
		{ OrderTypes.III_Archaeology, "III Archaeology" },                                             // Archaeology
		{ OrderTypes.III_Bat_Relatives, "III Bat Relatives" },                                         // Bat Relatives
		{ OrderTypes.III_Beaver_Relatives, "III Beaver Relatives" },                                   // Beaver Relatives
		{ OrderTypes.III_Building_Packs, "III Building Packs" },                                       // Building the Citadel
		{ OrderTypes.III_Coats_NeedForTime, "III Coats NeedForTime" },                                 // New Clothes
		{ OrderTypes.III_Copper, "III Copper" },                                                       // Industry
		{ OrderTypes.III_Costly_Route, "III Costly Route" },                                           // Profitable Trade
		{ OrderTypes.III_Cysts, "III Cysts" },                                                         // Pyromania
		{ OrderTypes.III_Farmfields, "III Farmfields" },                                               // Agriculture
		{ OrderTypes.III_Forum, "III Forum" },                                                         // The Forum
		{ OrderTypes.III_Fox_Relatives, "III Fox Relatives" },                                         // Fox Relatives
		{ OrderTypes.III_Frog_Relatives, "III Frog Relatives" },                                       // Frog Relatives
		{ OrderTypes.III_Frog_Upgrades, "III Frog Upgrades" },                                         // Upgraded Living
		{ OrderTypes.III_Glades, "III Glades" },                                                       // Trailblazing
		{ OrderTypes.III_Glades_In_Time, "III Glades in Time" },                                       // Hasty Explorer
		{ OrderTypes.III_Harpy_Relatives, "III Harpy Relatives" },                                     // Harpy Relatives
		{ OrderTypes.III_Higene, "III Higene" },                                                       // Cleanliness
		{ OrderTypes.III_Hub, "III Hub" },                                                             // Advanced District
		{ OrderTypes.III_Human_Relatives, "III Human Relatives" },                                     // Human Relatives
		{ OrderTypes.III_Leisure_For_Time, "III Leisure for Time" },                                   // Basic Rights
		{ OrderTypes.III_Lizard_Relatives, "III Lizard Relatives" },                                   // Lizard Relatives
		{ OrderTypes.III_Lost_Villagers, "III Lost Villagers" },                                       // Lost in the Woods
		{ OrderTypes.III_Luxury, "III Luxury" },                                                       // Luxury
		{ OrderTypes.III_Provisions_And_Crops, "III Provisions and Crops" },                           // Rations for the Citadel
		{ OrderTypes.III_Pump_Upgrade, "III Pump Upgrade" },                                           // Water Industry
		{ OrderTypes.III_Rain_Collector, "III Rain Collector" },                                       // Advanced Logistics
		{ OrderTypes.III_Religion, "III Religion" },                                                   // Religion
		{ OrderTypes.III_Resolve_Bats, "III Resolve Bats" },                                           // Bat Villagers
		{ OrderTypes.III_Resolve_Beavers, "III Resolve Beavers" },                                     // Beaver Resolve
		{ OrderTypes.III_Resolve_Foxes, "III Resolve Foxes" },                                         // Fox Villagers
		{ OrderTypes.III_Resolve_Frogs, "III Resolve Frogs" },                                         // Frog Resolve
		{ OrderTypes.III_Resolve_Harpies, "III Resolve Harpies" },                                     // Harpy Villagers
		{ OrderTypes.III_Resolve_Humans, "III Resolve Humans" },                                       // Human Villagers
		{ OrderTypes.III_Resolve_Lizards, "III Resolve Lizards" },                                     // Lizard Villagers
		{ OrderTypes.III_Route_Value, "III Route Value" },                                             // Fair Exchange
		{ OrderTypes.III_Routes, "III Routes" },                                                       // Export
		{ OrderTypes.III_Routes_And_Amber, "III Routes And Amber" },                                   // Income Tax
		{ OrderTypes.III_Royal_Gardens, "III Royal Gardens" },                                         // Aesthetics
		{ OrderTypes.III_Ruins, "III Ruins" },                                                         // Ruins
		{ OrderTypes.III_Salt, "III Salt" },                                                           // Salty Delivery
		{ OrderTypes.III_Scrolls_And_Temple, "III Scrolls and Temple" },                               // Brotherhood
		{ OrderTypes.III_Send_To_Citadel, "III Send to Citadel" },                                     // Gifts for the Queen
		{ OrderTypes.III_Service_Bats, "III Service Bats" },                                           // Training
		{ OrderTypes.III_Service_Harpy, "III Service Harpy" },                                         // Healing
		{ OrderTypes.III_Service_Human, "III Service Human" },                                         // Religious Rites
		{ OrderTypes.III_Service_Lizard, "III Service Lizard" },                                       // Arena
		{ OrderTypes.III_Serving_Ale, "III Serving Ale" },                                             // Serving Ale
		{ OrderTypes.III_Solve_Chests, "III Solve Chests" },                                           // Open or send caches
		{ OrderTypes.III_Solve_Dangerous_Relic, "III Solve Dangerous Relic" },                         // Profitable Caution
		{ OrderTypes.III_Standing, "III Standing" },                                                   // Good Friends
		{ OrderTypes.III_TO_Basic_Packs, "III TO Basic Packs" },                                       // Basic Packages
		{ OrderTypes.III_TO_Building_Packs, "III TO Building Packs" },                                 // Building Rush
		{ OrderTypes.III_TO_Chest_Chaser, "III TO Chest Chaser" },                                     // Chest Chaser
		{ OrderTypes.III_TO_Dangerous_Stuff, "III TO Dangerous Stuff" },                               // Foolhardy Man
		{ OrderTypes.III_TO_Digging_Coal, "III TO Digging Coal" },                                     // Coal Fever
		{ OrderTypes.III_TO_Digging_Ore, "III TO Digging Ore" },                                       // Copper Fever
		{ OrderTypes.III_TO_Digging_Salt, "III TO Digging Salt" },                                     // Salt Fever
		{ OrderTypes.III_TO_Engines_And_Water, "III TO Engines and Water" },                           // Let It Rain
		{ OrderTypes.III_TO_Explore_And_Deliver, "III TO Explore and Deliver" },                       // Disturbing the Ancients
		{ OrderTypes.III_TO_Forbidden_Glade, "III TO Forbidden Glade" },                               // Devilish Curiosity
		{ OrderTypes.III_TO_Glades_And_Tools, "III TO Glades and Tools" },                             // Forest Fascination
		{ OrderTypes.III_TO_Rich_Trader, "III TO Rich Trader" },                                       // Wealthy Trader
		{ OrderTypes.III_TO_Ruins_And_Planks, "III TO Ruins and Planks" },                             // Into the Ruins
		{ OrderTypes.III_TO_Shiny, "III TO Shiny" },                                                   // Bling-Bling
		{ OrderTypes.III_TO_Thirsty_Trader, "III TO Thirsty Trader" },                                 // Thirsty Trader
		{ OrderTypes.III_TO_Water_Used, "III TO Water Used" },                                         // The Source
		{ OrderTypes.III_Trade_And_Spark, "III Trade and Spark" },                                     // Trade and Industry
		{ OrderTypes.III_TradePacks, "III TradePacks" },                                               // Trading Goods
		{ OrderTypes.III_Trader_Value_Sold, "III Trader Value Sold" },                                 // Booming Economy
		{ OrderTypes.III_Upgrade_Mine_Coal, "III Upgrade Mine - Coal" },                               // Lumps of Coal
		{ OrderTypes.III_Upgrade_Mine_Copper, "III Upgrade Mine - Copper" },                           // Ore Mining
		{ OrderTypes.III_Use_Blue_Water, "III Use Blue Water" },                                       // Power of the Storm
		{ OrderTypes.III_Use_Green_Water, "III Use Green Water" },                                     // Power of the Drizzle
		{ OrderTypes.III_Use_Yellow_Water, "III Use Yellow Water" },                                   // Power of the Clearance
		{ OrderTypes.III_Valuables, "III Valuables" },                                                 // Luxury Goods
		{ OrderTypes.III_Varied_Delivery, "III Varied Delivery" },                                     // Varied Delivery
		{ OrderTypes.III_Wine_And_Guild_House, "III Wine and Guild House" },                           // Liquid Luck
		{ OrderTypes.IV_2_Complex_Food_For_Time, "IV 2 Complex Food for Time" },                       // Folks Gotta Eat!
		{ OrderTypes.IV_Cysts, "IV Cysts" },                                                           // Pyromancer
		{ OrderTypes.IV_Dangerous_Glades, "IV Dangerous Glades" },                                     // Playing With Fire
		{ OrderTypes.IV_Glades_In_Time, "IV Glades in Time" },                                         // All at Once
		{ OrderTypes.IV_Peddler, "IV Peddler" },                                                       // Peddler
		{ OrderTypes.IV_Rainwater, "IV Rainwater" },                                                   // Infused Rainwater
		{ OrderTypes.IV_Religion_For_Time, "IV Religion for Time" },                                   // The Cult of Fire
		{ OrderTypes.IV_Route_Value, "IV Route Value" },                                               // Export Hub
		{ OrderTypes.IV_Routes, "IV Routes" },                                                         // Trade Baron
		{ OrderTypes.IV_TO_Fearless, "IV TO Fearless" },                                               // Fearless
		{ OrderTypes.IV_TO_Forbidden_Glade, "IV TO Forbidden Glade" },                                 // Ultimate Challenge
		{ OrderTypes.IV_TO_Greedy_Merchant, "IV TO Greedy Merchant" },                                 // Greedy Merchant
		{ OrderTypes.IV_TO_Trading_Master, "IV TO Trading Master" },                                   // Trading Master
		{ OrderTypes.IV_Trade_And_Luxury_Packs, "IV Trade and Luxury Packs" },                         // Trade and Luxury
		{ OrderTypes.IV_Use_Water, "IV Use Water" },                                                   // Rainpunk Enthusiast
		{ OrderTypes.IVA_Building_And_Crops_Packs, "IVA Building and Crops Packs" },                   // Funding an Outpost
		{ OrderTypes.IVA_Farmfields, "IVA Farmfields" },                                               // Focus on Farming
		{ OrderTypes.IVA_Luxury_Goods, "IVA Luxury Goods" },                                           // Luxuries for the Citadel
		{ OrderTypes.IVA_Master_Of_Exploration, "IVA Master of Exploration" },                         // Master of Exploration
		{ OrderTypes.IVA_Outpost, "IVA Outpost" },                                                     // Advanced Outposts
		{ OrderTypes.IVA_Pastries, "IVA Pastries" },                                                   // Pastries
		{ OrderTypes.IVA_Serving_The_People, "IVA Serving the People" },                               // Serving the People
		{ OrderTypes.IVA_Stone_Roads, "IVA Stone Roads" },                                             // Stone Roads
		{ OrderTypes.IVA_Tablets, "IVA Tablets" },                                                     // Deeper into the Wilds
		{ OrderTypes.IVA_TO_Bonfire, "IVA TO Bonfire" },                                               // Great Expansion
		{ OrderTypes.IVA_TO_Cooking, "IVA TO Cooking" },                                               // Advanced Cuisine
		{ OrderTypes.IVA_TO_Glades_Tablets_Relics, "IVA TO Glades Tablets Relics" },                   // Time of Courage
		{ OrderTypes.IVA_TO_Packing, "IVA TO Packing" },                                               // Large Parcel
		{ OrderTypes.IVA_TO_Wood_And_Packs, "IVA TO Wood and Packs" },                                 // Ravenous Axes
		{ OrderTypes.IVA_Trade_Goods, "IVA Trade Goods" },                                             // Goods for the Citadel
		{ OrderTypes.IVA_Wood, "IVA Wood" },                                                           // Wood and Provisions
		{ OrderTypes.IVB_Bat_Majority, "IVB Bat Majority" },                                           // Bat Majority
		{ OrderTypes.IVB_Beaver_Majority, "IVB Beaver Majority" },                                     // Beaver Majority
		{ OrderTypes.IVB_Brawling, "IVB Brawling" },                                                   // Brawling
		{ OrderTypes.IVB_Builders_Tools, "IVB Builders Tools" },                                       // Builder's Tools
		{ OrderTypes.IVB_Education, "IVB Education" },                                                 // Knowledge
		{ OrderTypes.IVB_Fox_Majority, "IVB Fox Majority" },                                           // Fox Majority
		{ OrderTypes.IVB_Frog_Majority, "IVB Frog Majority" },                                         // Frog Majority
		{ OrderTypes.IVB_Harpy_Majority, "IVB Harpy Majority" },                                       // Harpy Majority
		{ OrderTypes.IVB_Human_Majority, "IVB Human Majority" },                                       // Human Majority
		{ OrderTypes.IVB_Leisure, "IVB Leisure" },                                                     // Leisure
		{ OrderTypes.IVB_Lizard_Majority, "IVB Lizard Majority" },                                     // Lizard Majority
		{ OrderTypes.IVB_Rainproof_Coats, "IVB Rainproof Coats" },                                     // Rainproof Coats
		{ OrderTypes.IVB_Rich_Delivery, "IVB Rich Delivery" },                                         // Expensive Delivery
		{ OrderTypes.IVB_TO_Building_Tools, "IVB TO Building Tools" },                                 // Construction Work
		{ OrderTypes.IVB_TO_Engines_Amount, "IVB TO Engines Amount" },                                 // Technological Progress
		{ OrderTypes.IVB_TO_Food_Provision, "IVB TO Food Provision" },                                 // Food Provision
		{ OrderTypes.IVB_Travel_Rations, "IVB Travel Rations" },                                       // Travel Rations
		{ OrderTypes.IVB_Utopia, "IVB Utopia" },                                                       // Utopia
		{ OrderTypes.Needs_Served, "Needs Served" },                                                   // Queen's Feathers
		{ OrderTypes.Needs_Served_HIGH, "Needs Served HIGH" },                                         // Queen's Feathers
		{ OrderTypes.Needs_Served_LOW, "Needs Served LOW" },                                           // Queen's Feathers
		{ OrderTypes.R_Ghost_Assault_Trader, "[R] Ghost Assault Trader" }, 
		{ OrderTypes.R_Ghost_Cut_Trees, "[R] Ghost Cut Trees" }, 
		{ OrderTypes.R_Ghost_Decorations_Aesthetics, "[R] Ghost Decorations Aesthetics" }, 
		{ OrderTypes.R_Ghost_Decorations_Harmony, "[R] Ghost Decorations Harmony" }, 
		{ OrderTypes.R_Ghost_Discover_DangGlades, "[R] Ghost Discover DangGlades" }, 
		{ OrderTypes.R_Ghost_Discover_DangGlades_In_Time, "[R] Ghost Discover DangGlades in Time" }, 
		{ OrderTypes.R_Ghost_Engines, "[R] Ghost Engines" }, 
		{ OrderTypes.R_Ghost_Exile_Villagers, "[R] Ghost Exile Villagers" }, 
		{ OrderTypes.R_Ghost_Forbid_Needs_Beavers, "[R] Ghost Forbid Needs Beavers" }, 
		{ OrderTypes.R_Ghost_Forbid_Needs_Foxes, "[R] Ghost Forbid Needs Foxes" }, 
		{ OrderTypes.R_Ghost_Forbid_Needs_Harpies, "[R] Ghost Forbid Needs Harpies" }, 
		{ OrderTypes.R_Ghost_Forbid_Needs_Humans, "[R] Ghost Forbid Needs Humans" }, 
		{ OrderTypes.R_Ghost_Forbid_Needs_Lizards, "[R] Ghost Forbid Needs Lizards" }, 
		{ OrderTypes.R_Ghost_Generate_Cysts, "[R] Ghost Generate Cysts" }, 
		{ OrderTypes.R_Ghost_Hostility_High, "[R] Ghost Hostility High" }, 
		{ OrderTypes.R_Ghost_Hostility_Low, "[R] Ghost Hostility Low" }, 
		{ OrderTypes.R_Ghost_Housing_Needs, "[R] Ghost Housing Needs" }, 
		{ OrderTypes.R_Ghost_HUBs_Upgrade, "[R] Ghost HUBs upgrade" }, 
		{ OrderTypes.R_Ghost_Human_Houses, "[R] Ghost Human Houses" }, 
		{ OrderTypes.R_Ghost_Keep_Goods, "[R] Ghost Keep Goods" }, 
		{ OrderTypes.R_Ghost_Keep_Villagers, "[R] Ghost Keep Villagers" }, 
		{ OrderTypes.R_Ghost_Leisure, "[R] Ghost Leisure" }, 
		{ OrderTypes.R_Ghost_Luxury, "[R] Ghost Luxury" }, 
		{ OrderTypes.R_Ghost_Rebuild_Ruins, "[R] Ghost Rebuild Ruins" }, 
		{ OrderTypes.R_Ghost_Religion, "[R] Ghost Religion" }, 
		{ OrderTypes.R_Ghost_Remove_Cysts, "[R] Ghost Remove Cysts" }, 
		{ OrderTypes.R_Ghost_Resolve_Foxes, "[R] Ghost Resolve Foxes" }, 
		{ OrderTypes.R_Ghost_Resolve_Harpies, "[R] Ghost Resolve Harpies" }, 
		{ OrderTypes.R_Ghost_Resolve_Lizards, "[R] Ghost Resolve Lizards" }, 
		{ OrderTypes.R_Ghost_Sacrifice_Goods, "[R] Ghost Sacrifice Goods" }, 
		{ OrderTypes.R_Ghost_Salvage_Ruins, "[R] Ghost Salvage Ruins" }, 
		{ OrderTypes.R_Ghost_Send_Goods_To_Citadel, "[R] Ghost Send Goods to Citadel" }, 
		{ OrderTypes.R_Ghost_Service_Needs, "[R] Ghost Service Needs" }, 
		{ OrderTypes.R_Ghost_Solve_DangRelics, "[R] Ghost Solve DangRelics" }, 
		{ OrderTypes.R_Ghost_Starve_Beavers, "[R] Ghost Starve Beavers" }, 
		{ OrderTypes.R_Ghost_Starve_Frogs, "[R] Ghost Starve Frogs" }, 
		{ OrderTypes.R_Ghost_Starve_Humans, "[R] Ghost Starve Humans" }, 
		{ OrderTypes.R_Ghost_Trade_Routes, "[R] Ghost Trade Routes" }, 
		{ OrderTypes.R_Ghost_Trade_Routes_With_Value, "[R] Ghost Trade Routes with Value" }, 
		{ OrderTypes.R_Ghost_Trade_Routes_With_Value_Many, "[R] Ghost Trade Routes with Value Many" }, 
		{ OrderTypes.R_Ghost_Upgrade_Houses, "[R] Ghost Upgrade Houses" }, 
		{ OrderTypes.R_Ghost_Upgrade_Mine, "[R] Ghost Upgrade Mine" }, 
		{ OrderTypes.R_Ghost_Use_Water, "[R] Ghost Use Water" }, 
		{ OrderTypes.Rep_From_Events, "Rep from Events" },                                             // Blood of the Stag
		{ OrderTypes.Rep_From_Events_HIGH, "Rep from Events HIGH" },                                   // Blood of the Stag
		{ OrderTypes.Rep_From_Events_LOW, "Rep from Events LOW" },                                     // Blood of the Stag
		{ OrderTypes.Rep_From_Resolve, "Rep from Resolve" },                                           // Mortal Blood
		{ OrderTypes.Rep_From_Resolve_HIGH, "Rep from Resolve HIGH" },                                 // Mortal Blood
		{ OrderTypes.Rep_From_Resolve_LOW, "Rep from Resolve LOW" },                                   // Mortal Blood
		{ OrderTypes.Resolve, "Resolve" },                                                             // Fire Essence
		{ OrderTypes.Resolve_HIGH, "Resolve HIGH" },                                                   // Fire Essence
		{ OrderTypes.Resolve_LOW, "Resolve LOW" },                                                     // Fire Essence
		{ OrderTypes.Standing, "Standing" },                                                           // Golden Blood
		{ OrderTypes.Standing_HIGH, "Standing HIGH" },                                                 // Golden Blood
		{ OrderTypes.T_II_Brewery, "T II Brewery" },                                                   // Brewing Ale
		{ OrderTypes.T_II_Farm, "T II Farm" },                                                         // Farming
		{ OrderTypes.T_II_Provisions, "T II Provisions" },                                             // Provisions
		{ OrderTypes.T_II_Resolve, "T II Resolve" },                                                   // High Society
		{ OrderTypes.T_II_Smokehouse, "T II Smokehouse" },                                             // Smokehouse
		{ OrderTypes.T_II_Tavern, "T II Tavern" },                                                     // A Place for Rest
		{ OrderTypes.T_II_Trapper, "T II Trapper" },                                                   // First Yield
		{ OrderTypes.T_II_Woodcutters_Camp, "T II Woodcutters Camp" },                                 // Home & Hearth
		{ OrderTypes.T_III_Amber, "T III Amber" },                                                     // Get Rich
		{ OrderTypes.T_III_Beavers_Resolve, "T III Beavers Resolve" },                                 // High Resolve
		{ OrderTypes.T_III_Berries, "T III Berries" },                                                 // Collecting Berries
		{ OrderTypes.T_III_Food, "T III Food" },                                                       // Happy Meal
		{ OrderTypes.T_III_Guild_House, "T III Guild House" },                                         // Fulfilling Needs
		{ OrderTypes.T_III_Packs, "T III Packs" },                                                     // Buying & Selling
		{ OrderTypes.T_III_Rain, "T III Rain" },                                                       // Catching Rainwater
		{ OrderTypes.T_III_Sacrifice, "T III Sacrifice" },                                             // Surviving Requires Sacrifice
		{ OrderTypes.T_III_Trading_Post, "T III Trading Post" },                                       // Traders & Currency
		{ OrderTypes.T_III_Wine, "T III Wine" },                                                       // Winemaking
		{ OrderTypes.T_IV_Blightpost, "T IV Blightpost" },                                             // Blight Fighters
		{ OrderTypes.T_IV_Caches, "T IV Caches" },                                                     // Finders Keepers
		{ OrderTypes.T_IV_Clan_Hall, "T IV Clan Hall" },                                               // Stay in Shape
		{ OrderTypes.T_IV_Engines, "T IV Engines" },                                                   // Rainpunk Technology
		{ OrderTypes.T_IV_Frobidden, "T IV Frobidden" },                                               // Forbidden Fruit
		{ OrderTypes.T_IV_Metal, "T IV Metal" },                                                       // Metallurgy
		{ OrderTypes.T_IV_Mine, "T IV Mine" },                                                         // Mining Basics
		{ OrderTypes.T_IV_Pipes, "T IV Pipes" },                                                       // Pipe Manufacturing
		{ OrderTypes.T_IV_Pump, "T IV Pump" },                                                         // Water Extraction
		{ OrderTypes.T_IV_Water_And_Cysts, "T IV Water & Cysts" },                                     // Effects of Technology
		{ OrderTypes.TI_Building_Blocks, "TI Building Blocks" },                                       // Building Blocks
		{ OrderTypes.TI_Deep_Exploration, "TI Deep Exploration" },                                     // Ancient Tablets
		{ OrderTypes.TI_Forager, "TI Forager" },                                                       // Food Supplies
		{ OrderTypes.TI_Glades, "TI Glades" },                                                         // Exploring the Wilds
		{ OrderTypes.TI_Scavenger, "TI Scavenger" },                                                   // Harvesters' Camp
		{ OrderTypes.TI_Stonecutter, "TI Stonecutter" },                                               // Stonecutters' Camp
		{ OrderTypes.TI_Woodcutters_Camp, "TI Woodcutters Camp" },                                     // Woodcutters' Camps
		{ OrderTypes.Trade_Packs_And_Perks_LOW, "Trade Packs and Perks LOW" },                         // Golden Blood

	};
}
