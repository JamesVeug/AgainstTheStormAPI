using ATS_API.Helpers;
using Eremite.Buildings;

namespace ATS_API.Buildings;

public class NewBuildingTagModel : ASyncable<BuildingTagModel>
{
    public readonly BuildingTagTypes ID;
    public readonly BuildingTagModel Model;

    public NewBuildingTagModel(BuildingTagTypes id, BuildingTagModel buildingTagModel)
    {
        Model = buildingTagModel;
        ID = id;
    }
}