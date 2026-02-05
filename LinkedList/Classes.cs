namespace LinkedList
{
    internal class Classes
    {
        public class ListNode(int val = 0, ListNode? next = null)
        {
            public int val = val;
            public ListNode? next = next;
        }

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
    }
}
