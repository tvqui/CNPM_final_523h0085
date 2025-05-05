namespace GUI
{
    partial class frm_Signup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            SignIn = new LinkLabel();
            label5 = new Label();
            txtEmail = new TextBox();
            label4 = new Label();
            btnSignUp = new Button();
            txtCPassword = new TextBox();
            txtPassword = new TextBox();
            txtUserName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            btnAvata = new Guna.UI2.WinForms.Guna2Button();
            txtPhonenumber = new TextBox();
            label9 = new Label();
            guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            txtLastname = new TextBox();
            label8 = new Label();
            txtFirstname = new TextBox();
            label7 = new Label();
            ShowCP = new CheckBox();
            ShowP = new CheckBox();
            label6 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            avata_Customer = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            panel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)avata_Customer).BeginInit();
            SuspendLayout();
            // 
            // SignIn
            // 
            SignIn.AutoSize = true;
            SignIn.Location = new Point(381, 629);
            SignIn.Margin = new Padding(2, 0, 2, 0);
            SignIn.Name = "SignIn";
            SignIn.Size = new Size(85, 20);
            SignIn.TabIndex = 13;
            SignIn.TabStop = true;
            SignIn.Text = "sign in here";
            SignIn.LinkClicked += SignIn_LinkClicked;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(228, 629);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(149, 20);
            label5.TabIndex = 12;
            label5.Text = "already have account";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(40, 169);
            txtEmail.Margin = new Padding(2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(397, 27);
            txtEmail.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(40, 147);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(47, 20);
            label4.TabIndex = 7;
            label4.Text = "Email";
            // 
            // btnSignUp
            // 
            btnSignUp.BackgroundImageLayout = ImageLayout.Stretch;
            btnSignUp.FlatStyle = FlatStyle.Flat;
            btnSignUp.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSignUp.Location = new Point(281, 549);
            btnSignUp.Margin = new Padding(2);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(138, 55);
            btnSignUp.TabIndex = 11;
            btnSignUp.Text = "SIGN UP";
            btnSignUp.UseVisualStyleBackColor = true;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // txtCPassword
            // 
            txtCPassword.Location = new Point(42, 479);
            txtCPassword.Margin = new Padding(2);
            txtCPassword.Name = "txtCPassword";
            txtCPassword.PasswordChar = '*';
            txtCPassword.Size = new Size(397, 27);
            txtCPassword.TabIndex = 6;
            txtCPassword.UseSystemPasswordChar = true;
            txtCPassword.KeyUp += txtCPassword_KeyUp;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(42, 388);
            txtPassword.Margin = new Padding(2);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(397, 27);
            txtPassword.TabIndex = 5;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(42, 323);
            txtUserName.Margin = new Padding(2);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(397, 27);
            txtUserName.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(42, 457);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(137, 20);
            label3.TabIndex = 3;
            label3.Text = "Confirm Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(42, 366);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(42, 301);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 1;
            label1.Text = "Username";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Wheat;
            panel2.Controls.Add(btnAvata);
            panel2.Controls.Add(txtPhonenumber);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(guna2ControlBox1);
            panel2.Controls.Add(txtLastname);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(txtFirstname);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(ShowCP);
            panel2.Controls.Add(ShowP);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(SignIn);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(txtEmail);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(btnSignUp);
            panel2.Controls.Add(txtCPassword);
            panel2.Controls.Add(txtPassword);
            panel2.Controls.Add(txtUserName);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(387, 2);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(491, 676);
            panel2.TabIndex = 3;
            // 
            // btnAvata
            // 
            btnAvata.BorderRadius = 5;
            btnAvata.CustomizableEdges = customizableEdges1;
            btnAvata.DisabledState.BorderColor = Color.DarkGray;
            btnAvata.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAvata.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAvata.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAvata.Font = new Font("Segoe UI", 9F);
            btnAvata.ForeColor = Color.White;
            btnAvata.Location = new Point(41, 566);
            btnAvata.Name = "btnAvata";
            btnAvata.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnAvata.Size = new Size(131, 38);
            btnAvata.TabIndex = 7;
            btnAvata.Text = "Import Avata";
            btnAvata.Click += btnAvata_Click;
            // 
            // txtPhonenumber
            // 
            txtPhonenumber.Location = new Point(40, 243);
            txtPhonenumber.Margin = new Padding(2);
            txtPhonenumber.Name = "txtPhonenumber";
            txtPhonenumber.Size = new Size(397, 27);
            txtPhonenumber.TabIndex = 3;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(40, 221);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(115, 20);
            label9.TabIndex = 20;
            label9.Text = "Phone Number";
            // 
            // guna2ControlBox1
            // 
            guna2ControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2ControlBox1.BorderColor = Color.DimGray;
            guna2ControlBox1.BorderRadius = 2;
            guna2ControlBox1.CustomizableEdges = customizableEdges3;
            guna2ControlBox1.FillColor = Color.Firebrick;
            guna2ControlBox1.ForeColor = Color.Black;
            guna2ControlBox1.IconColor = Color.White;
            guna2ControlBox1.Location = new Point(448, 3);
            guna2ControlBox1.Name = "guna2ControlBox1";
            guna2ControlBox1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2ControlBox1.Size = new Size(40, 24);
            guna2ControlBox1.TabIndex = 5;
            // 
            // txtLastname
            // 
            txtLastname.Location = new Point(246, 105);
            txtLastname.Margin = new Padding(2);
            txtLastname.Name = "txtLastname";
            txtLastname.Size = new Size(193, 27);
            txtLastname.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(252, 83);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(81, 20);
            label8.TabIndex = 18;
            label8.Text = "Last name";
            // 
            // txtFirstname
            // 
            txtFirstname.Location = new Point(42, 105);
            txtFirstname.Margin = new Padding(2);
            txtFirstname.Name = "txtFirstname";
            txtFirstname.Size = new Size(193, 27);
            txtFirstname.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(48, 83);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(83, 20);
            label7.TabIndex = 16;
            label7.Text = "First name";
            // 
            // ShowCP
            // 
            ShowCP.AutoSize = true;
            ShowCP.Location = new Point(40, 510);
            ShowCP.Margin = new Padding(2);
            ShowCP.Name = "ShowCP";
            ShowCP.Size = new Size(132, 24);
            ShowCP.TabIndex = 15;
            ShowCP.Text = "Show Password";
            ShowCP.UseVisualStyleBackColor = true;
            ShowCP.CheckedChanged += ShowCP_CheckedChanged;
            // 
            // ShowP
            // 
            ShowP.AutoSize = true;
            ShowP.Location = new Point(42, 419);
            ShowP.Margin = new Padding(2);
            ShowP.Name = "ShowP";
            ShowP.Size = new Size(132, 24);
            ShowP.TabIndex = 14;
            ShowP.Text = "Show Password";
            ShowP.UseVisualStyleBackColor = true;
            ShowP.CheckedChanged += ShowP_CheckedChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(0, 0, 192);
            label6.Location = new Point(48, 31);
            label6.Name = "label6";
            label6.Size = new Size(309, 35);
            label6.TabIndex = 4;
            label6.Text = "CREATE AN ACCOUNT";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = SystemColors.ActiveCaption;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 495F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel2, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(880, 680);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(215, 204, 210);
            panel1.BackgroundImage = Properties.Resources.e81f678d16aa664e01cde4c2f5f97453;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(avata_Customer);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(379, 674);
            panel1.TabIndex = 23;
            // 
            // avata_Customer
            // 
            avata_Customer.Anchor = AnchorStyles.None;
            avata_Customer.ImageRotate = 0F;
            avata_Customer.Location = new Point(77, -1);
            avata_Customer.Name = "avata_Customer";
            avata_Customer.ShadowDecoration.CustomizableEdges = customizableEdges5;
            avata_Customer.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            avata_Customer.Size = new Size(192, 185);
            avata_Customer.TabIndex = 4;
            avata_Customer.TabStop = false;
            // 
            // frm_Signup
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(880, 680);
            ControlBox = false;
            Controls.Add(tableLayoutPanel1);
            Name = "frm_Signup";
            Text = "frm_Signup";
            Load += frm_Signup_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)avata_Customer).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private LinkLabel SignIn;
        private Label label5;
        private TextBox txtEmail;
        private Label label4;
        private Button btnSignUp;
        private TextBox txtCPassword;
        private TextBox txtPassword;
        private TextBox txtUserName;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Label label6;
        private CheckBox ShowCP;
        private CheckBox ShowP;
        private TextBox txtLastname;
        private Label label8;
        private TextBox txtFirstname;
        private Label label7;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox txtPhonenumber;
        private Label label9;
        private Guna.UI2.WinForms.Guna2CirclePictureBox avata_Customer;
        private Guna.UI2.WinForms.Guna2Button btnAvata;
        private Panel panel1;
    }
}