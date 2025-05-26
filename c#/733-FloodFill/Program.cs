namespace _733_FloodFill
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] testImage = [[1, 1, 1], [1, 1, 0], [1, 0, 1]];
            int sr = 1;
            int sc = 1;
            int color = 2;

            var result = FloodFill(testImage, sr, sc, color);
            foreach (var row in result)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }
        public static int[][] FloodFill(int[][] image, int sr, int sc, int color)
        {
            int old = image[sr][sc];
            if (old == color)
            {
                return image;
            }

            int m = image.Length;
            int n = image[0].Length;


            Queue<(int row, int col)> queue = new();
            queue.Enqueue((sr, sc));

            while (queue.Count > 0)
            {
                var (row, col) = queue.Dequeue();
                image[row][col] = color;

                if (row > 0 && image[row - 1][col] == old)
                {
                    queue.Enqueue((row - 1, col));
                }
                if (row < m - 1 && image[row + 1][col] == old)
                {
                    queue.Enqueue((row + 1, col));
                }
                if (col > 0 && image[row][col - 1] == old)
                {
                    queue.Enqueue((row, col - 1));
                }
                if (col < n - 1 && image[row][col + 1] == old)
                {
                    queue.Enqueue((row, col + 1));
                }
            }

            return image;
        }


    }
}
