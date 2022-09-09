using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_Programs
{
    public class SpecialChar
    {
        char ch;
        
        public void Char()
        {
            Console.WriteLine("Enter any character: ");
            ch = Convert.ToChar(Console.ReadLine());

            // Alphabet checking condition
            if ((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z'))
            {
                Console.WriteLine(ch + " is an Alphabet ");
            }
            // Digit checking condition
            else if (ch >= '0' && ch <= '9')
            {
                Console.WriteLine(ch + " is a Digit ");
            }
            else
            {
                Console.WriteLine(ch + "is a Special character ");
            }

            Console.ReadKey();
        }

        
    }
}
