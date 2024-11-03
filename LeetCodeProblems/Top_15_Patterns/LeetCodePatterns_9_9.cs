using DSA.Trees;
//SUBMITTED - SIMILARLY solve 9.8 ROTTON ORANGE PROBLEM very much similar
namespace LeetCodeProblems.Top_15_Patterns
{
    public class LeetCodePatterns_9_9
    {
        public static void FloodFill()
        {
            //            ////Case - 1
            //            int[][] image =
            //{
            //                new[] {1, 1, 1 },
            //                new[] {1, 1, 0 },
            //                new[] {1, 0, 1 }
            //            };
            //            int sr = 1, sc = 1, color = 2;

            //Case - 2
            int[][] image =
            {
                new[] {0, 0, 0 },
                new[] {0, 0, 0 }
            };
            int sr = 1, sc = 0, color = 2;

            var actualOutput = FloodFill(image, sr, sc, color);

            Console.WriteLine("Actual Output  = " + actualOutput);
            Console.Read();

        }

        private static int[][] FloodFill(int[][] image, int sr, int sc, int color)
        {
            int[][] result = image;
            int m = image.Length;       // no of rows
            int n = image[0].Length;    // no of colns

            Queue<(int,int)> q = new();
            q.Enqueue((sr, sc));
            int orgColor = result[sr][sc];

            while (q.Count > 0)
            {
                var (r,c) = q.Dequeue();
                //set the new color to image's pixel
                result[r][c] = color;

                //add the neighbours of this pixel to queue 
                int nr = r + 1, nc = c;
                if (nr<m && nc<n && nr >= 0 && nc >= 0 &&
                    result[nr][nc] == orgColor && result[nr][nc] != color)
                    q.Enqueue((nr, nc));

                nr = r - 1; nc = c;
                if (nr < m && nc < n && nr >= 0 && nc >= 0 &&
                    result[nr][nc] == orgColor && result[nr][nc] != color)
                    q.Enqueue((nr, nc));

                nr = r; nc = c + 1;
                if (nr < m && nc < n && nr >= 0 && nc >= 0 &&
                    result[nr][nc] == orgColor && result[nr][nc] != color)
                    q.Enqueue((nr, nc));

                nr = r; nc = c - 1;
                if (nr < m && nc < n && nr >= 0 && nc >= 0 &&
                    result[nr][nc] == orgColor && result[nr][nc] != color)
                    q.Enqueue((nr, nc));
            }
            return result;
        }
    }
}
