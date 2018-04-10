//Fibonacci- Naive recurssion

using System;

namespace Code15
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
            
            for (int i = 0; i < N; i++)
                fibarray[i] = fib(i);

            foreach (int fibN in fibarray)
                Console.WriteLine(fibN);
        }

        public static int fib(int N)
        {
            if (N == 0 || N == 1)
                return 1;
            else
                return fib(N - 1) + fib(N - 2);
        }
    }
}
