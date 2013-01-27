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
    public class ProjectDAL: IProject
    {
        public List<ProjectDTO> GetAllProjects()
        {
            var results = new List<ProjectDTO>();
            using (var ctx = ConnectionManager<SqlConnection>.GetManager("SqlDB"))
            {
                var cmd = ctx.Connection.CreateCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "GetAllProjects";

                using (var dr = new SafeDataReader(cmd.ExecuteReader()))
                {
                    while (dr.Read())
                    {
                        results.Add(new ProjectDTO { ID = dr.GetInt32("ID"), IsActive = dr.GetBoolean("IsActive"), Name = dr.GetString("Name"), ManagerID = dr.GetInt32("ManagerID"), DateLastUpdated = dr.GetDateTime("DateLastUpdated"), UpdatedBy = dr.GetString("UpdatedBy"), IsDeleted = false, IsNew = false });
                    }
                }
                
            }
            return results;
        }
    }
}
