//Multiplication table of a number

using System;

namespace Code6
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            bool B;
            do
            {
                Console.WriteLine("Please enter the number: ");
                B = int.TryParse(Console.ReadLine(), out N);
                if (B)
                {

                }
                else
                    Console.WriteLine("Please enter a valid number");

            } while (B == false);

            for (int count = 1; count<=10; count++ )
            {
                int product = N * count;
                Console.WriteLine("{0}*{1} = {2}",N,count,product);
            }


        }
    }
}
