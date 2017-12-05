using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank
{
    static class Bank
    {
        static float GetMoney(int lineNumber)
        {
            string[] arrLine;
            float value;

            arrLine = System.IO.File.ReadAllLines("../../accounts.txt");

            value = float.Parse(arrLine[lineNumber].Substring(9));

            return value;
        }

        public static bool AddMoney(decimal amount, int lineNumber)
        {
            string[] arrLine;
            string modifiedLine;
            decimal value;

            arrLine = System.IO.File.ReadAllLines("../../accounts.txt");
        
            modifiedLine = arrLine[lineNumber].Substring(0, 10);

            value = decimal.Parse(arrLine[lineNumber].Substring(10));
            value += amount;

            arrLine[lineNumber] = modifiedLine + " " + value.ToString();

            System.IO.File.WriteAllLines("../../accounts.txt", arrLine);

            return true;
        }

        public static bool RetrieveMoney(decimal amount, int lineNumber)
        {
            string[] arrLine;
            string modifiedLine;
            decimal value;

            arrLine = System.IO.File.ReadAllLines("../../accounts.txt");

            modifiedLine = arrLine[lineNumber].Substring(0, 10);

            value = decimal.Parse(arrLine[lineNumber].Substring(10));
            value -= amount;

            if (value < 0)
            {
                Console.WriteLine("Teil pole nii palju raha");
                return false;
            }

            arrLine[lineNumber] = modifiedLine + " " + value.ToString();

            System.IO.File.WriteAllLines("../../accounts.txt", arrLine);



            return true;
        }
    }
}
