using System.Drawing;
using System.Text;

namespace LeetCodeProblems.LeetCode_150
{
    internal static class LeetCode_58_Medium
    {
        public static void IsValidSudoku()
        {
            ////Case - 1
            //char[][] board = [
            //    ['5', '3', '.', '.', '7', '.', '.', '.', '.'], 
            //    ['6', '.', '.', '1', '9', '5', '.', '.', '.'], 
            //    ['.', '9', '8', '.', '.', '.', '.', '6', '.'],
            //    ['8', '.', '.', '.', '6', '.', '.', '.', '3'], 
            //    ['4', '.', '.', '8', '.', '3', '.', '.', '1'], 
            //    ['7', '.', '.', '.', '2', '.', '.', '.', '6'], 
            //    ['.', '6', '.', '.', '.', '.', '2', '8', '.'], 
            //    ['.', '.', '.', '4', '1', '9', '.', '.', '5'], 
            //    ['.', '.', '.', '.', '8', '.', '.', '7', '9']
            //   ];
            //var expOut = "PAHNAPLSIIGYIR";

            ////Case - 2
            char[][] board = [
                ['7', '.', '.', '.', '4', '.', '.', '.', '.'],
                ['.', '.', '.', '8', '6', '5', '.', '.', '.'],
                ['.', '1', '.', '2', '.', '.', '.', '.', '.'],
                ['.', '.', '.', '.', '.', '9', '.', '.', '.'],
                ['.', '.', '.', '.', '5', '.', '5', '.', '.'],
                ['.', '.', '.', '.', '.', '.', '.', '.', '.'],
                ['.', '.', '.', '.', '.', '.', '2', '.', '.'],
                ['.', '.', '.', '.', '.', '.', '.', '.', '.'],
                ['.', '.', '.', '.', '.', '.', '.', '.', '.']
                ];

            //CASE - 3


            //Case - 4


            //Case - 5


            //Case - 6


            //Case - 7


            //Case - 8


            var actualOutput = IsValidSudoku(board);

            Console.WriteLine("Actual Output  = " + actualOutput);
            Console.Read();
        }


        private static bool IsValidSudoku(char[][] board)
        {
            if (board.Length != 9) return false;
            int l = board.Length;

            HashSet<int>[] rows = new HashSet<int>[l];
            HashSet<int>[] columns = new HashSet<int>[l];
            HashSet<int>[] sq = new HashSet<int>[l];


            for (int k = 0; k < l; k++)
            {
                rows[k] = new();
                columns[k] = new();
                sq[k] = new ();
            }

            for (int i = 0; i < l; i++)
            {             
                int iV = 0;
                for (int j = 0; j < l; j++)
                {
                    char chV = board[i][j];
                    if (chV <= '0' && chV >= '9') return false;
                    if (chV == '.') continue;
                    iV = chV - '0';

                    if (rows[i].Add(iV) == false) return false;

                    if (columns[j].Add(iV) == false) return false;

                    int sqRowIndex = (i / 3) * 3;
                    int sqColIndex = (j / 3);
                    int sqIndex = sqRowIndex + sqColIndex;
                    if (sq[sqIndex].Add(iV) == false) 
                        return false;
                }
            }

            return true;
        }
    }
}
