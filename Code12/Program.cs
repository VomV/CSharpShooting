//Compute the sum of the digits of an integer

using System;

namespace Code12
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            bool B;
            do
            {
                Console.WriteLine("Please enter the integer: ");
                B = int.TryParse(Console.ReadLine(), out N);
                if (B)
                {

                }
                else
                    Console.WriteLine("Please enter a valid number");

            } while (B == false);

            int D = N % 10;
            int Sum = D;
            
            while (N>10)
            {                                
                N = (N / 10);
                D = N % 10;
                Sum += D;
            }

            Console.WriteLine(Sum);
            
        }
    }
}
