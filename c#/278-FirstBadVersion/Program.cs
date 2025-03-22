using System.Security.Cryptography;

namespace FirstBadVersion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 2126753390;
            Console.WriteLine(FirstBadVersion(n));
        }
        public static int FirstBadVersion(int n)
        {
            int first = 1;
            int last = n;
            int bad = 0;

            while (last >= first)
            {
                int mid = first + (last - first) / 2;
                //int mid = (first + last) / 2;
                if (IsBadVersion(mid))
                {
                    bad = mid;
                    last = mid - 1;
                }
                else
                {
                    first = mid + 1;
                }
            }
            return bad;
        }

        public static bool IsBadVersion(int n)
        {
            int badVersion = 1702766719;
            return n>=badVersion;
        }
    }
}
