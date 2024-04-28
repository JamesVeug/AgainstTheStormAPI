using System;
using System.Collections.Generic;
using UnityEngine.Pool;

namespace ATS_API.Helpers;

public static class ArrayExtensions
{
    public static void AddElements<T>(ref T[] array, T[] elements)
    {
        int startingIndex = array.Length;
        Array.Resize(ref array, startingIndex + elements.Length);
        for (int i = 0; i < elements.Length; i++)
        {
            array[startingIndex + i] = elements[i];
        }
    }
    
    public static void AddElements<T>(ref T[] array, List<T> elements)
    {
        int startingIndex = array.Length;
        Array.Resize(ref array, startingIndex + elements.Count);
        for (int i = 0; i < elements.Count; i++)
        {
            array[startingIndex + i] = elements[i];
        }
    }
    
    public static void AddElements<T>(ref T[] array, IEnumerable<T> elements)
    {
        List<T> list1 = ListPool<T>.Get();
        list1.AddRange(elements);
        AddElements(ref array, list1);
        ListPool<T>.Release(list1);
    }

    public static void AddElement<T>(ref T[] array, T element)
    {
        int startingIndex = array.Length;
        Array.Resize(ref array, startingIndex + 1);
        array[startingIndex] = element;
    }
}