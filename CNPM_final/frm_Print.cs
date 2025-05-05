using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frm_Print : Form
    {
        private DataTable orderTable;
        private DataTable productTable;
        private string username;

        public frm_Print(DataTable orderTable, DataTable productTable, string username)
        {
            InitializeComponent();
            this.orderTable = orderTable;
            this.productTable = productTable;
            this.username = username;
            Load += frm_Print_Load;
        }
        public frm_Print()
        {
            InitializeComponent();
        }

        private void frm_Print_Load(object sender, EventArgs e)
        {
            PrintInvoice();
        }

        private void PrintInvoice()
        {
            StringBuilder invoiceText = new StringBuilder();
            decimal grandTotal = 0;

            // Tiêu đề
            invoiceText.AppendLine("========== HÓA ĐƠN BÁN HÀNG ==========");
            invoiceText.AppendLine("CỬA HÀNG THỂ THAO TDT");
            invoiceText.AppendLine("Địa chỉ: 123 Đường Thể Thao, Quận 7, TP. HCM");
            invoiceText.AppendLine("Điện thoại: 123456789");
            invoiceText.AppendLine();
            invoiceText.AppendLine($"Khách hàng: {username}");
            invoiceText.AppendLine($"Ngày mua: {DateTime.Now:dd/MM/yyyy HH:mm:ss}");
            invoiceText.AppendLine("--------------------------------------");
            invoiceText.AppendLine("Tên sản phẩm    | Màu sắc | Số lượng | Đơn giá (VND) | Tổng tiền (VND)");
            invoiceText.AppendLine("--------------------------------------");

            // Danh sách sản phẩm
            foreach (DataRow row in orderTable.Rows)
            {
                string name = row["Name"].ToString();
                string color = row["Color"].ToString();
                int quantity = Convert.ToInt32(row["Quantity"]);

                // Lấy đơn giá từ productTable
                DataRow product = productTable.AsEnumerable()
                    .FirstOrDefault(r => r.Field<string>("p_name") == name && r.Field<string>("color") == color);
                decimal unitPrice = product != null ? Convert.ToDecimal(product["price"]) : 0;
                decimal total = unitPrice * quantity;

                grandTotal += total;

                invoiceText.AppendLine($"{name,-15} | {color,-8} | {quantity,-9} | {unitPrice:N0,-12} | {total:N0}");
            }

            invoiceText.AppendLine("--------------------------------------");
            invoiceText.AppendLine($"Tổng cộng: {grandTotal:N0} VND");
            invoiceText.AppendLine("======================================");
            invoiceText.AppendLine("Cảm ơn quý khách đã mua hàng!");

            // Hiển thị hóa đơn trong RichTextBox
            rtbInvoice.Text = invoiceText.ToString();

            // In hóa đơn
            PrintDialog printDialog = new PrintDialog();
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                using (PrintDocument printDocument = new PrintDocument())
                {
                    printDocument.PrintPage += (s, ev) =>
                    {
                        ev.Graphics.DrawString(rtbInvoice.Text, new Font("Arial", 10), Brushes.Black, ev.MarginBounds);
                    };
                    printDocument.Print();
                }
            }

            // Đóng form sau khi in
            Close();
        }
    }
}
