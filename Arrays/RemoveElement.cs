namespace Arrays
{
    // Leetcode : 27 - Remove Element
    // Approach : Two Pointers
    // Time Complexity : O(n)
    // Space Complexity : O(1)
    // Type: Easy
    public class RemoveElement
    {

        public static int RemoveElementFn(int[] nums, int val)
        {
            int leftPtr = 0;
            int rightPtr = nums.Length - 1;
            if (nums.Length == 0)
                return 0;
            while (leftPtr < rightPtr)
            {
                if (nums[leftPtr] == val)
                {
                    (nums[rightPtr], nums[leftPtr]) = (nums[leftPtr], nums[rightPtr]);
                    rightPtr--;
                }
                else
                {
                    leftPtr++;
                }
            }
            return nums[leftPtr] == val ? leftPtr : leftPtr + 1;
        }
    }
}
