﻿using System;
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

            while (true)
            {
                string userInput;

                Console.WriteLine();
                Console.WriteLine("1. Võta raha välja");
                Console.WriteLine("2. Sisesta raha");
                Console.WriteLine("3. Logi välja");

                userInput = Console.ReadLine();

                if (userInput == "1")
                {
                    float amount;

                    Console.WriteLine("Sisestage summa");

                    amount = float.Parse(Console.ReadLine());

                    Bank.RetrieveMoney(amount, Accounts.accountName);
                }

                else if (userInput == "2")
                {
                    float amount;

                    Console.WriteLine("Sisestage summa");
                    amount = float.Parse(Console.ReadLine());

                    Bank.AddMoney(amount, Accounts.accountName);
                }

                else if (userInput == "3")
                {
                    Console.WriteLine("Välja logitud");
                    return;
                }

                else
                {
                    Console.WriteLine("Teadmata käsk sisestatud");
                }
            }
        }

    }
}
