
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

        // var wallsAndGates = new WallsAndGatesLC286();
        // int[][] grid = [[2147483647,-1,0,2147483647],[2147483647,2147483647,2147483647,-1],[2147483647,-1,2147483647,2147483647],[0,-1,2147483647,2147483647]];
        // wallsAndGates.WallsAndGates(grid);
        // foreach(var row in grid)
        // {
        //     foreach(var cell in row)
        //     {
        //         Console.Write(cell + " ");
        //     }
        //     Console.WriteLine();
        // }

        // var orangesRotting = new OrangesRottingLC994();
        // int[][] grid = [[2,1,1],[1,1,0],[0,1,1]];
        // Console.WriteLine(orangesRotting.OrangesRotting(grid));
        // grid = [[2,1,1],[0,1,1],[1,0,1]];
        // Console.WriteLine(orangesRotting.OrangesRotting(grid));
        // grid = [[0,2]];
        // Console.WriteLine(orangesRotting.OrangesRotting(grid));

        // var pacificAtlantic = new PacificAtlanticLC417();
        // int[][] heights = [[1,2,2,3,5],[3,2,3,4,4],[6,7,1,4,5],[5,1,1,2,4],[3,3,5,8,8]];
        // var result = pacificAtlantic.PacificAtlantic(heights);
        // foreach(var row in result)
        // {
        //     foreach(var cell in row)
        //     {
        //         Console.Write(cell + " ");
        //     }
        //     Console.WriteLine();
        // }

        var surroundedRegions = new SurroundedRegionsLC130();
        char[][] board = [['X','X','X','X'],['X','O','O','X'],['X','X','O','X'],['X','O','X','X']];
        surroundedRegions.Solve(board);
        foreach(var row in board)
        {
            foreach(var cell in row)
            {
                Console.Write(cell + " ");
            }
            Console.WriteLine();
        }
    }
}
