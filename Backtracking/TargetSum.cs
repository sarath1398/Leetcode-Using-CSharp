namespace Backtracking;

    // Leetcode : 494 - Target Sum
    // Approach : Backtracking
    // Time Complexity : O(2^n)
    // Space Complexity : O(n)
    // Type: Medium
    public class TargetSum
{
    int count = 0;
    public int FindTargetSumWays(int[] nums, int target)
    {
        Backtrack(nums, target, 0);
        return count;
    }
    public void Backtrack(int[] nums, int target, int idx)
    {
        if (idx == nums.Length)
        {
            if (target == 0)
            {
                count += 1;
            }
            return;
        }
        Backtrack(nums, target - nums[idx], idx + 1);
        Backtrack(nums, target + nums[idx], idx + 1);
    }
}