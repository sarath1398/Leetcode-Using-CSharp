namespace Strings
{
    public class Classes
    {
        public class ScoreOfStringLC3110
        {
            public static int ScoreOfString(string s)
            {
                int abs = 0;
                for (int i = 1; i < s.Length; i++)
                {
                    abs += Math.Abs((int)s[i] - (int)s[i - 1]);
                }
                return abs;
            }
        }
    }
}
