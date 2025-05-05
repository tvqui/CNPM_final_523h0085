using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using Microsoft.Data.SqlClient;

namespace DAL
{
    public class DAL_Orders
    {
        DTO_Orders o;
        public DAL_Orders() { }

        public DAL_Orders(DTO_Orders order)
        {
            o = order;
        }

        public void addQuery()
        {
            string query = $"INSERT INTO orders VALUES ('{o.OrderID}', '{o.Username}', GETDATE(), '{o.ProductID}', N'{o.PName}', N'{o.Brand}', N'{o.Color}', {o.Quantity}, {o.UnitPrice}, N'{o.ImagePath}', N'{o.PStatus}')";
            Connection.ActionQuery(query);
        }

        public void updateQuery()
        {
            string query = $"UPDATE orders SET Username = '{o.Username}', ProductID = '{o.ProductID}', PName = N'{o.PName}', Brand = N'{o.Brand}', Color = N'{o.Color}', Quantity = {o.Quantity}, UnitPrice = {o.UnitPrice}, ImagePath = N'{o.ImagePath}', PStatus = N'{o.PStatus}' WHERE OrderID = '{o.OrderID}'";
            Connection.ActionQuery(query);
        }

        public void deleteQuery()
        {
            string query = $"DELETE FROM orders WHERE order_id = '{o.OrderID}'";
            Connection.ActionQuery(query);
        }

        public DataTable selectQuery()
        {
            string query = "SELECT * FROM orders";
            return Connection.SelectQuery(query);
        }

        public static bool IsProductInCart(string productId, string username)
        {
            string sql = $"SELECT * FROM orders WHERE product_id = '{productId}' AND username = '{username}' AND p_status = N'Chưa thanh toán'";
            return Connection.HasRows(sql);
        }

        public static void IncreaseQuantity(string productId, string username)
        {
            string sql = $"UPDATE orders SET quantity = quantity + 1 WHERE product_id = '{productId}' AND username = '{username}' AND p_status = N'Chưa thanh toán'";
            Connection.ActionQuery(sql);
        }

        public static void DecreaseQuantity(string productId, string username)
        {
            string sql = $"UPDATE orders SET quantity = quantity - 1 WHERE product_id = '{productId}' AND username = '{username}' AND p_status = N'Chưa thanh toán'";
            Connection.ActionQuery(sql);
        }

        public static void DeleteIfZero(string productId, string username)
        {
            string sql = $"DELETE FROM orders WHERE quantity <= 0 AND product_id = '{productId}' AND username = '{username}' AND p_status = N'Chưa thanh toán'";
            Connection.ActionQuery(sql);
        }

        public static void SetAllToPaid(string username)
        {
            string sql = $"UPDATE orders SET p_status = N'Đã mua' WHERE username = '{username}' AND p_status = N'Chưa thanh toán'";
            Connection.ActionQuery(sql);
        }

        public static DataTable GetCartByUsername(string username)
        {
            string sql = $"SELECT * FROM orders WHERE username = '{username}' AND p_status = N'Chưa thanh toán'";
            return Connection.SelectQuery(sql);
        }

        public static void InsertOrder(DTO_Orders order)
        {
            string query = $"INSERT INTO orders (OrderID, Username, OrderDate, ProductID, PName, Brand, Color, Quantity, UnitPrice, ImagePath, PStatus) VALUES ('{order.OrderID}', '{order.Username}', '{order.OrderDate:yyyy-MM-dd HH:mm:ss}', '{order.ProductID}', N'{order.PName}', N'{order.Brand}', N'{order.Color}', {order.Quantity}, {order.UnitPrice}, N'{order.ImagePath}', N'{order.PStatus}')";
            Connection.ActionQuery(query);
        }

        public static DataTable GetPurchasedOrdersByUsername(string username)
        {
            string sql = $"SELECT * FROM orders WHERE Username = '{username}' AND PStatus = N'Bought'";
            return Connection.SelectQuery(sql);
        }

        public static int GetOrderCount()
        {
            string query = "SELECT COUNT(*) FROM orders";
 
            var table = Connection.SelectQuery(query);
            return Convert.ToInt32(table.Rows[0][0]);
        }
        public static DataTable GetAllPurchasedOrders()
        {
            string sql = "SELECT * FROM orders WHERE PStatus = 'Bought'";
            return Connection.SelectQuery(sql);
        }
    }
}