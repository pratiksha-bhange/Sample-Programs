using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_Programs
{
    public class ReverseNumber
    {
        int num, reverse = 0;
        public void Reverse()
        {
            
            Console.WriteLine("Enter a Number : ");
            num = Convert.ToInt32(Console.ReadLine());
            while (num != 0)
            {
                reverse = reverse * 10;
                reverse = reverse + num % 10;
                num = num / 10;
            }
            Console.WriteLine("Reverse of Entered Number is : " + reverse);
            Console.ReadLine();
        }
    }
}
        
        
    

