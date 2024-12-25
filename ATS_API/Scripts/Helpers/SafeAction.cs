using System;
using System.Collections.Generic;
using ATS_API;
using Cysharp.Threading.Tasks;

namespace ATS_API.Helpers;

public class SafeAction
{
    private List<Action> _actions = new List<Action>();
    
    public void AddListener(Action action)
    {
        _actions.Add(action);
    }
    
    public void RemoveListener(Action action)
    {
        _actions.Remove(action);
    }
    
    public void Invoke()
    {
        foreach (Action action in _actions)
        {
            try
            {
                action.Invoke();
            }
            catch (Exception e)
            {
                APILogger.LogError(e + "\n" + Environment.StackTrace);
            }
        }
    }
}

public class SafeAction<T>
{
    private List<Action<T>> _actions = new List<Action<T>>();
    
    public void AddListener(Action<T> action)
    {
        _actions.Add(action);
    }
    
    public void RemoveListener(Action<T> action)
    {
        _actions.Remove(action);
    }
    
    public void Invoke(T t)
    {
        foreach (Action<T> action in _actions)
        {
            try
            {
                action.Invoke(t);
            }
            catch (Exception e)
            {
                APILogger.LogError(e + "\n" + Environment.StackTrace);
            }
        }
    }
    
    public async UniTask<bool> Invoke(T t, Func<Exception, UniTask<bool>> OnException)
    {
        foreach (Action<T> action in _actions)
        {
            try
            {
                action.Invoke(t);
            }
            catch (Exception e)
            {
                APILogger.LogError(e + "\n" + Environment.StackTrace);
                bool uniTask = await OnException.Invoke(e);
                if (!uniTask)
                {
                    return false;
                }
            }
        }

        return true;
    }
}

public class SafeAction<T,Y>
{
    private List<Action<T,Y>> _actions = new List<Action<T, Y>>();
    
    public void AddListener(Action<T,Y> action)
    {
        _actions.Add(action);
    }
    
    public void RemoveListener(Action<T,Y> action)
    {
        _actions.Remove(action);
    }
    
    public void Invoke(T t, Y y)
    {
        foreach (Action<T,Y> action in _actions)
        {
            try
            {
                action.Invoke(t,y);
            }
            catch (Exception e)
            {
                APILogger.LogError(e + "\n" + Environment.StackTrace);
            }
        }
    }
    
    public async UniTask<bool> Invoke(T t, Y y, Func<Exception, UniTask<bool>> OnException)
    {
        foreach (Action<T,Y> action in _actions)
        {
            try
            {
                action.Invoke(t,y);
            }
            catch (Exception e)
            {
                APILogger.LogError(e + "\n" + Environment.StackTrace);
                bool uniTask = await OnException.Invoke(e);
                if (!uniTask)
                {
                    return false;
                }
            }
        }

        return true;
    }
}