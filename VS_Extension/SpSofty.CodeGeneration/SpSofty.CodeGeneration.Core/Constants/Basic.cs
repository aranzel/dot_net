namespace SpSofty.CodeGeneration.Core.Constants
{
    internal static class Basic
    {
        public static string NAMESPACE_EMPYT = "[Namespace Empyt]";
        public static string REGEX_NAMESTACE = @"namespace\s+([\w.]*)";
        public static string TOKEN_CLASS_NAME = "{CLASS_NAME}";
        public static string EREGEX_CLASS_NAME = @"(interface|class|public|protected|internal|private|new) ("
                + TOKEN_CLASS_NAME + @")|[<,]{1}(" + TOKEN_CLASS_NAME + ")[,>]{1}";
    }
}
