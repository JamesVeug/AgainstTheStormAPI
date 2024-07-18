using Eremite.Buildings;

namespace ATS_API.Buildings;

public interface IBuildingBuilder
{
    public BuildingModel Model { get; }
    public string GUID { get; }
    public string Name { get; }
}