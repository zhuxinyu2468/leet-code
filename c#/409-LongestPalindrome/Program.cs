namespace _409_LongestPalindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "abccccdd";

            Console.WriteLine(LongestPalindrome(s));
        }

        public static int LongestPalindrome(string s)
        {
            HashSet<char> hashSet = new HashSet<char>();
            int count = 0;
            foreach (char a in s)
            {
                if (hashSet.Contains(a))
                {
                    hashSet.Remove(a);
                    count += 2;
                }
                else
                {
                    hashSet.Add(a);
                }
            }

            return hashSet.Count > 0 ? count + 1 : count;
        }
    }
}
