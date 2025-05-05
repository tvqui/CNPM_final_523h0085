using System.Data;
using DTO;
using Microsoft.Data.SqlClient;
namespace DAL
{
    public class DAL_Customer
    {
        DTO_Customer p;

        public DAL_Customer()
        {
        }
        public DAL_Customer(string id, string fname, string lname, string uname, string password, string phone, string email, string avatar)
        {
            p = new DTO_Customer(id, fname, lname, uname, password, phone, email, avatar);
        }

        public DAL_Customer(DTO_Customer customer)
        {
            p = customer;
        }
        public void addQuery()
        {
            string query = "INSERT INTO customers VALUES (" +
                           p.CustomerID + ", '" + p.FirstName + "', '" + p.LastName + "', '" + p.CustomerUsername + "', '" + p.CustomerPassword +
                           "', '" + p.Phone + "', '" + p.Email + "', '" + p.AvatarPath + "')";
            Connection.ActionQuery(query);
        }

        public void updateQuery()
        {
            string query = "UPDATE customers SET " +
                           "first_name = '" + p.FirstName + "', " +
                           "last_name = '" + p.LastName + "', " +
                           "customer_username = '" + p.CustomerUsername + "', " +
                           "customer_password = '" + p.CustomerPassword + "', " +
                           "phone = '" + p.Phone + "', " +
                           "email = '" + p.Email + "', " +
                           "avatar_path = '" + p.AvatarPath + "' " +
                           "WHERE customer_id = " + p.CustomerID;
            Connection.ActionQuery(query);
        }

        public void deleteQuery()
        {
            string query = "DELETE FROM customers WHERE customer_id = " + p.CustomerID;
            Connection.ActionQuery(query);
        }

        public DataTable selectQuery()
        {
            string query = "SELECT * FROM customers";
            return Connection.SelectQuery(query);
        }

        public DataTable loginCustomer(string username, string password)
        {
            string sql = $"SELECT * FROM customers WHERE customer_username = '{username}' AND customer_password = '{password}'";
            return Connection.SelectQuery(sql);
        }

        public void Register()
        {
            string sql = $"INSERT INTO customers (customer_id, first_name, last_name, customer_username, customer_password, phone, email, avatar_path) " +
                         $"VALUES ('{p.CustomerID}','{p.FirstName}', '{p.LastName}', '{p.CustomerUsername}', '{p.CustomerPassword}', '{p.Phone}', '{p.Email}', '{p.AvatarPath}')";
            Connection.ActionQuery(sql);
        }

        public bool CheckUsernameExists()
        {
            string sql = $"SELECT * FROM customers WHERE customer_username = '{p.CustomerUsername}'";
            DataTable dt = Connection.SelectQuery(sql);
            return dt.Rows.Count > 0;
        }

        public DataTable SelectCustomersByDate(string date)
        {
            string sql = $"SELECT * FROM customers WHERE customer_id LIKE 'cus{date}%'";
            return Connection.SelectQuery(sql);
        }

        

        // Phương thức lấy thông tin người dùng theo username
        public DataTable GetUserInfoByUsername(string username)
        {
            string query = $"SELECT first_name, avatar_path FROM customers WHERE customer_username = '{username}'";
            return Connection.SelectQuery(query);
        }

        public static int GetCustomerCount()
        {
            string query = "SELECT COUNT(*) FROM customers";

            var table = Connection.SelectQuery(query);
            return Convert.ToInt32(table.Rows[0][0]);
        }



        public void UpdatePassword(string username, string newPassword)
        {
            string sql = $"UPDATE customers SET customer_password = '{newPassword}' WHERE customer_username = '{username}'";
            Connection.ActionQuery(sql);
        }




    }
}
