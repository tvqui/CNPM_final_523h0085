using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CNPM_final;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace GUI
{
    public partial class frm_Role : Form
    {
        private string _username;

        public frm_Role(string username)
        {
            InitializeComponent();
            this._username = username;
        }
        public frm_Role()
        {
            InitializeComponent();
            
        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome " + _username);
            frmUser_main main = new frmUser_main(_username);
            main.Show();
            this.Hide();

            main.FormClosed += (s, args) => this.Close();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome " + _username);
            frm_Admin admin = new frm_Admin(_username);
            admin.Show();
            this.Hide();

            admin.FormClosed += (s, args) => this.Close();
        }
    }
}
