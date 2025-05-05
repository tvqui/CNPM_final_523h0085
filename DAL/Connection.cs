using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace DAL
{
    public class Connection
    {
        private static SqlConnection GetConnection()
        {
            string connectionString = ConfigReader.GetConnectionString();
            SqlConnection connection = new SqlConnection(connectionString);
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            return connection;
        }

        public static void ActionQuery(string sql)
        {
            using (SqlConnection connection = GetConnection())
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.ExecuteNonQuery();
            }
        }

        public static DataTable SelectQuery(string sql)
        {
            using (SqlConnection connection = GetConnection())
            using (SqlDataAdapter adapter = new SqlDataAdapter(sql, connection))
            {
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }

        public static bool HasRows(string sql)
        {
            using (SqlConnection connection = GetConnection())
            using (SqlCommand command = new SqlCommand(sql, connection))
            using (SqlDataReader reader = command.ExecuteReader())
            {
                return reader.HasRows;
            }
        }
    }
}