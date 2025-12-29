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
            // Type : Easy
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

        public class AppendCharactersToStringLC2486
        {
            // Approach : Two Pointers
            // Time Complexity : O(n)
            // Space Complexity : O(1)
            // Type : Medium
            public static int AppendCharacters(string s, string t)
            {
                int shortPtr = 0;
                for (int i = 0; i < s.Length; i++)
                {
                    if (shortPtr < t.Length && s[i] == t[shortPtr])
                    {
                        shortPtr++;
                    }
                }
                return t.Length - shortPtr;
            }
        }

        public class LengthOfLastWordLC58
        {
            // Approach : Two Pointers
            // Time Complexity : O(n)
            // Space Complexity : O(1)
            // Type: Easy
            public static int LengthOfLastWord(string s)
            {
                int revPtr = s.Length - 1;
                int count = 0;
                while (s[revPtr] == ' ')
                    revPtr--;
                for (int i = revPtr; i >= 0; i--)
                {
                    if (s[i] == ' ')
                    {
                        return count;
                    }
                    if ((s[i] >= 'a' && s[i] <= 'z') || (s[i] >= 'A' && s[i] <= 'Z'))
                    {
                        count++;
                    }
                }
                return count;
            }
        }

        public class LongestCommonPrefix
        {
            public static string LongestCommonPrefixFn(string[] strs)
            {
                string smallestString = "";
                string maxPrefixString = "";
                int minLength = 201;
                foreach (string str in strs)
                {
                    if (str.Length < minLength)
                    {
                        smallestString = str;
                        minLength = str.Length;
                    }
                }
                for (int i = 0; i < smallestString.Length; i++)
                {
                    int count = 0;
                    for (int j = 0; j < strs.Length; j++)
                    {
                        if (smallestString[i] == strs[j][i])
                        {
                            count++;
                        }
                    }
                    if (count == strs.Length)
                    {
                        maxPrefixString += smallestString[i];
                    }
                    else
                    {
                        break;
                    }
                }
                return maxPrefixString;
            }
        }
    }
}
