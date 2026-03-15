using System.Text;

namespace Backtracking
{
    // Leetcode : 140 - Word Break II
    // Approach : Backtracking
    // Time Complexity : O(m + n * 2^n)
    // Space Complexity : O(m + 2^n)
    // Type: Hard
    internal class WordBreakII
    {
        // Using Trie to store the dictionary words
        public class Node
        {
            // Array of size 26 to store the links to the next node
            public Node[] _links;
            // Boolean to check if the node is the end of a word
            public bool IsEndOfWord { get; set; }

            public Node()
            {
                _links = new Node[26];
                IsEndOfWord = false;
            }

            public bool ContainsKey(char ch) => _links[ch - 'a'] != null;
            public Node GetNode(char ch) => _links[ch - 'a'];
            public void SetNode(char ch, Node node) => _links[ch - 'a'] = node;
        }

        public List<string> WordBreak(string s, List<string> wordDict)
        {
            // Initialize the Trie
            Node root = new();
            foreach (string word in wordDict)
            {
                // Insert each word into the Trie
                Node curr = root;
                foreach (char letter in word)
                {
                    if (!curr.ContainsKey(letter))
                    {
                        curr.SetNode(letter, new Node());
                    }
                    curr = curr.GetNode(letter);
                }
                curr.IsEndOfWord = true;
            }

            // Initialize the result list and StringBuilder
            List<string> result = [];
            StringBuilder sb = new();

            // Helper function to perform DFS
            void dfs(Node cur, string s, StringBuilder sb, int currIndex)
            {
                // Reached the end of the string
                if (currIndex == s.Length)
                {
                    // Only add if we successfully ended on a word boundary
                    if (cur == root)
                    {
                        // Remove the trailing space added during the word break
                        result.Add(sb.ToString().TrimEnd());
                    }
                    return;
                }

                // Get the current character
                char curr_letter = s[currIndex];

                // If the current character is in the Trie
                if (cur.ContainsKey(curr_letter))
                {
                    // Get the next node
                    Node nextNode = cur.GetNode(curr_letter);

                    // Append the character
                    sb.Append(curr_letter);

                    // If we formed a valid word, we can choose to break here
                    if (nextNode.IsEndOfWord)
                    {
                        sb.Append(' ');
                        dfs(root, s, sb, currIndex + 1); // Start next word from root
                        sb.Length--;          // backtrack the space
                    }

                    // We can choose NOT to break, and continue down the Trie
                    dfs(nextNode, s, sb, currIndex + 1);
                    // Backtrack the character itself before returning
                    sb.Length--;
                }
            }

            // Start DFS passing the root node
            dfs(root, s, sb, 0);
            return result;
        }
    }
}
