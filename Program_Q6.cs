using System;
using System.Reflection.Metadata;

namespace Lesson005
{
    class Program_Q6
    {
        public static void Main_Q6(string[] args)
        {
            Console.Write("Input the 1st string : ");
            string input1 = Console.ReadLine();
            Console.Write("Input the 2nd string : ");
            string input2 = Console.ReadLine();

            if (input1.Length == input2.Length)
            {
                Console.WriteLine("The length of both strings are equal and");

                if (input1 == input2)
                {
                    Console.WriteLine("also, both strings are equal.");
                }
                else
                {
                    Console.WriteLine("also, both strings are different.");
                }
            }
            else
            {
                Console.WriteLine("The length of both strings are different.");
            }
            
            /*
            S1 -> same length same strings
            S2 -> same length different strings
            S3 -> different length different strings
            */
        }
    }
}