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

    // Approach : Two Pointers
    // Time Complexity : O(n^2)
    // Space Complexity : O(n)
    // Type: Medium
    public class ThreeSum
    {
        // Two sum implementation
        public static List<List<int>> TwoSum(int[] nums, int left, int right, int target)
        {
            List<List<int>> result = [];
            while (left < right)
            {
                if (nums[left] + nums[right] > target)
                {
                    right--;
                }
                else if (nums[left] + nums[right] < target)
                {
                    left++;
                }
                else
                {
                    result.Add([nums[left], nums[right]]);
                    // Handle duplicates in both left and right elements
                    while (left < right && nums[right] == nums[right - 1])
                        right--;
                    while (left < right && nums[left] == nums[left + 1])
                        left++;
                    left++;
                    right--;
                }
            }
            return result;
        }
        public static IList<IList<int>> ThreeSumFn(int[] nums)
        {
            List<IList<int>> result = [];
            Array.Sort(nums);
            for (int i = 0; i < nums.Length - 2; i++)
            {
                // If chosen element is greater than 0, then the next set of elements in triplet
                // are also positive numbers which means a+b+c can never be 0
                if (nums[i] > 0) break;
                // Handle duplicates before choosing an element as target - chosenElement
                if (i > 0 && nums[i] == nums[i - 1])
                    continue;
                int chosenElement = nums[i];
                // Since target is 0 , then the two sum target should be 0 - chosenElement
                // which is equal to -chosenElement
                var twoSum = TwoSum(nums, i + 1, nums.Length - 1, -chosenElement);
                foreach (var pair in twoSum)
                {
                    result.Add([chosenElement, pair[0], pair[1]]);
                }
            }
            return result;
        }
    }

    // Approach : Two Pointers
    // Time Complexity : O(n^3)
    // Space Complexity : O(n)
    // Type: Medium
    public class FourSum
    {
        public static IList<IList<int>> FourSumFn(int[] nums, int target)
        {
            // 4 sum is like 3 sum but with one extra loop for choosing second candidate
            // and an actual target value instead of 0
            List<IList<int>> result = [];
            int n = nums.Length;
            Array.Sort(nums);
            for (int i = 0; i < n - 3; i++)
            {
                // handle duplicates
                if (i > 0 && nums[i] == nums[i - 1])
                    continue;
                for (int j = i + 1; j < n - 2; j++)
                {
                    // handle duplicates
                    if (j > i + 1 && nums[j] == nums[j - 1])
                        continue;
                    // two sum here
                    int left = j + 1, right = n - 1;
                    while (left < right)
                    {
                        long sum = (long)nums[i] + (long)nums[j] + (long)nums[left] + (long)nums[right];
                        if (sum < (long)target)
                        {
                            left++;
                        }
                        else if (sum > (long)target)
                        {
                            right--;
                        }
                        else
                        {
                            result.Add([nums[i], nums[j], nums[left], nums[right]]);
                            // handle duplicates
                            while (left < right && nums[left] == nums[left + 1])
                                left++;
                            // handle duplicates
                            while (left < right && nums[right] == nums[right - 1])
                                right--;
                            left++;
                            right--;
                        }
                    }
                }
            }
            return result;
        }
    }
}