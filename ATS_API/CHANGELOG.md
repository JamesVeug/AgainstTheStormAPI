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

# 1.1.0
- Added Custom Trader support
- Added BareBones support for Custom Order
- Added GoodsProductionBuilder
- Added lots more helper methods
- Fixed tooltip icons showing text instead of icons
- Fixed unable to sell custom goods at trader (1.3.3)
  - Added optional Short description goods
- Fixed new fuels breaking existing save files

# 1.0.0
- Added Custom Goods support
- Added Custom Cornerstones support