using System;
using System.Collections.Generic;
using System.Text;

namespace Payroll
{
	class SalariedEmployee : Employee
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


		public SalariedEmployee(string firstN, string lastN, int _age, int _employeeId, decimal _monthlyPay)
			: base(firstN, lastN, _age, _employeeId)
		{
			weeklyPay = ((_monthlyPay * 12) / 52); //get acurate weekly pay
		}


	}
}
