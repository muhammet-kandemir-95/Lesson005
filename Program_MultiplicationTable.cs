using System;

namespace Lesson005
{
    class Program_MultiplicationTable
    {
        public static void Main_MultiplicationTable(string[] args)
        {
            Console.WriteLine("".PadRight(80, '-'));
            for (int i = 0; i < 10; i++)
            {
                Console.Write("|");
                for (int j = 0; j < 4; j++)
                {
                    Console.Write((i + 1).ToString().PadRight(4, ' ') + " * " + (j + 1).ToString().PadRight(4, ' ') + " = " + ((i + 1) * (j + 1)).ToString().PadRight(4, ' '));

                    if (j != 3)
                    {
                        Console.Write("| ");
                    }
                }

                Console.Write("|");

                Console.WriteLine();
                Console.WriteLine("".PadRight(80, '-'));
            }
        }
    }
}