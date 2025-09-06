namespace Backtracking;

class Program
{
    static void Main(string[] args)
    {
        // var data = new CombinationSumLC();
        // List<IList<int>> result = new List<IList<int>>(data.CombinationSum([2, 3, 6, 7], 7));
        // foreach (var res in result)
        // {
        //     foreach (var r in res)
        //     {
        //         Console.Write(r + " ");
        //     }
        //     Console.WriteLine();
        // }
        // var data = new BinaryWatch();
        // var result = data.ReadBinaryWatch(1);
        // foreach (var r in result)
        // {
        //     Console.Write(r + " ");
        // }
        var data = new CombinationSum2();
        var result = data.CombinationSum2Fn([10, 1, 2, 7, 6, 1, 5], 8);
        foreach (var r in result)
        {
            Console.WriteLine(string.Join(",", r));
        }
    }
}