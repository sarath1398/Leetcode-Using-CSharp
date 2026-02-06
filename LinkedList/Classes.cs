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
                while (curr != null)
                {
                    Node node = new(curr.val);
                    map.Add(curr, node);
                    curr = curr.next;
                }
                curr = head;
                while (curr != null)
                {
                    Node nn = map[curr];
                    nn.next = curr.next != null ? map[curr.next] : null;
                    nn.random = curr.random != null ? map[curr.random] : null;
                    curr = curr.next;
                }
                return head != null ? map[head] : null;
            }
        }
    }
}
