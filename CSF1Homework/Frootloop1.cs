using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class FrootLoop1
    {
        static void Main(string[] args)
        {
            string[] fruit = { "Cherry","Apple","Banana","Mango","Avacado","Watermelon"};
            for (int i = 0; i < fruit.Length; i++)
            {
                Console.Write($"{fruit[i]}\n");
            }

        }
    }
}
