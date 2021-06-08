using System;

namespace Input
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter a number from 1-4");
            num = Convert.ToInt32(Console.ReadLine());
            if(num == 1)
            {
                Console.WriteLine(num.ToString() + "your chosen number ");
            }
            else if(num==2)
            {
                Console.WriteLine(num.ToString() + " your chosen number ");
            }
            else if (num ==3)
            {
                Console.WriteLine(num.ToString() + " your chosen number ");
            }
            
             else if (num == 4)
                {
                    Console.WriteLine(num.ToString() + " is your chosen number ");
                }
            else
            {
                Console.WriteLine("Invalid");
            }
            
        }
    }
}
