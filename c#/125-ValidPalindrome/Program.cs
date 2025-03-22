namespace ValidPalindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "0P";
            
            Console.WriteLine(IsPalindrome(s));
        }

        public static bool IsPalindrome(string s)
        {
            string cleanS = String.Join("",s.ToLower().Where(c=>Char.IsLetterOrDigit(c)));
            int left = 0;
            int right = cleanS.Length - 1;
            while (left < right)
            {
                if (cleanS[left] != cleanS[right])
                {
                    return false;
                }
                left++;
                right--;
            }

            return true;
        }
    }
}
