//Print a message

using System;


namespace Code1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter your name: ");
            String Name = Console.ReadLine();
            Console.WriteLine("Hello: \n{0}", Name);
        }
    }
}
