using System;

namespace Lesson005
{
    class Program_StringExample001
    {
        public static void Main_StringExample001(string[] args)
        {
            Console.Write("Please enter your first name: ");
            string name = Console.ReadLine();
            
            Console.WriteLine("Upper: " + name.ToUpper());
            Console.WriteLine("Lower: " + name.ToLower());
            Console.WriteLine("First upper then lower: " + name.Substring(0, 1).ToUpper() + name.Substring(1).ToLower());
            Console.WriteLine("First lower then upper: " + name.Substring(0, 1).ToLower() + name.Substring(1).ToUpper());

            string nameUpperLowerMixed = "";
            for (int i = 0; i < name.Length; i++)
            {
                if (i % 2 == 0)
                {
                    nameUpperLowerMixed = nameUpperLowerMixed + name.Substring(i, 1).ToUpper();
                }
                else
                {
                    nameUpperLowerMixed = nameUpperLowerMixed + name.Substring(i, 1).ToLower();
                }
            }
            
            Console.WriteLine("Upper and Lower Mixed: " + nameUpperLowerMixed);
        }
    }
}