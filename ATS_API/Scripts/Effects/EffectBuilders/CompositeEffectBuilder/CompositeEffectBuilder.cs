using Eremite.Model.Effects;
using Eremite.Model;
using System.Collections.Generic;
using System.Linq;
using ATS_API.Helpers;
using System;

namespace ATS_API.Effects;

/// <summary>
/// This will build <see cref="CompositeEffectModel"/>.
/// A <see cref="CompositeEffectModel"/> can contain multiple effects.
/// When players acquire the composite effect, they will receive all the individual effects contained within it.
/// </summary>
public class CompositeEffectBuilder : EffectBuilder<CompositeEffectModel>
{
    /// <summary>
    /// Create with the basic information
    /// </summary>
    /// <param name="guid">Mod guid</param>
    /// <param name="name">Effect program name</param>
    /// <param name="iconPath">icon path</param>
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
    /// Sets the description arguments for the text effect.
    /// The composite effect description comprises of text and amount information from its sub-effects. 
    /// The <see cref="TextArgType"/> parameter specifies the source of the text from the sub-effect,
    /// and the <see cref="int"/> parameter indicates the index of the source sub-effect.
    /// Each tuple <c>(TextArgType type, int sourceIndex)</c> will assign the i-th text placeholder <c>{}</c>
    /// to the corresponding value of <c>effects[sourceIndex]</c>, based on the specified text source defined by <see cref="TextArgType"/>.
    /// </summary>
    /// <param name="args">The arguments defining the text source and effect index mappings.</param>
    public void SetDescriptionArgs(params (TextArgType type, int sourceIndex)[] args)
    {
        m_effectModel.formatDescription = true;
        m_effectModel.dynamicDescriptionArgs = args.ToTextArgArray();
    }

    /// <summary>
    /// Set description args.
    /// </summary>
    /// <param name="args"></param>
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

    /// <summary>
    /// Specifies which sub-effect's preview action to be used for the composite effect preview action.
    /// This is not a text preview. But it usually used for the visual preview of a range in the scene.
    /// </summary>
    /// <param name="index">
    /// index of sub-effect
    /// </param>
    public void SetNestedPreviewActionIndex(int index)
    {
        m_effectModel.hasNestedPreview = true;
        m_effectModel.nestedPreviewIndex = index;
    }

    /// <summary>
    /// Specifies which sub-effect's retroactive preview to be used for the composite effect retroactive preview.
    /// This text usually shows up as a suffix of the description text when it presents as an option in the cornerstone reward.
    /// </summary>
    /// <param name="index">
    /// index of sub-effect
    /// </param>
    public void SetNestedRetroactiveIndex(int index)
    {
        m_effectModel.hasNestedRetroactivePreview = true;
        m_effectModel.nestedRetroactivePreviewEffectIndex = index;
    }

    /// <summary>
    /// Specifies which sub-effect's preview texts to be used for the composite effect preview texts.
    /// This text usually shows up when the player hover on the effect icon.
    /// It will show as a tooltip below the effect description.
    /// </summary>
    /// <param name="index">
    /// index of sub-effect
    /// </param>
    public void SetNestedPreviewIndex(int index)
    {
        m_effectModel.hasNestedStatePreview = true;
        m_effectModel.nestedStatePreviewEffectIndex = index;
    }

    /// <summary>
    /// Specifies which sub-effect's amount to be used for the composite effect amount.
    /// This impacts the result of <see cref="EffectModel.GetAmountText"/>
    /// It may also provide an additional visual text on the icon, like +5% or +1.
    /// Note:
    /// it will automatically ignore the text setted in <see cref="SetAmountText"/>
    /// They are conflicted, only one of the method can be chosen for the amount text
    /// </summary>
    /// <param name="index">
    /// index of sub-effect
    /// </param>
    public void SetNestedAmountIndex(int index)
    {
        m_effectModel.hasNestedAmount = true;
        m_effectModel.nestedAmountEffectIndex = index;
    }

    /// <summary>
    /// Assign a fixed text amount to the effect.
    /// When you use this function, it will disable nested amount.
    /// It is conflict with <see cref="SetNestedAmountIndex"/>, 
    /// only one of the method can be chosen for the amount text.
    /// This impacts the result of <see cref="EffectModel.GetAmountText"/>
    /// It may also provide an additional visual text on the icon, like +5% or +1.
    /// </summary>
    /// <param name="text">
    /// </param>
    public void SetAmountText(string text)
    {
        m_effectModel.hasNestedAmount = false;
        m_effectModel.amountText = text;
    }

    /// <summary>
    /// Specifies which sub-effect's int amount to be used for the composite effect int amount.
    /// This impacts the result of <see cref="EffectModel.GetIntAmount"/>
    /// This might be useful for some formatted texts.
    /// </summary>
    /// <param name="index">
    /// index of sub-effect
    /// </param>
    public void SetNestedIntAmountIndex(int index)
    {
        m_effectModel.hasNestedIntAmount = true;
        m_effectModel.nestedIntAmountEffectIndex = index;
    }

    /// <summary>
    /// Specifies which sub-effect's float amount to be used for the composite effect float amount.
    /// This impacts the result of <see cref="EffectModel.GetFloatAmount"/>
    /// This might be useful for some formatted texts.
    /// </summary>
    /// <param name="index">
    /// index of sub-effect
    /// </param>
    public void SetNestedFloatAmountIndex(int index)
    {
        m_effectModel.hasNestedFloatAmount = true;
        m_effectModel.nestedFloatAmountEffectIndex = index;
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