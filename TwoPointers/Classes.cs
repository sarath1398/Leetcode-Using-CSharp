using System.Text;

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

    // Approach : Two Pointers
    // Time Complexity : O(n)
    // Space Complexity : O(1)
    // Type: Easy
    public class ValidPalindromeII
    {
        public static bool ValidPalindrome(string s)
        {
            bool IsPalindrome(int l, int r)
            {
                while (l < r)
                {
                    if (s[l] != s[r]) return false;
                    l++;
                    r--;
                }
                return true;
            }

            int lptr = 0, rptr = s.Length - 1;
            while (lptr < rptr)
            {
                if (s[lptr] != s[rptr])
                {
                    return IsPalindrome(lptr + 1, rptr) || IsPalindrome(lptr, rptr - 1);
                }
                lptr++;
                rptr--;
            }
            return true;
        }
    }

    // Approach : Two Pointers
    // Time Complexity : O(m + n)
    // Space Complexity : O(m + n)
    // Type: Easy
    public class MergeStringsAlternatively
    {
        public static string MergeAlternately(string word1, string word2)
        {
            StringBuilder sb = new();
            int lptr1 = 0, lptr2 = 0;
            while (lptr1 < word1.Length && lptr2 < word2.Length)
            {
                sb.Append(word1[lptr1++]);
                sb.Append(word2[lptr2++]);
            }
            while (lptr1 < word1.Length)
            {
                sb.Append(word1[lptr1++]);
            }
            while (lptr2 < word2.Length)
            {
                sb.Append(word2[lptr2++]);
            }
            return sb.ToString();
        }
    }

    // Approach : Two Pointers
    // Time Complexity : O(m + n)
    // Space Complexity : O(m + n)
    // Type: Easy
    public class MergeSortedArray
    {
        public static void Merge(int[] nums1, int m, int[] nums2, int n)
        {

            // nums1 value lies between nums1[0...m-1]
            // nums2 value lies between nums2[0...n-1]
            // zeroes lie between nums1[m...m+n-1]

            int zeroEndPtr = m + n - 1;
            int maxNum1Ptr = m - 1;
            int maxNum2Ptr = n - 1;

            // Fill the max value from the end
            while (maxNum1Ptr >= 0 && maxNum2Ptr >= 0)
            {
                if (nums1[maxNum1Ptr] > nums2[maxNum2Ptr])
                {
                    nums1[zeroEndPtr--] = nums1[maxNum1Ptr--];
                }
                else
                {
                    nums1[zeroEndPtr--] = nums2[maxNum2Ptr--];
                }
            }

            // Fill the leftover values of nums2 as per sorted order in nums1
            for (int i = 0; i <= maxNum2Ptr; i++)
            {
                nums1[i] = nums2[i];
            }

            Console.WriteLine(String.Join(',',nums1));
        }
    }

    // Approach : Two Pointers
    // Time Complexity : O(n)
    // Space Complexity : O(n)
    // Type: Easy
    public class RemoveDuplicatesFromSorted
    {
        public static int RemoveDuplicates(int[] nums)
        {
            int fast = 1;
            int slow = 0; // Index points to the unique elements in the sorted array
            if (nums.Length == 1)
                return 1;
            else
            {
                while (fast < nums.Length)
                {
                    // If the first match of a unique element is found then
                    // swap the slow + 1 pointer with the fast pointer
                    if (nums[fast] != nums[slow])
                    {
                        slow++;
                        (nums[fast], nums[slow]) = (nums[slow], nums[fast]);
                    }
                    fast++;
                }
            }
            return slow + 1;
        }
    }
}