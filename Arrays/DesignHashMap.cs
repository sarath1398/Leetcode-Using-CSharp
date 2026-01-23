namespace Arrays
{
    // Leetcode : 706 - Design HashMap
    // Approach : Array / LinkedList (Chaining)
    // Time Complexity : O(1) avg
    // Space Complexity : O(n)
    // Type: Easy
    public class DesignHashMap
    {
        public class Node(int key, int value)
        {
            readonly int key = key;
            int value = value;

            public int Key { get => key; }

            public int Value { get => value; set => this.value = value; }
        }
        public class MyHashMap
        {
            private readonly LinkedList<Node>[] hashMap;
            private readonly int BUCKET_SIZE = 10000;
            public MyHashMap()
            {
                hashMap = new LinkedList<Node>[BUCKET_SIZE];
                for (int i = 0; i < BUCKET_SIZE; i++)
                {
                    hashMap[i] = new LinkedList<Node>();
                }
            }

            public void Put(int key, int value)
            {
                int hash = key % BUCKET_SIZE;
                Node? node = hashMap[hash].FirstOrDefault(n => n.Key == key);
                if (node == null)
                {
                    hashMap[hash].AddFirst(new Node(key, value));
                }
                else
                {
                    node.Value = value;   
                }
            }

            public int Get(int key)
            {
                int hash = key % BUCKET_SIZE;
                LinkedList<Node> allNodes = hashMap[hash];
                foreach (Node node in allNodes)
                {
                    if (node.Key == key)
                    {
                        return node.Value;
                    }
                }
                return -1;
            }

            public void Remove(int key)
            {
                int hash = key % BUCKET_SIZE;
                Node? node = hashMap[hash].FirstOrDefault(n => n.Key == key);
                if (node != null)
                {
                    hashMap[hash].Remove(node);
                }
            }
        }
    }
}
