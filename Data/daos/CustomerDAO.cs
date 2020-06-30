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
    public class CustomerDAO
    {
        public bool checkPhoneDulicate(string phone)
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
                cmd.CommandText = "checkPhoneExist";
                cmd.Parameters.Add("@Phone", SqlDbType.Char).Value = phone;
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
        }//end checkPhoneDuplicate
        public DataTable getCustomerList()
        {
            SqlConnection conn = null;
            SqlCommand cmd = null;
            SqlDataAdapter da = null;
            DataTable dtCustomer = null;
            try
            {
                conn = utils.DBConnection.GetConnection();
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "getCustomerList";
                cmd.Connection = conn;
                da = new SqlDataAdapter(cmd);
                if (conn.State == ConnectionState.Closed)
                {
                    dtCustomer = new DataTable();
                    conn.Open();
                    da.Fill(dtCustomer);
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
            return dtCustomer;
        }//end getCustomerList
        public bool addNewCustomer(CustomerDTO newCustomer)
        {
            SqlConnection conn = null;
            SqlCommand cmd = null;
            bool result = false;
            try
            {
                conn = utils.DBConnection.GetConnection();
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "AddNewCustomer";
                cmd.Parameters.Add("@Phone", SqlDbType.Char).Value = newCustomer.phone;
                cmd.Parameters.Add("@CustomerName", SqlDbType.NVarChar).Value = newCustomer.customerName; ;
                cmd.Parameters.Add("@Email", SqlDbType.NVarChar).Value = newCustomer.email;
                cmd.Parameters.Add("@Address", SqlDbType.NVarChar).Value = newCustomer.address;               
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
        }//end AddCustomer
        public bool deleteCustomer(string phone)
        {
            SqlConnection conn = null;
            SqlCommand cmd = null;
            bool result = false;
            try
            {
                conn = utils.DBConnection.GetConnection();
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "deleteCustomer";
                cmd.Parameters.Add("@Phone", SqlDbType.Char).Value = phone;
                cmd.Connection = conn;
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                result = (cmd.ExecuteNonQuery() < 0);
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
        }//end delete Customer
    }//end customerDAO
}
