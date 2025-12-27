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
