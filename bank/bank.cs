using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank
{
    static class Bank
    {
        public static bool GetAccountLine

        public static bool AddMoney(float amount, string accountName)
        {
            try
            {
                using (System.IO.StreamReader sr = new System.IO.StreamReader("../../accounts.txt"))
                {
                    string line;

                    while ((line = sr.ReadLine()) != null)
                    {
                        if (line.Substring(0, 5) == accountName)
                        {
                            if (line.Substring(6, 4) == password)
                            {
                                Console.WriteLine("Sisse logitud");

                                Accounts.accountName = accountName;
                                Accounts.password = password;

                                return true;
                            }

                            Console.WriteLine("Vale parool");
                            return false;
                        }
                    }

                    Console.WriteLine("Konto ei eksisteeri");
                    return false;
                }
            }

            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
                return false;
            }

            return true;
        }

        public static bool RetrieveMoney(float amount, string password)
        {


            return true;
        }
    }
}
