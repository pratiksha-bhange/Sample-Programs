using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_Programs
{
    public class Addition
    {
        int num1, num2;
        int sum;

        public void Add()
        {

           
            Console.Write("Input an first integer value: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input an Second integer value: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            sum = num1 + num2;


            Console.WriteLine("Addition of Two Number is = " + sum);
        }
       
    }
}
