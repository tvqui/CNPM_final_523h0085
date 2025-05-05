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
    public partial class frm_Admin : Form
    {

        private string _username; // Đặt tên đúng như dùng trong hàm

        public frm_Admin(string username)
        {
            InitializeComponent();
            this._username = username;

        }
        public frm_Admin()
        {
            InitializeComponent();

        }

        private void labelCustomers_Click(object sender, EventArgs e)
        {

        }

        private void btnCashier_Click(object sender, EventArgs e)
        {
            LoadForm(new frm_Cashier(_username));
        }

        private void LoadUserInfo()
        {
            if (string.IsNullOrEmpty(_username))
            {
                MessageBox.Show("Tên người dùng không hợp lệ.");
                return;
            }

            BUS_User busUser = new BUS_User();
            DataTable userInfo = busUser.GetUserInfoByUsername(_username);

            if (userInfo == null)
            {
                MessageBox.Show("Không thể lấy thông tin người dùng từ cơ sở dữ liệu.");
                return;
            }

            if (userInfo.Rows.Count > 0)
            {
                labelName.Text = userInfo.Rows[0]["username"]?.ToString() ?? "Không rõ tên";

                string avatarPath = userInfo.Rows[0]["avatar_path"]?.ToString();

                if (!string.IsNullOrEmpty(avatarPath) && File.Exists(avatarPath))
                {
                    Avata.Image = Image.FromFile(avatarPath);
                    Avata.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else
                {
                    // Gán ảnh mặc định nếu ảnh không tồn tại
                    Avata.Image = Image.FromFile(@"D:\Final\CNPM\CNPM_final\CNPM_final\Resources\user.png");
                    Avata.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy người dùng.");
            }
        }

        private void frm_Admin_Load(object sender, EventArgs e)
        {
            LoadUserInfo();
            MessageBox.Show("Welcome " + _username);
            frm_Adview view = new frm_Adview();
            LoadForm(view);
        }
        public void LoadForm(Form frm)
        {
            layout.Controls.Clear();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            layout.Controls.Add(frm);
            frm.Show();
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            LoadForm(new frm_Adview());
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            LoadForm(new frm_Sales());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frm_Login login = new frm_Login();
            login.Show();
            this.Hide();

            login.FormClosed += (s, args) => this.Close();
        }

        private void btnStockin_Click(object sender, EventArgs e)
        {
            LoadForm(new frm_Stockin());
        }

        private void btnCP_Click(object sender, EventArgs e)
        {
            LoadForm(new frm_ChangePassword(_username));
        }
    }
}
