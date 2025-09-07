namespace Backtracking;

public class Subsets2
{
    public void Backtrack(int[] nums,int start,List<int> tempList,List<IList<int>> results)
    {
        results.Add(new List<int>(tempList));
        for(int i = start; i < nums.Length; i++)
        { 
            if(i > start && nums[i] == nums[i-1])
            {
                continue;
            }
            tempList.Add(nums[i]);
            Backtrack(nums,i+1,tempList,results);
            tempList.RemoveAt(tempList.Count()-1);
        }
    }
    public IList<IList<int>> SubsetsWithDup(int[] nums) {
        // Try backtracking with a start index loop concept
        Array.Sort(nums);
        List<int> tempList = new();
        List<IList<int>> results = new();
        Backtrack(nums,0,tempList,results);
        return results;
    }
}