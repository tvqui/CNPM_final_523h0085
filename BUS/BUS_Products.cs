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
    public class BUS_Products
    {
        DAL_Products p;
        public BUS_Products() { }

        public BUS_Products(DTO_Products product)
        {
            p = new DAL_Products(product);
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

        public static DataTable GetProductsBySport(string sport)
        {
            return DAL_Products.GetProductsBySport(sport);
        }

        public static DataTable GetAllProducts()
        {
            return DAL_Products.GetAllProducts();
        }

        

    }
}
