using System.Text;

// Leetcode - 17
// Approach : Backtracking
// Time Complexity : O(4^n * n)
// Space Complexity : O(n)
// Type: Medium
public class LetterCombinationsOfAPhoneNumber
{
    public IList<string> LetterCombinations(string digits)
    {
        // Mapping of digits to letters
        Dictionary<int, string> dict = [];
        dict.Add(2, "abc");
        dict.Add(3, "def");
        dict.Add(4, "ghi");
        dict.Add(5, "jkl");
        dict.Add(6, "mno");
        dict.Add(7, "pqrs");
        dict.Add(8, "tuv");
        dict.Add(9, "wxyz");

        // Result list
        List<string> result = [];

        // Base case
        if (digits.Length == 0)
            return result;

        // DFS function
        void DFS(int curr_digit, StringBuilder sb)
        {
            // Base case
            if (sb.Length == digits.Length)
            {
                result.Add(sb.ToString());
                return;
            }
            // Base case
            if (curr_digit > digits.Length)
            {
                return;
            }
            // Get the current digit
            int digit = digits[curr_digit] - '0';
            // Get the letters for the current digit
            string numbers = dict[digit];
            // Iterate through the letters
            for (int i = 0; i < numbers.Length; i++)
            {
                // Append the letter
                sb.Append(numbers[i].ToString());
                // Recurse for the next digit
                DFS(curr_digit + 1, sb);
                // Backtrack
                sb.Length--;
            }
            return;
        }

        // Start DFS
        DFS(0, new StringBuilder());
        return result;
    }
}