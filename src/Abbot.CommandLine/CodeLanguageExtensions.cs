using Serious.Abbot.Entities;

namespace Serious.Abbot.CommandLine
{
    public static class CodeLanguageExtensions
    {
        public static string GetFileExtension(this CodeLanguage language)
        {
            return language switch
            {
                CodeLanguage.Python => "py",
                CodeLanguage.CSharp => "cs",
                CodeLanguage.JavaScript => "js",
                _ => "txt"
            };
        }
    }
}