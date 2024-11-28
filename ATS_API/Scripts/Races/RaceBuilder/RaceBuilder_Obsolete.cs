using System;
using ATS_API.Helpers;

namespace ATS_API.Races;

public partial class RaceBuilder
{
    [Obsolete("Deprecated in v1.5. You just need ot add the race to the house as a need instead.", true)]
    public RaceBuilder SetHousingNeed(string housingNeed)
    {
        return this;
    }

    [Obsolete("Deprecated in v1.5. You just need ot add the race to the house as a need instead.", true)]
    public RaceBuilder SetHousingNeed(NeedTypes housingNeed)
    {
        return this;
    }
}