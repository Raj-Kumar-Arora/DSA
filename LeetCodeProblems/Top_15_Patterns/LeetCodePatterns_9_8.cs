using DSA.Trees;
namespace LeetCodeProblems.Top_15_Patterns
{
    //SIMILAR to 9.9 FloodFill PROBLEM very much similar  -LeetCodePatterns_9_9 WHICH IS SOLVED using BFS
    public class LeetCodePatterns_9_8
    {
        public static void OrangesRotting()
        {
            ////Case - 1
            //int[][] grid =
            //{
            //   new[] {2, 1, 1, 2 },
            //   new[] {1, 1, 0, 2 },
            //   new[] {1, 0, 1, 2 }
            //};
            int[][] grid =
            {
                new[] {2, 1, 1 },
                new[] {1, 1, 0 },
                new[] {0, 1, 1 }
            };
            var actualOutput = OrangesRotting(grid);

            Console.WriteLine("Actual Output  = " + actualOutput);
            Console.Read();

        }

        private static int OrangesRotting(int[][] grid)
        {
            int result = 0;
            int m = grid.Length;  // no of rows   // equivalent => grid.GetLength(0);
            int n = grid[0].Length; // no of colmns
            int noOfRottenOrngs = 0;
            int noOfEmptyCells = 0;

            do
            {
                noOfRottenOrngs = 0;
                noOfEmptyCells = 0;

                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (grid[i][j] == 0)
                            noOfEmptyCells++;

                        //orage is rotten, set adjacent oranges rotton and update mins timer (rslt)
                        if (grid[i][j] == 2)
                        {
                            noOfRottenOrngs++;

                            if ((j + 1) < n && grid[i][j + 1] != 0)
                            {
                                grid[i][j + 1] = 2;
                                //noOfRottenOrngs++;
                            }

                            if ((i + 1) < m && grid[i + 1][j] != 0)
                            {
                                grid[i + 1][j] = 2;
                                //noOfRottenOrngs++;
                            }
                        }
                    }
                    result++;
                }
            } while ((noOfEmptyCells + noOfRottenOrngs) == m * n);

            return result;
        }
    }
}
