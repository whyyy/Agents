namespace Agents.Infrastructure.Extensions
{
    public static class StringExtensions
    {
        public static string RemoveFormatting(this string text)
        {
            return text.Replace($"\r", "")
                .Replace($"\n", "")
                .Replace($"\t","");
        }
    }
}