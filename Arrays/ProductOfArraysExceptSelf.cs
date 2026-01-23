namespace Arrays
{
    // Leetcode : 238 - Product of Array Except Self
    // Approach : Prefix and Suffix Products
    // Time Complexity : O(n)
    // Space Complexity : O(1)
    // Type: Medium
    public class ProductOfArraysExceptSelf
    {
        public static int[] ProductExceptSelf(int[] nums)
        {
            int n = nums.Length;
            //int[] prefixProduct = new int[n];
            //int[] suffixProduct = new int[n];
            int[] result = new int[n];

            // Build prefix
            // prefixProduct[0] = nums[0];
            // for (int i = 1; i < n; i++) {
            //     prefixProduct[i] = prefixProduct[i - 1] * nums[i];
            // }

            // Build Prefix
            result[0] = 1;
            for (int i = 1; i < n; i++)
            {
                result[i] = result[i - 1] * nums[i - 1];
            }

            // Build suffix
            // suffixProduct[n - 1] = nums[n - 1];
            // for (int i = n - 1; i >= 0; i--) {
            //     suffixProduct[i] = suffixProduct[i + 1] * nums[i];
            // }

            // Build Suffix
            int suffix = 1;
            for (int i = n - 1; i >= 0; i--)
            {
                result[i] *= suffix;
                suffix *= nums[i];
            }


            // // Build result
            // for (int i = 0; i < n; i++) {
            //     int left = (i == 0) ? 1 : prefixProduct[i - 1];
            //     int right = (i == n - 1) ? 1 : suffixProduct[i + 1];
            //     result[i] = left * right;
            // }
            return result;
        }
    }
}