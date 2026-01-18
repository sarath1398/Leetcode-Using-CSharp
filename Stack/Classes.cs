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
    }
}
