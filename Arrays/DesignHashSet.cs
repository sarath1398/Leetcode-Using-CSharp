using System.Collections.Generic;

namespace Arrays
{
    public class DesignHashSet
    {
        public class MyHashSet
        {
            readonly LinkedList<int>[] hashSet;
            private static readonly int BUCKET_SIZE = 10000;

            public MyHashSet()
            {
                hashSet = new LinkedList<int>[BUCKET_SIZE];
                for (int i = 0; i < BUCKET_SIZE; i++)
                {
                    hashSet[i] = new LinkedList<int>();
                }
            }

            public void Add(int key)
            {
                int hash = key % BUCKET_SIZE;
                if (!hashSet[hash].Contains(key))
                {
                    hashSet[hash].AddLast(key);
                }
            }

            public void Remove(int key)
            {
                int hash = key % BUCKET_SIZE;
                if (hashSet[hash].Contains(key))
                {
                    hashSet[hash].Remove(key);
                }
            }

            public bool Contains(int key)
            {
                int hash = key % BUCKET_SIZE;
                return hashSet[hash].Contains(key);
            }
        }

        /**
         * Your MyHashSet object will be instantiated and called as such:
         * MyHashSet obj = new MyHashSet();
         * obj.Add(key);
         * obj.Remove(key);
         * bool param_3 = obj.Contains(key);
         */
    }
}
