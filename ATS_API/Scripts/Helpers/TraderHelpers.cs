using System.Collections.Generic;
using ATS_API.Traders;

namespace ATS_API.Helpers;

public class TraderHelpers
{
    public static readonly IReadOnlyList<string> DefaultDesiredGoods = new List<string>()
    {
        "[Valuable] Amber",
        "[Valuable] Ancient Tablet",
        "[Mat Processed] Parts",
        "[Packs] Pack of Crops",
        "[Packs] Pack of Luxury Goods",
        "[Packs] Pack of Provisions",
        "[Packs] Pack of Trade Goods",
        "[Packs] Pack of Building Materials",
        "[Food Processed] Skewers",
        "[Food Processed] Jerky",
        "[Food Processed] Biscuits",
        "[Food Processed] Pie",
        "[Food Processed] Pickled Goods",
        "[Needs] Wine",
        "[Needs] Ale",
        "[Needs] Coats",
        "[Needs] Incense",
        "[Needs] Scrolls",
        "[Needs] Tea",
        "[Crafting] Coal",
        "[Crafting] Oil",
        "[Tools] Simple Tools",
        "[Metal] Copper Ore",
        "_Meta Machinery",
        "_Meta Food Stockpiles",
        "_Meta Artifacts",
        "[Crafting] Sea Marrow",
        "Blight Fuel",
        "Hearth Parts",
        "[Food Processed] Porridge"
    };

    public static readonly IReadOnlyList<NameToAmount> DefaultOfferedGoods =
        new List<NameToAmount>()
        {
            new(50, "[Needs] Ale"),
            new(50, "[Needs] Wine"),
            new(50, "[Needs] Incense"),
            new(50, "[Needs] Scrolls"),
            new(50, "[Needs] Tea"),
            new(50, "[Needs] Coats"),
            new(50, "[Vessel] Pottery"),
            new(50, "[Vessel] Barrels"),
            new(50, "[Crafting] Flour"),
            new(50, "[Crafting] Pigment"),
            new(50, "[Needs] Training Gear"),
            new(50, "[Vessel] Waterskin"),
            new(50, "[Mat Raw] Resin"),
            new(40, "[Food Raw] Herbs"),
            new(40, "[Mat Raw] Leather"),
            new(40, "[Mat Raw] Clay"),
            new(30, "[Mat Processed] Planks"),
            new(30, "[Mat Processed] Bricks"),
            new(30, "[Mat Processed] Fabric"),
            new(15, "[Mat Processed] Pipe")
        };

    public static readonly IReadOnlyList<NameToAmount> DefaultGuaranteedOfferedGoods =
        new List<NameToAmount>()
        {
            new(40, "[Valuable] Amber")
        };

    public static readonly IReadOnlyList<NameToAmount> DefaultMerchandise = new List<NameToAmount>()
    {
        new(50, "Herbalist Camp Blueprint"),
        new(50, "Forager's Camp Blueprint"),
        new(50, "Trapper's Camp Blueprint"),
        new(40, "Coats +3"),
        new(40, "Jerky +3"),
        new(40, "Tea +3"),
        new(40, "Ale +3"),
        new(25, "Bricks +3"),
        new(40, "Oil +3"),
        new(40, "Vegetables +1"),
        new(30, "Accidental Jerky"),
        new(50, "0_5 Reputation Donation"),
        new(40, "SmallFarm Blueprint"),
        new(40, "Herb Garden Blueprint"),
        new(40, "Brickyard Blueprint"),
        new(40, "Lumbermill Blueprint"),
        new(40, "Weaver Blueprint"),
        new(40, "Crude Workstation +50"),
        new(30, "Trading Packs"),
        new(40, "Extra Harpy Newcommers"),
        new(40, "Skewers +3"),
        new(25, "Fabric +3"),
        new(50, "NeedPerk Coats Breaks"),
        new(50, "NeedPerk Housing Resolve"),
        new(50, "NeedPerk Ale Resolve"),
        new(10, "Wildcard Pick Trader"),
        new(50, "Porridge +2")
    };
}