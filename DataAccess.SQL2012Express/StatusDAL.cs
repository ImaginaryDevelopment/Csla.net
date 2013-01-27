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
    public class StatusDAL: IStatus
    {
        public List<StatusDTO> GetAllStatus()
        {
            var results = new List<StatusDTO>();
            using (var ctx = ConnectionManager<SqlConnection>.GetManager("SqlDB"))
            {
                var cmd = ctx.Connection.CreateCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "GetAllStatus";
                using (var dr = new SafeDataReader(cmd.ExecuteReader()))
                {
                    while (dr.Read())
                    {
                        results.Add(new StatusDTO { ID = dr.GetInt32("ID"), IsActive = dr.GetBoolean("IsActive"), StatusText = dr.GetString("StatusText"), DateLastUpdated = dr.GetDateTime("DateLastUpdated"), UpdatedBy = dr.GetString("UpdatedBy"), IsDeleted = false, IsNew = false });
                    }
                }

            }
            return results;
        }
    }
}
