using DSA.LinkedLists;
using LinkedLists;

namespace ConsoleApp1.LeetCode_150
{
    //Definition for singly-linked list.
    //public class ListNode
    //{
    //    public int val;
    //    public ListNode next;
    //    public ListNode(int x)
    //    {
    //        val = x;
    //        next = null;
    //    }
    //}
    internal static class LeetCode_22_Easy
    {
        public static void Test()
        {
            //LinkedList<int> l1 = new LinkedList<int>();
            //LinkedList<int> l2 = new LinkedList<int>();

            //////Case - 1
            //int[] arr1 = { 1, 2, 4 };
            //foreach (int i in arr1)
            //{
            //    l1.AddLast(new LinkedListNode<int>(i));
            //}
            //LinkedListNode<int> list1 = l1.First;

            //int[] arr2 = { 1, 3, 4 };
            //foreach (int i in arr2)
            //{
            //    l2.AddLast(new LinkedListNode<int>(i));
            //}
            //LinkedListNode<int> list2 = l2.First;


            //********************************************************************/
            //*** This code is not tested - its just fixed to fix build errors ***/
            //*** while merging Leetcode project to DSA main project           ***/
            //********************************************************************/

            LinkedList l1 = new LinkedList();
            LinkedList l2 = new LinkedList();

            ////Case - 1
            int[] arr1 = { 1, 2, 4 };
            foreach (int i in arr1)
            {
                l1.Insert(i);
            }
            Node list1 = l1.Start;

            int[] arr2 = { 1, 3, 4 };
            foreach (int i in arr2)
            {
                l2.Insert(i);
            }
            Node list2 = l2.Start;

            //// bool expOutput = [1,1,2,3,4,4];

            ////Case - 2


            ////CASE - 3 



            //Case - 4


            //Case - 5



            var actualOutput = MergeTwoLists(list1, list2);

            //Console.WriteLine("actualOutput = " + actualOutput);
        }

        // ********************************************/
        // Following code was submitted to LEETCODE   */
        // for its reference see   my git Repositry   */
        //  DSA |  LinkedLists |  MergeTwoLists CLASS */
        // ********************************************/

        private static Node MergeTwoLists(Node list1, Node list2)
        {
            if (list1 == null)
                return list2;
            if (list2 == null)
                return list1;

            Node t1 = list1, t2 = list2;       //references to current traversal positions of list1 & list2
            Node mStart = null, mEnd = null;   //references to Start and last position of merged list

            //Init mStart & mEnd
            if (t1.data <= t2.data)
            {
                mStart = t1; mEnd = t1; t1 = t1.next;
            }
            else
            {
                mStart = t2; mEnd = t2; t2 = t2.next;
            }

            while (t1 != null && t2 != null)
            {
                if (t1.data <= t2.data)
                {
                    mEnd.next = t1;
                    mEnd = mEnd.next;
                    t1 = t1.next;
                }
                else
                {
                    mEnd.next = t2;
                    mEnd = mEnd.next;
                    t2 = t2.next;
                }
            }
            if (t1 == null)
                mEnd.next = t2;
            if (t2 == null)
                mEnd.next = t1;

            return mStart;
        }

        /// ** THE FOLLOWING CODE is NOT WORKING 
        /// ** BCZ IT MAKES USE OF C#.NET's class LINKED LIST which does not support assigning TO NEXT pointe of NODE
        //public static LinkedListNode<int> MergeTwoLists(LinkedListNode<int> list1, LinkedListNode<int> list2)
        //{
        //    LinkedList<int> l1 = new LinkedList<int>();

        //    // We are merging list2 to list1 (without creating any additional list)
        //    // so we will need reference to current nodes in list1 and list 2 and previous node in list1

        //    // t1 & t2 are reference to current nodes in list1 & lis2 
        //    // t1p is reference to previous node in list1
        //    LinkedListNode<int> t1p = null, t1 = list1, t2 = list2;  

        //    while (t1 != null && t2 != null)
        //    {
        //        if (t1.Value < t2.Value)
        //        {
        //            if (t1.Next != null)
        //            {
        //                //traverse to next node
        //                t1p = t1;
        //                t1 = t1.Next;
        //            }
        //            else
        //            {
        //                //t1 is last node of list1. Add t2 after t1
        //                //list2 is already sorted so adding t2 after t1 will complete the merge operation

        //                t1.Next = t2;
        //            }
        //        }
        //        else
        //        {
        //            //insert t2 between t1p & t1
        //            //insert t2 between t1p & t1
        //            ListNode t2n = t2.next;

        //            if (t1p != null)
        //                t1p.next = t2;
        //            else
        //            {   //we are inserting t2 at starting of list1
        //                //ListNode t1n = t1.next;
        //                list1 = t2;
        //                t2.next = t1;
        //                t2 = t2n;
        //            }
        //            t2.next = t1;

        //            t1p = t2;
        //            t2 = t2n;
        //        }
        //    }
        //    return list1;
        //}
    }
}