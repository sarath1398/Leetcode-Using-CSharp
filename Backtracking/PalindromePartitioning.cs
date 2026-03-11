namespace Backtracking
{
    // Leetcode : 131 - Palindrome Partitioning
    // Approach : Backtracking
    // Time Complexity : O(n * 2 ^ n)
    // Space Complexity : O(n)
    // Type: Medium
    public class PalindromePartitioning
    {
        // Result list to store all partitions
        List<List<string>> result = [];
        public bool IsPalindrome(string s)
        {
            // Helper function to check if a string is a palindrome
            int left = 0;
            int right = s.Length - 1;
            while (left <= right)
            {
                // If characters at left and right are not equal, it's not a palindrome
                if (s[left] != s[right])
                    return false;
                left++;
                right--;
            }
            // If all characters matched, it's a palindrome
            return true;
        }
        public List<List<string>> Partition(string s)
        {
            // Result list to store all partitions
            List<List<string>> result = [];

            void DFS(int index, List<string> temp)
            {
                // Base case: If we have processed the entire string, add the partition to result
                if (index == s.Length)
                {
                    result.Add([.. temp]);
                    return;
                }
                string s1 = "";
                // Try all possible partitions starting from the current index
                for (int i = index; i < s.Length; i++)
                {
                    s1 += s[i];
                    // If the current substring is a palindrome, add it to the partition
                    if (IsPalindrome(s1))
                    {
                        // Add the current partition to the result
                        temp.Add(s1);
                        // Recursively try to partition the remaining string
                        DFS(i + 1, temp);
                        // Backtrack: Remove the last partition
                        temp.RemoveAt(temp.Count - 1);
                    }
                }
                return;
            }
            // Start the DFS from index 0 with an empty partition
            DFS(0, []);
            return result;
        }
    }
}
