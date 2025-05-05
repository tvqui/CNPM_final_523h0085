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
using DTO;

namespace GUI
{
    public partial class frm_Signup : Form
    {
        public frm_Signup()
        {
            InitializeComponent();
        }

        private void frm_Signup_Load(object sender, EventArgs e)
        {

        }

        private void SignIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_Login login = new frm_Login();
            login.Show();
            this.Hide();

            login.FormClosed += (s, args) => this.Close();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstname.Text.Trim();
            string lastName = txtLastname.Text.Trim();
            string username = txtUserName.Text.Trim();
            string password = txtPassword.Text.Trim();
            string phone = txtPhonenumber.Text.Trim();
            string email = txtEmail.Text.Trim();
            string avatar = btnAvata.Tag != null ? btnAvata.Tag.ToString() : "";

            // Validate cơ bản  
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) ||
                string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill in all required fields!");
                return;
            }

            // Tạo mã customer_id tự động  
            string customerID = GenerateCustomerID();
            MessageBox.Show(customerID); // Tạo mã khách hàng mới
            // Pass all required parameters to the constructor  
            BUS_Customer busCustomer = new BUS_Customer(customerID, firstName, lastName, username, password, phone, email, avatar);

            // Kiểm tra username đã tồn tại chưa  
            if (busCustomer.CheckUsernameExists())
            {
                MessageBox.Show("Username already exists. Please choose another one!");
                return;
            }

            // Đăng ký tài khoản  
            busCustomer.Register();

            MessageBox.Show("Register successful! Please login now.");

            // Chuyển về form Login  
            frm_Login login = new frm_Login();
            login.Show();
            this.Hide();
        }

        private string GenerateCustomerID()
        {
            string prefix = "cus";
            string today = DateTime.Now.ToString("yyyyMMdd");

            // Lấy tất cả khách hàng đăng ký hôm nay để đếm số lượng
            BUS_Customer busCustomer = new BUS_Customer();
            DataTable dt = busCustomer.SelectCustomersByDate(today);

            int nextNumber = dt.Rows.Count + 1; // Nếu có 5 người đăng ký rồi thì số tiếp theo là 6
            string formattedNumber = nextNumber.ToString("D4"); // Định dạng thành 4 chữ số (0001, 0002,...)

            return prefix + today + formattedNumber;
        }

        private void btnAvata_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select Avatar Image";
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedPath = openFileDialog.FileName;

                // Hiển thị hình ảnh vào PictureBox (nếu có)
                avata_Customer.Image = Image.FromFile(selectedPath);
                avata_Customer.SizeMode = PictureBoxSizeMode.StretchImage;

                // Lưu đường dẫn file vào Tag của nút Avatar
                btnAvata.Tag = selectedPath;
            }
        }

        private void ShowP_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowP.Checked)
            {
                // Hiện mật khẩu
                txtPassword.UseSystemPasswordChar = false;
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                // Ẩn mật khẩu
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void ShowCP_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowCP.Checked)
            {
                // Hiện mật khẩu
                txtCPassword.UseSystemPasswordChar = false;
                txtCPassword.PasswordChar = '\0';
            }
            else
            {
                // Ẩn mật khẩu
                txtCPassword.UseSystemPasswordChar = true;
            }
        }

        private void txtCPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Tự động nhấn nút Đăng ký khi nhấn Enter
                btnSignUp.PerformClick();
            }
        }
    }
}
