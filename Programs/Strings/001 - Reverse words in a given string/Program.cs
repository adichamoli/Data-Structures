using System;

namespace ReverseWords
{
    class Program
    {
        public static String[] RevString(String[] s, int l)
        {
            int j = l / 2;
            
            while (j <= l - 1)
            {
                String temp;
                temp = s[l - j - 1];
                s[l - j - 1] = s[j];
                s[j] = temp;
                j += 1;
            }

            return s;
        }

        public static void Main()
        {
            string[] s = "i like this program very much".Split(' ');
            string ans = "";
            
            for (int i = s.Length - 1; i >= 0; i--)
            {
                ans += s[i] + " ";
            }
            
            Console.Write("Reversed String : ");
            Console.WriteLine(ans.Substring(0, ans.Length - 1));

            String s1 = "getting good at coding " +
            "needs a lot of practice";
            String[] words = s1.Split(' ');

            words = RevString(words, words.Length);

            s1 = String.Join(" ", words);

            Console.WriteLine("Reversed String Without Space: ");
            Console.WriteLine(s1);
        }
    }
}
