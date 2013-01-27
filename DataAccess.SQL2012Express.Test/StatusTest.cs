using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataAccess.SQL2012Express.Test
{
    [TestClass]
    public class StatusTest
    {
        [TestMethod]
        public void TestGetAll()
        {
            var dal = new StatusDAL();
            List<StatusDTO> data = new List<StatusDTO>();
            
            data = dal.GetAllStatus();
            Assert.IsTrue(data.Count > 0, "Roles GetAll failed");

        }
    }
}
