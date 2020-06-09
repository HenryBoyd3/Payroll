using System;
using System.Collections.Generic;
using System.Text;

namespace Payroll
{
	public class HourlyEmployee :Employee
    {
		protected static decimal hourWeeklyPay;
		protected static decimal hourTakeHomePay;
		protected static decimal hourFICA;
		protected static decimal hourFederalIncomeTax;
		//this block is to save the total of all hourly users
		public decimal HourWeeklyPay
		{
			get { return hourWeeklyPay; }
			set { hourWeeklyPay = value; }
		}
		public decimal HourTakeHomePay
		{
			get { return hourTakeHomePay; }
			set { hourTakeHomePay = value; }
		}
		public decimal HourFICA
		{
			get { return hourFICA; }
			set { hourFICA = value; }
		}
		public decimal HourFedTax
		{
			get { return hourFederalIncomeTax; }
			set { hourFederalIncomeTax = value; }
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

		public HourlyEmployee(string firstN, string lastN, int _age, int _employeeId, decimal _hourlyPay, decimal _hoursWorked)
			: base(firstN, lastN, _age, _employeeId)
		{

			weeklyPay = _hourlyPay * _hoursWorked;
		}
		public HourlyEmployee() { }
		public  string hourlyInfo(Employee employee)
		{

			employee.CalculatePay();
			HourlyEmployee hr = employee as HourlyEmployee;
			hr.HourWeeklyPay += hr.WeeklyPay;
			hr.HourTakeHomePay += hr.TakeHomePay;
			hr.HourFICA += hr.fICA;
			hr.HourFedTax += hr.FedTax;

			return string.Format("{4}. Employee ID: {5}\n" +
				" Gross Pay this week {0}\n" +
				" Net Pay this week {1}\n" +
				" FICA Paid this week {2} \n" +
				" Total federal tax withheld this week {3}\n"
				, hr.WeeklyPay.ToString("C"), hr.TakeHomePay.ToString("C"),
				hr.fICA.ToString("C"), hr.FedTax.ToString("C"), hr.Name, hr.EmployeeId.ToString());

		}



	}
}
