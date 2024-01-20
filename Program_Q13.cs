using System;
using System.Reflection.Metadata;
using System.Text.RegularExpressions;

namespace Lesson005
{
    class Program_Q13
    {
        public static void Main_Q13(string[] args)
        {
            Console.Write("Input the string : ");
            string input = Console.ReadLine();

            Console.Write("Input the position to start extraction : ");
            int startPosition = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Input the length of substring : ");
            int length = Convert.ToInt32(Console.ReadLine());

            string output = input.Substring(startPosition - 1, length);

            Console.WriteLine("The substring retrieve from the string is : " + output);           
        }
    }
}