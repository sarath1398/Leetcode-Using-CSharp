namespace Arrays;

public class ContainsDuplicates : Solution
{
    public bool ContainsDuplicate(int[] nums)
    {
        Dictionary<int, int> map = new();
        foreach (int num in nums)
        {
            if (map.ContainsKey(num))
            {
                return true;
            }
            map.Add(num,0);
        }

        return false;
    }
}