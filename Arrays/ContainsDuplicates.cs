namespace Arrays
{
    public class ContainsDuplicates
    {
        public static bool ContainsDuplicate(int[] nums)
        {
            Dictionary<int, int> map = new();
            foreach (int num in nums)
            {
                if (map.ContainsKey(num))
                {
                    return true;
                }
                map.Add(num, 0);
            }

            return false;
        }
    }
}