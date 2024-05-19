using Eremite.Model.Effects;
using Eremite.Model.Effects.Hooked;
using TextArgType = Eremite.Model.Effects.Hooked.TextArgType;

namespace ATS_API.Helpers;

public static class EffectHookedTextArg_Extensions
{
    public static HookedTextArg[] ToHookedTextArgArray(this (SourceType source, TextArgType type, int sourceIndex)[] args)
    {
        HookedTextArg[] hookedTextArgs = new HookedTextArg[args.Length];
        for (int i = 0; i < args.Length; i++)
        {
            hookedTextArgs[i] = new HookedTextArg()
            {
                source = args[i].source,
                sourceIndex = args[i].sourceIndex,
                type = args[i].type,
            };
        }

        return hookedTextArgs;
    }
    
    public static HookedTextArg ToHookedTextArg(this (SourceType source, TextArgType type, int sourceIndex) arg)
    {
        return new HookedTextArg()
        {
            source = arg.source,
            sourceIndex = arg.sourceIndex,
            type = arg.type,
        };
    }
    
    public static HookedStateTextArg[] ToHookedStateTextArgArray(this (HookedStateTextArg.HookedStateTextSource source, int sourceIndex)[] args)
    {
        HookedStateTextArg[] hookedStateTextArgs = new HookedStateTextArg[args.Length];
        for (int i = 0; i < args.Length; i++)
        {
            hookedStateTextArgs[i] = new HookedStateTextArg()
            {
                source = args[i].source,
                sourceIndex = args[i].sourceIndex,
            };
        }

        return hookedStateTextArgs;
    }
    
    public static HookedStateTextArg ToHookedStateTextArg(this (HookedStateTextArg.HookedStateTextSource source, int sourceIndex) arg)
    {
        return new HookedStateTextArg()
        {
            source = arg.source,
            sourceIndex = arg.sourceIndex,
        };
    }
}