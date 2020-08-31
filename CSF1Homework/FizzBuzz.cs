using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class FizzBuzz
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number for a FizzBuzz game: ");
            int userNum = int.Parse(Console.ReadLine());
            for (int i = 1; i <= userNum; i++)
            {
                if (i % 5 ==0 && i % 3==0)
                {
                    Console.Write("FizzBuzz, ");
                }
                else if (i % 3 ==0)
                {
                    Console.Write("Fizz, ");
                }
                else if (i % 5 ==0)
                {
                    Console.Write("Buzz, ");
                }
                else
                {
                    Console.Write($"{i}, ");
                }
            }
            Console.WriteLine();
        }
    }
}
