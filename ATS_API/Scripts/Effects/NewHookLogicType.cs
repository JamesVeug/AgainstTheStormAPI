using System;
using Eremite.Controller.Effects;
using Eremite.Model.Effects;

namespace ATS_API.Effects;

public class NewHookLogicType : ASyncable<HookLogic>
{
    public HookLogicType ID;
    public Type HookLogicType;
    public IHookMonitor Monitor;
}