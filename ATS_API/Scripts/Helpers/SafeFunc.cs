using System;
using System.Collections.Generic;
using ATS_API;
using Cysharp.Threading.Tasks;

namespace ATS_API.Helpers;

public class SafeFunc<ArgType,ReturnType>
{
    private List<Func<ArgType,ReturnType>> _funcs = new List<Func<ArgType, ReturnType>>();
    
    public void AddListener(Func<ArgType,ReturnType> func)
    {
        _funcs.Add(func);
    }
    
    public void RemoveListener(Func<ArgType,ReturnType> func)
    {
        _funcs.Remove(func);
    }
    
    public ReturnType Invoke(ArgType t)
    {
        foreach (Func<ArgType,ReturnType> func in _funcs)
        {
            try
            {
                return func.Invoke(t);
            }
            catch (Exception e)
            {
                APILogger.LogError(e + "\n" + Environment.StackTrace);
            }
        }

        return default;
    }
    
    public async UniTask<ReturnType> Invoke(ArgType t, Func<Exception, UniTask<ReturnType>> OnException)
    {
        foreach (Func<ArgType,ReturnType> func in _funcs)
        {
            try
            {
                return func.Invoke(t);
            }
            catch (Exception e)
            {
                APILogger.LogError(e + "\n" + Environment.StackTrace);
                return await OnException.Invoke(e);
            }
        }

        return default;
    }
}