# 3.x.x
- Buildings
  - Added support for custom decorations
  - Added support for custom decoration tiers
  - Added support to BuildingBuilders to change tile size
    - Only 1x1 and 2x2 tested
  - Added first pass support to modify existing builds
- Biomes
  - Added Gather and Fall sound support for NaturalResources
  - Added custom terrain support for biomes
    - Placeholder Masked type to overlay textures easily
    - Custom terrain handling support
  - Added support to set fertile amount text
  - Added support to set how much soil is in a biome (Only 0 nullifies it atm)
- Enum helpers
  - Added WorkshopTypes enum
  - Added DecorationTierTypes enum
  - Added more comments overall and line breaks to summary
  - Added integer value to all enums (Except EffectResolveTypes)
  - Fixed .All() not including custom enums
  - Updated to v1.5.6R (Safe)
- Other
  - Added EventBus to store various events to reduce mods needing to patch the same method over and over again
  - Fixed AssetBundlerHelper unloading a bundler after extracting something once
  - Improved logging when failing to load sounds

# 3.0.1
- Bumped ATS version to 1.5.6R
- Added more support for WorkshopRecipeBuilder

# 3.0.0 - Possible mod breaking changes.
- Bumped ATS version to 1.5.5R
- Added comments/documentation to API so modders have an idea of what things do (Project needs documentation pass)
- Added Custom support for Biomes (Minimal)
- Updated all enums to 1.5.2R with HEAPS more documentation (Mod breaking)
- API now localizes all custom text to supported languages using google-translate
  - [Link to spreadsheet for suggestions](https://docs.google.com/spreadsheets/d/1KeU4Dr45S2l7VQ2XEi_8hwKSiZ3IZE3LHkTP5aZA7IU/edit?usp=sharing)
- Added more enums
  - SimpleSeasonalEffectTypes
  - ResourcesDepositsTypes
  - NaturalResourceTypes
- Added more documentation to enums
- Added more helper methods
- LocalizationManager now supports loading .csv and .tsv files
- Added How to make asset bundles to WIKI
- When playing in Spanish Latin American will default to Spanish translations 
- Possibly more languageCode fixes

# 2.3.0
- Added Custom saving support
- Added Custom Meta Reward support (Goods and Effects)
- Added AscensionModifierTypes enum
- Added GeneralPopup which any mod can use
  - Custom save system uses this when a file fails to load
- Mods Tab now shows a tooltip with mod description and dependencies and if they are installed or not.
- MetaRewardTypes enum updated to 1.4.17R and now includes the type of MetaReward
- Difficulty cleanup and added more methods (may break existing mods - none on thunderstore atm)
- Added missing Key methods for HookedEffectBuilder
- Exposed more stuff that was previously private
- Added preset Localization keys
- Deprecated `RegisterKey` function for Hotkeys in favor of `New`
- Removed a bunch of logs to reduce console spam
- Goods and effects now have custom icon types

# 2.2.0
- Added Custom Difficulty support
- Fixed localization not working
- Fixed ChineseSimplified and Chinese Traditional using wrong locale codes

# 2.1.0
- Bumped ATS version to 1.4.11R
- Options/Configs for mods that can be modified will show in the options menu now
- Improved support for custom hotkeys that appear in the options menu too

# 2.0.0 - Contains mod breaking changes.
- Bumped ATS version to 1.4.4R
  - Updated Enum helpers
- Added Custom race support (first pass)
- Added ResolveEffectBuilder
- Added more columns to relics.csv export
- Added stack trace when failing to find data using enum helpers
- Custom BuildingTagModel support
- Refactored loading mods flow to be less error-prone

# 1.2.4
- Fixed infinite loading screen when loading save with the SkyScaper building
- Fixed infinite loading screen when loading save with missing perks/effects
- Added MetaCurrencyTypes enum helper
- Added more SetIcon methods for goods and effect builders
- Added AddHostility helper method to EffectFactory
- Added order support when exporting csv data
- Reduced console spam

# 1.2.3
- Added VillagerPerkTypes enum helper
- Added BuildingPerkTypes enum helper

# 1.2.2
- Added Set icon method for GoodsBuilder, so it also changes inline images
- Added string to Types enum helper for all enum types
- Added support to replace existing inline images
- Added load and export helpers for audio
- Added export texture helper method
- Reduced number of logs

# 1.2.1
- Added CSVBuilder helper to export relics
- Added GoodsCategoriesTypes enum helper
- Can now do your own csv and .cs enum export using configs
- Fixed displayName, description and shortDescription not editable if key exists.
- Fixed New goods not working with new traders
- Fixed not being able to add new strings after game has loaded
- Added more config options

# 1.2.0 - Contains mod breaking changes.
- Light support for custom buildings with and without a custom model
  - Houses and Workshops
- Added RecipeBuilder and WorkshopRecipeBuilder
- Added new enums
  - BiomeTypes
  - BuildingBehaviourTypes
  - BuildingCategoryTypes
  - BuildingTagTypes
  - BuildingTypes
  - DifficultyTypes
  - EffectTypes
  - GoalTypes
  - GoodsTypes (Enums have been changed)
  - MetaRewardTypes
  - NeedTypes
  - OreTypes
  - ProfessionTypes
  - RaceTypes
  - RelicTypes
  - ResolveEffectTypes
  - SeasonTypes
  - TagTypes
  - TraderTypes
- Added ToName, GetAll and ToModel helper methods for all enum types
- Added remove hook helper methods
- Added SetShowHookedRewardsAsPerks effect helper
- Added missing language support to hooked effect building (Code breaking)
- Added namespace for SeasonTypes (Code breaking)
- Added helper method to generate .cs files for all enums 
- Added Asset bundle helper methods
- Fixed custom effects without declaring a hook throwing an exception
- Fixed custom effects that add removal hooks not working
- Fixed localization sometimes not working for custom mods
- More code comments/documentation

# 1.1.1 - Possible mod breaking changes.
- Added defaults to new goods and effects to avoid errors when making a new perk/cornerstone
- Added light support for devs to specify a renaming of an effect to avoid breaking saves.
- Added AfterSeasonChanges Hook (Thanks Shush!)
- Added SetLabel for EffectBuilders
- Added GoodsTypes enum for easier referencing types. Can still use string if preferred
- Fixed missing resolve effects breaking existing save files
- Fixed HookedEffectBuilder.AddInstantEffect changing the name of the main effect
- Fixed error message when trying to get a Good that does not exist
- Renamed SetMissingFields to AssignMissingFieldsToEffect
- Renamed CanbeSoldToAllTraders to CanBeSoldToAllTraders
- Changed a lot of namespaces to be more precise

## 1.1.0
- Added Custom Trader support
- Added BareBones support for Custom Order
- Added GoodsProductionBuilder
- Added lots more helper methods
- Fixed tooltip icons showing text instead of icons
- Fixed unable to sell custom goods at trader (1.3.3)
  - Added optional Short description goods
- Fixed new fuels breaking existing save files

## 1.0.0
- Added Custom Goods support
- Added Custom Cornerstones support