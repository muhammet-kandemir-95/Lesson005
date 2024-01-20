using System;
using System.Reflection.Metadata;

namespace Lesson005
{
    class Program_TurkishNumberTextToNumber
    {
        public static int ConvertNumberStringToNumber(string inputNumberString)
        {
            inputNumberString = inputNumberString.Trim();

            int hundred = 0;
            if (inputNumberString.Contains("yüz"))
            {
                string[] hundreds = inputNumberString.Split(new string[] { "yüz" }, StringSplitOptions.None);
                string hundredPart = hundreds[0];
                hundred = ConvertNumberStringToNumber(hundredPart) * 100;
                if (hundredPart == "")
                {
                    hundred = 100;
                }

                inputNumberString = hundreds[1];
            }
            string[] numberParts = inputNumberString.Trim().Split(' ');

            string numberString = numberParts[numberParts.Length - 1];

            int resultNumber = 0;
            if (numberString == "sıfır" || numberString == "sifir")
            {
                resultNumber = 0;
            }
            else if (numberString == "bir")
            {
                resultNumber = 1;
            }
            else if (numberString == "iki")
            {
                resultNumber = 2;
            }
            else if (numberString == "üç")
            {
                resultNumber = 3;
            }
            else if (numberString == "dört")
            {
                resultNumber = 4;
            }
            else if (numberString == "beş")
            {
                resultNumber = 5;
            }
            else if (numberString == "alti" || numberString == "altı")
            {
                resultNumber = 6;
            }
            else if (numberString == "yedi")
            {
                resultNumber = 7;
            }
            else if (numberString == "sekiz")
            {
                resultNumber = 8;
            }
            else if (numberString == "dokuz")
            {
                resultNumber = 9;
            }

            string hundredString = numberParts[0];

            int resultHundred = 0;
            if (hundredString == "on")
            {
                resultHundred = 10;
            }
            else if (hundredString == "yirmi")
            {
                resultHundred = 20;
            }
            else if (hundredString == "otuz")
            {
                resultHundred = 30;
            }
            else if (hundredString == "kırk" || hundredString == "kirk")
            {
                resultHundred = 40;
            }
            else if (hundredString == "elli")
            {
                resultHundred = 50;
            }
            else if (hundredString == "altmış" || hundredString == "altmiş")
            {
                resultHundred = 60;
            }
            else if (hundredString == "yetmiş")
            {
                resultHundred = 70;
            }
            else if (hundredString == "seksen")
            {
                resultHundred = 80;
            }
            else if (hundredString == "doksan")
            {
                resultHundred = 90;
            }

            int result = (resultHundred + resultNumber) + hundred;

            return result;
        }

        public static void Main_TurkishNumberTextToNumber(string[] args)
        {
            Console.Write("Please enter a number in character: ");
            string inputNumberString = Console.ReadLine();
            string lowerInputNumberString = inputNumberString.ToLower().Trim();
            while (lowerInputNumberString.Contains("  "))
            {
                lowerInputNumberString = lowerInputNumberString.Replace("  ", " ");
            }

            string[] millions = lowerInputNumberString.Split(new string[] { "milyon" }, StringSplitOptions.None);
            int millionResult = 0;
            string thousandPart = "";
            if (millions.Length == 2)
            {
                millionResult = ConvertNumberStringToNumber(millions[0]) * 1000000;
                if (millions[0] == "")
                {
                    millionResult = 1000000;
                }
                thousandPart = millions[1];
            }
            else
            {
                thousandPart = millions[0];
            }

            string[] thousands = thousandPart.Split(new string[] { "bin" }, StringSplitOptions.None);
            int thousandResult = 0;
            string hundredPart = "";
            if (thousands.Length == 2)
            {
                thousandResult = ConvertNumberStringToNumber(thousands[0]) * 1000;
                if (thousands[0] == "")
                {
                    thousandResult = 1000;
                }
                hundredPart = thousands[1];
            }
            else
            {
                hundredPart = thousands[0];
            }

            int hundredResult = ConvertNumberStringToNumber(hundredPart);

            Console.WriteLine("ResultNumber in number: " + (millionResult + thousandResult + hundredResult));
        }
    }
}