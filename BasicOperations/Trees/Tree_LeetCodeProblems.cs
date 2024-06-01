using DSA.Trees;
using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;

namespace Trees
{
    public static class Tree_LeetCodeProblems
    {
        public static void Start()
        {
            int selectedSubOptionInt = -1;

            do
            {
                Console.WriteLine("\nSupported sub-options in Tree:");
                Console.WriteLine("1. MaxDepth");
                Console.WriteLine("2. IsSameTree");
                Console.WriteLine("3. InvertTree");
                Console.WriteLine("4. IsSymmetric");
                Console.WriteLine("5. PathSum");
                Console.WriteLine("6. CountNodes");
                Console.WriteLine("7. AverageOfLevels");
                Console.WriteLine("8. GetMinimumDifference");
                Console.WriteLine("9. SortedArrayToBST");
                Console.WriteLine("10. SearchInsert");
                Console.WriteLine("11. AddBinary");
                Console.WriteLine("12. ReverseBits");
                Console.WriteLine("13. HammingWeight");
                Console.WriteLine("14. SingleNumber");
                Console.WriteLine("15. IsPalindrome");
                Console.WriteLine("16. PlusOne");
                Console.WriteLine("17. MySqrt");
                Console.WriteLine("18. ClimbStairs");

                Console.WriteLine("\n0. EXIT !!!");
                Console.Write("\nSelect sub-option in Tree: ");

                int.TryParse(Console.ReadLine(), out selectedSubOptionInt);
                Console.WriteLine("");

                Console.WriteLine("Selected sub-option: " + selectedSubOptionInt.ToString() + "\n");
                Console.WriteLine(DSA.Common.Constants.STR_LINE_SEPERATOR);

                //TODO - here some creational design pattern can be used to create diff class object based on user selection
                //for the current scope, lets do it in seperate project

                switch (selectedSubOptionInt)
                {
                    case 1: Tree_LeetCodeProblems.MaxDepth(); break;
                    case 2: Tree_LeetCodeProblems.IsSameTree(); break;
                    case 3: Tree_LeetCodeProblems.InvertTree(); break;
                    case 4: Tree_LeetCodeProblems.IsSymmetric(); break;
                    case 5: Tree_LeetCodeProblems.HasPathSum(); break;
                    case 6: Tree_LeetCodeProblems.CountNodes(); break;
                    case 7: Tree_LeetCodeProblems.AverageOfLevels(); break;
                    case 8: Tree_LeetCodeProblems.GetMinimumDifference(); break;
                    case 9: Tree_LeetCodeProblems.SortedArrayToBST(); break;
                    case 10: Tree_LeetCodeProblems.SearchInsert(); break;
                    case 11: Tree_LeetCodeProblems.AddBinary(); break;
                    case 12: Tree_LeetCodeProblems.ReverseBits(); break;
                    case 13: Tree_LeetCodeProblems.HammingWeight(); break;
                    case 14: Tree_LeetCodeProblems.SingleNumber(); break;
                    case 15: Tree_LeetCodeProblems.IsPalindrome(); break;
                    case 16: Tree_LeetCodeProblems.PlusOne(); break;
                    case 17: Tree_LeetCodeProblems.MySqrt(); break;
                    case 18: Tree_LeetCodeProblems.ClimbStairs(); break;

                    case 0:
                        Console.WriteLine("You selected 0. Exiting...");
                        break;
                    default:
                        Console.WriteLine("!!! Wrong input selection !!!\n");
                        break;
                }
            } while (selectedSubOptionInt != 0);
        }

        private static void ClimbStairs()
        {
            ////CASE - 1 
            int x = 4;
            //int[] expectedOutput = 5 ;

            var actualOutput = ClimbStairs(x);
            Console.WriteLine(" Actual Output : " + actualOutput);
        }

        private static int ClimbStairs(int n)
        {
            if (n <= 0) return 0;
            if (n > 0 && n < 3) return n;

            int[] arr = new int[n+1];
            arr[1] = 1;
            arr[2] = 2;

            ClimbStairs(n, arr);
            return arr[n];
        }
        private static void ClimbStairs(int n, int[] arr)
        {
            for (int i = 3; i <= n; i++)
            {
                arr[i] = arr[i-1] + arr[i-2];
            }
        }

        //2nd & BETTER WAY
        private static int ClimbStairs_2ndWay(int n)
        {
            if (n <= 0) return 0;
            if (n > 0 && n < 3) return n;

            int sum = 0;
            int first = 1, second = 2;

            for (int i = 3; i<=n; i++)
            {
                sum = first + second;
                first = second;
                second = sum;
            }
            return sum;
        }
        private static void MySqrt()
        {
            //////CASE - 1 
            int x = 2147395600;
            ////int[] expectedOutput = 46340 ;

            ////CASE - 1 
            //int x = 4;
            //int[] expectedOutput = 2 ;

            var actualOutput = MySqrt(x);
            Console.WriteLine(" Actual Output : " + actualOutput);
        }
        private static int MySqrt(int x)
        {
            for (long i=1; i<=x; i++)
            {
                if (i * i > x)
                    return (int)(i-1);
            }
            return 0;
        }

        //tedious way 
        //private static int MySqrt(int x)
        //{
        //    int ret = 0;
        //    // 289398
        //    //for x=1, loop should check till i<=x

        //    //for (int i = 1; i <= x; i++)
        //    //{
        //    //    if ((i * i <= x) &&
        //    //            ((i + 1) * (i + 1) > x))
        //    //        return i;
        //    //}

        //    int i = 0;
        //    try
        //    {                
        //        for (i = 1; i <= x; i++)
        //        {
        //            if (i * i <= x)
        //            {
        //                int nextSqr = checked((i + 1) * (i + 1));

        //                //if overflow happened then (nextSqr > x ) will be false but 
        //                //value will be on -ve range of integer values
        //                if (nextSqr > x)
        //                    return i;
        //                //else if (nextSqr >= int.MinValue)
        //                //    return i;


        //                //if ((nextSqr > x) == true && 
        //                //     nextSqr > int.MaxValue == false)
        //                //    return i;

        //                //if ((nextSqr > x) == false &&
        //                //     nextSqr > int.MinValue == true)
        //                //    return i;
        //            }

        //            //return i;
        //        }

        //    }
        //    catch (OverflowException)
        //    {
        //        ret = i;
        //    }
        //    finally
        //    {   }

        //    return ret;
        //}
        private static void PlusOne()
        {
            ////CASE - 1 
            //int[] digits = new int[] { 4, 3, 2, 1 };
            //int[] expectedOutput = 4 3 2 2 ;

            ////CASE - 2 
            //int[] digits = new int[] { 4, 3, 9, 9 };
            //int[] expectedOutput = 4 4 0 0  ;

            ////CASE - 3 
            //int[] digits = new int[] { 9 };
            //int[] expectedOutput = 1 0  ;

            ////CASE - 4 
            //int[] digits = new int[] { 9,9,9 };
            //int[] expectedOutput = 1 0 0 0;

            ////CASE - 5 
            int[] digits = new int[] { 9, 0,9,9 };
            //int[] expectedOutput = 9 1 0 0 ;

            var actualOutput = PlusOne(digits);
            Console.WriteLine(" Actual Output : " + actualOutput);
        }
        private static int[] PlusOne(int[] digits)
        {
            int len = digits.Length;
            for (int i = 0; i<len; i++)
            {
                var currDigitIndex = len - 1 - i;

                if (digits[currDigitIndex] == 9)
                {
                    digits[currDigitIndex] = 0;
                    
                    //if current index is the MSB
                    if (currDigitIndex == 0)
                    {
                        // Create a new array with increased size
                        int[] newDigits = new int[len+1];

                        // Add 1 as MSB to the new array
                        newDigits[0] = 1;

                        // Copy existing elements to the new array
                        // digits array will copy starting from index 0
                        // and new array destination will be starting from index 1
                        // because at index 0 (MSB) we have stored 1 as incremented value
                        Array.Copy(digits,0, newDigits, 1,len);

                        return newDigits;
                    }
                }
                else
                {
                    digits[currDigitIndex]++;
                    break;
                }
            }
            return digits;
        }
        //private void PlusOne(int[] digits, int currDigitIndex)
        //{
        //    if (digits[currDigitIndex] == 9)
        //    {
        //        digits[currDigitIndex] = 0;
        //        PlusOne
        //        }
        //    else
        //    {
        //        digits[currDigitIndex]++;
        //        break;
        //    }
        //}
        private static void IsPalindrome()
        {
            ////CASE - 1 
            //int n = 141;
            //bool expectedOutput = true;

            ////CASE - 2 
            int n = -141;
            //bool expectedOutput = false;

            bool actualOutput = IsPalindrome(n);
            Console.WriteLine(" Actual Output : " + actualOutput);
        }
        private static bool IsPalindrome(int n)
        {
            string str = n.ToString();           
            int len = str.Length;
            for (int i = 0; i < len / 2; i++)
            {
                if (str[i] != str[len - 1 - i])
                    return false;
            }
            return true;
        }

        //failing for case - 2 (n = -141)
        //private static bool IsPalindrome(int n)
        //{
        //    List<int> digitsArr = new();
        //    while (n>0)
        //    {
        //        digitsArr.Add(n % 10);
        //        n /= 10;
        //    }
        //    int len = digitsArr.Count;
        //    for (int i = 0; i< len/2; i++)
        //    {
        //        if (digitsArr[i] != digitsArr[len - 1 - i])
        //            return false;
        //    }
        //    return true;
        //}

        private static void SingleNumber()
        {
            ////CASE - 1 
            int[] nums = new int[] { 2, 2, 1 };
            //int expectedOutput = 1;

            int actualOutput = SingleNumber(nums);
            Console.WriteLine(" Actual Output : " + actualOutput);
        }
        private static int SingleNumber(int[] nums)
        {
            Dictionary<int, int> dict = new();
            for (int i=0; i<nums.Length; i++)
            {
                if (dict.TryGetValue(nums[i], out int result))
                {
                    dict[nums[i]]++;
                }
                else
                    dict.Add(nums[i], 1);
            }
            foreach (var kvp in dict)
            {
                if (kvp.Value == 1)
                    return kvp.Key;
            }
            return -1;
        }

        private static void HammingWeight()
        {
            // CASE - 1
            //int n = 11;
            //expected output = 3

            //case - 2             
            int n = 2147483645;
            //expected output = 30

            int actualOutput = HammingWeight(n);
            Console.WriteLine(" Actual Output : " + actualOutput);
        }
        private static int HammingWeight(int n)
        {
            int count = 0;

            while (n > 0)
            {
                int lsd = n % 2;
                if (lsd == 1) 
                    count++;
                n = n / 2;
            }
            return count;
        }

        private static void ReverseBits()
        {
            ////CASE - 1 
            //uint n = 0b0101;   
            //expectedOutput = "0b 1010";  //decimal value 10

            //CASE - 2 
            //uint n = 0b1010;
            //expectedOutput = "0b 0101";  //decimal value 5

            //CASE - 3 
              uint n = 0b1101;
            //expectedOutput = "0b 1011";  //decimal value 11

            uint actualOutput = ReverseBits(n);
            Console.WriteLine(" Actual Output : " + actualOutput);
        }
        private static uint ReverseBits(uint n)
        {
            // APPROACH 
            // STEP - 1  Get ith bit from LSB towards MSB
            // STEP - 2  Left shift bit (32 - ith) times to perform reverse 
            // STEP - 3  Do OR operation with result of previous steps
            uint result = 0;
            int len = 4; // 32;  //32 bit unit length

            for (int i = 0; i < len; i++)
            {
                // STEP - 1  Get ith bit from LSB towards MSB
                uint t1 = (uint)(n & 1);
                n = n >> 1;

                // STEP - 2  Left shift bit (32 - ith) times to perform reverse 
                uint t2 = t1 << (len - i - 1);

                // STEP - 3  Do OR operation with result of previous steps
                result |= t2;
            }
            return result;

            //Sln # 2  - NOT WORKING 
            //result = result << 1;
            //if (n % 2 == 1)
            //    result++;
            //n = n >> 1;

            //1st sln NOT WORKING 
            //uint lsb = (uint)(n & i);
            //uint reverse = lsb << (len-i-1);
            //result = result | reverse;
            //n = n >> 1;
        }
        private static void AddBinary()
        {
            ////CASE - 1 
            string a = "11", b = "1";
            //string expectedOutput = "100";

            //CASE - 2 
            //string a = "1010", b = "1011";
            //string expectedOutput = "10101";

            //CASE - 3 
            //string a = "", b = "";
            //string expectedOutput = "100";

            string actualOutput = AddBinary(a, b);
            Console.WriteLine(" Actual Output : " + actualOutput);
        }
        private static string AddBinary(string a, string b)
        {
            int i = a.Length - 1 , j = b.Length - 1;
            int carry = 0;
            string result = "";

            //// Step - 1   Fetching LSB(Least significant bit) i.e. right most bit
            ///             from both strings and then taking their sum in SumDigit
            ///  Step - 2   Carry forward is calculated from SumDigit using / , % 
            ///             as sumDigit is integer
            ///  Step - 3   Adjust carry forward in final sum
            while (i >= 0 || j >= 0 || carry == 1)
            {
                int firstDigit  = (i >= 0) ? (a[i--] - '0') : 0;    
                int secondDigit = (j >= 0) ? (b[j--] - '0') : 0;
                int sumDigit = firstDigit + secondDigit + carry;
                carry = sumDigit / 2;

                result += (sumDigit % 2).ToString();
            }
            return new string(result.Reverse().ToArray());
        }
        private static void SearchInsert()
        {
            ////CASE - 1 
            //int[] nums = new int[] { 1, 3, 5, 6 };
            //int target = 5;
            ////int expectedOutput = 2;

            //CASE - 2 
            int[] nums = new int[] { 1, 3, 5, 6 };
            int target = 2;
            //int expectedOutput = 1;

            ////CASE - 3 
            //int[] nums = new int[] { 1, 3, 5, 6 };
            //int target = 7;
            ////int expectedOutput = 4;

            int actualOutput = SearchInsert(nums, target);
            Console.WriteLine(" Actual Output : " + actualOutput);

        }
        private static int SearchInsert(int[] nums, int target)
        {
            if (nums.Length == 0) return 0;
            int i = 0;
            for (i = 0; i<nums.Length; i++)
            {
                if (nums[i] == target) return i;
                else if (nums[i] < target) continue;
                else if (nums[i] > target)
                {
                    if (i == 0 || nums[i - 1] < target)
                        return i;
                }
            }
            //target not found in array and its higher than last element 
            //insert at end of array
            // if (i == nums.Length)   
            return i;
        }
        private static void SortedArrayToBST()
        {
            //////// CASE - 1
            int[] nums = new int[] { -10, -3, 0, 5, 9 };
            //int expectedOutput = 1;

            //////// CASE - 2

            //////// CASE - 3


            ////// CASE - 4   

            Node actualOutput = SortedArrayToBST(nums);

           // Console.WriteLine("Actual Output = " + new BinarySearchTree(actualOutput));
        }

        public static Node SortedArrayToBST(int[] nums)
        {
            //Approach:-
            //We will make use of the fact that the inorder traversal of BST gives Sorted Array
            //So we will reverse the logic of inorder traversal
            //by using Divide & Conquer technique
            if (nums.Length == 0) return null;

            int midIndex = nums.Length / 2;
            int[] leftArr = nums.Take(midIndex).ToArray();
            int[] rightArr = nums.Skip(midIndex+1).ToArray();

            Node node = new Node(nums[midIndex]);
            node.left = SortedArrayToBST(leftArr);
            node.right = SortedArrayToBST(rightArr);

            return node;
        }

        public static void GetMinimumDifference()
        {
            //////// CASE - 1
            //BinaryTree bt = new BinaryTree();
            //bt.root = new Node(4);
            //    bt.root.left = new Node(2);
            //        bt.root.left.left = new Node(1);
            //        bt.root.left.right = new Node(3);
            //    bt.root.right = new Node(6);
            ////int expectedOutput = 1;

            //////// CASE - 2
            //BinaryTree bt = new BinaryTree();
            //bt.root = new Node(1);
            //    bt.root.left = new Node(0);
            //    bt.root.right = new Node(48);
            //        bt.root.right.left = new Node(12);
            //        bt.root.right.right = new Node(49);
            //////int expectedOutput = 1;

            //////// CASE - 3
            //BinaryTree bt = new BinaryTree();
            //bt.root = new Node(1);
            //    bt.root.left = null;
            //    bt.root.right = new Node(3);
            //        bt.root.right.left = new Node(2);
            //////int expectedOutput = 1;

            ////// CASE - 4   236,104,701,null,227,null,911]
            BinaryTree bt = new BinaryTree();
            bt.root = new Node(236);
                bt.root.left = new Node(104);
                    bt.root.left.right = new Node(227);
                bt.root.right = new Node(701);
                    bt.root.right.right = new Node(911);
            //int expectedOutput = 1;

            var actualOutput = GetMinimumDifference(bt.root);

            Console.WriteLine("Actual Output = " + actualOutput);
        }

        private static int GetMinimumDifference(Node root)
        {
            //Approach:-
            //Since its BST, so inorder traversal will sort it 
            //then will find min diff b/w any 2 nodes

            //Step - 1 inorder traversal
            //int[] sortedArr = new();
            List<int> sortedList = new();
            InOrder(root, sortedList);

            //Step - 2 find 2 lowest values in list and get abs diff
            int minDiff = int.MaxValue;
            for (int i = 0; i < sortedList.Count-1; i++)
            {
                for (int j = i+1; j<sortedList.Count; j++)
                {
                    int tmpDiff = Math.Abs(sortedList[i] - sortedList[j]);
                    if ( tmpDiff < minDiff)
                        minDiff = tmpDiff;
                }
            }
            return minDiff;
        }
        private static void InOrder(Node node, List<int> sortedList)
        {
            if (node == null)
                return;

            InOrder(node.left, sortedList);
            sortedList.Add(node.data);
            InOrder(node.right, sortedList);
        }
        //BELOW CODE NOT WORKING for cae 4
        //I found the reason is misunderstanding about the problem
        //What I thought - Find min diff between 2 adjacent nodes in tree
        //What it is     - Find min diff between ANY 2 nodes in tree
        // se need to write this algo again
        //private static int GetMinimumDifference(Node root)
        //{
        //    if (root == null) return 0;

        //    int nMinDiff = int.MaxValue, lMinDiff = int.MaxValue, rMinDiff = int.MaxValue;
        //    if (root.left != null && root.right!= null)
        //    {
        //        nMinDiff = Math.Min (Math.Abs(root.data - root.left.data), Math.Abs(root.data - root.right.data));

        //        lMinDiff = GetMinimumDifference(root.left);
        //        rMinDiff = GetMinimumDifference(root.right);
        //    }
        //    else if (root.left != null && root.right == null)
        //    {
        //        nMinDiff = Math.Min(Math.Abs(root.data - root.left.data), int.MaxValue);

        //        lMinDiff = GetMinimumDifference(root.left);
        //        rMinDiff = int.MaxValue;
        //    }
        //    else if (root.left == null && root.right != null)
        //    {
        //        nMinDiff = Math.Min(int.MaxValue, Math.Abs(root.data - root.right.data));

        //        lMinDiff = int.MaxValue;
        //        rMinDiff = GetMinimumDifference(root.right);
        //    }

        //    return Math.Min(nMinDiff, Math.Min(lMinDiff, rMinDiff));
        //}
        private static void AverageOfLevels()
        {
            ////// CASE - 1
            //BinaryTree bt = new BinaryTree();
            //bt.root = new Node(3);
            //    bt.root.left = new Node(9);
            //    bt.root.right = new Node(20);
            //        bt.root.right.left = new Node(15);
            //        bt.root.right.right = new Node(7);
            ////int expectedOutput = 6;

            //// CASE - 2
            BinaryTree bt = new BinaryTree();
            bt.root = new Node(2147483647);
                bt.root.left = new Node(2147483647);
                bt.root.right = new Node(2147483647);
            var actualOutput = AverageOfLevels(bt.root);

            //Console.WriteLine("Actual Output = " + actualOutput);
        }
        public static IList<double> AverageOfLevels(Node root)
        {
            if (root == null) return null;

            Dictionary<int, List<long>> dictLevelToNodeValues = new Dictionary<int, List<long>>();
            SumOfLevels(root, 1, dictLevelToNodeValues);

            var result = new List<double>();
            foreach (var kvp in dictLevelToNodeValues)
            {
                //var lvlVal = kvp.Key;
                var lvlCnt = kvp.Value.Count;
                var lvlSum = kvp.Value.Sum();              
                result.Add((double)lvlSum/lvlCnt);
            }

            return result;
        }
        private static void SumOfLevels(Node node, int level, Dictionary<int, List<long>> dictLevelToNodeValue)
        {
            if (node == null) return;

            if (dictLevelToNodeValue.TryGetValue(level, out var levelList))
            {
                levelList.Add(node.data);
            }
            else
            {
                var list = new List<long>();
                list.Add(node.data);
                dictLevelToNodeValue.Add(level, list);
            }


            SumOfLevels(node.left, level + 1, dictLevelToNodeValue);
            SumOfLevels(node.right, level + 1, dictLevelToNodeValue);
        }
        private static void CountNodes()
        {
            //// CASE - 1
            //BinaryTree bt = new BinaryTree();
            //bt.root = new Node(1);
            //    bt.root.left = new Node(2);
            //        bt.root.left.left = new Node(4);
            //        bt.root.left.right = new Node(5);
            //    bt.root.right = new Node(3);
            //        bt.root.right.left = new Node(6);
            //int expectedOutput = 6;

            //// CASE - 2
            //BinaryTree bt = new BinaryTree();
            //int expectedOutput = 0;

            //// CASE - 3
            BinaryTree bt = new BinaryTree();
            bt.root = new Node(1);
            int expectedOutput = 1;

            int actualOutput = CountNodes(bt.root);

            Console.WriteLine("Actual Output = " + actualOutput);
        }

        private static int CountNodes(Node node)
        {
            if (node == null) 
                return 0;
            else
            {
                return CountNodes(node.left) + CountNodes(node.right) + 1;
            }
        }

        private static void HasPathSum()
        {
            //// CASE - 1
            //BinaryTree bt = new BinaryTree();
            //bt.root = new Node(5);
            //    bt.root.left = new Node(4);
            //        bt.root.left.left = new Node(11);
            //            bt.root.left.left.left = new Node(7);
            //            bt.root.left.left.right = new Node(2);
            //    bt.root.right = new Node(8);
            //        bt.root.right.left = new Node(13);
            //        bt.root.right.right = new Node(4);
            //            bt.root.right.right.right = new Node(1);
            //int targetSum = 22;
            //bool expectedOutput = true;

            //// CASE - 2  [1,2]
            //BinaryTree bt = new BinaryTree();
            //bt.root = new Node(1);
            //bt.root.left = new Node(2);
            //int targetSum = 1;
            ////bool expectedOutput = false;

            // CASE - 3  [1]
            //BinaryTree bt = new BinaryTree();
            //bt.root = new Node(1);
            //int targetSum = 1;
            ////bool expectedOutput = true;

            //// CASE - 4  [-2,null,-3]
            //BinaryTree bt = new BinaryTree();
            //bt.root = new Node(-2);
            //    bt.root.right = new Node(-3);
            //int targetSum = -2;
            ////bool expectedOutput = false;

            //// CASE - 5  [1,2,null,3,null,4,null,5
            BinaryTree bt = new BinaryTree();
            bt.root = new Node(1);
                bt.root.left = new Node(2);
                    bt.root.left.left = new Node(3);
                        bt.root.left.left.left = new Node(4);
                            bt.root.left.left.left.left = new Node(5);
            int targetSum = 6;
            //bool expectedOutput = false;

            //// CASE - 6    [5,4,8,11,null,13,4,7,2,null,null,null,1]
            ///// same as case 1
            //BinaryTree bt = new BinaryTree();
            //bt.root = new Node(5);
            //    bt.root.left = new Node(4);
            //        bt.root.left.left = new Node(11);
            //        bt.root.left.left.left = new Node(7);
            //        bt.root.left.left.right = new Node(2);
            //    bt.root.right = new Node(8);
            //        bt.root.right.left = new Node(13);
            //        bt.root.right.right = new Node(4);
            //        bt.root.right.right.right = new Node(1);
            //int targetSum = 22;
            //bool expectedOutput = true;

            bool actualOutput = HasPathSum(bt.root, targetSum);

            Console.WriteLine("Actual Output = " + actualOutput);
        }
        public static bool HasPathSum(Node root, int targetSum)
        {
            if (root == null) return false;

            int currSum = root.data;

            if ((root.left != null && HasPathSum(root.left, targetSum, currSum)) ||
               (root.right != null && HasPathSum(root.right, targetSum, currSum)))
                return true;
            else
            {
                if (root.left == null && root.right == null && currSum == targetSum)
                    return true;
            }
            return false;
        }
        private static bool HasPathSum(Node node, int targetSum, int currSum)
        {
            currSum += node.data;

            if ((node.left != null && HasPathSum(node.left, targetSum, currSum)) ||
                (node.right != null && HasPathSum(node.right, targetSum, currSum)))
                return true;
            else
            {
                if (node.left == null && node.right == null && currSum == targetSum)
                    return true;
            }

            return false;

            // ** Following code not passing case [1,2] / targetSum = 1 **
            //if (node == null)
            //{
            //    if (currSum == targetSum)
            //        return true;
            //}
            //else
            //{
            //    currSum += node.data;
            //    return (HasPathSum(node.left, targetSum, currSum) ||
            //            HasPathSum(node.right, targetSum, currSum));
            //}

            //return false;

            //if (node == null)
            //{
            //    if (currSum == targetSum) 
            //        return true;
            //}
            //else
            //{
            //    currSum += node.data;
            //    return (HasPathSum(node.left, targetSum, currSum) ||
            //            HasPathSum(node.right, targetSum, currSum));
            //}

            //return false;
        }

        public static void IsSymmetric()
        {
            // CASE - 1
            BinaryTree bt = new BinaryTree();
            bt.root = new Node(1);
            bt.root.left = new Node(2);
            bt.root.right = new Node(2);
            bt.root.left.left = new Node(3);
            bt.root.left.right = new Node(4);
            bt.root.right.left = new Node(4);
            bt.root.right.right = new Node(3);
            //bool expectedOutput = true;

            // CASE - 2  [1,2,2,2,null,2]
            //BinaryTree bt = new BinaryTree();
            //bt.root = new Node(1);
            //bt.root.left = new Node(2);
            //bt.root.right = new Node(2);
            //bt.root.left.left = new Node(2);
            //bt.root.left.right = null;
            //bt.root.right.left = new Node(2);
            //bool expectedOutput = false;


            bool actualOutput = IsSymmetric(bt.root);

            Console.WriteLine("Actual Output = " + actualOutput);
        }

        //private bool IsSymmetric(TreeNode root)
        //{
        //    if (root == null) return false;

        //    List<int> leftTreeList = new();
        //    List<int> rightTreeList = new();
        //    InOrderTraversal(root.left, leftTreeList);
        //    MirrorInOrderTraversal(root.right, rightTreeList);

        //    if (leftTreeList.Count != rightTreeList.Count)
        //        return false;

        //    for (int i = 0; i < leftTreeList.Count; i++)
        //        if (leftTreeList[i] != rightTreeList[i])
        //            return false;

        //    return true;
        //}

        // Code submitted/ accepted to / by LeetCode
        private static bool IsSymmetric(Node root)
        {
            if (root == null) return true;

            return IsMirror(root.left, root.right);
        }
        private static bool IsMirror(Node node1, Node node2)
        {
            if (node1 == null && node2 == null) return true;
            if (node1 == null || node2 == null) return false;

            return (node1.data  == node2.data) && IsMirror(node1.left, node2.right) && IsMirror(node1.right, node2.left);
        }

        //BELOW CODE NOT WORKING FOR 1 CASE - CASE - 2  [1,2,2,2,null,2]
        //private static bool IsSymmetric(Node root)
        //{
        //    if (root == null) return false; 

        //    List<int> leftTreeList = new ();
        //    List<int> rightTreeList = new ();
        //    InOrderTraversal(root.left, leftTreeList);
        //    MirrorInOrderTraversal(root.right, rightTreeList);

        //    if (leftTreeList.Count != rightTreeList.Count)
        //        return false;

        //    for (int i = 0; i < leftTreeList.Count; i++)
        //        if (leftTreeList[i] != rightTreeList[i]) 
        //            return false;

        //    return true;
        //}

        ////InOrder Traversal =>     lNr => left -> root Node -> right 
        //private static void InOrderTraversal (Node node, List<int> treeList)
        //{
        //    if (node == null)
        //    {
        //        treeList.Add(int.MaxValue);
        //        return;
        //    }

        //    //if (node.left != null) 
        //        InOrderTraversal(node.left, treeList);
        //    treeList.Add (node.data);
        //    //if (node.right != null) 
        //        InOrderTraversal(node.right, treeList);
        //}

        ////MirrorInOrder Traversal =>     rNl => right -> root Node -> left 
        //private static void MirrorInOrderTraversal(Node node, List<int> treeList)
        //{
        //    if (node == null)
        //    {
        //        treeList.Add(int.MaxValue);
        //        return;
        //    }

        //    //if (node.right != null)  
        //        MirrorInOrderTraversal(node.right, treeList);
        //    treeList.Add(node.data);
        //    //if (node.left != null) 
        //        MirrorInOrderTraversal(node.left, treeList);
        //}


        public static void InvertTree()
        {
            // CASE - 1
            //BinaryTree bt = new BinaryTree();
            //bt.root = new Node(10);
            //bt.root.left = new Node(11);
            //bt.root.right = new Node(12);
            //bt.root.left.left = new Node(13);
            //bt.root.left.right = new Node(14);
            //bt.root.right.left = new Node(15);
            //bt.root.right.right = new Node(16);

            //// CASE - 2
            //BinaryTree bt = new BinaryTree();
            //bt.root = new Node(1);
            //bt.root.left = new Node(2);

            // CASE - 3
            BinaryTree bt = new BinaryTree();
            bt.root = new Node(2);
            bt.root.left = new Node(3);
            bt.root.right = null;
            bt.root.left.left = new Node(1);


            Console.WriteLine("Tree BEFORE Invert : " );
            bt.Display();

            var newRoot = InvertTree(bt.root);
            bt.root = newRoot;
            Console.WriteLine("Tree AFTER Invert : ");
            bt.Display();
        }
        // Code submitted/ accepted to / by LeetCode
        //private static TreeNode InvertTree(TreeNode root)
        //{
            //if (root == null)
            //    return null;

            //InvertTree(root.left);
            //InvertTree(root.right);

            ////Swap the nodes
            //TreeNode tmp = root.left;
            //root.left = root.right;
            //root.right = tmp;

            //return root;
        //}


        private static Node InvertTree(Node root)
        {
            if (root == null)
                return null;

            InvertTree(root.left);
            InvertTree(root.right);

            //Swap the nodes
            Node tmp = root.left;
            root.left = root.right;
            root.right = tmp;

            return root;
        }
        //ALL CASES NOT WORKING - so taking most voted soln from leetcode 

        //private static Node InvertTree(Node root)
        //{
        //    if (root == null)
        //        return null;

        //    Queue<Node> queue = new ();
        //    queue.Enqueue(root);
        //    List<Node> invertedTree = new (); 

        //    //We will do Level Traversal for tree with swapping of left <-> right to invert tree
        //    while (queue.Count > 0)
        //    {
        //        Node node = queue.Dequeue();
        //        if (node != null)
        //        {
        //            invertedTree.Add(new Node (node.data));
        //            queue.Enqueue(node.right);
        //            queue.Enqueue(node.left);
        //        }
        //        else
        //        {
        //            invertedTree.Add(null);
        //        }
        //    }

        //    //now we need to create tree from invertedTree list by assigning left/right childs
        //    for (int i = 1; i < invertedTree.Count; i++)
        //    {
        //        //index of parent node to which current node will be assigned as left/right
        //        int parentNodeIndex = (i - 1) / 2;
        //        bool isLeftChild = (i % 2 == 1);  //if it will be left/right child of binary tree?
        //        if (invertedTree[parentNodeIndex] != null)
        //        {
        //            if (isLeftChild)
        //                invertedTree[parentNodeIndex].left = invertedTree[i];
        //            else
        //                invertedTree[parentNodeIndex].right = invertedTree[i];
        //        }
        //    }
        //    return invertedTree[0];
        //}
        public static void IsSameTree()
        {
            // CASE - 1
            //BinaryTree bt1 = new BinaryTree()
            //{ 
            //    root = new Node() 
            //    {   data = 1,               
            //        left = new Node()  { data = 2 },
            //        right = new Node() { data = 3 }
            //    }
            //};
            //BinaryTree bt2 = new BinaryTree()
            //{
            //    root = new Node()
            //    {
            //        data = 1,
            //        left = new Node() { data = 2 },
            //        right = new Node() { data = 3 }
            //    }
            //};

            // CASE - 2
            BinaryTree bt1 = new BinaryTree()
            {
                root = new Node()
                {
                    data = 1,
                    left = new Node() { data = 2 }
                }
            };
            BinaryTree bt2 = new BinaryTree()
            {
                root = new Node()
                {
                    data = 1,
                    right = new Node() { data = 2 }
                }
            };

            bool actualOutput = IsSameTree(bt1.root, bt2.root);

            Console.WriteLine("Actual Output = " + actualOutput);
        }
        // private static bool IsSameTree(TreeNode p, TreeNode q)
        // Code submitted/ accepted to / by LeetCode

        private static bool IsSameTree(Node p, Node q)
        {
            if (p == q) return true;
            if (p == null ||  q == null) return false;

            if (p.data != q.data) return false;

            if (IsSameTree(p.left, q.left) == false)
                return false;

            if (IsSameTree(p.right, q.right) == false)
                return false;

            return true;
        }


        //Similar to BinaryTree.cs - Height()
        public static void MaxDepth ()
        {
            //CASE - 1
            BinaryTree bt = new BinaryTree()
            {
                root = new Node()
                {
                    data = 3,
                    left = new Node() { data = 9 },
                    right = new Node() { data = 20,
                        left = new Node() { data = 15 },
                        right = new Node() { data = 7 }
                    }
                }
            };
            var actualOutput = MaxDepth(bt.root);

            Console.WriteLine("Actual Output = " + actualOutput);
        }
        //private int MaxDepth(TreeNode root)
        // Code submitted/ accepted to / by LeetCode
        private static int MaxDepth(Node root)
        {
            if (root == null)
                return 0;
            else
            {
                int ld = MaxDepth(root.left);
                int rd = MaxDepth(root.right);

                if (ld >= rd)
                    return ld + 1;
                else
                    return rd + 1;
            }
        }
    }
}
