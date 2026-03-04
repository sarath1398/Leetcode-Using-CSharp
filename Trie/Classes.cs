namespace Trie
{
    internal class Classes
    {
        // Leetcode : 208 - Implement Trie (Prefix Tree)
        // Approach : DFS
        // Time Complexity : O(n)
        // Space Complexity : O(n)
        // Type : Medium
        public class Trie
        {
            // Root node of the trie
            Node root;

            // Node class for the trie
            public class Node
            {
                // Array of links to the next nodes
                Node[] _links;
                // Flag to check if the node is the end of a word
                public bool IsEndOfWord { get; set; }

                // Constructor
                public Node()
                {
                    _links = new Node[26];
                    IsEndOfWord = false;
                }
                
                // Get the node for the given character
                public Node GetNode(char ch)
                {
                    return _links[ch - 'a'];
                }

                // Check if the node contains the given character
                public bool ContainsKey(char ch)
                {
                    return _links[ch - 'a'] != null;
                }

                // Set the node for the given character
                public void SetNode(char ch, Node n)
                {
                    _links[ch - 'a'] = n;
                }
            }

            public Trie()
            {
                root = new Node();
            }

            // Insert a word into the trie
            public void Insert(string word)
            {
                Node curr = root;
                foreach (char c in word)
                {
                    // If the node does not contain the character, create a new node
                    if (!curr.ContainsKey(c))
                    {
                        Node newNode = new();
                        curr.SetNode(c, newNode);
                    }
                    // Move to the next node
                    curr = curr.GetNode(c);
                }
                // Mark the end of the word
                curr.IsEndOfWord = true;
            }

            // Search for a word in the trie
            public bool Search(string word)
            {
                Node? endNode = SearchHelper(word);
                // Check if the end node is not null and is the end of a word
                return endNode != null && endNode.IsEndOfWord;
            }

            // Search for a prefix in the trie
            // This works like a partial search so no need to check for IsEndOfWord
            public bool StartsWith(string prefix)
            {
                Node? endNode = SearchHelper(prefix);
                // Check if the end node is not null
                return endNode != null;
            }

            // Helper function to search for a word in the trie
            public Node? SearchHelper(string word)
            {
                Node curr = root;
                // Traverse the trie for the given word
                foreach (char ch in word)
                {
                    // If the node does not contain the character, return null
                    if (!curr.ContainsKey(ch))
                        return null;
                    // Move to the next node
                    curr = curr.GetNode(ch);
                }
                // Return the end node
                return curr;
            }
        }


        // Leetcode : 211 - Design Add and Search Words Data Structure
        // Approach : DFS
        // Time Complexity : O(n)
        // Space Complexity : O(n)
        // Type : Medium
        public class WordDictionary {

            public class Node
            {
                Node[] _links;
                public bool IsEnd {get;set;}

                public Node()
                {
                    _links = new Node[26];
                    IsEnd = false;
                } 

                public bool ContainsKey(char ch)
                {
                    return _links[ch-'a'] != null;
                }

                public Node GetNode(char ch)
                {
                    return _links[ch - 'a'];
                }

                public void SetNode(Node node, char ch)
                {
                    _links[ch - 'a'] = node;
                }
            }

            public Node root;

            public WordDictionary() {
                root = new Node();
            }
            
            public void AddWord(string word) {
                Node curr = root;
                foreach(char ch in word)
                {
                    if(!curr.ContainsKey(ch))
                    {
                        Node newNode = new();
                        curr.SetNode(newNode,ch);
                    }
                    curr = curr.GetNode(ch);
                }
                curr.IsEnd = true;
            }

            public bool SearchHelper(Node root, string word, int matchCount)
            {
                if(matchCount == word.Length)
                {
                    return root.IsEnd;
                }
                char curr_letter = word[matchCount];
                if(curr_letter != '.')
                {
                    if(root.ContainsKey(curr_letter))
                        return SearchHelper(root.GetNode(curr_letter),word,matchCount + 1);
                    return false;
                }
                else
                {
                    for(int i = 0; i < 26; i++)
                    {
                        char ch = (char)(i + 'a');
                        if(root.ContainsKey(ch))
                        {
                            bool isMatch = SearchHelper(root.GetNode(ch),word,matchCount + 1);
                            if(isMatch)
                                return true;
                        }
                    }
                }
                return false;
            }
            
            public bool Search(string word) {
                Node curr = root;
                if(curr == null)
                {
                    return false;
                }
                return SearchHelper(curr,word,0);
            }
        }
    }
}
