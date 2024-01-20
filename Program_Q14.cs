using System;
using System.Reflection.Metadata;
using System.Text.RegularExpressions;

namespace Lesson005
{
    class Program_Q14
    {
        public static void Main_Q14(string[] args)
        {
            Console.Write("Input the string : ");
            string input = Console.ReadLine();
            
            Console.Write("Input the substring to search : ");
            string inputToBeSearched = Console.ReadLine();

            #region Way 1
            if (input.Contains(inputToBeSearched))
            {
                Console.WriteLine("The substring exists in the string");
            }
            else 
            {
                Console.WriteLine("The substring does not exist in the string");
            }
            #endregion
         
            #region Way 2
            bool found = false;
            for (int i = 0; i < input.Length - inputToBeSearched.Length + 1; i++)
            {
                bool matched = true;
                for (int j = 0; j < inputToBeSearched.Length; j++)
                {
                    if (input[i + j] != inputToBeSearched[j])
                    {
                        matched = false;
                        break;
                    }
                }

                if (matched)
                {
                    found = true;
                    break;
                }
            }
            
            if (found)
            {
                Console.WriteLine("The substring exists in the string");
            }
            else 
            {
                Console.WriteLine("The substring does not exist in the string");
            }
            #endregion
        }
    }
}