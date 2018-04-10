//Fibonacci - bottom up

using System;


namespace Code14
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            bool B;
            do
            {
                Console.WriteLine("Please enter the number of fibonacci terms: ");
                B = int.TryParse(Console.ReadLine(), out N);
                if (B)
                {

                }
                else
                    Console.WriteLine("Please enter a valid number");

            } while (B == false);

            int[] fibarray = new int[N];
            fibarray[0] = 1;
            fibarray[1] = 1;

            for(int i=2; i<N; i++)
            {
                fibarray[i] = fibarray[i - 1] + fibarray[i - 2];
            }
            foreach(int fib in fibarray)
                Console.WriteLine(fib);
        }
                      
}
}
