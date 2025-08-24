namespace TwoPointers;

class Program
{
    static void Main(string[] args)
    {
        var twoSum = new TwoSum2();
        foreach (var index in twoSum.TwoSum([2,7,11,15],9))
        {
            Console.Write(index + " ");            
        }
    }
}
