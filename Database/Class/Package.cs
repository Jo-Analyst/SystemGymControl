﻿using System.Data;
using System.Data.SqlClient;

namespace Database
{
    public class Package
    {
        private int id;
        private string description;
        private decimal valuePackage;
        private int duration;
        private string period;

        string _sql;

        public int _id
        {
            get { return id; }
            set { id = value; }
        }
        public string _description
        {
            get { return description; }
            set { description = value; }
        }
        public int _duration
        {
            get { return duration; }
            set { duration = value; }
        }
        public decimal _value
        {
            get { return valuePackage; }
            set { valuePackage = value; }
        }
        public string _period
        {
            get { return period; }
            set { period = value; }
        }

        public void Save()
        {
            SqlConnection connection = new SqlConnection(ConnectionDataBase.stringConnection);
            if (_id == 0)
                _sql = "INSERT INTO packages VALUES (@description, @value, @duration, @period)";
            else
                _sql = "UPDATE packages SET description = @description, value = @value, duration = @duration, period = @period WHERE id = @id";

            SqlCommand command = new SqlCommand(_sql, connection);
            command.Parameters.AddWithValue("@id", _id);
            command.Parameters.AddWithValue("@description", _description);
            command.Parameters.AddWithValue("@value", _value);
            command.Parameters.AddWithValue("@duration", _duration);
            command.Parameters.AddWithValue("@period", _period);
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        public void Delete(int idPackage)
        {
            SqlConnection connection = new SqlConnection(ConnectionDataBase.stringConnection);
            _sql = "DELETE FROM packages WHERE id = @id";
            SqlCommand command = new SqlCommand(_sql, connection);
            command.Parameters.AddWithValue("@id", idPackage);
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        public DataTable SearchAll()
        {
            try
            {
                SqlConnection connection = new SqlConnection(ConnectionDataBase.stringConnection);
                _sql = "SELECT * FROM packages";
                SqlDataAdapter adapter = new SqlDataAdapter(_sql, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@id", _id);
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
            catch
            {
                throw;
            }
        }


        public SqlDataReader SearchID(int idPackage)
        {
            SqlConnection connection = new SqlConnection(ConnectionDataBase.stringConnection);
            try
            {
                connection.Open();
                _sql = "SELECT * FROM packages WHERE id = @id";
                SqlCommand adapter = new SqlCommand(_sql, connection);
                adapter.Parameters.AddWithValue("@id", idPackage);
                SqlDataReader dr = adapter.ExecuteReader();
                dr.Read();
                return dr;
            }
            catch
            {
                throw;
            }
        }

        public DataTable SearchDescription(string description)
        {
            using (var connection = new SqlConnection(ConnectionDataBase.stringConnection))
            { 
                try
                {
                    _sql = $"SELECT * FROM packages WHERE description like '%{description}%'";
                    SqlDataAdapter adapter = new SqlDataAdapter(_sql, connection);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    return table;
                }
                catch
                {
                    throw;
                }
            }
        }
    }
}
