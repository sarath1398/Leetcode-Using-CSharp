namespace Stack
{
   public class Classes
   {
        // Leetcode : 682 - Baseball Game
        // Approach : Simulation using Stack
        // Time Complexity : O(n)
        // Space Complexity : O(n)
        // Type: Easy
        public class BaseBallGame
        {
            public static int CalPoints(string[] operations)
            {
                Stack<int> stack = new();
                int sum = 0;
                foreach (string op in operations)
                {
                    if (op != "C" && op != "D" && op != "+")
                    {
                        int value = int.Parse(op);
                        sum += value;
                        stack.Push(value);
                    }
                    else if (op == "+")
                    {
                        int op1 = stack.Pop();
                        int op2 = stack.Pop();
                        int operation = op1 + op2;
                        sum += operation;
                        stack.Push(op2);
                        stack.Push(op1);
                        stack.Push(operation);
                    }
                    else if (op == "C")
                    {
                        int value = stack.Pop();
                        sum -= value;
                    }
                    else
                    {
                        int op1 = stack.Pop();
                        int operation = 2 * op1;
                        sum += operation;
                        stack.Push(op1);
                        stack.Push(operation);
                    }
                }
                return sum;
            }
        }

        // Leetcode : 20 - Valid Parentheses
        // Approach : Stack
        // Time Complexity : O(n)
        // Space Complexity : O(n)
        // Type: Easy
        public class ValidParantheses
        {
            public static bool IsValid(string s)
            {
                Stack<char> stack = new(s.Length);
                foreach (char c in s)
                {
                    if (c == '[' || c == '(' || c == '{')
                    {
                        stack.Push(c);
                    }
                    else
                    {
                        if (stack.Count == 0)
                            return false;

                        char last = stack.Peek();
                        if (!(c == ')' && last == '(' || c == '}' && last == '{' || c == ']' && last == '['))
                        {
                            return false;
                        }
                        stack.Pop();
                    }
                }
                return stack.Count == 0;
            }
        }

        // Leetcode : 225 - Implement Stack using Queues
        // Approach : Two Queues
        // Time Complexity : O(n)
        // Space Complexity : O(n)
        // Type: Easy
        public class ImplementStackUsingTwoQueues
        {
            //TODO : Come up with a single queue solution
            public class MyStack
            {
                Queue<int> q1, q2;

                public MyStack()
                {
                    q1 = new();
                    q2 = new();
                }

                public void Push(int x)
                {
                    q2.Enqueue(x);
                    while (q1.Count > 0)
                    {
                        q2.Enqueue(q1.Dequeue());
                    }
                    (q1, q2) = (q2, q1);
                }

                public int Pop()
                {
                    return q1.Dequeue();
                }

                public int Top()
                {
                    return q1.Peek();
                }

                public bool Empty()
                {
                    return q1.Count == 0;
                }
            }
        }

        // Leetcode : 232 - Implement Queue using Stacks
        // Approach : Two Stacks
        // Time Complexity : O(n)
        // Space Complexity : O(n)
        // Type: Easy   
        public class ImplementQueueUsingTwoStacks
        {
            public class MyQueue
            {

                // TODO : Come up with an amortized O(1) time complexity solution for Peek and Pop operations

                private readonly Stack<int> s1;
                private readonly Stack<int> s2;

                public MyQueue()
                {
                    s1 = new();
                    s2 = new();
                }

                public void Push(int x)
                {
                    s1.Push(x);
                }

                public int Pop()
                {
                    while (s1.Count > 1)
                    {
                        s2.Push(s1.Pop());
                    }
                    int value = s1.Pop();
                    while (s2.Count > 0)
                    {
                        s1.Push(s2.Pop());
                    }
                    return value;
                }

                public int Peek()
                {
                    while (s1.Count > 1)
                    {
                        s2.Push(s1.Pop());
                    }
                    int value = s1.Peek();
                    while (s2.Count > 0)
                    {
                        s1.Push(s2.Pop());
                    }
                    return value;
                }

                public bool Empty()
                {
                    return s1.Count == 0;
                }
            }

            /**
             * Your MyQueue object will be instantiated and called as such:
             * MyQueue obj = new MyQueue();
             * obj.Push(x);
             * int param_2 = obj.Pop();
             * int param_3 = obj.Peek();
             * bool param_4 = obj.Empty();
             */
        }


        // TODO: Come up with a single stack solution
        // Leetcode : 155 - Min Stack
        // Approach : Two Stacks
        // Time Complexity : O(1)
        // Space Complexity : O(n)
        // Type: Medium 
        public class MinStack
        {
            private readonly Stack<int> s1;
            private readonly Stack<int> s2;

            public MinStack()
            {
                s1 = new();
                s2 = new();
            }

            public void Push(int val)
            {
                s1.Push(val);
                if (s2.Count == 0)
                {
                    s2.Push(val);
                }
                else
                {
                    s2.Push(Math.Min(val, s2.Peek()));
                }
            }

            public void Pop()
            {
                s1.Pop();
                s2.Pop();
            }

            public int Top()
            {
                return s1.Peek();
            }

            public int GetMin()
            {
                return s2.Peek();
            }
        }

        // Leetcode : 150 - Evaluate Reverse Polish Notation
        // Approach : Stack
        // Time Complexity : O(n)
        // Space Complexity : O(n)
        // Type: Medium
        public class EvaluateReversePolishNotation
        {
            public static int EvalRPN(string[] tokens)
            {
                Stack<int> evaluator = new();

                foreach (string token in tokens)
                {
                    if (token == "+" || token == "-" || token == "*" || token == "/")
                    {
                        int op2 = evaluator.Pop();
                        int op1 = evaluator.Pop();
                        if (token == "+")
                            evaluator.Push(op1 + op2);
                        else if (token == "-")
                            evaluator.Push(op1 - op2);
                        else if (token == "*")
                            evaluator.Push(op1 * op2);
                        else
                            evaluator.Push(op1 / op2);
                    }
                    else
                        evaluator.Push(int.Parse(token));
                }

                return evaluator.Pop();
            }
        }

        // Leetcode : 735 - Asteroid Collision
        // Approach : Stack
        // Time Complexity : O(n)
        // Space Complexity : O(n)
        // Type: Medium
        public class AsteroidCollisionProblem
        {
            public static int[] AsteroidCollision(int[] asteroids) {
            Stack<int> asteroidStack = new();
            foreach(int asteroid in asteroids)
            {
                int current = asteroid;
                while (asteroidStack.Count > 0 && current < 0 && asteroidStack.Peek() > 0)
                {
                    if(-asteroid > asteroidStack.Peek())
                    {
                        asteroidStack.Pop();
                    }
                    else if (asteroidStack.Peek() == -asteroid)
                    {
                        asteroidStack.Pop();
                        current = 0;
                    }
                    else
                    {
                        current = 0;
                    }
                }
                if(current != 0 )
                    asteroidStack.Push(asteroid);
                }
                return asteroidStack.Reverse().ToArray();
            }
        }

        // Leetcode : 739 - Daily Temperatures
        // Approach : Monotonic Stack
        // Time Complexity : O(n)
        // Space Complexity : O(n)
        // Type: Medium
        public class DailyTemperatures {
            public static int[] DailyTemperaturesFn(int[] temperatures) {
                int n = temperatures.Length;
                int[] result = new int[n];
                Stack<(int,int)> monoStack = new(n);
                for(int i = n - 1; i >= 0; i--)
                {
                    while(monoStack.Count > 0 && temperatures[i] >= monoStack.Peek().Item1)
                    {
                        monoStack.Pop();
                    }
                    
                    if(monoStack.Count != 0)
                    {
                        (_, int index) = monoStack.Peek();
                        result[i] = index - i;
                    }

                    monoStack.Push((temperatures[i],i));
                }
                return result;
            }
        }

        // Leetcode : 901 - Online Stock Span
        // Approach : Monotonic Stack
        // Time Complexity : O(n)
        // Space Complexity : O(n)
        // Type: Medium
        public class StockSpanner
        {
            private readonly Stack<(int price,int span)> _stack;

            public StockSpanner() {
                _stack = new();
            }

            public int Next(int price) {
                int day = 1; // consider current day for span
                // maintain strictly decreasing order
                while(_stack.Count > 0 && _stack.Peek().price <= price)
                {
                    day += _stack.Pop().span;
                }
                _stack.Push((price,day));
                return _stack.Peek().span;
            }
            /**
            * Your StockSpanner object will be instantiated and called as such:
            * StockSpanner obj = new StockSpanner();
            * int param_1 = obj.Next(price);
            */
        }

        // Leetcode : 853 - Car Fleet
        // Approach : Stack
        // Time Complexity : O(nlogn)
        // Space Complexity : O(n)
        // Type: Medium
        public class CarFleet {
            public static int CarFleetFn(int target, int[] position, int[] speed) {
                List<(int pos ,int speed)> pairs = [];
                for(int i = 0; i < position.Length; i++)
                {
                    pairs.Add((position[i],speed[i]));
                }
                pairs.Sort((a,b) => b.pos.CompareTo(a.pos));
                Stack<double> stack = new();
                foreach(var pair in pairs)
                {
                    (int p,int s) = pair;
                    double time = (double)(target - p) / s;
                    if (stack.Count == 0 || time > stack.Peek()) {
                        stack.Push(time);
                    }
                }
                return stack.Count;
            }
        }
    }
}
