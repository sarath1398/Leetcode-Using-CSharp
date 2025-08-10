namespace Arrays;

public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int,int> frequency = new Dictionary<int,int>();
        int index = 0;
        foreach(var n in nums)
        {
			bool isAvailable = frequency.TryGetValue(n,out int value);
			if(isAvailable)
			{
				frequency[n] = index++;
			} else {
				frequency.Add(n,index++);
			}
        }
        for(int i=0;i<nums.Length;i++)
        {
            var rem = target - nums[i];
            var isAvailable = frequency.TryGetValue(rem,out int idx);
            if(isAvailable && i != idx)
            {
                return [i,idx];
            }
        }
        //redundant since there is always a solution
        return [0, 0];
    }
}

class TwoSum
{
    static void Main(string[] args)
    {
        // Testcase Wrapper
        var sol = new Solution();
        // var data = sol.TwoSum(nums: [2, 7, 11, 15], 9);
        // foreach (var d in data)
        // {
        //     Console.Write(d + " ");
        // }
        // var data = new ContainsDuplicates();
        // Console.WriteLine(data.ContainsDuplicate([1,2,3,4]));
        // var data = new ValidAnagrams();
        // Console.WriteLine(data.IsAnagram("cock", "crane"));
        // var data = new GroupAnagrams();
        // var lists = data.GroupAnagramsFn(["act","pots","tops","cat","stop","hat"]);
        // foreach(var list in lists)
        // {
        //     foreach (var l in list)
        //     {
        //         Console.Write(l+ " ");
        //     }
        //     Console.WriteLine();
        // }
        var data = new TopKFrequentElements();
        var array = data.TopKFrequent([1,1,1,2,2,3],2);
        foreach (var num in array)
        {
            Console.Write(num + " ");
        }
    }
}