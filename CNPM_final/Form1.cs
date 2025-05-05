
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Drawing;
using Guna.UI2.WinForms;
using GUI;
using static Guna.UI2.WinForms.Suite.Descriptions;
using System.Data;
using DAL;
using BUS;

namespace CNPM_final
{
    public partial class frmUser_main : Form
    {

        private string _username;

        public frmUser_main(string username)
        {
            InitializeComponent();
            this._username = username;

        }


        public frmUser_main()
        {
            InitializeComponent();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            frm_Login login = new frm_Login();
            login.Show();
            this.Hide();

            login.FormClosed += (s, args) => this.Close();
        }

        private void frmUser_main_Load(object sender, EventArgs e)
        {
            LoadUserInfo();
            frm_Choosesport chooseForm = new frm_Choosesport(this, _username);
            LoadForm(chooseForm);
            //MessageBox.Show(_username);
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

        private void frmUser_main_Resize(object sender, EventArgs e)
        {

        }





        private void LoadUserInfo()
        {
            if (string.IsNullOrEmpty(_username))
            {
                MessageBox.Show("Tên người dùng không hợp lệ.");
                return;
            }

            DataTable userInfo;
            try
            {
                if (_username.Contains("nvbn"))
                {
                    // User is a 'Users' type (e.g., employee)
                    BUS_User busUsers = new BUS_User();
                    userInfo = busUsers.GetUserInfoByUsername(_username);
                    labelName.Text = userInfo.Rows[0]["username"]?.ToString() ?? "Không rõ tên";
                }
                else
                {
                    // User is a 'Customer' type
                    BUS_Customer busCustomer = new BUS_Customer();
                    userInfo = busCustomer.GetUserInfoByUsername(_username);
                    labelName.Text = userInfo.Rows[0]["first_name"]?.ToString() ?? "Không rõ tên";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lấy thông tin người dùng: {ex.Message}");
                return;
            }

            if (userInfo == null)
            {
                MessageBox.Show("Không thể lấy thông tin người dùng từ cơ sở dữ liệu.");
                return;
            }

            if (userInfo.Rows.Count > 0)
            {


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

        private void btnHome_Click(object sender, EventArgs e)
        {


            LoadForm(new frm_Choosesport(_username));
            //var parentForm = this.TopLevelControl as frmUser_main;
            //if (parentForm != null)
            //{
            //    parentForm.LoadForm(new frm_Search(_username, "soccer"));
            //}
        }

        private void btnPH_Click(object sender, EventArgs e)
        {
            LoadForm(new frm_HistoryBuy(_username));
            //MessageBox.Show("asasas",_username);
        }

        private void btnCP_Click(object sender, EventArgs e)
        {
            LoadForm(new frm_ChangePassword(_username));
        }
    }
}
