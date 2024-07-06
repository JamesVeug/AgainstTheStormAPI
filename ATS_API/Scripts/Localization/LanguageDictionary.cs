using System.Collections.Generic;

namespace ATS_API.Localization;

public class LanguageDictionary : Dictionary<string, string>
{
    public LanguageDictionary()
    {
        
    }
    
    public LanguageDictionary(Dictionary<string,string> dictionary)
    {
        foreach (KeyValuePair<string, string> pair in dictionary)
        {
            Add(pair.Key, pair.Value);
        }
    }
}