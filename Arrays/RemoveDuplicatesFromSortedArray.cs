namespace Arrays
{
    public class RemoveDuplicatesFromSortedArray
    {
        public static int RemoveDuplicates(int[] nums)
        {
            int fast = 1;
            int slow = 0;
            if (nums.Length == 1)
                return 1;
            else
            {
                for (; fast < nums.Length;)
                {
                    if (nums[fast] == nums[slow])
                    {
                        fast++;
                        continue;
                    }
                    else
                    {
                        slow++;
                        int temp = nums[fast];
                        nums[fast] = nums[slow];
                        nums[slow] = temp;
                        fast++;
                    }
                }
            }
            return slow + 1;
        }
    }
}
