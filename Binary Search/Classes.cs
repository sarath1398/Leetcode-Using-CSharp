namespace Binary_Search
{
    internal class Classes
    {
        // Leetcode : 704 - Binary Search
        // Approach : Binary Search
        // Time Complexity : O(logn)
        // Space Complexity : O(1)
        // Type: Easy
        public class BinarySearch
        {
            public static int Search(int[] nums, int target)
            {
                int start = 0;
                int end = nums.Length - 1;
                while (start <= end)
                {
                    int mid = start + (end - start) / 2;
                    if (nums[mid] == target)
                    {
                        return mid;
                    }
                    else if (nums[mid] < target)
                    {
                        start = mid + 1;
                        continue;
                    }
                    else if (nums[mid] > target)
                    {
                        end = mid - 1;
                        continue;
                    }
                }
                return -1;
            }
        }
    }
}
