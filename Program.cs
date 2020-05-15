using System;
using System.Collections.Generic;

namespace Loops_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
          /*  Console.WriteLine("Enter a number ");

            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                if (i%3!=0 && i%7!=0)
                {
                    Console.WriteLine(i);
                }
            }*/

           // Console.WriteLine("Hello");
            string num = (Console.ReadLine());
            int length = num.Length;
            List<double> nums = new List<double>();

            //Console.WriteLine("This is " + num);
            foreach (var number in  num)
            {
                //Console.WriteLine(number);
                if (number !='1' && number !='0') //|| number == 1)
                {
                    Console.WriteLine("This number is not a binary");
                    break;
                }
                else
                {
                    Console.WriteLine("The number {0} is a binary number", number);

                    /*for (int j = 0; j < length; j++)
                    {
                        //double [] nums = new double[] {};
                        nums.Add(Math.Pow(j,2) * number);

                        Console.WriteLine(nums);
                    }*/

                    
                    
                }
            }
           
                     


        }
    }
}
