namespace _217_ContainsDuplicate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = [1, 2, 3, 4, 5, 1];
            Console.WriteLine(ContainsDuplicate(nums));
        }

        public static bool ContainsDuplicate(int[] nums)
        {
/*            HashSet<int> set = new HashSet<int>();
            foreach (int i in nums)
            {
                if (set.Contains(i))
                {
                    return true;
                }
                else
                {
                    set.Add(i);
                } 
            }
            return false;*/

            // or 
            HashSet<int> set = new HashSet<int>(nums);
            return set.Count < nums.Length;
        }
    }
}
