using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using Microsoft.Data.SqlClient;
namespace DAL
{
    public class DAL_User
    {
        DTO_User p;

        //public DAL_User() { }
        public DAL_User()
        {
            p = new DTO_User(); // Khởi tạo mặc định để tránh null
        }

        public DAL_User(string id, string username, string password, string role, string avatar, DateTime createdAt)
        {
            p = new DTO_User(id, username, password, role, avatar, createdAt);
        }

        public void addQuery()
        {
            string query = "INSERT INTO users VALUES (" +
                           p.UserID + ", '" + p.Username + "', '" + p.Password + "', '" + p.Role + "', '" +
                           p.AvatarPath + "', '" + p.CreatedAt.ToString("yyyy-MM-dd HH:mm:ss") + "')";
            Connection.ActionQuery(query);
        }

        public void updateQuery()
        {
            string query = "UPDATE users SET " +
                           "username = '" + p.Username + "', " +
                           "password = '" + p.Password + "', " +
                           "role = '" + p.Role + "', " +
                           "avatar_path = '" + p.AvatarPath + "' " +
                           "WHERE user_id = " + p.UserID;
            Connection.ActionQuery(query);
        }

        public void deleteQuery()
        {
            string query = "DELETE FROM users WHERE user_id = " + p.UserID;
            Connection.ActionQuery(query);
        }

        public DataTable selectQuery()
        {
            string query = "SELECT * FROM users";
            return Connection.SelectQuery(query);
        }

        public DataTable loginUser(string username, string password)
        {
            string sql = $"SELECT * FROM users WHERE username = '{username}' AND password = '{password}'";
            return Connection.SelectQuery(sql);
        }

        // DAL_User.cs
        public bool CheckLogin(string username, string password)
        {
            string sql = $"SELECT * FROM users WHERE username = '{username}' AND password = '{password}'";
            return Connection.HasRows(sql);
        }

        public void UpdatePassword(string username, string newPassword)
        {
            string sql = $"UPDATE users SET password = '{newPassword}' WHERE username = '{username}'";
            Connection.ActionQuery(sql);
        }


        // Phương thức lấy thông tin người dùng theo username
        public DataTable GetUserInfoByUsername(string username)
        {
            string query = $"SELECT username, avatar_path FROM users WHERE username  = '{username}'";
            return Connection.SelectQuery(query);
        }
        public static int GetEmployeeCount()
        {
            string query = "SELECT COUNT(*) FROM users";
            var table = Connection.SelectQuery(query);
            return Convert.ToInt32(table.Rows[0][0]);
        }

        

    }
}
