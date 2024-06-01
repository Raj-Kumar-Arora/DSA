using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Misc
{
    internal static class SpiralOrderMatrix
    {
        public static void Test()
        {
            List<List<int>> A = new List<List<int>>();
            A.Add(new List<int>());
            //A.Add(new List<int>());
            // A[0].Add(1);

            A[0] = new List<int>() { 11, 217, 223, 213, 178, 226, 166, 212, 121, 277, 188, 5, 56, 354, 6 };
            A.Add(new List<int>() { 69, 384, 201, 369, 72, 174, 320, 265, 61, 397, 152, 10, 385, 288, 23 });

            List<int> ret = spiralOrder(A);

            for (int i = 0; i < ret.Count; i++)
                Console.WriteLine(ret[i]);
        }

        public static List<int> spiralOrder(List<List<int>> A)
        {
            int m = A.Count;      // no of Rows 
            int n = A[0].Count;   // no of columns
            List<int> ret = new List<int>(m * n);
            int l = 0;           //for return list count

            Console.Write("no of rows : ", m);
            Console.Write("no of columns : ", n);
            if (m == 1 || n == 1)
            {
                ret.Add(A[0][0]);
            }
            else
            {
                //Console.Write("INPUT DATA :");
                //for (int i = 0; i < A.Count; i++)
                //{
                //    for (int j = 0; j < A[i].Count; j++)
                //    {
                //        Console.Write(A[i][j] + " ");
                //    }
                //}
                //Console.Write("-----------");

                //for (int j = 0; j < n - 1; j++)
                //    ret.Add(A[0][j]);

                //for (int i = 1; i < m; i++)
                //    ret.Add(A[i][n - 1]);

                //for (int j = n - 2; j >= 0; j--)
                //    ret.Add(A[m - 1][j]);

                //ret[l++] = A[m - 2][0];

                //for (int j = 0; j < n - 3; j++)
                //    ret.Add(A[m - 3][j]);

                //for (int j = n - 2; j > 0; j--)
                //    ret.Add(A[m - 2][j]);

                int rs = 0, cs = 0;
                int re = m - 1, ce = n - 1;

                while (rs <= re && cs <= ce)
                {
                    //traverse right
                    for (int j = cs; j <= ce; j++)
                        ret.Add(A[rs][j]);
                    rs++;

                    //traverse down
                    for (int i = rs; i <= re; i++)
                        ret.Add(A[i][ce]);
                    ce--;

                    if (rs <= re)
                    {
                        //traverse left
                        for (int j = ce; j >= cs; j--)
                            ret.Add(A[re][j]);
                        re--;
                    }
                    if (cs <= ce)
                    {
                        //traverse up
                        for (int i = re; i >= rs; i--)
                            ret.Add(A[i][cs]);

                        cs++;

                    }
                }
            }
            return ret;
        }
    }
}
