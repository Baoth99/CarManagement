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
    public class InvoiceDAO
    {

        public DataTable getInvoiceList()
        {
            SqlConnection conn = null;
            SqlCommand cmd = null;
            SqlDataAdapter da = null;
            DataTable dtInvoice = null;
            try
            {
                conn = utils.DBConnection.GetConnection();
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "getInvoiceList";
                cmd.Connection = conn;
                da = new SqlDataAdapter(cmd);
                if (conn.State == ConnectionState.Closed)
                {
                    dtInvoice = new DataTable();
                    conn.Open();
                    da.Fill(dtInvoice);
                }
            }
            catch (Exception)
            {
                throw new Exception();
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
            return dtInvoice;
        }

        public bool addNewInvoice(InvoiceDTO newInvoice)
        {
            SqlConnection conn = null;
            SqlCommand cmd = null;
            bool result = false;
            try
            {
                conn = utils.DBConnection.GetConnection();
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "AddNewInvoice";
                cmd.Parameters.Add("@CarID", SqlDbType.VarChar).Value = newInvoice.carID;
                cmd.Parameters.Add("@Phone", SqlDbType.Char).Value = newInvoice.phone;
                cmd.Parameters.Add("@ID", SqlDbType.VarChar).Value = newInvoice.id;
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

        public string[] getInvoiceInfo(InvoiceDTO dto)
        {
            SqlConnection conn = null;
            SqlCommand cmd = null;
            SqlDataReader reader = null;
            string[] obj = null;
            try
            {
                conn = utils.DBConnection.GetConnection();
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "getInvoice";
                cmd.Parameters.Add("@carID", SqlDbType.VarChar).Value = dto.carID;
                cmd.Parameters.Add("@Phone", SqlDbType.Char).Value = dto.phone;
                cmd.Parameters.Add("@ID", SqlDbType.VarChar).Value = dto.id;
                cmd.Parameters.Add("@invoiceID", SqlDbType.NVarChar).Value = dto.invoiceID;
                cmd.Connection = conn;
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                    reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        if (reader.Read())
                        {
                            obj = new string[8];
                            obj[0] = reader.GetString(0);
                            obj[1] = reader.GetString(1);
                            obj[2] = reader.GetString(2);
                            obj[3] = (float)reader.GetDouble(3) + "";
                            obj[4] = reader.GetString(4);
                            obj[5] = reader.GetString(5);
                            obj[6] = reader.GetString(6);
                            obj[7] = reader.GetString(7);
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
            return obj;
        }
    }
}
