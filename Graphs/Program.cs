
using static Graphs.Classes;

namespace Graphs;
internal class Program
{
    static void Main(string[] args)
    {
        var islandPerimeter = new IslandPerimeterLC463();
        int[][] grid = [[0,1,0,0],[1,1,1,0],[0,1,0,0],[1,1,0,0]];
        Console.WriteLine(islandPerimeter.IslandPerimeter(grid));
        grid = [[1]];
        Console.WriteLine(islandPerimeter.IslandPerimeter(grid));
        grid = [[1,0]];
        Console.WriteLine(islandPerimeter.IslandPerimeter(grid));
    }
}
