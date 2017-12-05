using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank
{
    static class Accounts
    {
        public static bool Register()
        {
            int accountName;
            int password;
            Random rnd = new Random();

            accountName = rnd.Next(0, 99999);
            Console.WriteLine("Kasutajanimi: " + accountName);

            password = rnd.Next(0, 9999);
            Console.WriteLine("Parool: " + password);

            System.IO.File.AppendAllText("../../accounts.txt", accountName + " " + password + Environment.NewLine);

            return true;
        }

        public static bool Login()
        {
            string accountName;
            string password;

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
                        if (line.Substring(0, 5) == accountName)
                        {
                            string a = line.Substring(6, 3);
                            if (line.Substring(6, 10) == password)
                            {
                                Console.WriteLine("Sisse logitud");
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
