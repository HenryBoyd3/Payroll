using System;
using System.Collections.Generic;

namespace Payroll
{
    class Program
    {
       static List<Employee> staff = new List<Employee>();
        static void Main(string[] args)
        {
            while (true)
            {
                
                Console.WriteLine("1 to add an hourly employee\n 2 montly employee \n 3 to get total payment\n 4 to quit");
                int userInput = decimal.ToInt32(GetInupts.parseDec());
                UserOptions(userInput);
                Console.ReadKey();
                Console.Clear();
                if (userInput == 4)
                    break;
            }
        }

        static void UserOptions(int number)
        {
            string firstN, lastN;
            int age, employeeId;
            decimal hourwork, hourpay, monthlypay;
            switch (number)
            {
                case 1://add hourly employee
                    Console.WriteLine("enter first name");
                    firstN = GetInupts.parseString();
                    Console.WriteLine("enter Last name");
                    lastN = GetInupts.parseString();
                    Console.WriteLine("enter age");
                    age = decimal.ToInt32(GetInupts.parseDec());
                    Console.WriteLine("enter Employee ID");
                    employeeId = decimal.ToInt32(GetInupts.parseDec());
                    Console.WriteLine("enter hourly rate");
                    hourwork = GetInupts.parseDec();
                    Console.WriteLine("enter hours worked");
                    hourpay = GetInupts.parseDec();
                    Employee hp = new HourlyEmployee(firstN, lastN, age, employeeId, hourpay, hourwork);
                    staff.Add(hp);
                    break;
                case 2://add hourly employee
                    Console.WriteLine("enter first name");
                    firstN = GetInupts.parseString();
                    Console.WriteLine("enter Last name");
                    lastN = GetInupts.parseString();
                    Console.WriteLine("enter age");
                    age = decimal.ToInt32(GetInupts.parseDec());
                    Console.WriteLine("enter Employee ID");
                    employeeId = decimal.ToInt32(GetInupts.parseDec());
                    Console.WriteLine("enter monthly Pay");
                    monthlypay = GetInupts.parseDec();
                    Employee mp = new SalariedEmployee(firstN, lastN, age, employeeId, monthlypay);
                    staff.Add(mp);
                    break;
                case 3: //manage funds
                    decimal hourGrossPay =0, hourNetPay = 0, hourFICAPaid = 0, hourFedTax = 0;
                    decimal salariedGrossPay = 0, salariedNetPay = 0, salariedFICAPaid = 0, salariedFedTax = 0;
                    foreach (Employee employee in staff)
                    {
                        if (employee is HourlyEmployee)
                        {
                            employee.CalculatePay();
                            HourlyEmployee hr = employee as HourlyEmployee;
                            hourGrossPay += hr.WeeklyPay;
                            hourNetPay += hr.TakeHomePay;
                            hourFICAPaid += hr.fICA;
                            hourFedTax += hr.FedTax;
                            
                        }
                        if (employee is SalariedEmployee)
                        {
                            employee.CalculatePay();
                            SalariedEmployee se = employee as SalariedEmployee;
                            salariedGrossPay += se.WeeklyPay;
                            salariedNetPay += se.TakeHomePay;
                            salariedFICAPaid += se.fICA;
                            salariedFedTax += se.FedTax;                 
                        }
                    }
                    Console.WriteLine(string.Format(" Gross Pay for Hourly employee's this week {0}\n Net Pay for Hourly employee's this week {1}\n" +
                        " FICA Paid for Hourly Employee's this week {2} \n Total federal tax withheld for Hourly Employee's this week {3}\n"
                        , hourGrossPay.ToString("C"), hourNetPay.ToString("C"), hourFICAPaid.ToString("C"), hourFedTax.ToString("C")));
                    Console.WriteLine(string.Format(" Gross Pay for Salaried employee's this week {0}\n Net Pay for Salaried employee's this week {1}\n" +
                        " FICA Paid for Salaried Employee's this week {2} \n Total federal tax withheld for Salaried Employee's this week {3}\n"
                        , salariedGrossPay.ToString("C"), salariedNetPay.ToString("C"), salariedFICAPaid.ToString("C"), salariedFedTax.ToString("C")));
                    Console.WriteLine(string.Format(" Total Gross Pay this week: {0}\n Total Net Pay this week: {1}\n" +
                        " Total FICA Paid this week: {2} \n Total federal tax withheld this week: {3}"
                        , (hourGrossPay+ salariedGrossPay).ToString("C"), (hourNetPay + salariedNetPay).ToString("C"),
                        (hourFICAPaid + salariedFICAPaid).ToString("C"), (hourFedTax + salariedFedTax).ToString("C")));
                    break;

            }
        }



    }

}
