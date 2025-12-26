namespace Arrays
{
    public class DestinationCity
    {
        public static string DestCity(IList<IList<string>> paths)
        {
            // Add all source and destination paths in a dictionary
            Dictionary<string, string> pathMap = new();
            foreach (var path in paths)
            {
                pathMap.Add(path[0], path[1]);
            }
            // Try to check if one destination is the source for any other path.
            // If not, then that's the final destination
            foreach (var path in paths)
            {
                string dest = pathMap[path[0]];
                bool isAvailable = pathMap.TryGetValue(dest, out string new_dest);
                if (!isAvailable)
                {
                    return dest;
                }
            }
            return String.Empty;
        }
    }
}