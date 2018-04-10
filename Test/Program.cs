using System;


namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "aAsdfsdA";
            Console.WriteLine(str.ToLower());
            int a = Math.Abs(-8);
            Console.WriteLine(a);

            int[] arr = new int[10];
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }

        }
    }
}
