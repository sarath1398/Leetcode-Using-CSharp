namespace Backtracking;

public class CombinationSum3
{
    public void BacktrackFn(int[] arr,List<int> tempList,int index,int maxLength,int target,List<IList<int>> result)
    {
        if(target == 0 && maxLength == 0)
        {
            result.Add(new List<int>(tempList));
            return;
        }
        if(maxLength <= 0 || target <= 0 || index >= arr.Length || arr[index] > target)
        {
            return;
        }
        tempList.Add(arr[index]);
        BacktrackFn(arr,tempList,index+1,maxLength-1,target-arr[index],result);
        tempList.Remove(arr[index]);
        BacktrackFn(arr,tempList,index+1,maxLength,target,result);
        return;
    }
    public IList<IList<int>> CombinationSum3Fn(int k, int n) {
        int[] candidates = [1,2,3,4,5,6,7,8,9];
        var result = new List<IList<int>>();
        var tempList = new List<int>();
        BacktrackFn(candidates,tempList,0,k,n,result);
        return result;
    }
}