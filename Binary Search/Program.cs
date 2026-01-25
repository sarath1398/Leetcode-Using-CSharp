using static Binary_Search.Classes;

namespace Binary_Search
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine(BinarySearch.Search([-1, 0, 3, 5, 9, 12], 9));
            // Console.WriteLine(BinarySearch.Search([-1, 0, 3, 5, 9, 12], 2));

            Console.WriteLine(SearchInsertPosition.SearchInsert(new int[] { 1, 3, 5, 6 }, 5));
            Console.WriteLine(SearchInsertPosition.SearchInsert(new int[] { 1, 3, 5, 6 }, 2));
            Console.WriteLine(SearchInsertPosition.SearchInsert(new int[] { 1, 3, 5, 6 }, 7));
        }
    }
}
