using ATS_API.Effects;
using Eremite.Model;

public class ResolveEffectBuilder : AResolveEffectBuilder<ResolveEffectModel>
{
    public ResolveEffectBuilder(string guid, string name, string iconPath) : base(guid, name, iconPath)
    {
    }
}