namespace Arrays;

public class TopKFrequentElements : Solution
{
    public int[] TopKFrequent(int[] nums, int k)
    {
        Dictionary<int, int> frequencyMap = new();
        foreach (var num in nums)
        {
            bool isAdded = frequencyMap.TryAdd(num,1);
            if (!isAdded)
            {
                frequencyMap[num]++;
            }
        }

        var groupingMap = new Dictionary<int, List<int>>();
        int max = int.MinValue;
        foreach (var num in frequencyMap.Keys)
        {
            int frequency = frequencyMap[num];
            bool isAdded = groupingMap.TryAdd(frequency, new List<int>() { num });
            if (!isAdded)
            {
                groupingMap[frequency].Add(num);
            }

            max = Math.Max(max, frequency);
        }

        List<int> finalList = new();
        for (int i = max; i > 0 && k > 0; i--)
        {
            var isRetrieved = groupingMap.TryGetValue(i,out List<int> allNums);
            if (!isRetrieved)
            {
                continue;
            }
            foreach (var num in allNums)
            {
                finalList.Add(num);
                k--;
                if (k == 0)
                {
                    return finalList.ToArray();
                }
            }
        }

        return finalList.ToArray(); // Redundant since we already know that there exists a solution as per the problem statement
    }
}