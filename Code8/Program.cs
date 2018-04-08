//Remove a specified character from a string using its index

using System;

namespace Code8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the string: ");
            string str = Console.ReadLine();

            char[] carray = str.ToCharArray();
            Console.WriteLine(carray);

            int N;
            bool B;
            do
            {
                Console.WriteLine("Please enter the index of character to be removed(starting from zero): ");
                B = int.TryParse(Console.ReadLine(), out N);
                if (B)
                {

                }
                else
                    Console.WriteLine("Please enter a valid number");

            } while (B == false);

            char[] carray1 = new char[carray.Length - 1];


            for (int k = 0; k < carray.Length - 1; k++)
            {
                if (k >= N)
                {
                    carray[k] = carray[k + 1];
                }
                carray1[k] = carray[k];
            }
            str = new string(carray1);
            Console.WriteLine("Modified string: {0}",str);
        }
    }
}
