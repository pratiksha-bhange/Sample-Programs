using System;

namespace Basic_Programs
{
    class Program
    {
        public static void Main(string[] args)
        {
            string a;
            Console.Write("Enter Program Name : ");
            a = Convert.ToString(Console.ReadLine());
            switch (a)
            {
                case "PositiveNegativeNo":
                    PositiveNegativeNo positiveNegativeNo = new PositiveNegativeNo();
                    positiveNegativeNo.PositiveNegative();
                    break;

                case "Addition":
                    Addition addition = new Addition();
                    addition.Add();
                    break;

                case "ReverseNumber":
                    ReverseNumber reverse = new ReverseNumber();
                    reverse.Reverse();
                    break;

                case "SpecialChar":
                    SpecialChar specialChar = new SpecialChar();
                    specialChar.Char();
                    break;

                case "MaximumNo":
                    MaximumNo maximumNo = new MaximumNo();
                    maximumNo.MaxNo();
                    break;

                case "Vowels":
                    vowels vowels = new vowels();
                    vowels.CheckVowels();
                    break;
            }

        
        }
    }
}
