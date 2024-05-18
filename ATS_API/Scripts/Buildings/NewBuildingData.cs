using ATS_API.Helpers;
using Eremite.Buildings;
using UnityEngine;

namespace ATS_API.Buildings;

public class NewBuildingData : ASyncable<BuildingModel>
{
    public string Guid;
    public string Name;
    public BuildingModel BuildingModel;
    public BuildingVisualData VisualData;
    public BuildingBehaviourTypes Behaviour;
    public Sprite Icon;
    public object MetaData;

    public override void Sync(BuildingModel model)
    {
        base.Sync(model);

        if (BuildingModel.Prefab == null)
        {
            Building clone = BuildingManager.GetDefaultVisualData(Behaviour);
            
            // Set up!
            
            
        }
    }
}