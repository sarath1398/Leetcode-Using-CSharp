namespace Backtracking;

    // Leetcode : 39 - Combination Sum
    // Approach : Backtracking
    // Time Complexity : O(2^n)
    // Space Complexity : O(n)
    // Type: Medium
    public class CombinationSumLC
{
        public void findAllCombinations(int[] arr, int n, int target, List<int> auxArray,int index,ref List<IList<int>> allSolutions)
        {
            if(target < 0 || index >= n )
            {
                return;
            }
            if(target == 0)
            {
                allSolutions.Add(new List<int>(auxArray));
                return;
            }
            auxArray.Add(arr[index]);
            findAllCombinations(arr,n,target-arr[index],auxArray,index,ref allSolutions);
            auxArray.RemoveAt(auxArray.Count()-1);
            findAllCombinations(arr,n,target,auxArray,index+1,ref allSolutions);
            return;
        }
    
        public IList<IList<int>> CombinationSum(int[] candidates, int target) {
            List<int> auxArray = new();
            List<IList<int>> allSolutions = new();
            findAllCombinations(candidates,candidates.Length,target,auxArray,0,ref allSolutions);
            return allSolutions;
        }
}