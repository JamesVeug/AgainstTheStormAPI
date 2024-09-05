using ATS_API.Helpers;
using ATS_API.Localization;
using Eremite.Model;
using UnityEngine;

namespace ATS_API.Effects;

public abstract class AResolveEffectBuilder<T> where T : ResolveEffectModel
{
    public string Name => m_name;
    public string GUID => m_guid;
    public T EffectModel => m_effectModel;
    public ResolveEffectModel Model => m_effectModel;
    
    protected readonly NewResolveEffectData m_newData;
    protected readonly T m_effectModel;
    protected readonly string m_guid;
    protected readonly string m_name;
    
    public AResolveEffectBuilder(string guid, string name, string iconPath)
    {
        m_guid = guid;
        m_name = name;

        m_newData = EffectManager.CreateResolveEffect<T>(guid, name);
        m_effectModel = (T)m_newData.Model;
        m_effectModel.label = Placeholders.Label;
        m_effectModel.displayName = Placeholders.DisplayName;
        m_effectModel.description = Placeholders.Description;
        m_effectModel.resolve = 1;

        if (!string.IsNullOrEmpty(iconPath))
        {
            SetIcon(iconPath);
        }
    }
    
    public AResolveEffectBuilder<T> SetResolve(int amount, ResolveEffectType resolveType)
    {
        m_effectModel.resolve = amount;
        m_effectModel.type = resolveType;
        return this;
    }
    
    public AResolveEffectBuilder<T> SetIcon(string iconPath)
    {
        return SetIcon(TextureHelper.GetImageAsSprite(iconPath, TextureHelper.SpriteType.EffectIcon));
    }
    
    public AResolveEffectBuilder<T> SetIcon(Texture2D texture)
    {
        return SetIcon(texture.ConvertTexture(TextureHelper.SpriteType.EffectIcon));
    }
    
    public AResolveEffectBuilder<T> SetIcon(Sprite sprite)
    {
        TextMeshProManager.Add(sprite.texture, m_newData.Model.name);
        m_effectModel.icon = sprite;
        return this;
    }

    public AResolveEffectBuilder<T> SetLabel(string labelModel, SystemLanguage systemLanguage = SystemLanguage.English)
    {
        m_effectModel.label = LocalizationManager.ToLabelModel(m_guid, m_name, "label", labelModel, systemLanguage);
        return this;
    }

    public AResolveEffectBuilder<T> SetDisplayName(string displayName, SystemLanguage systemLanguage = SystemLanguage.English)
    {
        m_effectModel.displayName = LocalizationManager.ToLocaText(m_guid, m_name, "displayName", displayName, systemLanguage);
        return this;
    }
    
    public AResolveEffectBuilder<T> SetDisplayNameKey(string key)
    {
        m_effectModel.displayName = new LocaText() { key = key };
        return this;
    }

    public virtual AResolveEffectBuilder<T> SetDescription(string description)
    {
        m_effectModel.description = LocalizationManager.ToLocaText(m_guid, m_name, "description", description);
        return this;
    }
    
    public virtual AResolveEffectBuilder<T> SetDescriptionKey(string key)
    {
        m_effectModel.description = new LocaText() { key = key };
        return this;
    }
}