namespace Arrays
{
    // Leetcode : 229 - Majority Element II
    // Approach : Boyer-Moore Voting Algorithm (Extended)
    // Time Complexity : O(n)
    // Space Complexity : O(1)
    // Type: Medium
    internal class MajorityElementII
    {
        public static IList<int> MajorityElement(int[] nums)
        {
            List<int> result = [];
            int c1 = 0, num1 = -(10 ^ 8 - 1), num2 = -(10 ^ 8 - 1), c2 = 0;
            foreach (int num in nums)
            {
                if (num == num1)
                {
                    c1++;
                }
                else if (num == num2)
                {
                    c2++;
                }
                else if (c1 == 0)
                {
                    num1 = num;
                    c1++;
                }
                else if (c2 == 0)
                {
                    num2 = num;
                    c2++;
                }
                else
                {
                    c1--;
                    c2--;
                }
            }
            c1 = 0;
            c2 = 0;
            foreach (int num in nums)
            {
                if (num == num1)
                    c1++;
                if (num == num2)
                    c2++;
            }
            if (c1 > nums.Length / 3)
                result.Add(num1);
            if (c2 > nums.Length / 3)
                result.Add(num2);
            return result;
        }
    }
}
