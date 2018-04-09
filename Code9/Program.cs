//Return true if two integers are of opposite signs

using System;


namespace Code9
{
    class Program
    {
        static void Main(string[] args)
        {
            int N1, N2;
            bool B;
            do
            {
                Console.WriteLine("Please enter the first integer: ");
                B = int.TryParse(Console.ReadLine(), out N1);
                if (B)
                {

                }
                else
                    Console.WriteLine("Please enter a valid number");

            } while (B == false);

            do
            {
                Console.WriteLine("Please enter the second integer: ");
                B = int.TryParse(Console.ReadLine(), out N2);
                if (B)
                {

                }
                else
                    Console.WriteLine("Please enter a valid number");

            } while (B == false);

            int N3 = N1 * N2;
            if(N3<0)
            {
                bool result = true;
                Console.WriteLine(result);
            }

        }
    }
}
