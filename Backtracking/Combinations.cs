namespace Backtracking;

public class Combinations
{
    public void Backtrack(int n,int count, int start, List<int> tempList, List<IList<int>> results)
    {
        if(count == 0)
        {
            results.Add(new List<int>(tempList));
            return;
        }
        if(count < 0 || start > n)
        {
            return;
        }
        for(int i=start+1; i<=n;i++)
        {
            tempList.Add(i);
            Backtrack(n,count-1,i,tempList,results);
            tempList.RemoveAt(tempList.Count()-1);
        }
        return;
    }
    public IList<IList<int>> Combine(int n, int k) {
        List<int> tempList = new();
        int start = 0;
        List<IList<int>> results = new();
        Backtrack(n,k,start,tempList,results);
        return results;
    }
}