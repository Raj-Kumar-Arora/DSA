using DSA.LinkedLists;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{

    //   /// SOLVED THIS ON LEETCODE DIRECTLY AND NOT HERE
    //   /// HERE IS THE CODE SUBMITTED OVER THERE FOR REFERENCE
    //   /// https://leetcode.com/problems/merge-two-sorted-lists/?envType=study-plan-v2&envId=top-interview-150
    //   /**
    //* Definition for singly-linked list.
    //* public class ListNode {
    //*     public int val;
    //*     public ListNode next;
    //*     public ListNode(int val=0, ListNode next=null) {
    //*         this.val = val;
    //*         this.next = next;
    //*     }
    //* }
    //*/
    //public class Solution
    //{
    //public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    //{
    //// We are merging list2 to list1 (without creating any additional list)
    //// so we will need reference to current ListNodes in list1 and list 2 and previous ListNode in list1

    //// t1 & t2 are reference to current ListNodes in list1 & lis2 
    //// t1p is reference to previous ListNode in list1
    //// Similarly t2n = reference to next ListNode of t2 in list2

    //ListNode t1p = null, t1 = list1;
    //ListNode t2 = list2;
    //while (t2 != null)
    //{
    //    ListNode t2n = t2.next;

    //    //If list1 empty, return list2 head
    //    if (list1 == null)
    //        return list2;

    //    while (t1 != null)
    //    {
    //        if (t1.val == t2.val)           //CASE -1 : Insert t2 after t1
    //        {
    //            ListNode t1n = t1.next;
    //            t1.next = t2;
    //            t2.next = t1n;

    //            // traverse to next ListNode in list1
    //            t1p = t1;
    //            t1 = t1.next;
    //            break;
    //        }
    //        else if (t1.val < t2.val)       //CASE -2 : Insert t2 after t1
    //        {
    //            // if t1 is the only ListNode then insert t2 after t1
    //            if (t1.next == null)
    //            {
    //                ListNode t1n = t1.next;
    //                t1.next = t2;
    //                t2.next = t1n;

    //                // traverse to next ListNode in list1
    //                t1p = t1;
    //                t1 = t1.next;
    //                break;
    //                //return list1;
    //            }
    //            // else traverse to next ListNode to find the suitable place to add t2
    //            // e.g. t1 is pointing to 1st ListNode of list1 [1,2,4]
    //            // and t2 is also pointing to 1st ListNode of list2 [3,5]
    //            // so we need to traverse till  t1p = 2 and t1=4 in list1
    //            else
    //            {
    //                // traverse to next ListNode in list1
    //                t1p = t1;
    //                t1 = t1.next;
    //            }
    //        }
    //        else if (t1.val > t2.val)
    //        {
    //            if (t1p == null)        //CASE - 3 : //inserting t2 at starting of list1
    //            {
    //                t2.next = t1;
    //                list1 = t2;

    //                // traverse to next ListNode in list1
    //                t1p = t2;         //t1p is now  set to t2 
    //                //t1 = t1.next;
    //                break;
    //            }
    //            else if (t1p.val < t2.val)  //CASE - 4 : // insert t2 between t1p & t1
    //            {
    //                t1p.next = t2;
    //                t2.next = t1;

    //                // traverse to next ListNode in list1
    //                t1p = t2;       //t1p is now  set to t2
    //                //t1 = t1.next;
    //                break;
    //            }
    //        }
    //    }

    //    t1p = null; t1 = list1;

    //    //traverse to next ListNode in list2
    //    t2 = t2n;
    //}

    //return list1;
    //    }
    //}

    // 2nd Way
    //private ListNode Merge_2ndWay(ListNode list1, ListNode list2)
    //{
    //    if (list1 == null)
    //        return list2;
    //    if (list2 == null)
    //        return list1;

    //    ListNode t1 = list1, t2 = list2;       //references to current traversal positions of list1 & list2
    //    ListNode mStart = null, mEnd = null;   //references to Start and last position of merged list

    //    //Init mStart & mEnd
    //    if (t1.val <= t2.val)
    //    {
    //        mStart = t1; mEnd = t1; t1 = t1.next;
    //    }
    //    else
    //    {
    //        mStart = t2; mEnd = t2; t2 = t2.next;
    //    }

    //    while (t1 != null && t2 != null)
    //    {
    //        if (t1.val <= t2.val)
    //        {
    //            mEnd.next = t1;
    //            mEnd = mEnd.next;
    //            t1 = t1.next;
    //        }
    //        else
    //        {
    //            mEnd.next = t2;
    //            mEnd = mEnd.next;
    //            t2 = t2.next;
    //        }
    //    }
    //    if (t1 == null)
    //        mEnd.next = t1;
    //    if (t2 == null)
    //        mEnd.next = t2;

    //    return mStart;
    //}

    /// <summary>
    /// below code is COMPLETE & WORKING
    /// and sumitted to LEETCODE 
    /// </summary>
    public static class Merging2SoredLists
    {
        public static void Merge()
        {
            //Console.WriteLine("TO BE IMPLEMENTED...");

            LinkedList list1 = new();
            LinkedList list2 = new();

            //Console.WriteLine("Details of 1st list...");
            //list1.Create();
            //Console.WriteLine("Details of 2nd list...");
            //list2.Create();

            // CASE - 1
            //list1.Insert(1);
            //list1.Insert(2);
            //list1.Insert(4);

            //list2.Insert(1);
            //list2.Insert(3);
            //list2.Insert(4);

            // CASE - 2
            //list1.Insert(-2);
            //list1.Insert(-1);
            //list1.Insert(5);
            //list1.Insert(6);

            //list2.Insert(5);
            //list2.Insert(8);
            //list2.Insert(8);

            // CASE - 3
            //list1.Insert(5);
            //list2.Insert(1);
            //list2.Insert(2);
            //list2.Insert(4);

            // CASE - 4
            // list1 = [-10,-9,-6,-4,1,9,9]
            // list2 = [-5,-3,0,7,8,8]

            //list1.Insert(-10);
            //list1.Insert(-9);
            //list1.Insert(-6);
            //list1.Insert(-4);
            //list1.Insert(1);
            //list1.Insert(9);
            //list1.Insert(9);

            //list2.Insert(-5);
            //list2.Insert(-3);
            //list2.Insert(0);
            //list2.Insert(7);
            //list2.Insert(8);
            //list2.Insert(8);

            // CASE - 5
            list1.Insert(1);
            //list2 is empty in this case


            Console.WriteLine("BEFORE MERGING");
            Console.WriteLine("1st list:"); list1.Display();
            Console.WriteLine();
            Console.WriteLine("2nd list:"); list2.Display();
            Console.WriteLine();

            //Node mergedList = Merge_1stWay(list1.Start, list2.Start);
            Node mergedList = Merge_2ndWay(list1.Start, list2.Start);

            list1.Start = mergedList;
            Console.WriteLine("AFTER MERGING");
            Console.WriteLine("Merged list :"); list1.Display();
        }

        private static Node Merge_2ndWay(Node list1, Node list2)
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
        private static Node Merge_1stWay(Node list1, Node list2)
        {
            // We are merging list2 to list1 (without creating any additional list)
            // so we will need reference to current nodes in list1 and list 2 and previous node in list1

            // t1 & t2 are reference to current nodes in list1 & lis2 
            // t1p is reference to previous node in list1
            // Similarly t2n = reference to next node of t2 in list2

            Node t1p = null, t1 = list1;
            Node t2 = list2;
            while (t2 != null)
            {
                Node t2n = t2.next;

                //If list1 empty, return list2 head
                if (list1 == null)
                    return list2;

                while (t1 != null)
                {
                    if (t1.data == t2.data)           //CASE -1 : Insert t2 after t1
                    {
                        Node t1n = t1.next;
                        t1.next = t2;
                        t2.next = t1n;

                        // traverse to next node in list1
                        t1p = t1;
                        t1 = t1.next;
                        break;
                    }
                    else if (t1.data < t2.data)       //CASE -2 : Insert t2 after t1
                    {
                        // if t1 is the only node then insert t2 after t1
                        if (t1.next == null)
                        {
                            Node t1n = t1.next;
                            t1.next = t2;
                            t2.next = t1n;

                            // traverse to next node in list1
                            t1p = t1;
                            t1 = t1.next;
                            break;
                            //return list1;
                        }
                        // else traverse to next node to find the suitable place to add t2
                        // e.g. t1 is pointing to 1st node of list1 [1,2,4]
                        // and t2 is also pointing to 1st node of list2 [3,5]
                        // so we need to traverse till  t1p = 2 and t1=4 in list1
                        else
                        {
                            // traverse to next node in list1
                            t1p = t1;
                            t1 = t1.next;
                        }
                    }
                    else if (t1.data > t2.data)
                    {
                        if (t1p == null)        //CASE - 3 : //inserting t2 at starting of list1
                        {
                            t2.next = t1;
                            list1 = t2;

                            // traverse to next node in list1
                            t1p = t2;         //t1p is now  set to t2 
                            //t1 = t1.next;
                            break;
                        }
                        else if (t1p.data < t2.data)  //CASE - 4 : // insert t2 between t1p & t1
                        {
                            t1p.next = t2;
                            t2.next = t1;

                            // traverse to next node in list1
                            t1p = t2;       //t1p is now  set to t2
                            //t1 = t1.next;
                            break;
                        }
                    }
                }

                t1p = null; t1 = list1;

                //traverse to next node in list2
                t2 = t2n;
            }

            return list1;
        }
    }
}
