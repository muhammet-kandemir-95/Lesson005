using System;
using System.Reflection.Metadata;

namespace Lesson005
{
    class Program_StringOperations
    {
        public static void Main_StringOperations(string[] args)
        {
            Console.Write("Please enter your fullname: ");
            string fullname = Console.ReadLine();

            while (fullname.Contains("  "))
            {
                fullname = fullname.Replace("  ", " ");
            }
            string[] names = fullname.Trim().Split(' ');

            string firstName = "";
            string lastName = "";
            string middleName = "";
            for (int i = 0; i < names.Length; i++)
            {
                string name = names[i].Substring(0, 1).ToUpper() + names[i].Substring(1).ToLower();
                if (i == 0) // First Name
                {
                    firstName = name;
                }
                else if (i == names.Length - 1) // Last Name
                {
                    lastName = name;
                }
                else // Middle Name
                {
                    if (middleName != "")
                    {
                        middleName = middleName + " ";
                    }

                    middleName = middleName + name;
                }
            }

            Console.WriteLine("First Name: " + firstName);
            if (middleName != "")
            {
                Console.WriteLine("Middle Name: " + middleName);
            }
            if (lastName != "")
            {
                Console.WriteLine("Last Name: " + lastName);
            }
        }
    }
}