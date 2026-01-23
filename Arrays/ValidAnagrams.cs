namespace Arrays
{
    // Leetcode : 242 - Valid Anagram
    // Approach : HashMap / Array Count
    // Time Complexity : O(n)
    // Space Complexity : O(1)
    // Type: Easy
    public class ValidAnagrams
    {
        public static bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length)
            {
                return false;
            }
            else
            {
                Dictionary<char, int> frequencyMapFirst = new();
                Dictionary<char, int> frequencyMapSecond = new();
                for (int i = 0; i < s.Length; i++)
                {
                    bool isAddedFirstString = frequencyMapFirst.TryAdd(s[i], 1);
                    bool isAddedSecondString = frequencyMapSecond.TryAdd(t[i], 1);
                    if (!isAddedFirstString)
                    {
                        frequencyMapFirst[s[i]]++;
                    }

                    if (!isAddedSecondString)
                    {
                        frequencyMapSecond[t[i]]++;
                    }
                }

                for (int i = 0; i < s.Length; i++)
                {
                    frequencyMapFirst.TryGetValue(s[i], out int count1);
                    frequencyMapSecond.TryGetValue(s[i], out int count2);
                    if (count1 != count2)
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}