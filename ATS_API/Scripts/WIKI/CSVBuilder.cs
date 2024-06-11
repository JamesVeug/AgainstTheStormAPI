using System.Collections.Generic;
using System.Linq;

public class CSVBuilder
{
    public struct Header
    {
        public string Name;
        public int Order;
    }

    private List<Dictionary<string, string>> values = new List<Dictionary<string, string>>();
    
    public List<Header> orderedHeaders = new List<Header>();
    
    
    public Dictionary<string, string> currentRow = new Dictionary<string, string>();
    public int columnIndex = 0;
    
    
    public CSVBuilder()
    {
        
    }

    public void AddValue(string header, string value, int order)
    {
        Header expectedHeader = columnIndex < orderedHeaders.Count ? orderedHeaders[columnIndex] : new Header();
        if (expectedHeader.Name != header)
        {
            int indexOf = orderedHeaders.FindIndex(a=>a.Name == header);
            if (indexOf == -1)
            {
                // We are missing this column because a previous iteration did not add it!
                Header header1 = new Header();
                header1.Name = header;
                header1.Order = order;
                
                // Insert this header in the correct order
                int i = 0;
                for (; i < orderedHeaders.Count; i++)
                {
                    if (orderedHeaders[i].Order > order)
                    {
                        break;
                    }
                }
                orderedHeaders.Insert(i, header1);
                columnIndex = i;
            }
            else
            {
                // We have skipped columns
                columnIndex = indexOf;
            }
        }
        
        currentRow[header] = value;
        columnIndex++;
    }

    public void NextRow()
    {
        values.Add(currentRow);
        currentRow = new Dictionary<string, string>();
        columnIndex = 0;
    }
    
    public void SaveAsCSV(string path)
    {
        if (currentRow.Count > 0)
        {
            NextRow();
        }

        using (System.IO.StreamWriter file = new System.IO.StreamWriter(path))
        {
            file.WriteLine(string.Join(",", orderedHeaders.Select(a=>a.Name)));
            
            for (int i = 0; i < values.Count; i++)
            {
                Dictionary<string,string> dictionary = values[i];

                string row = "";
                for (var j = 0; j < orderedHeaders.Count; j++)
                {
                    var header = orderedHeaders[j];
                    if (!dictionary.TryGetValue(header.Name, out string value))
                    {
                        value = "";
                    }

                    if (value.IndexOf(",") >= 0)
                    {
                        value = "\"" + value + "\"";
                    }

                    if (j > 0)
                    {
                        row += ",";
                    }
                    row += value;
                }

                file.WriteLine(row);
            }
        }
    }
}