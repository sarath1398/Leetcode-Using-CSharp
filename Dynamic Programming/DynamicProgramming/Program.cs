namespace DynamicProgramming;

public class Program
{
    static void Main(string[] args)
    {
        // var data = new MinimumCostClimbingStairs();
        // Console.WriteLine(data.MinCostClimbingStairs([1,100,1,1,1,100,1,1,100,1]));
        // var data = new ClimbingStairs();
        // Console.WriteLine(data.ClimbStairs(3));
        var data = new CoinChange();
        Console.WriteLine(data.CoinChangeFn([1,2,5],11));
    }
}