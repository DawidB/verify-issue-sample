using System.Text.Json;

namespace TestProject1;

public static class StringExtensions
{
    public static string TryExtractJson(this string input)
    {
        const string jsonStart = "```json";
        const string jsonEnd = "```";
        
        int jsonStartIndex = input.IndexOf(jsonStart, StringComparison.OrdinalIgnoreCase);
        int startIndex = jsonStartIndex == -1 ? 0 : jsonStartIndex + jsonStart.Length; 
        int jsonEndIndex = input.LastIndexOf(jsonEnd, StringComparison.OrdinalIgnoreCase);
        int endIndex = jsonEndIndex == -1 ? input.Length : jsonEndIndex; 
        int endingLength = input.Length - endIndex;
        int finalLength = input.Length - startIndex - endingLength;
        return input.Substring(startIndex, finalLength).Trim();
    }
    
    public static string[] ToArray(this string input) => JsonSerializer.Deserialize<string[]>(input)!;
}