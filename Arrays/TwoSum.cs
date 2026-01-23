namespace Arrays
{

    // Leetcode : 1 - Two Sum
    // Approach : HashMap
    // Time Complexity : O(n)
    // Space Complexity : O(n)
    // Type: Easy
    public class TwoSum
    {
        public static int[] TwoSumFn(int[] nums, int target)
        {
            Dictionary<int, int> frequency = new Dictionary<int, int>();
            int index = 0;
            foreach (var n in nums)
            {
                bool isAvailable = frequency.TryGetValue(n, out int value);
                if (isAvailable)
                {
                    frequency[n] = index++;
                }
                else
                {
                    frequency.Add(n, index++);
                }
            }
            for (int i = 0; i < nums.Length; i++)
            {
                var rem = target - nums[i];
                var isAvailable = frequency.TryGetValue(rem, out int idx);
                if (isAvailable && i != idx)
                {
                    return [i, idx];
                }
            }
            //redundant since there is always a solution
            return [0, 0];
        }
    }
}