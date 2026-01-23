namespace Arrays
{
    // Leetcode : 560 - Subarray Sum Equals K
    // Approach : Prefix Sum Array + HashMap
    // Time Complexity : O(n)
    // Space Complexity : O(n)
    // Type: Medium
    public class SubarraySumEqualsK
    {
        public static int SubarraySum(int[] nums, int k)
        {
            Dictionary<int, int> prefixSumMap = new(nums.Length)
            {
                // The intution here is that if a subarray nums[left....right] has a sum of k
                // and we calculate prefix sum for every nums[i] then
                // *********** prefixSum[left-1] + k = prefixSum[right] *********************
                // Since left can be 0, we assume a nums[-1] that is 0
                // and since nums[-1] theoretically exists, we have a scenario where
                // prefixSum=0 and so we have a base case of prefixSum 0 having count 1

                { 0, 1 }
            };
            int prefixSum = 0, count = 0;
            foreach (int num in nums)
            {
                prefixSum += num;
                if (prefixSumMap.ContainsKey(prefixSum - k))
                {
                    count += prefixSumMap[prefixSum - k];
                }
                if (!prefixSumMap.TryAdd(prefixSum, 1))
                {
                    prefixSumMap[prefixSum]++;
                }
            }
            return count;
        }
    }
}
