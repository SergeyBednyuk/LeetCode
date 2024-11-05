namespace _21_merge_two_sorted_lists;

class Program
{
    static void Main(string[] args)
    {
        var c1_l1 = new ListNode(1)
        {
            next = new ListNode(2)
            {
                next = new ListNode(4)
            }
        };
        
        /////////////////////////////////
        var c1_l2 = new ListNode(1)
        {
            next = new ListNode(3)
            {
                next = new ListNode(4)
            }
        };
        
        /////////////////////////////////
        var result = MergeTwoLists(c1_l1, c1_l2);
        while (result.next != null)
        {
            Console.WriteLine(result.val);
            result = result.next;
        }
    }
    internal static ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        var l1 = new ListNode();
        var tail = l1;
        
        while(list1 != null && list2 != null)
        {
            if(list1.val < list2.val)
            {
                tail.next = list1;
                list1 = list1.next;
            }
            else
            {
                tail.next = list2;
                list2 = list2.next;
            }
            tail = tail.next;
        }

        if (list1 == null)
        {
            tail.next = list2;
        }
        else
        {
            tail.next = list1;
        }
        return l1.next;
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
}