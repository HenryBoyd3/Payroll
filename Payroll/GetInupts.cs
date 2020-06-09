using System;
using System.Collections.Generic;
using System.Text;

namespace Payroll
{
    public static class GetInupts
    {
        public static decimal parseDec(string Message)
        {
            Console.WriteLine(Message);
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

        public static string parseString(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }
    }
}
