using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace LinqToSql.SqlClient
{
    public class SqlClient
    {
        private SqlConnection _connection;
        private Logger _logger;

        public SqlClient(string connectionString = @"Server=localhost\SQLEXPRESS;Database=LinqToSql;Trusted_Connection=True;") 
        {
            this._connection = new SqlConnection(connectionString);
            this._logger = new Logger();
        }
        public SqlConnection Connect()
        {
            try
            {
                this._connection.Open();
            }
            catch (SqlException ex)
            {
                this._logger.Error(ex.Message);
                return null;
            }

            if (this._connection.State == System.Data.ConnectionState.Open)
            {
                this._logger.Info("Successfully connect to " + this._connection.ConnectionString);
            }

            return this._connection;
        }

        public SqlDataReader ExecuteSelect(string query) 
        {
            var command = new SqlCommand();
            command.Connection = this._connection;
            command.CommandText = query;
            this._logger.Debug(string.Format("Call execute: `{0}`...", query));

            SqlDataReader reader = null;

            try
            {
                reader = command.ExecuteReader();
            }
            catch (Exception ex)
            {
                this._logger.Error(ex.Message);
                return reader;
            }

            this._logger.Debug("Execution finished...");

            return reader;
        }

        public int ExecuteInsert(string query) 
        {
            var command = new SqlCommand();
            command.Connection = this._connection;
            command.CommandText = query;
            this._logger.Debug(string.Format("Call execute: `{0}`...", query));

            int result = 0;

            try 
            {
                result = command.ExecuteNonQuery();
            }
            catch(Exception ex) 
            {
                this._logger.Error(ex.Message);
                return result;
            }

            this._logger.Debug(string.Format("Execution finished: inserted {0} row(s)...", result));

            return result;
        }

        public int ExecuteUpdate(string query) 
        {
            var command = new SqlCommand();
            command.Connection = this._connection;
            command.CommandText = query;
            this._logger.Debug(string.Format("Call execute: `{0}`...", query));

            int result = 0;

            try
            {
                result = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                this._logger.Error(ex.Message);
                return result;
            }

            this._logger.Debug(string.Format("Execution finished: updated {0} row(s)...", result));

            return result;
        }

        public int ExecuteDelete(string query) 
        {
            var command = new SqlCommand();
            command.Connection = this._connection;
            command.CommandText = query;
            this._logger.Debug(string.Format("Call execute: `{0}`...", query));

            int result = 0;

            try
            {
                result = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                this._logger.Error(ex.Message);
                return result;
            }

            this._logger.Debug(string.Format("Execution finished: deleted {0} row(s)...", result));

            return result;
        } 
    }
}
