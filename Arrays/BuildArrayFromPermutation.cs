namespace Arrays
{
    // Leetcode : 1920 - Build Array from Permutation
    // Approach : Simulation
    // Time Complexity : O(n)
    // Space Complexity : O(1)
    // Type: Easy
    public class BuildArrayFromPermutation
    {
        // TODO: Come up with an O(1) space complexity solution
        public static int[] BuildArray(int[] nums)
        {
            int[] solArray = new int[nums.Length];
            int i = 0;
            foreach (var num in nums)
            {
                solArray[i++] = nums[num];
            }
            return solArray;
        }
    }
}