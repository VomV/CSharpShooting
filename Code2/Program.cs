//Add two numbers

using System;

namespace Code2
{
    class Program
    {
        public static float Sum(float a, float b)
        {
            return a + b;
        }

        static void Main()
        {
            float FN, SN;
            bool B;

            do
            {
                Console.WriteLine("Please enter the first number: ");
                B = float.TryParse(Console.ReadLine(), out FN);
                if (B)
                {

                }
                else
                    Console.WriteLine("Please enter a valid number");
              
            } while (B == false);

            do
            {
                Console.WriteLine("Please enter the second number: ");
                B = float.TryParse(Console.ReadLine(), out SN);
                if (B)
                {

                }
                else
                    Console.WriteLine("Please enter a valid number");

            } while (B == false);

            float Add = Sum(FN, SN);
            Console.WriteLine("Sum of the numbers: {0}", Add);

        }
    }

}
