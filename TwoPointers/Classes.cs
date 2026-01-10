namespace TwoPointers
{
    public class TwoSum2
    {
        public int[] TwoSum(int[] numbers, int target)
        {
            int start = 0;
            int end = numbers.Length - 1;
            while (start < end)
            {
                int twoSum = numbers[start] + numbers[end];
                if (twoSum > target)
                {
                    end--;
                    continue;
                }
                else if (twoSum < target)
                {
                    start++;
                    continue;
                }
                else
                {
                    int[] result = { start + 1, end + 1 };
                    return result;
                }
            }
            return [];
        }
    }

    // Approach : Two Pointers
    // Time Complexity : O(n)
    // Space Complexity : O(1)
    // Type: Easy
    public class ReverseStringLC344
    {
        public static void ReverseString(char[] s)
        {
            int lptr = 0, rptr = s.Length - 1;
            while (lptr < rptr)
            {
                (s[lptr], s[rptr]) = (s[rptr], s[lptr]);
                lptr++;
                rptr--;
            }
            Console.WriteLine("[" + string.Join(',',s) + "]");
        }
    }

    // Approach : Two Pointers
    // Time Complexity : O(n)
    // Space Complexity : O(1)
    // Type: Easy
    public class ValidPalindrome
    {
        public static bool IsPalindrome(string s)
        {
            int lptr = 0, rptr = s.Length - 1;
            while (lptr < rptr)
            {
                if (!((s[lptr] >= 'A' && s[lptr] <= 'Z') || (s[lptr] >= 'a' && s[lptr] <= 'z')
                || (s[lptr] >= '0' && s[lptr] <= '9')))
                {
                    lptr++;
                }
                if (!((s[rptr] >= 'A' && s[rptr] <= 'Z') || (s[rptr] >= 'a' && s[rptr] <= 'z')
                || (s[rptr] >= '0' && s[rptr] <= '9')))
                {
                    rptr--;
                }
                if (((s[lptr] >= 'A' && s[lptr] <= 'Z') || (s[lptr] >= 'a' && s[lptr] <= 'z')
                || (s[lptr] >= '0' && s[lptr] <= '9')) && ((s[rptr] >= 'A' && s[rptr] <= 'Z')
                || (s[rptr] >= 'a' && s[rptr] <= 'z') || (s[rptr] >= '0' && s[rptr] <= '9')))
                {
                    if (Char.ToLowerInvariant(s[lptr]) != Char.ToLowerInvariant(s[rptr]))
                    {
                        return false;
                    }
                    lptr++;
                    rptr--;
                }
            }
            return true;
        }
    }
}
