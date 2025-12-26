namespace Arrays
{
    public class ProductOfArraysExceptSelf
    {
        public static int[] ProductExceptSelf(int[] nums)
        {
            int n = nums.Length;
            int sum = 1;
            int[] result = new int[n];
            result[0] = 1;
            for (int i = 1; i < n; i++)
            {
                result[i] = result[i - 1] * nums[i - 1];
            }
            for (int j = n - 1; j >= 0; j--)
            {
                result[j] *= sum;
                sum *= nums[j];
            }

            return result;
        }
    }
}