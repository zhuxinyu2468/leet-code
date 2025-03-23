namespace _53_MaxSubArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = [-2, 1, -3, 4, -1, 2, 1, -5, 4];
            Console.WriteLine(MaxSubArray(nums));
        }

        public static int MaxSubArray(int[] nums)
        {
            int max = 0;
            int res = nums[0];
            foreach (int i in nums)
            {
                if (max < 0)
                {
                    max = 0;
                }
                max += i;
                res = Math.Max(res, max);
            }

            
            return res;
        }
    }
}
