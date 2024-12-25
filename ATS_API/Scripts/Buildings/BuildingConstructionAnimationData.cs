using UnityEngine;

namespace ATS_API.Buildings;

/// <summary>
/// Data that controls how a building reacts when its under construction
/// If no data is provided then a building with the same dimensions will be used instead
/// If some values are not set then the values from the template will be used 
/// </summary>
public class BuildingConstructionAnimationData
{
    public bool? SimpleScaffolding;
    public GameObject ScaffoldingPrefab;
        
    public Vector3? unconstructedPosition;
    public Vector3? constructedPosition;
        
    public ParticleSystem dustPrefab;
    public Vector2? buildingRising;
    public Vector2? scaffoldingDropping;
    public Vector2? dustRange;
    public Vector3? scaffoldingPosition;
    public Vector2? scaffoldingDroppedPosition;
    public int? levels;
    public Vector2? scaffoldingRising;

    public void ReplaceNulls(BuildingConstructionAnimationData template)
    {
        if (!SimpleScaffolding.HasValue)
        {
            SimpleScaffolding = template.SimpleScaffolding;
        }
        if (ScaffoldingPrefab == null)
        {
            ScaffoldingPrefab = template.ScaffoldingPrefab;
        }
        if (!unconstructedPosition.HasValue)
        {
            unconstructedPosition = template.unconstructedPosition;
        }
        if (!constructedPosition.HasValue)
        {
            constructedPosition = template.constructedPosition;
        }
        if (dustPrefab == null)
        {
            dustPrefab = template.dustPrefab;
        }
        if (!buildingRising.HasValue)
        {
            buildingRising = template.buildingRising;
        }
        if (!scaffoldingDropping.HasValue)
        {
            scaffoldingDropping = template.scaffoldingDropping;
        }
        if (!dustRange.HasValue)
        {
            dustRange = template.dustRange;
        }
        if (!scaffoldingPosition.HasValue)
        {
            scaffoldingPosition = template.scaffoldingPosition;
        }
        if (!scaffoldingDroppedPosition.HasValue)
        {
            scaffoldingDroppedPosition = template.scaffoldingDroppedPosition;
        }
        if (!levels.HasValue)
        {
            levels = template.levels;
        }
        if (!scaffoldingRising.HasValue)
        {
            scaffoldingRising = template.scaffoldingRising;
        }
    }
}