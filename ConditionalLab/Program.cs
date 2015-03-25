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
            Console.WriteLine("Please enter your salary so we know how to tax yas!");
            var input = Console.ReadLine();
            double incomeAmount = int.Parse(input);
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

            Console.WriteLine("income: ${0}", incomeAmount);
            Console.WriteLine("tax: ${0}", taxRate);

            Console.ReadLine();
        }
    }
}