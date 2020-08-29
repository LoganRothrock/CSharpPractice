using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class GradesLoop
    {
        static void Main(string[] args)
        {
            sbyte score = 0;
            do
            {
                Console.Write("Please enter a score: ");
                score = sbyte.Parse(Console.ReadLine());
                
                if(score >= 0)
                {
                    Console.WriteLine(score);
                }
                    
            } while (score >=0);
        }
    }
}
