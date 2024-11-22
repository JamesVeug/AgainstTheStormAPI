using System;
using System.Globalization;
using System.Text;

namespace ATS_API.Helpers;

public static class StringExtensions
{
    public static string ToLiteral(this char c)
    {
        StringBuilder literal = new StringBuilder(3);
        literal.Append("\"");
        switch (c)
        {
            case '\'': literal.Append(@"\'"); break;
            case '\"': literal.Append("\\\""); break;
            case '\\': literal.Append(@"\\"); break;
            case '\0': literal.Append(@"\0"); break;
            case '\a': literal.Append(@"\a"); break;
            case '\b': literal.Append(@"\b"); break;
            case '\f': literal.Append(@"\f"); break;
            case '\n': literal.Append(@"\n"); break;
            case '\r': literal.Append(@"\r"); break;
            case '\t': literal.Append(@"\t"); break;
            case '\v': literal.Append(@"\v"); break;
            default:
                if (Char.GetUnicodeCategory(c) != UnicodeCategory.Control)
                {
                    literal.Append(c);
                }
                else
                {
                    literal.Append(@"\u");
                    literal.Append(((ushort)c).ToString("x4"));
                }
                break;
        };
        return literal.ToString();
    }
    
    public static string ToLiteral(this string input)
    {
        StringBuilder literal = new StringBuilder(input.Length + 2);
        literal.Append("\"");
        foreach (char c in input)
        {
            switch (c)
            {
                case '\'': literal.Append(@"\'"); break;
                case '\"': literal.Append("\\\""); break;
                case '\\': literal.Append(@"\\"); break;
                case '\0': literal.Append(@"\0"); break;
                case '\a': literal.Append(@"\a"); break;
                case '\b': literal.Append(@"\b"); break;
                case '\f': literal.Append(@"\f"); break;
                case '\n': literal.Append(@"\n"); break;
                case '\r': literal.Append(@"\r"); break;
                case '\t': literal.Append(@"\t"); break;
                case '\v': literal.Append(@"\v"); break;
                default:
                    if (Char.GetUnicodeCategory(c) != UnicodeCategory.Control)
                    {
                        literal.Append(c);
                    }
                    else
                    {
                        literal.Append(@"\u");
                        literal.Append(((ushort)c).ToString("x4"));
                    }
                    break;
            }
        }
        literal.Append("\"");
        return literal.ToString();
    }
}