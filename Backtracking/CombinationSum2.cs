namespace Backtracking;

public class CombinationSum2
{
    // TODO : Understand how the iterative version of CombinationSum2 program works.
    public void BackTrackFn(int[] arr,int n, int target,List<int> aux,int index,List<IList<int>> result)
    {
        if(target == 0)
        {
            result.Add(new List<int>(aux));
            return;
        }
        if(index >= n || target - arr[index] < 0)
        {
            return;
        }
        aux.Add(arr[index]);
        BackTrackFn(arr,n,target-arr[index],aux,index+1,result);
        aux.RemoveAt(aux.Count()-1);
        
        int nextIndex = index + 1;
        while(nextIndex < n && arr[index]==arr[nextIndex])
        {
            nextIndex++;
        }
        BackTrackFn(arr,n,target,aux,nextIndex,result);
        return;
    }
    public IList<IList<int>> CombinationSum2Fn(int[] candidates, int target) {
        List<int> auxArray = new();
        List<IList<int>> result = new List<IList<int>>();
        Array.Sort(candidates);
        BackTrackFn(candidates,candidates.Length,target,auxArray,0,result);
        return result;
    }
}