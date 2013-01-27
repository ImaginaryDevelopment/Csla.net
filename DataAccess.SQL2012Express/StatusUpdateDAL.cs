using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Csla.Data;
using System.Data.SqlClient;
using DataAccess;

namespace DataAccess.SQL2012Express
{
    public class StatusUpdateDAL: IStatusUpdate
    {
        public List<StatusUpdateDTO> GetStatusUpdatesByPerson(int personID)
        {
            var results = new List<StatusUpdateDTO>();
            using (var ctx = ConnectionManager<SqlConnection>.GetManager("SqlDB"))
            {
                var cmd = ctx.Connection.CreateCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "GetStatusUpdateByPersonID";
                cmd.Parameters.AddWithValue("@ID", personID);
                using (var dr = new SafeDataReader(cmd.ExecuteReader()))
                {
                    while (dr.Read())
                    {
                        results.Add(new StatusUpdateDTO { ID = dr.GetInt32("ID"), PersonID = dr.GetInt32("PersonID"), ProjectID = dr.GetInt32("ProjectID"), StatusID = dr.GetInt32("StatusID"), IncidentID = dr.GetInt32("IncidentID"), RequestID = dr.GetInt32("RequestID"), ChangeID = dr.GetInt32("ChangeID"), StatusText = dr.GetString("StatusText"), DatePerformed = dr.GetDateTime("DatePerformed"), DateRecorded = dr.GetDateTime("DateRecorded"), DateLastUpdated = dr.GetDateTime("DateLastUpdated"), UpdatedBy = dr.GetString("UpdatedBy"), IsDeleted = false, IsNew = false });
                    }
                }
            }
            return results;
        }

        public List<StatusUpdateDTO> GetStatusUpdatesByPersonAndDateRange(int personID, DateTime start, DateTime end)
        {
            throw new NotImplementedException();
        }

        public List<StatusUpdateDTO> GetStatusUpdatesByPersonAndProject(int personID, int projectID)
        {
            var results = new List<StatusUpdateDTO>();
            using (var ctx = ConnectionManager<SqlConnection>.GetManager("SqlDB"))
            {
                var cmd = ctx.Connection.CreateCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "GetStatusUpdateByPersonandProjectID";
                cmd.Parameters.AddWithValue("@PersonID", personID);
                cmd.Parameters.AddWithValue("@ProjectID", projectID);
                using (var dr = new SafeDataReader(cmd.ExecuteReader()))
                {
                    while (dr.Read())
                    {
                        results.Add(new StatusUpdateDTO { ID = dr.GetInt32("ID"), PersonID = dr.GetInt32("PersonID"), ProjectID = dr.GetInt32("ProjectID"), StatusID = dr.GetInt32("StatusID"), IncidentID = dr.GetInt32("IncidentID"), RequestID = dr.GetInt32("RequestID"), ChangeID = dr.GetInt32("ChangeID"), StatusText = dr.GetString("StatusText"), DatePerformed = dr.GetDateTime("DatePerformed"), DateRecorded = dr.GetDateTime("DateRecorded"), DateLastUpdated = dr.GetDateTime("DateLastUpdated"), UpdatedBy = dr.GetString("UpdatedBy"), IsDeleted = false, IsNew = false });
                    }
                }
            }
            return results;
        }

        public List<StatusUpdateDTO> GetStatusUpdatesByPersonAndProjectAndDateRange(int personID, int projectID, DateTime start, DateTime end)
        {
            throw new NotImplementedException();
        }

        public StatusUpdateDTO Update(StatusUpdateDTO data)
        {
            using (var ctx = ConnectionManager<SqlConnection>.GetManager("SqlDB"))
            {
                using (var cmd = ctx.Connection.CreateCommand())
                {
                    data.DateLastUpdated = DateTime.Now;
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    //if it is deleted enter here because we still have the 'IsNew' to figure in later
                    if (data.IsDeleted)
                    {
                        //new data won't be in the database so save the work and 'do nothing' ;)
                        if (!data.IsNew)
                        {
                            //delete the data actually we mark notactive in db to preserve past entries :)
                            cmd.CommandText = "DeleteStatusUpdate";
                            cmd.Parameters.AddWithValue("@ID", data.ID);
                            //we really do remove status updated!
                            var rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected == 0)
                                throw new DataNotFoundException("Delete StatusUpdate failed");
                        }
                        //reset the primary key either way
                        data.ID = -1;
                    }
                    //otherwise maybe it is new
                    else if (data.IsNew)
                    {
                        //insert data
                        cmd.CommandText = "AddStatusUpdate";
                        cmd.Parameters.AddWithValue("@PersonID", data.PersonID);
                        cmd.Parameters.AddWithValue("@ProjectID", data.ProjectID);
                        cmd.Parameters.AddWithValue("@StatusID", data.StatusID);
                        cmd.Parameters.AddWithValue("@IncidentID", data.IncidentID);
                        cmd.Parameters.AddWithValue("@RequestID", data.RequestID);
                        cmd.Parameters.AddWithValue("@ChangeID", data.ChangeID);
                        cmd.Parameters.AddWithValue("@StatusText", data.StatusText);
                        cmd.Parameters.AddWithValue("@DatePerformed", data.DatePerformed);
                        cmd.Parameters.AddWithValue("@DateRecorded", data.DateRecorded);
                        cmd.Parameters.AddWithValue("@DateLastUpdated", data.DateLastUpdated);
                        cmd.Parameters.AddWithValue("@UpdatedBy", data.UpdatedBy);
                        SqlParameter param = new SqlParameter("@NewID", System.Data.SqlDbType.Int);
                        param.Direction = System.Data.ParameterDirection.Output;
                        cmd.Parameters.Add(param);
                        var rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected == 0)
                            throw new DataNotFoundException("Add StatusUpdate failed");
                        else
                        {
                            //set primary key to database-generated (here scope_identity) value
                            data.ID = Convert.ToInt32(param.Value);
                            data.IsNew = false;
                            data.IsDeleted = false;
                        }
                    }
                    //end of logic tree.  It is an update.
                    else
                    {
                        //update the data
                        cmd.CommandText = "UpdateStatusUpdate";
                        cmd.Parameters.AddWithValue("@ID", data.ID);
                        cmd.Parameters.AddWithValue("@PersonID", data.PersonID);
                        cmd.Parameters.AddWithValue("@ProjectID", data.ProjectID);
                        cmd.Parameters.AddWithValue("@StatusID", data.StatusID);
                        cmd.Parameters.AddWithValue("@IncidentID", data.IncidentID);
                        cmd.Parameters.AddWithValue("@RequestID", data.RequestID);
                        cmd.Parameters.AddWithValue("@ChangeID", data.ChangeID);
                        cmd.Parameters.AddWithValue("@StatusText", data.StatusText);
                        cmd.Parameters.AddWithValue("@DatePerformed", data.DatePerformed);
                        cmd.Parameters.AddWithValue("@DateRecorded", data.DateRecorded);
                        cmd.Parameters.AddWithValue("@DateLastUpdated", data.DateLastUpdated);
                        cmd.Parameters.AddWithValue("@UpdatedBy", data.UpdatedBy);
                        var rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected == 0)
                            throw new DataNotFoundException("Update Status failed");
                        data.IsNew = false;
                        data.IsDeleted = false;
                    }
                }
            }
            return data;
        }


        public List<StatusUpdateDTO> GetStatusByProject(int projectID)
        {
            var results = new List<StatusUpdateDTO>();
            using (var ctx = ConnectionManager<SqlConnection>.GetManager("SqlDB"))
            {
                var cmd = ctx.Connection.CreateCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "GetStatusUpdateForProject";
                cmd.Parameters.AddWithValue("@ID", projectID);
                using (var dr = new SafeDataReader(cmd.ExecuteReader()))
                {
                    while (dr.Read())
                    {
                        results.Add(new StatusUpdateDTO { ID = dr.GetInt32("ID"), PersonID = dr.GetInt32("PersonID"), ProjectID = dr.GetInt32("ProjectID"), StatusID = dr.GetInt32("StatusID"), IncidentID = dr.GetInt32("IncidentID"), RequestID = dr.GetInt32("RequestID"), ChangeID = dr.GetInt32("ChangeID"), StatusText = dr.GetString("StatusText"), DatePerformed = dr.GetDateTime("DatePerformed"), DateRecorded = dr.GetDateTime("DateRecorded"), DateLastUpdated = dr.GetDateTime("DateLastUpdated"), UpdatedBy = dr.GetString("UpdatedBy"), IsDeleted = false, IsNew = false });
                    }
                }
            }
            return results;
        }
    }
}
