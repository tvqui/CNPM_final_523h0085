using System;
using System.Windows.Forms;
using BUS;

namespace GUI
{
    public partial class frm_ChangePassword : Form
    {
        private readonly string _username;

        public frm_ChangePassword(string username)
        {
            InitializeComponent();
            _username = username;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string currentPassword = txtCurrentP.Text.Trim();
            string newPassword = txtNewP.Text.Trim();
            string confirmPassword = txtConfirmP.Text.Trim();

            if (string.IsNullOrEmpty(currentPassword) || string.IsNullOrEmpty(newPassword) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Vui lòng điền đầy đủ các trường!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("Mật khẩu mới và xác nhận mật khẩu không khớp!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                bool isStaff = _username.StartsWith("nvbn");
                bool isPasswordCorrect;

                if (isStaff)
                {
                    BUS_User busUser = new BUS_User();
                    isPasswordCorrect = busUser.CheckLogin(_username, currentPassword);
                    if (!isPasswordCorrect)
                    {
                        MessageBox.Show("Mật khẩu hiện tại không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    busUser.ChangePassword(_username, newPassword);
                }
                else
                {
                    BUS_Customer busCustomer = new BUS_Customer();
                    isPasswordCorrect = busCustomer.CheckLogin(_username, currentPassword);
                    if (!isPasswordCorrect)
                    {
                        MessageBox.Show("Mật khẩu hiện tại không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    busCustomer.ChangePassword(_username, newPassword);
                }

                MessageBox.Show("Đổi mật khẩu thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi đổi mật khẩu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}


    

    
