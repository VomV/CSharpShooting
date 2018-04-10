//Reverse the words of a sentence

using System;

namespace Code13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string: ");
            string str = Console.ReadLine();

            string[] words = str.Split(' ');
            Array.Reverse(words);
            string reversestr = string.Join(" ", words);
            Console.WriteLine(reversestr);
        }
    }
}
