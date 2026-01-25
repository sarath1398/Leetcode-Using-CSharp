namespace Strings
{
    public class Classes
    {
        // Leetcode : 3110 - Score of a String
        // Approach : String Iteration
        // Time Complexity : O(n)
        // Space Complexity : O(1)
        // Type: Easy
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

        // Leetcode : 392 - Is Subsequence
        // Approach : Two Pointers
        // Time Complexity : O(n)
        // Space Complexity : O(1)
        // Type : Easy

        // TODO : Handle this followup - Suppose there are lots of incoming s, say s1, s2, ..., sk
        // where k >= 10^9 and you want to check one by one to see if t has its subsequence.
        // In this scenario, how would you change your code?

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



        // Leetcode : 2486 - Append Characters to String to Make Subsequence
        // Approach : Two Pointers
        // Time Complexity : O(n)
        // Space Complexity : O(1)
        // Type : Medium

        public class AppendCharactersToStringLC2486
        {
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


        // Leetcode : 58 - Length of Last Word
        // Approach : Two Pointers
        // Time Complexity : O(n)
        // Space Complexity : O(1)
        // Type: Easy

        public class LengthOfLastWordLC58
        {
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


        // Leetcode : 14 - Longest Common Prefix
        // Approach : Brute Force
        // Time Complexity : O(n^2)
        // Space Complexity : O(1)
        // Type: Easy
        // TODO : Use Trie to find LCP of all strings

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

        // Leetcode : 1408 - String Matching in an Array
        // Approach : Brute Force
        // Time Complexity : O(n^2)
        // Space Complexity : O(n)
        // Type: Easy

        // Check whether s is a substring of t
        // TODO : Use KMP algorithm for checking substring condition

        public class StringMatchingInAnArray
        {
            public static bool IsSubstring(string s, string t)
            {
                for (int i = 0; i <= t.Length - s.Length; i++)
                {
                    int j = 0;
                    while (j < s.Length && t[i + j] == s[j])
                    {
                        j++;
                    }
                    if (j == s.Length)
                    {
                        return true;
                    }
                }
                return false;
            }
            public static IList<string> StringMatching(string[] words)
            {
                List<string> match = [];
                for (int i = 0; i < words.Length; i++)
                {
                    for (int j = i + 1; j < words.Length; j++)
                    {
                        bool isSubstring = false;
                        if (words[i].Length < words[j].Length)
                        {
                            isSubstring = IsSubstring(words[i], words[j]);
                            if (isSubstring)
                            {
                                match.Add(words[i]);
                            }
                        }
                        else if (words[j].Length < words[i].Length)
                        {
                            isSubstring = IsSubstring(words[j], words[i]);
                            if (isSubstring)
                            {
                                match.Add(words[j]);
                            }
                        }
                    }
                }
                HashSet<string> set = [.. match];
                return [.. set];
            }
        }
    }
}
