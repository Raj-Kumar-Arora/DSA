using DSA.LinkedLists;
using System.Collections.Generic;

namespace LeetCodeProblems.LeetCode_150
{
    
     /* Definition for singly-linked list.*/
      public class ListNode {
          public int val;
          public ListNode next;
          public ListNode(int val=0, ListNode next=null) {
              this.val = val;
              this.next = next;
          }
      }
     

    internal static class LeetCode_72_Medium
    {
        public static void ReverseBetween()
        {
            //LinkedList<int> list = new();
            ListNode head = new ListNode();

            ////Case - 1
            int[] arr = [1, 2, 3, 4, 5];
            int left = 2, right = 4;

            ListNode t1 = null;
            foreach (int i in arr)
            {
                ListNode t = new ListNode(i);              

                if (t1 == null)
                    head = t;
                else
                    t1.next = t;

                t1 = t;
            }
           

            ////Case - 2

            //CASE - 3


            //Case - 4


            //Case - 5


            //Case - 6


            //Case - 7


            //Case - 8


            var actualOutput = 
                ReverseBetween(head, left, right);

           // Console.WriteLine("Actual Output  = " + actualOutput);
            Console.Read();
        }

        //NOT MY SOLUTION - ITS from LEETCODE C#
        public static ListNode ReverseBetween(ListNode head, int left, int right)
        {
            if (head == null || left == right) return head;

            //Approach 
            //Divide the input linkedin list to 3 parts
            //1st part - traverse 1st part as its till node with index = left. Keep track of last node of this part.
            //1st part - traverse list and reverse. Keep start and end pointers of linkedlist
            //3rd part - connect start and end of necessary parts

            //1st part - implementation
            ListNode t1 = head;
            int cnt = 1;

            while (t1 != null && cnt < left - 1)
            {
                t1 = t1.next;
                cnt++;
            }

            //2nd part - implementation
            ListNode t2 = t1.next;
            cnt++;
            ListNode prev = null, next = null;

            while (t2 != null && cnt <= right)
            {
                next = t2.next;
                t2.next = prev;
                prev = t2;
                if (next != null)
                    t2 = next;

                cnt++;
            }

            ListNode t2Start = prev;
            ListNode t3Start = t2;

            //3rd Part - - implementation
            //Connect t1 & t2 parts
            ListNode t2End = t1.next;
            t1.next = t2Start;
            t2End.next = t3Start;

            return head;
        }
    }
}
