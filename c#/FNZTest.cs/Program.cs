namespace FNZTest.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = FindMaxSum("999");
            Console.WriteLine(s);
            
        }

        public static string FindMaxSum(string S)
        {
            char[] digits = S.ToCharArray();
            for (int i = 0; i <= S.Length; i++)
            {
                if (digits[i] != '0')
                {
                    digits[i]--;
                }
                for (int j = i+1; j < S.Length; j++)
                {
                    digits[j] = '9';
                }
                string result = new string(digits).TrimStart('0');
                return result.Length == 0 ? "0" : result;
            }
            return "0";
        }
    }
}
