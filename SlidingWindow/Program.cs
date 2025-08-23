namespace Sliding_Window;

class Program
{
    static void Main(string[] args)
    {
        var data = new DefuseTheBomb();
        foreach (var d in data.Decrypt([5, 7, 1, 4], 3))
        {
            Console.Write(d + " ");
        }
    }
}