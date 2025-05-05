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
using CNPM_final;

namespace GUI
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        private void frm_Login_Load(object sender, EventArgs e)
        {

        }

        private void showPass_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '*')
            {
                hidePass.BringToFront();
                txtPassword.PasswordChar = '\0';
            }
        }

        private void hidePass_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '\0')
            {
                showPass.BringToFront();
                txtPassword.PasswordChar = '*';
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter username and password!");
                return;
            }

            if (IsStaff(username))
            {
                // Nhân viên
                BUS_User busUser = new BUS_User("", username, password, "", "", DateTime.Now);

                DataTable dt = busUser.loginUser(username, password);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Login successful (Staff)!");
                    // TODO: mở form dashboard nhân viên
                    frm_Role role = new frm_Role(username);
                    role.Show();
                    this.Hide();

                    role.FormClosed += (s, args) => this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid staff username or password!");
                }
            }
            else
            {
                // Khách hàng
                BUS_Customer busCustomer = new BUS_Customer("", "", "", username, password, "", "", "");

                DataTable dt = busCustomer.loginCustomer(username, password);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Login successful (Customer)!");
                    // TODO: mở form dashboard khách hàng
                    frmUser_main main = new frmUser_main(username);
                    main.Show();
                    this.Hide();

                    main.FormClosed += (s, args) => this.Close();

                }
                else
                {
                    MessageBox.Show("Invalid customer username or password!");
                }
            }
        }

        private bool IsStaff(string username)
        {
            // Kiểm tra nếu username bắt đầu bằng "nvbn" (ví dụ quy ước nhân viên bắt đầu bằng "nvbn")
            if (username.StartsWith("nvbn"))
            {
                // username phải có ít nhất 17 ký tự (vd: nvbnYYYYMMDDxxxx)
                if (username.Length >= 16)
                {
                    string datePart = username.Substring(4, 8);   // lấy từ index 4, 8 ký tự (YYYYMMDD)
                    string numberPart = username.Substring(12, 4); // lấy tiếp 4 ký tự cuối (mã số)

                    // kiểm tra cả datePart và numberPart có phải là số hay không
                    return int.TryParse(datePart, out _) && int.TryParse(numberPart, out _);
                }
            }
            return false; // nếu không đúng định dạng thì không phải nhân viên
        }

        private void btnRegiter_Click(object sender, EventArgs e)
        {
            frm_Signup signup = new frm_Signup();
            signup.Show();
            this.Hide();

            signup.FormClosed += (s, args) => this.Close();
        }

        private void txtPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSignIn.PerformClick();
            }
        }
    }
}
