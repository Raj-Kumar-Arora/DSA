using System.Drawing;
using System.Text;

namespace LeetCodeProblems.LeetCode_150
{
    internal static class LeetCode_59_Medium
    {
        public static void SpiralOrder()
        {
            ////Case - 1
            //int[][] matrix = [[1, 2, 3], [4, 5, 6], [7, 8, 9]];
            //var expOut = ;

            ////Case - 2
            int[][] matrix = [[1, 2, 3, 4], [5, 6, 7, 8], [9, 10, 11, 12]];

            //CASE - 3


            //Case - 4


            //Case - 5


            //Case - 6


            //Case - 7


            //Case - 8


            var actualOutput = SpiralOrder(matrix);

            Console.WriteLine("Actual Output  = " + actualOutput);
            Console.Read();
        }


        private static IList<int> SpiralOrder(int[][] matrix)
        {
            int rowLen = matrix.Length;
            int colLen = matrix[0].Length;

            int totalElementsCnt = rowLen * colLen;
            List<int> result = new();

            int top = 0, bottom = rowLen-1, left = 0, right = colLen-1;

            while (result.Count < totalElementsCnt)
            {
                //go left to right
                for (int j = left; j <= right && result.Count < totalElementsCnt; j++)
                    result.Add(matrix[top][j]);
                top++;

                //go top to bottom
                for (int i = top; i <= bottom && result.Count < totalElementsCnt; i++)
                    result.Add(matrix[i][right]);
                right--;

                //go right to left
                for (int j = right; j >= left && result.Count < totalElementsCnt; j--)
                    result.Add(matrix[bottom][j]);
                bottom--;

                //go bottom to top  
                for (int i = bottom; i >= top && result.Count < totalElementsCnt; i--)
                    result.Add(matrix[i][left]);
                left++;
            }

            return result;
        }
    }
}
