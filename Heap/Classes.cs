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
    }
}
