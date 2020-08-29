using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class Powers
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <=50; i++)
            {
                long sum = 0;
                sum = Convert.ToInt64(Math.Pow(2,i));
                Console.WriteLine(sum);
            }
        }
    }
}
