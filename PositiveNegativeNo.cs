using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_Programs
{
    public class PositiveNegativeNo
    {

        int num;
        public void PositiveNegative()
        {
         
            Console.WriteLine("Enter any number: ");
            num = Convert.ToInt32(Console.ReadLine());

            if (num > 0)
            {
                Console.WriteLine("Entered number is positive ");
            }
            else if (num < 0)
            {
                Console.WriteLine("Entered number is nagative ");
            }
            else
            {
                Console.WriteLine("Entered number is zero ");
            }

            Console.ReadLine();
        }
    }
}
