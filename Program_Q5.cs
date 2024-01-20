using System;
using System.Reflection.Metadata;

namespace Lesson005
{
    class Program_Q5
    {
        public static void Main_Q5(string[] args)
        {
            Console.Write("Input the string : ");
            string input = Console.ReadLine();

            #region Way 1
            string[] splittedItems = input.Trim().Split(' ');
            Console.WriteLine("Total number of words in the string is : " + splittedItems.Length);
            #endregion

            #region Way 2
            int wordCount = 1;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == ' ')
                {
                    wordCount = wordCount + 1;
                }
            }
            Console.WriteLine("Total number of words in the string is : " + wordCount);
            #endregion
        }
    }
}