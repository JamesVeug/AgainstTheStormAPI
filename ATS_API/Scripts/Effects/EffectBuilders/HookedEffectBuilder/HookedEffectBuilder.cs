using Eremite.Model.Effects;

namespace ATS_API.Effects;

/// <summary>
/// Creates a new hooked effect.
/// Hooked effects can buff/debuff the player as soon as its acquired or after a hook has completed its conditions
/// HookedEffects can also be removed from the player if a RemovalHook has completed its conditions 
/// </summary>
public partial class HookedEffectBuilder : EffectBuilder<HookedEffectModel>
{
    public string Name => m_effectModel.name;
    
    public HookedEffectBuilder(string guid, string name, string iconPath) : base(guid,name,iconPath)
    {
        m_effectModel.instantEffects = [];
        m_effectModel.hookedEffects = [];
    }
}