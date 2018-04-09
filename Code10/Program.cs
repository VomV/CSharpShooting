//find the longest word in a string

using System;

namespace Code10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string: ");
            string str = Console.ReadLine();

            char[] carray = str.ToCharArray();

            int i = 1, j = 0, Len = 1;
            int StartIndex = 0;
            int[] Index = new int[] { 0, 0 };
            foreach (char c in carray)
            {
                if (char.IsWhiteSpace(c))
                {
                    if (Len < (i - j - 1))
                    {
                        Len = i - j - 1;
                        StartIndex = j;

                    }
                    j = i;
                }
                i++;
            }

            string Longest = new string(carray, StartIndex, Len);
            Console.WriteLine("Longest word: {0}", Longest);
        }
    }
}
