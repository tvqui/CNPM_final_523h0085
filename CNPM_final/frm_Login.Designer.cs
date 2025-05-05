namespace GUI
{
    partial class frm_Login
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Login));
            guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            hidePass = new Button();
            button6 = new Button();
            button5 = new Button();
            btnRegiter = new Button();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            btnSignIn = new Button();
            showPass = new Button();
            txtPassword = new TextBox();
            txtUserName = new TextBox();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // guna2ControlBox1
            // 
            guna2ControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2ControlBox1.BorderColor = Color.DimGray;
            guna2ControlBox1.BorderRadius = 2;
            guna2ControlBox1.CustomizableEdges = customizableEdges5;
            guna2ControlBox1.FillColor = Color.Firebrick;
            guna2ControlBox1.ForeColor = Color.Black;
            guna2ControlBox1.IconColor = Color.White;
            guna2ControlBox1.Location = new Point(623, 1);
            guna2ControlBox1.Name = "guna2ControlBox1";
            guna2ControlBox1.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2ControlBox1.Size = new Size(56, 24);
            guna2ControlBox1.TabIndex = 4;
            // 
            // hidePass
            // 
            hidePass.BackColor = Color.Transparent;
            hidePass.BackgroundImage = (Image)resources.GetObject("hidePass.BackgroundImage");
            hidePass.BackgroundImageLayout = ImageLayout.Zoom;
            hidePass.FlatStyle = FlatStyle.Flat;
            hidePass.Location = new Point(272, 179);
            hidePass.Margin = new Padding(2);
            hidePass.Name = "hidePass";
            hidePass.Size = new Size(23, 37);
            hidePass.TabIndex = 8;
            hidePass.UseVisualStyleBackColor = false;
            hidePass.Click += hidePass_Click;
            // 
            // button6
            // 
            button6.BackgroundImage = (Image)resources.GetObject("button6.BackgroundImage");
            button6.BackgroundImageLayout = ImageLayout.Zoom;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button6.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Location = new Point(140, 12);
            button6.Margin = new Padding(2);
            button6.Name = "button6";
            button6.Size = new Size(56, 67);
            button6.TabIndex = 11;
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Transparent;
            button5.BackgroundImageLayout = ImageLayout.Stretch;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button5.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.Blue;
            button5.Location = new Point(108, 73);
            button5.Margin = new Padding(2);
            button5.Name = "button5";
            button5.Size = new Size(118, 48);
            button5.TabIndex = 10;
            button5.Text = "LOGIN";
            button5.UseVisualStyleBackColor = false;
            // 
            // btnRegiter
            // 
            btnRegiter.AutoSize = true;
            btnRegiter.BackColor = Color.Transparent;
            btnRegiter.BackgroundImageLayout = ImageLayout.Stretch;
            btnRegiter.FlatAppearance.BorderSize = 0;
            btnRegiter.FlatAppearance.MouseDownBackColor = Color.DarkOrange;
            btnRegiter.FlatAppearance.MouseOverBackColor = Color.LightSalmon;
            btnRegiter.FlatStyle = FlatStyle.Flat;
            btnRegiter.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegiter.ForeColor = Color.DarkTurquoise;
            btnRegiter.Location = new Point(78, 283);
            btnRegiter.Margin = new Padding(2);
            btnRegiter.Name = "btnRegiter";
            btnRegiter.Size = new Size(190, 48);
            btnRegiter.TabIndex = 9;
            btnRegiter.Text = "Regiter";
            btnRegiter.UseVisualStyleBackColor = false;
            btnRegiter.Click += btnRegiter_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.Location = new Point(30, 185);
            pictureBox3.Margin = new Padding(2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(25, 32);
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Location = new Point(30, 125);
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(25, 35);
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // btnSignIn
            // 
            btnSignIn.AutoSize = true;
            btnSignIn.BackColor = Color.Transparent;
            btnSignIn.BackgroundImageLayout = ImageLayout.Stretch;
            btnSignIn.FlatAppearance.BorderSize = 0;
            btnSignIn.FlatAppearance.MouseDownBackColor = Color.DarkOrange;
            btnSignIn.FlatAppearance.MouseOverBackColor = Color.LightSalmon;
            btnSignIn.FlatStyle = FlatStyle.Flat;
            btnSignIn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSignIn.ForeColor = Color.DarkTurquoise;
            btnSignIn.Location = new Point(78, 228);
            btnSignIn.Margin = new Padding(2);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(190, 51);
            btnSignIn.TabIndex = 1;
            btnSignIn.Text = "Sign in";
            btnSignIn.UseVisualStyleBackColor = false;
            btnSignIn.Click += btnSignIn_Click;
            // 
            // showPass
            // 
            showPass.BackgroundImage = (Image)resources.GetObject("showPass.BackgroundImage");
            showPass.BackgroundImageLayout = ImageLayout.Zoom;
            showPass.FlatStyle = FlatStyle.Flat;
            showPass.Location = new Point(299, 180);
            showPass.Margin = new Padding(2);
            showPass.Name = "showPass";
            showPass.Size = new Size(20, 36);
            showPass.TabIndex = 7;
            showPass.UseVisualStyleBackColor = true;
            showPass.Click += showPass_Click;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(255, 224, 192);
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Cursor = Cursors.IBeam;
            txtPassword.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(59, 181);
            txtPassword.Margin = new Padding(2);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(260, 36);
            txtPassword.TabIndex = 6;
            txtPassword.KeyUp += txtPassword_KeyUp;
            // 
            // txtUserName
            // 
            txtUserName.BackColor = Color.FromArgb(255, 224, 192);
            txtUserName.BorderStyle = BorderStyle.None;
            txtUserName.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUserName.Location = new Point(59, 125);
            txtUserName.Margin = new Padding(2);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(260, 36);
            txtUserName.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(hidePass);
            panel2.Controls.Add(showPass);
            panel2.Controls.Add(button6);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(btnRegiter);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(btnSignIn);
            panel2.Controls.Add(txtPassword);
            panel2.Controls.Add(txtUserName);
            panel2.Location = new Point(163, 23);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(321, 426);
            panel2.TabIndex = 3;
            // 
            // frm_Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.login;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(679, 511);
            ControlBox = false;
            Controls.Add(guna2ControlBox1);
            Controls.Add(panel2);
            Name = "frm_Login";
            Text = "frm_Login";
            Load += frm_Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button hidePass;
        private Button button6;
        private Button button5;
        private Button btnRegiter;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Button btnSignIn;
        private Button showPass;
        private TextBox txtPassword;
        private TextBox txtUserName;
        private Panel panel2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
    }
}