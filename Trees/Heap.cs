using DSA.Common;
using DSA.Trees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DSA.Trees
{
    public class Heap
    {
        #region properties
        private int[] DataArr { get; set; }
        private int Size { get; set; }
        #endregion public properties

        #region CTORs
        public Heap() 
        {
            DataArr = new int[10];
            Size= 0;
            DataArr[0] = 99999;
        }
        public Heap(int size) 
        {
            DataArr = new int[size];
            Size= 0;
            DataArr[0] = 99999;
        }
        #endregion CTORs

        #region Basic Binary Search Tree Operations
        public void Create_Tree()
        {
            //Insert(13);
            //Insert(44);
            //Insert(10);
            //Insert(79);
            //Insert(99);
            //Insert(45);

            DataArr = new int[50];
            Insert(85);
            Insert(70);
            Insert(55);
            Insert(56);
            Insert(30);
            Insert(42);
            Insert(33);
            Insert(16);
            Insert(28);
            Insert(19);
            Insert(20);
            Insert(25);
            Insert(32);
            //Insert();
            //Insert();
            //Insert();
            //Insert();
        }

        public void Display()
        {
            if (IsHeapEmpty() == true)
            {
                Console.WriteLine("The heap is empty.");
                return;
            }

            Console.Write("|");
            for (int i=1; i<=Size; i++)
                Console.Write("  " + DataArr[i]);
        }
        public void Insert()
        {
            Console.Write("Enter value of data for new node: ");
            int data;
            if (int.TryParse(Console.ReadLine(), out data) == false)
            {
                Console.WriteLine("Please enter a valid integer no.");
                return;
            }

            Insert(data);
        }
        private void Insert(int data)
        {
            Size++;

            //TODO : find an improvement. Limitation due to array size resize not possible
            //if (Size == 10)
            //{
            //    DataArr = new int[50];      //TODO : find an improvement. Limitation due to array size resize not possible
            //}
            DataArr[Size] = data;
            RestoreUp(Size);
        }
        private void RestoreUp(int i)
        {            
            if (i == 1) return; // Reached top of heap i.e. at root

            int iParent = i / 2;
            if (DataArr[iParent] < DataArr[i])
            {
                int tmp = DataArr[iParent];
                DataArr[iParent] = DataArr[i];
                DataArr[i] = tmp;

                RestoreUp(iParent);
            }
        }
        public void Delete()
        {
            if (IsHeapEmpty() == true) return;

            Console.Write("Enter value of data for node to delete: ");
            int data;
            if (int.TryParse(Console.ReadLine(), out data) == false)
            {
                Console.WriteLine("Please enter a valid integer no.");
                return;
            }

            //Check if data value present in heap
            //if (DataArr.Contains(data))
            int index = Array.IndexOf(DataArr, data);
            if ( index != -1)
                Delete(data, index);
            else
                Console.WriteLine("Entered data is not present in heap!");
        }

        private void Delete(int data, int index)
        {
            //if (index > 0 ) //TODO for root node
            //{
            //    int replacementItem = DataArr[index + 1];
            //    int parentIndex = index / 2;
            //    int parentItem = DataArr[parentIndex];
            //    if (replacementItem > parentItem)
            //    {
            //        RestoreDown(parentIndex);
            //    }
            //}

            int replcementIndex = Size;
            int replacementItem = DataArr[replcementIndex];

            Size--;
            DataArr[index] = replacementItem;
            RestoreDown(index);
        }

        private void RestoreDown(int i)
        {
            if ( Size/2 < i)
            {
                return;
            }
            int leftIndex = 2 * i;
            int rightIndex = 2 * i + 1;
            //if (leftIndex == Size || rightIndex == Size)
            //    return;

            int leftItem = DataArr[leftIndex];
            int rightItem = DataArr[rightIndex];

            if (DataArr[i] < leftItem || DataArr[i] < rightItem)
            {
                if (leftItem >= rightItem)
                {
                    int tmp = DataArr[i];
                    DataArr[i] = DataArr[leftIndex];
                    DataArr[leftIndex] = tmp;

                    RestoreDown(leftIndex);
                }
                else if (rightItem > leftItem)
                {
                    int tmp = DataArr[i];
                    DataArr[i] = DataArr[rightIndex];
                    DataArr[rightIndex] = tmp;

                    RestoreDown(rightIndex);
                }
            }
        }

        private bool IsHeapEmpty()
        {
            return Size == 0;
        }
        #endregion Basic Binary Search Tree Operations

    }
}
