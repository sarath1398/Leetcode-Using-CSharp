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

        // Leetcode : 35 - Search Insert Position
        // Approach : Binary Search
        // Time Complexity : O(logn)
        // Space Complexity : O(1)
        // Type: Easy
        public class SearchInsertPosition
        {
            public static int SearchInsert(int[] nums, int target)
            {
                int n = nums.Length;
                int end = n - 1;
                int start = 0;
                if (target > nums[end])
                {
                    return end + 1;
                }
                else if (target < nums[start])
                {
                    return 0;
                }
                while (start <= end)
                {
                    int mid = start + (end - start) / 2;
                    if (nums[mid] == target)
                    {
                        return mid;
                    }
                    else if (nums[mid] < target && nums[mid + 1] > target)
                    {
                        return mid + 1;
                    }
                    else if (nums[mid] < target)
                    {
                        start = mid + 1;
                        continue;
                    }
                    else
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
