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
    public class PersonDAL: IPersonDAL
    {

        public List<PersonDTO> Fetch()
        {
            var results = new List<PersonDTO>();
            using (var ctx = ConnectionManager<SqlConnection>.GetManager("SqlDB"))
            {                
                var cmd = ctx.Connection.CreateCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "GetAllPersons";
                using (var dr = new SafeDataReader(cmd.ExecuteReader()))
                {
                    while (dr.Read())
                    {
                        results.Add(new PersonDTO { ID = dr.GetInt32("ID"), IsActive = dr.GetBoolean("IsActive"), RoleID = dr.GetInt32("RoleID"), UserName = dr.GetString("UserName"), Password = dr.GetString("Password"), FirstName = dr.GetString("FirstName"), MiddleName = dr.GetString("MiddleName"), LastName = dr.GetString("LastName"), DateLastUpdated = dr.GetDateTime("DateLastUpdated"), UpdatedBy = dr.GetString("UpdatedBy"), IsNew = false, IsDeleted = false });
                    }
                }
            }
            return results;
        }

        public PersonDTO Fetch(int id)
        {
            var result = new PersonDTO();
            using (var ctx = ConnectionManager<SqlConnection>.GetManager("SqlDB"))
            {
                var cmd = ctx.Connection.CreateCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "GetPerson";
                cmd.Parameters.AddWithValue("@ID", id);
                using (var dr = new SafeDataReader(cmd.ExecuteReader()))
                {
                    if (dr.Read())
                    {
                        result = new PersonDTO { ID = dr.GetInt32("ID"), IsActive = dr.GetBoolean("IsActive"), RoleID = dr.GetInt32("RoleID"), UserName = dr.GetString("UserName"), Password = dr.GetString("Password"), FirstName = dr.GetString("FirstName"), MiddleName = dr.GetString("MiddleName"), LastName = dr.GetString("LastName"), DateLastUpdated = dr.GetDateTime("DateLastUpdated"), UpdatedBy = dr.GetString("UpdatedBy"), IsNew = false, IsDeleted = false };
                    }
                }
            }
            return result;
        }

        public PersonDTO Update(PersonDTO data)
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
                            cmd.CommandText = "DeletePerson";
                            cmd.Parameters.AddWithValue("@ID", data.ID);
                            cmd.Parameters.AddWithValue("@UpdatedBy", data.UpdatedBy);
                            cmd.Parameters.AddWithValue("DateLastUpdated", data.DateLastUpdated);
                            var rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected == 0)
                                throw new DataNotFoundException("DeletePerson failed");
                        }
                        //reset the primary key either way
                        data.ID = -1;
                    }
                        //otherwise maybe it is new
                    else if (data.IsNew)
                    {
                        //insert data
                        cmd.CommandText = "AddPerson";
                        cmd.Parameters.AddWithValue("@IsActive", data.IsActive);
                        cmd.Parameters.AddWithValue("@RoleID", data.RoleID);
                        cmd.Parameters.AddWithValue("@UserName", data.UserName);
                        cmd.Parameters.AddWithValue("@Password", data.Password);
                        cmd.Parameters.AddWithValue("@FirstName", data.FirstName);
                        cmd.Parameters.AddWithValue("@MiddleName", data.MiddleName);
                        cmd.Parameters.AddWithValue("@LastName", data.LastName);
                        cmd.Parameters.AddWithValue("@DateLastUpdated", data.DateLastUpdated);
                        cmd.Parameters.AddWithValue("@UpdatedBy", data.UpdatedBy);
                        SqlParameter param = new SqlParameter("@NewID", System.Data.SqlDbType.Int);
                        param.Direction = System.Data.ParameterDirection.Output;
                        cmd.Parameters.Add(param);
                        var rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected == 0)
                            throw new DataNotFoundException("AddPerson failed");
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
                        cmd.CommandText = "UpdatePerson";
                        cmd.Parameters.AddWithValue("@ID", data.ID);
                        cmd.Parameters.AddWithValue("@IsActive", data.IsActive);
                        cmd.Parameters.AddWithValue("@RoleID", data.RoleID);
                        cmd.Parameters.AddWithValue("@UserName", data.UserName);
                        cmd.Parameters.AddWithValue("@Password", data.Password);
                        cmd.Parameters.AddWithValue("@FirstName", data.FirstName);
                        cmd.Parameters.AddWithValue("@MiddleName", data.MiddleName);
                        cmd.Parameters.AddWithValue("@LastName", data.LastName);
                        cmd.Parameters.AddWithValue("@DateLastUpdated", data.DateLastUpdated);
                        cmd.Parameters.AddWithValue("@UpdatedBy", data.UpdatedBy);
                        var rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected == 0)
                            throw new DataNotFoundException("UpdatePerson failed");
                        data.IsNew = false;
                        data.IsDeleted = false;
                    }
                }
            }
            return data;
        }
    
        }       
}

