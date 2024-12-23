using System.Collections.Generic;
using System.IO;
using System.Text;

/// <summary>
/// Given data this will export a .md file in the format of a table with the file name and the number of lines in the file.
/// </summary>
public class MDFileTableBuilder
{
    private string fullPath;
    private List<string[]> data = new List<string[]>();
    private List<string> keys = new List<string>();
    
    public MDFileTableBuilder(string fullPath, List<string> keys)
    {
        this.fullPath = fullPath;
        this.keys = keys;
    }
    
    public void AddData(params string[] data)
    {
        if(data.Length != keys.Count)
        {
            throw new System.Exception("Data length does not match keys length");
        }
        
        this.data.Add(data);
    }
    
    
    /// <summary>
    /// Builds a table of the files in the given directory.
    /// </summary>
    /// <returns>A string representing the table of files.</returns>
    public void ExportAsFile()
    {
        StringBuilder sb = new StringBuilder();

        // Header
        foreach (string key in keys)
        {
            sb.Append("| ").Append(key).Append(" ");
        }
        sb.Append("|\n");
        
        // Alignment
        foreach (string key in keys)
        {
            sb.Append("| --- ");
        }
        sb.Append("|\n");

        // Data
        foreach (string[] data in data)
        {
            foreach (string d in data)
            {
                sb.Append("| ").Append(d).Append(" ");
            }
            sb.Append("|\n");
        }

        // check if directory exists
        if (!Directory.Exists(Path.GetDirectoryName(fullPath)))
        {
            Directory.CreateDirectory(Path.GetDirectoryName(fullPath));
        }
        File.WriteAllText(fullPath, sb.ToString());
    }
}