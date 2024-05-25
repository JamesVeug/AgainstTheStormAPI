using System;

namespace ATS_API.Helpers;

public static class Extensions
{
    /// <summary>
    /// Strips out all the bad characters that enums use to make a string into a valid enum string
    /// </summary>
    public static string ToEnumString(this string name, bool stripNumbersFromBeginning=false)
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
            // .Replace("-","_")
            .Replace("&","And")
            .Replace("+","Plus")
            .Replace("(","")
            .Replace(")","_")
            .Replace("[","")
            .Replace("]","")
            .Replace("'","");

        // Change - to Minus if there is a number to the right of it otherwise replace with _
        i = id.IndexOf("-");
        while (i != -1)
        {
            if (i + 1 < id.Length && char.IsDigit(id[i + 1]))
            {
                id = id.Substring(0, i) + "Minus" + id.Substring(i + 1);
            }
            else
            {
                id = id.Substring(0, i) + "_" + id.Substring(i + 1);
            }
            i = id.IndexOf("-", i + 1);
        }
        

        // Replace digits at the start with the actual words
        if (stripNumbersFromBeginning)
        {
            while (id.Length > 0 && (char.IsDigit(id[0]) || id[0] == '_'))
            {
                id = id.Substring(1);
            }
        }
        else
        {
            if (id.Length > 0 && char.IsDigit(id[0]))
            {
                id = "_" + id;
            }
        }

        // Remove repeated _
        while (id.Contains("__"))
        {
            id = id.Replace("__", "_");
        }
        
        // Remove _ at the end
        if (id.Length > 0 && id[id.Length - 1] == '_')
        {
            id = id.Substring(0, id.Length - 1);
        }


        return id;
    }
}