using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class InterestCalc
    {
        static void Main(string[] args)
        {
            decimal balance, interestRate, years;
            Console.Write("Please enter a starting balance for interest calculation: ");
            balance = decimal.Parse(Console.ReadLine());
            Console.Write("Please enter the interest rate: ");
            interestRate = decimal.Parse(Console.ReadLine());
            interestRate /= 100.0m;
            Console.Write("Please enter the amount of years that the interest will accumulate: ");
            years = decimal.Parse(Console.ReadLine());
            balance += balance * interestRate * years;
            Console.WriteLine("The amount you will have in {0} year{1} is {2:c}",years,years == 1 ? "" : "s",balance);
        }
    }
}
