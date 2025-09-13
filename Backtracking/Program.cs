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
        // var data = new CombinationSum2();
        // var result = data.CombinationSum2Fn([10, 1, 2, 7, 6, 1, 5], 8);
        // foreach (var r in result)
        // {
        //     Console.WriteLine(string.Join(",", r));
        // }
        // var data = new CombinationSum3();
        // var result = data.CombinationSum3Fn(3, 8);
        // foreach (var r in result)
        // {
        //     Console.WriteLine(string.Join(",", r));
        // }
        // var data = new Combinations();
        // var results = data.Combine(4, 2);
        // foreach (var result in results)
        // {
        //     Console.WriteLine(string.Join(',',result));
        // }
        // var data = new Subsets1();
        // var results = data.Subsets([1,2,3]);
        // foreach (var result in results)
        // {
        //     Console.WriteLine(string.Join(',',result));
        // }
        // var data = new Subsets2();
        // var results = data.SubsetsWithDup([1,2,2]);
        // foreach (var result in results)
        // {
        //     Console.WriteLine(string.Join(',',result));
        // }
        var data = new TargetSum();
        Console.WriteLine(data.FindTargetSumWays([1, 1, 1, 1, 1], 3));
    }
}