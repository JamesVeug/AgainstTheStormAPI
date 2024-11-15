using ATS_API.Helpers;
using ATS_API.Localization;
using Eremite.Model;
using Eremite.Model.Configs.CustomGame;
using Eremite.WorldMap;
using UnityEngine;

namespace ATS_API.Biomes;

public partial class BiomeBuilder
{
    public NewBiome NewBiome => newBiome;
    public BiomeModel Model => newModel;
    
    private readonly NewBiome newBiome;
    private readonly BiomeModel newModel;
    private readonly string guid; // myGuid
    private readonly string name; // itemName
    
    public BiomeBuilder(string guid, string name)
    {
        newBiome = BiomeManager.New(guid, name);
        newModel = newBiome.biomeModel;
        this.guid = guid;
        this.name = name;
        
        newModel.displayName = Placeholders.DisplayName; // Royal Woodlands
        newModel.description = Placeholders.Description; // "The Queen's forests were once part of the Smoldering City, but the Blightstorm reclaimed this land. The Royal Woodlands are rich in roots, moss broccoli, mushrooms, and flax, with a decent amount of dewberries and clay. The ground is fertile and soft, which makes it perfect for farming.",
        newModel.soilGrade = "Biome_SoilGrade_Medium".ToLocaText();
        newModel.size = "Biome_Size_Medium".ToLocaText();

        newModel.isTutorialBiome = false;
        newModel.canBePicked = true;
        newModel.canBePickedInDemo = true;
        newModel.canHaveModifier = true;
        newModel.material = null; // Set this using an existing model if its null and worldMapTexture is null.
        newModel.fields = null; // Use the existing model if its null.
        newModel.isInCustom = true;
        newModel.customGameBlueprintsType = BiomeBlueprintsType.Default;
        newModel.biomeVFX = null; // null for Cursed Royal Woodlands
        newModel.icon = null; // Set this using an existing model if its null.
        
        // Woodland Town
        newModel.townName = Placeholders.TownName;
        
        // The Queen's forests were once part of the Smoldering City, but the Blightstorm reclaimed this land. The Royal Woodlands are rich in roots, moss broccoli, mushrooms, and flax, with a decent amount of dewberries and clay. The ground is fertile and soft, which makes it perfect for farming.
        newModel.townDescription = Placeholders.TownDescription;
        
        // Use the existing model if its null.
        // NOTE: This is the entire world for the biome which will need a custom solution for when the player wants to change the texutre of the ground.
        newModel.maps = null;
        
        newModel.Ore = null; // Empty list for Cursed Royal Woodlands
        newModel.haseBaseReward = true;
        
        newModel.baseMetaCurrency = null; // Use NewBiome baseMetaCurrency and baseMetaCurrencyAmount
        newModel.haseNearbyReward = true;
        
        newModel.nearbyMetaCurrency = null; // Use NewBiome nearbyMetaCurrency and nearbyMetaCurrencyAmount
        
        newModel.reputationToExpWinRatio = 2.5f;
        newModel.reputationToExpLooseRatio = 2f;
        newModel.expForLooseWithoutPoints = 0;
        
        newModel.rewardChasesCalculatedFromCenter = false;
        
        newModel.mainHearth = null; // Use the existing model if its null.
        newModel.mainStorage = null; // Use the existing model if its null.
        
        newModel.wantedGoods = null; // Use NewBiome tradeRouteGoods


        // Clone Cursed Royal Woodlands and insert rewards and whatnot from NewBiome
        // LOOOOOOOOOOOOOTS to do here wow
        newModel.seasons = null; 
        
        
        // Clone Cursed Royal Woodlands and insert rewards and whatnot from NewBiome
        // Pretty standard but lots of options for the player
        newModel.newcomers = null;
        
        newModel.music = null; // Use the existing model if its null.
        newModel.graphics = null; // Use the existing model if its null.
        newModel.trade = null; // Use the existing model if its null. (All biomes use this really)
        newModel.difficulty = null; // Clone the existing model if its null.
        newModel.hostility = null; // Clone the existing model if its null.
        
        newModel.mapResources = null; // Use the existing model if its null.
        newModel.gladesRewards = null; // Clone the existing model if its null.
        newModel.gladesDeposits = null; // Clone the existing model if its null.
        newModel.gladesSprings = null; // Clone the existing model if its null.
        newModel.oreDeposits = null; // Clone the existing model if its null.
        newModel.gladesBuildings = null; // Clone the existing model if its null.
        newModel.gladesRelics = null; // Clone the existing model if its null.
        newModel.landPatches = null; // Clone the existing model if its null.

        newModel.earlyEffects = null; // Empty list for Cursed Royal Woodlands
        newModel.effects = null; // Use the existing model if its null. contains 1 that is _Biome_ Wood in Woodlands
        newModel.initialGoods = null; // Empty list for Cursed Royal Woodlands
        
        newModel.corsairDrizzleProfiles = null; // Use the existing model if its null.
        newModel.corsairClearanceProfiles = null; // Use the existing model if its null.
        newModel.corsairStormProfiles = null; // Use the existing model if its null.
    }
}