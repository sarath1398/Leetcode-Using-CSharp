namespace Arrays
{
    // Leetcode : 41 - First Missing Positive
    // Approach : Cyclic Sort / In-place Hashing
    // Time Complexity : O(n)
    // Space Complexity : O(1)
    // Type: Hard
    public class FirstMissingPositive
    {
        public static int FirstMissingPositiveFn(int[] nums)
        {
            // O(n) space complexity
            // HashSet<int> set = new(nums);
            // int firstPositiveInteger = 1;
            // while(set.Contains(firstPositiveInteger))
            // {
            //     firstPositiveInteger++;
            // }
            // return firstPositiveInteger;

            // O(1) space complexity solution
            for (int i = 0; i < nums.Length; i++)
            {
                // Preprocessing - Update existing negative numbers as 0
                if (nums[i] < 0)
                    nums[i] = 0;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                int val = Math.Abs(nums[i]);
                // Check if val is in the solution range of [1...n+1]
                if (val >= 1 && val <= nums.Length)
                {
                    // if val exists and is a positive value then
                    // mark the nums[val - 1] as negative to mark the presence of val
                    if (nums[val - 1] > 0)
                    {
                        nums[val - 1] = -nums[val - 1];
                    }
                    // Provide a value out of valid range in case of 0
                    else if (nums[val - 1] == 0)
                    {
                        nums[val - 1] = -(nums.Length + 1);
                    }
                }
            }
            for (int i = 0; i < nums.Length; i++)
            {
                // if nums[i] is positive then i+1 is the missing element
                // since it is not marked as negative
                if (nums[i] >= 0)
                    return i + 1;
            }
            // If all are negative then the first value out of solution range
            // i.e [1...n] is the positive integer
            return nums.Length + 1;
        }
    }
}
