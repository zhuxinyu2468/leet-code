namespace _383_RansomNote
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = "aa";
            string b = "aab";
            Console.WriteLine(CanConstruct(a,b));
        }

        public static bool CanConstruct(string ransomNote, string magazine)
        {
            Dictionary<char,int> map = new Dictionary<char,int>();
            foreach (var item in magazine)
            {
                if (map.ContainsKey(item))
                {
                    map[item] += 1;
                } else
                {
                    map[item] = 1;
                }
            }
            foreach (char c in ransomNote)
            {
                if (map.ContainsKey(c) && map[c] > 0)
                {
                    map[c] -= 1;
                }
                else
                {
                    return false;
                }
            }

            return true;
        }
    }
}
