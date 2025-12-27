namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Testcase Wrapper

            //var data = TwoSum.TwoSumFn(nums: [2, 7, 11, 15], 9);
            //foreach (var d in data)
            //{
            //    Console.Write(d + " ");
            //}

            //Console.WriteLine(ContainsDuplicates.ContainsDuplicate([1, 2, 3, 4]));

            //Console.WriteLine(ValidAnagrams.IsAnagram("cock", "crane"));

            //var lists = GroupAnagrams.GroupAnagramsFn(["act", "pots", "tops", "cat", "stop", "hat"]);
            //foreach (var list in lists)
            //{
            //    foreach (var l in list)
            //    {
            //        Console.Write(l + " ");
            //    }
            //    Console.WriteLine();
            //}

            //var data4 = new TopKFrequentElements();
            //var array = TopKFrequentElements.TopKFrequent([1, 1, 1, 2, 2, 3], 2);
            //foreach (var num in array)
            //{
            //    Console.Write(num + " ");
            //}

            //Console.WriteLine(EncodeAndDecode.Encode(["we", "say", ":", "yes", "!@#$%^&*()"]));
            //var decode = EncodeAndDecode.Decode("4#neet4#code4#love3#you");
            //foreach (var w in decode)
            //{
            //    Console.Write(w + " ");
            //}

            //ProductOfArraysExceptSelf.ProductExceptSelf([1, 2, 4, 6]); // TODO : Work on this sometime later

            //foreach (var d in BuildArrayFromPermutation.BuildArray([0, 2, 1, 5, 3, 4]))
            //{
            //    Console.Write(d + " ");
            //}

            //Console.WriteLine(DestinationCity.DestCity([["London", "New York"], ["New York", "Lima"], ["Lima", "Sao Paulo"]]));

            //Console.WriteLine(RemoveDuplicatesFromSortedArray.RemoveDuplicates([1, 1, 2, 2, 3, 4, 4, 5]));

            //Console.WriteLine(BestTimeToBuyAndSellStocksII.MaxProfit([7, 1, 5, 3, 6, 4]));

            //Console.WriteLine(String.Join(',',ConcatenationOfArray.GetConcatenation([1, 3, 2, 1])));
            //Console.WriteLine(String.Join(',',ConcatenationOfArray.GetConcatenation([1, 2, 1])));

            Console.WriteLine(String.Join(',', ReplaceElement_LC1299.ReplaceElements([17, 18, 5, 4, 6, 1])));
            Console.WriteLine(String.Join(',', ReplaceElement_LC1299.ReplaceElements([400])));
            
            Console.ReadKey();
        }
    }
}
