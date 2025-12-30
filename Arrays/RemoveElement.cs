namespace Arrays
{
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
                    int temp = nums[leftPtr];
                    nums[leftPtr] = nums[rightPtr];
                    nums[rightPtr] = temp;
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
