using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Numerics;
using System.Text;

namespace AddTwoNumbers
{
    internal class Program
    {
        
        public class ListNode {
                 public int val;
                 public ListNode next;
                 public ListNode(int x) { val = x; }
        }
        
        
        public static void Main(string[] args)
        {
//            var number1 = new ListNode(5){next = new ListNode(6){next = new ListNode(4)}};
//            var number2 = new ListNode(2){next = new ListNode(4){next = new ListNode(3)}};
//            var number1 = new ListNode(0);
//            var number2 = new ListNode(0);
//            var number1 = CreateLinkedList(new int[]{9});
//            var number2 = CreateLinkedList(new int[] {1, 9, 9, 9, 9, 9, 9, 9, 9, 9});
//                [2,4,3,2,4,3,2,4,3,2,4,3,2,4,3,2,4,3,2,4,3,2,4,3,2,4,3,2,4,3,2,4,3,2,4,3,2,4,3,2,4,3,2,4,3,2,4,3,2,4,3,2,4,3,2,4,3,2,4,3,9]
//                [5,6,4,2,4,3,2,4,3,2,4,3,2,4,3,2,4,3,2,4,3,2,4,3,2,4,3,2,4,3,2,4,3,2,4,3,2,4,3,2,4,3,2,4,3,2,4,3,2,4,3,2,4,3,2,4,3,9,9,9,9]
            var number1 = CreateLinkedList(new int[]{2,4,3,2,4,3,2,4,3,2,4,3,2,4,3,2,4,3,2,4,3,2,4,3,2,4,3,2,4,3,2,4,3,2,4,3,2,4,3,2,4,3,2,4,3,2,4,3,2,4,3,2,4,3,2,4,3,2,4,3,9});
            var number2 = CreateLinkedList(new int[] {5,6,4,2,4,3,2,4,3,2,4,3,2,4,3,2,4,3,2,4,3,2,4,3,2,4,3,2,4,3,2,4,3,2,4,3,2,4,3,2,4,3,2,4,3,2,4,3,2,4,3,2,4,3,2,4,3,9,9,9,9});
            
            AddTwoNumbers2(number1, number2);
            Console.ReadLine();
        }

        private static ListNode CreateLinkedList(int[] arr)
        {
            ListNode prev = null;
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                var listNode = new ListNode(arr[i]){next = prev};
                prev = listNode;
            }
            return prev;
        }
        
        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            var num1 = GetNumber(l1);
            var num2 = GetNumber(l2);
            var result = num1 + num2;
            var node = GetListNodes(result);

            return node;
        }
        
        public static ListNode AddTwoNumbers2(ListNode l1, ListNode l2) 
        {
            ListNode dummyHead = new ListNode(0);
            ListNode p = l1, q = l2, curr = dummyHead;
            int carry = 0;
            while (p != null || q != null) {
                int x = (p != null) ? p.val : 0;
                int y = (q != null) ? q.val : 0;
                int sum = carry + x + y;
                carry = sum / 10;
                curr.next = new ListNode(sum % 10);
                curr = curr.next;
                if (p != null) p = p.next;
                if (q != null) q = q.next;
            }
            if (carry > 0) {
                curr.next = new ListNode(carry);
            }
            return dummyHead.next;
        }

//        private static ListNode GetListNodes(ulong result)
//        {
//            Stack<ulong> s = new Stack<ulong>();
//            if (result == 0)
//            {
//                s.Push(result);
//            }
//            else
//            {
//                while (result > 0)
//                {
//                    s.Push(result % 10);
//                    result = result / 10;
//                }    
//            }
//            ListNode previous = null;
//            while (s.Count > 0)
//            {
//                var listNode = new ListNode((int)s.Pop()){next = previous};
//                previous = listNode;
//            }
//            return previous;
//        }
        
        private static ListNode GetListNodes(BigInteger result)
        {
            var str = result.ToString();
            ListNode previous = null;
            for (int i = 0; i < str.Length; i++)
            {
                var listNode = new ListNode(Int32.Parse(str[i].ToString())){next = previous};
                previous = listNode;
            }
            return previous;
        }
        
        private static BigInteger GetNumber(ListNode node)
        {
            Stack<int> q = new Stack<int>();
            while (node != null)
            {
                q.Push(node.val);
                node = node.next;
            }

            var str = new StringBuilder();
            while (q.Count > 0)
            {
                str.Append(q.Pop());
            }
            return BigInteger.Parse(str.ToString());
        }
        
//        private static ulong GetNumber(ListNode node)
//        {
//            Queue<int> q = new Queue<int>();
//            while (node != null)
//            {
//                q.Enqueue(node.val);
//                node = node.next;
//            }
//            ulong r = 1;
//            ulong result = 0;            
//            while (q.Count > 0)
//            {
//                result += ((ulong)q.Dequeue() * r);
//                r *= 10;
//            }
//            return result;
//        
//        }
        
        
    }
}