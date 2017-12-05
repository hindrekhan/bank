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
            int a = lineNumber;

            modifiedLine = arrLine[lineNumber];
            decimal b = decimal.Parse(modifiedLine.Substring(11));

            arrLine[lineNumber] += " " + amount;

            return true;
        }

        public static bool RetrieveMoney(float amount, int lineNumber)
        {
            string[] arrLine;

            arrLine = System.IO.File.ReadAllLines("../../accounts.txt");

           // arrLine[lineNumber] += " " + amount;

            return true;
        }
    }
}
