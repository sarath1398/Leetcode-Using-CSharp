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

        // Leetcode : 875 - Koko Eating Bananas
        // Approach : Binary Search
        // Time Complexity : O(nlogn)
        // Space Complexity : O(1)
        // Type: Easy
        public class KokoEatingBananas {
            // Helper function to check if koko can eat all piles within h hours at k bananas per hour speed
            public static bool IsPileEatable(int[] piles,int h,int k)
            {
                foreach (int pile in piles)
                {
                    h -= (int)Math.Ceiling((double)pile / k);
                    if (h < 0) return false;
                }
                
                return true;
            }
            public static int MinEatingSpeed(int[] piles, int h) {
                int maxPile = -1;
                foreach(int pile in piles)
                {
                    maxPile = Math.Max(maxPile,pile);
                }
                // search space - [1,...,maxPile]
                int start = 1;
                int end = maxPile;
                int k = maxPile;
                while(start <= end)
                {
                    int mid = start + (end-start) / 2;
                    bool isEatable = IsPileEatable(piles,h,mid);
                    if(isEatable == true)
                    {
                        // assign smaller value to k till the start and end cross each other
                        end = mid - 1;
                        k = Math.Min(k,mid);
                    }
                    else
                    {
                        // if not eatable, then increase the speed
                        start = mid + 1;
                    }
                }
                return k;
            }
        }

        // Leetcode : 1011 - Capacity To Ship Packages In N Days
        // Approach : Binary Search
        // Time Complexity : O(nlogn)
        // Space Complexity : O(1)
        // Type: Medium
        public class ShipWithinDays {
            public static bool IsShippable(int[] weights, int days, int capacity)
            {
                int usedDays = 1;
                int currentLoad = 0;

                foreach (int w in weights)
                {
                    if (currentLoad + w > capacity)
                    {
                        usedDays++;
                        currentLoad = 0;
                    }
                    currentLoad += w;
                }
                return usedDays <= days;
            }

            public static int ShipWithinDaysFn(int[] weights, int days) {
                int start = 0;
                int sum = 0;
                int n = weights.Length;
                foreach(int weight in weights)
                {
                    start = Math.Max(start,weight);
                    sum+=weight;
                }
                int end = sum;
                int leastWeight = sum;
                while(start <= end)
                {
                    int mid = start + (end - start) / 2;
                    bool isShippable = IsShippable(weights,days,mid);
                    if(isShippable)
                    {
                        leastWeight = Math.Min(leastWeight,mid);
                        end = mid - 1;
                    }
                    else
                    {
                        start = mid + 1;
                    }
                }
                return leastWeight;
            }
        }

        // Leetcode : 153 - Find Minimum in Rotated Sorted Array
        // Approach : Binary Search
        // Time Complexity : O(logn)
        // Space Complexity : O(1)
        // Type: Medium
        public class FindMinRotatedSortedArray
        {
            public static int FindMin(int[] nums)
            {
                // search space - [0,...,n-1]
                int start = 0;
                int n = nums.Length;
                int end = n - 1;
                int result = int.MaxValue;
                while (start <= end)
                {
                    int mid = start + (end - start) / 2;
                    // if left subarray [start...mid] is sorted then move to right subarray
                    if (nums[start] <= nums[mid])
                    {
                        // store the smaller value
                        result = Math.Min(result, nums[start]);
                        start = mid + 1;
                    }
                    // if right subarray [mid...end] is sorted then move to left subarray with smaller value
                    else
                    {
                        // store the smaller value
                        result = Math.Min(result, nums[mid]);
                        end = mid - 1;
                    }
                }
                return result;
            }
        }

        // Leetcode : 33 - Search in Rotated Sorted Array
        // Approach : Binary Search
        // Time Complexity : O(logn)
        // Space Complexity : O(1)
        // Type: Medium
        public class SearchRotatedSortedArray {
            public static int Search(int[] nums, int target) {
                int start = 0;
                int n = nums.Length;
                int end = n - 1;
                while(start <= end)
                {
                    int mid = start + (end - start) / 2;
                    if(nums[mid] == target)
                    {
                        return mid;
                    }
                    // left subarray is sorted
                    if(nums[mid] >= nums[start])
                    {   
                        // check if target is within the sorted array
                        if(target >= nums[start] && target <= nums[mid])
                        {   
                            end = mid - 1;
                            continue;
                        }
                        else
                        {
                            start = mid + 1;
                            continue;
                        }
                    }
                    // right subarray is sorted
                    else
                    {
                        // check if target is within the sorted array
                        if(target >= nums[mid] && target <= nums[end])
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
                }
                return -1;
            }
        }


        // Leetcode : 81 - Search in Rotated Sorted Array II
        // Approach : Binary Search
        // Time Complexity : O(logn)
        // Space Complexity : O(1)
        // Type: Medium
        public class SearchRotatedSortedArrayII {
            public static bool Search(int[] nums, int target) {
                int start = 0;
                int n = nums.Length;
                int end = n - 1;
                while(start <= end)
                {
                    int mid = start + (end - start) / 2;
                    if(nums[mid] == target)
                    {
                        return true;
                    }
                    // reduce the search space from both the ends if the
                    // value has overflowed from the end to start and target is not start 
                    else if(nums[start] == nums[end] && target != nums[start])
                    {
                        start++;
                        end--;
                    }
                    // left subarray is sorted
                    else if(nums[mid] >= nums[start])
                    {   
                        // check if target is within the sorted array
                        if(target >= nums[start] && target <= nums[mid])
                        {   
                            end = mid - 1;
                            continue;
                        }
                        else
                        {
                            start = mid + 1;
                            continue;
                        }
                    }
                    // right subarray is sorted
                    else
                    {
                        // check if target is within the sorted array
                        if(target >= nums[mid] && target <= nums[end])
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
                }
                return false;
            }
        }
        
        // Leetcode : 981 - Time Based Key-Value Store
        // Approach : Binary Search
        // Time Complexity : O(logn)
        // Space Complexity : O(1)
        // Type: Medium
        public class TimeMap {
            readonly Dictionary<string,List<(string value, int timestamp)>> timeMap;

            public TimeMap() {
                timeMap = [];
            }

            public void Set(string key, string value, int timestamp) {
                if(!timeMap.TryGetValue(key, out List<(string value, int timestamp)>? value1))
                {
                    List<(string value, int timestamp)> list = [];
                    value1 = list;
                    timeMap.Add(key, value1);
                }

                value1.Add((value,timestamp));
            }

            public string Get(string key, int timestamp) {
                
                if (!timeMap.ContainsKey(key)) {
                    return "";
                }

                var searchList = timeMap[key];
                int start = 0;
                int end = searchList.Count - 1;
                string result = "";
                while(start <= end)
                {
                    int mid = start + (end - start) / 2;
                    var searchVal = searchList[mid];
                    if(searchVal.timestamp <= timestamp)
                    {
                        result = searchVal.Item1;
                        start = mid + 1;
                    }
                    else
                    {
                        end = mid - 1;
                    }
                }
                return result;
            }
        }

        // Leetcode : 410 - Split Array Largest Sum
        // Approach : Binary Search
        // Time Complexity : O(nlogn)
        // Space Complexity : O(1)
        // Type: Medium
        public class SplitArrayLargestSum
        {
            public static bool CanSplit(int[] arr, int splits, int capacity)
            {
                int c = 0;
                int index = 0;
                while (index < arr.Length)
                {
                    // add a number to current sum and check if it is greater than capacity
                    c += arr[index];
                    if (c > capacity)
                    {
                        // if it is greater than capacity, decrement the number of splits
                        // and reset the current sum to current number
                        splits--;
                        c = arr[index];
                    }
                    index++;
                }
                // If the final split is within capacity then the number of splits will be atleast 1.
                // Hence the strictly greater than 0 condition
                return splits > 0;
            }
            public static int SplitArray(int[] nums, int k)
            {
                // The search space will be [minValue, sum] since the minimum possible subarray is a single element with maximum value
                // and the maximum possible subarray is the entire array. Hence the sum of all elements.
                int start = int.MinValue;
                int end = 0;
                foreach (int num in nums)
                {
                    end += num;
                    start = Math.Max(start, num);
                }
                int result = int.MaxValue;
                while (start <= end)
                {
                    int max = start + (end - start) / 2;
                    // Check if the current capacity can be split into k subarrays
                    if (CanSplit(nums, k, max))
                    {
                        // If it can be split, update the result and try to find a smaller capacity
                        result = Math.Min(result, max);
                        end = max - 1;
                    }
                    else
                    {
                        // If it cannot be split, try to find a larger capacity from our assumption
                        start = max + 1;
                    }
                }
                return result;
            }
        }

        // Leetcode : 4 - Median of Two Sorted Arrays
        // Approach : Binary Search
        // Time Complexity : O(log(min(n1,n2)))
        // Space Complexity : O(1)
        // Type: Hard
        public class MedianOfTwoSortedArrays
        {
            public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
            {
                // Ensure nums1 is the smaller array to optimize the binary search range
                if (nums1.Length > nums2.Length)
                {
                    (nums1, nums2) = (nums2, nums1);
                }
                int n1 = nums1.Length;
                int n2 = nums2.Length;
                int total = n1 + n2;
                int half = (total + 1) / 2;
                int start = 0;
                int end = n1;

                while (start <= end)
                {
                    // Find the middle of the first array
                    int mid = start + (end - start) / 2;
                    // Find the middle of the second array
                    int sHalf = half - mid;
                    // Get the left and right elements of the first array
                    int left1 = mid > 0 ? nums1[mid - 1] : int.MinValue;
                    int right1 = mid < n1 ? nums1[mid] : int.MaxValue;
                    // Get the left and right elements of the second array
                    int left2 = sHalf > 0 ? nums2[sHalf - 1] : int.MinValue;
                    int right2 = sHalf < n2 ? nums2[sHalf] : int.MaxValue;
                    // we compare the left1+left2 array with the right1+right2 array
                    // check if the max element in the right is greater than the min element in the left
                    // and if the min element in the left is greater than the max element in the right
                    if (left1 <= right2 && left2 <= right1)
                    {
                        // if the total number of elements is even, the median is the average of the maximum of the left elements and the minimum of the right elements
                        if (total % 2 == 0)
                        {
                            return (Math.Min(right2, right1) + Math.Max(left1, left2)) / 2.0;
                        }
                        // if the total number of elements is odd, the median is the maximum of the left elements
                        return Math.Max(left1, left2);
                    }
                    else if (left1 > right2)
                    {
                        end = mid - 1;
                    }
                    else
                    {
                        start = mid + 1;
                    }
                }
                return -1;
            }
        }
    }
}
