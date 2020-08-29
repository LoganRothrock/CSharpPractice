using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class ATMApp
    {
        static void Main(string[] args)
        {
            string userAccount , userPIN ,another;
            const string USER_ACCOUNT_NUMBER = "123456789" , USER_PIN = "1234";
            decimal userBalance = 0.0m;
            Console.Write("Hello thank you for using our ATM");
            do
            {
                Console.Write("\nPlease enter your account number : ");
                 userAccount = Console.ReadLine();      
                
            } while  (userAccount != USER_ACCOUNT_NUMBER);
            Console.Clear();
            Console.Write("Accounts matched");
            do
            {
                Console.Write("\nNow please enter the PIN associated with that account: ");
                userPIN = Console.ReadLine();

            } while (userPIN != USER_PIN);
            Console.Clear();
            Console.WriteLine("PINS matched!");
            bool repeat = true;
            while (repeat)
            {


                Console.WriteLine("\nWould you like to make a:\n1) Deposit\n2) Withdrawal\n3) View Balance\n4) Exit");
                string userInput = Console.ReadLine().ToUpper();
                switch (userInput)
                {
                    case "D":
                    case "DEPOSIT":
                    case "1":
                        Console.Clear();
                        Console.WriteLine("How much would you like to deposit?");
                        int depositAmount = int.Parse(Console.ReadLine());
                        Console.WriteLine("{0:c} has been deposited into account {1}", depositAmount, USER_ACCOUNT_NUMBER);
                        userBalance += depositAmount;
                        break;
                    case "W":
                    case "WITHDRAWAL":
                    case "2":
                        Console.Clear();
                        Console.WriteLine("How much would you like to withdrawal?");
                        int withdrawalAmount = int.Parse(Console.ReadLine());
                        if (withdrawalAmount > userBalance)
                        {
                            Console.WriteLine("You are unable to withdrawal {0:c} because you only have {1:c} in your account",withdrawalAmount,userBalance);
                        }
                        else if (withdrawalAmount < userBalance && withdrawalAmount > 0)
                        {
                            userBalance -= withdrawalAmount;
                            Console.WriteLine("{0:c} has been withdrawaled from account {1}.\nYou now have {2} remaining inside account {1}", withdrawalAmount, USER_ACCOUNT_NUMBER, userBalance);
                        }
                        break;
                    case "B":
                    case "BALANCE":
                    case "3":
                        Console.WriteLine($"{userBalance:c}");
                        break;
                    case "E":
                    case "EXIT":
                    case "4":

                        break;

                    default:
                        break;

                }
                Console.WriteLine("Would you like to do anything else? (Deposit/Withdrawal) Y/N");
                another = Console.ReadLine().ToUpper();
                if (another == "Y" || another == "YES")
                {
                    Console.Clear();
                }else 
                {
                    repeat = false;
                }
                
            }
            Console.WriteLine("Thank you for your buisness");
        }
    }
}
