using static Sliding_Window.Classes;

class Program
{
    static void Main(string[] args)
    {
        // var data = new DefuseTheBomb();
        // foreach (var d in data.Decrypt([5, 7, 1, 4], 3))
        // {
        //     Console.Write(d + " ");
        // }

        // Console.WriteLine(ContainsDuplicateII.ContainsNearbyDuplicate([1,2,3,1], 3));
        // Console.WriteLine(ContainsDuplicateII.ContainsNearbyDuplicate([1,0,1,1], 1));
        // Console.WriteLine(ContainsDuplicateII.ContainsNearbyDuplicate([1,2,3,1,2,3], 2));

        Console.WriteLine(BestTimeToBuyAndSellStock.MaxProfit([7,1,5,3,6,4]));
        Console.WriteLine(BestTimeToBuyAndSellStock.MaxProfit([7,6,4,3,1]));
    }
}