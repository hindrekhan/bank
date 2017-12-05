using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string userInput;

                Console.WriteLine("1. Logi sisse");
                Console.WriteLine("2. Loo konto");

                userInput = Console.ReadLine();

                if (userInput == "1")
                {
                    Accounts.Login();
                    break;
                }

                else if (userInput == "2")
                {
                    Accounts.Register();
                    break;
                }

                else
                {
                    Console.WriteLine("Teadmata käsk sisestatud");
                }

            }
        }

    }
}
