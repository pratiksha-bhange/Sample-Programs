using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_Programs
{
   public class MaximumNo
    {

        int num1 = 0, num2 = 0;
        public void MaxNo()
        {
            //Reading first numbers from user
            Console.WriteLine("Enter First number: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            //Reading second numbers from user
            Console.WriteLine("Enter Second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            // Condition to check maximum number
            if (num1 > num2)
            {
                Console.WriteLine(  " Maximum number is : " +num1);
            }
            else
            {
                Console.WriteLine("Maximum number is : " +num2);
            }

            Console.ReadLine();
        }
           
    }
}
