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