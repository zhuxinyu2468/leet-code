using System.Text;

namespace _67_AddBinary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = "11";
            string b = "1";
            string result = AddBinary(a, b);
            Console.WriteLine(result);
        }
        public static string AddBinary(string a, string b)
        {
            string ans = string.Empty;
            int carry = 0;
            int i = a.Length - 1;
            int j = b.Length - 1;
            while (i >= 0 || j >= 0||carry==1) {
                if (i >= 0)
                {
                    carry += a[i--] - '0';
                }
                if (j >= 0)
                {
                    carry += b[j--] - '0';
                }

                ans += carry % 2;
                carry /= 2;
            }
            
            return new string(ans.Reverse().ToArray()); 
        }
    }
}
