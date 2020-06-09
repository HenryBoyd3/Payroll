using Microsoft.VisualStudio.TestTools.UnitTesting;
using Payroll;

namespace PayrollTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void EmployeeAgeTestEqual()
        {
            var test = new HourlyEmployee("a","a",1,2,10,40);
            var resealt = test.Age;
            Assert.AreEqual(1, resealt);
        }
        [TestMethod]
        public void EmployeeNameTestEqual()
        {
            var test = new HourlyEmployee("a", "a", 1, 2, 10, 40);
            var resealt = test.Name;
            Assert.AreEqual("a, a", resealt);
        }
        [TestMethod]
        public void EmployeeIDTestEqual()
        {
            var test = new HourlyEmployee("a", "a", 1, 2, 10, 40);
            var resealt = test.EmployeeId;
            Assert.AreEqual(2, resealt);
        }
        [TestMethod]
        public void EmployeeWeeklyPayTestEqual()
        {
            var test = new HourlyEmployee("a", "a", 1, 2, 10, 40);
            var resealt = test.WeeklyPay;
            Assert.AreEqual(400, resealt);
        }
        [TestMethod]
        public void EmployeeCalculatePayTestEqual()
        {
            var test = new HourlyEmployee("a", "a", 1, 2, 10, 40);
            var resealt = test.CalculatePay();
            Assert.AreEqual("$263.40", resealt);
        }
        [TestMethod]
        public void EmployeeCalculateFedTaxTestEqual()
        {
            var test = new HourlyEmployee("a", "a", 1, 2, 10, 40);
            test.CalculatePay();
            var resealt = test.FedTax;
            Assert.AreEqual(106.00m, resealt);
        }
        [TestMethod]
        public void EmployeeCalculateTakeHomePayTestEqual()
        {
            var test = new HourlyEmployee("a", "a", 1, 2, 10, 40);
            test.CalculatePay();
            var resealt = test.TakeHomePay;
            Assert.AreEqual(263.40m, resealt);
        }
        [TestMethod]
        public void EmployeeCalculateFICAPaidTestEqual()
        {
            var test = new HourlyEmployee("a", "a", 1, 2, 10, 40);
            test.CalculatePay();
            var resealt = test.fICA;
            Assert.AreEqual(30.60m, resealt);
        }


        [TestMethod]
        public void UserOptionHourlyOnlyTest()
        {
            FillEmployees.UserOptions(3, Program.staff);
            var employee = new HourlyEmployee("a", "a", 1, 2, 10, 40);
            Program.staff.Add(employee);
            var test = Program.staff[0];
            Assert.IsNotNull(test);
        }
        [TestMethod]
        public void UserOptionSalariedOnlyTest()
        {
            FillEmployees.UserOptions(3, Program.staff);
            var employee = new SalariedEmployee("a", "a", 1, 2, 1000);
            Program.staff.Add(employee);
            var test = Program.staff[0];
            Assert.IsNotNull(test);
        }
        [TestMethod]
        public void UserOptionSalariedAndHourlyTest()
        {
            FillEmployees.UserOptions(3, Program.staff);
            var employee = new HourlyEmployee("a", "a", 1, 2, 10, 40);
            Program.staff.Add(employee);
            var employee2 = new SalariedEmployee("a", "a", 1, 2, 1000);
            Program.staff.Add(employee2);
            var test = Program.staff[0];
            Assert.IsNotNull(test);
        }
        [TestMethod]
        public void UserOptionQuitTest()
        {
            FillEmployees.UserOptions(4, Program.staff);

            var test = Program.quits;
            Assert.IsTrue(test);
        }

    }
}
