using System;
using System.Collections.Generic;
using System.Text;

namespace LeetcodeTraining
{
    static class DetectCycleSolution
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }

        static public ListNode DetectCycle(ListNode head)
        {
            HashSet<ListNode> set = new HashSet<ListNode>();

            while (head != null)
            {
                if (set.Contains(head))
                {
                    return head;
                }
                else
                {
                    set.Add(head);
                }
                head = head.next;
            }

            return null;
        }
    }
}
