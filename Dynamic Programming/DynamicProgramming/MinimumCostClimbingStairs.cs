namespace DynamicProgramming;

    // Leetcode : 746 - Min Cost Climbing Stairs
    // Approach : Dynamic Programming
    // Time Complexity : O(n)
    // Space Complexity : O(1)
    // Type: Easy
    public class MinimumCostClimbingStairs : Program
{
    public int MinCostClimbingStairs(int[] cost) {
        int step1 = cost[0];
        int step2 = cost[1];
        int n = cost.Length;
        if(n==2)
        {
            return Math.Min(step1,step2);
        }
        else
        {
            for(int i=2;i<n;i++)
            {
                int curr_step = cost[i] + Math.Min(step1, step2);
                step1 = step2;
                step2 = curr_step;
            }
            return Math.Min(step1, step2);
        }
    }
}