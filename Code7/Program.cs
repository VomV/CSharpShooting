//Draw a rectangle

using System;

namespace Code7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the character for drawing the rectangle: ");
            char charac = Convert.ToChar(Console.ReadLine());

            int L, W;
            bool B;
            do
            {
                Console.WriteLine("Please enter the length: ");
                B = int.TryParse(Console.ReadLine(), out L);
                if (B)
                {

                }
                else
                    Console.WriteLine("Please enter a valid number");

            } while (B == false);

            do
            {
                Console.WriteLine("Please enter the width: ");
                B = int.TryParse(Console.ReadLine(), out W);
                if (B)
                {

                }
                else
                    Console.WriteLine("Please enter a valid number");

            } while (B == false);

            for (int i = 1; i <= L; i++)
            {
                if (i == 1 || i == L)
                {
                    for (int j = 1; j <= W; j++)
                    {
                        Console.Write(charac);
                    }
                }
                else
                {
                    Console.Write(charac);
                    for (int k = 2; k <= W - 1; k++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write(charac);
                }

                Console.WriteLine();

            }

        }
    }
}
