# Against The Storm API

This mod is designed to be used in conjunction with other mods that wish to add new content to the game. 
It provides a number of useful functions for adding new things to the game in a way that takes away the struggles of understanding the code base and more.

Against the Storm is a deeply complex game with tricky to navigate code for the average person. Also with the game being regular updated it's impossible to know what the devs will change in code which can result in your mod breaking and requiring you to manually fix and reupload it.


![alt text](https://github.com/JamesVeug/AgainstTheStormAPI/blob/master/Github/CustomKeyBindings.png?raw=true "Custom Keybindings")
![alt text](https://github.com/JamesVeug/AgainstTheStormAPI/blob/master/Github/ModsTab.png?raw=true "Mods tab for adjustable values")
![alt text](https://github.com/JamesVeug/AgainstTheStormAPI/blob/master/Github/ConsoleExample.png?raw=true "Developer Console available form the menu")


## How to install

### Installation with Thunderstore (Recommended)
1. Download and install the Thunderstore app for free from [here](https://thunderstore.io/)
2. Install [API mod](https://thunderstore.io/c/against-the-storm/p/ATS_API_Devs/API/) using the Thunderstore App
   - Be sure `BepInEx` is installed too!
3. Run the game using Thunderstore


### Manual Installation
1. Install v5.4.21 of [BepInEx](https://github.com/BepInEx/BepInEx/releases/tag/v5.4.21)
   - Extract the contents of the zip into `Against the Storm` folder that has the games `Against the Storm.exe` in it
   - Run the game once so `Against the Storm/BepInEx/plugins` gets created. [If the plugins folder does not get created then you installed it wrong.](https://docs.bepinex.dev/articles/user_guide/installation/index.html)
2. Install [API mod](https://thunderstore.io/c/against-the-storm/p/ATS_API_Devs/API/)
   - Download content using the Manual Download button
   - Extract the contents of the zip into the `Against the Storm/BepInEx/plugins` folder
3. Run the game


## Help

### Example Mod
The API is worked alongside the Example Mod mod which contains at least 1 of every new feature in the API to ensure everything is working as we expect.

You're encouraged to view all the code and copy+paste anything you require into your own mod.

If anything does not work please reach out on the discord!

**Github:** https://github.com/JamesVeug/AgainstTheStormAPI/tree/master/ExampleMod

**Thunderstore:** https://thunderstore.io/c/against-the-storm/p/ATS_API_Devs/ExampleMod/


### Discord
If you require help with the mod, have ideas you want added, want to report a problem or just want to chat join our discord.
    
https://discord.com/invite/ZfVWG86gsJ


### Wiki
If you need help with how to use the API here is the wiki to provide examples and explanations.

https://github.com/JamesVeug/AgainstTheStormAPI/blob/master/ATS_API/WIKI/WIKI.md


## Support added for
- Enabling the Developer Quantum Console within the options menu
- New Goods (items that can be traded/sold, food & fuel)
- New Perks/Cornerstones
- New Traders
- New Orders (Minimal)
- New Buildings
  - House
  - Workshop
  - Decoration (+Custom tier support)
  - Institution (aka: Service buildings)
- New Recipes
- New Races (Minimal)
- New Difficulties
- New MetaRewards (Goods and Effects when embarking)
- New Biomes
- Localization for all of the above
- Custom Hotkeys (Saving and rebinding included)
- Custom Save/Load system

## Other stuff added
- Any options/configs that mods add can be modified in the options menu of the game.
- [Enums](https://github.com/JamesVeug/AgainstTheStormAPI/tree/master/ATS_API/Scripts/Helpers/Enums) that list everything in the game, so you can easily see what items/orders exist and get their data without hassle.

## API Localization
The API contains text that is needed for custom message popups, missing content added by mods and others. The text has been google translated by default to other languages. 

If you'd like to help translate the text to your language please reach out on the discord or [suggest changes on the spread sheet](https://docs.google.com/spreadsheets/d/1KeU4Dr45S2l7VQ2XEi_8hwKSiZ3IZE3LHkTP5aZA7IU/edit?usp=sharing) 

## Contributors
- JamesGames
- Forwindz


## Special Thanks
- TelHurin (Eremite Games)
- Shush
- ElenaRoan
