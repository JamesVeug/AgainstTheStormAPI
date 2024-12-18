using Eremite.Model.Effects;
using Eremite.Model;
using System.Collections.Generic;
using System.Linq;
using ATS_API.Helpers;

namespace ATS_API.Effects;

/// <summary>
/// This will build <see cref="CompositeEffectModel"/>.
/// <see cref="CompositeEffectModel"/> can hold multiple effects.
/// When players obtain the composite effect, they will obtain all effects in the composite effect.
/// </summary>
public class CompositeEffectBuilder : EffectBuilder<CompositeEffectModel>
{

    public CompositeEffectBuilder(string guid, string name, string iconPath) : base(guid, name, iconPath)
    {
        m_effectModel.anyNestedToFit = false;
        m_effectModel.rewards = [];
    }

    /// <summary>
    /// Add an effect to the composite effect
    /// </summary>
    /// <param name="effect"></param>
    public void AddEffect(EffectModel effect)
    {
        m_effectModel.rewards.ForceAdd(effect);
    }

    /// <summary>
    /// Add a series of effects to the composite effect
    /// </summary>
    /// <param name="effects"></param>
    public void AddEffects(IEnumerable<EffectModel> effects)
    {
        List<EffectModel> effectList = m_effectModel.rewards.ToList();
        effectList.AddRange(effects.ToList());
        m_effectModel.rewards = effectList.ToArray();
    }

    /// <summary>
    /// Remove current effects, and set with a new effect
    /// </summary>
    /// <param name="effect"></param>
    public void SetEffect(EffectModel effect)
    {
        m_effectModel.rewards = [effect];
    }

    /// <summary>
    /// Remove current effects, and set with new effects
    /// </summary>
    /// <param name="effects"></param>
    public void SetEffects(IEnumerable<EffectModel> effects)
    {
        m_effectModel.rewards = effects.ToArray();
    }

    /// <summary>
    /// Clean all effects in the composite effect
    /// </summary>
    public void ClearEffects()
    {
        m_effectModel.rewards = [];
    }

    /// <summary>
    /// Set description args.
    /// `TextArgType type` indicates the text source.
    /// `int sourceIndex` indicates the index of source effect.
    /// Each `(TextArgType type, int sourceIndex)` means
    /// the {i_th} text is assigned with Effects[sourceIndex]'s corresponding value.
    /// </summary>
    /// <param name="args"></param>
    public void SetDescriptionArgs(params (TextArgType type, int sourceIndex)[] args)
    {
        if (args == null)
        {
            m_effectModel.formatDescription = false;
            return;
        }
        m_effectModel.formatDescription = true;
        m_effectModel.dynamicDescriptionArgs = args.ToTextArgArray();
    }

    public void SetDescriptionArgs(TextArg[] args)
    {
        m_effectModel.formatDescription = args != null;
        m_effectModel.dynamicDescriptionArgs = args;
    }

    /// <summary>
    /// Normally the composite effect fits only if 
    /// all nested effects fits as well. Use this 
    /// option to change it so if only one of the 
    /// nested effects fits - this effect can be drawn.
    /// </summary>
    /// <param name="value"></param>
    public void SetAnyNestedToFit(bool value)
    {
        m_effectModel.anyNestedToFit = value;
    }

    public void SetNestedPreviewActionIndex(int index)
    {
        if (index < 0)
        {
            m_effectModel.hasNestedPreview = false;
        }
        else
        {
            m_effectModel.hasNestedPreview = true;
            m_effectModel.nestedPreviewIndex = index;
        }
    }

    /// <summary>
    /// This indicates which effect we should use for the composite effect retroactive preview.
    /// If you do not want to provide a retroactive nested preview,
    /// pass a negative index to disable the preview like this: 
    /// `SetNestedRetroactivePreviewIndex(-1);`
    /// </summary>
    /// <param name="index">
    /// if the index is negative, it indicates the 
    /// composite effect do not use retroactive preview. 
    /// Otherwise the index indicates we use which sub-effect
    /// as the composite effect retroactive preview </param>
    public void SetNestedRetroactivePreviewIndex(int index)
    {
        if (index < 0)
        {
            m_effectModel.hasNestedRetroactivePreview = false;
        }
        else
        {
            m_effectModel.hasNestedRetroactivePreview = true;
            m_effectModel.nestedRetroactivePreviewEffectIndex = index;
        }
    }

    public void SetNestedPreviewIndex(int index)
    {
        if (index < 0)
        {
            m_effectModel.hasNestedStatePreview = false;
        }
        else
        {
            m_effectModel.hasNestedStatePreview = true;
            m_effectModel.nestedStatePreviewEffectIndex = index;
        }
    }

    public void SetNestedAmountIndex(int index)
    {
        if (index < 0)
        {
            m_effectModel.hasNestedAmount = false;
        }
        else
        {
            m_effectModel.hasNestedAmount = true;
            m_effectModel.nestedAmountEffectIndex = index;
        }
    }

    public void SetNestedIntAmountIndex(int index)
    {
        if (index < 0)
        {
            m_effectModel.hasNestedIntAmount = false;
        }
        else
        {
            m_effectModel.hasNestedIntAmount = true;
            m_effectModel.nestedIntAmountEffectIndex = index;
        }
    }

    public void SetNestedFloatAmountIndex(int index)
    {
        if (index < 0)
        {
            m_effectModel.hasNestedFloatAmount = false;
        }
        else
        {
            m_effectModel.hasNestedFloatAmount = true;
            m_effectModel.nestedFloatAmountEffectIndex = index;
        }
    }

    /// <summary>
    /// When this is set to true, all your sub effects will show in the game.
    /// </summary>
    /// <param name="value"></param>
    public void SetShowEffectAsPerks(bool value)
    {
        m_effectModel.showEffectsAsPerks = value;
    }

    /// <summary>
    /// Indicate this effect comes from previous of the settlement game or not.
    /// </summary>
    /// <param name="value"></param>
    public void SetForceAsPreGameModifier(bool value)
    {
        m_effectModel.forceAsPreGameModifier = value;
    }
}