using System;
using System.Reflection.Metadata;
using System.Text.RegularExpressions;

namespace Lesson005
{
    class Program_Q15
    {
        public static void Main_Q15(string[] args)
        {
            Console.Write("Input the string : ");
            string input = Console.ReadLine();

            Console.Write("After conversion, the string is : ");
            for (int i = 0; i < input.Length; i++)
            {
                bool isUpper = char.IsUpper(input[i]);

                if (isUpper == true)
                {
                    Console.Write(input[i].ToString().ToLower());
                }
                else
                {
                    Console.Write(input[i].ToString().ToUpper());
                }
            }
        }
    }
}