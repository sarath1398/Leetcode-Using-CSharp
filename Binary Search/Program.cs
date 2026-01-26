using static Binary_Search.Classes;

namespace Binary_Search
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine(BinarySearch.Search([-1, 0, 3, 5, 9, 12], 9));
            // Console.WriteLine(BinarySearch.Search([-1, 0, 3, 5, 9, 12], 2));

            //Console.WriteLine(SearchInsertPosition.SearchInsert([1, 3, 5, 6], 5));
            //Console.WriteLine(SearchInsertPosition.SearchInsert([1, 3, 5, 6], 2));
            //Console.WriteLine(SearchInsertPosition.SearchInsert([1, 3, 5, 6], 7));

            // GuessNumber.PICK = 6;
            // Console.WriteLine(GuessNumber.GuessNumberFn(10));
            // GuessNumber.PICK = 1;
            // Console.WriteLine(GuessNumber.GuessNumberFn(1));
            // Console.WriteLine(GuessNumber.GuessNumberFn(2));

            // Console.WriteLine(Sqrt.MySqrt(4));
            // Console.WriteLine(Sqrt.MySqrt(8));

            // Console.WriteLine(Search2DMatrix.SearchMatrix([[1,3,5,7],[10,11,16,20],[23,30,34,60]],3));
            // Console.WriteLine(Search2DMatrix.SearchMatrix([[1,3,5,7],[10,11,16,20],[23,30,34,60]],13));

            Console.WriteLine(KokoEatingBananas.MinEatingSpeed([3,6,7,11],8));
            Console.WriteLine(KokoEatingBananas.MinEatingSpeed([30,11,23,4,20],5));
            Console.WriteLine(KokoEatingBananas.MinEatingSpeed([30,11,23,4,20],6));
        }
    }
}
