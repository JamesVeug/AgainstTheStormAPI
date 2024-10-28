# Custom Goods

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

This creates a new Good that is registered to the game. We provide the GUID of the mod, a name that never changes and an icon (128x128).
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


# Custom Cornerstones

Cornerstones are effects/perks that are rewarded periodically throughout Against the Storm to provide the player positive and negative buffs.

To create a new Cornerstone here is an example of how you would do it with a 128x128 icon.

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

# Custom Traders

Traders are NPCs that regularly arrive at the Trading post or appear in some glades. Players can purchase items from them or sell items to them.

To create a new Trader here is an example of how you would do it.

TraderIcon is the large detailed icon that appears in the Trading menu (256x256). TraderIconSmall is the icon that apepars in the world in the UI and above the trading post. (63x63)

```csharp
TraderBuilder builder = new TraderBuilder(PluginInfo.PLUGIN_GUID, "ExampleTrader", "TraderIcon.png", "TraderIconSmall.png");
builder.SetDisplayName("Example Trader");
builder.SetDescription("This is an example trader.");
builder.SetDialogue("Hello, I am an example trader.");
builder.SetStayingTime(10);
builder.SetArrivalTime(10);
builder.SetAssaultData(3,5,0.5f,0.4f, true);
builder.AddGuaranteedOfferedGoods((2, "[Valuable] Ancient Tablet"));
builder.AddDesiredGoods("[Mat Raw] Wood");
builder.SetAmountOfGoods(20,30);
builder.SetAvailableInAllBiomes();
```


# Custom Races

Custom races are still in the experimental phase and may not work as intended. Here's an example of how to create one using existing game data.

```csharp
RaceBuilder builder = new RaceBuilder(PluginInfo.PLUGIN_GUID, "Axolotl");
builder.SetDisplayName("Axolotl");
builder.SetPluralDisplayName("Axolotls");
builder.SetDescription("Axolotls are a type of salamander that fully metamorphosed into land-dwelling creatures.");
builder.SetIcon("Axolotl.png");
builder.SetRoundIcon("AxolotlRound.png");
builder.SetWideIcon("AxolotlWide.png");

builder.AddCharacteristic(BuildingTagTypes.Rainwater, VillagerPerkTypes.Proficiency);
builder.AddCharacteristic(BuildingTagTypes.Brewing, VillagerPerkTypes.Comfortable_Job);

builder.AddNeed(NeedTypes.Any_Housing);
builder.AddNeed(NeedTypes.Biscuits);

CustomRaceNeed burgerNeed = RaceNeedFactory.ComplexFoodNeed(PluginInfo.PLUGIN_GUID, burger.NewGood.id, 7);
builder.AddNeed(burgerNeed.ID);
```

Characteristics, Needs and housing all are currently being tested so some may not work as intended which is why documentation is limited at this time.

Custom models are not supported atm, so they use the Harpy model by default.

See the example mod for more code examples.


# Custom Hotkeys

Hotkeys are keybindings that the player can change in the options menu and when performed will trigger code within your mod.

To create your own C# hotkey you can use the following code as an example. This will register a hotkey that when F1 is pressed will log "Hello!" to the console.

```csharp
Hotkeys.RegisterKey("My Mod Name", "dothething", "Log Hello", [KeyCode.F1], () =>
{
    Debug.Log("Hello"!);
});
```

`"My Mod Name"` is what will to show as the header in the options menu. 

`"dothething"` is the key that will be saved and loaded as an id for the action. So this needs to be unique and once your mod is released you should NEVER change this. 

`"Log Hello"` is the text that will appear in the options menu.

`[KeyCode.F1]` are the default keys that will trigger the hotkey. [See here for more KeyCodes](https://docs.unity3d.com/ScriptReference/KeyCode.html)

Every set of keys with the same id will be saved in their own file when the user closes the KeyBindings menu. You can view these in `%localappdata%low/Eremite Games/Against the Storm/My Mod Name.save`


# Custom Difficulties / Prestiges

Against the Storm has an array of difficulties that can be selected when starting a new game. You can add your own difficulty to the game using the following code.

```csharp
DifficultyBuilder builder = new DifficultyBuilder("My Mod Name", "Faster Corruption");
builder.SetPrestigeLevel(21);
builder.CopyModifiersFromPreviousDifficulties(true);

NewAscensionModifierModel modifier = builder.AddModifier(EffectTypes.Hearth_Corruption_Rate_Plus50);
modifier.SetShortDescription("Corruption in the Ancient Hearth grows 50% quicker.");
``` 

This will create a new P21 difficulty for you to play that will increase the corruption rate by 50% and include all previous modifiers from early prestiges.

`"My Mod Name"` is the name of your mod. This should commonly `PluginInfo.PLUGIN_GUID.`

`"Faster Corruption"` is the name of the difficulty. Used to uniquely identify the difficulty.

`"Corruption in the Ancient Hearth grows 50% quicker."` is the description of the difficulty that will appear in the options menu.

`CopyModifiersFromPreviousDifficulties();` will copy all the modifiers from the previous prestige levels. Can be set to false to define your own modifiers

# Custom save data

Sometimes you might want to save data for your mod that can be loaded when the game is loaded. 

This can be used to save settings, progress or anything else you might need.

```csharp
ModSaveData data = ModdedSaveManager.GetSaveData(PluginInfo.PLUGIN_GUID);
data.General.SetValue("Used my mod", true);
data.CurrentCycle.SetValue("Time", DateTime.Now.ToLongTimeString());
data.CurrentSettlement.SetValue("Time", DateTime.Now.ToLongTimeString());

bool usedMod = data.General.GetValue<bool>("Used my mod");
```

- General save data always persists.
- CurrentCycle resets every time you end a cycle.
- CurrentSettlement resets every time you start a new game.