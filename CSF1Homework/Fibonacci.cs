using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class Fibonacci
    {
        static void Main(string[] args)
        {
            int firstNum = 0, secondNum = 1, mathNum = 0;
            bool repeat = true;
            Console.Write("Please enter an end number for a Fibonacci sequence: ");
            int userNum = int.Parse(Console.ReadLine());
            while (repeat)
            {
                if (firstNum > userNum)
                {
                    repeat = false;
                }
                Console.Write($"{firstNum}, ");
                mathNum = firstNum;
                firstNum = secondNum;
                secondNum = secondNum + mathNum;
                
            }
            Console.WriteLine();
        }
    }
}
