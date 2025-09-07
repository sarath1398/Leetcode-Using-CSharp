namespace Backtracking;

public class Subsets1
{
    public void Backtrack(int[] nums,int idx, List<int> tempList, List<IList<int>> results)
    {
        if(idx==nums.Length)
        {
            results.Add(new List<int>(tempList));
            return;
        }
        tempList.Add(nums[idx]);
        Backtrack(nums,idx+1,tempList,results);
        tempList.RemoveAt(tempList.Count()- 1);
        Backtrack(nums,idx+1,tempList,results);
        return;
    }
    public IList<IList<int>> Subsets(int[] nums) {
        List<int> tempList = new();
        List<IList<int>> results = new();
        Backtrack(nums,0,tempList,results);
        return results;
    }
}