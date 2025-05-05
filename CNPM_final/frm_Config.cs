using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using DAL;
using Microsoft.Data.SqlClient;

namespace GUI
{
    public partial class frm_Config : Form
    {
        public frm_Config()
        {
            InitializeComponent();
        }

        private void frm_Config_Load(object sender, EventArgs e)
        {
            ckW_CheckedChanged(sender, e);
            LoadConfig();
        }

        private void LoadConfig()
        {
            try
            {
                if (File.Exists("config.txt"))
                {
                    foreach (var line in File.ReadAllLines("config.txt"))
                    {
                        var parts = line.Split(':');
                        if (parts.Length != 2) continue;

                        string key = parts[0].Trim();
                        string value = parts[1].Trim();

                        switch (key)
                        {
                            case "Server": txtserver.Text = value; break;
                            case "Database": txtdb.Text = value; break;
                            case "UserID": txtuid.Text = value; break;
                            case "Password": txtPass.Text = value; break;
                            case "WinAuth":
                                if (bool.TryParse(value, out bool winAuth))
                                    ckW.Checked = winAuth;
                                break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load configuration: {ex.Message}");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string server = txtserver.Text.Trim();
            string database = txtdb.Text.Trim();
            string uid = txtuid.Text.Trim();
            string pass = txtPass.Text.Trim();
            bool winAuth = ckW.Checked;

            if (string.IsNullOrWhiteSpace(server) || string.IsNullOrWhiteSpace(database))
            {
                MessageBox.Show("Server and Database are required.");
                return;
            }

            string[] configLines = winAuth
                ? new[]
                {
                    $"Server:{server}",
                    $"Database:{database}",
                    $"WinAuth:true"
                }
                : new[]
                {
                    $"Server:{server}",
                    $"Database:{database}",
                    $"UserID:{uid}",
                    $"Password:{pass}",
                    $"WinAuth:false"
                };

            if (!winAuth && (string.IsNullOrWhiteSpace(uid) || string.IsNullOrWhiteSpace(pass)))
            {
                MessageBox.Show("User ID and Password are required for SQL Server Authentication.");
                return;
            }

            try
            {
                File.WriteAllLines("config.txt", configLines);

                // Test the connection
                string connectionString = ConfigReader.GetConnectionString();
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    MessageBox.Show("Configuration saved and connection successful!");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to save configuration or connect to database: {ex.Message}");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtserver.Text = "";
            txtdb.Text = "";
            txtuid.Text = "";
            txtPass.Text = "";
            ckW.Checked = false;
        }

        private void ckW_CheckedChanged(object sender, EventArgs e)
        {
            txtuid.Enabled = !ckW.Checked;
            txtPass.Enabled = !ckW.Checked;
        }
    }
}