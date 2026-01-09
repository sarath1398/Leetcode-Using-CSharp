namespace Arrays
{
    internal class LongestConsecutiveSubsequence
    {
        public static int LongestConsecutive(int[] nums)
        {
            HashSet<int> set = [];
            if (nums.Length == 0)
                return 0;
            foreach (int num in nums)
            {
                set.Add(num);
            }
            int globalCount = 1; // Always 1 element will be there minimum
            foreach (int num in set)
            {
                // Check if the current element is the end of the subsequence
                if (!set.Contains(num + 1) && set.Contains(num - 1))
                {
                    int count = 2;
                    int value = num - 1;
                    while (set.Contains(value - 1))
                    {
                        count++;
                        value--;
                    }
                    globalCount = Math.Max(globalCount, count);

                    // Quit early if we find an subsequence which is more than
                    // half the size of input array
                    if (globalCount > nums.Length / 2)
                    {
                        return globalCount;
                    }
                }
            }
            return globalCount;
        }
    }
}
