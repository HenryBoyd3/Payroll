using System;
using System.Collections.Generic;
using System.Text;

namespace Payroll
{
    class HourlyEmployee :Employee
    {

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




	}
}
