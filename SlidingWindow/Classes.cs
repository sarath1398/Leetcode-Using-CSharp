namespace Sliding_Window;

public class Classes
{
    // Leetcode : 1652 - Defuse the Bomb
    // Approach : Sliding Window
    // Time Complexity : O(n)
    // Space Complexity : O(n)
    // Type: Easy
    public class DefuseTheBomb
    {
        public int[] Decrypt(int[] code, int k)
        {
            int n = code.Length;
            int[] decrypt = new int[n];
            if(k == 0)
            {
                return decrypt;
            }
            // TODO: Think of a solution to combine the previous and next in the same case instead of if-else
            else
            {
                bool isNextPtr = k < 0 ? false : true;
                k = k < 0 ? -1*k : k;
                if(isNextPtr)
                {
                    // Track next k sum
                    int initNextSum = 0;
                    for(int i=0;i<k;i++)
                    {
                        initNextSum+=code[i];
                    }
                    for(int i=0;i<n;i++)
                    {
                        int end = (i+k)%n;
                        int nextSum = initNextSum-code[i]+code[end];
                        initNextSum = nextSum;
                        decrypt[i]=nextSum;
                    }
                }
                else
                {
                    //Track prev k sum
                    int initPrevSum = 0;
                    for(int i=n-k;i<n;i++)
                    {
                        initPrevSum+=code[i];
                    }
                    for(int i=0;i<n;i++)
                    {
                        int end = (n-k+i)%n;
                        decrypt[i] = initPrevSum;
                        initPrevSum += code[i]-code[end];
                    }
                }
                return decrypt;
            }
        }
    }

    // Leetcode : 219 - Contains Duplicate II
    // Approach : Sliding Window
    // Time Complexity : O(n)
    // Space Complexity : O(n)
    // Type: Easy
    public class ContainsDuplicateII {
        public static bool ContainsNearbyDuplicate(int[] nums, int k) {
            Dictionary<int,int> dict = new();
            int l = 0;
            int r = 0;
            int n = nums.Length - 1;
            while(r <= n)
            {
                // add if there is no duplicate entry for the number along with index
                if(!dict.ContainsKey(nums[r]))
                {
                    dict.Add(nums[r],r);
                }
                // first occurrence of duplicate number in the dictionary
                else
                {
                    int prevIndex = dict[nums[r]];
                    if(Math.Abs(prevIndex - r) <= k)
                    {
                        return true;
                    }
                    // update the index of the duplicate number
                    dict[nums[r]] = r;
                    // move the window to the right and omit the leftmost element
                    l++;
                }
                // move the window to the right
                r++;
            }
            return false;
        }
    }

    // Leetcode : 121 - Best Time to Buy and Sell Stock
    // Approach : Sliding Window
    // Time Complexity : O(n)
    // Space Complexity : O(1)
    // Type: Easy
    public class BestTimeToBuyAndSellStock {
        public static int MaxProfit(int[] prices) {
            int maxProfit = 0;
            int l = 0, r = 1;
            int n = prices.Length - 1;
            while(r <= n)
            {
                // create a window till the buying price is lesser than the selling price
                if(prices[l] < prices[r])
                {
                    int profit = prices[r] - prices[l];
                    maxProfit = Math.Max(maxProfit,profit);
                } 
                // if the buying price is greater than selling price then start a new window
                else
                {
                    l = r;
                }
                r++;
            }
            return maxProfit;
        }
    }

    // Leetcode : 3 - Longest Substring Without Repeating Characters
    // Approach : Sliding Window
    // Time Complexity : O(n)
    // Space Complexity : O(n)
    // Type: Medium
    public class LongestSubstringWithoutRepeatingCharacters {
        public static int LengthOfLongestSubstring(string s) {
            HashSet<char> set = new HashSet<char>();
            int l = 0, r = 0;
            int maxCount = 0;
            while(r < s.Length)
            {
                // check if the new element is present inside our current window
                // if yes, then remove all elements till the previous elements from the set and the window
                while(set.Contains(s[r]))
                {
                    set.Remove(s[l]);
                    l++;
                }
                // add the new unique element to the set and keep track of maximum size of the set
                set.Add(s[r]);
                maxCount = Math.Max(maxCount, set.Count);
                r++;
            }
            // return maxcount
            return maxCount;
        }
    }
}
