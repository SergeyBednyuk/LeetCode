namespace _141_Linked_List_Cycle;

class Program
{
    static void Main(string[] args)
    {
        var case1 = new ListNode(3)
        {
            next = new ListNode(2)
            {
                next = new ListNode(0)
                {
                    next = new ListNode(-4)
                }
            }
        };
        var case1_c = case1.next;
        case1.next.next.next.next = case1_c;

        Console.WriteLine(case1.next.next.next.next.val);
        
        var case2 = new ListNode(1)
        {
            next = new ListNode(2)
        };
        var case2_c = case2;
        case2.next.next = case2_c;
        Console.WriteLine(case2.next.next.val);

        var case3 = new ListNode(1);
        
        //Solution
        var result = HasCycle(case2);
        Console.WriteLine(result);
        Console.ReadKey();
    }
    
    public static bool HasCycle(ListNode head)
    {
        var p1 = head;
        var p2 = head;
        for (int i = 0; true; i++)
        {
            if (p2.next != null && p2.next.next != null)
            {
                p2 = p2.next.next;
            }
            else
            {
                return false;
            }
            p1 = p1.next;
            if (p1 == p2)
            {
                break;  
            }
        }
        return true;
    }
}

internal class ListNode
{
    public int val;
    public ListNode next;

    public ListNode(int val)
    {
        this.val = val;
        next = null;
    }
}