using System.Text;

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
            // Node class for the trie
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
            
            // Add a word to the trie
            public void AddWord(string word) {
                Node curr = root;
                foreach(char ch in word)
                {
                    // If the node does not contain the character, create a new node
                    if(!curr.ContainsKey(ch))
                    {
                        Node newNode = new();
                        curr.SetNode(newNode,ch);
                    }
                    // Move to the next node
                    curr = curr.GetNode(ch);
                }
                // Mark the end of the word
                curr.IsEnd = true;
            }

            // Helper function to search for a word in the trie
            public bool SearchHelper(Node root, string word, int matchCount)
            {
                // If the match count is equal to the length of the word, return the end of the word
                if(matchCount == word.Length)
                {
                    return root.IsEnd;
                }
                char curr_letter = word[matchCount];
                // If the current letter is not a wildcard, check if the node contains the character
                if(curr_letter != '.')
                {
                    // If the node contains the character, move to the next node
                    if(root.ContainsKey(curr_letter))
                        return SearchHelper(root.GetNode(curr_letter),word,matchCount + 1);
                    // If the node does not contain the character, return false
                    return false;
                }
                else
                {
                    // If the current letter is a wildcard, check if the node contains any character
                    for(int i = 0; i < 26; i++)
                    {
                        char ch = (char)(i + 'a');
                        // If the node contains the character, move to the next node
                        if(root.ContainsKey(ch))
                        {
                            // If the match is found, return true
                            bool isMatch = SearchHelper(root.GetNode(ch),word,matchCount + 1);
                            if(isMatch)
                                return true;
                        }
                    }
                }
                // If no match is found, return false
                return false;
            }
            
            // Search for a word in the trie
            public bool Search(string word) {
                Node curr = root;
                // If the root is null, return false
                if(curr == null)
                {
                    return false;
                }
                // Call the helper function to search for the word
                return SearchHelper(curr,word,0);
            }
        }

        // Leetcode : 2707 - Extra Characters in a String
        // Approach : DFS + Memoization
        // Time Complexity : O(n)
        // Space Complexity : O(n)
        // Type : Medium
        public class ExtraCharactersInAString {
            
            Node root = new();
            
            // Memoization dictionary
            public Dictionary<int,int> memo = new();

            // Node class for the trie
            public class Node
            {
                Node[] _links;
                public bool IsEndOfWord {get; set;}

                public Node()
                {
                    _links = new Node[26];
                    IsEndOfWord = false;
                }

                public bool ContainsKey(char ch) => _links[ch - 'a'] != null;

                public Node GetNode(char ch) => _links[ch - 'a'];

                public void SetNode(Node node, char ch) => _links[ch - 'a'] = node;
            }

            public int WordBreak(string query, int startIndex)
            {
                // no word breaks since no string to break
                if(startIndex >= query.Length)
                {
                    return 0;
                }

                // Check if the result is already memoized
                if(memo.ContainsKey(startIndex + 1))
                    return memo[startIndex + 1];
                // omit the current letter
                int min = 1 + WordBreak(query,startIndex + 1);
                
                // unwind the recursion stack and check for trie

                // reset node to root
                Node curr_node = root;

                // search the subquery and check if it exists in trie
                for(int i = startIndex; i < query.Length; i++)
                {
                    char curr_letter = query[i];
                    // If the node does not contain the character, break
                    if(!curr_node.ContainsKey(curr_letter))
                    {
                        break;
                    }
                    // Move to the next node
                    curr_node = curr_node.GetNode(curr_letter);

                    // If the node is the end of a word, update the minimum
                    if(curr_node.IsEndOfWord == true)
                    {
                        min = Math.Min(min,WordBreak(query,i + 1));
                    }
                }
                // Memoize the result
                memo[startIndex + 1] = min;
                return min;
            }

            public int MinExtraChar(string s, string[] dictionary) {
                Node curr = new();
                // Insert all the words in the dictionary into the trie
                foreach(string word in dictionary)
                {
                    curr = root;
                    foreach(char ch in word)
                    {
                        if(!curr.ContainsKey(ch))
                        {
                            Node newNode = new();
                            curr.SetNode(newNode,ch);
                        }
                        curr = curr.GetNode(ch);
                    }
                    curr.IsEndOfWord = true;
                }
                return WordBreak(s,0);
            }
        }

        // Leetcode : 212 - Word Search II
        // Approach : DFS + Backtracking
        // Time Complexity : O(n)
        // Space Complexity : O(n)
        // Type : Medium
        public class WordSearchII {

            Node root = new();
            bool[,] visited;
            HashSet<string> result = new();

            // Define properties for the node
            public class Node
            {
                Node[] _links = new Node[26];
                public bool IsEndOfWord {get;set;} = false;
                public bool IsVisited {get; set;} = false;

                public void SetNode(char ch, Node newNode) => _links[ch - 'a'] = newNode;

                public Node GetNode(char ch) => _links[ch - 'a'];

                public bool ContainsKey(char ch) => _links[ch - 'a'] != null;
            }

            // The backtracking function
            public void DFS(char[][] board, int r, int c, int rows, int cols,
            Node curr_node, StringBuilder sb)
            {
                // Return if out of bounds or if the prefix tree does not contain the current letter 
                // or if the cell is already visited

                if(r >= rows || c >= cols || r < 0 || c < 0 ||
                !curr_node.ContainsKey(board[r][c]) || visited[r,c] == true)
                {
                    return;
                }

                // (int x, int y) top = (r - 1, c);
                // (int x, int y) down = (r + 1, c);
                // (int x, int y) left = (r , c - 1);
                // (int x, int y) right = (r , c + 1);

                // Get the current letter and append it to the string builder
                char curr_letter = board[r][c];
                sb.Append(curr_letter);
                // update the visited array
                visited[r,c] = true;
                // move to the next node
                curr_node = curr_node.GetNode(curr_letter);
                // if the current node is the end of a word, add it to the result
                if(curr_node.IsEndOfWord == true)
                {
                    result.Add(sb.ToString());
                }

                // Recursively call the function for all the possible directions
                DFS(board,r - 1, c, rows, cols, curr_node, sb);
                DFS(board,r + 1, c, rows, cols, curr_node, sb);
                DFS(board,r, c + 1, rows, cols, curr_node, sb);
                DFS(board,r, c - 1, rows, cols, curr_node, sb);

                // Backtrack
                visited[r,c] = false;
                sb.Length--;
            }

            public IList<string> FindWords(char[][] board, string[] words) { 
                root = new();
                int N = board.Length;
                int M = board[0].Length;
                visited = new bool[N,M];
                // Insert all the words in the dictionary into the trie
                foreach(string word in words)
                {
                    Node curr = root;
                    foreach(char ch in word)
                    {
                        if(!curr.ContainsKey(ch))
                        {
                            curr.SetNode(ch,new Node());
                        }
                        curr = curr.GetNode(ch);
                    }
                    curr.IsEndOfWord = true;
                }
                // Iterate over the board and call the DFS function
                for(int i = 0; i < N; i++)
                {
                    StringBuilder sb = new();
                    for(int j = 0; j< M; j++)
                    {
                        DFS(board,i,j,N,M,root,sb);
                    }
                }
                // Return the result
                return result.ToList();
            }
        }
    }
}
