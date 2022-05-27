using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;

namespace MampoteSystem.Datos.AdoNet
{
    public class SqlManager
    {
        SqlConnection sql;
        private bool isClosed;
        private string connectionString;

        public SqlManager(string connectionString)
        {
            this.connectionString = connectionString;

            sql = new SqlConnection(connectionString);
            isClosed = true;
        }

        protected void Close(bool value)
        {
            this.isClosed = value;
        }

        public void Dispose(){ sql.Dispose(); }

        public DataSet GetData(string command)
        {
            try
            {
                using (isClosed ? (new SqlConnection(connectionString)) : sql)
                {
                    if (sql.State == ConnectionState.Closed)
                    {
                        sql.Open();
                    }

                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command, sql))
                    {
                        var dataSet = new DataSet();
                        dataAdapter.Fill(dataSet);
                        this.Close(true);
                        return dataSet;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataSet GetData(string command, params SqlParameter[] sqlParameters)
        {
            try
            {
                using (var newConnection = isClosed ? new SqlConnection(connectionString) : sql)
                {
                    newConnection.Open();
                    using (SqlDataAdapter da = new SqlDataAdapter(command, newConnection))
                    {
                        da.SelectCommand.CommandType = CommandType.StoredProcedure;
                        da.SelectCommand.Parameters.AddRange(sqlParameters);

                        var ds = new DataSet();
                        da.Fill(ds);
                        Close(true);
                        return ds;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<T> ToList<T>(DataTable datos) where T:class, new()
        {
            try
            {
                var list = new List<T>();
                foreach(var row in datos.AsEnumerable())
                {
                    T obj = new T();
                    foreach (var property in obj.GetType().GetProperties())
                    {
                        try
                        {
                            PropertyInfo propertyInfo = obj.GetType().GetProperty(property.Name);
                            propertyInfo.SetValue(obj, 
                                                  Convert.ChangeType(row[property.Name], 
                                                  propertyInfo.PropertyType,
                                                  null));

                        }
                        catch
                        {
                            continue;
                        }
                    }

                    list.Add(obj);
                }

                return list;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
        }

        public Int32 ExecuteNonQuery(string commandText, CommandType commandType, params SqlParameter[] sqlParameters)
        {
            try
            {
                using (isClosed ? (new SqlConnection(connectionString)) : sql)
                {
                    if(sql.State == ConnectionState.Closed) { 
                        sql.Open();
                    }

                    using (SqlCommand command = new SqlCommand(commandText, sql))
                    {
                        command.CommandType = commandType;
                        command.Parameters.AddRange(sqlParameters);
                        Close(true);

                        return command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public Int32 ExecuteNonQuery(string commandText, CommandType commandType)
        {
            try
            {
                using (isClosed ? (new SqlConnection(connectionString)) : sql)
                {

                    if (sql.State == ConnectionState.Closed)
                    {
                        sql.Open();
                    }
                    using (SqlCommand command = new SqlCommand(commandText, sql))
                    {
                        command.CommandType = commandType;
                        Close(true);

                        return command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Object ExecuteScalar(string commandText, CommandType commandType, params SqlParameter[] sqlParameters)
        {
            try
            {
                using (isClosed ? (new SqlConnection(connectionString)) : sql)
                {
                    sql.Open();
                    using (SqlCommand command = new SqlCommand(commandText, sql))
                    {
                        command.CommandType = commandType;
                        command.Parameters.AddRange(sqlParameters);
                        Close(true);

                        return command.ExecuteScalar();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public Object ExecuteScalar(string commandText, CommandType commandType)
        {
            try
            {
                using (isClosed ? (new SqlConnection(connectionString)) : sql)
                {
                    sql.Open();
                    using (SqlCommand command = new SqlCommand(commandText, sql))
                    {
                        command.CommandType = commandType;
                        Close(true);

                        return command.ExecuteScalar();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
