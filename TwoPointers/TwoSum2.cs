namespace TwoPointers;

public class TwoSum2
{
    public int[] TwoSum(int[] numbers, int target) {
        int start = 0;
        int end = numbers.Length - 1;
        while(start < end)
        {
            int twoSum = numbers[start] + numbers[end];
            if(twoSum > target)
            {
                end--;
                continue;
            }
            else if (twoSum < target)
            {
                start++;
                continue;
            }
            else
            {
                int[] result = { start+1, end+1 };
                return result;
            }
        }
        return [];
    }
}