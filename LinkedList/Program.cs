using static LinkedList.Classes;

namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FindDuplicate.FindDuplicateFn([1,3,4,2,2]));
            Console.WriteLine(FindDuplicate.FindDuplicateFn([3,1,3,4,2]));
            Console.WriteLine(FindDuplicate.FindDuplicateFn([3,3,3,3,3]));
        }
    }
}
