namespace _57_InsertInterval
{
    internal class Program
    {
        static void Main(string[] args)
        {
/*            int[][] intervals = [[1, 3], [6, 9]];
            int[] newIntervals = [2, 5];*/
            int[][] intervals = [[1, 2], [3, 5], [6, 7], [8, 10], [12, 16]];
            int[] newIntervals = [4, 8];


            Console.WriteLine(Insert(intervals,newIntervals));
        }

        public static int[][] Insert(int[][] intervals, int[] newInterval)
        {
            List<int[]> result = new List<int[]>();
            int i = 0;
            int n = intervals.Length;

            while (i < n && intervals[i][1] < newInterval[0])
            {
                result.Add(intervals[i]);
                i++;
            }
            while (i<n && intervals[i][0] <= newInterval[1])
            {
                newInterval[0] = Math.Min(intervals[i][0], newInterval[0]);
                newInterval[1] = Math.Max(intervals[i][1], newInterval[1]);
                i++;
            }
            result.Add(newInterval);

            while (i < n)
            {
                result.Add(intervals[i]);
                i++;
            }

            return result.ToArray();
        }
    }
}
