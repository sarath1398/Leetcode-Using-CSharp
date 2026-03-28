
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

        // var findTheTownJudge = new FindTheTownJudgeLC997();
        // int n = 2;
        // int[][] trust = [[1,2]];
        // Console.WriteLine(findTheTownJudge.FindJudge(n, trust));
        // n = 3;
        // trust = [[1,3],[2,3]];
        // Console.WriteLine(findTheTownJudge.FindJudge(n, trust));
        // n = 3;
        // trust = [[1,3],[2,3],[3,1]];
        // Console.WriteLine(findTheTownJudge.FindJudge(n, trust));

        // var numberOfIslands = new NumberOfIslandsLC200();
        // char[][] grid = [['1','1','1','1','0'],['1','1','0','1','0'],['1','1','0','0','0'],['0','0','0','0','0']];
        // Console.WriteLine(numberOfIslands.NumIslands(grid));
        // grid = [['1','1','0','0','0'],['1','1','0','0','0'],['0','0','1','0','0'],['0','0','0','1','1']];
        // Console.WriteLine(numberOfIslands.NumIslands(grid));

        var wallsAndGates = new WallsAndGatesLC286();
        int[][] grid = [[2147483647,-1,0,2147483647],[2147483647,2147483647,2147483647,-1],[2147483647,-1,2147483647,2147483647],[0,-1,2147483647,2147483647]];
        wallsAndGates.WallsAndGates(grid);
        foreach(var row in grid)
        {
            foreach(var cell in row)
            {
                Console.Write(cell + " ");
            }
            Console.WriteLine();
        }
    }
}
