namespace Binary_Search
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(BinarySearch.SearchFn(new int[] { -1, 0, 3, 5, 9, 12 }, 9));
            Console.WriteLine(BinarySearch.SearchFn(new int[] { -1, 0, 3, 5, 9, 12 }, 2));
        }
    }
}
