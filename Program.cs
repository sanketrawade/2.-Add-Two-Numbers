namespace _2._Add_Two_Numbers
{
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

    internal class Program
    {
        //public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        public ListNode AddTwoNumbers()
        {
            var list1 = new List<nuint>() { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 };
            var list2 = new List<nuint>() { 5, 6, 4 };
            var resList = new List<nuint>();
            nuint n1 = 0;
            nuint n2 = 0;

            //while (l1 != null)
            //{
            //    list1.Add(l1.val);
            //    l1 = l1.next;
            //}
            for (int i = list1.Count() - 1; i >= 0; i--)
            {
                n1 = ((n1 * 10) + list1.ElementAt(i));
            }

            //while (l2 != null)
            //{
            //    list2.Add(l2.val);
            //    l2 = l2.next;
            //}
            for (int i = list2.Count() - 1; i >= 0; i--)
            {
                n2 = (n2 * 10) + list2.ElementAt(i);
            }

            var res = n1 + n2;
            int rev = 0;
            if (res == 0)
            {
                resList.Add(0);
            }
            while (res > 0)
            {
                nuint num = res % 10;
                resList.Add(num);
                res = res / 10;
            }
            var head = new ListNode(Convert.ToInt32(resList[0]));
            var node = head;
            if (resList.Count() > 1)
            {
                for (int i = 1; i < resList.Count(); i++)
                {
                    node.next = new ListNode(Convert.ToInt32(resList[i]));
                    node = node.next;
                }
            }
            return head;
        }

        static void Main(string[] args)
        {
            var program = new Program();
            Console.WriteLine(program.AddTwoNumbers());
        }
    }
}