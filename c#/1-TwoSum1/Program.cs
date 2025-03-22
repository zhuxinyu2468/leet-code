using System.Linq;

namespace _1_TwoSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = [1, 1, 1, 1, 1, 4, 1, 1, 1, 1, 1, 7, 1, 1, 1, 1, 1];
            int target = 11;
            int[] result = TwoSum(nums, target);
            Console.WriteLine(result);
        }

        public static int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int,int> map = new Dictionary<int,int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int remains = target - nums[i];
                if (map.ContainsKey(remains))
                {
                    return new int[] { map[remains], i };
                }
                map[nums[i]] = i;
            }

            return new int[] { };
        }
    }
}
