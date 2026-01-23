namespace Arrays
{
    // Leetcode : 2678 - Number of Senior Citizens
    // Approach : String Parsing
    // Time Complexity : O(n)
    // Space Complexity : O(1)
    // Type: Easy
    public class NumberOfSeniorCitizens
    {
        public static int CountSeniors(string[] details)
        {
            int count = 0;
            foreach (string detail in details)
            {
                if ((detail[11] == '6' && detail[12] > '0') || (detail[11] > '6'))
                {
                    count++;
                }
            }
            return count;
        }
    }
}
