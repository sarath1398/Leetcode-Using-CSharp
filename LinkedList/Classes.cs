using System.Xml.Linq;

namespace LinkedList
{
    internal class Classes
    {
        public class ListNode(int val = 0, ListNode? next = null)
        {
            public int val = val;
            public ListNode? next = next;
        }

        // Leetcode : 206 - Reverse Linked List
        // Approach : Iterative
        // Time Complexity : O(n)
        // Space Complexity : O(1)
        // Type: Easy
        public static ListNode? ReverseList(ListNode? head)
        {
            ListNode? prev = null;
            ListNode? current = head;
            while (current != null)
            {
                ListNode? tempNext = current?.next;
                current?.next = prev;

                prev = current;
                current = tempNext;
            }
            head = prev;
            return head;
        }

        // Leetcode : 21 - Merge Two Sorted Lists
        // Approach : Iterative
        // Time Complexity : O(n + m)
        // Space Complexity : O(1)
        // Type: Easy
        public static ListNode MergeTwoLists(ListNode list1, ListNode list2) {
            // Create a dummy node to store the merged list
            ListNode temp = new();
            ListNode curr = temp;
            // Optional check. Handled as part of the while loop condition in itself
            if(list1 == null)
                return list2;
            if(list2 == null)
                return list1;
            // Iterate through both lists and append the smaller node to the result
            while(list1 != null && list2 != null)
            {   
                if(list1.val < list2.val)
                {
                    curr.next = list1;
                    list1 = list1.next;
                }
                else
                {
                    curr.next = list2;
                    list2 = list2.next;
                }
                curr = curr.next;
            }
            // Append remaining nodes
            if(list1 != null)
                curr.next = list1;
            else
                curr.next = list2;
            // Return the merged list
            return temp.next;
        }

        // Leetcode : 141 - Linked List Cycle
        // Approach : Floyd's Tortoise and Hare Algorithm
        // Time Complexity : O(n)
        // Space Complexity : O(1)
        // Type: Easy
        public class LinkedListCycle {
            public static bool HasCycle(ListNode head) {
                ListNode slow = head;
                ListNode fast = head;

                while(fast != null && fast.next != null)
                {
                    fast = fast.next.next;
                    slow = slow.next;
                    if(slow == fast)
                        return true;
                }
                
                return false;
            }
        }

        // Leetcode : 143 - Reorder List
        // Approach : Recursive
        // Time Complexity : O(n)
        // Space Complexity : O(n) - Recursion Stack Space
        // Type: Medium 

        // NOTE : This can also be done using a fast and slow pointer approach
        // where we can find the mid point and reverse the second half
        // of the linked list and then merge the two halves with a space complexity of O(1)
        // but I went with the recursive approach to understand recursion better
        public class ReorderList {
            // in-place reordering
            public ListNode HelperFunction(ListNode cur, ListNode adv)
            {
                if(adv == null)
                    return cur;
                // Move till the end of the list such that
                // adv points to the end of the list and cur
                // points to the start of the list
                cur = HelperFunction(cur,adv.next);

                // early exit if the recursion stack crosses the mid point
                if(cur == null)
                    return null;
                ListNode temp = null;
                // check if we reached the mid point
                // cur != adv is for odd length
                // cur.next != adv is for even length
                if(cur != adv && cur.next != adv)
                {
                    temp = cur.next;
                    cur.next = adv;
                    adv.next = temp;
                }
                // Update the last pointer as null to mark the end of linked list
                else
                {
                    adv.next = null;
                }
                // update the root with next swappable value
                return temp;
            }

            public void ReorderListFn(ListNode head) {
                head = HelperFunction(head,head.next);
            }
        }

        // Leetcode : 19 - Remove Nth Node From End of List
        // Approach : Two Pointers
        // Time Complexity : O(n)
        // Space Complexity : O(1)
        // Type: Medium
        public static ListNode RemoveNthFromEnd(ListNode head, int n) {
            ListNode dummy = new(0, head);
            ListNode slow,fast;
            fast = head;
            // Move fast pointer n steps ahead
            while(n > 0)
            {
                fast = fast.next;
                n--;
            }
            slow = dummy;
            // Move both pointers until fast reaches the end
            while(fast!=null)
            {
                slow = slow.next;
                fast = fast.next;
            }
            // Skip the nth node
            if(slow != null && slow.next != null)
            {
                slow.next = slow.next.next;
            }
            return dummy.next;
        }

        // Leetcode : 138 - Copy List with Random Pointer
        // Approach : Hashmap
        // Time Complexity : O(n)
        // Space Complexity : O(n)
        // Type: Medium
        public class CopyRandomList
        {
            // Definition for a Node.
            public class Node
            {
                public int val;
                public Node next;
                public Node random;

                public Node(int _val)
                {
                    val = _val;
                    next = null;
                    random = null;
                }
            }

            public static Node CopyRandomListFn(Node head)
            {
                Dictionary<Node, Node> map = [];
                Node curr = head;
                // Create a 1:1 mapping of new node to that of the original node
                while (curr != null)
                {
                    Node node = new(curr.val);
                    map.Add(curr, node);
                    curr = curr.next;
                }
                curr = head;
                // Update the next and random pointers of the new nodes based on the mapping
                while (curr != null)
                {
                    Node nn = map[curr];
                    nn.next = curr.next != null ? map[curr.next] : null;
                    nn.random = curr.random != null ? map[curr.random] : null;
                    curr = curr.next;
                }
                // Return the head of the new list
                return head != null ? map[head] : null;
            }
        }

        // Leetcode : 2 - Add Two Numbers
        // Approach : Simulation
        // Time Complexity : O(n)
        // Space Complexity : O(n)
        // Type: Medium
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
            ListNode l3 = new();
            ListNode dummy = l3;
            int sum = 0;
            int carry = 0;

            while(l1 != null || l2 != null || carry != 0)
            {
                int v1 = (l1 != null) ? l1.val : 0;
                int v2 = (l2 != null) ? l2.val : 0;
                sum = v1 + v2 + carry;
                
                int val = sum % 10;
                carry = sum / 10;
                ListNode sumList = new(val,null);
                l3.next = sumList;
                l3 = l3.next; 
                l1 = (l1 != null) ? l1.next : null;
                l2 = (l2 != null) ? l2.next : null;
            }
            
            l3.next = null;
            return dummy.next;
        }

        // Leetcode : 287 - Find the Duplicate Number
        // Approach : Floyd's Tortoise and Hare (Cycle Detection)
        // Time Complexity : O(n)
        // Space Complexity : O(1)
        // Type: Medium
        public class FindDuplicate {
            public static int FindDuplicateFn(int[] nums) {
                int slow = 0;
                int fast = 0;
                // Find the intersection point of the slow and fast pointers
                while(true)
                {
                    slow = nums[slow];
                    fast = nums[nums[fast]];
                    if(slow == fast)
                    {
                        break;
                    }
                }
                // Find the entrance to the cycle
                int slow1 = 0;
                while(true)
                {
                    slow1 = nums[slow1];
                    slow = nums[slow];
                    if(slow1 == slow)
                        return slow;
                }
            }
        }

        // Leetcode : 92 - Reverse Linked List II
        // Approach : Recursion
        // Time Complexity : O(n)
        // Space Complexity : O(n)
        // Type: Medium
        public class ReverseLinkedListII
        {
            private static ListNode? successor = null;
            
            // Reverse a linkedlist recursively for N nodes
            // use successor node to point to the next node after N nodes instead of NULL
            public static ListNode? ReverseList(ListNode? head, int n)
            {
                if (n == 1)
                {
                    successor = head?.next;
                    return head;
                }
                ListNode? newHead = ReverseList(head?.next, n - 1);
                ListNode? front = head?.next;
                front?.next = head;
                head?.next = successor;
                return newHead;
            }
            public static ListNode? ReverseBetween(ListNode? head, int left, int right)
            {
                if (left == 1)
                {
                    return ReverseList(head, right);
                }
                head?.next = ReverseBetween(head.next, left - 1, right - 1);
                return head;
            }
        }

        // Leetcode : 622 - Design Circular Queue
        // Approach : Doubly Linked List
        // Time Complexity : O(1)
        // Space Complexity : O(k)
        // Type: Medium
        public class QueueListNode
        {
            public int val;
            public QueueListNode prev;
            public QueueListNode next;

            public QueueListNode(int val = -1, QueueListNode prev = null, QueueListNode next = null)
            {
                this.val = val;
                this.prev = prev;
                this.next = next;
            }
        }

        /**
        * Your MyCircularQueue object will be instantiated and called as such:
        * MyCircularQueue obj = new MyCircularQueue(k);
        * bool param_1 = obj.EnQueue(value);
        * bool param_2 = obj.DeQueue();
        * int param_3 = obj.Front();
        * int param_4 = obj.Rear();
        * bool param_5 = obj.IsEmpty();
        * bool param_6 = obj.IsFull();
        */
        public class MyCircularQueue 
        {
            private QueueListNode front = null;
            private QueueListNode rear = null;
            private int cur = 0;
            private int capacity;

            public MyCircularQueue(int k)
            {
                this.capacity = k;
            }
            
            public bool EnQueue(int value)
            {
                if (IsFull())
                    return false;

                QueueListNode node = new QueueListNode(value);
                if (IsEmpty()) {
                    front = node;
                    rear = node;
                    // Making it circular
                    node.next = rear;
                    node.prev = front;
                } 
                else
                {
                    rear.next = node;
                    node.prev = rear;
                    node.next = front; 
                    front.prev = node; 
                    rear = node;
                }
                cur++;
                return true;
            }
            
            public bool DeQueue()
            {
                if (IsEmpty())
                    return false;

                if (cur == 1)
                {
                    front = null;
                    rear = null;
                } 
                else
                {
                    front = front.next;
                    front.prev = rear;
                    rear.next = front;
                }
                cur--;
                return true;
            }
            
            public int Front()
            {
                return cur == 0 ? -1 : front.val;
            }
            
            public int Rear()
            {
                return cur == 0 ? -1 : rear.val;
            }
            
            public bool IsEmpty()
            {
                return cur <= 0;
            }
            
            public bool IsFull()
            {
                return cur >= capacity;
            }
        }

        // Leetcode : 146 - LRU Cache
        // Approach : Doubly Linked List + Hash Map
        // Time Complexity : O(1)
        // Space Complexity : O(k)
        // Type: Medium

        /**
        * Your LRUCache object will be instantiated and called as such:
        * LRUCache obj = new LRUCache(capacity);
        * int param_1 = obj.Get(key);
        * obj.Put(key,value);
        */
        public class LRUCache {
    
            public int maxCapacity;
            // has a 1:1 mapping between the key and the node containing the key value pair
            public Dictionary<int,LinkedListNode<(int key, int value)>> map;
            // Leftmost elements are least accessed and rightmost elements are most accessed 
            // in this order linkedlist
            public LinkedList<(int key, int value)> order;

            // Initialize the LRU Cache with the given capacity
            public LRUCache(int capacity) {
                this.maxCapacity = capacity;
                map = new();
                order = new();
            }
            
            public int Get(int key) {
                if(!map.ContainsKey(key))
                {
                    return -1;
                }
                // Update ordering since the element is now accessed
                var node = map[key];
                order.Remove(node);
                order.AddLast(node);
                (int k, int v) = node.Value;
                return v;
            }
            
            public void Put(int key, int value) {
                // check if key already exists in map
                // if yes, then update ordering and value of the key
                if(map.ContainsKey(key))
                {
                    var node = map[key];
                    order.Remove(node);
                    node.Value = (key, value);
                    order.AddLast(node);
                }
                else
                {
                    // check if the new element is exceeding capacity of map
                    // considering >= since the count starts from 
                    // Remove from left of linkedlist to remove Least used value
                    if(map.Count >= maxCapacity)
                    {
                        var front = order.First.Value;
                        order.RemoveFirst();
                        map.Remove(front.key);
                    }
                    // Add if the above two conditions are not applicable
                    LinkedListNode<(int key, int value)> node = new((key,value));
                    order.AddLast(node);
                    map.Add(key,node);
                }
            }
        }

        // Leetcode : 460 - LFU Cache
        // Approach : Doubly Linked List + Hash Map
        // Time Complexity : O(1)
        // Space Complexity : O(k)
        // Type: Hard

        /**
        * Your LFUCache object will be instantiated and called as such:
        * LFUCache obj = new LFUCache(capacity);
        * int param_1 = obj.Get(key);
        * obj.Put(key,value);
        */
        public class LFUNode {
            public int key;
            public int value;
            public int frequency;

            public LFUNode(int key, int value) {
                this.key = key;
                this.value = value;
                this.frequency = 1;
            }
        }

        public class LFUCache {
            // Maintains a LinkedList in LRU order for each frequency
            Dictionary<int, LinkedList<LFUNode>> freqMap;
            // Maintains a 1:1 map between each LinkedListNode and key
            Dictionary<int, LinkedListNode<LFUNode>> nodeMap;
            int capacity;
            // Maintains the minFrequency in case of eviction
            int minFreq;

            public LFUCache(int capacity) {
                this.capacity = capacity;
                this.minFreq = 0;
                freqMap = new Dictionary<int, LinkedList<LFUNode>>();
                nodeMap = new Dictionary<int, LinkedListNode<LFUNode>>();
            }

            public int Get(int key) {
                if (!nodeMap.ContainsKey(key))
                {
                    return -1;
                } 
                LinkedListNode<LFUNode> node = nodeMap[key];
                UpdateFrequency(node);
                return node.Value.value;
            }

            public void Put(int key, int value) {
                if (capacity == 0)
                {
                    return;
                } 

                if (nodeMap.ContainsKey(key))
                {
                    LinkedListNode<LFUNode> node = nodeMap[key];
                    node.Value.value = value;
                    UpdateFrequency(node);
                }
                else
                {
                    // Eviction logic
                    if (nodeMap.Count == capacity) {
                        // Get the list of minimum frequency
                        LinkedList<LFUNode> list = freqMap[minFreq];
                        
                        // Remove LRU
                        LFUNode toRemove = list.First.Value; 
                        list.RemoveFirst();
                        // Remove the evicted lru node from the nodeMap
                        nodeMap.Remove(toRemove.key); 
                    }

                    // Add new node
                    LFUNode newNode = new LFUNode(key, value);
                    // Create the linked list node
                    LinkedListNode<LFUNode> llNode = new LinkedListNode<LFUNode>(newNode);
                    
                    nodeMap.Add(key, llNode);
                    
                    // New nodes always start at freq 1
                    minFreq = 1; 
                    if (!freqMap.ContainsKey(1))
                    {
                        freqMap[1] = new LinkedList<LFUNode>();
                    } 
                    freqMap[1].AddLast(llNode);
                }
            }

            private void UpdateFrequency(LinkedListNode<LFUNode> llNode) {
                int currFreq = llNode.Value.frequency;
                
                // Remove from current frequency list
                freqMap[currFreq].Remove(llNode);

                // Check if the list with minFreq is empty. 
                // If yes, then the frequency has to be incremented to next minFrequency
                if (currFreq == minFreq && freqMap[currFreq].Count == 0) {
                    minFreq++;
                }

                // Increment frequency
                llNode.Value.frequency++;
                int newFreq = llNode.Value.frequency;

                // Add to new frequency list
                if (!freqMap.ContainsKey(newFreq)) {
                    freqMap[newFreq] = new LinkedList<LFUNode>();
                }
                freqMap[newFreq].AddLast(llNode);
            }
        }
    }
}
