using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataAccess.SQL2012Express.Test
{
    [TestClass]
    public class PersonDalTest
    {
        [TestMethod]
        public void UpdatePersonTest()
        {
            var dal = new PersonDAL();

            var data = new PersonDTO();
            //test insert
            data.IsDeleted = false;
            data.IsNew = true;
            data.IsActive = true;
            data.UserName = @"avery@advovet.com";
            data.Password = "Password1";
            data.FirstName = "Avery";
            data.MiddleName = "Marmol";
            data.LastName = "Bortell";
            data.DateLastUpdated = DateTime.Now;
            data.UpdatedBy = "Test Script";
            //test the dal and insert
            data = dal.Update(data);
            Assert.IsTrue(data.ID > 0, "Person ID is less than zero indicating new PK did not come back.");
            
            //test Update  note the DAL should have prepared the dto metadata.
            data.UpdatedBy = "Test Update Script";
            data = dal.Update(data);

            //test delete
            data.IsDeleted = true;
            data = dal.Update(data);

            //If delete was successful server sets pk to -1
            Assert.IsTrue(data.ID < 0, "Person PK < 0 therefore delete was successful");

            data = null;
            dal = null;
        }

        [TestMethod]
        public void TestFetches()
        {
            var dal = new PersonDAL();
            
            List<PersonDTO> data = new List<PersonDTO>();

            //test fetch 1
            data.Add(dal.Fetch(1));
            Assert.IsTrue(data.Count == 1, "There is not a single person in the list.  Failed single fetch.");
            //clear the list
            data.Clear();
            //test fetch all
            data.AddRange(dal.Fetch());
            Assert.IsTrue(data.Count > 1, "The fetch all failed.");
            dal = null;
            data = null;
        }
    }
}
