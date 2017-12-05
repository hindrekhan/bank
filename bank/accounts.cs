using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank
{
    static class Accounts
    {
        public static string accountName { get; set; }
        public static string password { get; set; }
        public static int lineNumber { get; set; }


        public static bool Register()
        {
            int accountName;
            int password;
            Random rnd = new Random();

            Console.WriteLine("Uus konto loodud.");

            accountName = rnd.Next(10000, 99999);
            Console.WriteLine("Kasutajanimi: " + accountName);

            password = rnd.Next(1000, 9999);
            Console.WriteLine("Parool: " + password);

            System.IO.File.AppendAllText("../../accounts.txt", accountName + " " + password + " 0,0" + Environment.NewLine);



            return true;
        }

        public static bool Login()
        {
            string accountName;
            string password;
            int lineNumber;

            lineNumber = 0;

            Console.WriteLine("Sisestage kasutajanimi");
            accountName = Console.ReadLine();

            Console.WriteLine("Sisestage parool");
            password = Console.ReadLine();

            

            try
            {
                using (System.IO.StreamReader sr = new System.IO.StreamReader("../../accounts.txt"))
                {
                    string line;
                    
                    while ((line = sr.ReadLine()) != null)
                    {
                        lineNumber++;

                        if (line.Substring(0, 5) == accountName)
                        {
                            if (line.Substring(6, 4) == password)
                            {
                                Console.WriteLine("Sisse logitud");

                                Accounts.accountName = accountName;
                                Accounts.password = password;
                                Accounts.lineNumber = lineNumber - 1;

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
        }
    }
}
