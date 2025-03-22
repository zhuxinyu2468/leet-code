namespace _242_ValidAnagram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "anagram";
            string t = "nagaram";
            Console.WriteLine(IsAnagram(s,t));
        }

        public static bool IsAnagram(string s, string t)
        {
            Dictionary<char, int> d = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (d.ContainsKey(s[i]))
                {
                    d[s[i]] += 1;
                }
                else
                {
                    d[s[i]] = 1;
                }
            }
            int lettersToSatisfy = d.Count;

            foreach (char a in t)
            {
                if (!d.ContainsKey(a))
                {
                    return false;
                }
                d[a]--;
                if (d[a] < 0)
                {
                    return false;
                }
                if (d[a] == 0)
                {
                    lettersToSatisfy--;
                }
            }
            return lettersToSatisfy == 0;
        }
    }
}
