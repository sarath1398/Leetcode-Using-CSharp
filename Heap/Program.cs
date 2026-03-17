using static Heap.Classes;

namespace Heap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            KthLargest kthLargest = new KthLargest(3, new int[] { 4, 5, 8, 2 });
            Console.WriteLine(kthLargest.Add(3));   // returns 4
            Console.WriteLine(kthLargest.Add(5));   // returns 5
            Console.WriteLine(kthLargest.Add(10));  // returns 5
            Console.WriteLine(kthLargest.Add(9));   // returns 8
            Console.WriteLine(kthLargest.Add(4));   // returns 8
        }
    }
}
