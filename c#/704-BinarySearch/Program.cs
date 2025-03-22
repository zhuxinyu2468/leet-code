namespace _704_BinarySearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = [-1, 0, 3, 5, 9, 12];
            int target = 5;
            Console.WriteLine(Search(nums, target));
        }

        public static int Search(int[] nums, int target)
        {
            int l = 0;
            int r = nums.Length - 1;
            while (l < r)
            {
                var m = (l + r) / 2;
                if (nums[m] >= target)
                {
                    r = m;
                }
                else
                {
                    l = m + 1;
                }
            }

            return nums[l] == target ? l : -1;
        }
    }
}
