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

            //Console.WriteLine(ValidParantheses.IsValid("()"));
            //Console.WriteLine(ValidParantheses.IsValid("()[]{}"));
            //Console.WriteLine(ValidParantheses.IsValid("(]"));
            //Console.WriteLine(ValidParantheses.IsValid("([])"));
            //Console.WriteLine(ValidParantheses.IsValid("([)]"));

            //Console.WriteLine(EvaluateReversePolishNotation.EvalRPN(["2", "1", "+", "3", "*"]));
            //Console.WriteLine(EvaluateReversePolishNotation.EvalRPN(["4", "13", "5", "/", "+"]));
            //Console.WriteLine(EvaluateReversePolishNotation.EvalRPN(["10", "6", "9", "3", "+", "-11", "*", "/", "*", "17", "+", "5", "+"]));

            // Console.WriteLine("[" + string.Join(", ", AsteroidCollisionProblem.AsteroidCollision([5, 10, -5])) + "]");
            // Console.WriteLine("[" + string.Join(", ", AsteroidCollisionProblem.AsteroidCollision([8, -8])) + "]");
            // Console.WriteLine("[" + string.Join(", ", AsteroidCollisionProblem.AsteroidCollision([10, 2, -5])) + "]");
            // Console.WriteLine("[" + string.Join(", ", AsteroidCollisionProblem.AsteroidCollision([3, 5, -6, 2, -1, 4])) + "]");

            // Console.WriteLine("[" + string.Join(", ", DailyTemperatures.DailyTemperaturesFn([73, 74, 75, 71, 69, 72, 76, 73])) + "]");
            // Console.WriteLine("[" + string.Join(", ", DailyTemperatures.DailyTemperaturesFn([30, 40, 50, 60])) + "]");
            // Console.WriteLine("[" + string.Join(", ", DailyTemperatures.DailyTemperaturesFn([30, 60, 90])) + "]");

            // Console.WriteLine(CarFleet.CarFleetFn(12, [10,8,0,5,3], [2,4,1,1,3]));
            // Console.WriteLine(CarFleet.CarFleetFn(10, [3], [3]));
            // Console.WriteLine(CarFleet.CarFleetFn(100, [0,2,4], [4,2,1]));

            // Console.WriteLine(SimplifyPath.SimplifyPathFn("/home/"));
            // Console.WriteLine(SimplifyPath.SimplifyPathFn("/home//foo/"));
            // Console.WriteLine(SimplifyPath.SimplifyPathFn("/home/user/Documents/../Pictures"));
            // Console.WriteLine(SimplifyPath.SimplifyPathFn("/../"));
            // Console.WriteLine(SimplifyPath.SimplifyPathFn("/.../a/../b/c/../d/./"));

            Console.WriteLine(DecodeString.DecodeStringFn("3[a]2[bc]"));
            Console.WriteLine(DecodeString.DecodeStringFn("3[a2[c]]"));
            Console.WriteLine(DecodeString.DecodeStringFn("2[abc]3[cd]ef"));
        }
    }
}
