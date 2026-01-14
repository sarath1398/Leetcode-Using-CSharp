using static Stack.Classes;

namespace Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(BaseBallGame.CalPoints(["5", "2", "C", "D", "+"]));
            //Console.WriteLine(BaseBallGame.CalPoints(["5", "-2", "4", "C", "D", "9", "+", "+"]));
            //Console.WriteLine(BaseBallGame.CalPoints(["1", "C"]));

            Console.WriteLine(ValidParantheses.IsValid("()"));
            Console.WriteLine(ValidParantheses.IsValid("()[]{}"));
            Console.WriteLine(ValidParantheses.IsValid("(]"));
            Console.WriteLine(ValidParantheses.IsValid("([])"));
            Console.WriteLine(ValidParantheses.IsValid("([)]"));
        }
    }
}
