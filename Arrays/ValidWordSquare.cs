namespace Arrays
{
    // Leetcode : 422 - Valid Word Square
    // Approach : Brute Force
    // Time Complexity : O(n^2)
    // Space Complexity : O(1)
    // Type: Easy
    public class ValidWordSquareLC422
    {

        public static bool ValidWordSquare(List<string> words)
        {
            for (int i = 0; i < words.Count; i++)
            {
                for (int j = 0; j < words[i].Length; j++)
                {
                    // j >= words.Count - If word in row exceeds the word in column
                    // i >= words[j].Length - If word in column exceeds the length of word in row
                    if (j >= words.Count || i >= words[j].Length)
                    {
                        return false;
                    }
                    if (words[i][j] != words[j][i])
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
