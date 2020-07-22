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


        public DataTable getEmployeeList(bool role)
        {
            SqlConnection conn = null;
            SqlCommand cmd = null;
            SqlDataAdapter da = null;
            DataTable dtEmp = null;
            try
            {
                conn = utils.DBConnection.GetConnection();
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetEmployeeList";
                cmd.Parameters.Add("@role", SqlDbType.Bit).Value = role;
                cmd.Connection = conn;
                da = new SqlDataAdapter(cmd);
                if (conn.State == ConnectionState.Closed)
                {
                    dtEmp = new DataTable();
                    conn.Open();
                    da.Fill(dtEmp);
                }

            }
            catch (Exception se)
            {
                throw new Exception(se.Message);
            }
            finally
            {
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
            return dtEmp;
        }


        public bool checkDupEmpID(String id)
        {
            SqlConnection conn = null;
            SqlCommand cmd = null;
            SqlDataReader reader = null;
            bool result = true;
            try
            {
                conn = utils.DBConnection.GetConnection();
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "checkIdEmpUserName";
                cmd.Parameters.Add("@EmpID", SqlDbType.VarChar).Value = id;
                cmd.Connection = conn;
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                    reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        if (reader.Read())
                        {
                            result = false;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
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
            return result;
        }


        public bool checkDupUserName(String userName)
        {
            SqlConnection conn = null;
            SqlCommand cmd = null;
            SqlDataReader reader = null;
            bool result = true;
            try
            {
                conn = utils.DBConnection.GetConnection();
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "checUserName";
                cmd.Parameters.Add("@UserName", SqlDbType.VarChar).Value = userName;
                cmd.Connection = conn;
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                    reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        if (reader.Read())
                        {
                            result = false;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
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
            return result;
        }


        public bool addNewEmp(EmployeeDTO newEmp)
        {
            SqlConnection conn = null;
            SqlCommand cmd = null;
            bool result = false;
            try
            {
                conn = utils.DBConnection.GetConnection();
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "AddNewEmployee";
                cmd.Parameters.Add("@ID", SqlDbType.Char).Value = newEmp.id;
                cmd.Parameters.Add("@FullName", SqlDbType.NVarChar).Value = newEmp.fullName;
                cmd.Parameters.Add("@UserName", SqlDbType.NVarChar).Value = newEmp.userName;
                cmd.Parameters.Add("@Password", SqlDbType.VarChar).Value = newEmp.password;
                cmd.Parameters.Add("@Role", SqlDbType.Bit).Value = newEmp.role;
                cmd.Parameters.Add("@Status", SqlDbType.Bit).Value = newEmp.status;
                cmd.Connection = conn;
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                result = (cmd.ExecuteNonQuery() < 0);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
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
            return result;
        }


        public bool updateEmployee(EmployeeDTO emp)
        {
            SqlConnection conn = null;
            SqlCommand cmd = null;
            bool result = false;
            try
            {
                conn = utils.DBConnection.GetConnection();
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "updateEmp";
                cmd.Parameters.Add("@Role", SqlDbType.Bit).Value = emp.role;
                cmd.Parameters.Add("@Status", SqlDbType.Bit).Value = emp.status;
                cmd.Parameters.Add("@ID", SqlDbType.VarChar).Value = emp.id;
                cmd.Connection = conn;
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                result = (cmd.ExecuteNonQuery() > 0);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
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
            return result;
        }

    }
}
