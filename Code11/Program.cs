//Sum of first 500 prime numbers

using System;

namespace Code11
{
    class Program
    {
        static void Main(string[] args)
        {

            int k = 1;
            int i = 2, Sum = 0;
            while(k <= 500)
            {
                if(IsPrime(i))
                {
                    Sum += i;
                    k++;
                    Console.WriteLine(i);
                }
                
                i++;
            }
            Console.WriteLine(k);
            Console.WriteLine(i);
            Console.WriteLine("Sum of first 500 prime Nos: {0}", Sum);
        }

        public static bool IsPrime(int N)
        {
            for(int i=2; i<=Math.Sqrt(N); i++)
            {

                if (N % i == 0)
                    return false;

            }
            return true;
        }
    }
}
