using System;
using System.Collections.Generic;
using System.Text;

namespace Payroll
{
    static class GetInupts
    {
        public static decimal parseDec()
        {
            decimal number;
            while (true)
            {
                bool success = decimal.TryParse(Console.ReadLine(), out number);
                if (success)
                {
                    return number;
                }
                else
                {
                    Console.WriteLine("error not a valid value try again");
                }
            }
        }

        public static string parseString()
        {

            return "a";
        }
    }
}
