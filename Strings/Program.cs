using static Strings.Classes;

namespace Strings
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Score of a string
            //Console.WriteLine(ScoreOfStringLC3110.ScoreOfString("hello"));
            //Console.WriteLine(ScoreOfStringLC3110.ScoreOfString("zaz"));

            // Is Subsequence
            //Console.WriteLine(IsSubSequenceLC392.IsSubsequence("abc", "ahbgdc"));
            //Console.WriteLine(IsSubSequenceLC392.IsSubsequence("axc", "ahbgdc"));

            // Append Characters To String
            //Console.WriteLine(AppendCharactersToStringLC2486.AppendCharacters("coaching", "coding"));
            //Console.WriteLine(AppendCharactersToStringLC2486.AppendCharacters("abcde", "a"));
            //Console.WriteLine(AppendCharactersToStringLC2486.AppendCharacters("z","abcde"));

            // Length of Last Word
            //Console.WriteLine(LengthOfLastWordLC58.LengthOfLastWord("Hello World"));
            //Console.WriteLine(LengthOfLastWordLC58.LengthOfLastWord("   fly me   to   the moon  "));
            //Console.WriteLine(LengthOfLastWordLC58.LengthOfLastWord("luffy is still joyboy"));

            // Longest Common Prefix
            Console.WriteLine(LongestCommonPrefix.LongestCommonPrefixFn(["flower", "flow", "flight"]));
            Console.WriteLine(LongestCommonPrefix.LongestCommonPrefixFn(["dog", "racecar", "car"]));
        }
    }
}
