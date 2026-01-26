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

        // Leetcode : 374 - Guess Number Higher or Lower
        // Approach : Binary Search
        // Time Complexity : O(logn)
        // Space Complexity : O(1)
        // Type: Easy

        // Optional implementation of Guess method for better clarity
        public class GuessGame {
            public static int PICK = 0;
            public static int guess(int num) {
                if (num < PICK) return 1;
                else if (num > PICK) return -1;
                else return 0;

            }
        }

        // Leetcode solution starts here
        public class GuessNumber : GuessGame {
            public static int GuessNumberFn(int n) {
                int start = 1;
                int end = n;

                while(start <= end)
                {
                    int mid = start + (end - start) / 2;
                    int val = guess(mid);
                    if (val == 0)
                    {
                        return mid;
                    }
                    else if (val == 1)
                    {
                        start = mid + 1;
                    }
                    else
                    {
                        end = mid - 1;
                    }
                }
                
                // code never reaches here
                return -1;
            }
        }

        // Leetcode : 69 - Sqrt(x)
        // Approach : Binary Search
        // Time Complexity : O(logn)
        // Space Complexity : O(1)
        // Type: Easy
        public class Sqrt
        {
            public static int MySqrt(int x)
            {
                int start = 0;
                int end = x;
                int res = 0;
                while (start <= end)
                {
                    int mid = start + (end - start) / 2;
                    // Reminder : Store multiplications in long data type
                    // if you think the value might overflow
                    long guess = (long)mid * mid;
                    if (guess > x)
                    {
                        end = mid - 1;
                    }
                    else if (guess < x)
                    {
                        start = mid + 1;
                        // store approximation value here
                        res = mid;
                    }
                    else
                    {
                        return mid;
                    }
                }
                return res;
            }
        }

        // Leetcode : 74 - Search a 2D Matrix
        // Approach : Binary Search - Find the row where the target lies between start and end.
        // Then search the row for target
        // Time Complexity : O(log(m*n))
        // Space Complexity : O(1)
        // Type: Easy
        public class Search2DMatrix {
            public static bool SearchMatrix(int[][] matrix, int target) {
                int n = matrix.Length;
                int m = matrix[0].Length;

                // start and end for row
                int s1 = 0, e1 = n - 1;
                int row = 0;
                while(s1 <= e1)
                {
                    int mid1 = s1 + (e1 - s1) / 2;
                    // check if the mid1 is the row having the target in the matrix
                    if(matrix[mid1][0] <= target && matrix[mid1][m-1] >= target)
                    {
                        row = mid1;
                        break;
                    }
                    else if(matrix[mid1][0] > target)
                    {
                        e1 = mid1 - 1;
                    }
                    else
                    {
                        s1 = mid1 + 1;
                    }
                }
                // search within the row for target
                int start = 0, end = m - 1;
                while(start <= end)
                {
                    int mid = start + (end - start) / 2;
                    if(matrix[row][mid] == target)
                    {
                        return true;
                    }
                    else if(matrix[row][mid] > target)
                    {
                        end = mid - 1;
                    }
                    else
                    {
                        start = mid + 1;
                    }
                }
                return false;
            }
        }
    }
}
