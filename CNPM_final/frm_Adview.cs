using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace GUI
{
    public partial class frm_Adview : Form
    {
        public frm_Adview()
        {
            InitializeComponent();
        }

        private void frm_Adview_Load(object sender, EventArgs e)
        {
            try
            {
                labelOrders.Text = BUS_Orders.GetOrderCount().ToString();
                labelEmployees.Text = BUS_User.GetEmployeeCount().ToString();
                labelCustomers.Text = BUS_Customer.GetCustomerCount().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
