namespace MergeTwoSortedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListNode l1 = new ListNode(1);
            l1.next = new ListNode(2);
            l1.next.next = new ListNode(4);

            ListNode l2 = new ListNode(1);
            l2.next = new ListNode(3);
            l2.next.next = new ListNode(4);
            var result = MergeTwoLists(l1, l2);
            Console.WriteLine(result);
        }

        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }

        public static ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            if (list1 == null)
            {
                return list2;
            }
                
            if (list2 == null)
            {
                return list1;
            }
                
            if (list1.val - list2.val >= 0)
            {

                list2.next = MergeTwoLists(list1, list2.next);
                return list2 ;
            }
            else
            {
                list1.next = MergeTwoLists(list2, list1.next);
                return list1 ;
            }
        }
    }
}
