using ATS_API.Ascension;
using ATS_API.Helpers;
using ATS_API.Localization;
using Eremite.Model;
using UnityEngine;

namespace ATS_API.Difficulties;

public class DifficultyBuilder
{
    private readonly NewDifficulty newDifficulty;
    private readonly DifficultyModel newModel;
    private readonly string guid; // myGuid
    private readonly string name; // itemName
    
    public DifficultyBuilder(string guid, string name)
    {
        newDifficulty = DifficultyManager.New(guid, name);
        newModel = newDifficulty.difficultyModel;
        this.guid = guid;
        this.name = name;
        
        newModel.displayName = Placeholders.DisplayName;
        newModel.description = Placeholders.Description;
        newModel.effectsMagnitude = "SeasonalEffectsMagnitude_4".ToLocaText();
        
        newModel.blightFootprintRate = float.MinValue;
        newModel.blightCorruptionRate = float.MinValue;
        newModel.rewardsMultiplier = float.MinValue;
        newModel.expMultiplier = float.MinValue;
        newModel.scoreMultiplier = float.MinValue;
        newModel.difficultyBudget = int.MinValue;
        newModel.positiveEffects = int.MinValue;
        newModel.negativeEffects = int.MinValue;
        newModel.minEffectCost = int.MinValue;
        newModel.maxEffectCost = int.MinValue;
        newModel.preparationPointsPenalty = int.MinValue;
        newModel.portRequirementsRatio = 1;
        newModel.maxWildcards = 1;
    }
    
    public void SetIcon(string iconImage)
    {
        SetIcon(TextureHelper.GetImageAsSprite(iconImage, TextureHelper.SpriteType.EffectIcon));
    }

    public void SetIcon(Texture2D texture2D)
    {
        SetIcon(texture2D.ConvertTexture(TextureHelper.SpriteType.EffectIcon));
    }
    
    public void SetIcon(Sprite sprite)
    {
        newModel.icon = sprite;
        TextMeshProManager.Add(newModel.icon.texture, newModel.name);
    }

    public DifficultyBuilder SetDisplayName(string text, SystemLanguage language = SystemLanguage.English)
    {
        string key = newModel.displayName.key;
        if (string.IsNullOrEmpty(key) || key == Placeholders.DisplayName.key)
        {
            // Create a new key for this field
            return SetDisplayName(LocalizationManager.ToLocaText(guid, name, "displayName", text, language));
        }
        else
        {
            // Replace current key
            LocalizationManager.AddString(key, text, language);
            return this;
        }
    }
    
    public DifficultyBuilder SetDisplayNameKey(string key)
    {
        return SetDisplayName(key.ToLocaText());
    }
    
    public DifficultyBuilder SetDisplayName(LocaText text)
    {
        newModel.displayName = text;
        return this;
    }

    public DifficultyBuilder SetDescription(string description, SystemLanguage language = SystemLanguage.English)
    {
        string key = newModel.description.key;
        if (string.IsNullOrEmpty(key) || key == Placeholders.Description.key)
        {
            // Create a new key for this field
            return SetDescriptionKey(LocalizationManager.ToLocaText(guid, name, "description", description, language));
        }
        else
        {
            // Replace current key
            LocalizationManager.AddString(key, description, language);
            return this;
        }
    }

    public DifficultyBuilder SetDescriptionKey(LocaText locaText)
    {
        newModel.description = locaText;
        return this;
    }

    public DifficultyBuilder SetDescriptionKey(string key)
    {
        return SetDescriptionKey(key.ToLocaText());
    }
    
    /// <summary>
    /// Sets the difficulty pickable when embarking and daily run.
    /// </summary>
    public DifficultyBuilder SetCanBePicked()
    {
        newDifficulty.difficultyModel.canBePicked = true;
        return this;
    }
    
    /// <summary>
    /// Sets the difficulty pickable when choosing difficulties for a custom game
    /// </summary>
    public DifficultyBuilder SetIsInCustomGame()
    {
        newDifficulty.difficultyModel.isInCustomGame = true;
        return this;
    }
    
    /// <summary>
    /// Sets the non-prestige level at which the difficulty is unlocked for embarking
    /// </summary>
    /// <argument name="index">The level at which the difficulty is unlocked. Note: Level is 0 based so for level 20 put 19.</argument>
    public DifficultyBuilder SetIndex(int index)
    {
        SetCanBePicked();
        newDifficulty.difficultyModel.index = index;
        return this;
    }
    
    public DifficultyBuilder SetPrestigeLevel(int level, bool copyModifiersFromPreviousPrestige=true)
    {
        SetCanBePicked();
        SetIndex(level + 3); //  Prestige 1 is index 4
        newModel.isAscension = true;
        newModel.ascensionIndex = level - 1;
        newModel.shortName = $"P{level}";
        newDifficulty.copyModifiersFromPreviousDifficulty = copyModifiersFromPreviousPrestige;
        if (newModel.displayName.key == Placeholders.DisplayName.key)
        {
            SetDisplayNameKey("Common_Ascension");
        }
        

        return this;
    }
    
    public DifficultyBuilder CopyModifiersFromPreviousDifficulties(bool copy = true)
    {
        newDifficulty.copyModifiersFromPreviousDifficulty = copy;
        return this;
    }

    public NewAscensionModifierModel AddModifier(EffectTypes effect, bool isShown = true, bool isEarlyEffect = false)
    {
        AscensionModifierModel modifier = ScriptableObject.CreateInstance<AscensionModifierModel>();
        modifier.name = newModel.name + "_Modifier_" + (newDifficulty.ascensionModifiers.Count + 1);
        modifier.isEarlyEffect = isEarlyEffect;
        modifier.isShown = isShown;
        
        NewAscensionModifierModel model = new NewAscensionModifierModel(modifier.name, modifier, effect);
        newDifficulty.ascensionModifiers.Add(model);
        return model;
    }
}