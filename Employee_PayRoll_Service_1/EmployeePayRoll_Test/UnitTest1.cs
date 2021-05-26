using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Employee_PayRoll_Service_1;

namespace EmployeePayRoll_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            EmployeeRepo repo = new EmployeeRepo();

            bool exp = true;

            bool actual = repo.GetAllEmployee();

            Assert.AreEqual(actual, exp);
        }
    }
}
