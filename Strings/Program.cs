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
            Console.WriteLine(IsSubSequenceLC392.IsSubsequence("abc", "ahbgdc"));
            Console.WriteLine(IsSubSequenceLC392.IsSubsequence("axc", "ahbgdc"));
        }
    }
}
