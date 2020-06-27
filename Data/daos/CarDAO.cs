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
    public class CarDAO
    {
        public DataTable getCarList()
        {
            SqlConnection conn = null;
            SqlCommand cmd = null;
            SqlDataAdapter da = null;
            DataTable dtCar = null;
            try
            {
                conn = utils.DBConnection.GetConnection();
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "getCarList";
                cmd.Connection = conn;
                da = new SqlDataAdapter(cmd);
                if (conn.State == ConnectionState.Closed)
                {
                    dtCar = new DataTable();
                    conn.Open();
                    da.Fill(dtCar);
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
            return dtCar;
        }

        public bool insertNewCar(CarDTO newCar)
        {
            SqlConnection conn = null;
            SqlCommand cmd = null;
            bool result = false;
            try
            {
                conn = utils.DBConnection.GetConnection();
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "insertNewCar";
                cmd.Parameters.Add("@CarID", SqlDbType.NVarChar).Value = newCar.carID;
                cmd.Parameters.Add("@Name", SqlDbType.NVarChar).Value = newCar.name;
                cmd.Parameters.Add("@Type", SqlDbType.NVarChar).Value = newCar.type;
                cmd.Parameters.Add("@Brand", SqlDbType.NVarChar).Value = newCar.brand;
                cmd.Parameters.Add("@Model", SqlDbType.NVarChar).Value = newCar.model;
                cmd.Parameters.Add("@Origin", SqlDbType.NVarChar).Value = newCar.origin;
                cmd.Parameters.Add("@Color", SqlDbType.NVarChar).Value = newCar.color;
                cmd.Parameters.Add("@Price", SqlDbType.Float).Value = newCar.price;
                cmd.Parameters.Add("@Status", SqlDbType.Bit).Value = newCar.status;
                cmd.Parameters.Add("@ImageName", SqlDbType.NVarChar).Value = newCar.imageName;
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
    }
} 
