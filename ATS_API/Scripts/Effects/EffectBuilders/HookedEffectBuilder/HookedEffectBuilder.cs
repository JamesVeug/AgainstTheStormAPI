﻿using Eremite.Model;
using Eremite.Model.Effects;

namespace ATS_API.Effects;

/// <summary>
/// Creates a new hooked effect.
/// Hooked effects can buff/debuff the player as soon as its acquired or after a hook has completed its conditions
/// HookedEffects can also be removed from the player if a RemovalHook has completed its conditions 
/// </summary>
public partial class HookedEffectBuilder : EffectBuilder<HookedEffectModel>
{
    public HookedEffectBuilder(string guid, string name, string iconPath) : base(guid,name,iconPath)
    {
        m_effectModel.instantEffects = [];
        m_effectModel.hookedEffects = [];
        m_effectModel.hooks = [];
    }

    /// <summary>
    /// If you have an hooked effect which grants another hooked effect, and you want that second hooked effect to show up on the HUD, set this to true
    /// </summary>
    public void SetShowHookedRewardsAsPerks(bool showHookedRewardsAsPerks = true)
    {
        m_effectModel.showHookedRewardsAsPerks = showHookedRewardsAsPerks;
    }

    private void AssignMissingFieldsToEffect(EffectModel effect)
    {
        if (effect.description == null || effect.description.key == Placeholders.DescriptionKey)
        {
            effect.description = m_effectModel.description;
            effect.formatDescription = m_effectModel.formatDescription;
        }
        if (effect.displayName == null || effect.displayName.key == Placeholders.DisplayNameKey)
        {
            effect.displayName = m_effectModel.displayName;
        }
        if (effect.label == null || effect.label.displayName.key == Placeholders.DisplayNameKey)
        {
            effect.label = m_effectModel.label;
        }
        if (effect.GetIcon() == null)
        {
            effect.overrideIcon = m_effectModel.GetIcon();
        }
        if (effect.blockedBy == null)
        {
            effect.blockedBy = m_effectModel.blockedBy;
        }
    }
}