using System;
using System.Linq;
using System.Collections.Generic;
using UnityEngine.Pool;
using Eremite;
using Eremite.Model.Meta;

namespace ATS_API.Helpers;

// Generated using Version 1.5.2R
public enum MetaRewardTypes
{
	Unknown = -1,
	None,
	
	/// <summary>
	/// CurrencyMetaRewardModel-Artifacts
	/// </summary>
	/// <name>Artifacts 10</name>
	Artifacts_10,

	/// <summary>
	/// CurrencyMetaRewardModel-Artifacts
	/// </summary>
	/// <name>Artifacts 15</name>
	Artifacts_15,

	/// <summary>
	/// CurrencyMetaRewardModel-Artifacts
	/// </summary>
	/// <name>Artifacts 20</name>
	Artifacts_20,

	/// <summary>
	/// CurrencyMetaRewardModel-Artifacts
	/// </summary>
	/// <name>Artifacts 5</name>
	Artifacts_5,

	/// <summary>
	/// ConsumptionControlMetaRewardModel-Consumption Control
	/// </summary>
	/// <name>Consumption Control Activation</name>
	Consumption_Control_Activation,

	/// <summary>
	/// CustomGameMetaRewardModel-Training Expedition
	/// </summary>
	/// <name>Custom Game Activation</name>
	Custom_Game_Activation,

	/// <summary>
	/// EssentialBuildingMetaRewardModel-Big Shelter
	/// </summary>
	/// <name>Essential Big Shelter</name>
	Essential_Big_Shelter,

	/// <summary>
	/// EssentialBuildingMetaRewardModel-Clan Hall
	/// </summary>
	/// <name>Essential Common Hall</name>
	Essential_Common_Hall,

	/// <summary>
	/// EssentialBuildingMetaRewardModel-Crude Workstation
	/// </summary>
	/// <name>Essential Crude Workstation</name>
	Essential_Crude_Workstation,

	/// <summary>
	/// EssentialBuildingMetaRewardModel-Ancient Arch
	/// </summary>
	/// <name>Essential Decor Ancient Arch</name>
	Essential_Decor_Ancient_Arch,

	/// <summary>
	/// EssentialBuildingMetaRewardModel-Ancient Tombstone
	/// </summary>
	/// <name>Essential Decor Ancient Gravestone</name>
	Essential_Decor_Ancient_Gravestone,

	/// <summary>
	/// EssentialBuildingMetaRewardModel-Anvil
	/// </summary>
	/// <name>Essential Decor Anvil</name>
	Essential_Decor_Anvil,

	/// <summary>
	/// EssentialBuildingMetaRewardModel-Barrels
	/// </summary>
	/// <name>Essential Decor Barrels</name>
	Essential_Decor_Barrels,

	/// <summary>
	/// EssentialBuildingMetaRewardModel-Bonfire
	/// </summary>
	/// <name>Essential Decor Bonfire</name>
	Essential_Decor_Bonfire,

	/// <summary>
	/// EssentialBuildingMetaRewardModel-Cages
	/// </summary>
	/// <name>Essential Decor Cages</name>
	Essential_Decor_Cages,

	/// <summary>
	/// EssentialBuildingMetaRewardModel-Chest
	/// </summary>
	/// <name>Essential Decor Chest</name>
	Essential_Decor_Chest,

	/// <summary>
	/// EssentialBuildingMetaRewardModel-Saltwater Pitcher Plant
	/// </summary>
	/// <name>Essential Decor Coastal Plant</name>
	Essential_Decor_Coastal_Plant,

	/// <summary>
	/// EssentialBuildingMetaRewardModel-Coral Growth
	/// </summary>
	/// <name>Essential Decor Coral</name>
	Essential_Decor_Coral,

	/// <summary>
	/// EssentialBuildingMetaRewardModel-Crates
	/// </summary>
	/// <name>Essential Decor Crates</name>
	Essential_Decor_Crates,

	/// <summary>
	/// EssentialBuildingMetaRewardModel-Fence
	/// </summary>
	/// <name>Essential Decor Fence</name>
	Essential_Decor_Fence,

	/// <summary>
	/// EssentialBuildingMetaRewardModel-Fence Corner
	/// </summary>
	/// <name>Essential Decor Fence Corner</name>
	Essential_Decor_Fence_Corner,

	/// <summary>
	/// EssentialBuildingMetaRewardModel-Fire Shrine
	/// </summary>
	/// <name>Essential Decor Fire Shrine</name>
	Essential_Decor_Fire_Shrine,

	/// <summary>
	/// EssentialBuildingMetaRewardModel-Fish Mount
	/// </summary>
	/// <name>Essential Decor Fish</name>
	Essential_Decor_Fish,

	/// <summary>
	/// EssentialBuildingMetaRewardModel-Flower Bed
	/// </summary>
	/// <name>Essential Decor Flower Bed</name>
	Essential_Decor_Flower_Bed,

	/// <summary>
	/// EssentialBuildingMetaRewardModel-Overgrown Fence
	/// </summary>
	/// <name>Essential Decor Fox Fence</name>
	Essential_Decor_Fox_Fence,

	/// <summary>
	/// EssentialBuildingMetaRewardModel-Overgrown Fence Corner
	/// </summary>
	/// <name>Essential Decor Fox Fence Corner</name>
	Essential_Decor_Fox_Fence_Corner,

	/// <summary>
	/// EssentialBuildingMetaRewardModel-Evergreen Shrub
	/// </summary>
	/// <name>Essential Decor Frog Tree</name>
	Essential_Decor_Frog_Tree,

	/// <summary>
	/// EssentialBuildingMetaRewardModel-Gate
	/// </summary>
	/// <name>Essential Decor Gate</name>
	Essential_Decor_Gate,

	/// <summary>
	/// EssentialBuildingMetaRewardModel-Golden Leaf Plant
	/// </summary>
	/// <name>Essential Decor Golden Leaf</name>
	Essential_Decor_Golden_Leaf,

	/// <summary>
	/// EssentialBuildingMetaRewardModel-Industrial Chimney
	/// </summary>
	/// <name>Essential Decor Industrail Chimney</name>
	Essential_Decor_Industrail_Chimney,

	/// <summary>
	/// EssentialBuildingMetaRewardModel-Lamp
	/// </summary>
	/// <name>Essential Decor Lamp</name>
	Essential_Decor_Lamp,

	/// <summary>
	/// EssentialBuildingMetaRewardModel-Lizard Post
	/// </summary>
	/// <name>Essential Decor Lizard Post</name>
	Essential_Decor_Lizard_Post,

	/// <summary>
	/// EssentialBuildingMetaRewardModel-Marble Fountain
	/// </summary>
	/// <name>Essential Decor Marbe Fountain</name>
	Essential_Decor_Marbe_Fountain,

	/// <summary>
	/// EssentialBuildingMetaRewardModel-Monument of Greed
	/// </summary>
	/// <name>Essential Decor Monument of Greed</name>
	Essential_Decor_Monument_Of_Greed,

	/// <summary>
	/// EssentialBuildingMetaRewardModel-Decorative Fungus
	/// </summary>
	/// <name>Essential Decor Mushroom</name>
	Essential_Decor_Mushroom,

	/// <summary>
	/// EssentialBuildingMetaRewardModel-Nightfern
	/// </summary>
	/// <name>Essential Decor Nightfern</name>
	Essential_Decor_Nightfern,

	/// <summary>
	/// EssentialBuildingMetaRewardModel-Ornate Column
	/// </summary>
	/// <name>Essential Decor Ornate Column</name>
	Essential_Decor_Ornate_Column,

	/// <summary>
	/// EssentialBuildingMetaRewardModel-Pipe
	/// </summary>
	/// <name>Essential Decor Pipe</name>
	Essential_Decor_Pipe,

	/// <summary>
	/// EssentialBuildingMetaRewardModel-Pipe Cross
	/// </summary>
	/// <name>Essential Decor Pipe Cross</name>
	Essential_Decor_Pipe_Cross,

	/// <summary>
	/// EssentialBuildingMetaRewardModel-Pipe Elbow
	/// </summary>
	/// <name>Essential Decor Pipe Elbow</name>
	Essential_Decor_Pipe_Elbow,

	/// <summary>
	/// EssentialBuildingMetaRewardModel-Pipe Ending
	/// </summary>
	/// <name>Essential Decor Pipe End</name>
	Essential_Decor_Pipe_End,

	/// <summary>
	/// EssentialBuildingMetaRewardModel-Pipe T-Connector
	/// </summary>
	/// <name>Essential Decor Pipe T Cross</name>
	Essential_Decor_Pipe_T_Cross,

	/// <summary>
	/// EssentialBuildingMetaRewardModel-Valve
	/// </summary>
	/// <name>Essential Decor Pipe Valve</name>
	Essential_Decor_Pipe_Valve,

	/// <summary>
	/// EssentialBuildingMetaRewardModel-Road Sign
	/// </summary>
	/// <name>Essential Decor Road Sign</name>
	Essential_Decor_Road_Sign,

	/// <summary>
	/// EssentialBuildingMetaRewardModel-Thorny Reed
	/// </summary>
	/// <name>Essential Decor Scarlet Decor</name>
	Essential_Decor_Scarlet_Decor,

	/// <summary>
	/// EssentialBuildingMetaRewardModel-Rainpunk Barrels
	/// </summary>
	/// <name>Essential Decor Side Barrels</name>
	Essential_Decor_Side_Barrels,

	/// <summary>
	/// EssentialBuildingMetaRewardModel-Signboard
	/// </summary>
	/// <name>Essential Decor Signboard</name>
	Essential_Decor_Signboard,

	/// <summary>
	/// EssentialBuildingMetaRewardModel-Stone Fence
	/// </summary>
	/// <name>Essential Decor Stone Fence</name>
	Essential_Decor_Stone_Fence,

	/// <summary>
	/// EssentialBuildingMetaRewardModel-Stone Fence Corner
	/// </summary>
	/// <name>Essential Decor Stone Fence Corner</name>
	Essential_Decor_Stone_Fence_Corner,

	/// <summary>
	/// EssentialBuildingMetaRewardModel-Wall Crossing
	/// </summary>
	/// <name>Essential Decor Tower</name>
	Essential_Decor_Tower,

	/// <summary>
	/// EssentialBuildingMetaRewardModel-Town Board
	/// </summary>
	/// <name>Essential Decor Town Board</name>
	Essential_Decor_Town_Board,

	/// <summary>
	/// EssentialBuildingMetaRewardModel-Umbrella
	/// </summary>
	/// <name>Essential Decor Umbrella</name>
	Essential_Decor_Umbrella,

	/// <summary>
	/// EssentialBuildingMetaRewardModel-Wall
	/// </summary>
	/// <name>Essential Decor Wall</name>
	Essential_Decor_Wall,

	/// <summary>
	/// EssentialBuildingMetaRewardModel-Wall Corner
	/// </summary>
	/// <name>Essential Decor Wall Corner</name>
	Essential_Decor_Wall_Corner,

	/// <summary>
	/// EssentialBuildingMetaRewardModel-Water Barrels
	/// </summary>
	/// <name>Essential Decor Water Barrels</name>
	Essential_Decor_Water_Barrels,

	/// <summary>
	/// EssentialBuildingMetaRewardModel-Water Shrine
	/// </summary>
	/// <name>Essential Decor Water Shrine</name>
	Essential_Decor_Water_Shrine,

	/// <summary>
	/// EssentialBuildingMetaRewardModel-Overgrown Well
	/// </summary>
	/// <name>Essential Decor Well</name>
	Essential_Decor_Well,

	/// <summary>
	/// EssentialBuildingMetaRewardModel-Farm Field
	/// </summary>
	/// <name>Essential Farmfield</name>
	Essential_Farmfield,

	/// <summary>
	/// EssentialBuildingMetaRewardModel-Harvesters' Camp
	/// </summary>
	/// <name>Essential Harvester</name>
	Essential_Harvester,

	/// <summary>
	/// EssentialBuildingMetaRewardModel-Makeshift Post
	/// </summary>
	/// <name>Essential Makeshift Post</name>
	Essential_Makeshift_Post,

	/// <summary>
	/// EssentialBuildingMetaRewardModel-Mine
	/// </summary>
	/// <name>Essential Mine</name>
	Essential_Mine,

	/// <summary>
	/// EssentialBuildingMetaRewardModel-Paved Road
	/// </summary>
	/// <name>Essential Paved Road</name>
	Essential_Paved_Road,

	/// <summary>
	/// EssentialBuildingMetaRewardModel-Small Fishing Hut
	/// </summary>
	/// <name>Essential Primitive Fishing Hut</name>
	Essential_Primitive_Fishing_Hut,

	/// <summary>
	/// EssentialBuildingMetaRewardModel-Small Foragers' Camp
	/// </summary>
	/// <name>Essential Primitive Forager</name>
	Essential_Primitive_Forager,

	/// <summary>
	/// EssentialBuildingMetaRewardModel-Small Herbalists' Camp
	/// </summary>
	/// <name>Essential Primitive Herbalist</name>
	Essential_Primitive_Herbalist,

	/// <summary>
	/// EssentialBuildingMetaRewardModel-Small Trappers' Camp
	/// </summary>
	/// <name>Essential Primitive Trapper</name>
	Essential_Primitive_Trapper,

	/// <summary>
	/// EssentialBuildingMetaRewardModel-Reinforced Road
	/// </summary>
	/// <name>Essential Reinforced Road</name>
	Essential_Reinforced_Road,

	/// <summary>
	/// EssentialBuildingMetaRewardModel-Shelter
	/// </summary>
	/// <name>Essential Shelter</name>
	Essential_Shelter,

	/// <summary>
	/// EssentialBuildingMetaRewardModel-Small Hearth
	/// </summary>
	/// <name>Essential Small Hearth</name>
	Essential_Small_Hearth,

	/// <summary>
	/// EssentialBuildingMetaRewardModel-Stonecutters' Camp
	/// </summary>
	/// <name>Essential Stonecutter</name>
	Essential_Stonecutter,

	/// <summary>
	/// EssentialBuildingMetaRewardModel-Small Warehouse
	/// </summary>
	/// <name>Essential Storage</name>
	Essential_Storage,

	/// <summary>
	/// EssentialBuildingMetaRewardModel-Small Hearth
	/// </summary>
	/// <name>Essential Temporary Hearth</name>
	Essential_Temporary_Hearth,

	/// <summary>
	/// EssentialBuildingMetaRewardModel-Trading Post
	/// </summary>
	/// <name>Essential Trading Post</name>
	Essential_Trading_Post,

	/// <summary>
	/// EssentialBuildingMetaRewardModel-Woodcutters' Camp
	/// </summary>
	/// <name>Essential Woodcutters Camp</name>
	Essential_Woodcutters_Camp,

	/// <summary>
	/// CurrencyMetaRewardModel-Food Stockpiles
	/// </summary>
	/// <name>Food Stockpiles 10</name>
	Food_Stockpiles_10,

	/// <summary>
	/// CurrencyMetaRewardModel-Food Stockpiles
	/// </summary>
	/// <name>Food Stockpiles 15</name>
	Food_Stockpiles_15,

	/// <summary>
	/// CurrencyMetaRewardModel-Food Stockpiles
	/// </summary>
	/// <name>Food Stockpiles 20</name>
	Food_Stockpiles_20,

	/// <summary>
	/// CurrencyMetaRewardModel-Food Stockpiles
	/// </summary>
	/// <name>Food Stockpiles 25</name>
	Food_Stockpiles_25,

	/// <summary>
	/// CurrencyMetaRewardModel-Food Stockpiles
	/// </summary>
	/// <name>Food Stockpiles 30</name>
	Food_Stockpiles_30,

	/// <summary>
	/// CurrencyMetaRewardModel-Food Stockpiles
	/// </summary>
	/// <name>Food Stockpiles 5</name>
	Food_Stockpiles_5,

	/// <summary>
	/// ExpMetaRewardModel-Honor Badge
	/// </summary>
	/// <name>Goals Exp Reward - Regular</name>
	Goals_Exp_Reward_Regular,

	/// <summary>
	/// HouseUpgradesUnlockMetaRewardModel-House Upgrades: Beavers
	/// </summary>
	/// <name>House Upgrades Unlock - Beavers</name>
	House_Upgrades_Unlock_Beavers,

	/// <summary>
	/// HouseUpgradesUnlockMetaRewardModel-House Upgrades: Foxes
	/// </summary>
	/// <name>House Upgrades Unlock - Foxes</name>
	House_Upgrades_Unlock_Foxes,

	/// <summary>
	/// HouseUpgradesUnlockMetaRewardModel-House Upgrades: Frogs
	/// </summary>
	/// <name>House Upgrades Unlock - Frogs</name>
	House_Upgrades_Unlock_Frogs,

	/// <summary>
	/// HouseUpgradesUnlockMetaRewardModel-House Upgrades: Harpies
	/// </summary>
	/// <name>House Upgrades Unlock - Harpies</name>
	House_Upgrades_Unlock_Harpies,

	/// <summary>
	/// HouseUpgradesUnlockMetaRewardModel-House Upgrades: Humans
	/// </summary>
	/// <name>House Upgrades Unlock - Humans</name>
	House_Upgrades_Unlock_Humans,

	/// <summary>
	/// HouseUpgradesUnlockMetaRewardModel-House Upgrades: Lizards
	/// </summary>
	/// <name>House Upgrades Unlock - Lizards</name>
	House_Upgrades_Unlock_Lizards,

	/// <summary>
	/// IronmanActivationMetaRewardModel-Queen's Hand Trial
	/// </summary>
	/// <name>Ironman Activation</name>
	Ironman_Activation,

	/// <summary>
	/// CurrencyMetaRewardModel-Machinery
	/// </summary>
	/// <name>Machinery 10</name>
	Machinery_10,

	/// <summary>
	/// CurrencyMetaRewardModel-Machinery
	/// </summary>
	/// <name>Machinery 15</name>
	Machinery_15,

	/// <summary>
	/// CurrencyMetaRewardModel-Machinery
	/// </summary>
	/// <name>Machinery 20</name>
	Machinery_20,

	/// <summary>
	/// CurrencyMetaRewardModel-Machinery
	/// </summary>
	/// <name>Machinery 25</name>
	Machinery_25,

	/// <summary>
	/// CurrencyMetaRewardModel-Machinery
	/// </summary>
	/// <name>Machinery 5</name>
	Machinery_5,

	/// <summary>
	/// RaceMetaRewardModel-Fox
	/// </summary>
	/// <name>Meta Foxes Unlock</name>
	Meta_Foxes_Unlock,

	/// <summary>
	/// RaceMetaRewardModel-Frog
	/// </summary>
	/// <name>Meta Frogs Unlock</name>
	Meta_Frogs_Unlock,

	/// <summary>
	/// RaceMetaRewardModel-Harpy
	/// </summary>
	/// <name>Meta Harpies Unlock</name>
	Meta_Harpies_Unlock,

	/// <summary>
	/// EffectMetaRewardModel-Dual Carriage System
	/// </summary>
	/// <name>Meta Perk Unlock 2 Hauling Carts in Main Warehouse</name>
	Meta_Perk_Unlock_2_Hauling_Carts_In_Main_Warehouse,

	/// <summary>
	/// EffectMetaRewardModel-Over-Diligent Woodworkers
	/// </summary>
	/// <name>Meta Perk Unlock Accidental Barrels</name>
	Meta_Perk_Unlock_Accidental_Barrels,

	/// <summary>
	/// EffectMetaRewardModel-Alarm Bells
	/// </summary>
	/// <name>Meta Perk Unlock Alarm Bells</name>
	Meta_Perk_Unlock_Alarm_Bells,

	/// <summary>
	/// EffectMetaRewardModel-Stormwalker Tax
	/// </summary>
	/// <name>Meta Perk Unlock Amber for Newcomers</name>
	Meta_Perk_Unlock_Amber_For_Newcomers,

	/// <summary>
	/// EffectMetaRewardModel-Deep Pockets
	/// </summary>
	/// <name>Meta Perk Unlock Amber for Trade Routes</name>
	Meta_Perk_Unlock_Amber_For_Trade_Routes,

	/// <summary>
	/// EffectMetaRewardModel-Bed and Breakfast
	/// </summary>
	/// <name>Meta Perk Unlock Amber for Trader Visit</name>
	Meta_Perk_Unlock_Amber_For_Trader_Visit,

	/// <summary>
	/// EffectMetaRewardModel-Counterfeit Amber
	/// </summary>
	/// <name>Meta Perk Unlock Amber for Water</name>
	Meta_Perk_Unlock_Amber_For_Water,

	/// <summary>
	/// EffectMetaRewardModel-Lumber Tax
	/// </summary>
	/// <name>Meta Perk Unlock Amber for Wood</name>
	Meta_Perk_Unlock_Amber_For_Wood,

	/// <summary>
	/// EffectMetaRewardModel-Back to Nature
	/// </summary>
	/// <name>Meta Perk Unlock Back to Nature</name>
	Meta_Perk_Unlock_Back_To_Nature,

	/// <summary>
	/// EffectMetaRewardModel-Fish Scraps
	/// </summary>
	/// <name>Meta Perk Unlock Bait For Crafting</name>
	Meta_Perk_Unlock_Bait_For_Crafting,

	/// <summary>
	/// EffectMetaRewardModel-Reckless Plunder
	/// </summary>
	/// <name>Meta Perk Unlock Cache Rewards for Nodes</name>
	Meta_Perk_Unlock_Cache_Rewards_For_Nodes,

	/// <summary>
	/// EffectMetaRewardModel-Burnt to a Crisp
	/// </summary>
	/// <name>Meta Perk Unlock Coal for Cyst</name>
	Meta_Perk_Unlock_Coal_For_Cyst,

	/// <summary>
	/// EffectMetaRewardModel-Without Restrictions
	/// </summary>
	/// <name>Meta Perk Unlock Consumption Control for Extra Production</name>
	Meta_Perk_Unlock_Consumption_Control_For_Extra_Production,

	/// <summary>
	/// EffectMetaRewardModel-Copper Extractor
	/// </summary>
	/// <name>Meta Perk Unlock Copper for each tree</name>
	Meta_Perk_Unlock_Copper_For_Each_Tree,

	/// <summary>
	/// EffectMetaRewardModel-Firekeeper's Armor
	/// </summary>
	/// <name>Meta Perk Unlock Corruption Per Removed Cyst -50</name>
	Meta_Perk_Unlock_Corruption_Per_Removed_Cyst_Minus50,

	/// <summary>
	/// EffectMetaRewardModel-Small Distillery
	/// </summary>
	/// <name>Meta Perk Unlock Crystaline Water</name>
	Meta_Perk_Unlock_Crystaline_Water,

	/// <summary>
	/// EffectMetaRewardModel-Blightrot Pruner
	/// </summary>
	/// <name>Meta Perk Unlock Eggs For Cysts</name>
	Meta_Perk_Unlock_Eggs_For_Cysts,

	/// <summary>
	/// EffectMetaRewardModel-Exploration Expedition
	/// </summary>
	/// <name>Meta Perk Unlock Exploring Expedition</name>
	Meta_Perk_Unlock_Exploring_Expedition,

	/// <summary>
	/// EffectMetaRewardModel-Worker's Rations
	/// </summary>
	/// <name>Meta Perk Unlock Extra Prod for consumption</name>
	Meta_Perk_Unlock_Extra_Prod_For_Consumption,

	/// <summary>
	/// EffectMetaRewardModel-Guild Catalogue
	/// </summary>
	/// <name>Meta Perk Unlock Extra Trader Merch</name>
	Meta_Perk_Unlock_Extra_Trader_Merch,

	/// <summary>
	/// EffectMetaRewardModel-Old Fedora Hat
	/// </summary>
	/// <name>Meta Perk Unlock Fedora Hat</name>
	Meta_Perk_Unlock_Fedora_Hat,

	/// <summary>
	/// EffectMetaRewardModel-Forge Trip Hammer
	/// </summary>
	/// <name>Meta Perk Unlock Forge Trip Hammer</name>
	Meta_Perk_Unlock_Forge_Trip_Hammer,

	/// <summary>
	/// EffectMetaRewardModel-Overzealous Architects
	/// </summary>
	/// <name>Meta Perk Unlock Frog DLC - Blueprints for Upgrades</name>
	Meta_Perk_Unlock_Frog_DLC_Blueprints_For_Upgrades,

	/// <summary>
	/// EffectMetaRewardModel-Borrowed Time
	/// </summary>
	/// <name>Meta Perk Unlock Frog DLC - Borrowed Time</name>
	Meta_Perk_Unlock_Frog_DLC_Borrowed_Time,

	/// <summary>
	/// EffectMetaRewardModel-City of Wonders
	/// </summary>
	/// <name>Meta Perk Unlock Frog DLC - City of Wonders</name>
	Meta_Perk_Unlock_Frog_DLC_City_Of_Wonders,

	/// <summary>
	/// EffectMetaRewardModel-Frog Clan Support
	/// </summary>
	/// <name>Meta Perk Unlock Frog DLC - Frog Clan Support</name>
	Meta_Perk_Unlock_Frog_DLC_Frog_Clan_Support,

	/// <summary>
	/// EffectMetaRewardModel-Frog Friendship
	/// </summary>
	/// <name>Meta Perk Unlock Frog DLC - Frog Friendship</name>
	Meta_Perk_Unlock_Frog_DLC_Frog_Friendship,

	/// <summary>
	/// EffectMetaRewardModel-Strength in Numbers
	/// </summary>
	/// <name>Meta Perk Unlock Frog DLC - Strength in Numbers</name>
	Meta_Perk_Unlock_Frog_DLC_Strength_In_Numbers,

	/// <summary>
	/// EffectMetaRewardModel-Hauling Cart
	/// </summary>
	/// <name>Meta Perk Unlock Hauling Cart in All Warehouses</name>
	Meta_Perk_Unlock_Hauling_Cart_In_All_Warehouses,

	/// <summary>
	/// EffectMetaRewardModel-Frequent Patrols
	/// </summary>
	/// <name>Meta Perk Unlock Hostility for Relics</name>
	Meta_Perk_Unlock_Hostility_For_Relics,

	/// <summary>
	/// EffectMetaRewardModel-Baptism of Fire
	/// </summary>
	/// <name>Meta Perk Unlock Hostility for Removed Cysts</name>
	Meta_Perk_Unlock_Hostility_For_Removed_Cysts,

	/// <summary>
	/// EffectMetaRewardModel-Calming Water
	/// </summary>
	/// <name>Meta Perk Unlock Hostility for Water</name>
	Meta_Perk_Unlock_Hostility_For_Water,

	/// <summary>
	/// EffectMetaRewardModel-Crowded Houses
	/// </summary>
	/// <name>Meta Perk Unlock Houses Global Capacity +1</name>
	Meta_Perk_Unlock_Houses_Global_Capacity_Plus1,

	/// <summary>
	/// EffectMetaRewardModel-Queen's Gift
	/// </summary>
	/// <name>Meta Perk Unlock HP for Impatience</name>
	Meta_Perk_Unlock_HP_For_Impatience,

	/// <summary>
	/// EffectMetaRewardModel-Safe Haven
	/// </summary>
	/// <name>Meta Perk Unlock Hubs for hostility</name>
	Meta_Perk_Unlock_Hubs_For_Hostility,

	/// <summary>
	/// EffectMetaRewardModel-Woodpecker Technique
	/// </summary>
	/// <name>Meta Perk Unlock Insect for tree</name>
	Meta_Perk_Unlock_Insect_For_Tree,

	/// <summary>
	/// EffectMetaRewardModel-Flame Amulets
	/// </summary>
	/// <name>Meta Perk Unlock LessHostilityPerWoodcutter</name>
	Meta_Perk_Unlock_LessHostilityPerWoodcutter,

	/// <summary>
	/// EffectMetaRewardModel-Firelink Ritual
	/// </summary>
	/// <name>Meta Perk Unlock Lower Hostility For Religion</name>
	Meta_Perk_Unlock_Lower_Hostility_For_Religion,

	/// <summary>
	/// EffectMetaRewardModel-Mist Piercers
	/// </summary>
	/// <name>Meta Perk Unlock Mist Piercers</name>
	Meta_Perk_Unlock_Mist_Piercers,

	/// <summary>
	/// EffectMetaRewardModel-Moldy Grain Seeds
	/// </summary>
	/// <name>Meta Perk Unlock Mold Grain</name>
	Meta_Perk_Unlock_Mold_Grain,

	/// <summary>
	/// EffectMetaRewardModel-Trade Negotiations
	/// </summary>
	/// <name>Meta Perk Unlock More Amber from Routes</name>
	Meta_Perk_Unlock_More_Amber_From_Routes,

	/// <summary>
	/// EffectMetaRewardModel-Rich Glades
	/// </summary>
	/// <name>Meta Perk Unlock More Node Charges</name>
	Meta_Perk_Unlock_More_Node_Charges,

	/// <summary>
	/// EffectMetaRewardModel-Economic Migration
	/// </summary>
	/// <name>Meta Perk Unlock Newcomer Rate for Trade Routes</name>
	Meta_Perk_Unlock_Newcomer_Rate_For_Trade_Routes,

	/// <summary>
	/// EffectMetaRewardModel-Overexploitation
	/// </summary>
	/// <name>Meta Perk Unlock Overexploitation</name>
	Meta_Perk_Unlock_Overexploitation,

	/// <summary>
	/// EffectMetaRewardModel-Free Samples
	/// </summary>
	/// <name>Meta Perk Unlock Parts for Trade</name>
	Meta_Perk_Unlock_Parts_For_Trade,

	/// <summary>
	/// EffectMetaRewardModel-Filling Dish
	/// </summary>
	/// <name>Meta Perk Unlock Porridge Prod for water</name>
	Meta_Perk_Unlock_Porridge_Prod_For_Water,

	/// <summary>
	/// EffectMetaRewardModel-Firekeeper's Prayer
	/// </summary>
	/// <name>Meta Perk Unlock Relic time reduction</name>
	Meta_Perk_Unlock_Relic_Time_Reduction,

	/// <summary>
	/// EffectMetaRewardModel-Trade Hub
	/// </summary>
	/// <name>Meta Perk Unlock Reputation from Trade</name>
	Meta_Perk_Unlock_Reputation_From_Trade,

	/// <summary>
	/// EffectMetaRewardModel-Prosperous Archaeology
	/// </summary>
	/// <name>Meta Perk Unlock Resolve for Chests</name>
	Meta_Perk_Unlock_Resolve_For_Chests,

	/// <summary>
	/// EffectMetaRewardModel-Generous Rations
	/// </summary>
	/// <name>Meta Perk Unlock Resolve for consumption</name>
	Meta_Perk_Unlock_Resolve_For_Consumption,

	/// <summary>
	/// EffectMetaRewardModel-Rebellious Spirit
	/// </summary>
	/// <name>Meta Perk Unlock Resolve for Impatience</name>
	Meta_Perk_Unlock_Resolve_For_Impatience,

	/// <summary>
	/// EffectMetaRewardModel-Prosperous Settlement
	/// </summary>
	/// <name>Meta Perk Unlock Resolve for Sales</name>
	Meta_Perk_Unlock_Resolve_For_Sales,

	/// <summary>
	/// EffectMetaRewardModel-Friendly Relations
	/// </summary>
	/// <name>Meta Perk Unlock Resolve for Standing</name>
	Meta_Perk_Unlock_Resolve_For_Standing,

	/// <summary>
	/// EffectMetaRewardModel-Frequent Caravans
	/// </summary>
	/// <name>Meta Perk Unlock Resolve for started Route</name>
	Meta_Perk_Unlock_Resolve_For_Started_Route,

	/// <summary>
	/// EffectMetaRewardModel-Stormwalker Training
	/// </summary>
	/// <name>Meta Perk Unlock Route Less Travel Time</name>
	Meta_Perk_Unlock_Route_Less_Travel_Time,

	/// <summary>
	/// EffectMetaRewardModel-Royal Guard Training
	/// </summary>
	/// <name>Meta Perk Unlock Royal Guard Training</name>
	Meta_Perk_Unlock_Royal_Guard_Training,

	/// <summary>
	/// EffectMetaRewardModel-Fiery Wrath
	/// </summary>
	/// <name>Meta Perk Unlock Sacrifice Cost for Impatience</name>
	Meta_Perk_Unlock_Sacrifice_Cost_For_Impatience,

	/// <summary>
	/// EffectMetaRewardModel-Bone Tools
	/// </summary>
	/// <name>Meta Perk Unlock Tools for death</name>
	Meta_Perk_Unlock_Tools_For_Death,

	/// <summary>
	/// EffectMetaRewardModel-Improvised Tools
	/// </summary>
	/// <name>Meta Perk Unlock Tools for Glade for Resolve</name>
	Meta_Perk_Unlock_Tools_For_Glade_For_Resolve,

	/// <summary>
	/// EffectMetaRewardModel-Tightened Belt
	/// </summary>
	/// <name>Meta Perk Unlock Trade Routes Bonus Fuel</name>
	Meta_Perk_Unlock_Trade_Routes_Bonus_Fuel,

	/// <summary>
	/// EffectMetaRewardModel-Urban Planning
	/// </summary>
	/// <name>Meta Perk Unlock Trade routes for housing spots</name>
	Meta_Perk_Unlock_Trade_Routes_For_Housing_Spots,

	/// <summary>
	/// EffectMetaRewardModel-Trade Logs
	/// </summary>
	/// <name>Meta Perk Unlock Trading Packs</name>
	Meta_Perk_Unlock_Trading_Packs,

	/// <summary>
	/// EffectMetaRewardModel-Hidden from the Queen
	/// </summary>
	/// <name>Meta Perk Unlock VillagerDeathEffectBlock</name>
	Meta_Perk_Unlock_VillagerDeathEffectBlock,

	/// <summary>
	/// EffectMetaRewardModel-From the Shadows
	/// </summary>
	/// <name>Meta Perk Unlock Villagers For Corruption</name>
	Meta_Perk_Unlock_Villagers_For_Corruption,

	/// <summary>
	/// EffectMetaRewardModel-Book of Water
	/// </summary>
	/// <name>Meta Perk Unlock Water Crit For Fishing</name>
	Meta_Perk_Unlock_Water_Crit_For_Fishing,

	/// <summary>
	/// EffectMetaRewardModel-Smuggler's Visit
	/// </summary>
	/// <name>Meta Perk Unlock Wildcard</name>
	Meta_Perk_Unlock_Wildcard,

	/// <summary>
	/// EffectMetaRewardModel-No Quality Control
	/// </summary>
	/// <name>Meta Perk Unlock Wood +2 for insects</name>
	Meta_Perk_Unlock_Wood_Plus2_For_Insects,

	/// <summary>
	/// EffectMetaRewardModel-Prayer Book
	/// </summary>
	/// <name>Meta Perk Unlock Working time for firekeeper</name>
	Meta_Perk_Unlock_Working_Time_For_Firekeeper,

	/// <summary>
	/// ExpMetaRewardModel-Absolutely Nothing
	/// </summary>
	/// <name>Meta Reward 0 Exp</name>
	Meta_Reward_0_Exp,

	/// <summary>
	/// BuildingMetaRewardModel-Advanced Rain Collector
	/// </summary>
	/// <name>Meta Reward Advanced Rain Collector</name>
	Meta_Reward_Advanced_Rain_Collector,

	/// <summary>
	/// BuildingMetaRewardModel-Alchemist's Hut
	/// </summary>
	/// <name>Meta Reward Alchemist Hut</name>
	Meta_Reward_Alchemist_Hut,

	/// <summary>
	/// BuildingMetaRewardModel-Apothecary
	/// </summary>
	/// <name>Meta Reward Apothecary</name>
	Meta_Reward_Apothecary,

	/// <summary>
	/// BuildingMetaRewardModel-Artisan
	/// </summary>
	/// <name>Meta Reward Artisan</name>
	Meta_Reward_Artisan,

	/// <summary>
	/// BuildingMetaRewardModel-Bakery
	/// </summary>
	/// <name>Meta Reward Bakery</name>
	Meta_Reward_Bakery,

	/// <summary>
	/// BuildingMetaRewardModel-Bath House
	/// </summary>
	/// <name>Meta Reward Bath House</name>
	Meta_Reward_Bath_House,

	/// <summary>
	/// BuildingMetaRewardModel-Beanery
	/// </summary>
	/// <name>Meta Reward Beanery</name>
	Meta_Reward_Beanery,

	/// <summary>
	/// BuildingMetaRewardModel-Beaver House
	/// </summary>
	/// <name>Meta Reward Beaver House</name>
	Meta_Reward_Beaver_House,

	/// <summary>
	/// BuildingMetaRewardModel-Big Shelter
	/// </summary>
	/// <name>Meta Reward Big Shelter</name>
	Meta_Reward_Big_Shelter,

	/// <summary>
	/// BlightPostUpgradesUnlockMetaRewardModel-Blight Post Upgrades
	/// </summary>
	/// <name>Meta Reward Blight Post Upgrades Unlock</name>
	Meta_Reward_Blight_Post_Upgrades_Unlock,

	/// <summary>
	/// BonusVillagersMetaRewardModel-More Villagers
	/// </summary>
	/// <name>Meta Reward Bonus Villagers</name>
	Meta_Reward_Bonus_Villagers,

	/// <summary>
	/// GlobalExtraProductionChanceMetaRewardModel-Unforeseen Riches
	/// </summary>
	/// <name>Meta Reward Bonus Yield</name>
	Meta_Reward_Bonus_Yield,

	/// <summary>
	/// BuildingMetaRewardModel-Brewery
	/// </summary>
	/// <name>Meta Reward Brewery</name>
	Meta_Reward_Brewery,

	/// <summary>
	/// BuildingMetaRewardModel-Brick Oven
	/// </summary>
	/// <name>Meta Reward Brick Oven</name>
	Meta_Reward_Brick_Oven,

	/// <summary>
	/// BuildingMetaRewardModel-Brickyard
	/// </summary>
	/// <name>Meta Reward Brickyard</name>
	Meta_Reward_Brickyard,

	/// <summary>
	/// GlobalBuildingStorageMetaRewardModel-Larger Storage
	/// </summary>
	/// <name>Meta Reward Building Storage</name>
	Meta_Reward_Building_Storage,

	/// <summary>
	/// FuelRateMetaRewardModel-Everlasting Flames
	/// </summary>
	/// <name>Meta Reward Burning Duration</name>
	Meta_Reward_Burning_Duration,

	/// <summary>
	/// BuildingMetaRewardModel-Butcher
	/// </summary>
	/// <name>Meta Reward Butcher</name>
	Meta_Reward_Butcher,

	/// <summary>
	/// BuildingMetaRewardModel-Cannery
	/// </summary>
	/// <name>Meta Reward Cannery</name>
	Meta_Reward_Cannery,

	/// <summary>
	/// EmbarkGoodsAmountMetaRewardModel-Stocked Caravans
	/// </summary>
	/// <name>Meta Reward Caravan Goods</name>
	Meta_Reward_Caravan_Goods,

	/// <summary>
	/// CaravanSlotMetaRewardModel-Additional Caravan Choice
	/// </summary>
	/// <name>Meta Reward Caravan Slot</name>
	Meta_Reward_Caravan_Slot,

	/// <summary>
	/// BuildingMetaRewardModel-Carpenter
	/// </summary>
	/// <name>Meta Reward Carpenter</name>
	Meta_Reward_Carpenter,

	/// <summary>
	/// BuildingMetaRewardModel-Cellar
	/// </summary>
	/// <name>Meta Reward Cellar</name>
	Meta_Reward_Cellar,

	/// <summary>
	/// CapitalHomeUnlockMetaRewardModel-Viceroy's Quarters
	/// </summary>
	/// <name>Meta Reward Citadel Home Unlock</name>
	Meta_Reward_Citadel_Home_Unlock,

	/// <summary>
	/// BuildingMetaRewardModel-Clan Hall
	/// </summary>
	/// <name>Meta Reward Clan Hall</name>
	Meta_Reward_Clan_Hall,

	/// <summary>
	/// BuildingMetaRewardModel-Clay Pit
	/// </summary>
	/// <name>Meta Reward Clay Pit</name>
	Meta_Reward_Clay_Pit,

	/// <summary>
	/// BuildingMetaRewardModel-Clothier
	/// </summary>
	/// <name>Meta Reward Clothier</name>
	Meta_Reward_Clothier,

	/// <summary>
	/// BuildingMetaRewardModel-Cobbler
	/// </summary>
	/// <name>Meta Reward Cobbler</name>
	Meta_Reward_Cobbler,

	/// <summary>
	/// BuildingMetaRewardModel-Cookhouse
	/// </summary>
	/// <name>Meta Reward Cookhouse</name>
	Meta_Reward_Cookhouse,

	/// <summary>
	/// BuildingMetaRewardModel-Cooperage
	/// </summary>
	/// <name>Meta Reward Cooperage</name>
	Meta_Reward_Cooperage,

	/// <summary>
	/// SeasonRewardsAmountMetaRewardModel-Additional Cornerstone Choice
	/// </summary>
	/// <name>Meta Reward Cornerstone</name>
	Meta_Reward_Cornerstone,

	/// <summary>
	/// CornerstonesRerollsMetaRewardModel-Cornerstone Reroll Charge
	/// </summary>
	/// <name>Meta Reward Cornerstone Reroll</name>
	Meta_Reward_Cornerstone_Reroll,

	/// <summary>
	/// BuildingMetaRewardModel-Crude Workstation
	/// </summary>
	/// <name>Meta Reward Crude Workstation</name>
	Meta_Reward_Crude_Workstation,

	/// <summary>
	/// DailyChallengeMetaRewardModel-Daily Expedition
	/// </summary>
	/// <name>Meta Reward Daily Challenge</name>
	Meta_Reward_Daily_Challenge,

	/// <summary>
	/// BuildingMetaRewardModel-Ancient Arch
	/// </summary>
	/// <name>Meta Reward Decor Ancient Arch</name>
	Meta_Reward_Decor_Ancient_Arch,

	/// <summary>
	/// BuildingMetaRewardModel-Ancient Tombstone
	/// </summary>
	/// <name>Meta Reward Decor Ancient Gravestone</name>
	Meta_Reward_Decor_Ancient_Gravestone,

	/// <summary>
	/// BuildingMetaRewardModel-Bench
	/// </summary>
	/// <name>Meta Reward Decor Bank</name>
	Meta_Reward_Decor_Bank,

	/// <summary>
	/// BuildingMetaRewardModel-Barrels
	/// </summary>
	/// <name>Meta Reward Decor Barrels</name>
	Meta_Reward_Decor_Barrels,

	/// <summary>
	/// BuildingMetaRewardModel-Bush
	/// </summary>
	/// <name>Meta Reward Decor Bush</name>
	Meta_Reward_Decor_Bush,

	/// <summary>
	/// BuildingMetaRewardModel-Coral Growth
	/// </summary>
	/// <name>Meta Reward Decor Coral</name>
	Meta_Reward_Decor_Coral,

	/// <summary>
	/// BuildingMetaRewardModel-Crates
	/// </summary>
	/// <name>Meta Reward Decor Crates</name>
	Meta_Reward_Decor_Crates,

	/// <summary>
	/// BuildingMetaRewardModel-Fence
	/// </summary>
	/// <name>Meta Reward Decor Fence</name>
	Meta_Reward_Decor_Fence,

	/// <summary>
	/// BuildingMetaRewardModel-Fence Corner
	/// </summary>
	/// <name>Meta Reward Decor Fence Corner</name>
	Meta_Reward_Decor_Fence_Corner,

	/// <summary>
	/// BuildingMetaRewardModel-Fire Shrine
	/// </summary>
	/// <name>Meta Reward Decor Fire Shrine</name>
	Meta_Reward_Decor_Fire_Shrine,

	/// <summary>
	/// BuildingMetaRewardModel-Flower Bed
	/// </summary>
	/// <name>Meta Reward Decor Flower Bed</name>
	Meta_Reward_Decor_Flower_Bed,

	/// <summary>
	/// BuildingMetaRewardModel-Gate
	/// </summary>
	/// <name>Meta Reward Decor Gate</name>
	Meta_Reward_Decor_Gate,

	/// <summary>
	/// BuildingMetaRewardModel-Golden Leaf Plant
	/// </summary>
	/// <name>Meta Reward Decor Golden Leaf</name>
	Meta_Reward_Decor_Golden_Leaf,

	/// <summary>
	/// BuildingMetaRewardModel-Lamp
	/// </summary>
	/// <name>Meta Reward Decor Lamp</name>
	Meta_Reward_Decor_Lamp,

	/// <summary>
	/// BuildingMetaRewardModel-Lizard Post
	/// </summary>
	/// <name>Meta Reward Decor Lizard Post</name>
	Meta_Reward_Decor_Lizard_Post,

	/// <summary>
	/// BuildingMetaRewardModel-Decorative Fungus
	/// </summary>
	/// <name>Meta Reward Decor Mushroom</name>
	Meta_Reward_Decor_Mushroom,

	/// <summary>
	/// BuildingMetaRewardModel-Nightfern
	/// </summary>
	/// <name>Meta Reward Decor Nightfern</name>
	Meta_Reward_Decor_Nightfern,

	/// <summary>
	/// BuildingMetaRewardModel-Water Barrels
	/// </summary>
	/// <name>Meta Reward Decor Rainpunk Barrels</name>
	Meta_Reward_Decor_Rainpunk_Barrels,

	/// <summary>
	/// BuildingMetaRewardModel-Road Sign
	/// </summary>
	/// <name>Meta Reward Decor Road Sign</name>
	Meta_Reward_Decor_Road_Sign,

	/// <summary>
	/// BuildingMetaRewardModel-Rainpunk Barrels
	/// </summary>
	/// <name>Meta Reward Decor Side Barrels</name>
	Meta_Reward_Decor_Side_Barrels,

	/// <summary>
	/// BuildingMetaRewardModel-Signboard
	/// </summary>
	/// <name>Meta Reward Decor Signboard</name>
	Meta_Reward_Decor_Signboard,

	/// <summary>
	/// BuildingMetaRewardModel-Wall Crossing
	/// </summary>
	/// <name>Meta Reward Decor Tower</name>
	Meta_Reward_Decor_Tower,

	/// <summary>
	/// BuildingMetaRewardModel-Umbrella
	/// </summary>
	/// <name>Meta Reward Decor Umbrella</name>
	Meta_Reward_Decor_Umbrella,

	/// <summary>
	/// BuildingMetaRewardModel-Wall
	/// </summary>
	/// <name>Meta Reward Decor Wall</name>
	Meta_Reward_Decor_Wall,

	/// <summary>
	/// BuildingMetaRewardModel-Distillery
	/// </summary>
	/// <name>Meta Reward Distillery</name>
	Meta_Reward_Distillery,

	/// <summary>
	/// BuildingMetaRewardModel-Druid's Hut
	/// </summary>
	/// <name>Meta Reward Druid</name>
	Meta_Reward_Druid,

	/// <summary>
	/// EmbarkEffectMetaRewardModel-Embarkation Bonus: Fishing Hut
	/// </summary>
	/// <name>Meta Reward Embark Blueprint Fishing Hut</name>
	Meta_Reward_Embark_Blueprint_Fishing_Hut,

	/// <summary>
	/// EmbarkEffectMetaRewardModel-Embarkation Bonus: Foragers' Camp
	/// </summary>
	/// <name>Meta Reward Embark Blueprint Forager</name>
	Meta_Reward_Embark_Blueprint_Forager,

	/// <summary>
	/// EmbarkEffectMetaRewardModel-Embarkation Bonus: Herb Garden
	/// </summary>
	/// <name>Meta Reward Embark Blueprint Herb Garden</name>
	Meta_Reward_Embark_Blueprint_Herb_Garden,

	/// <summary>
	/// EmbarkEffectMetaRewardModel-Embarkation Bonus: Herbalists' Camp
	/// </summary>
	/// <name>Meta Reward Embark Blueprint Herbalist</name>
	Meta_Reward_Embark_Blueprint_Herbalist,

	/// <summary>
	/// EmbarkEffectMetaRewardModel-Embarkation Bonus: Plantation
	/// </summary>
	/// <name>Meta Reward Embark Blueprint Plantation</name>
	Meta_Reward_Embark_Blueprint_Plantation,

	/// <summary>
	/// EmbarkEffectMetaRewardModel-Embarkation Bonus: Small Farm
	/// </summary>
	/// <name>Meta Reward Embark Blueprint Small Farm</name>
	Meta_Reward_Embark_Blueprint_Small_Farm,

	/// <summary>
	/// EmbarkEffectMetaRewardModel-Embarkation Bonus: Trappers' Camp
	/// </summary>
	/// <name>Meta Reward Embark Blueprint Trapper</name>
	Meta_Reward_Embark_Blueprint_Trapper,

	/// <summary>
	/// EmbarkGoodMetaRewardModel
	/// </summary>
	/// <name>Meta Reward Embark Goods Amber</name>
	Meta_Reward_Embark_Goods_Amber,

	/// <summary>
	/// EmbarkGoodMetaRewardModel
	/// </summary>
	/// <name>Meta Reward Embark Goods Bricks</name>
	Meta_Reward_Embark_Goods_Bricks,

	/// <summary>
	/// EmbarkGoodMetaRewardModel
	/// </summary>
	/// <name>Meta Reward Embark Goods Clay</name>
	Meta_Reward_Embark_Goods_Clay,

	/// <summary>
	/// EmbarkGoodMetaRewardModel
	/// </summary>
	/// <name>Meta Reward Embark Goods Coal</name>
	Meta_Reward_Embark_Goods_Coal,

	/// <summary>
	/// EmbarkGoodMetaRewardModel
	/// </summary>
	/// <name>Meta Reward Embark Goods Eggs</name>
	Meta_Reward_Embark_Goods_Eggs,

	/// <summary>
	/// EmbarkGoodMetaRewardModel
	/// </summary>
	/// <name>Meta Reward Embark Goods Fabric</name>
	Meta_Reward_Embark_Goods_Fabric,

	/// <summary>
	/// EmbarkGoodMetaRewardModel
	/// </summary>
	/// <name>Meta Reward Embark Goods Leather</name>
	Meta_Reward_Embark_Goods_Leather,

	/// <summary>
	/// EmbarkGoodMetaRewardModel
	/// </summary>
	/// <name>Meta Reward Embark Goods Meat</name>
	Meta_Reward_Embark_Goods_Meat,

	/// <summary>
	/// EmbarkGoodMetaRewardModel
	/// </summary>
	/// <name>Meta Reward Embark Goods Oil</name>
	Meta_Reward_Embark_Goods_Oil,

	/// <summary>
	/// EmbarkGoodMetaRewardModel
	/// </summary>
	/// <name>Meta Reward Embark Goods Parts</name>
	Meta_Reward_Embark_Goods_Parts,

	/// <summary>
	/// EmbarkGoodMetaRewardModel
	/// </summary>
	/// <name>Meta Reward Embark Goods Planks</name>
	Meta_Reward_Embark_Goods_Planks,

	/// <summary>
	/// EmbarkGoodMetaRewardModel
	/// </summary>
	/// <name>Meta Reward Embark Goods Provisions</name>
	Meta_Reward_Embark_Goods_Provisions,

	/// <summary>
	/// EmbarkGoodMetaRewardModel
	/// </summary>
	/// <name>Meta Reward Embark Goods Reeds</name>
	Meta_Reward_Embark_Goods_Reeds,

	/// <summary>
	/// EmbarkGoodMetaRewardModel
	/// </summary>
	/// <name>Meta Reward Embark Goods Roots</name>
	Meta_Reward_Embark_Goods_Roots,

	/// <summary>
	/// EmbarkGoodMetaRewardModel
	/// </summary>
	/// <name>Meta Reward Embark Goods Stone</name>
	Meta_Reward_Embark_Goods_Stone,

	/// <summary>
	/// EmbarkGoodMetaRewardModel
	/// </summary>
	/// <name>Meta Reward Embark Goods Vegetables</name>
	Meta_Reward_Embark_Goods_Vegetables,

	/// <summary>
	/// EmbarkGoodMetaRewardModel
	/// </summary>
	/// <name>Meta Reward Embark Goods Wood</name>
	Meta_Reward_Embark_Goods_Wood,

	/// <summary>
	/// EmbarkEffectMetaRewardModel-Embarkation Bonus: Ale Delivery Line
	/// </summary>
	/// <name>Meta Reward Embark Perk Ale 3pm</name>
	Meta_Reward_Embark_Perk_Ale_3pm,

	/// <summary>
	/// EmbarkEffectMetaRewardModel-Embarkation Bonus: Royal Permit
	/// </summary>
	/// <name>Meta Reward Embark Perk Cornerstone Reroll +1</name>
	Meta_Reward_Embark_Perk_Cornerstone_Reroll_Plus1,

	/// <summary>
	/// EmbarkEffectMetaRewardModel-Embarkation Bonus: Tea Delivery Line
	/// </summary>
	/// <name>Meta Reward Embark Perk Cosmetics 3pm</name>
	Meta_Reward_Embark_Perk_Cosmetics_3pm,

	/// <summary>
	/// EmbarkEffectMetaRewardModel-Embarkation Bonus: Incense Delivery Line
	/// </summary>
	/// <name>Meta Reward Embark Perk Incense 3pm</name>
	Meta_Reward_Embark_Perk_Incense_3pm,

	/// <summary>
	/// EmbarkEffectMetaRewardModel-Embarkation Bonus: Scroll Delivery Line
	/// </summary>
	/// <name>Meta Reward Embark Perk Scrolls 3pm</name>
	Meta_Reward_Embark_Perk_Scrolls_3pm,

	/// <summary>
	/// EmbarkEffectMetaRewardModel-Embarkation Bonus: Training Gear Delivery Line
	/// </summary>
	/// <name>Meta Reward Embark Perk Training Gear 3pm</name>
	Meta_Reward_Embark_Perk_Training_Gear_3pm,

	/// <summary>
	/// EmbarkEffectMetaRewardModel-Embarkation Bonus: Wine Delivery Line
	/// </summary>
	/// <name>Meta Reward Embark Perk Wine 3pm</name>
	Meta_Reward_Embark_Perk_Wine_3pm,

	/// <summary>
	/// PreparationPointsMetaRewardModel-Embarkation Points
	/// </summary>
	/// <name>Meta Reward Embark Point</name>
	Meta_Reward_Embark_Point,

	/// <summary>
	/// BonusEmbarkRangeMetaRewardModel-Greater Embarkation Range
	/// </summary>
	/// <name>Meta Reward Embark Range</name>
	Meta_Reward_Embark_Range,

	/// <summary>
	/// EmbarkEffectMetaRewardModel-Embarkation Bonus: Villagers
	/// </summary>
	/// <name>Meta Reward Embark Villagers</name>
	Meta_Reward_Embark_Villagers,

	/// <summary>
	/// EssentialRacialBuildingMetaRewardModel-Essential Blueprint: Beaver House
	/// </summary>
	/// <name>Meta Reward Essential Beaver House</name>
	Meta_Reward_Essential_Beaver_House,

	/// <summary>
	/// EssentialBuildingMetaRewardModel-Essential Blueprint: Field Kitchen
	/// </summary>
	/// <name>Meta Reward Essential Field Kitchen</name>
	Meta_Reward_Essential_Field_Kitchen,

	/// <summary>
	/// EssentialRacialBuildingMetaRewardModel-Essential Blueprint: Fox House
	/// </summary>
	/// <name>Meta Reward Essential Fox House</name>
	Meta_Reward_Essential_Fox_House,

	/// <summary>
	/// EssentialRacialBuildingMetaRewardModel-Essential Blueprint: Frog House
	/// </summary>
	/// <name>Meta Reward Essential Frog House</name>
	Meta_Reward_Essential_Frog_House,

	/// <summary>
	/// EssentialRacialBuildingMetaRewardModel-Essential Blueprint: Harpy House
	/// </summary>
	/// <name>Meta Reward Essential Harpy House</name>
	Meta_Reward_Essential_Harpy_House,

	/// <summary>
	/// EssentialRacialBuildingMetaRewardModel-Essential Blueprint: Human House
	/// </summary>
	/// <name>Meta Reward Essential Human House</name>
	Meta_Reward_Essential_Human_House,

	/// <summary>
	/// EssentialRacialBuildingMetaRewardModel-Essential Blueprint: Lizard House
	/// </summary>
	/// <name>Meta Reward Essential Lizard House</name>
	Meta_Reward_Essential_Lizard_House,

	/// <summary>
	/// EssentialBuildingMetaRewardModel-Rain Collector
	/// </summary>
	/// <name>Meta Reward Essential Rain Collector</name>
	Meta_Reward_Essential_Rain_Collector,

	/// <summary>
	/// BuildingMetaRewardModel-Explorers' Lodge
	/// </summary>
	/// <name>Meta Reward Explorers Lodge</name>
	Meta_Reward_Explorers_Lodge,

	/// <summary>
	/// FactionsActivationMetaRewardModel-Vanguard of the Stolen Keys
	/// </summary>
	/// <name>Meta Reward Faction Blue</name>
	Meta_Reward_Faction_Blue,

	/// <summary>
	/// FactionsActivationMetaRewardModel-First Dawn Company
	/// </summary>
	/// <name>Meta Reward Faction Green</name>
	Meta_Reward_Faction_Green,

	/// <summary>
	/// FactionsActivationMetaRewardModel-Brass Order
	/// </summary>
	/// <name>Meta Reward Faction Orange</name>
	Meta_Reward_Faction_Orange,

	/// <summary>
	/// BonusFarmAreaMetaRewardModel-Farm Range Increase
	/// </summary>
	/// <name>Meta Reward Farm Range</name>
	Meta_Reward_Farm_Range,

	/// <summary>
	/// BuildingMetaRewardModel-Finesmith
	/// </summary>
	/// <name>Meta Reward Finesmith</name>
	Meta_Reward_Finesmith,

	/// <summary>
	/// BuildingMetaRewardModel-Fishing Hut
	/// </summary>
	/// <name>Meta Reward Fishers Camp</name>
	Meta_Reward_Fishers_Camp,

	/// <summary>
	/// BuildingMetaRewardModel-Foragers' Camp
	/// </summary>
	/// <name>Meta Reward Forager's Camp</name>
	Meta_Reward_Foragers_Camp,

	/// <summary>
	/// BuildingMetaRewardModel-Forum
	/// </summary>
	/// <name>Meta Reward Forum</name>
	Meta_Reward_Forum,

	/// <summary>
	/// BuildingMetaRewardModel-Fox House
	/// </summary>
	/// <name>Meta Reward Fox House</name>
	Meta_Reward_Fox_House,

	/// <summary>
	/// BuildingMetaRewardModel-Frog House
	/// </summary>
	/// <name>Meta Reward Frog House</name>
	Meta_Reward_Frog_House,

	/// <summary>
	/// BuildingMetaRewardModel-Furnace
	/// </summary>
	/// <name>Meta Reward Furnace</name>
	Meta_Reward_Furnace,

	/// <summary>
	/// GlobalCapacityMetaRewardModel-Worker Capacity Increase
	/// </summary>
	/// <name>Meta Reward Global Capacity</name>
	Meta_Reward_Global_Capacity,

	/// <summary>
	/// GoalsUnlockMetaRewardModel-Obsidian Archive
	/// </summary>
	/// <name>Meta Reward Goals Unlock</name>
	Meta_Reward_Goals_Unlock,

	/// <summary>
	/// GracePeriodMetaRewardModel-Last Stand
	/// </summary>
	/// <name>Meta Reward Grace Period</name>
	Meta_Reward_Grace_Period,

	/// <summary>
	/// BuildingMetaRewardModel-Granary
	/// </summary>
	/// <name>Meta Reward Granary</name>
	Meta_Reward_Granary,

	/// <summary>
	/// BuildingMetaRewardModel-Greenhouse
	/// </summary>
	/// <name>Meta Reward Greenhouse</name>
	Meta_Reward_Greenhouse,

	/// <summary>
	/// BuildingMetaRewardModel-Grill
	/// </summary>
	/// <name>Meta Reward Grill</name>
	Meta_Reward_Grill,

	/// <summary>
	/// BuildingMetaRewardModel-Forester's Hut
	/// </summary>
	/// <name>Meta Reward Grove</name>
	Meta_Reward_Grove,

	/// <summary>
	/// CaravanGoodMetaRewardModel
	/// </summary>
	/// <name>Meta Reward Guaranteed Bricks</name>
	Meta_Reward_Guaranteed_Bricks,

	/// <summary>
	/// CaravanGoodMetaRewardModel
	/// </summary>
	/// <name>Meta Reward Guaranteed Fabric</name>
	Meta_Reward_Guaranteed_Fabric,

	/// <summary>
	/// CaravanGoodMetaRewardModel
	/// </summary>
	/// <name>Meta Reward Guaranteed Pipes</name>
	Meta_Reward_Guaranteed_Pipes,

	/// <summary>
	/// CaravanGoodMetaRewardModel
	/// </summary>
	/// <name>Meta Reward Guaranteed Planks</name>
	Meta_Reward_Guaranteed_Planks,

	/// <summary>
	/// BuildingMetaRewardModel-Guild House
	/// </summary>
	/// <name>Meta Reward Guild House</name>
	Meta_Reward_Guild_House,

	/// <summary>
	/// BuildingMetaRewardModel-Harpy House
	/// </summary>
	/// <name>Meta Reward Harpy House</name>
	Meta_Reward_Harpy_House,

	/// <summary>
	/// MainStorageHaulersMetaRewardModel-Haulers - Main Warehouse
	/// </summary>
	/// <name>Meta Reward Haulers - Main Storage</name>
	Meta_Reward_Haulers_Main_Storage,

	/// <summary>
	/// SecondaryStorageHaulersMetaRewardModel-Haulers - Small Warehouse
	/// </summary>
	/// <name>Meta Reward Haulers - Secondary Storage</name>
	Meta_Reward_Haulers_Secondary_Storage,

	/// <summary>
	/// BuildingMetaRewardModel-Small Hearth
	/// </summary>
	/// <name>Meta Reward Hearth</name>
	Meta_Reward_Hearth,

	/// <summary>
	/// BuildingMetaRewardModel-Herb Garden
	/// </summary>
	/// <name>Meta Reward Herb Garden</name>
	Meta_Reward_Herb_Garden,

	/// <summary>
	/// BuildingMetaRewardModel-Herbalists' Camp
	/// </summary>
	/// <name>Meta Reward Herbalist Camp</name>
	Meta_Reward_Herbalist_Camp,

	/// <summary>
	/// CapitalHomeDecorationMetaRewardModel-Ancient Artifact
	/// </summary>
	/// <name>Meta Reward Home Decor - Ancient Artifact</name>
	Meta_Reward_Home_Decor_Ancient_Artifact,

	/// <summary>
	/// CapitalHomeDecorationMetaRewardModel-Domesticated Sea Tiger
	/// </summary>
	/// <name>Meta Reward Home Decor - Domesticated Sea Tiger</name>
	Meta_Reward_Home_Decor_Domesticated_Sea_Tiger,

	/// <summary>
	/// CapitalHomeDecorationMetaRewardModel-Dueling Umbrella
	/// </summary>
	/// <name>Meta Reward Home Decor - Dueling Umbrella</name>
	Meta_Reward_Home_Decor_Dueling_Umbrella,

	/// <summary>
	/// CapitalHomeDecorationMetaRewardModel-Fishman Skull
	/// </summary>
	/// <name>Meta Reward Home Decor - Fishman Skull</name>
	Meta_Reward_Home_Decor_Fishman_Skull,

	/// <summary>
	/// CapitalHomeDecorationMetaRewardModel-Ibex Rug
	/// </summary>
	/// <name>Meta Reward Home Decor - Ibex Rug</name>
	Meta_Reward_Home_Decor_Ibex_Rug,

	/// <summary>
	/// CapitalHomeDecorationMetaRewardModel-Inscribed Slab
	/// </summary>
	/// <name>Meta Reward Home Decor - Inscribed Slab</name>
	Meta_Reward_Home_Decor_Inscribed_Slab,

	/// <summary>
	/// CapitalHomeDecorationMetaRewardModel-Landscape Painting
	/// </summary>
	/// <name>Meta Reward Home Decor - Landscape Painting</name>
	Meta_Reward_Home_Decor_Landscape_Painting,

	/// <summary>
	/// CapitalHomeDecorationMetaRewardModel-Marshglow Fungite
	/// </summary>
	/// <name>Meta Reward Home Decor - Marshglow Fungite</name>
	Meta_Reward_Home_Decor_Marshglow_Fungite,

	/// <summary>
	/// CapitalHomeDecorationMetaRewardModel-Mole Trophy
	/// </summary>
	/// <name>Meta Reward Home Decor - Mole Trophy</name>
	Meta_Reward_Home_Decor_Mole_Trophy,

	/// <summary>
	/// CapitalHomeDecorationMetaRewardModel-Painting of the Ancient Hearth
	/// </summary>
	/// <name>Meta Reward Home Decor - Painting of the Ancient Hearth</name>
	Meta_Reward_Home_Decor_Painting_Of_The_Ancient_Hearth,

	/// <summary>
	/// CapitalHomeDecorationMetaRewardModel-Plate of Food
	/// </summary>
	/// <name>Meta Reward Home Decor - Plate of Food</name>
	Meta_Reward_Home_Decor_Plate_Of_Food,

	/// <summary>
	/// CapitalHomeDecorationMetaRewardModel-Reefbloom
	/// </summary>
	/// <name>Meta Reward Home Decor - Reefbloom</name>
	Meta_Reward_Home_Decor_Reefbloom,

	/// <summary>
	/// CapitalHomeDecorationMetaRewardModel-Rosevine
	/// </summary>
	/// <name>Meta Reward Home Decor - Rosevine</name>
	Meta_Reward_Home_Decor_Rosevine,

	/// <summary>
	/// CapitalHomeDecorationMetaRewardModel-Sparkdew Crystal
	/// </summary>
	/// <name>Meta Reward Home Decor - Sparkdew Crystal</name>
	Meta_Reward_Home_Decor_Sparkdew_Crystal,

	/// <summary>
	/// CapitalHomeDecorationMetaRewardModel-Storm Orb
	/// </summary>
	/// <name>Meta Reward Home Decor - Storm Orb</name>
	Meta_Reward_Home_Decor_Storm_Orb,

	/// <summary>
	/// CapitalHomeDecorationMetaRewardModel-The Sparkcaster
	/// </summary>
	/// <name>Meta Reward Home Decor - The Sparkcaster</name>
	Meta_Reward_Home_Decor_The_Sparkcaster,

	/// <summary>
	/// CapitalHomeDecorationMetaRewardModel-Trade Contract
	/// </summary>
	/// <name>Meta Reward Home Decor - Trade Contract</name>
	Meta_Reward_Home_Decor_Trade_Contract,

	/// <summary>
	/// CapitalHomeDecorationMetaRewardModel-Standard Uniform
	/// </summary>
	/// <name>Meta Reward Home Decor - Uniform 0 - Standard Uniform</name>
	Meta_Reward_Home_Decor_Uniform_0_Standard_Uniform,

	/// <summary>
	/// CapitalHomeDecorationMetaRewardModel-Settler's Mask
	/// </summary>
	/// <name>Meta Reward Home Decor - Uniform 1 - Settler's Mask</name>
	Meta_Reward_Home_Decor_Uniform_1_Settlers_Mask,

	/// <summary>
	/// CapitalHomeDecorationMetaRewardModel-Pioneer's Mantle
	/// </summary>
	/// <name>Meta Reward Home Decor - Uniform 2 - Pioneer's Mantle</name>
	Meta_Reward_Home_Decor_Uniform_2_Pioneers_Mantle,

	/// <summary>
	/// CapitalHomeDecorationMetaRewardModel-Veteran's Shoulder Guard
	/// </summary>
	/// <name>Meta Reward Home Decor - Uniform 3 - Veteran's Shoulder Guard</name>
	Meta_Reward_Home_Decor_Uniform_3_Veterans_Shoulder_Guard,

	/// <summary>
	/// CapitalHomeDecorationMetaRewardModel-Viceroy's Cape
	/// </summary>
	/// <name>Meta Reward Home Decor - Uniform 4 - Viceroy's Cape</name>
	Meta_Reward_Home_Decor_Uniform_4_Viceroys_Cape,

	/// <summary>
	/// CapitalHomeDecorationMetaRewardModel-Decorated Belt
	/// </summary>
	/// <name>Meta Reward Home Decor - Uniform 5 - Decorated Belt</name>
	Meta_Reward_Home_Decor_Uniform_5_Decorated_Belt,

	/// <summary>
	/// CapitalHomeDecorationMetaRewardModel-Royal Visage
	/// </summary>
	/// <name>Meta Reward Home Decor - Uniform 6 - Royal Visage</name>
	Meta_Reward_Home_Decor_Uniform_6_Royal_Visage,

	/// <summary>
	/// CapitalHomeDecorationMetaRewardModel-Stormshroud Attire
	/// </summary>
	/// <name>Meta Reward Home Decor - Uniform 7 - Stormshroud Attire</name>
	Meta_Reward_Home_Decor_Uniform_7_Stormshroud_Attire,

	/// <summary>
	/// CapitalHomeDecorationMetaRewardModel-Crimson Cloak
	/// </summary>
	/// <name>Meta Reward Home Decor - Uniform 8 - Crimson Cloak</name>
	Meta_Reward_Home_Decor_Uniform_8_Crimson_Cloak,

	/// <summary>
	/// CapitalHomeDecorationMetaRewardModel-Queen's Hand Pauldron
	/// </summary>
	/// <name>Meta Reward Home Decor - Uniform 9 - Queen's Hand Pauldron</name>
	Meta_Reward_Home_Decor_Uniform_9_Queens_Hand_Pauldron,

	/// <summary>
	/// BuildingMetaRewardModel-Homestead
	/// </summary>
	/// <name>Meta Reward Homestead</name>
	Meta_Reward_Homestead,

	/// <summary>
	/// HubTierMetaRewardModel-Hearth Upgrade - Neighborhood
	/// </summary>
	/// <name>Meta Reward Hub Tier 1</name>
	Meta_Reward_Hub_Tier_1,

	/// <summary>
	/// HubTierMetaRewardModel-Hearth Upgrade - District
	/// </summary>
	/// <name>Meta Reward Hub Tier 2</name>
	Meta_Reward_Hub_Tier_2,

	/// <summary>
	/// BuildingMetaRewardModel-Human House
	/// </summary>
	/// <name>Meta Reward Human House</name>
	Meta_Reward_Human_House,

	/// <summary>
	/// ReputationPenaltyRateMetaRewardModel-Queen's Patience
	/// </summary>
	/// <name>Meta Reward Impatience</name>
	Meta_Reward_Impatience,

	/// <summary>
	/// BuildingMetaRewardModel-Kiln
	/// </summary>
	/// <name>Meta Reward Kiln</name>
	Meta_Reward_Kiln,

	/// <summary>
	/// BuildingMetaRewardModel-Leatherworker
	/// </summary>
	/// <name>Meta Reward Leatherworks</name>
	Meta_Reward_Leatherworks,

	/// <summary>
	/// BuildingMetaRewardModel-Lizard House
	/// </summary>
	/// <name>Meta Reward Lizard House</name>
	Meta_Reward_Lizard_House,

	/// <summary>
	/// BuildingMetaRewardModel-Lumber Mill
	/// </summary>
	/// <name>Meta Reward Lumbermill</name>
	Meta_Reward_Lumbermill,

	/// <summary>
	/// BuildingMetaRewardModel-Manufactory
	/// </summary>
	/// <name>Meta Reward Manufactory</name>
	Meta_Reward_Manufactory,

	/// <summary>
	/// BuildingMetaRewardModel-Market
	/// </summary>
	/// <name>Meta Reward Market</name>
	Meta_Reward_Market,

	/// <summary>
	/// MenuSkinMetaRewardModel-Menu Skin: Coral Forest
	/// </summary>
	/// <name>Meta Reward Menu Skin - Coral Forest</name>
	Meta_Reward_Menu_Skin_Coral_Forest,

	/// <summary>
	/// MenuSkinMetaRewardModel-Menu Skin: Cursed Royal Woodlands
	/// </summary>
	/// <name>Meta Reward Menu Skin - Cursed Royal Woodlands</name>
	Meta_Reward_Menu_Skin_Cursed_Royal_Woodlands,

	/// <summary>
	/// MenuSkinMetaRewardModel-Menu Skin: Calm Settlement
	/// </summary>
	/// <name>Meta Reward Menu Skin - Farming</name>
	Meta_Reward_Menu_Skin_Farming,

	/// <summary>
	/// MenuSkinMetaRewardModel-Menu Skin: Industrial Town
	/// </summary>
	/// <name>Meta Reward Menu Skin - Industry</name>
	Meta_Reward_Menu_Skin_Industry,

	/// <summary>
	/// MenuSkinMetaRewardModel-Menu Skin: Marshlands
	/// </summary>
	/// <name>Meta Reward Menu Skin - Marshlands</name>
	Meta_Reward_Menu_Skin_Marshlands,

	/// <summary>
	/// MenuSkinMetaRewardModel-Menu Skin: Scarlet Orchard
	/// </summary>
	/// <name>Meta Reward Menu Skin - Scarlet Orchard</name>
	Meta_Reward_Menu_Skin_Scarlet_Orchard,

	/// <summary>
	/// MenuSkinMetaRewardModel-Menu Skin: Sealed Forest
	/// </summary>
	/// <name>Meta Reward Menu Skin - Sealed Forest</name>
	Meta_Reward_Menu_Skin_Sealed_Forest,

	/// <summary>
	/// CurrencyMultiplayerMetaRewardModel-More Citadel Resources
	/// </summary>
	/// <name>Meta Reward Meta Resources</name>
	Meta_Reward_Meta_Resources,

	/// <summary>
	/// BuildingMetaRewardModel-Mine
	/// </summary>
	/// <name>Meta Reward Mine</name>
	Meta_Reward_Mine,

	/// <summary>
	/// MineUpgradesUnlockMetaRewardModel-Mine Upgrades
	/// </summary>
	/// <name>Meta Reward Mine Upgrade Unlock</name>
	Meta_Reward_Mine_Upgrade_Unlock,

	/// <summary>
	/// BuildingMetaRewardModel-Monastery
	/// </summary>
	/// <name>Meta Reward Monastery</name>
	Meta_Reward_Monastery,

	/// <summary>
	/// NewcommersGoodsRateMetaRewardModel-Newcomer Gifts
	/// </summary>
	/// <name>Meta Reward Newcomer Goods</name>
	Meta_Reward_Newcomer_Goods,

	/// <summary>
	/// RawDepositsChargesMetaRewardModel-Gathering Technique
	/// </summary>
	/// <name>Meta Reward Node Charges</name>
	Meta_Reward_Node_Charges,

	/// <summary>
	/// BuildingMetaRewardModel-Pantry
	/// </summary>
	/// <name>Meta Reward Pantry</name>
	Meta_Reward_Pantry,

	/// <summary>
	/// RevealEffectMetaRewardModel-Starting Ability: Beavers
	/// </summary>
	/// <name>Meta Reward Passive Beavers</name>
	Meta_Reward_Passive_Beavers,

	/// <summary>
	/// RevealEffectMetaRewardModel-Starting Ability: Foxes
	/// </summary>
	/// <name>Meta Reward Passive Foxes</name>
	Meta_Reward_Passive_Foxes,

	/// <summary>
	/// RevealEffectMetaRewardModel-Starting Ability: Frogs
	/// </summary>
	/// <name>Meta Reward Passive Frogs</name>
	Meta_Reward_Passive_Frogs,

	/// <summary>
	/// RevealEffectMetaRewardModel-Starting Ability: Harpies
	/// </summary>
	/// <name>Meta Reward Passive Harpies</name>
	Meta_Reward_Passive_Harpies,

	/// <summary>
	/// RevealEffectMetaRewardModel-Starting Ability: Humans
	/// </summary>
	/// <name>Meta Reward Passive Humans</name>
	Meta_Reward_Passive_Humans,

	/// <summary>
	/// RevealEffectMetaRewardModel-Starting Ability: Lizards
	/// </summary>
	/// <name>Meta Reward Passive Lizards</name>
	Meta_Reward_Passive_Lizards,

	/// <summary>
	/// BuildingMetaRewardModel-Paved Road
	/// </summary>
	/// <name>Meta Reward Paved Road</name>
	Meta_Reward_Paved_Road,

	/// <summary>
	/// BuildingMetaRewardModel-Plantation
	/// </summary>
	/// <name>Meta Reward Plantation</name>
	Meta_Reward_Plantation,

	/// <summary>
	/// BuildingMetaRewardModel-Press
	/// </summary>
	/// <name>Meta Reward Press</name>
	Meta_Reward_Press,

	/// <summary>
	/// GlobalProductionSpeedMetaRewardModel-Production Speed Increase
	/// </summary>
	/// <name>Meta Reward Prod Speed</name>
	Meta_Reward_Prod_Speed,

	/// <summary>
	/// BuildingMetaRewardModel-Provisioner
	/// </summary>
	/// <name>Meta Reward Provisioner</name>
	Meta_Reward_Provisioner,

	/// <summary>
	/// BuildingMetaRewardModel-Rain Mill
	/// </summary>
	/// <name>Meta Reward Rain Mill</name>
	Meta_Reward_Rain_Mill,

	/// <summary>
	/// RainpunkMetaRewardModel-Rainpunk Engines
	/// </summary>
	/// <name>Meta Reward Rainpunk Activation</name>
	Meta_Reward_Rainpunk_Activation,

	/// <summary>
	/// BuildingMetaRewardModel-Rainpunk Foundry
	/// </summary>
	/// <name>Meta Reward Rainpunk Foundry</name>
	Meta_Reward_Rainpunk_Foundry,

	/// <summary>
	/// BuildingMetaRewardModel-Ranch
	/// </summary>
	/// <name>Meta Reward Ranch</name>
	Meta_Reward_Ranch,

	/// <summary>
	/// ReputationRewardPicksMetaRewardModel-Additional Blueprint Choice
	/// </summary>
	/// <name>Meta Reward Reputation Reward Pick</name>
	Meta_Reward_Reputation_Reward_Pick,

	/// <summary>
	/// ReputationRewardsRerollMetaRewardModel-Blueprint Reroll
	/// </summary>
	/// <name>Meta Reward Reshuffle</name>
	Meta_Reward_Reshuffle,

	/// <summary>
	/// HearthSacraficeTimeRateMetaRewardModel-Sacrificial Flames
	/// </summary>
	/// <name>Meta Reward Sacrifice Cost</name>
	Meta_Reward_Sacrifice_Cost,

	/// <summary>
	/// BuildingMetaRewardModel-Scribe
	/// </summary>
	/// <name>Meta Reward Scribe</name>
	Meta_Reward_Scribe,

	/// <summary>
	/// BuildingMetaRewardModel-Clothier
	/// </summary>
	/// <name>Meta Reward Sewer</name>
	Meta_Reward_Sewer,

	/// <summary>
	/// BuildingMetaRewardModel-Smelter
	/// </summary>
	/// <name>Meta Reward Smelter</name>
	Meta_Reward_Smelter,

	/// <summary>
	/// BuildingMetaRewardModel-Smithy
	/// </summary>
	/// <name>Meta Reward Smithy</name>
	Meta_Reward_Smithy,

	/// <summary>
	/// BuildingMetaRewardModel-Smokehouse
	/// </summary>
	/// <name>Meta Reward Smokehouse</name>
	Meta_Reward_Smokehouse,

	/// <summary>
	/// BuildingMetaRewardModel-Stamping Mill
	/// </summary>
	/// <name>Meta Reward Stamping Mill</name>
	Meta_Reward_Stamping_Mill,

	/// <summary>
	/// BuildingMetaRewardModel-Main Warehouse
	/// </summary>
	/// <name>Meta Reward Storage</name>
	Meta_Reward_Storage,

	/// <summary>
	/// BuildingMetaRewardModel-Supplier
	/// </summary>
	/// <name>Meta Reward Supplier</name>
	Meta_Reward_Supplier,

	/// <summary>
	/// BuildingMetaRewardModel-Tavern
	/// </summary>
	/// <name>Meta Reward Tavern</name>
	Meta_Reward_Tavern,

	/// <summary>
	/// BuildingMetaRewardModel-Tea Doctor
	/// </summary>
	/// <name>Meta Reward Tea Doctor</name>
	Meta_Reward_Tea_Doctor,

	/// <summary>
	/// BuildingMetaRewardModel-Teahouse
	/// </summary>
	/// <name>Meta Reward Tea House</name>
	Meta_Reward_Tea_House,

	/// <summary>
	/// BuildingMetaRewardModel-Temple
	/// </summary>
	/// <name>Meta Reward Temple</name>
	Meta_Reward_Temple,

	/// <summary>
	/// BuildingMetaRewardModel-Tinctury
	/// </summary>
	/// <name>Meta Reward Tinctury</name>
	Meta_Reward_Tinctury,

	/// <summary>
	/// BuildingMetaRewardModel-Tinkerer
	/// </summary>
	/// <name>Meta Reward Tinkerer</name>
	Meta_Reward_Tinkerer,

	/// <summary>
	/// BuildingMetaRewardModel-Toolshop
	/// </summary>
	/// <name>Meta Reward Toolshop</name>
	Meta_Reward_Toolshop,

	/// <summary>
	/// TownsVisionRangeMetaRewardModel-Increased Town Vision Range
	/// </summary>
	/// <name>Meta Reward Town Vision</name>
	Meta_Reward_Town_Vision,

	/// <summary>
	/// TradeRoutesLimitMetaReward-More Trade Routes
	/// </summary>
	/// <name>Meta Reward Trade Routes Limit</name>
	Meta_Reward_Trade_Routes_Limit,

	/// <summary>
	/// TraderIntervalMetaRewardModel-Quicker Trader Arrival
	/// </summary>
	/// <name>Meta Reward Trader Arrival</name>
	Meta_Reward_Trader_Arrival,

	/// <summary>
	/// TraderMerchAmountMetaRewardModel-Extra Merchandise
	/// </summary>
	/// <name>Meta Reward Trader Merch</name>
	Meta_Reward_Trader_Merch,

	/// <summary>
	/// TraderMerchandisePriceReductionMetaRewardModel-Special Discount
	/// </summary>
	/// <name>Meta Reward Trader Perk Discount</name>
	Meta_Reward_Trader_Perk_Discount,

	/// <summary>
	/// VillagersSpeedMetaRewardModel-Villager Speed Increase
	/// </summary>
	/// <name>Meta Reward Villager Speed</name>
	Meta_Reward_Villager_Speed,

	/// <summary>
	/// BuildingMetaRewardModel-Weaver
	/// </summary>
	/// <name>Meta Reward Weaver</name>
	Meta_Reward_Weaver,

	/// <summary>
	/// BuildingMetaRewardModel-Workshop
	/// </summary>
	/// <name>Meta Reward Workshop</name>
	Meta_Reward_Workshop,

	/// <summary>
	/// TraderMetaRewardModel-Zhorg
	/// </summary>
	/// <name>Meta Trader Unlock A</name>
	Meta_Trader_Unlock_A,

	/// <summary>
	/// TraderMetaRewardModel-Old Farluf
	/// </summary>
	/// <name>Meta Trader Unlock B</name>
	Meta_Trader_Unlock_B,

	/// <summary>
	/// TraderMetaRewardModel-Sothur The Ancient
	/// </summary>
	/// <name>Meta Trader Unlock C</name>
	Meta_Trader_Unlock_C,

	/// <summary>
	/// TraderMetaRewardModel-Vliss Greybone
	/// </summary>
	/// <name>Meta Trader Unlock D</name>
	Meta_Trader_Unlock_D,

	/// <summary>
	/// TraderMetaRewardModel-Sir Renwald Redmane
	/// </summary>
	/// <name>Meta Trader Unlock E</name>
	Meta_Trader_Unlock_E,

	/// <summary>
	/// TraderMetaRewardModel-Xiadani Stormfeather
	/// </summary>
	/// <name>Meta Trader Unlock F</name>
	Meta_Trader_Unlock_F,

	/// <summary>
	/// TraderMetaRewardModel-Dullahan Warlander
	/// </summary>
	/// <name>Meta Trader Unlock G</name>
	Meta_Trader_Unlock_G,

	/// <summary>
	/// TimedOrdersMetaRewardModel-Timed Orders
	/// </summary>
	/// <name>Timed Orders Activation</name>
	Timed_Orders_Activation,

	/// <summary>
	/// TradeRoutesMetaRewardModel-Trade Routes
	/// </summary>
	/// <name>Trade Routes Activation</name>
	Trade_Routes_Activation,



	MAX = 399
}

public static class MetaRewardTypesExtensions
{
	private static MetaRewardTypes[] s_All = null;
	public static MetaRewardTypes[] All()
	{
		if (s_All == null)
		{
			s_All = new MetaRewardTypes[399];
			for (int i = 0; i < 399; i++)
			{
				s_All[i] = (MetaRewardTypes)(i+1);
			}
		}
		return s_All;
	}
	
	/// <summary>
	/// Returns the name or internal ID of the model that will be used in the game.
	/// Every MetaRewardTypes should have a unique name as to distinguish it from others.
	/// If no name is found, it will return MetaRewardTypes.Artifacts_10 in the enum and log an error.
	/// </summary>
	public static string ToName(this MetaRewardTypes type)
	{
		if (TypeToInternalName.TryGetValue(type, out var name))
		{
			return name;
		}

		Plugin.Log.LogError($"Cannot find name of MetaRewardTypes: " + type + "\n" + Environment.StackTrace);
		return TypeToInternalName[MetaRewardTypes.Artifacts_10];
	}
	
	/// <summary>
	/// Returns a MetaRewardTypes associated with the given name.
	/// Every MetaRewardTypes should have a unique name as to distinguish it from others.
	/// If no MetaRewardTypes is found, it will return MetaRewardTypes.Unknown and log a warning.
	/// </summary>
	public static MetaRewardTypes ToMetaRewardTypes(this string name)
	{
		foreach (KeyValuePair<MetaRewardTypes,string> pair in TypeToInternalName)
		{
			if (pair.Value == name)
			{
				return pair.Key;
			}
		}

		Plugin.Log.LogWarning("Cannot find MetaRewardTypes with name: " + name + "\n" + Environment.StackTrace);
		return MetaRewardTypes.Unknown;
	}
	
	/// <summary>
	/// Returns a MetaRewardModel associated with the given name.
	/// MetaRewardModel contain all the data that will be used in the game.
	/// Every MetaRewardModel should have a unique name as to distinguish it from others.
	/// If no MetaRewardModel is found, it will return null and log an error.
	/// </summary>
	public static Eremite.Model.Meta.MetaRewardModel ToMetaRewardModel(this string name)
	{
		Eremite.Model.Meta.MetaRewardModel model = SO.Settings.metaRewards.FirstOrDefault(a=>a.name == name);
		if (model != null)
		{
			return model;
		}
	
		Plugin.Log.LogError("Cannot find MetaRewardModel for MetaRewardTypes with name: " + name + "\n" + Environment.StackTrace);
		return null;
	}

    /// <summary>
    /// Returns a MetaRewardModel associated with the given MetaRewardTypes.
    /// MetaRewardModel contain all the data that will be used in the game.
    /// Every MetaRewardModel should have a unique name as to distinguish it from others.
    /// If no MetaRewardModel is found, it will return null and log an error.
    /// </summary>
	public static Eremite.Model.Meta.MetaRewardModel ToMetaRewardModel(this MetaRewardTypes types)
	{
		return types.ToName().ToMetaRewardModel();
	}
	
	/// <summary>
	/// Returns an array of MetaRewardModel associated with the given MetaRewardTypes.
	/// MetaRewardModel contain all the data that will be used in the game.
	/// Every MetaRewardModel should have a unique name as to distinguish it from others.
	/// If a MetaRewardModel is not found, the element will be replaced with null and an error will be logged.
	/// </summary>
	public static Eremite.Model.Meta.MetaRewardModel[] ToMetaRewardModelArray(this IEnumerable<MetaRewardTypes> collection)
	{
		int count = collection.Count();
		Eremite.Model.Meta.MetaRewardModel[] array = new Eremite.Model.Meta.MetaRewardModel[count];
		int i = 0;
		foreach (MetaRewardTypes element in collection)
		{
			array[i++] = element.ToMetaRewardModel();
		}

		return array;
	}
	
	/// <summary>
	/// Returns an array of MetaRewardModel associated with the given MetaRewardTypes.
	/// MetaRewardModel contain all the data that will be used in the game.
	/// Every MetaRewardModel should have a unique name as to distinguish it from others.
	/// If a MetaRewardModel is not found, the element will be replaced with null and an error will be logged.
	/// </summary>
	public static Eremite.Model.Meta.MetaRewardModel[] ToMetaRewardModelArray(this IEnumerable<string> collection)
	{
		int count = collection.Count();
		Eremite.Model.Meta.MetaRewardModel[] array = new Eremite.Model.Meta.MetaRewardModel[count];
		int i = 0;
		foreach (string element in collection)
		{
			array[i++] = element.ToMetaRewardModel();
		}

		return array;
	}
	
	/// <summary>
	/// Returns an array of MetaRewardModel associated with the given MetaRewardTypes.
	/// MetaRewardModel contain all the data that will be used in the game.
	/// Every MetaRewardModel should have a unique name as to distinguish it from others.
	/// If a MetaRewardModel is not found, it will not be included in the array.
	/// </summary>
	public static Eremite.Model.Meta.MetaRewardModel[] ToMetaRewardModelArrayNoNulls(this IEnumerable<string> collection)
	{
		using(ListPool<Eremite.Model.Meta.MetaRewardModel>.Get(out List<Eremite.Model.Meta.MetaRewardModel> list))
		{
			foreach (string element in collection)
			{
				Eremite.Model.Meta.MetaRewardModel model = element.ToMetaRewardModel();
				if (model != null)
				{
					list.Add(model);
				}
			}
			return list.ToArray();
		}
	}
	
	/// <summary>
	/// Returns an array of MetaRewardModel associated with the given MetaRewardTypes.
	/// MetaRewardModel contain all the data that will be used in the game.
	/// Every MetaRewardModel should have a unique name as to distinguish it from others.
	/// If a MetaRewardModel is not found, it will not be included in the array.
	/// </summary>
	public static Eremite.Model.Meta.MetaRewardModel[] ToMetaRewardModelArrayNoNulls(this IEnumerable<MetaRewardTypes> collection)
	{
		using(ListPool<Eremite.Model.Meta.MetaRewardModel>.Get(out List<Eremite.Model.Meta.MetaRewardModel> list))
		{
			foreach (MetaRewardTypes element in collection)
			{
				Eremite.Model.Meta.MetaRewardModel model = element.ToMetaRewardModel();
				if (model != null)
				{
					list.Add(model);
				}
			}
			return list.ToArray();
		}
	}
	
	internal static readonly Dictionary<MetaRewardTypes, string> TypeToInternalName = new()
	{
		{ MetaRewardTypes.Artifacts_10, "Artifacts 10" },                                                                                              // CurrencyMetaRewardModel-Artifacts
		{ MetaRewardTypes.Artifacts_15, "Artifacts 15" },                                                                                              // CurrencyMetaRewardModel-Artifacts
		{ MetaRewardTypes.Artifacts_20, "Artifacts 20" },                                                                                              // CurrencyMetaRewardModel-Artifacts
		{ MetaRewardTypes.Artifacts_5, "Artifacts 5" },                                                                                                // CurrencyMetaRewardModel-Artifacts
		{ MetaRewardTypes.Consumption_Control_Activation, "Consumption Control Activation" },                                                          // ConsumptionControlMetaRewardModel-Consumption Control
		{ MetaRewardTypes.Custom_Game_Activation, "Custom Game Activation" },                                                                          // CustomGameMetaRewardModel-Training Expedition
		{ MetaRewardTypes.Essential_Big_Shelter, "Essential Big Shelter" },                                                                            // EssentialBuildingMetaRewardModel-Big Shelter
		{ MetaRewardTypes.Essential_Common_Hall, "Essential Common Hall" },                                                                            // EssentialBuildingMetaRewardModel-Clan Hall
		{ MetaRewardTypes.Essential_Crude_Workstation, "Essential Crude Workstation" },                                                                // EssentialBuildingMetaRewardModel-Crude Workstation
		{ MetaRewardTypes.Essential_Decor_Ancient_Arch, "Essential Decor Ancient Arch" },                                                              // EssentialBuildingMetaRewardModel-Ancient Arch
		{ MetaRewardTypes.Essential_Decor_Ancient_Gravestone, "Essential Decor Ancient Gravestone" },                                                  // EssentialBuildingMetaRewardModel-Ancient Tombstone
		{ MetaRewardTypes.Essential_Decor_Anvil, "Essential Decor Anvil" },                                                                            // EssentialBuildingMetaRewardModel-Anvil
		{ MetaRewardTypes.Essential_Decor_Barrels, "Essential Decor Barrels" },                                                                        // EssentialBuildingMetaRewardModel-Barrels
		{ MetaRewardTypes.Essential_Decor_Bonfire, "Essential Decor Bonfire" },                                                                        // EssentialBuildingMetaRewardModel-Bonfire
		{ MetaRewardTypes.Essential_Decor_Cages, "Essential Decor Cages" },                                                                            // EssentialBuildingMetaRewardModel-Cages
		{ MetaRewardTypes.Essential_Decor_Chest, "Essential Decor Chest" },                                                                            // EssentialBuildingMetaRewardModel-Chest
		{ MetaRewardTypes.Essential_Decor_Coastal_Plant, "Essential Decor Coastal Plant" },                                                            // EssentialBuildingMetaRewardModel-Saltwater Pitcher Plant
		{ MetaRewardTypes.Essential_Decor_Coral, "Essential Decor Coral" },                                                                            // EssentialBuildingMetaRewardModel-Coral Growth
		{ MetaRewardTypes.Essential_Decor_Crates, "Essential Decor Crates" },                                                                          // EssentialBuildingMetaRewardModel-Crates
		{ MetaRewardTypes.Essential_Decor_Fence, "Essential Decor Fence" },                                                                            // EssentialBuildingMetaRewardModel-Fence
		{ MetaRewardTypes.Essential_Decor_Fence_Corner, "Essential Decor Fence Corner" },                                                              // EssentialBuildingMetaRewardModel-Fence Corner
		{ MetaRewardTypes.Essential_Decor_Fire_Shrine, "Essential Decor Fire Shrine" },                                                                // EssentialBuildingMetaRewardModel-Fire Shrine
		{ MetaRewardTypes.Essential_Decor_Fish, "Essential Decor Fish" },                                                                              // EssentialBuildingMetaRewardModel-Fish Mount
		{ MetaRewardTypes.Essential_Decor_Flower_Bed, "Essential Decor Flower Bed" },                                                                  // EssentialBuildingMetaRewardModel-Flower Bed
		{ MetaRewardTypes.Essential_Decor_Fox_Fence, "Essential Decor Fox Fence" },                                                                    // EssentialBuildingMetaRewardModel-Overgrown Fence
		{ MetaRewardTypes.Essential_Decor_Fox_Fence_Corner, "Essential Decor Fox Fence Corner" },                                                      // EssentialBuildingMetaRewardModel-Overgrown Fence Corner
		{ MetaRewardTypes.Essential_Decor_Frog_Tree, "Essential Decor Frog Tree" },                                                                    // EssentialBuildingMetaRewardModel-Evergreen Shrub
		{ MetaRewardTypes.Essential_Decor_Gate, "Essential Decor Gate" },                                                                              // EssentialBuildingMetaRewardModel-Gate
		{ MetaRewardTypes.Essential_Decor_Golden_Leaf, "Essential Decor Golden Leaf" },                                                                // EssentialBuildingMetaRewardModel-Golden Leaf Plant
		{ MetaRewardTypes.Essential_Decor_Industrail_Chimney, "Essential Decor Industrail Chimney" },                                                  // EssentialBuildingMetaRewardModel-Industrial Chimney
		{ MetaRewardTypes.Essential_Decor_Lamp, "Essential Decor Lamp" },                                                                              // EssentialBuildingMetaRewardModel-Lamp
		{ MetaRewardTypes.Essential_Decor_Lizard_Post, "Essential Decor Lizard Post" },                                                                // EssentialBuildingMetaRewardModel-Lizard Post
		{ MetaRewardTypes.Essential_Decor_Marbe_Fountain, "Essential Decor Marbe Fountain" },                                                          // EssentialBuildingMetaRewardModel-Marble Fountain
		{ MetaRewardTypes.Essential_Decor_Monument_Of_Greed, "Essential Decor Monument of Greed" },                                                    // EssentialBuildingMetaRewardModel-Monument of Greed
		{ MetaRewardTypes.Essential_Decor_Mushroom, "Essential Decor Mushroom" },                                                                      // EssentialBuildingMetaRewardModel-Decorative Fungus
		{ MetaRewardTypes.Essential_Decor_Nightfern, "Essential Decor Nightfern" },                                                                    // EssentialBuildingMetaRewardModel-Nightfern
		{ MetaRewardTypes.Essential_Decor_Ornate_Column, "Essential Decor Ornate Column" },                                                            // EssentialBuildingMetaRewardModel-Ornate Column
		{ MetaRewardTypes.Essential_Decor_Pipe, "Essential Decor Pipe" },                                                                              // EssentialBuildingMetaRewardModel-Pipe
		{ MetaRewardTypes.Essential_Decor_Pipe_Cross, "Essential Decor Pipe Cross" },                                                                  // EssentialBuildingMetaRewardModel-Pipe Cross
		{ MetaRewardTypes.Essential_Decor_Pipe_Elbow, "Essential Decor Pipe Elbow" },                                                                  // EssentialBuildingMetaRewardModel-Pipe Elbow
		{ MetaRewardTypes.Essential_Decor_Pipe_End, "Essential Decor Pipe End" },                                                                      // EssentialBuildingMetaRewardModel-Pipe Ending
		{ MetaRewardTypes.Essential_Decor_Pipe_T_Cross, "Essential Decor Pipe T Cross" },                                                              // EssentialBuildingMetaRewardModel-Pipe T-Connector
		{ MetaRewardTypes.Essential_Decor_Pipe_Valve, "Essential Decor Pipe Valve" },                                                                  // EssentialBuildingMetaRewardModel-Valve
		{ MetaRewardTypes.Essential_Decor_Road_Sign, "Essential Decor Road Sign" },                                                                    // EssentialBuildingMetaRewardModel-Road Sign
		{ MetaRewardTypes.Essential_Decor_Scarlet_Decor, "Essential Decor Scarlet Decor" },                                                            // EssentialBuildingMetaRewardModel-Thorny Reed
		{ MetaRewardTypes.Essential_Decor_Side_Barrels, "Essential Decor Side Barrels" },                                                              // EssentialBuildingMetaRewardModel-Rainpunk Barrels
		{ MetaRewardTypes.Essential_Decor_Signboard, "Essential Decor Signboard" },                                                                    // EssentialBuildingMetaRewardModel-Signboard
		{ MetaRewardTypes.Essential_Decor_Stone_Fence, "Essential Decor Stone Fence" },                                                                // EssentialBuildingMetaRewardModel-Stone Fence
		{ MetaRewardTypes.Essential_Decor_Stone_Fence_Corner, "Essential Decor Stone Fence Corner" },                                                  // EssentialBuildingMetaRewardModel-Stone Fence Corner
		{ MetaRewardTypes.Essential_Decor_Tower, "Essential Decor Tower" },                                                                            // EssentialBuildingMetaRewardModel-Wall Crossing
		{ MetaRewardTypes.Essential_Decor_Town_Board, "Essential Decor Town Board" },                                                                  // EssentialBuildingMetaRewardModel-Town Board
		{ MetaRewardTypes.Essential_Decor_Umbrella, "Essential Decor Umbrella" },                                                                      // EssentialBuildingMetaRewardModel-Umbrella
		{ MetaRewardTypes.Essential_Decor_Wall, "Essential Decor Wall" },                                                                              // EssentialBuildingMetaRewardModel-Wall
		{ MetaRewardTypes.Essential_Decor_Wall_Corner, "Essential Decor Wall Corner" },                                                                // EssentialBuildingMetaRewardModel-Wall Corner
		{ MetaRewardTypes.Essential_Decor_Water_Barrels, "Essential Decor Water Barrels" },                                                            // EssentialBuildingMetaRewardModel-Water Barrels
		{ MetaRewardTypes.Essential_Decor_Water_Shrine, "Essential Decor Water Shrine" },                                                              // EssentialBuildingMetaRewardModel-Water Shrine
		{ MetaRewardTypes.Essential_Decor_Well, "Essential Decor Well" },                                                                              // EssentialBuildingMetaRewardModel-Overgrown Well
		{ MetaRewardTypes.Essential_Farmfield, "Essential Farmfield" },                                                                                // EssentialBuildingMetaRewardModel-Farm Field
		{ MetaRewardTypes.Essential_Harvester, "Essential Harvester" },                                                                                // EssentialBuildingMetaRewardModel-Harvesters' Camp
		{ MetaRewardTypes.Essential_Makeshift_Post, "Essential Makeshift Post" },                                                                      // EssentialBuildingMetaRewardModel-Makeshift Post
		{ MetaRewardTypes.Essential_Mine, "Essential Mine" },                                                                                          // EssentialBuildingMetaRewardModel-Mine
		{ MetaRewardTypes.Essential_Paved_Road, "Essential Paved Road" },                                                                              // EssentialBuildingMetaRewardModel-Paved Road
		{ MetaRewardTypes.Essential_Primitive_Fishing_Hut, "Essential Primitive Fishing Hut" },                                                        // EssentialBuildingMetaRewardModel-Small Fishing Hut
		{ MetaRewardTypes.Essential_Primitive_Forager, "Essential Primitive Forager" },                                                                // EssentialBuildingMetaRewardModel-Small Foragers' Camp
		{ MetaRewardTypes.Essential_Primitive_Herbalist, "Essential Primitive Herbalist" },                                                            // EssentialBuildingMetaRewardModel-Small Herbalists' Camp
		{ MetaRewardTypes.Essential_Primitive_Trapper, "Essential Primitive Trapper" },                                                                // EssentialBuildingMetaRewardModel-Small Trappers' Camp
		{ MetaRewardTypes.Essential_Reinforced_Road, "Essential Reinforced Road" },                                                                    // EssentialBuildingMetaRewardModel-Reinforced Road
		{ MetaRewardTypes.Essential_Shelter, "Essential Shelter" },                                                                                    // EssentialBuildingMetaRewardModel-Shelter
		{ MetaRewardTypes.Essential_Small_Hearth, "Essential Small Hearth" },                                                                          // EssentialBuildingMetaRewardModel-Small Hearth
		{ MetaRewardTypes.Essential_Stonecutter, "Essential Stonecutter" },                                                                            // EssentialBuildingMetaRewardModel-Stonecutters' Camp
		{ MetaRewardTypes.Essential_Storage, "Essential Storage" },                                                                                    // EssentialBuildingMetaRewardModel-Small Warehouse
		{ MetaRewardTypes.Essential_Temporary_Hearth, "Essential Temporary Hearth" },                                                                  // EssentialBuildingMetaRewardModel-Small Hearth
		{ MetaRewardTypes.Essential_Trading_Post, "Essential Trading Post" },                                                                          // EssentialBuildingMetaRewardModel-Trading Post
		{ MetaRewardTypes.Essential_Woodcutters_Camp, "Essential Woodcutters Camp" },                                                                  // EssentialBuildingMetaRewardModel-Woodcutters' Camp
		{ MetaRewardTypes.Food_Stockpiles_10, "Food Stockpiles 10" },                                                                                  // CurrencyMetaRewardModel-Food Stockpiles
		{ MetaRewardTypes.Food_Stockpiles_15, "Food Stockpiles 15" },                                                                                  // CurrencyMetaRewardModel-Food Stockpiles
		{ MetaRewardTypes.Food_Stockpiles_20, "Food Stockpiles 20" },                                                                                  // CurrencyMetaRewardModel-Food Stockpiles
		{ MetaRewardTypes.Food_Stockpiles_25, "Food Stockpiles 25" },                                                                                  // CurrencyMetaRewardModel-Food Stockpiles
		{ MetaRewardTypes.Food_Stockpiles_30, "Food Stockpiles 30" },                                                                                  // CurrencyMetaRewardModel-Food Stockpiles
		{ MetaRewardTypes.Food_Stockpiles_5, "Food Stockpiles 5" },                                                                                    // CurrencyMetaRewardModel-Food Stockpiles
		{ MetaRewardTypes.Goals_Exp_Reward_Regular, "Goals Exp Reward - Regular" },                                                                    // ExpMetaRewardModel-Honor Badge
		{ MetaRewardTypes.House_Upgrades_Unlock_Beavers, "House Upgrades Unlock - Beavers" },                                                          // HouseUpgradesUnlockMetaRewardModel-House Upgrades: Beavers
		{ MetaRewardTypes.House_Upgrades_Unlock_Foxes, "House Upgrades Unlock - Foxes" },                                                              // HouseUpgradesUnlockMetaRewardModel-House Upgrades: Foxes
		{ MetaRewardTypes.House_Upgrades_Unlock_Frogs, "House Upgrades Unlock - Frogs" },                                                              // HouseUpgradesUnlockMetaRewardModel-House Upgrades: Frogs
		{ MetaRewardTypes.House_Upgrades_Unlock_Harpies, "House Upgrades Unlock - Harpies" },                                                          // HouseUpgradesUnlockMetaRewardModel-House Upgrades: Harpies
		{ MetaRewardTypes.House_Upgrades_Unlock_Humans, "House Upgrades Unlock - Humans" },                                                            // HouseUpgradesUnlockMetaRewardModel-House Upgrades: Humans
		{ MetaRewardTypes.House_Upgrades_Unlock_Lizards, "House Upgrades Unlock - Lizards" },                                                          // HouseUpgradesUnlockMetaRewardModel-House Upgrades: Lizards
		{ MetaRewardTypes.Ironman_Activation, "Ironman Activation" },                                                                                  // IronmanActivationMetaRewardModel-Queen's Hand Trial
		{ MetaRewardTypes.Machinery_10, "Machinery 10" },                                                                                              // CurrencyMetaRewardModel-Machinery
		{ MetaRewardTypes.Machinery_15, "Machinery 15" },                                                                                              // CurrencyMetaRewardModel-Machinery
		{ MetaRewardTypes.Machinery_20, "Machinery 20" },                                                                                              // CurrencyMetaRewardModel-Machinery
		{ MetaRewardTypes.Machinery_25, "Machinery 25" },                                                                                              // CurrencyMetaRewardModel-Machinery
		{ MetaRewardTypes.Machinery_5, "Machinery 5" },                                                                                                // CurrencyMetaRewardModel-Machinery
		{ MetaRewardTypes.Meta_Foxes_Unlock, "Meta Foxes Unlock" },                                                                                    // RaceMetaRewardModel-Fox
		{ MetaRewardTypes.Meta_Frogs_Unlock, "Meta Frogs Unlock" },                                                                                    // RaceMetaRewardModel-Frog
		{ MetaRewardTypes.Meta_Harpies_Unlock, "Meta Harpies Unlock" },                                                                                // RaceMetaRewardModel-Harpy
		{ MetaRewardTypes.Meta_Perk_Unlock_2_Hauling_Carts_In_Main_Warehouse, "Meta Perk Unlock 2 Hauling Carts in Main Warehouse" },                  // EffectMetaRewardModel-Dual Carriage System
		{ MetaRewardTypes.Meta_Perk_Unlock_Accidental_Barrels, "Meta Perk Unlock Accidental Barrels" },                                                // EffectMetaRewardModel-Over-Diligent Woodworkers
		{ MetaRewardTypes.Meta_Perk_Unlock_Alarm_Bells, "Meta Perk Unlock Alarm Bells" },                                                              // EffectMetaRewardModel-Alarm Bells
		{ MetaRewardTypes.Meta_Perk_Unlock_Amber_For_Newcomers, "Meta Perk Unlock Amber for Newcomers" },                                              // EffectMetaRewardModel-Stormwalker Tax
		{ MetaRewardTypes.Meta_Perk_Unlock_Amber_For_Trade_Routes, "Meta Perk Unlock Amber for Trade Routes" },                                        // EffectMetaRewardModel-Deep Pockets
		{ MetaRewardTypes.Meta_Perk_Unlock_Amber_For_Trader_Visit, "Meta Perk Unlock Amber for Trader Visit" },                                        // EffectMetaRewardModel-Bed and Breakfast
		{ MetaRewardTypes.Meta_Perk_Unlock_Amber_For_Water, "Meta Perk Unlock Amber for Water" },                                                      // EffectMetaRewardModel-Counterfeit Amber
		{ MetaRewardTypes.Meta_Perk_Unlock_Amber_For_Wood, "Meta Perk Unlock Amber for Wood" },                                                        // EffectMetaRewardModel-Lumber Tax
		{ MetaRewardTypes.Meta_Perk_Unlock_Back_To_Nature, "Meta Perk Unlock Back to Nature" },                                                        // EffectMetaRewardModel-Back to Nature
		{ MetaRewardTypes.Meta_Perk_Unlock_Bait_For_Crafting, "Meta Perk Unlock Bait For Crafting" },                                                  // EffectMetaRewardModel-Fish Scraps
		{ MetaRewardTypes.Meta_Perk_Unlock_Cache_Rewards_For_Nodes, "Meta Perk Unlock Cache Rewards for Nodes" },                                      // EffectMetaRewardModel-Reckless Plunder
		{ MetaRewardTypes.Meta_Perk_Unlock_Coal_For_Cyst, "Meta Perk Unlock Coal for Cyst" },                                                          // EffectMetaRewardModel-Burnt to a Crisp
		{ MetaRewardTypes.Meta_Perk_Unlock_Consumption_Control_For_Extra_Production, "Meta Perk Unlock Consumption Control for Extra Production" },    // EffectMetaRewardModel-Without Restrictions
		{ MetaRewardTypes.Meta_Perk_Unlock_Copper_For_Each_Tree, "Meta Perk Unlock Copper for each tree" },                                            // EffectMetaRewardModel-Copper Extractor
		{ MetaRewardTypes.Meta_Perk_Unlock_Corruption_Per_Removed_Cyst_Minus50, "Meta Perk Unlock Corruption Per Removed Cyst -50" },                  // EffectMetaRewardModel-Firekeeper's Armor
		{ MetaRewardTypes.Meta_Perk_Unlock_Crystaline_Water, "Meta Perk Unlock Crystaline Water" },                                                    // EffectMetaRewardModel-Small Distillery
		{ MetaRewardTypes.Meta_Perk_Unlock_Eggs_For_Cysts, "Meta Perk Unlock Eggs For Cysts" },                                                        // EffectMetaRewardModel-Blightrot Pruner
		{ MetaRewardTypes.Meta_Perk_Unlock_Exploring_Expedition, "Meta Perk Unlock Exploring Expedition" },                                            // EffectMetaRewardModel-Exploration Expedition
		{ MetaRewardTypes.Meta_Perk_Unlock_Extra_Prod_For_Consumption, "Meta Perk Unlock Extra Prod for consumption" },                                // EffectMetaRewardModel-Worker's Rations
		{ MetaRewardTypes.Meta_Perk_Unlock_Extra_Trader_Merch, "Meta Perk Unlock Extra Trader Merch" },                                                // EffectMetaRewardModel-Guild Catalogue
		{ MetaRewardTypes.Meta_Perk_Unlock_Fedora_Hat, "Meta Perk Unlock Fedora Hat" },                                                                // EffectMetaRewardModel-Old Fedora Hat
		{ MetaRewardTypes.Meta_Perk_Unlock_Forge_Trip_Hammer, "Meta Perk Unlock Forge Trip Hammer" },                                                  // EffectMetaRewardModel-Forge Trip Hammer
		{ MetaRewardTypes.Meta_Perk_Unlock_Frog_DLC_Blueprints_For_Upgrades, "Meta Perk Unlock Frog DLC - Blueprints for Upgrades" },                  // EffectMetaRewardModel-Overzealous Architects
		{ MetaRewardTypes.Meta_Perk_Unlock_Frog_DLC_Borrowed_Time, "Meta Perk Unlock Frog DLC - Borrowed Time" },                                      // EffectMetaRewardModel-Borrowed Time
		{ MetaRewardTypes.Meta_Perk_Unlock_Frog_DLC_City_Of_Wonders, "Meta Perk Unlock Frog DLC - City of Wonders" },                                  // EffectMetaRewardModel-City of Wonders
		{ MetaRewardTypes.Meta_Perk_Unlock_Frog_DLC_Frog_Clan_Support, "Meta Perk Unlock Frog DLC - Frog Clan Support" },                              // EffectMetaRewardModel-Frog Clan Support
		{ MetaRewardTypes.Meta_Perk_Unlock_Frog_DLC_Frog_Friendship, "Meta Perk Unlock Frog DLC - Frog Friendship" },                                  // EffectMetaRewardModel-Frog Friendship
		{ MetaRewardTypes.Meta_Perk_Unlock_Frog_DLC_Strength_In_Numbers, "Meta Perk Unlock Frog DLC - Strength in Numbers" },                          // EffectMetaRewardModel-Strength in Numbers
		{ MetaRewardTypes.Meta_Perk_Unlock_Hauling_Cart_In_All_Warehouses, "Meta Perk Unlock Hauling Cart in All Warehouses" },                        // EffectMetaRewardModel-Hauling Cart
		{ MetaRewardTypes.Meta_Perk_Unlock_Hostility_For_Relics, "Meta Perk Unlock Hostility for Relics" },                                            // EffectMetaRewardModel-Frequent Patrols
		{ MetaRewardTypes.Meta_Perk_Unlock_Hostility_For_Removed_Cysts, "Meta Perk Unlock Hostility for Removed Cysts" },                              // EffectMetaRewardModel-Baptism of Fire
		{ MetaRewardTypes.Meta_Perk_Unlock_Hostility_For_Water, "Meta Perk Unlock Hostility for Water" },                                              // EffectMetaRewardModel-Calming Water
		{ MetaRewardTypes.Meta_Perk_Unlock_Houses_Global_Capacity_Plus1, "Meta Perk Unlock Houses Global Capacity +1" },                               // EffectMetaRewardModel-Crowded Houses
		{ MetaRewardTypes.Meta_Perk_Unlock_HP_For_Impatience, "Meta Perk Unlock HP for Impatience" },                                                  // EffectMetaRewardModel-Queen's Gift
		{ MetaRewardTypes.Meta_Perk_Unlock_Hubs_For_Hostility, "Meta Perk Unlock Hubs for hostility" },                                                // EffectMetaRewardModel-Safe Haven
		{ MetaRewardTypes.Meta_Perk_Unlock_Insect_For_Tree, "Meta Perk Unlock Insect for tree" },                                                      // EffectMetaRewardModel-Woodpecker Technique
		{ MetaRewardTypes.Meta_Perk_Unlock_LessHostilityPerWoodcutter, "Meta Perk Unlock LessHostilityPerWoodcutter" },                                // EffectMetaRewardModel-Flame Amulets
		{ MetaRewardTypes.Meta_Perk_Unlock_Lower_Hostility_For_Religion, "Meta Perk Unlock Lower Hostility For Religion" },                            // EffectMetaRewardModel-Firelink Ritual
		{ MetaRewardTypes.Meta_Perk_Unlock_Mist_Piercers, "Meta Perk Unlock Mist Piercers" },                                                          // EffectMetaRewardModel-Mist Piercers
		{ MetaRewardTypes.Meta_Perk_Unlock_Mold_Grain, "Meta Perk Unlock Mold Grain" },                                                                // EffectMetaRewardModel-Moldy Grain Seeds
		{ MetaRewardTypes.Meta_Perk_Unlock_More_Amber_From_Routes, "Meta Perk Unlock More Amber from Routes" },                                        // EffectMetaRewardModel-Trade Negotiations
		{ MetaRewardTypes.Meta_Perk_Unlock_More_Node_Charges, "Meta Perk Unlock More Node Charges" },                                                  // EffectMetaRewardModel-Rich Glades
		{ MetaRewardTypes.Meta_Perk_Unlock_Newcomer_Rate_For_Trade_Routes, "Meta Perk Unlock Newcomer Rate for Trade Routes" },                        // EffectMetaRewardModel-Economic Migration
		{ MetaRewardTypes.Meta_Perk_Unlock_Overexploitation, "Meta Perk Unlock Overexploitation" },                                                    // EffectMetaRewardModel-Overexploitation
		{ MetaRewardTypes.Meta_Perk_Unlock_Parts_For_Trade, "Meta Perk Unlock Parts for Trade" },                                                      // EffectMetaRewardModel-Free Samples
		{ MetaRewardTypes.Meta_Perk_Unlock_Porridge_Prod_For_Water, "Meta Perk Unlock Porridge Prod for water" },                                      // EffectMetaRewardModel-Filling Dish
		{ MetaRewardTypes.Meta_Perk_Unlock_Relic_Time_Reduction, "Meta Perk Unlock Relic time reduction" },                                            // EffectMetaRewardModel-Firekeeper's Prayer
		{ MetaRewardTypes.Meta_Perk_Unlock_Reputation_From_Trade, "Meta Perk Unlock Reputation from Trade" },                                          // EffectMetaRewardModel-Trade Hub
		{ MetaRewardTypes.Meta_Perk_Unlock_Resolve_For_Chests, "Meta Perk Unlock Resolve for Chests" },                                                // EffectMetaRewardModel-Prosperous Archaeology
		{ MetaRewardTypes.Meta_Perk_Unlock_Resolve_For_Consumption, "Meta Perk Unlock Resolve for consumption" },                                      // EffectMetaRewardModel-Generous Rations
		{ MetaRewardTypes.Meta_Perk_Unlock_Resolve_For_Impatience, "Meta Perk Unlock Resolve for Impatience" },                                        // EffectMetaRewardModel-Rebellious Spirit
		{ MetaRewardTypes.Meta_Perk_Unlock_Resolve_For_Sales, "Meta Perk Unlock Resolve for Sales" },                                                  // EffectMetaRewardModel-Prosperous Settlement
		{ MetaRewardTypes.Meta_Perk_Unlock_Resolve_For_Standing, "Meta Perk Unlock Resolve for Standing" },                                            // EffectMetaRewardModel-Friendly Relations
		{ MetaRewardTypes.Meta_Perk_Unlock_Resolve_For_Started_Route, "Meta Perk Unlock Resolve for started Route" },                                  // EffectMetaRewardModel-Frequent Caravans
		{ MetaRewardTypes.Meta_Perk_Unlock_Route_Less_Travel_Time, "Meta Perk Unlock Route Less Travel Time" },                                        // EffectMetaRewardModel-Stormwalker Training
		{ MetaRewardTypes.Meta_Perk_Unlock_Royal_Guard_Training, "Meta Perk Unlock Royal Guard Training" },                                            // EffectMetaRewardModel-Royal Guard Training
		{ MetaRewardTypes.Meta_Perk_Unlock_Sacrifice_Cost_For_Impatience, "Meta Perk Unlock Sacrifice Cost for Impatience" },                          // EffectMetaRewardModel-Fiery Wrath
		{ MetaRewardTypes.Meta_Perk_Unlock_Tools_For_Death, "Meta Perk Unlock Tools for death" },                                                      // EffectMetaRewardModel-Bone Tools
		{ MetaRewardTypes.Meta_Perk_Unlock_Tools_For_Glade_For_Resolve, "Meta Perk Unlock Tools for Glade for Resolve" },                              // EffectMetaRewardModel-Improvised Tools
		{ MetaRewardTypes.Meta_Perk_Unlock_Trade_Routes_Bonus_Fuel, "Meta Perk Unlock Trade Routes Bonus Fuel" },                                      // EffectMetaRewardModel-Tightened Belt
		{ MetaRewardTypes.Meta_Perk_Unlock_Trade_Routes_For_Housing_Spots, "Meta Perk Unlock Trade routes for housing spots" },                        // EffectMetaRewardModel-Urban Planning
		{ MetaRewardTypes.Meta_Perk_Unlock_Trading_Packs, "Meta Perk Unlock Trading Packs" },                                                          // EffectMetaRewardModel-Trade Logs
		{ MetaRewardTypes.Meta_Perk_Unlock_VillagerDeathEffectBlock, "Meta Perk Unlock VillagerDeathEffectBlock" },                                    // EffectMetaRewardModel-Hidden from the Queen
		{ MetaRewardTypes.Meta_Perk_Unlock_Villagers_For_Corruption, "Meta Perk Unlock Villagers For Corruption" },                                    // EffectMetaRewardModel-From the Shadows
		{ MetaRewardTypes.Meta_Perk_Unlock_Water_Crit_For_Fishing, "Meta Perk Unlock Water Crit For Fishing" },                                        // EffectMetaRewardModel-Book of Water
		{ MetaRewardTypes.Meta_Perk_Unlock_Wildcard, "Meta Perk Unlock Wildcard" },                                                                    // EffectMetaRewardModel-Smuggler's Visit
		{ MetaRewardTypes.Meta_Perk_Unlock_Wood_Plus2_For_Insects, "Meta Perk Unlock Wood +2 for insects" },                                           // EffectMetaRewardModel-No Quality Control
		{ MetaRewardTypes.Meta_Perk_Unlock_Working_Time_For_Firekeeper, "Meta Perk Unlock Working time for firekeeper" },                              // EffectMetaRewardModel-Prayer Book
		{ MetaRewardTypes.Meta_Reward_0_Exp, "Meta Reward 0 Exp" },                                                                                    // ExpMetaRewardModel-Absolutely Nothing
		{ MetaRewardTypes.Meta_Reward_Advanced_Rain_Collector, "Meta Reward Advanced Rain Collector" },                                                // BuildingMetaRewardModel-Advanced Rain Collector
		{ MetaRewardTypes.Meta_Reward_Alchemist_Hut, "Meta Reward Alchemist Hut" },                                                                    // BuildingMetaRewardModel-Alchemist's Hut
		{ MetaRewardTypes.Meta_Reward_Apothecary, "Meta Reward Apothecary" },                                                                          // BuildingMetaRewardModel-Apothecary
		{ MetaRewardTypes.Meta_Reward_Artisan, "Meta Reward Artisan" },                                                                                // BuildingMetaRewardModel-Artisan
		{ MetaRewardTypes.Meta_Reward_Bakery, "Meta Reward Bakery" },                                                                                  // BuildingMetaRewardModel-Bakery
		{ MetaRewardTypes.Meta_Reward_Bath_House, "Meta Reward Bath House" },                                                                          // BuildingMetaRewardModel-Bath House
		{ MetaRewardTypes.Meta_Reward_Beanery, "Meta Reward Beanery" },                                                                                // BuildingMetaRewardModel-Beanery
		{ MetaRewardTypes.Meta_Reward_Beaver_House, "Meta Reward Beaver House" },                                                                      // BuildingMetaRewardModel-Beaver House
		{ MetaRewardTypes.Meta_Reward_Big_Shelter, "Meta Reward Big Shelter" },                                                                        // BuildingMetaRewardModel-Big Shelter
		{ MetaRewardTypes.Meta_Reward_Blight_Post_Upgrades_Unlock, "Meta Reward Blight Post Upgrades Unlock" },                                        // BlightPostUpgradesUnlockMetaRewardModel-Blight Post Upgrades
		{ MetaRewardTypes.Meta_Reward_Bonus_Villagers, "Meta Reward Bonus Villagers" },                                                                // BonusVillagersMetaRewardModel-More Villagers
		{ MetaRewardTypes.Meta_Reward_Bonus_Yield, "Meta Reward Bonus Yield" },                                                                        // GlobalExtraProductionChanceMetaRewardModel-Unforeseen Riches
		{ MetaRewardTypes.Meta_Reward_Brewery, "Meta Reward Brewery" },                                                                                // BuildingMetaRewardModel-Brewery
		{ MetaRewardTypes.Meta_Reward_Brick_Oven, "Meta Reward Brick Oven" },                                                                          // BuildingMetaRewardModel-Brick Oven
		{ MetaRewardTypes.Meta_Reward_Brickyard, "Meta Reward Brickyard" },                                                                            // BuildingMetaRewardModel-Brickyard
		{ MetaRewardTypes.Meta_Reward_Building_Storage, "Meta Reward Building Storage" },                                                              // GlobalBuildingStorageMetaRewardModel-Larger Storage
		{ MetaRewardTypes.Meta_Reward_Burning_Duration, "Meta Reward Burning Duration" },                                                              // FuelRateMetaRewardModel-Everlasting Flames
		{ MetaRewardTypes.Meta_Reward_Butcher, "Meta Reward Butcher" },                                                                                // BuildingMetaRewardModel-Butcher
		{ MetaRewardTypes.Meta_Reward_Cannery, "Meta Reward Cannery" },                                                                                // BuildingMetaRewardModel-Cannery
		{ MetaRewardTypes.Meta_Reward_Caravan_Goods, "Meta Reward Caravan Goods" },                                                                    // EmbarkGoodsAmountMetaRewardModel-Stocked Caravans
		{ MetaRewardTypes.Meta_Reward_Caravan_Slot, "Meta Reward Caravan Slot" },                                                                      // CaravanSlotMetaRewardModel-Additional Caravan Choice
		{ MetaRewardTypes.Meta_Reward_Carpenter, "Meta Reward Carpenter" },                                                                            // BuildingMetaRewardModel-Carpenter
		{ MetaRewardTypes.Meta_Reward_Cellar, "Meta Reward Cellar" },                                                                                  // BuildingMetaRewardModel-Cellar
		{ MetaRewardTypes.Meta_Reward_Citadel_Home_Unlock, "Meta Reward Citadel Home Unlock" },                                                        // CapitalHomeUnlockMetaRewardModel-Viceroy's Quarters
		{ MetaRewardTypes.Meta_Reward_Clan_Hall, "Meta Reward Clan Hall" },                                                                            // BuildingMetaRewardModel-Clan Hall
		{ MetaRewardTypes.Meta_Reward_Clay_Pit, "Meta Reward Clay Pit" },                                                                              // BuildingMetaRewardModel-Clay Pit
		{ MetaRewardTypes.Meta_Reward_Clothier, "Meta Reward Clothier" },                                                                              // BuildingMetaRewardModel-Clothier
		{ MetaRewardTypes.Meta_Reward_Cobbler, "Meta Reward Cobbler" },                                                                                // BuildingMetaRewardModel-Cobbler
		{ MetaRewardTypes.Meta_Reward_Cookhouse, "Meta Reward Cookhouse" },                                                                            // BuildingMetaRewardModel-Cookhouse
		{ MetaRewardTypes.Meta_Reward_Cooperage, "Meta Reward Cooperage" },                                                                            // BuildingMetaRewardModel-Cooperage
		{ MetaRewardTypes.Meta_Reward_Cornerstone, "Meta Reward Cornerstone" },                                                                        // SeasonRewardsAmountMetaRewardModel-Additional Cornerstone Choice
		{ MetaRewardTypes.Meta_Reward_Cornerstone_Reroll, "Meta Reward Cornerstone Reroll" },                                                          // CornerstonesRerollsMetaRewardModel-Cornerstone Reroll Charge
		{ MetaRewardTypes.Meta_Reward_Crude_Workstation, "Meta Reward Crude Workstation" },                                                            // BuildingMetaRewardModel-Crude Workstation
		{ MetaRewardTypes.Meta_Reward_Daily_Challenge, "Meta Reward Daily Challenge" },                                                                // DailyChallengeMetaRewardModel-Daily Expedition
		{ MetaRewardTypes.Meta_Reward_Decor_Ancient_Arch, "Meta Reward Decor Ancient Arch" },                                                          // BuildingMetaRewardModel-Ancient Arch
		{ MetaRewardTypes.Meta_Reward_Decor_Ancient_Gravestone, "Meta Reward Decor Ancient Gravestone" },                                              // BuildingMetaRewardModel-Ancient Tombstone
		{ MetaRewardTypes.Meta_Reward_Decor_Bank, "Meta Reward Decor Bank" },                                                                          // BuildingMetaRewardModel-Bench
		{ MetaRewardTypes.Meta_Reward_Decor_Barrels, "Meta Reward Decor Barrels" },                                                                    // BuildingMetaRewardModel-Barrels
		{ MetaRewardTypes.Meta_Reward_Decor_Bush, "Meta Reward Decor Bush" },                                                                          // BuildingMetaRewardModel-Bush
		{ MetaRewardTypes.Meta_Reward_Decor_Coral, "Meta Reward Decor Coral" },                                                                        // BuildingMetaRewardModel-Coral Growth
		{ MetaRewardTypes.Meta_Reward_Decor_Crates, "Meta Reward Decor Crates" },                                                                      // BuildingMetaRewardModel-Crates
		{ MetaRewardTypes.Meta_Reward_Decor_Fence, "Meta Reward Decor Fence" },                                                                        // BuildingMetaRewardModel-Fence
		{ MetaRewardTypes.Meta_Reward_Decor_Fence_Corner, "Meta Reward Decor Fence Corner" },                                                          // BuildingMetaRewardModel-Fence Corner
		{ MetaRewardTypes.Meta_Reward_Decor_Fire_Shrine, "Meta Reward Decor Fire Shrine" },                                                            // BuildingMetaRewardModel-Fire Shrine
		{ MetaRewardTypes.Meta_Reward_Decor_Flower_Bed, "Meta Reward Decor Flower Bed" },                                                              // BuildingMetaRewardModel-Flower Bed
		{ MetaRewardTypes.Meta_Reward_Decor_Gate, "Meta Reward Decor Gate" },                                                                          // BuildingMetaRewardModel-Gate
		{ MetaRewardTypes.Meta_Reward_Decor_Golden_Leaf, "Meta Reward Decor Golden Leaf" },                                                            // BuildingMetaRewardModel-Golden Leaf Plant
		{ MetaRewardTypes.Meta_Reward_Decor_Lamp, "Meta Reward Decor Lamp" },                                                                          // BuildingMetaRewardModel-Lamp
		{ MetaRewardTypes.Meta_Reward_Decor_Lizard_Post, "Meta Reward Decor Lizard Post" },                                                            // BuildingMetaRewardModel-Lizard Post
		{ MetaRewardTypes.Meta_Reward_Decor_Mushroom, "Meta Reward Decor Mushroom" },                                                                  // BuildingMetaRewardModel-Decorative Fungus
		{ MetaRewardTypes.Meta_Reward_Decor_Nightfern, "Meta Reward Decor Nightfern" },                                                                // BuildingMetaRewardModel-Nightfern
		{ MetaRewardTypes.Meta_Reward_Decor_Rainpunk_Barrels, "Meta Reward Decor Rainpunk Barrels" },                                                  // BuildingMetaRewardModel-Water Barrels
		{ MetaRewardTypes.Meta_Reward_Decor_Road_Sign, "Meta Reward Decor Road Sign" },                                                                // BuildingMetaRewardModel-Road Sign
		{ MetaRewardTypes.Meta_Reward_Decor_Side_Barrels, "Meta Reward Decor Side Barrels" },                                                          // BuildingMetaRewardModel-Rainpunk Barrels
		{ MetaRewardTypes.Meta_Reward_Decor_Signboard, "Meta Reward Decor Signboard" },                                                                // BuildingMetaRewardModel-Signboard
		{ MetaRewardTypes.Meta_Reward_Decor_Tower, "Meta Reward Decor Tower" },                                                                        // BuildingMetaRewardModel-Wall Crossing
		{ MetaRewardTypes.Meta_Reward_Decor_Umbrella, "Meta Reward Decor Umbrella" },                                                                  // BuildingMetaRewardModel-Umbrella
		{ MetaRewardTypes.Meta_Reward_Decor_Wall, "Meta Reward Decor Wall" },                                                                          // BuildingMetaRewardModel-Wall
		{ MetaRewardTypes.Meta_Reward_Distillery, "Meta Reward Distillery" },                                                                          // BuildingMetaRewardModel-Distillery
		{ MetaRewardTypes.Meta_Reward_Druid, "Meta Reward Druid" },                                                                                    // BuildingMetaRewardModel-Druid's Hut
		{ MetaRewardTypes.Meta_Reward_Embark_Blueprint_Fishing_Hut, "Meta Reward Embark Blueprint Fishing Hut" },                                      // EmbarkEffectMetaRewardModel-Embarkation Bonus: Fishing Hut
		{ MetaRewardTypes.Meta_Reward_Embark_Blueprint_Forager, "Meta Reward Embark Blueprint Forager" },                                              // EmbarkEffectMetaRewardModel-Embarkation Bonus: Foragers' Camp
		{ MetaRewardTypes.Meta_Reward_Embark_Blueprint_Herb_Garden, "Meta Reward Embark Blueprint Herb Garden" },                                      // EmbarkEffectMetaRewardModel-Embarkation Bonus: Herb Garden
		{ MetaRewardTypes.Meta_Reward_Embark_Blueprint_Herbalist, "Meta Reward Embark Blueprint Herbalist" },                                          // EmbarkEffectMetaRewardModel-Embarkation Bonus: Herbalists' Camp
		{ MetaRewardTypes.Meta_Reward_Embark_Blueprint_Plantation, "Meta Reward Embark Blueprint Plantation" },                                        // EmbarkEffectMetaRewardModel-Embarkation Bonus: Plantation
		{ MetaRewardTypes.Meta_Reward_Embark_Blueprint_Small_Farm, "Meta Reward Embark Blueprint Small Farm" },                                        // EmbarkEffectMetaRewardModel-Embarkation Bonus: Small Farm
		{ MetaRewardTypes.Meta_Reward_Embark_Blueprint_Trapper, "Meta Reward Embark Blueprint Trapper" },                                              // EmbarkEffectMetaRewardModel-Embarkation Bonus: Trappers' Camp
		{ MetaRewardTypes.Meta_Reward_Embark_Goods_Amber, "Meta Reward Embark Goods Amber" },                                                          // EmbarkGoodMetaRewardModel
		{ MetaRewardTypes.Meta_Reward_Embark_Goods_Bricks, "Meta Reward Embark Goods Bricks" },                                                        // EmbarkGoodMetaRewardModel
		{ MetaRewardTypes.Meta_Reward_Embark_Goods_Clay, "Meta Reward Embark Goods Clay" },                                                            // EmbarkGoodMetaRewardModel
		{ MetaRewardTypes.Meta_Reward_Embark_Goods_Coal, "Meta Reward Embark Goods Coal" },                                                            // EmbarkGoodMetaRewardModel
		{ MetaRewardTypes.Meta_Reward_Embark_Goods_Eggs, "Meta Reward Embark Goods Eggs" },                                                            // EmbarkGoodMetaRewardModel
		{ MetaRewardTypes.Meta_Reward_Embark_Goods_Fabric, "Meta Reward Embark Goods Fabric" },                                                        // EmbarkGoodMetaRewardModel
		{ MetaRewardTypes.Meta_Reward_Embark_Goods_Leather, "Meta Reward Embark Goods Leather" },                                                      // EmbarkGoodMetaRewardModel
		{ MetaRewardTypes.Meta_Reward_Embark_Goods_Meat, "Meta Reward Embark Goods Meat" },                                                            // EmbarkGoodMetaRewardModel
		{ MetaRewardTypes.Meta_Reward_Embark_Goods_Oil, "Meta Reward Embark Goods Oil" },                                                              // EmbarkGoodMetaRewardModel
		{ MetaRewardTypes.Meta_Reward_Embark_Goods_Parts, "Meta Reward Embark Goods Parts" },                                                          // EmbarkGoodMetaRewardModel
		{ MetaRewardTypes.Meta_Reward_Embark_Goods_Planks, "Meta Reward Embark Goods Planks" },                                                        // EmbarkGoodMetaRewardModel
		{ MetaRewardTypes.Meta_Reward_Embark_Goods_Provisions, "Meta Reward Embark Goods Provisions" },                                                // EmbarkGoodMetaRewardModel
		{ MetaRewardTypes.Meta_Reward_Embark_Goods_Reeds, "Meta Reward Embark Goods Reeds" },                                                          // EmbarkGoodMetaRewardModel
		{ MetaRewardTypes.Meta_Reward_Embark_Goods_Roots, "Meta Reward Embark Goods Roots" },                                                          // EmbarkGoodMetaRewardModel
		{ MetaRewardTypes.Meta_Reward_Embark_Goods_Stone, "Meta Reward Embark Goods Stone" },                                                          // EmbarkGoodMetaRewardModel
		{ MetaRewardTypes.Meta_Reward_Embark_Goods_Vegetables, "Meta Reward Embark Goods Vegetables" },                                                // EmbarkGoodMetaRewardModel
		{ MetaRewardTypes.Meta_Reward_Embark_Goods_Wood, "Meta Reward Embark Goods Wood" },                                                            // EmbarkGoodMetaRewardModel
		{ MetaRewardTypes.Meta_Reward_Embark_Perk_Ale_3pm, "Meta Reward Embark Perk Ale 3pm" },                                                        // EmbarkEffectMetaRewardModel-Embarkation Bonus: Ale Delivery Line
		{ MetaRewardTypes.Meta_Reward_Embark_Perk_Cornerstone_Reroll_Plus1, "Meta Reward Embark Perk Cornerstone Reroll +1" },                         // EmbarkEffectMetaRewardModel-Embarkation Bonus: Royal Permit
		{ MetaRewardTypes.Meta_Reward_Embark_Perk_Cosmetics_3pm, "Meta Reward Embark Perk Cosmetics 3pm" },                                            // EmbarkEffectMetaRewardModel-Embarkation Bonus: Tea Delivery Line
		{ MetaRewardTypes.Meta_Reward_Embark_Perk_Incense_3pm, "Meta Reward Embark Perk Incense 3pm" },                                                // EmbarkEffectMetaRewardModel-Embarkation Bonus: Incense Delivery Line
		{ MetaRewardTypes.Meta_Reward_Embark_Perk_Scrolls_3pm, "Meta Reward Embark Perk Scrolls 3pm" },                                                // EmbarkEffectMetaRewardModel-Embarkation Bonus: Scroll Delivery Line
		{ MetaRewardTypes.Meta_Reward_Embark_Perk_Training_Gear_3pm, "Meta Reward Embark Perk Training Gear 3pm" },                                    // EmbarkEffectMetaRewardModel-Embarkation Bonus: Training Gear Delivery Line
		{ MetaRewardTypes.Meta_Reward_Embark_Perk_Wine_3pm, "Meta Reward Embark Perk Wine 3pm" },                                                      // EmbarkEffectMetaRewardModel-Embarkation Bonus: Wine Delivery Line
		{ MetaRewardTypes.Meta_Reward_Embark_Point, "Meta Reward Embark Point" },                                                                      // PreparationPointsMetaRewardModel-Embarkation Points
		{ MetaRewardTypes.Meta_Reward_Embark_Range, "Meta Reward Embark Range" },                                                                      // BonusEmbarkRangeMetaRewardModel-Greater Embarkation Range
		{ MetaRewardTypes.Meta_Reward_Embark_Villagers, "Meta Reward Embark Villagers" },                                                              // EmbarkEffectMetaRewardModel-Embarkation Bonus: Villagers
		{ MetaRewardTypes.Meta_Reward_Essential_Beaver_House, "Meta Reward Essential Beaver House" },                                                  // EssentialRacialBuildingMetaRewardModel-Essential Blueprint: Beaver House
		{ MetaRewardTypes.Meta_Reward_Essential_Field_Kitchen, "Meta Reward Essential Field Kitchen" },                                                // EssentialBuildingMetaRewardModel-Essential Blueprint: Field Kitchen
		{ MetaRewardTypes.Meta_Reward_Essential_Fox_House, "Meta Reward Essential Fox House" },                                                        // EssentialRacialBuildingMetaRewardModel-Essential Blueprint: Fox House
		{ MetaRewardTypes.Meta_Reward_Essential_Frog_House, "Meta Reward Essential Frog House" },                                                      // EssentialRacialBuildingMetaRewardModel-Essential Blueprint: Frog House
		{ MetaRewardTypes.Meta_Reward_Essential_Harpy_House, "Meta Reward Essential Harpy House" },                                                    // EssentialRacialBuildingMetaRewardModel-Essential Blueprint: Harpy House
		{ MetaRewardTypes.Meta_Reward_Essential_Human_House, "Meta Reward Essential Human House" },                                                    // EssentialRacialBuildingMetaRewardModel-Essential Blueprint: Human House
		{ MetaRewardTypes.Meta_Reward_Essential_Lizard_House, "Meta Reward Essential Lizard House" },                                                  // EssentialRacialBuildingMetaRewardModel-Essential Blueprint: Lizard House
		{ MetaRewardTypes.Meta_Reward_Essential_Rain_Collector, "Meta Reward Essential Rain Collector" },                                              // EssentialBuildingMetaRewardModel-Rain Collector
		{ MetaRewardTypes.Meta_Reward_Explorers_Lodge, "Meta Reward Explorers Lodge" },                                                                // BuildingMetaRewardModel-Explorers' Lodge
		{ MetaRewardTypes.Meta_Reward_Faction_Blue, "Meta Reward Faction Blue" },                                                                      // FactionsActivationMetaRewardModel-Vanguard of the Stolen Keys
		{ MetaRewardTypes.Meta_Reward_Faction_Green, "Meta Reward Faction Green" },                                                                    // FactionsActivationMetaRewardModel-First Dawn Company
		{ MetaRewardTypes.Meta_Reward_Faction_Orange, "Meta Reward Faction Orange" },                                                                  // FactionsActivationMetaRewardModel-Brass Order
		{ MetaRewardTypes.Meta_Reward_Farm_Range, "Meta Reward Farm Range" },                                                                          // BonusFarmAreaMetaRewardModel-Farm Range Increase
		{ MetaRewardTypes.Meta_Reward_Finesmith, "Meta Reward Finesmith" },                                                                            // BuildingMetaRewardModel-Finesmith
		{ MetaRewardTypes.Meta_Reward_Fishers_Camp, "Meta Reward Fishers Camp" },                                                                      // BuildingMetaRewardModel-Fishing Hut
		{ MetaRewardTypes.Meta_Reward_Foragers_Camp, "Meta Reward Forager's Camp" },                                                                   // BuildingMetaRewardModel-Foragers' Camp
		{ MetaRewardTypes.Meta_Reward_Forum, "Meta Reward Forum" },                                                                                    // BuildingMetaRewardModel-Forum
		{ MetaRewardTypes.Meta_Reward_Fox_House, "Meta Reward Fox House" },                                                                            // BuildingMetaRewardModel-Fox House
		{ MetaRewardTypes.Meta_Reward_Frog_House, "Meta Reward Frog House" },                                                                          // BuildingMetaRewardModel-Frog House
		{ MetaRewardTypes.Meta_Reward_Furnace, "Meta Reward Furnace" },                                                                                // BuildingMetaRewardModel-Furnace
		{ MetaRewardTypes.Meta_Reward_Global_Capacity, "Meta Reward Global Capacity" },                                                                // GlobalCapacityMetaRewardModel-Worker Capacity Increase
		{ MetaRewardTypes.Meta_Reward_Goals_Unlock, "Meta Reward Goals Unlock" },                                                                      // GoalsUnlockMetaRewardModel-Obsidian Archive
		{ MetaRewardTypes.Meta_Reward_Grace_Period, "Meta Reward Grace Period" },                                                                      // GracePeriodMetaRewardModel-Last Stand
		{ MetaRewardTypes.Meta_Reward_Granary, "Meta Reward Granary" },                                                                                // BuildingMetaRewardModel-Granary
		{ MetaRewardTypes.Meta_Reward_Greenhouse, "Meta Reward Greenhouse" },                                                                          // BuildingMetaRewardModel-Greenhouse
		{ MetaRewardTypes.Meta_Reward_Grill, "Meta Reward Grill" },                                                                                    // BuildingMetaRewardModel-Grill
		{ MetaRewardTypes.Meta_Reward_Grove, "Meta Reward Grove" },                                                                                    // BuildingMetaRewardModel-Forester's Hut
		{ MetaRewardTypes.Meta_Reward_Guaranteed_Bricks, "Meta Reward Guaranteed Bricks" },                                                            // CaravanGoodMetaRewardModel
		{ MetaRewardTypes.Meta_Reward_Guaranteed_Fabric, "Meta Reward Guaranteed Fabric" },                                                            // CaravanGoodMetaRewardModel
		{ MetaRewardTypes.Meta_Reward_Guaranteed_Pipes, "Meta Reward Guaranteed Pipes" },                                                              // CaravanGoodMetaRewardModel
		{ MetaRewardTypes.Meta_Reward_Guaranteed_Planks, "Meta Reward Guaranteed Planks" },                                                            // CaravanGoodMetaRewardModel
		{ MetaRewardTypes.Meta_Reward_Guild_House, "Meta Reward Guild House" },                                                                        // BuildingMetaRewardModel-Guild House
		{ MetaRewardTypes.Meta_Reward_Harpy_House, "Meta Reward Harpy House" },                                                                        // BuildingMetaRewardModel-Harpy House
		{ MetaRewardTypes.Meta_Reward_Haulers_Main_Storage, "Meta Reward Haulers - Main Storage" },                                                    // MainStorageHaulersMetaRewardModel-Haulers - Main Warehouse
		{ MetaRewardTypes.Meta_Reward_Haulers_Secondary_Storage, "Meta Reward Haulers - Secondary Storage" },                                          // SecondaryStorageHaulersMetaRewardModel-Haulers - Small Warehouse
		{ MetaRewardTypes.Meta_Reward_Hearth, "Meta Reward Hearth" },                                                                                  // BuildingMetaRewardModel-Small Hearth
		{ MetaRewardTypes.Meta_Reward_Herb_Garden, "Meta Reward Herb Garden" },                                                                        // BuildingMetaRewardModel-Herb Garden
		{ MetaRewardTypes.Meta_Reward_Herbalist_Camp, "Meta Reward Herbalist Camp" },                                                                  // BuildingMetaRewardModel-Herbalists' Camp
		{ MetaRewardTypes.Meta_Reward_Home_Decor_Ancient_Artifact, "Meta Reward Home Decor - Ancient Artifact" },                                      // CapitalHomeDecorationMetaRewardModel-Ancient Artifact
		{ MetaRewardTypes.Meta_Reward_Home_Decor_Domesticated_Sea_Tiger, "Meta Reward Home Decor - Domesticated Sea Tiger" },                          // CapitalHomeDecorationMetaRewardModel-Domesticated Sea Tiger
		{ MetaRewardTypes.Meta_Reward_Home_Decor_Dueling_Umbrella, "Meta Reward Home Decor - Dueling Umbrella" },                                      // CapitalHomeDecorationMetaRewardModel-Dueling Umbrella
		{ MetaRewardTypes.Meta_Reward_Home_Decor_Fishman_Skull, "Meta Reward Home Decor - Fishman Skull" },                                            // CapitalHomeDecorationMetaRewardModel-Fishman Skull
		{ MetaRewardTypes.Meta_Reward_Home_Decor_Ibex_Rug, "Meta Reward Home Decor - Ibex Rug" },                                                      // CapitalHomeDecorationMetaRewardModel-Ibex Rug
		{ MetaRewardTypes.Meta_Reward_Home_Decor_Inscribed_Slab, "Meta Reward Home Decor - Inscribed Slab" },                                          // CapitalHomeDecorationMetaRewardModel-Inscribed Slab
		{ MetaRewardTypes.Meta_Reward_Home_Decor_Landscape_Painting, "Meta Reward Home Decor - Landscape Painting" },                                  // CapitalHomeDecorationMetaRewardModel-Landscape Painting
		{ MetaRewardTypes.Meta_Reward_Home_Decor_Marshglow_Fungite, "Meta Reward Home Decor - Marshglow Fungite" },                                    // CapitalHomeDecorationMetaRewardModel-Marshglow Fungite
		{ MetaRewardTypes.Meta_Reward_Home_Decor_Mole_Trophy, "Meta Reward Home Decor - Mole Trophy" },                                                // CapitalHomeDecorationMetaRewardModel-Mole Trophy
		{ MetaRewardTypes.Meta_Reward_Home_Decor_Painting_Of_The_Ancient_Hearth, "Meta Reward Home Decor - Painting of the Ancient Hearth" },          // CapitalHomeDecorationMetaRewardModel-Painting of the Ancient Hearth
		{ MetaRewardTypes.Meta_Reward_Home_Decor_Plate_Of_Food, "Meta Reward Home Decor - Plate of Food" },                                            // CapitalHomeDecorationMetaRewardModel-Plate of Food
		{ MetaRewardTypes.Meta_Reward_Home_Decor_Reefbloom, "Meta Reward Home Decor - Reefbloom" },                                                    // CapitalHomeDecorationMetaRewardModel-Reefbloom
		{ MetaRewardTypes.Meta_Reward_Home_Decor_Rosevine, "Meta Reward Home Decor - Rosevine" },                                                      // CapitalHomeDecorationMetaRewardModel-Rosevine
		{ MetaRewardTypes.Meta_Reward_Home_Decor_Sparkdew_Crystal, "Meta Reward Home Decor - Sparkdew Crystal" },                                      // CapitalHomeDecorationMetaRewardModel-Sparkdew Crystal
		{ MetaRewardTypes.Meta_Reward_Home_Decor_Storm_Orb, "Meta Reward Home Decor - Storm Orb" },                                                    // CapitalHomeDecorationMetaRewardModel-Storm Orb
		{ MetaRewardTypes.Meta_Reward_Home_Decor_The_Sparkcaster, "Meta Reward Home Decor - The Sparkcaster" },                                        // CapitalHomeDecorationMetaRewardModel-The Sparkcaster
		{ MetaRewardTypes.Meta_Reward_Home_Decor_Trade_Contract, "Meta Reward Home Decor - Trade Contract" },                                          // CapitalHomeDecorationMetaRewardModel-Trade Contract
		{ MetaRewardTypes.Meta_Reward_Home_Decor_Uniform_0_Standard_Uniform, "Meta Reward Home Decor - Uniform 0 - Standard Uniform" },                // CapitalHomeDecorationMetaRewardModel-Standard Uniform
		{ MetaRewardTypes.Meta_Reward_Home_Decor_Uniform_1_Settlers_Mask, "Meta Reward Home Decor - Uniform 1 - Settler's Mask" },                     // CapitalHomeDecorationMetaRewardModel-Settler's Mask
		{ MetaRewardTypes.Meta_Reward_Home_Decor_Uniform_2_Pioneers_Mantle, "Meta Reward Home Decor - Uniform 2 - Pioneer's Mantle" },                 // CapitalHomeDecorationMetaRewardModel-Pioneer's Mantle
		{ MetaRewardTypes.Meta_Reward_Home_Decor_Uniform_3_Veterans_Shoulder_Guard, "Meta Reward Home Decor - Uniform 3 - Veteran's Shoulder Guard" }, // CapitalHomeDecorationMetaRewardModel-Veteran's Shoulder Guard
		{ MetaRewardTypes.Meta_Reward_Home_Decor_Uniform_4_Viceroys_Cape, "Meta Reward Home Decor - Uniform 4 - Viceroy's Cape" },                     // CapitalHomeDecorationMetaRewardModel-Viceroy's Cape
		{ MetaRewardTypes.Meta_Reward_Home_Decor_Uniform_5_Decorated_Belt, "Meta Reward Home Decor - Uniform 5 - Decorated Belt" },                    // CapitalHomeDecorationMetaRewardModel-Decorated Belt
		{ MetaRewardTypes.Meta_Reward_Home_Decor_Uniform_6_Royal_Visage, "Meta Reward Home Decor - Uniform 6 - Royal Visage" },                        // CapitalHomeDecorationMetaRewardModel-Royal Visage
		{ MetaRewardTypes.Meta_Reward_Home_Decor_Uniform_7_Stormshroud_Attire, "Meta Reward Home Decor - Uniform 7 - Stormshroud Attire" },            // CapitalHomeDecorationMetaRewardModel-Stormshroud Attire
		{ MetaRewardTypes.Meta_Reward_Home_Decor_Uniform_8_Crimson_Cloak, "Meta Reward Home Decor - Uniform 8 - Crimson Cloak" },                      // CapitalHomeDecorationMetaRewardModel-Crimson Cloak
		{ MetaRewardTypes.Meta_Reward_Home_Decor_Uniform_9_Queens_Hand_Pauldron, "Meta Reward Home Decor - Uniform 9 - Queen's Hand Pauldron" },       // CapitalHomeDecorationMetaRewardModel-Queen's Hand Pauldron
		{ MetaRewardTypes.Meta_Reward_Homestead, "Meta Reward Homestead" },                                                                            // BuildingMetaRewardModel-Homestead
		{ MetaRewardTypes.Meta_Reward_Hub_Tier_1, "Meta Reward Hub Tier 1" },                                                                          // HubTierMetaRewardModel-Hearth Upgrade - Neighborhood
		{ MetaRewardTypes.Meta_Reward_Hub_Tier_2, "Meta Reward Hub Tier 2" },                                                                          // HubTierMetaRewardModel-Hearth Upgrade - District
		{ MetaRewardTypes.Meta_Reward_Human_House, "Meta Reward Human House" },                                                                        // BuildingMetaRewardModel-Human House
		{ MetaRewardTypes.Meta_Reward_Impatience, "Meta Reward Impatience" },                                                                          // ReputationPenaltyRateMetaRewardModel-Queen's Patience
		{ MetaRewardTypes.Meta_Reward_Kiln, "Meta Reward Kiln" },                                                                                      // BuildingMetaRewardModel-Kiln
		{ MetaRewardTypes.Meta_Reward_Leatherworks, "Meta Reward Leatherworks" },                                                                      // BuildingMetaRewardModel-Leatherworker
		{ MetaRewardTypes.Meta_Reward_Lizard_House, "Meta Reward Lizard House" },                                                                      // BuildingMetaRewardModel-Lizard House
		{ MetaRewardTypes.Meta_Reward_Lumbermill, "Meta Reward Lumbermill" },                                                                          // BuildingMetaRewardModel-Lumber Mill
		{ MetaRewardTypes.Meta_Reward_Manufactory, "Meta Reward Manufactory" },                                                                        // BuildingMetaRewardModel-Manufactory
		{ MetaRewardTypes.Meta_Reward_Market, "Meta Reward Market" },                                                                                  // BuildingMetaRewardModel-Market
		{ MetaRewardTypes.Meta_Reward_Menu_Skin_Coral_Forest, "Meta Reward Menu Skin - Coral Forest" },                                                // MenuSkinMetaRewardModel-Menu Skin: Coral Forest
		{ MetaRewardTypes.Meta_Reward_Menu_Skin_Cursed_Royal_Woodlands, "Meta Reward Menu Skin - Cursed Royal Woodlands" },                            // MenuSkinMetaRewardModel-Menu Skin: Cursed Royal Woodlands
		{ MetaRewardTypes.Meta_Reward_Menu_Skin_Farming, "Meta Reward Menu Skin - Farming" },                                                          // MenuSkinMetaRewardModel-Menu Skin: Calm Settlement
		{ MetaRewardTypes.Meta_Reward_Menu_Skin_Industry, "Meta Reward Menu Skin - Industry" },                                                        // MenuSkinMetaRewardModel-Menu Skin: Industrial Town
		{ MetaRewardTypes.Meta_Reward_Menu_Skin_Marshlands, "Meta Reward Menu Skin - Marshlands" },                                                    // MenuSkinMetaRewardModel-Menu Skin: Marshlands
		{ MetaRewardTypes.Meta_Reward_Menu_Skin_Scarlet_Orchard, "Meta Reward Menu Skin - Scarlet Orchard" },                                          // MenuSkinMetaRewardModel-Menu Skin: Scarlet Orchard
		{ MetaRewardTypes.Meta_Reward_Menu_Skin_Sealed_Forest, "Meta Reward Menu Skin - Sealed Forest" },                                              // MenuSkinMetaRewardModel-Menu Skin: Sealed Forest
		{ MetaRewardTypes.Meta_Reward_Meta_Resources, "Meta Reward Meta Resources" },                                                                  // CurrencyMultiplayerMetaRewardModel-More Citadel Resources
		{ MetaRewardTypes.Meta_Reward_Mine, "Meta Reward Mine" },                                                                                      // BuildingMetaRewardModel-Mine
		{ MetaRewardTypes.Meta_Reward_Mine_Upgrade_Unlock, "Meta Reward Mine Upgrade Unlock" },                                                        // MineUpgradesUnlockMetaRewardModel-Mine Upgrades
		{ MetaRewardTypes.Meta_Reward_Monastery, "Meta Reward Monastery" },                                                                            // BuildingMetaRewardModel-Monastery
		{ MetaRewardTypes.Meta_Reward_Newcomer_Goods, "Meta Reward Newcomer Goods" },                                                                  // NewcommersGoodsRateMetaRewardModel-Newcomer Gifts
		{ MetaRewardTypes.Meta_Reward_Node_Charges, "Meta Reward Node Charges" },                                                                      // RawDepositsChargesMetaRewardModel-Gathering Technique
		{ MetaRewardTypes.Meta_Reward_Pantry, "Meta Reward Pantry" },                                                                                  // BuildingMetaRewardModel-Pantry
		{ MetaRewardTypes.Meta_Reward_Passive_Beavers, "Meta Reward Passive Beavers" },                                                                // RevealEffectMetaRewardModel-Starting Ability: Beavers
		{ MetaRewardTypes.Meta_Reward_Passive_Foxes, "Meta Reward Passive Foxes" },                                                                    // RevealEffectMetaRewardModel-Starting Ability: Foxes
		{ MetaRewardTypes.Meta_Reward_Passive_Frogs, "Meta Reward Passive Frogs" },                                                                    // RevealEffectMetaRewardModel-Starting Ability: Frogs
		{ MetaRewardTypes.Meta_Reward_Passive_Harpies, "Meta Reward Passive Harpies" },                                                                // RevealEffectMetaRewardModel-Starting Ability: Harpies
		{ MetaRewardTypes.Meta_Reward_Passive_Humans, "Meta Reward Passive Humans" },                                                                  // RevealEffectMetaRewardModel-Starting Ability: Humans
		{ MetaRewardTypes.Meta_Reward_Passive_Lizards, "Meta Reward Passive Lizards" },                                                                // RevealEffectMetaRewardModel-Starting Ability: Lizards
		{ MetaRewardTypes.Meta_Reward_Paved_Road, "Meta Reward Paved Road" },                                                                          // BuildingMetaRewardModel-Paved Road
		{ MetaRewardTypes.Meta_Reward_Plantation, "Meta Reward Plantation" },                                                                          // BuildingMetaRewardModel-Plantation
		{ MetaRewardTypes.Meta_Reward_Press, "Meta Reward Press" },                                                                                    // BuildingMetaRewardModel-Press
		{ MetaRewardTypes.Meta_Reward_Prod_Speed, "Meta Reward Prod Speed" },                                                                          // GlobalProductionSpeedMetaRewardModel-Production Speed Increase
		{ MetaRewardTypes.Meta_Reward_Provisioner, "Meta Reward Provisioner" },                                                                        // BuildingMetaRewardModel-Provisioner
		{ MetaRewardTypes.Meta_Reward_Rain_Mill, "Meta Reward Rain Mill" },                                                                            // BuildingMetaRewardModel-Rain Mill
		{ MetaRewardTypes.Meta_Reward_Rainpunk_Activation, "Meta Reward Rainpunk Activation" },                                                        // RainpunkMetaRewardModel-Rainpunk Engines
		{ MetaRewardTypes.Meta_Reward_Rainpunk_Foundry, "Meta Reward Rainpunk Foundry" },                                                              // BuildingMetaRewardModel-Rainpunk Foundry
		{ MetaRewardTypes.Meta_Reward_Ranch, "Meta Reward Ranch" },                                                                                    // BuildingMetaRewardModel-Ranch
		{ MetaRewardTypes.Meta_Reward_Reputation_Reward_Pick, "Meta Reward Reputation Reward Pick" },                                                  // ReputationRewardPicksMetaRewardModel-Additional Blueprint Choice
		{ MetaRewardTypes.Meta_Reward_Reshuffle, "Meta Reward Reshuffle" },                                                                            // ReputationRewardsRerollMetaRewardModel-Blueprint Reroll
		{ MetaRewardTypes.Meta_Reward_Sacrifice_Cost, "Meta Reward Sacrifice Cost" },                                                                  // HearthSacraficeTimeRateMetaRewardModel-Sacrificial Flames
		{ MetaRewardTypes.Meta_Reward_Scribe, "Meta Reward Scribe" },                                                                                  // BuildingMetaRewardModel-Scribe
		{ MetaRewardTypes.Meta_Reward_Sewer, "Meta Reward Sewer" },                                                                                    // BuildingMetaRewardModel-Clothier
		{ MetaRewardTypes.Meta_Reward_Smelter, "Meta Reward Smelter" },                                                                                // BuildingMetaRewardModel-Smelter
		{ MetaRewardTypes.Meta_Reward_Smithy, "Meta Reward Smithy" },                                                                                  // BuildingMetaRewardModel-Smithy
		{ MetaRewardTypes.Meta_Reward_Smokehouse, "Meta Reward Smokehouse" },                                                                          // BuildingMetaRewardModel-Smokehouse
		{ MetaRewardTypes.Meta_Reward_Stamping_Mill, "Meta Reward Stamping Mill" },                                                                    // BuildingMetaRewardModel-Stamping Mill
		{ MetaRewardTypes.Meta_Reward_Storage, "Meta Reward Storage" },                                                                                // BuildingMetaRewardModel-Main Warehouse
		{ MetaRewardTypes.Meta_Reward_Supplier, "Meta Reward Supplier" },                                                                              // BuildingMetaRewardModel-Supplier
		{ MetaRewardTypes.Meta_Reward_Tavern, "Meta Reward Tavern" },                                                                                  // BuildingMetaRewardModel-Tavern
		{ MetaRewardTypes.Meta_Reward_Tea_Doctor, "Meta Reward Tea Doctor" },                                                                          // BuildingMetaRewardModel-Tea Doctor
		{ MetaRewardTypes.Meta_Reward_Tea_House, "Meta Reward Tea House" },                                                                            // BuildingMetaRewardModel-Teahouse
		{ MetaRewardTypes.Meta_Reward_Temple, "Meta Reward Temple" },                                                                                  // BuildingMetaRewardModel-Temple
		{ MetaRewardTypes.Meta_Reward_Tinctury, "Meta Reward Tinctury" },                                                                              // BuildingMetaRewardModel-Tinctury
		{ MetaRewardTypes.Meta_Reward_Tinkerer, "Meta Reward Tinkerer" },                                                                              // BuildingMetaRewardModel-Tinkerer
		{ MetaRewardTypes.Meta_Reward_Toolshop, "Meta Reward Toolshop" },                                                                              // BuildingMetaRewardModel-Toolshop
		{ MetaRewardTypes.Meta_Reward_Town_Vision, "Meta Reward Town Vision" },                                                                        // TownsVisionRangeMetaRewardModel-Increased Town Vision Range
		{ MetaRewardTypes.Meta_Reward_Trade_Routes_Limit, "Meta Reward Trade Routes Limit" },                                                          // TradeRoutesLimitMetaReward-More Trade Routes
		{ MetaRewardTypes.Meta_Reward_Trader_Arrival, "Meta Reward Trader Arrival" },                                                                  // TraderIntervalMetaRewardModel-Quicker Trader Arrival
		{ MetaRewardTypes.Meta_Reward_Trader_Merch, "Meta Reward Trader Merch" },                                                                      // TraderMerchAmountMetaRewardModel-Extra Merchandise
		{ MetaRewardTypes.Meta_Reward_Trader_Perk_Discount, "Meta Reward Trader Perk Discount" },                                                      // TraderMerchandisePriceReductionMetaRewardModel-Special Discount
		{ MetaRewardTypes.Meta_Reward_Villager_Speed, "Meta Reward Villager Speed" },                                                                  // VillagersSpeedMetaRewardModel-Villager Speed Increase
		{ MetaRewardTypes.Meta_Reward_Weaver, "Meta Reward Weaver" },                                                                                  // BuildingMetaRewardModel-Weaver
		{ MetaRewardTypes.Meta_Reward_Workshop, "Meta Reward Workshop" },                                                                              // BuildingMetaRewardModel-Workshop
		{ MetaRewardTypes.Meta_Trader_Unlock_A, "Meta Trader Unlock A" },                                                                              // TraderMetaRewardModel-Zhorg
		{ MetaRewardTypes.Meta_Trader_Unlock_B, "Meta Trader Unlock B" },                                                                              // TraderMetaRewardModel-Old Farluf
		{ MetaRewardTypes.Meta_Trader_Unlock_C, "Meta Trader Unlock C" },                                                                              // TraderMetaRewardModel-Sothur The Ancient
		{ MetaRewardTypes.Meta_Trader_Unlock_D, "Meta Trader Unlock D" },                                                                              // TraderMetaRewardModel-Vliss Greybone
		{ MetaRewardTypes.Meta_Trader_Unlock_E, "Meta Trader Unlock E" },                                                                              // TraderMetaRewardModel-Sir Renwald Redmane
		{ MetaRewardTypes.Meta_Trader_Unlock_F, "Meta Trader Unlock F" },                                                                              // TraderMetaRewardModel-Xiadani Stormfeather
		{ MetaRewardTypes.Meta_Trader_Unlock_G, "Meta Trader Unlock G" },                                                                              // TraderMetaRewardModel-Dullahan Warlander
		{ MetaRewardTypes.Timed_Orders_Activation, "Timed Orders Activation" },                                                                        // TimedOrdersMetaRewardModel-Timed Orders
		{ MetaRewardTypes.Trade_Routes_Activation, "Trade Routes Activation" },                                                                        // TradeRoutesMetaRewardModel-Trade Routes

	};
}
