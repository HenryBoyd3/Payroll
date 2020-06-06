using System;
using System.Collections.Generic;
using System.Text;

namespace Payroll
{
    abstract class Employee
    {
		protected int age;
		protected int employeeId;
		protected string name;
		protected decimal weeklyPay;
		protected decimal takeHomePay;
		protected decimal FICA;
		protected decimal federalIncomeTax;

		public int EmployeeId
		{
			get { return employeeId; }
		}
		public int Age
		{
			get { return age; }
		}
		public string Name
		{
			get { return name; }
		}
		protected Employee()
		{ }
		protected Employee(string firstN, string lastN, int _age, int _employeeId)
		{
			name = lastN + ", " + firstN;
			age = _age;
			employeeId = _employeeId;
		}

		public virtual string CalculatePay() 
		{

			FICA = Math.Round(weeklyPay * 0.0765m,2);
			federalIncomeTax = Math.Round(weeklyPay * 0.265m,2);
			takeHomePay = weeklyPay - (FICA + federalIncomeTax);
			return takeHomePay.ToString("C");
		}

		
	}
}
