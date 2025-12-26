namespace Arrays
{
    public class GroupAnagrams
    {
        public static IList<IList<string>> GroupAnagramsFn(string[] strs)
        {
            if (strs.Length == 1)
            {
                var strsList = strs.ToList();
                return new List<IList<string>>() { { strsList } };
            }
            else
            {
                Dictionary<string, List<string>> frequencyMap = new();
                foreach (string str in strs)
                {
                    var charMap = new int[26]; // Note : C# arrays are set to default values by default
                    foreach (char s in str)
                    {
                        var charIndex = s - 'a';
                        charMap[charIndex]++;
                    }
                    var binaryStringMap = "";
                    foreach (char c in charMap)
                    {
                        binaryStringMap += c.ToString();
                    }
                    bool isInserted = frequencyMap.TryAdd(binaryStringMap, new List<string> { str });
                    if (!isInserted)
                    {
                        frequencyMap[binaryStringMap].Add(str);
                    }
                }

                var finalList = new List<IList<string>>();
                foreach (var keys in frequencyMap.Keys)
                {
                    finalList.Add(frequencyMap[keys]);
                }
                return finalList;
            }
        }
    }
}