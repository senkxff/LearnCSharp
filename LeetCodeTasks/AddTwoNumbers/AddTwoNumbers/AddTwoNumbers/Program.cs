namespace AddTwoNumbers
{
    public class ListNode
    {
        public int value;
        public ListNode next;
        public ListNode(int value = 0, ListNode next = null)
        {
            this.value = value;
            this.next = next; 
        }
    }

    internal class Solution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode result = new ListNode();
            ListNode head = result; 
            int sum = 0;

            while (l1 != null || l2 != null || sum > 0)
            {
                if (l1 != null)
                {
                    sum += l1.value;
                    l1 = l1.next;
                }

                if (l2 != null)
                {
                    sum += l2.value;
                    l2 = l2.next;
                }
                result.next = new ListNode(sum % 10);
                sum /= 10;
                result = result.next;
            }
            return head.next;
        }
    }
}
