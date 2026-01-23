namespace Arrays
{
    // Leetcode : 1299 - Replace Elements with Greatest Element on Right Side
    // Approach : Reverse Iteration
    // Time Complexity : O(n)
    // Space Complexity : O(1)
    // Type: Easy
    public class ReplaceElement_LC1299
    {

        public static int[] ReplaceElements(int[] arr)
        {
            // Initial solution - Takes O(n) space complexity

            // int n = arr.Length;
            // int[] res = new int[n];
            // res[n-1] = -1;
            // int rmax = -1;
            // for(int i=n-1;i>0;i--)
            // {
            //     rmax = Math.Max(rmax,arr[i]);
            //     res[i-1] = rmax;
            // }
            // return res;

            // O(n) time complexity with O(1) space
            int n = arr.Length;
            int currMax = 0;
            int rMax = -1;
            for (int i = n - 1; i >= 0; i--)
            {
                currMax = Math.Max(arr[i], rMax);
                arr[i] = rMax;
                rMax = currMax;
            }
            return arr;
        }
    }
}
