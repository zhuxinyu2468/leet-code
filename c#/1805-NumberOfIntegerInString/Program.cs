using System.Text;
using System.Text.RegularExpressions;

public class Solution
{
    public static int NumDifferentIntegers(string word)
    {
        HashSet<string> resultWords = new HashSet<string>();
        for (int i = 0; i < word.Length; i++)
        {
            if (Char.IsDigit(word[i]))
            {
                StringBuilder sb = new StringBuilder();
                while (i<word.Length && Char.IsDigit(word[i]))
                {
                    sb.Append(word[i]);
                    i++;
                }
                resultWords.Add(sb.ToString().TrimStart('0'));
            }
        }
        
        return resultWords.Count;
    }

    public static void Main()
    {
        var word = "a123bc34d8ef34";

        int v = NumDifferentIntegers(word);
        Console.WriteLine(v);
    }
}