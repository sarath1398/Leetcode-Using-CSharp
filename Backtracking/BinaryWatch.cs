namespace Backtracking;

    // Leetcode : 401 - Binary Watch
    // Approach : Backtracking
    // Time Complexity : O(1)
    // Space Complexity : O(1)
    // Type: Easy
    public class BinaryWatch
{
    public List<string> allValues = new();
    public void Backtrack(int idx, char[] binaryStr, int turns)
    {
        int n = binaryStr.Length;
        string hrString = new string(binaryStr[6..10]);
        string secString = new string(binaryStr[0..6]);
        int hours = Convert.ToInt32(hrString,2);
        int minutes = Convert.ToInt32(secString,2);
        if (hours > 11 || minutes > 59)
            return;
        if (turns > 10 - idx)
            return;
        if(turns == 0)
        {
            string operand = (minutes < 10)? "0" : String.Empty;
            string watchFormat = hours.ToString() + ":" + operand + minutes.ToString();
            allValues.Add(watchFormat);
            return;
        }
        binaryStr[idx] = '1';
        //Console.WriteLine(string.Join("",binaryStr));
        Backtrack(idx+1,binaryStr,turns-1);
        binaryStr[idx] = '0';
        //Console.WriteLine(string.Join("",binaryStr));
        Backtrack(idx+1,binaryStr,turns);
    }
    public IList<string> ReadBinaryWatch(int turnedOn) {
        string hourAndMinutesString = "0000000000";
        char[] strArray = hourAndMinutesString.ToCharArray();
        Backtrack(0,strArray,turnedOn);
        //allValues.Sort();
        return allValues;
    }
}