namespace TwoPointers;

class Program
{
    static void Main(string[] args)
    {
        //var twoSum = new TwoSum2();
        //foreach (var index in twoSum.TwoSum([2,7,11,15],9))
        //{
        //    Console.Write(index + " ");            
        //}

        //ReverseStringLC344.ReverseString(['h', 'e', 'l', 'l', 'o']);
        //ReverseStringLC344.ReverseString(['H', 'a', 'n', 'n', 'a', 'h']);

        //Console.WriteLine(ValidPalindrome.IsPalindrome("A man, a plan, a canal: Panama"));
        //Console.WriteLine(ValidPalindrome.IsPalindrome("race a car"));
        //Console.WriteLine(ValidPalindrome.IsPalindrome(" "));

        //Console.WriteLine(ValidPalindromeII.ValidPalindrome("aba"));
        //Console.WriteLine(ValidPalindromeII.ValidPalindrome("abca"));
        //Console.WriteLine(ValidPalindromeII.ValidPalindrome("abc"));

        //Console.WriteLine(MergeStringsAlternatively.MergeAlternately("abc", "pqr"));
        //Console.WriteLine(MergeStringsAlternatively.MergeAlternately("ab","pqrs"));
        //Console.WriteLine(MergeStringsAlternatively.MergeAlternately("abcd","pq"));

        //MergeSortedArray.Merge([1, 2, 3, 0, 0, 0], 3, [2, 5, 6], 3);
        //MergeSortedArray.Merge([1], 1, [], 0);
        //MergeSortedArray.Merge([0], 0, [1], 1);

        //Console.WriteLine(RemoveDuplicatesFromSorted.RemoveDuplicates([1, 1, 2]));
        //Console.WriteLine(RemoveDuplicatesFromSorted.RemoveDuplicates([0, 0, 1, 1, 1, 2, 2, 3, 3, 4]));

        foreach (var result in ThreeSum.ThreeSumFn([-1, 0, 1, 2, -1, -4]))
        {
            Console.WriteLine(string.Join(',', result));

        }
        foreach (var result in ThreeSum.ThreeSumFn([0, 1, 1]))
        {
            Console.WriteLine(string.Join(',', result));
        }
        foreach (var result in ThreeSum.ThreeSumFn([0, 0, 0]))
        {
            Console.WriteLine(string.Join(',', result));
        }
    }
}
