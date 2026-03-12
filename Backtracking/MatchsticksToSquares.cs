namespace Backtracking
{
    // Leetcode - 473
    // Approach : Backtracking
    // Time Complexity : O(4 ^ n)
    // Space Complexity : O(n)
    // Type: Medium
    public class MatchsticksToSquares
    {
        // TODO : Work on an pruned and cleaner version of this solution
        public bool Makesquare(int[] matchsticks)
        {
            int sum = matchsticks.ToList().Sum();
            // Perimeter of a square should be divisible by 4
            if (sum % 4 != 0)
            {
                return false;
            }
            // side of a square = perimeter / 4
            int a = sum / 4;
            Array.Sort(matchsticks);
            Array.Reverse(matchsticks);
            bool result = false;
            int[] s = new int[4];

            void DFS(int i)
            {
                if (s[0] == s[1] && s[1] == s[2] && s[2] == s[3] && s[3] == a)
                {
                    result = true;
                    return;
                }

                if (s[0] > a || s[1] > a || s[2] > a || s[3] > a || i >= matchsticks.Length)
                {
                    return;
                }

                int currStick = matchsticks[i];
                s[0] += currStick;
                DFS(i + 1);
                s[0] -= currStick;
                s[1] += currStick;
                DFS(i + 1);
                s[1] -= currStick;
                s[2] += currStick;
                DFS(i + 1);
                s[2] -= currStick;
                s[3] += currStick;
                DFS(i + 1);
                s[3] -= currStick;
                return;
            }
            DFS(0);
            return result;
        }
    }
} 
