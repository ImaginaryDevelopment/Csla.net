using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess
{
    public interface IPersonDAL
    {
        List<PersonDTO> Fetch();
        PersonDTO Fetch(int id);
        /// <summary>
        /// Handles Insert, Update, and Delete using the MetaData IsNew and IsDeleted
        /// </summary>
        /// <param name="data"></param>
        /// <returns> a single Person Data Transfer ofject with the ID and DateLastUpdated adjusted</returns>
        PersonDTO Update(PersonDTO data);
    }
}
