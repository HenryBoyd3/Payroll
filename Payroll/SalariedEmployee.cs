using System;
using System.Collections.Generic;
using System.Text;

namespace Payroll
{
	public class SalariedEmployee : Employee
	{
		protected static decimal salariedWeeklyPay;
		protected static decimal salariedTakeHomePay;
		protected static decimal salariedFICA;
		protected static decimal salariedFederalIncomeTax;
		//making sure Salaried employees total cost is implemnted
		public decimal SalariedFICA
		{
			get { return salariedFICA; }
			set { salariedFICA = value; }
		}
		public decimal SalariedWeeklyPay
		{
			get { return salariedWeeklyPay; }
			set { salariedWeeklyPay = value; }
		}
		public decimal SalariedFedTax
		{
			get { return salariedFederalIncomeTax; }
			set { salariedFederalIncomeTax = value; }
		}
		public decimal SalariedTakeHomePay
		{
			get { return salariedTakeHomePay; }
			set { salariedTakeHomePay = value; }
		}


		public decimal fICA
		{
			get { return this.FICA; }
		}
		public decimal WeeklyPay
		{
			get { return this.weeklyPay; }
		}
		public decimal FedTax
		{
			get { return this.federalIncomeTax; }
		}
		public decimal TakeHomePay
		{
			get { return this.takeHomePay; }
		}

		public SalariedEmployee() { }
		public SalariedEmployee(string firstN, string lastN, int _age, int _employeeId, decimal _monthlyPay)
			: base(firstN, lastN, _age, _employeeId)
		{
			weeklyPay = ((_monthlyPay * 12) / 52); //get acurate weekly pay
		}

		public string salariedInfo(Employee employee)
		{
			employee.CalculatePay();
			SalariedEmployee se = employee as SalariedEmployee;
			se.SalariedWeeklyPay += se.WeeklyPay;
			se.SalariedTakeHomePay += se.TakeHomePay;
			se.SalariedFICA += se.fICA;
			se.SalariedFedTax += se.FedTax;

			return string.Format("{4}. Employee ID: {5} \n Gross" +
				" Pay this week {0}\n" +
				" Net Pay this week {1}\n" +
				" FICA Paid this week {2} \n" +
				" Total federal tax withheld this week {3}\n"
				, se.WeeklyPay.ToString("C"), se.TakeHomePay.ToString("C"),
				se.fICA.ToString("C"), se.FedTax.ToString("C"), se.Name, se.EmployeeId.ToString());
		}
	}
}
