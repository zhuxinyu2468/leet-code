namespace _169_MajorityElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = [2, 2, 1, 1, 1, 2, 2];
            Console.WriteLine(MajorityElement(nums));
        }

        public static int MajorityElement(int[] nums)
        {
            Dictionary<int,int> map = new Dictionary<int,int>();
            foreach (int i in nums)
            {
                if (map.ContainsKey(i))
                {
                    map[i] += 1;
                    if (map[i] > nums.Length / 2)
                    {
                        break;
                    }
                }
                else
                {
                    map[i] = 1;
                }
            }
            foreach (var m in map)
            {
                if (m.Value > nums.Length / 2)
                {
                    return m.Key;
                }
            }
            return 0;
        }
    }
}
