using Eremite.Model;

namespace ATS_API.Needs;

public class RaceNeedBuilder
{
    public string Name => _customRaceNeed.NeedModel.name; // myguid_itemName
    public CustomRaceNeed CustomRaceNeed => _customRaceNeed;
    
    private readonly string guid; // myGuid
    private readonly string name; // itemName
    
    private readonly CustomRaceNeed _customRaceNeed;

    public RaceNeedBuilder(string guid, string name)
    {
        this.guid = guid;
        this.name = name;

        _customRaceNeed = RaceNeedManager.New(guid, name);
    }
    
    
}