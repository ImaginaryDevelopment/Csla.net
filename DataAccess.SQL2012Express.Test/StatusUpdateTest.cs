using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataAccess.SQL2012Express.Test
{
    [TestClass]
    public class StatusUpdateTest
    {
        [TestMethod]
        public void UpdateStatusUpdateTest()
        {
            var dal = new StatusUpdateDAL();
            var data = new StatusUpdateDTO();

            data.PersonID = 2;
            data.ProjectID = 2;
            data.StatusID = 3;
            data.IncidentID = 8675310;
            data.StatusText = "Ran server optimization";
            data.DatePerformed = DateTime.Today.AddDays(-1);
            data.DateRecorded = DateTime.Now;
            data.DateLastUpdated = DateTime.Now;
            data.UpdatedBy = "Liza Bortell";
            data.IsDeleted = false;
            data.IsNew = true;

            data = dal.Update(data);
            Assert.IsTrue(data.ID > 0, "Primary Key ID is less than zero indicating new PK didn't come back.");
            
            //now test update
            data.StatusText += " updated";
            data = dal.Update(data);

            //now test delete
            data.IsDeleted = true;
            data = dal.Update(data);
        }

        [TestMethod]
        public void TestFetch()
        {
            var dal = new StatusUpdateDAL();
            var data = new StatusUpdateDTO();

            List<StatusUpdateDTO> results = new List<StatusUpdateDTO>();

            //Note: I know how many of each are in the database for these tests! 

            //first test by person
            results = dal.GetStatusUpdatesByPerson(1);
            Assert.IsTrue(results.Count == 1, "Fetch By Person failed");

            //then by person and project
            results = dal.GetStatusUpdatesByPersonAndProject(1, 1);
            Assert.IsTrue(results.Count == 1, "Fetch by Person and Project failed.");

            //then by project

            results = dal.GetStatusByProject(1);
            Assert.IsTrue(results.Count == 2, "Fetch by Person and Project failed.");
        }
    }
}
