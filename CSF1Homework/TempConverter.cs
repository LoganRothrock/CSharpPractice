using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class TempConverter
    {
        static void Main(string[] args)
        {
            decimal cel, fah;
            string leave = "TRUE";
            bool repeat = true;
            do
            {
                Console.Clear();
                Console.WriteLine("Would you like to make a Fahrenheit conversion or Celsius conversion? (F/C)");
                string userAnswer = Console.ReadLine().ToUpper();

                switch (userAnswer)
                {
                    case "F":
                    case "FAHRENHEIT":
                        Console.Clear();
                        Console.Write("Please enter the tempurature in Celsius: ");
                        cel = decimal.Parse(Console.ReadLine());
                        Console.WriteLine("\nThat would be {0} degrees in Fahrenheit.", (cel * (9.0m/5.0m) + 32));
                        Console.WriteLine("Would you like to make another conversion? (Y/N) ");
                        leave = Console.ReadLine().ToUpper();

                        break;
                    case "C":
                    case "CELSIUS":
                        Console.Clear();
                        Console.Write("Please enter the tempurature in Fahrenheit: ");
                        fah = decimal.Parse(Console.ReadLine());
                        Console.WriteLine("\nThat would be {0} degrees in Celsius.", ((fah - 32) / (9.0m/5.0m)));
                        Console.WriteLine("Would you like to make another conversion? (Y/N) ");
                        leave = Console.ReadLine().ToUpper();
                        break;

                    default:
                        Console.WriteLine("Please enter a valid option");
                        break;
                }
                if (leave == "NO" || leave == "N")
                {
                    repeat = false;
                }
                

            } while (repeat);
        }
    }
}
