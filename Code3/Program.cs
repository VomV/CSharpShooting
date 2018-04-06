//Divide two numbers

using System;


namespace Code3
{
    class Program
    {
        public static float division(float a, float b)
        {
            return a / b;
        }

        static void Main()
        {

            float FN, SN;
            bool B;
            Console.WriteLine("Division of two numbers");

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
            
            float Div = division(FN, SN);
            Console.WriteLine("FN/SN is: {0}", Div);
        }
    }
}
