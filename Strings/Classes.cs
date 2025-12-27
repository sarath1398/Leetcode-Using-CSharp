namespace Strings
{
    public class Classes
    {
        public class ScoreOfStringLC3110
        {
            public static int ScoreOfString(string s)
            {
                int abs = 0;
                for (int i = 1; i < s.Length; i++)
                {
                    abs += Math.Abs((int)s[i] - (int)s[i - 1]);
                }
                return abs;
            }
        }

        public class IsSubSequenceLC392
        {
            // Approach : Two Pointers
            // Time Complexity : O(n)
            // Space Complexity : O(1)
            // TODO : Handle this followup - Suppose there are lots of incoming s, say s1, s2, ..., sk
            // where k >= 10^9 and you want to check one by one to see if t has its subsequence.
            // In this scenario, how would you change your code?

            public static bool IsSubsequence(string s, string t)
            {
                int shortPtr = 0;
                for (int i = 0; i < t.Length; i++)
                {
                    if (shortPtr > s.Length - 1)
                        break;
                    else if (s[shortPtr] == t[i])
                    {
                        shortPtr++;
                    }
                }
                return shortPtr == s.Length;
            }
        }
    }
}
