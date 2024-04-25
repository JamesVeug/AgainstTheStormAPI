using System;
using System.Collections.Generic;

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

    public static void AddElement<T>(ref T[] array, T element)
    {
        int startingIndex = array.Length;
        Array.Resize(ref array, startingIndex + 1);
        array[startingIndex] = element;
    }
}