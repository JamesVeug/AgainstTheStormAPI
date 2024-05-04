using Eremite.Model;

namespace ATS_API.Effects;

public interface IEffectBuilder
{
    public EffectModel Model { get; }
    public string GUID { get; }
    public string Name { get; }
}