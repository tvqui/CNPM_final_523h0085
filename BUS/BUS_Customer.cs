using DAL;
using System.Data;
using DAL;
using DTO;
using Microsoft.Data.SqlClient;
namespace BUS
{
    public class BUS_Customer
    {
        DAL_Customer p;

        public BUS_Customer()
        {
           
        }
        public BUS_Customer(string id, string fname, string lname, string uname, string password, string phone, string email, string avatar)
        {
            p = new DAL_Customer(id, fname, lname, uname, password, phone, email, avatar);
        }

        public BUS_Customer(DTO_Customer customer)
        {
            p = new DAL_Customer(customer.CustomerID, customer.FirstName, customer.LastName,
                                 customer.CustomerUsername, customer.CustomerPassword,
                                 customer.Phone, customer.Email, customer.AvatarPath);
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

        public DataTable loginCustomer(string username, string password)
        {
            return p.loginCustomer(username, password);
        }

        public void Register()
        {
            p.Register();
        }

        public bool CheckUsernameExists()
        {
            return p.CheckUsernameExists();
        }

        public DataTable SelectCustomersByDate(string date)
        {
            // Nếu p chưa có thì tạo mới tạm thời (vì SelectCustomersByDate không cần DTO_Customer cụ thể)
            if (p == null)
                p = new DAL_Customer();

            return p.SelectCustomersByDate(date);
        }

        // BUS_Customer.cs
        public bool CheckLogin(string username, string password)
        {
            if (p == null)
                p = new DAL_Customer();
            DataTable dt = p.loginCustomer(username, password);
            return dt.Rows.Count > 0;
        }

        // BUS_Customer.cs





        // Phương thức lấy thông tin người dùng theo username
        public DataTable GetUserInfoByUsername(string username)
        {
            if (p == null)
                p = new DAL_Customer();

            return p.GetUserInfoByUsername(username);
        }

        public void ChangePassword(string username, string newPassword)
        {
            if (p == null)
                p = new DAL_Customer();
            p.UpdatePassword(username, newPassword);
        }



        public static int GetCustomerCount() => DAL_Customer.GetCustomerCount();

    }
}
