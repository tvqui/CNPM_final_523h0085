using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Microsoft.Data.SqlClient;

namespace BUS
{
    public class BUS_User
    {
        DAL_User p;

        public BUS_User(string id, string username, string password, string role, string avatar, DateTime createdAt)
        {
            p = new DAL_User(id, username, password, role, avatar, createdAt);
        }

        public void addQuery()
        {
            p.addQuery();
        }

        public void updateQuery()
        {
            p.updateQuery();
        }

        public void deleteQuery()
        {
            p.deleteQuery();
        }

        public DataTable selectQuery()
        {
            return p.selectQuery();
        }
        public DataTable loginUser(string username, string password)
        {
            return p.loginUser(username, password);
        }

        // BUS_User.cs
        public bool CheckLogin(string username, string password)
        {
            if (p == null)
                p = new DAL_User();
            return p.CheckLogin(username, password);
        }

        // BUS_User.cs

        public BUS_User()
        {
            p = new DAL_User(); // DAL_User cũng cần có constructor mặc định
        }
        public void ChangePassword(string username, string newPassword)
        {
            if (p == null)
                p = new DAL_User();
            p.UpdatePassword(username, newPassword);
        }

        // Phương thức lấy thông tin người dùng theo username
        public DataTable GetUserInfoByUsername(string username)
        {
            if (p == null)
                p = new DAL_User();
            
            return p.GetUserInfoByUsername(username);
        }

        

        public static int GetEmployeeCount() => DAL_User.GetEmployeeCount();

    }
}
