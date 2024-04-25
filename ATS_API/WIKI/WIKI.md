# Goods

Goods are items that can be traded / sold traders, used as food or fuel or crafting. They can also be used as rewards for completing orders or as rewards for keeping relics.


To create a new kind of Good here is an example of how you would do it.

```csharp
GoodsBuilder builder = new GoodsBuilder(PluginInfo.PLUGIN_GUID, "Diamonds", "Diamonds.png");
builder.SetDisplayName("Diamonds");
builder.SetDescription("Shiny and worth a lot of money. but not strong enough to be used as Armor.");
builder.CanBeSoldToAllTraders(40);
builder.CanBeSoldToPlayer(10, 35);
builder.AddRelicKeepRewardChance(10, 4);
builder.AddRelicKeepRewardChance(5, 2);
```

### Make a new Good

This creates a new Good that is registered to the game. We provide the GUID of the mod, a name that never changes and an icon.
NOTE: Once the name has be defined it should never be changed or it will break peoples games.

```csharp
GoodsBuilder builder = new GoodsBuilder("my mods guid", "Name of Good", "image path");
```

### DisplayName and Description

These define the text that appears in the game. By default they will be in English but if you want to use other languages you define the language as the second parameter.

```csharp
builder.SetDisplayName("Visible name of Good");
builder.SetDescription("Description of the Good that displays when in your inventory or in the trader.");
```

```csharp
builder.SetDisplayName("보이는 이름 영어", SystemLanguage.Korean);
```

### Sold by Trader

This sets up the Good so it can be sold by all traders for a price.
- 10 represents how many are sold byh the trader at a time.
- 35 represents the price the trader will buy the Good for. The amount is adjusted according to multipliers in the game. (How that's defined is unknown at this time)
- 100 represents the chance it will be sold by the trader. (1-100, This is a percentage)

```csharp
builder.CanBeSoldToPlayer(10, 35, 100);
```

### Sold to Player

This sets up the Good so the player can sell the Good to traders for an amount.
The amount is adjusted according to multipliers in the game. (How that's defined is unknown at this time)

```csharp
builder.CanBeSoldToAllTraders(40);
```

### Rewarded by Relic / Abandoned Caches

To reward the Good at Glades you can use this function. It will provide a chance of appearing in Abandoned Caches. You can specify more than 1 per Good.
- 10 represents the chance it will appear in a cache
- 4 represents how much will be in the reward

```csharp
builder.AddRelicKeepRewardChance(10, 4);
```


# Cornerstones

Cornerstones are effects/perks that are rewarded periodically throughout Against the Storm to provide the player positive and negative buffs.

To create a new Cornerstone here is an example of how you would do it.

```csharp
HookedEffectBuilder builder = new HookedEffectBuilder(PluginInfo.PLUGIN_GUID, "Modders Unite", "TestCornerstone.png");
builder.SetObtainedAsCornerstone(); // Sets the effect as a cornerstone so it can be acquired after each year 
builder.SetAvailableInAllBiomesAndSeasons(); // Sets the effect to be available in all biomes and seasons
builder.SetDrawLimit(1); // Limits the player to have only 1 per game
builder.AddHook(HookFactory.AfterXNewVillagers(8)); // Adds the every X fillagers do the effect
builder.AddHookedEffect(EffectFactory.AddHookedEffect_IncreaseResolve(PluginInfo.PLUGIN_GUID, "UniteResolve", 1, ResolveEffectType.Global)); // Adds 1 global resolve per 8 villagers

builder.SetDisplayName("Modders Unite"); // Sets the display name of the effect that the player sees
builder.SetDescription("Modders have united the kingdom and raised everyone's spirits. " +
                        "Every {0} new Villagers gain +{1} Global Resolve."); // Sets the common description
builder.SetDescriptionArgs((SourceType.Hook, TextArgType.Amount), (SourceType.HookedEffect, TextArgType.Amount)); // Optional: Sets what the {x} will be poplated with
builder.SetPreviewDescription("+{0} Global Resolve"); // Shows the progression of the effect once acquired (eg: +5 Global Resolve)
builder.SetPreviewDescriptionArgs(HookedStateTextArg.HookedStateTextSource.TotalGainIntFromHooked); // Sets what the {x} will be poplated with
```
