using System;
using System.Collections.Generic;

namespace Payroll
{
   public class Program
    {
     public static List<Employee> staff = new List<Employee>();
     public static bool quits = false;
       public static void Main(string[] args)
        {

            while (!quits == true)
            {
                int userInput = decimal.ToInt32(GetInupts.parseDec("1 to add an hourly employee\n 2 montly employee \n 3 to get total payment\n 4 to quit"));
                FillEmployees.UserOptions(userInput,staff);
                Console.ReadKey();
                Console.Clear();
            }
        }


        public static void totalPay()
        {
            HourlyEmployee h = new HourlyEmployee();
            SalariedEmployee s = new SalariedEmployee();
            foreach (Employee employee in staff)
            { 
                if (employee is HourlyEmployee)
                {
                    HourlyEmployee current = (HourlyEmployee)employee;
                    Console.WriteLine(current.hourlyInfo(employee));
                    
                }
                if (employee is SalariedEmployee)
                {
                    SalariedEmployee current = (SalariedEmployee)employee;   
                    Console.WriteLine(current.salariedInfo(employee));
                }
            }
            
            Console.WriteLine(string.Format(" Gross Pay for Hourly employee's this week {0}\n Net Pay for Hourly employee's this week {1}\n" +
                " FICA Paid for Hourly Employee's this week {2} \n Total federal tax withheld for Hourly Employee's this week {3}\n"
                , h.HourWeeklyPay.ToString("C"), h.HourTakeHomePay.ToString("C"), h.HourFICA.ToString("C"), h.HourFedTax.ToString("C")));

            Console.WriteLine(string.Format(" Gross Pay for Salaried employee's this week {0}\n Net Pay for Salaried employee's this week {1}\n" +
                " FICA Paid for Salaried Employee's this week {2} \n Total federal tax withheld for Salaried Employee's this week {3}\n"
                , s.SalariedWeeklyPay.ToString("C"), s.SalariedTakeHomePay.ToString("C"), s.SalariedFICA.ToString("C"), s.SalariedFedTax.ToString("C")));
            
            Console.WriteLine(string.Format(" Total Gross Pay this week: {0}\n Total Net Pay this week: {1}\n" +
                " Total FICA Paid this week: {2} \n Total federal tax withheld this week: {3}"
                , (h.HourWeeklyPay + s.SalariedWeeklyPay).ToString("C"), (h.TakeHomePay + s.SalariedTakeHomePay).ToString("C"),
                (h.HourFICA + s.SalariedFICA).ToString("C"), (h.HourFedTax + s.SalariedFedTax).ToString("C")));
        }

    }

}
