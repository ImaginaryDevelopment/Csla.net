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
    public class RolesDAL:IRoles
    {
        public List<RolesDTO> GetAllRoles()
        {

            var results = new List<RolesDTO>();
            using (var ctx = ConnectionManager<SqlConnection>.GetManager("SqlDB"))
            {
                var cmd = ctx.Connection.CreateCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "GetAllRoles";
                using (var dr = new SafeDataReader(cmd.ExecuteReader()))
                {
                    while (dr.Read())
                    {
                        results.Add(new RolesDTO { ID = dr.GetInt32("ID"), IsActive = dr.GetBoolean("IsActive"), RoleName = dr.GetString("RoleName"), DateLastUpdated = dr.GetDateTime("DateLastUpdated"), UpdatedBy = dr.GetString("UpdatedBy"), IsDeleted = false, IsNew = false });
                    }
                }

            }
            return results;
        }
    }
}
