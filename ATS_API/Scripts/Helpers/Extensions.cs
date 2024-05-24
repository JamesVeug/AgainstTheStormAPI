using System;

namespace ATS_API.Helpers;

public static class Extensions
{
    /// <summary>
    /// Strips out all the bad characters that enums use to make a string into a valid enum string
    /// </summary>
    public static string ToEnumString(this string name)
    {
        string id = name;
        // replace every letter after a space with an upper case

        int i = id.IndexOf(" ");
        while (i != -1)
        {
            id = id.Substring(0, i) + "_" + id[i + 1].ToString().ToUpper() + id.Substring(i + 2);
            i = id.IndexOf(" ", i + 1);
        }
            
            
        id = id.Replace(" ", "_")
            .Replace("-","_")
            .Replace("&","And")
            .Replace("+","Plus")
            .Replace("(","")
            .Replace(")","_")
            .Replace("[","")
            .Replace("]","")
            .Replace("'","");


        // Replace digits at the start with the actual words
        if(id.Length > 0 && char.IsDigit(id[0]))
        {
            id = "_" + id;
        }

        return id;
    }
}