namespace Arrays
{
    public class SortColors
    {
        // Approach : Two Pointers
        // Time Complexity : O(n)
        // Space Complexity : O(1)
        // Type: Medium
        public static void SortColorsFn(int[] nums)
        {
            int lPtr = 0, rPtr = nums.Length - 1;
            // Condition is to check till the rPtr since rPtr to nums.Length - 1 has 2's
            for (int i = 0; i <= rPtr; i++)
            {
                if (nums[i] == 0)
                {
                    (nums[lPtr], nums[i]) = (nums[i], nums[lPtr]);
                    lPtr++;
                }
                else if (nums[i] == 2)
                {
                    (nums[rPtr], nums[i]) = (nums[i], nums[rPtr]);
                    rPtr--;
                    // Reset i value to check the nums[i] once again for 0 or 1
                    i--;
                }
            }
        }
    }
}
