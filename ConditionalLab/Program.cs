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
            //Console.WriteLine("Please enter your yearly salary: ");
            //var input = Console.ReadLine();
            //double incomeTier = int.Parse(input);

            //if (incomeTier <= 20000)
            //{
            //    incomeTier = incomeTier * 1.05;
            //}
            //else if (incomeTier >= 20000 && incomeTier <= 50000) 
            //{
            //    incomeTier = incomeTier * 1.10;
            //}

            //else if (incomeTier >= 50000 && incomeTier <= 75000) 
            //{
            //    incomeTier = incomeTier * 1.20;
            //}
            //else if (incomeTier >= 75000) 
            //{
            //    incomeTier = incomeTier * 1.35;
            //}

            //Console.Write(incomeTier);

            //Console.ReadLine();


            var taxPercentage = new [] 
            { 
                new Bracket(0, 20000),
                new Bracket(20000,50000),
                new Bracket(50000,75000),
                new Bracket(75000,int.MaxValue)
            };

            var taxSystem = incomeTaxCalculator(taxPercentage);


        }
    }
}
