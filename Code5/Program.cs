//Swap two numbers

using System;

namespace Code5
{
    class Program
    {
        static void Main(string[] args)
        {
            float FN, SN;
            bool B;

            do
            {
                Console.WriteLine("Please enter the first number, FN = ");
                B = float.TryParse(Console.ReadLine(), out FN);
                if (B)
                {

                }
                else
                    Console.WriteLine("Please enter a valid number");

            } while (B == false);

            do
            {
                Console.WriteLine("Please enter the second number, SN = ");
                B = float.TryParse(Console.ReadLine(), out SN);
                if (B)
                {

                }
                else
                    Console.WriteLine("Please enter a valid number");

            } while (B == false);

            FN = FN + SN;
            SN = FN - SN;
            FN = FN - SN;

            Console.WriteLine("Swapped Numbers: FN = {0}, SN = {1}", FN, SN);
        }
    }
}
