namespace LeetCodeProblems.Top_15_Patterns
{
    // 240. Search a 2D Matrix II
    // https://leetcode.com/problems/search-a-2d-matrix-ii/description/

    //solution - https://leetcode.com/problems/search-a-2d-matrix-ii/solutions/2327770/3-different-solutions-c-o-m-n-complexity/

    public class LeetCodePatterns_9_2
    {
        public static void SearchMatrix()
        {
            ////Case - 1
            //int[][] nums = [[1,4,7,11,15],[2,5,8,12,19],[3,6,9,16,22],[10,13,14,17,24],[18,21,23,26,30]];
            //int target = 5;

            ////Case - 2
            //int[][] nums = [[1, 4, 7, 11, 15], [2, 5, 8, 12, 19], [3, 6, 9, 16, 22], [10, 13, 14, 17, 24], [18, 21, 23, 26, 30]];
            //int target = 20;
            //var actualOutput = SearchMatrix(nums, target);

            ////Case - 3
            //int[][] nums = [[-1, 3]];
            //int target = 3;

            ////Case - 4
            //int[][] nums = [[-1, 3]];
            //int target = -1;

            //case - 5
            int[][] nums = [[1, 4, 7, 11, 15], [2, 5, 8, 12, 19], [3, 6, 9, 16, 22], [10, 13, 14, 17, 24], [18, 21, 23, 26, 30]];
            int target = 20;

            var actualOutput = SearchMatrix(nums, target);

            Console.WriteLine("Actual Output  = " + actualOutput);
            Console.Read();
        }

        // https://leetcode.com/problems/search-a-2d-matrix-ii/solutions/2327770/3-different-solutions-c-o-m-n-complexity/
        private static bool SearchMatrix(int[][] matrix, int target)
        {
            //int row = matrix.Length - 1;
            //int column = 0;
            //while (row >= 0 && column < matrix.Length)
            //{
            //    if (matrix[row][column] == target)
            //        return true;
            //    else if (matrix[row][column] < target)
            //        column++;
            //    else if (matrix[row][column] > target)
            //        row--;
            //}
            //if (matrix[row][column] == target)
            //    return true;
            //return false;

            //ALTERNATE WAY - CHECK WHY ABOVE WAY NOT WORKING

            int column = matrix[0].Length - 1;
            int row = 0;
            while (column >= 0 && row < matrix.Length)
            {
                if (matrix[row][column] == target)
                    return true;
                else if (matrix[row][column] > target)
                    column--;
                else if (matrix[row][column] < target)
                    row++;
            }
            return false;
        }

        //NOT WORKING 
        private static bool SearchMatrix_1(int[][] matrix, int target)
        {
            int rowLen = matrix.Length-1;
            int colLen = matrix[0].Length-1;

            int rowStart = matrix[0][0];
            int colStart = matrix[0][0];

            int si = 0, ei = rowLen;
            int index = BinarySearchInRow(si, ei, target, matrix);

            if (index == -1)
            {
                si = 0; ei = colLen;
                index = BinarySearchInColn(si, ei, target, matrix);
            }
            return index != -1;
        }
        private static int BinarySearchInRow(int si, int ei, int target, int[][] nums)
        {
            int mi = (si + ei) / 2;
            if (target == nums[mi][0])
                return mi;

            if (target >= nums[si][0] && target <= nums[mi][0])
            {
                ei = mi;
            }
            else if (target >= nums[mi + 1][0] && target <= nums[ei][0])
            {
                si = mi + 1;
            }
            else
                return -1;

            return BinarySearchInRow(si, ei, target, nums);
        }

        private static int BinarySearchInColn(int si, int ei, int target, int[][] nums)
        {
            int mi = (si + ei) / 2;
            if (target == nums[0][mi])
                return mi;

            if (target >= nums[0][si] && target <= nums[0][mi])
            {
                ei = mi;
            }
            else if (target >= nums[0][mi + 1] && target <= nums[0][ei])
            {
                si = mi + 1;
            }
            else
                return -1;

            return BinarySearchInColn(si, ei, target, nums);
        }
    }
}
