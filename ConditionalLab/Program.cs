using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalLab
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Income Tax Calculator
            */

            /*
             
            //Ask for Input
            Console.WriteLine("Please enter your salary so we know how to tax yas!");
            //Init input variable
            var input = Console.ReadLine();
            //Parse input string to integer and set to var incomeAmount
            double incomeAmount = int.Parse(input);
            //init tax variable
            double taxRate = 0.0;

            if (incomeAmount > 20000.0)
            {
                taxRate = taxRate + 20000.0 * 0.05;
            }
            else if (incomeAmount > 0.0)
            {
                taxRate = taxRate + incomeAmount * 0.05;
            }

            if (incomeAmount > 50000.0)
            {
                taxRate = taxRate + (50000.0 - 20000.0) * 0.10;
            }
            else if (incomeAmount > 20000.0)
            {
                taxRate = taxRate + (incomeAmount - 30000.0) * 0.10;
            }

            if (incomeAmount > 75000.0)
            {
                taxRate = taxRate + (75000.0 - 50000.0) * 0.20;
            }
            else if (incomeAmount > 50000.0)
            {
                taxRate = taxRate + (incomeAmount - 50000.0) * 0.20;
            }

            if (incomeAmount > 75000.0)
            {
                taxRate = taxRate + (incomeAmount - 75000.0) * 0.35;
            }

            Console.WriteLine("Your income is: ${0}", incomeAmount);
            Console.WriteLine("Your tax-rate is: ${0}", taxRate);


            */

            /*
             TIME CLASSIFICATIONS
            */

            /*
            DateTime saveNow = DateTime.Now;
            int seconds = saveNow.Second;
            Console.WriteLine("This time is {0}", saveNow);
            if (seconds == 0) 
            {
                Console.WriteLine("The new minute is just begining");
            }
            else if (seconds == 15) 
            {
                Console.WriteLine("We're one quarter done");
            }
            else if (seconds == 30) 
            {
                Console.WriteLine("Half way there");
            }

            else if (seconds == 45)
            {
                Console.WriteLine("Getting close to done");
            }

            else 
            {
                Console.WriteLine("Working on it!");
            }
             
            */

            /*
             * Fizz Buzz
             */

           
            for (int i = 0; i < 100; i++) 
            {
                if ((i % 3 == 0) && (i % 15 == 0))
                {
                    Console.WriteLine("FizzBuzz");
                }
                
                else if (i % 3 == 0) 
                {
                    Console.WriteLine("Fizz");
                }

                else if (i % 5 == 0) 
                {
                    Console.WriteLine("Buzz");
                }
                else 
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadLine();
        }
    }
}