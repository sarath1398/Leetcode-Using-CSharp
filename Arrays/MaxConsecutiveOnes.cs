namespace Arrays
{
    // Approach : Brute Force
    // Time Complexity : O(n)
    // Space Complexity : O(1)
    // Type: Easy
    public class MaxConsecutiveOnes
    {
        public static int FindMaxConsecutiveOnes(int[] nums)
        {
            int res = 0;
            int maxCount = 0;
            foreach (int i in nums)
            {
                if (i == 1)
                {
                    maxCount++;
                }
                else
                {
                    res = Math.Max(res, maxCount);
                    maxCount = 0;
                }
            }
            return (res > maxCount) ? res : maxCount;
        }
    }
}
