using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace DataAccess
{
    public interface IStatusUpdate
    {
        List<StatusUpdateDTO> GetStatusUpdatesByPerson(int personID);
        List<StatusUpdateDTO> GetStatusByProject(int projectID);
        List<StatusUpdateDTO> GetStatusUpdatesByPersonAndDateRange(int personID, DateTime start, DateTime end);
        List<StatusUpdateDTO> GetStatusUpdatesByPersonAndProject(int personID, int projectID);
        List<StatusUpdateDTO> GetStatusUpdatesByPersonAndProjectAndDateRange(int personID, int projectID, DateTime start, DateTime end);
        StatusUpdateDTO Update(StatusUpdateDTO data);
    }
}
