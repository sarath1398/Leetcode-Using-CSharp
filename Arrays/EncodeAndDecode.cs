namespace Arrays;

public class EncodeAndDecode : Solution
{
    public string Encode(IList<string> strs)
    {
        var finalStr = "";
        foreach (var str in strs)
        {
            finalStr += str.Length + "#" + str;
        }

        return finalStr;
    }

    public List<string> Decode(string s)
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