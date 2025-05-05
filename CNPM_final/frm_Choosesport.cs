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

namespace GUI
{
    public partial class frm_Choosesport : Form
    {

        private frmUser_main _mainForm;
        private string _username;

        public frm_Choosesport(frmUser_main mainForm, string username)
        {
            InitializeComponent();
            this._mainForm = mainForm;
            this._username = username;

        }
        public frm_Choosesport(string username)
        {
            InitializeComponent();
            this._username = username;
        }
        public frm_Choosesport()
        {
            InitializeComponent();
        }
        //"Football", "Basketball", "Martial Arts", "Badminton", "Tennis", "Golf", "Swimming", "Gym & Fitness", "Running"
        private void btnSoccer_Click(object sender, EventArgs e)
        {
            if (_mainForm != null)
            {
                _mainForm.LoadForm(new frm_Search(_mainForm, _username, "Football"));
            }
            else
            {
                MessageBox.Show("Main form is not initialized.");
            }

        }

        private void btnBasketball_Click(object sender, EventArgs e)
        {
            if (_mainForm != null)
            {
                _mainForm.LoadForm(new frm_Search(_mainForm, _username, "Basketball"));
            }
            else
            {
                MessageBox.Show("Main form is not initialized.");
            }
        }

        private void btnMA_Click(object sender, EventArgs e)
        {
            if (_mainForm != null)
            {
                _mainForm.LoadForm(new frm_Search(_mainForm, _username, "Martial Arts"));
            }
            else
            {
                MessageBox.Show("Main form is not initialized.");
            }
        }

        private void btnBMT_Click(object sender, EventArgs e)
        {
            if (_mainForm != null)
            {
                _mainForm.LoadForm(new frm_Search(_mainForm, _username, "Badminton"));
            }
            else
            {
                MessageBox.Show("Main form is not initialized.");
            }
        }

        private void btnTN_Click(object sender, EventArgs e)
        {
            if (_mainForm != null)
            {
                _mainForm.LoadForm(new frm_Search(_mainForm, _username, "Tennis"));
            }
            else
            {
                MessageBox.Show("Main form is not initialized.");
            }
        }

        private void btnGF_Click(object sender, EventArgs e)
        {
            if (_mainForm != null)
            {
                _mainForm.LoadForm(new frm_Search(_mainForm, _username, "Golf"));
            }
            else
            {
                MessageBox.Show("Main form is not initialized.");
            }
        }

        private void btnSwim_Click(object sender, EventArgs e)
        {
            if (_mainForm != null)
            {
                _mainForm.LoadForm(new frm_Search(_mainForm, _username, "Swimming"));
            }
            else
            {
                MessageBox.Show("Main form is not initialized.");
            }
        }

        private void btnGyF_Click(object sender, EventArgs e)
        {
            if (_mainForm != null)
            {
                _mainForm.LoadForm(new frm_Search(_mainForm, _username, "Gym & Fitness"));
            }
            else
            {
                MessageBox.Show("Main form is not initialized.");
            }
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            if (_mainForm != null)
            {
                _mainForm.LoadForm(new frm_Search(_mainForm, _username, "Running"));
            }
            else
            {
                MessageBox.Show("Main form is not initialized.");
            }
        }
    }
}
