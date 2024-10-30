using ATS_API.Helpers;
using Eremite.Model;

namespace ATS_API.Effects;

public class NewResolveEffectData : ASyncable<ResolveEffectModel>
{
    public ResolveEffectTypes ID;
    public ResolveEffectModel Model;
}