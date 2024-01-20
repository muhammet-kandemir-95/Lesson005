using System;
using System.Reflection.Metadata;

namespace Lesson005
{
    class Program_Q3
    {
        public static void Main_Q3(string[] args)
        {
            Console.Write("Input the string : ");
            string input = Console.ReadLine();

            Console.WriteLine("The characters of the string are :");
            for (int i = 0; i < input.Length; i++)
            {
                Console.Write(input[i] + " ");
            }
        }
    }
}