namespace Backtracking;

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