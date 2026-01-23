namespace Arrays
{
    // Leetcode : 169 - Majority Element
    // Approach : Greedy (Boyer Moore voting algorithm)
    // Time Complexity : O(n)
    // Space Complexity : O(1)
    // Type: Easy
    public class MajorityElement
    {

        public static int MajorityElementFn(int[] nums)
        {
            int initialMajority = nums[0];
            int majorityCount = 1;
            if (nums.Length == 1)
                return initialMajority;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] == initialMajority)
                {
                    majorityCount++;
                }
                else
                {
                    if (majorityCount <= 0)
                    {
                        initialMajority = nums[i];
                        majorityCount = 1;
                    }
                    else
                    {
                        majorityCount--;
                    }
                }
            }
            return initialMajority;
        }
    }
}
