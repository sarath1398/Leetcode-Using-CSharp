using static Heap.Classes;

namespace Heap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // KthLargest kthLargest = new KthLargest(3, [4, 5, 8, 2]);
            // Console.WriteLine(kthLargest.Add(3));   // returns 4
            // Console.WriteLine(kthLargest.Add(5));   // returns 5
            // Console.WriteLine(kthLargest.Add(10));  // returns 5
            // Console.WriteLine(kthLargest.Add(9));   // returns 8
            // Console.WriteLine(kthLargest.Add(4));   // returns 8

            // LastStoneWeightLC1046 lastStoneWeight = new LastStoneWeightLC1046();
            // Console.WriteLine(lastStoneWeight.LastStoneWeight([2,7,4,1,8,1]));

            // KClosestLC973 kClosest = new KClosestLC973();
            // int[][] points = [[1,3],[-2,2]];
            // int k = 1;
            // int[][] result = kClosest.KClosest(points,k);
            // foreach(var point in result)
            // {
            //     Console.WriteLine(point[0] + " " + point[1]);
            // }   

            var findKthLargest = new FindKthLargestLC215();
            int[] nums = [3,2,1,5,6,4];
            int k = 2;
            int result = findKthLargest.FindKthLargest(nums,k);
            Console.WriteLine(result);
        }
    }
}
