using System.Text.RegularExpressions;

namespace CpoDesign_nugets.TextManipulation
{
    public class TextManupulation
    {
        public static string RemoveTextInBracketsForText(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                return text;
            }

            string regex = "(\".*\")|('.*')|(\\(.*\\))";
            string output = Regex.Replace(text, regex, string.Empty);
            return output;
        }
    }
}
