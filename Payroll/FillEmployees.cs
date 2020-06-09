using System;
using System.Collections.Generic;
using System.Text;

namespace Payroll
{
    public static class FillEmployees
    {
        public static void UserOptions(int number, List<Employee> staff)
        {
            string firstN, lastN;
            int age, employeeId;
            decimal hourwork, hourpay, monthlypay;
            switch (number)
            {
                case 1://add hourly employee
                    firstN = GetInupts.parseString("enter first name");
                    lastN = GetInupts.parseString("enter Last name");
                    age = decimal.ToInt32(GetInupts.parseDec("enter age"));
                    employeeId = decimal.ToInt32(GetInupts.parseDec("enter Employee ID"));
                    hourwork = GetInupts.parseDec("enter hourly rate");
                    hourpay = GetInupts.parseDec("enter hours worked");
                    Employee hp = new HourlyEmployee(firstN, lastN, age, employeeId, hourpay, hourwork);
                    staff.Add(hp);
                    break;
                case 2://add hourly employee
                    firstN = GetInupts.parseString("enter first name");
                    lastN = GetInupts.parseString("enter Last name");
                    age = decimal.ToInt32(GetInupts.parseDec("enter age"));
                    employeeId = decimal.ToInt32(GetInupts.parseDec("enter Employee ID"));
                    monthlypay = GetInupts.parseDec("enter monthly Pay");
                    Employee mp = new SalariedEmployee(firstN, lastN, age, employeeId, monthlypay);
                    staff.Add(mp);
                    break;
                case 3: //manage funds
                    Program.totalPay();
                    Program.quits = true;
                    break;
                case 4:
                    Program.quits = true;
                    break;

            }
        }
    }
}
