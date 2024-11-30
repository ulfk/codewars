using System;
using System.Collections.Generic;
using System.Linq;

namespace Codewars;

// https://www.codewars.com/kata/563fbac924106b8bf7000046/csharp
public class BreadcrumbGenerator
{
    public static string GenerateBC(string url, string separator)
    {
        var uri = new Uri(ToValidUrl(url));
        var parts = uri.Segments.Select(x => x.Replace("/","")).ToArray();
        
        var lastPart = parts.Last();
        lastPart = RemoveParts(lastPart, [".html",".htm",".php",".asp"]);
        if (lastPart == "index")
        {
            parts = parts.Take(parts.Length - 1).ToArray();
        }
        else
        {
            parts[^1] = lastPart;
        }

        if (parts.Length == 1) return GetSpan("HOME");
        
        var bcParts = new List<string> { GetLink("/", "HOME") };
        var link = "/";
        for (var idx = 1; idx < parts.Length - 1; idx++)
        {
            link += parts[idx] + "/";
            bcParts.Add(GetLink(link, parts[idx]));
        }
        bcParts.Add(GetSpan(parts.Last()));
        return string.Join(separator, bcParts);
    }
    
    private static string ToValidUrl(string url) =>  !url.StartsWith("http") ? $"https://{url}" : url;

    private static string RemoveParts(string text, string[] removeParts)
    {
        return removeParts.Aggregate(text, (current, removal) => current.Replace(removal, ""));
    }

    private static string GetLink(string path, string text) => $"<a href=\"{path}\">{ToOutputText(text)}</a>";
    
    private static string GetSpan(string text) => $"<span class=\"active\">{ToOutputText(text)}</span>";

    private static string ToOutputText(string text)
    {
        var result = text.Replace('-',' ');
        if (text.Length > 30)
        {
            var parts = text.Split('-');
            result = new string(parts.Where(w => !ReservedWords.Contains(w)).Select(x => x[0]).ToArray());
        }
        return result.ToUpper();
    }

    private static readonly string[] ReservedWords = 
        [ "the", "of", "in", "from", "by", "with", "and", "or", "for", "to", "at", "a" ];
}