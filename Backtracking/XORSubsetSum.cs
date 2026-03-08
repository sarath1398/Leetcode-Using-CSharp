using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backtracking
{
    // Leetcode : 1863 - XOR Sum of All Subsets
    // Approach : Backtracking
    // Time Complexity : O(2^n)
    // Space Complexity : O(n)
    // Type: Medium 
    public class XORSubsetSum
    {
        public int result = 0;
        public int XORSum(List<int> nums)
        {
            int res = 0;
            foreach(int n in nums)
            {
                res ^= n;
            }
            return res;
        }
        public void Backtrack(int[] nums,int currIndex, List<int> subset)
        {
            if(currIndex >= nums.Length)
            {
                result += XORSum(subset);
                return;
            }
            subset.Add(nums[currIndex]);
            Backtrack(nums,currIndex + 1, subset);
            subset.RemoveAt(subset.Count - 1);
            Backtrack(nums,currIndex + 1, subset);
        }
        public int SubsetXORSum(int[] nums) {
            Backtrack(nums,0,new List<int>());
            return result;
        }
    }
}
