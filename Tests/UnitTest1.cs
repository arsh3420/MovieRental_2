using System;
using System.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MovieRentalSystem;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ConnectionValidation()
        {
            Assert.AreEqual(true, new DBContextHelper().VerifyConnection());
        }

        [TestMethod]
        public void ValuesValidation()
        {
            DBContextHelper database = new DBContextHelper();
            DataTable table = database.GetAllCustomer();
            Assert.IsNotNull(table);
        }
    }
}
