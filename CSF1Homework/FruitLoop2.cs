using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class FruitLoop2
    {
        static void Main(string[] args)
        {
            string[] fruit = { "Cherry", "Apple", "Banana", "Mango", "Avacado", "Watermelon" };
            for (int i = 0; i < fruit.Length; i++)
            {
                byte period = 0;
                Console.Write($"{fruit[i]}\n");
                while (period <= i)
                {
                    Console.Write(".");
                    period++;
                }
                Console.WriteLine("");
            }
        }
    }
}
