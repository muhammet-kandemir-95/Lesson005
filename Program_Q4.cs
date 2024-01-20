using System;
using System.Reflection.Metadata;

namespace Lesson005
{
    class Program_Q4
    {
        public static void Main_Q4(string[] args)
        {
            Console.Write("Input the string : ");
            string input = Console.ReadLine();

            Console.WriteLine("The characters of the string are :");
            for (int i = input.Length; i > 0; i--)
            {
                Console.Write(input[i - 1] + " ");
            }
        }
    }
}