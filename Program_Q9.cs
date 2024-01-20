using System;
using System.Reflection.Metadata;
using System.Text.RegularExpressions;

namespace Lesson005
{
    class Program_Q9
    {
        public static void Main_Q9(string[] args)
        {
            Console.Write("Input the string : ");
            string input = Console.ReadLine();
            input = input.ToLower();

            int vowelCharacterCount = 0;
            int consonantCharacterCount = 0;
            for (int i = 0; i < input.Length; i++)
            {
                bool isAlphabetic = Regex.IsMatch(input[i].ToString(), "[a-z]", RegexOptions.IgnoreCase);

                if (isAlphabetic == true)
                {
                    if (
                        input[i] == 'a' ||
                        input[i] == 'e' ||
                        input[i] == 'ı' ||
                        input[i] == 'i' ||
                        input[i] == 'o' ||
                        input[i] == 'ö' ||
                        input[i] == 'u' ||
                        input[i] == 'ü'
                    )
                    {
                        vowelCharacterCount++;
                    }
                    else
                    {
                        consonantCharacterCount++;
                    }
                }
            }

            Console.WriteLine("The total number of vowel in the string is : " + vowelCharacterCount);
            Console.WriteLine("The total number of consonant in the string is : " + consonantCharacterCount);
        }
    }
}