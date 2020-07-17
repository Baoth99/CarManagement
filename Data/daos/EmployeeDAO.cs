using Data.dtos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.daos
{
    public class EmployeeDAO
    {
        public EmployeeDTO Login(string userName, string password)
        {
            SqlConnection conn = null;
            SqlCommand cmd = null;
            SqlDataReader reader = null;
            EmployeeDTO employee = null;
            try
            {
                conn = utils.DBConnection.GetConnection();
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "checkLogin";
                cmd.Parameters.Add("@UserName", SqlDbType.NVarChar).Value = userName;
                cmd.Parameters.Add("@Password", SqlDbType.NVarChar).Value = password;
                cmd.Connection = conn;
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                    reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        if (reader.Read())
                        {
                            employee = new EmployeeDTO()
                            {
                                id = reader.GetString(0),
                                fullName = reader.GetString(1),
                                role = reader.GetBoolean(2),
                                status = reader.GetBoolean(3), 
                            };
                        }
                    }
                }
            }
            catch (Exception se)
            {

                throw new Exception(se.Message);
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
                if (cmd != null)
                {
                    cmd.Cancel();
                }
                if (conn != null)
                {
                    conn.Close();
                    conn.Dispose();
                }
            }
            return employee;
        }
    }
}
