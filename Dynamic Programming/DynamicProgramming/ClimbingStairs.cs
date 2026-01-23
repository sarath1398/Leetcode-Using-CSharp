namespace DynamicProgramming;

    // Leetcode : 70 - Climbing Stairs
    // Approach : Dynamic Programming
    // Time Complexity : O(n)
    // Space Complexity : O(1)
    // Type: Easy
    public class ClimbingStairs : Program
{
    public int ClimbStairs(int n) {
        if(n==0 || n == 1)
            return 1;
        int step0 = 1;
        int step1 = 1;
        for(int i = 2; i <= n; i++)
        {
            int curr_step = step0 + step1;
            step0 = step1;
            step1 = curr_step;
        }
        return step1;
    }
}