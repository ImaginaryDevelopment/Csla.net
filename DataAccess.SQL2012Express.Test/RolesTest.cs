using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataAccess.SQL2012Express.Test
{
    [TestClass]
    public class RolesTest
    {
        [TestMethod]
        public void GetAllRolesTest()
        {
            var dal = new RolesDAL();
            List<RolesDTO> data = new List<RolesDTO>();

            data = dal.GetAllRoles();
            Assert.IsTrue(data.Count > 0, "Roles GetAll failed");

        }
    }
}
