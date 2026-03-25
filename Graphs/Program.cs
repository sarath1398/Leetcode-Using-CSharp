
using static Graphs.Classes;

namespace Graphs;
internal class Program
{
    static void Main(string[] args)
    {
    //     var islandPerimeter = new IslandPerimeterLC463();
    //     int[][] grid = [[0,1,0,0],[1,1,1,0],[0,1,0,0],[1,1,0,0]];
    //     Console.WriteLine(islandPerimeter.IslandPerimeter(grid));
    //     grid = [[1]];
    //     Console.WriteLine(islandPerimeter.IslandPerimeter(grid));
    //     grid = [[1,0]];
    //     Console.WriteLine(islandPerimeter.IslandPerimeter(grid));

        var findTheTownJudge = new FindTheTownJudgeLC997();
        int n = 2;
        int[][] trust = [[1,2]];
        Console.WriteLine(findTheTownJudge.FindJudge(n, trust));
        n = 3;
        trust = [[1,3],[2,3]];
        Console.WriteLine(findTheTownJudge.FindJudge(n, trust));
        n = 3;
        trust = [[1,3],[2,3],[3,1]];
        Console.WriteLine(findTheTownJudge.FindJudge(n, trust));
    }
}
