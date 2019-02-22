using System;
using System.Collections.Generic;
using System.Text;

namespace LeetcodeTraining
{
    // NOT DONE
    // Need to improvemend in algorithm

    static public class AddTwoNumbersSolution
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }

        /* Description:
         * Input: (2 -> 4 -> 3) + (5 -> 6 -> 4)
         * Output: 7 -> 0 -> 8
         * Explanation: 342 + 465 = 807. 
         */

        static public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            decimal firstNumber = 0, secondNumber = 0, resultNumber = 0;

            //Initialize first number
            firstNumber = l1.val;
            l1 = l1.next;
            for (int i = 10; l1 != null; i *= 10)
            {
                //firstNumber *= 10;
                firstNumber += l1.val * i;
                l1 = l1.next;
            }

            //Initialize second number
            secondNumber = l2.val;
            l2 = l2.next;
            for (decimal i = 10; l2 != null; i *= 10)
            {
                //secondNumber *= 10;
                secondNumber += l2.val * i;
                l2 = l2.next;
            }

            resultNumber = firstNumber + secondNumber;

            //Divide result number
            ListNode listStart = new ListNode(0);
            ListNode currentListNode = listStart;

            currentListNode.val = (int)(resultNumber % 10);
            resultNumber /= 10;

            while (resultNumber >= 1)
            {
                currentListNode.next = new ListNode(0);
                currentListNode = currentListNode.next;
                currentListNode.val = (int)(resultNumber % 10);
                resultNumber /= 10;
            }

            return listStart;
        }

        static public ListNode addTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode c1 = l1;
            ListNode c2 = l2;
            ListNode sentinel = new ListNode(0);
            ListNode d = sentinel;
            int sum = 0;
            while (c1 != null || c2 != null)
            {
                sum /= 10;
                if (c1 != null)
                {
                    sum += c1.val;
                    c1 = c1.next;
                }
                if (c2 != null)
                {
                    sum += c2.val;
                    c2 = c2.next;
                }
                d.next = new ListNode(sum % 10);
                d = d.next;
            }
            if (sum / 10 == 1)
                d.next = new ListNode(1);
            return sentinel.next;
        }

        static public void AddTwoNumbersTest()
        {
            ListNode l1, l2, pointer;

            l1 = new ListNode(9);

            l2 = new ListNode(1);
            pointer = l2;
            pointer.next = new ListNode(9);
            pointer = pointer.next;
            pointer.next = new ListNode(9);
            pointer = pointer.next;
            pointer.next = new ListNode(9);
            pointer = pointer.next;
            pointer.next = new ListNode(9);
            pointer = pointer.next;
            pointer.next = new ListNode(9);
            pointer = pointer.next;
            pointer.next = new ListNode(9);
            pointer = pointer.next;
            pointer.next = new ListNode(9);
            pointer = pointer.next;
            pointer.next = new ListNode(9);
            pointer = pointer.next;
            pointer.next = new ListNode(9);

            PrintListNodeValue(l1);
            PrintListNodeValue(l2);

            ListNode result;
            result = AddTwoNumbers(l1, l2);
            //result = addTwoNumbers(l1, l2);
            PrintListNodeValue(result);

            void PrintListNodeValue(ListNode ln)
            {
                while (ln != null)
                {
                    Console.Write("{0}", ln.val);
                    ln = ln.next;
                }
                Console.WriteLine();
            }
        }
    }
}
