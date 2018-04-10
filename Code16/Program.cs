//Fibonacci- Recurssion with memoization

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

            fibarray[0] = 1;
            fibarray[1] = 1;

            for (int i = 2; i < N; i++)
                fibarray[i] = fib(i, fibarray);

            foreach (int fibN in fibarray)
                Console.WriteLine(fibN);
        }

        public static int fib(int N, int[] memo)
        {
            if (memo[N] != 0)
                return memo[N];
            else
                return fib(N - 1, memo) + fib(N - 2, memo);
        }
    }
}
