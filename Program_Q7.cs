using System;
using System.Reflection.Metadata;
using System.Text.RegularExpressions;

namespace Lesson005
{
    class Program_Q7
    {
        public static void Main_Q7(string[] args)
        {
            Console.Write("Input the string : ");
            string input = Console.ReadLine();

            int alphabeticCharacterCount = 0;
            int digitCharacterCount = 0;
            int specialCharacterCount = 0;
            for (int i = 0; i < input.Length; i++)
            {
                bool isAlphabetic = Regex.IsMatch(input[i].ToString(), "[a-z]", RegexOptions.IgnoreCase);
                bool isDigit = char.IsDigit(input[i]);

                if (isAlphabetic == true)
                {
                    alphabeticCharacterCount++;
                }
                else if (isDigit == true)
                {
                    digitCharacterCount++;
                }
                else
                {
                    specialCharacterCount++;
                }
            }

            Console.WriteLine("Number of Alphabets in the string is : " + alphabeticCharacterCount);
            Console.WriteLine("Number of Digits in the string is : " + digitCharacterCount);
            Console.WriteLine("Number of Special in the string is : " + specialCharacterCount);
        }
    }
}