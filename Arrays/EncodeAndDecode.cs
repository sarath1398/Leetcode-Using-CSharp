namespace Arrays
{
    // Leetcode : 271 - Encode and Decode Strings
    // Approach : Length Encoding
    // Time Complexity : O(n)
    // Space Complexity : O(n)
    // Type: Medium
    public class EncodeAndDecode
    {
        public static string Encode(IList<string> strs)
        {
            var finalStr = "";
            foreach (var str in strs)
            {
                finalStr += str.Length + "#" + str;
            }

            return finalStr;
        }

        public static List<string> Decode(string s)
        {
            int i = 0;
            List<string> finalList = new();
            for (; i < s.Length; i++)
            {
                string count = "";
                while (s[i] != '#')
                {
                    count += s[i++];
                }

                int wordLength = 0;
                var eachStr = "";
                int integerCount = int.Parse(count);
                while (wordLength < integerCount)
                {
                    i++;
                    eachStr += s[i];
                    wordLength++;
                }
                finalList.Add(eachStr);
            }
            return finalList;
        }
    }
}