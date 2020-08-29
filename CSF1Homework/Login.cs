using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class Login
    {
        static void Main(string[] args)
        {
            const string USER_LOGIN = "USERNAME", USER_PASSWORD = "1234";
            string userLogin = "", userPassword = "";
            for (int i = 5; i > 0; i--)
            {
               
                Console.Write("Please enter your username: ");
                userLogin = Console.ReadLine().ToUpper();
                if (userLogin == USER_LOGIN)
                {
                    Console.WriteLine("Hello {0}!", USER_LOGIN);
                    i = 0;
                }
                else if(i == 1)
                {
                    Console.WriteLine("You have used up all of your attempts the program will now shutdown have a good day.");
                }
                else
                {
                    Console.WriteLine("Wrong username you have {0} more attempt{1} left",i - 1 , i == 1 ? "" : "s" );
                }
            }
            if (userLogin == USER_LOGIN)
            {
                for (int i = 3; i > 0; i--)
                {
                    Console.WriteLine("Please enter the password for {0}",USER_LOGIN);
                    userPassword = Console.ReadLine();
                    if (userPassword == USER_PASSWORD)
                    {
                        Console.WriteLine("You have logged into your account successfully");
                        i = 0;
                    }
                    else if (i == 1)
                    {
                        Console.WriteLine("You have used up all of your attempts the program will now shutdown have a good day.");
                    }
                    else
                    {
                        Console.WriteLine("Wrong username you have {0} more attempt{1} left", i - 1, i == 1 ? "" : "s");
                    }
                }
            }

        }
    }
}
