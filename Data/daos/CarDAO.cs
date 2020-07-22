using Data.dtos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data.daos
{
    public class CarDAO
    {
        public DataTable getCarList(bool sold)
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
                cmd.Parameters.Add("@sold", SqlDbType.Bit).Value = sold;
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

        public bool checkIDDulicate(string carID)
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
                cmd.CommandText = "checkIDExist";
                cmd.Parameters.Add("@CarID", SqlDbType.NVarChar).Value = carID;
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

        public bool deleteCar(string carID)
        {
            SqlConnection conn = null;
            SqlCommand cmd = null;
            bool result = false;
            try
            {
                conn = utils.DBConnection.GetConnection();
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "deleteCar";
                cmd.Parameters.Add("@CarID", SqlDbType.NVarChar).Value = carID;
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
        }

        public bool updateCar(CarDTO car)
        {
            SqlConnection conn = null;
            SqlCommand cmd = null;
            bool result = false;
            try
            {
                conn = utils.DBConnection.GetConnection();
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "updateCar";
                cmd.Parameters.Add("@Name", SqlDbType.NVarChar).Value = car.name;
                cmd.Parameters.Add("@Type", SqlDbType.NVarChar).Value = car.type;
                cmd.Parameters.Add("@Brand", SqlDbType.NVarChar).Value = car.brand;
                cmd.Parameters.Add("@Model", SqlDbType.NVarChar).Value = car.model;
                cmd.Parameters.Add("@Origin", SqlDbType.NVarChar).Value = car.origin;
                cmd.Parameters.Add("@Color", SqlDbType.NVarChar).Value = car.color;
                cmd.Parameters.Add("@Price", SqlDbType.Float).Value = car.price;
                cmd.Parameters.Add("@Status", SqlDbType.Bit).Value = car.status;
                cmd.Parameters.Add("@ImageName", SqlDbType.NVarChar).Value = car.imageName;
                cmd.Parameters.Add("@CarID", SqlDbType.NVarChar).Value = car.carID;
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
        }

        public AutoCompleteStringCollection getCar()
        {
            SqlConnection conn = null;
            SqlCommand cmd = null;
            SqlDataReader reader = null;
            AutoCompleteStringCollection listName = new AutoCompleteStringCollection();
            try
            {
                conn = utils.DBConnection.GetConnection();
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "getCar";
                cmd.Connection = conn;
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                    reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            listName.Add(reader.GetString(1) + "-" + reader.GetString(0));
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
            return listName;
        }

        public CarDTO getCarByID(string id)
        {
            SqlConnection conn = null;
            SqlCommand cmd = null;
            SqlDataReader reader = null;
            CarDTO dto = null;
            try
            {
                conn = utils.DBConnection.GetConnection();
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "getCarByID";
                cmd.Parameters.Add("@carID", SqlDbType.NVarChar).Value = id.Trim();
                cmd.Connection = conn;
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                    reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        if (reader.Read())
                        {
                            dto = new CarDTO();
                            dto.carID = reader.GetString(0);
                            dto.name = reader.GetString(1);
                            dto.type = reader.GetString(2);
                            dto.brand = reader.GetString(3);
                            dto.model = reader.GetString(4);
                            dto.price = (float)reader.GetDouble(5);
                            dto.status = reader.GetBoolean(6);
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
            return dto;
        }

        public bool updateSaleCar(string id)
        {
            SqlConnection conn = null;
            SqlCommand cmd = null;
            bool result = false;
            try
            {
                conn = utils.DBConnection.GetConnection();
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "updateSale";
                cmd.Parameters.Add("@carID", SqlDbType.NVarChar).Value = id;
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
        }
    }
} 
