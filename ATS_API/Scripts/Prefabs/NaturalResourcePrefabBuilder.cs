using ATS_API;
using ATS_API.Helpers;
using Eremite.MapObjects;
using UnityEngine;

public class NaturalResourcePrefabBuilder
{
    public string Name => m_name;
    public string GUID => m_guid;
    
    protected readonly string m_guid;
    protected readonly string m_name;
    
    private NaturalResourcePrefabs m_prefabTemplate;
    private Texture2D m_textureOverride;
    
    public NaturalResourcePrefabBuilder(string guid, string name)
    {
        m_guid = guid;
        m_name = name;
    }

    public NaturalResourcePrefabBuilder SetPrefabTemplate(NaturalResourcePrefabs prefabTemplate)
    {
        m_prefabTemplate = prefabTemplate;
        return this;
    }

    public void SetTexture(string texture)
    {
        m_textureOverride = TextureHelper.GetImageAsTexture(texture, FilterMode.Bilinear);
    }

    public NaturalResource CreatePrefab()
    {
        NaturalResource prefab = m_prefabTemplate.ToNaturalResource();
        string fullName = m_guid + "_" + m_name; 
        NaturalResourcePrefabs id = GUIDManager.Get<NaturalResourcePrefabs>(m_guid, m_name);
        NaturalResourcePrefabsExtensions.TypeToInternalName[id] = fullName;
        NaturalResource clone = GameObject.Instantiate(prefab, Plugin.PrefabContainer);
        clone.name = fullName;
        clone.transform.localPosition = Vector3.zero;
        clone.transform.localRotation = Quaternion.identity;
        clone.transform.localScale = Vector3.one;
        
        if(m_textureOverride != null)
        {
            foreach (MeshRenderer renderer in clone.GetComponentsInChildren<MeshRenderer>())
            {
                Material material = new Material(renderer.material);
                material.SetTexture("Texture2D_46400E5F", m_textureOverride);
                renderer.material = material;
            }
        }
        
        return clone;
    }
}