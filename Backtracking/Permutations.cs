namespace Backtracking
{
    // Leetcode : 46 - Permutations
    // Approach : Backtracking
    // Time Complexity : O(n * n!)
    // Space Complexity : O(n)
    // Type: Medium
    public class Permutations
    {
        List<IList<int>> result = [];
        public void Backtrack(int[] nums, bool[] used, List<int> perm)
        {
            if (perm.Count == nums.Length)
            {
                result.Add([.. perm]);
                return;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (used[i] == true)
                    continue;
                used[i] = true;
                perm.Add(nums[i]);
                Backtrack(nums, used, perm);
                used[i] = false;
                perm.RemoveAt(perm.Count - 1);
            }
        }
        public IList<IList<int>> Permute(int[] nums)
        {
            int n = nums.Length;
            bool[] used = new bool[n];
            List<int> perm = [];
            Backtrack(nums, used, perm);
            return result;
        }
    }
}
