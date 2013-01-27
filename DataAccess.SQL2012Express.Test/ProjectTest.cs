using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataAccess.SQL2012Express.Test
{
    [TestClass]
    public class ProjectTest
    {
        [TestMethod]
        public void GetAllProjectsTest()
        {
            var dal = new ProjectDAL();
            List<ProjectDTO> data = new List<ProjectDTO>();

            data = dal.GetAllProjects();
            Assert.IsTrue(data.Count > 0, "Project GetAll failed");

        }
    }
}
