namespace Stack
{
   public class Classes
   {
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
    }
}
