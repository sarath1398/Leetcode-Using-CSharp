namespace Heap
{
    internal class Classes
    {
        // Leetcode : 703 - Kth Largest Element in a Stream
        // Approach : Min Heap
        // Time Complexity : O(n log k)
        // Space Complexity : O(k)
        // Type: Easy
        public class KthLargest
        {
            // Min Heap to store the k largest elements
            private PriorityQueue<int, int> heap = new();
            // Size of the heap
            private readonly int k = 0;

            public KthLargest(int k, int[] nums)
            {
                // Initialize the heap size
                this.k = k;
                // Add the initial elements to the heap
                foreach (int num in nums)
                {
                    heap.Enqueue(num, num);
                    // If the heap size exceeds k, remove the smallest element
                    if (heap.Count > k)
                    {
                        heap.Dequeue();
                    }
                }
            }

            public int Add(int val)
            {
                // Add the new element to the heap
                heap.Enqueue(val, val);
                // If the heap size exceeds k, remove the smallest element
                if (heap.Count > k)
                {
                    heap.Dequeue();
                }
                // Return the smallest element in the heap
                return heap.Peek();
            }
        }

        // Leetcode - 1046 - Last Stone Weight
        // Approach : Max Heap
        // Time Complexity : O(n log n)
        // Space Complexity : O(n)
        // Type: Easy
        public class LastStoneWeightLC1046 {
            public int LastStoneWeight(int[] stones) {
                PriorityQueue<int,int> queue = new();

                // Add all stones into heap. Used negative values
                // since max heap relies on negative values
                foreach(var stone in stones)
                {
                    queue.Enqueue(-stone,-stone);
                }

                while(queue.Count >= 0)
                {
                    int x = -1,y = -1;
                    // max element
                    if(queue.Count > 0)
                    {
                        y = -queue.Dequeue();
                    }
                    // second max element
                    if(queue.Count > 0)
                    {
                        x = -queue.Dequeue();
                    }
                    // if no elements exist in queue
                    if(x == -1 && y == -1)
                    {
                        return 0;
                    }
                    // if only one element exists
                    else if(x == -1)
                    {
                        return y;
                    }
                    // if x is lesser than y, then it's implied that stone x will break
                    /// and stone y-x will be added
                    else if(x < y)
                    {
                        queue.Enqueue(x - y, x - y); // since -(y-x) = (x-y)
                    }
                    // Note : Haven't handled x == y case since the x and y values 
                    // are dequeued already and x > y doesn't happen
                }

                // return added as a formality. The while loop handles all scenarios
                return -1;
            }
        }

        // Leetcode - 973 - K Closest Points to Origin
        // Approach : Min Heap
        // Time Complexity : O(n log n)
        // Space Complexity : O(n)
        // Type: Medium
        public class KClosestLC973 {
            public int[][] KClosest(int[][] points, int k) {
                PriorityQueue<(int x, int y),double> queue = new();
                // add all points into the queue
                foreach(var point in points)
                {
                    int x = point[0];
                    int y = point[1];
                    // calculate distance from origin
                    double distance = (double)Math.Sqrt(Math.Pow(x,2) + Math.Pow(y,2));
                    queue.Enqueue((x,y),distance);
                }
                // create result array
                int[][] result = new int[k][];
                // dequeue the k closest points
                for(int i = 0; i < k; i++)
                {
                    (int x, int y) = queue.Dequeue();
                    result[i] = new int[] {x,y};
                }
                return result;
            }
        }


        // Leetcode - 215 - Find the Kth Largest Element in an Array
        // Approach : Max Heap
        // Time Complexity : O(n log n)
        // Space Complexity : O(n)
        // Type: Medium
        public class FindKthLargestLC215 {
            public int FindKthLargest(int[] nums, int k) {
                PriorityQueue<int,int> queue = new();
                // create a max heap
                foreach(int n in nums)
                {
                    queue.Enqueue(-n,-n);
                }
                // pop the top k-1 elements
                for(int i = 0; i < k - 1;i++)
                {
                    queue.Dequeue();
                }
                // return the kth element in the queue
                int val = -queue.Peek();
                return val;
            }
        }
    }
}
