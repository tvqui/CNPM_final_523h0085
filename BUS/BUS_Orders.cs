using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using Microsoft.Data.SqlClient;

namespace BUS
{
    public class BUS_Orders
    {
        DAL_Orders o;
        public BUS_Orders() { }

        public BUS_Orders(DTO_Orders order)
        {
            o = new DAL_Orders(order);
        }

        public void addQuery()
        {
            o.addQuery();
        }

        public void updateQuery()
        {
            o.updateQuery();
        }

        public void deleteQuery()
        {
            o.deleteQuery();
        }

        public DataTable selectQuery()
        {
            return o.selectQuery();
        }

        public static void InsertOrder(DTO_Orders order)
        {
            DAL_Orders.InsertOrder(order);
        }

        public static bool IsProductInCart(string productId, string username)
        {
            return DAL_Orders.IsProductInCart(productId, username);
        }

        public static void IncreaseQuantity(string productId, string username)
        {
            DAL_Orders.IncreaseQuantity(productId, username);
        }

        public static void DecreaseQuantity(string productId, string username)
        {
            DAL_Orders.DecreaseQuantity(productId, username);
        }

        public static void DeleteIfZero(string productId, string username)
        {
            DAL_Orders.DeleteIfZero(productId, username);
        }

        public static void SetAllToPaid(string username)
        {
            DAL_Orders.SetAllToPaid(username);
        }

        public static DataTable GetCartByUsername(string username)
        {
            return DAL_Orders.GetCartByUsername(username);
        }


        public static DataTable GetPurchasedOrdersByUsername(string username)
        {
            return DAL_Orders.GetPurchasedOrdersByUsername(username);
        }

        public static int GetOrderCount() => DAL_Orders.GetOrderCount();

        public static DataTable GetAllPurchasedOrders()
        {

            return DAL_Orders.GetAllPurchasedOrders();
        }

    }
}
