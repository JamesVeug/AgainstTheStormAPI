public static class Extensions
{
    /// <summary>
    /// Strips out all the bad characters that enums use to make a string into a valid enum string
    /// </summary>
    /// <param name="name"></param>
    /// <returns></returns>
    public static string ToEnumString(this string name)
    {
        string id = name;
        // replace every letter after a space with an upper case

        int i = id.IndexOf(" ");
        while (i != -1)
        {
            id = id.Substring(0, i) + id[i + 1].ToString().ToUpper() + id.Substring(i + 2);
            i = id.IndexOf(" ", i + 1);
        }
            
            
        id = id.Replace(" ", "_")
            .Replace("'","")
            .Replace("(","")
            .Replace(")", "");

        return id;
    }
}