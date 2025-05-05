using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DAL.DAL_Products;
using DTO;
using Microsoft.Data.SqlClient;
namespace DAL
{
    public class DAL_Products
    {

        DTO_Products p;
        public DAL_Products() { }

        public DAL_Products(DTO_Products product)
        {
            p = product;
        }

        public void addQuery()
        {
            string query = $"INSERT INTO products VALUES ('{p.ProductID}', N'{p.PName}', N'{p.Brand}', N'{p.Color}', N'{p.Type}', {p.Price}, {p.StockQuantity}, '{p.ImagePath}', GETDATE(), GETDATE())";
            Connection.ActionQuery(query);
        }

        public void updateQuery()
        {
            string query = $"UPDATE products SET p_name = N'{p.PName}', brand = N'{p.Brand}', color = N'{p.Color}', type = N'{p.Type}', price = {p.Price}, stock_quantity = {p.StockQuantity}, image_path = '{p.ImagePath}', updated_at = GETDATE() WHERE product_id = '{p.ProductID}'";
            Connection.ActionQuery(query);
        }

        public void deleteQuery()
        {
            string query = $"DELETE FROM products WHERE product_id = '{p.ProductID}'";
            Connection.ActionQuery(query);
        }

        public DataTable selectQuery()
        {
            string query = "SELECT * FROM products";
            return Connection.SelectQuery(query);
        }

        public static DataTable GetProductsBySport(string sport)
        {
            string query = $"SELECT * FROM products WHERE type = N'{sport}'";
            return Connection.SelectQuery(query);
        }

        public static DataTable GetAllProducts()
        {
            string sql = "SELECT product_id, p_name, brand, color, price, image_path, type FROM products";
            return Connection.SelectQuery(sql);
        }

    }



}
