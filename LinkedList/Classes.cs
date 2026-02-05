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
    }
}
