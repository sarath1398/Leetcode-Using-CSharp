namespace Backtracking
{
    // Leetcode : 47 - Permutations II
    // Approach : Backtracking
    // Time Complexity : O(n * n!)
    // Space Complexity : O(n)
    // Type: Medium
    public class PermutationsII
    {
        // Result list to store all unique permutations
        List<IList<int>> result = [];
        public void Backtrack(int[] nums, bool[] used, List<int> subset)
        {
            // Base case: If the subset size equals the array size, we have a complete permutation
            if (subset.Count == nums.Length)
            {
                result.Add([.. subset]);
                return;
            }
            // Iterate through the array to find the next element to add to the subset
            for (int i = 0; i < nums.Length; i++)
            {
                // Skip if the element is already used
                if (used[i] == true)
                    continue;
                // Skip if the element is a duplicate and the previous element is not used
                if (i > 0 && nums[i] == nums[i - 1] && !used[i - 1])
                    continue;
                // Mark the element as used
                used[i] = true;
                // Add the element to the subset
                subset.Add(nums[i]);
                // Recursively call the backtrack function
                Backtrack(nums, used, subset);
                // Mark the element as unused
                used[i] = false;
                // Remove the element from the subset
                subset.RemoveAt(subset.Count - 1);
            }
        }
        public IList<IList<int>> PermuteUnique(int[] nums)
        {
            int n = nums.Length;
            bool[] used = new bool[n];
            // Sort the array to handle duplicates
            Array.Sort(nums);
            // Start the backtracking process
            Backtrack(nums, used, []);
            return result;
        }
    }
}
