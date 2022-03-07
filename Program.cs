using System;

namespace Reverse_string
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Here is a program to reverse your input, please enter a input:");
            string input = Console.ReadLine();

            string output = ReverseString(input);
            
            Console.WriteLine(output);
        }

        public static string ReverseString(string s)
        {
            char[] results = s.ToCharArray();

            Array.Reverse(results);

            return new string(results);
        }

        
    }
}
