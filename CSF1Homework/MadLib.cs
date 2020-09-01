using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class MadLib
    {
        static void Main(string[] args)
        {
            string[] madLibWords = new string[5];
            Console.WriteLine("Please enter a noun");
            madLibWords[0] = Console.ReadLine();
            Console.WriteLine("Please enter an adjective");
            madLibWords[1] = Console.ReadLine();
            Console.WriteLine("Please enter a verb");
            madLibWords[2] = Console.ReadLine();
            Console.WriteLine("Please enter a noun");
            madLibWords[3] = Console.ReadLine();
            Console.WriteLine("Please enter an adjective");
            madLibWords[4] = Console.ReadLine();
            Console.WriteLine("There once was a {0} {1}. Who was really good at {2}. He made a friend who was a {3} {4}", madLibWords[1], madLibWords[0], madLibWords[2], madLibWords[4], madLibWords[3]);
        }
    }
}
