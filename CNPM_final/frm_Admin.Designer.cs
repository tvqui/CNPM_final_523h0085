namespace GUI
{
    partial class frm_Admin
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Admin));
            panelMenu = new Panel();
            btnCashier = new Button();
            panelLogo = new Panel();
            labelRole = new Label();
            Avata = new PictureBox();
            labelName = new Label();
            btnHistory = new Button();
            btnHome = new Button();
            btnStockin = new Button();
            btnLogout = new Button();
            panelTitleBar = new Panel();
            guna2ControlBox5 = new Guna.UI2.WinForms.Guna2ControlBox();
            guna2ControlBox6 = new Guna.UI2.WinForms.Guna2ControlBox();
            guna2ControlBox3 = new Guna.UI2.WinForms.Guna2ControlBox();
            guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            layout = new Panel();
            btnCP = new Button();
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Avata).BeginInit();
            panelTitleBar.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.CadetBlue;
            panelMenu.Controls.Add(btnCP);
            panelMenu.Controls.Add(btnCashier);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Controls.Add(btnHistory);
            panelMenu.Controls.Add(btnHome);
            panelMenu.Controls.Add(btnStockin);
            panelMenu.Controls.Add(btnLogout);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(231, 662);
            panelMenu.TabIndex = 9;
            // 
            // btnCashier
            // 
            btnCashier.FlatAppearance.BorderSize = 0;
            btnCashier.FlatStyle = FlatStyle.Flat;
            btnCashier.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCashier.ForeColor = SystemColors.ButtonHighlight;
            btnCashier.Image = (Image)resources.GetObject("btnCashier.Image");
            btnCashier.ImageAlign = ContentAlignment.MiddleLeft;
            btnCashier.Location = new Point(-3, 191);
            btnCashier.Name = "btnCashier";
            btnCashier.Padding = new Padding(12, 0, 0, 0);
            btnCashier.Size = new Size(228, 73);
            btnCashier.TabIndex = 8;
            btnCashier.Text = "Cashier ";
            btnCashier.TextAlign = ContentAlignment.MiddleLeft;
            btnCashier.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCashier.UseVisualStyleBackColor = true;
            btnCashier.Click += btnCashier_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.SkyBlue;
            panelLogo.Controls.Add(labelRole);
            panelLogo.Controls.Add(Avata);
            panelLogo.Controls.Add(labelName);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(231, 83);
            panelLogo.TabIndex = 7;
            // 
            // labelRole
            // 
            labelRole.AutoSize = true;
            labelRole.Location = new Point(73, 40);
            labelRole.Name = "labelRole";
            labelRole.Size = new Size(53, 20);
            labelRole.TabIndex = 4;
            labelRole.Text = "Admin";
            // 
            // Avata
            // 
            Avata.Image = (Image)resources.GetObject("Avata.Image");
            Avata.Location = new Point(12, 9);
            Avata.Name = "Avata";
            Avata.Size = new Size(51, 51);
            Avata.TabIndex = 2;
            Avata.TabStop = false;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelName.Location = new Point(69, 9);
            labelName.Name = "labelName";
            labelName.Size = new Size(76, 20);
            labelName.TabIndex = 3;
            labelName.Text = "Unknown";
            // 
            // btnHistory
            // 
            btnHistory.FlatAppearance.BorderSize = 0;
            btnHistory.FlatStyle = FlatStyle.Flat;
            btnHistory.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHistory.ForeColor = SystemColors.ButtonHighlight;
            btnHistory.Image = (Image)resources.GetObject("btnHistory.Image");
            btnHistory.ImageAlign = ContentAlignment.MiddleLeft;
            btnHistory.Location = new Point(-3, 349);
            btnHistory.Name = "btnHistory";
            btnHistory.Padding = new Padding(12, 0, 0, 0);
            btnHistory.Size = new Size(228, 73);
            btnHistory.TabIndex = 3;
            btnHistory.Text = "View sales history";
            btnHistory.TextAlign = ContentAlignment.MiddleLeft;
            btnHistory.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnHistory.UseVisualStyleBackColor = true;
            btnHistory.Click += btnHistory_Click;
            // 
            // btnHome
            // 
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHome.ForeColor = SystemColors.ButtonHighlight;
            btnHome.Image = (Image)resources.GetObject("btnHome.Image");
            btnHome.ImageAlign = ContentAlignment.MiddleLeft;
            btnHome.Location = new Point(0, 112);
            btnHome.Name = "btnHome";
            btnHome.Padding = new Padding(12, 0, 0, 0);
            btnHome.Size = new Size(231, 73);
            btnHome.TabIndex = 1;
            btnHome.Text = "Home";
            btnHome.TextAlign = ContentAlignment.MiddleLeft;
            btnHome.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // btnStockin
            // 
            btnStockin.FlatAppearance.BorderSize = 0;
            btnStockin.FlatStyle = FlatStyle.Flat;
            btnStockin.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStockin.ForeColor = SystemColors.ButtonHighlight;
            btnStockin.Image = (Image)resources.GetObject("btnStockin.Image");
            btnStockin.ImageAlign = ContentAlignment.MiddleLeft;
            btnStockin.Location = new Point(-3, 270);
            btnStockin.Name = "btnStockin";
            btnStockin.Padding = new Padding(12, 0, 0, 0);
            btnStockin.Size = new Size(228, 73);
            btnStockin.TabIndex = 2;
            btnStockin.Text = "Stock in";
            btnStockin.TextAlign = ContentAlignment.MiddleLeft;
            btnStockin.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnStockin.UseVisualStyleBackColor = true;
            btnStockin.Click += btnStockin_Click;
            // 
            // btnLogout
            // 
            btnLogout.Dock = DockStyle.Bottom;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = SystemColors.ButtonHighlight;
            btnLogout.Image = (Image)resources.GetObject("btnLogout.Image");
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.Location = new Point(0, 589);
            btnLogout.Name = "btnLogout";
            btnLogout.Padding = new Padding(12, 0, 0, 0);
            btnLogout.Size = new Size(231, 73);
            btnLogout.TabIndex = 6;
            btnLogout.Text = "Logout";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.White;
            panelTitleBar.Controls.Add(guna2ControlBox5);
            panelTitleBar.Controls.Add(guna2ControlBox6);
            panelTitleBar.Controls.Add(guna2ControlBox3);
            panelTitleBar.Controls.Add(guna2ControlBox2);
            panelTitleBar.Controls.Add(guna2ControlBox1);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(231, 0);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(1045, 83);
            panelTitleBar.TabIndex = 10;
            // 
            // guna2ControlBox5
            // 
            guna2ControlBox5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2ControlBox5.BorderRadius = 2;
            guna2ControlBox5.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            guna2ControlBox5.CustomizableEdges = customizableEdges1;
            guna2ControlBox5.FillColor = Color.DodgerBlue;
            guna2ControlBox5.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2ControlBox5.IconColor = Color.White;
            guna2ControlBox5.Location = new Point(938, 0);
            guna2ControlBox5.Name = "guna2ControlBox5";
            guna2ControlBox5.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2ControlBox5.Size = new Size(56, 36);
            guna2ControlBox5.TabIndex = 4;
            // 
            // guna2ControlBox6
            // 
            guna2ControlBox6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2ControlBox6.BorderColor = Color.DimGray;
            guna2ControlBox6.BorderRadius = 2;
            guna2ControlBox6.CustomizableEdges = customizableEdges3;
            guna2ControlBox6.FillColor = Color.Firebrick;
            guna2ControlBox6.ForeColor = Color.Black;
            guna2ControlBox6.IconColor = Color.White;
            guna2ControlBox6.Location = new Point(989, 0);
            guna2ControlBox6.Name = "guna2ControlBox6";
            guna2ControlBox6.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2ControlBox6.Size = new Size(56, 36);
            guna2ControlBox6.TabIndex = 3;
            // 
            // guna2ControlBox3
            // 
            guna2ControlBox3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2ControlBox3.BorderRadius = 2;
            guna2ControlBox3.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            guna2ControlBox3.CustomizableEdges = customizableEdges5;
            guna2ControlBox3.FillColor = Color.DarkSeaGreen;
            guna2ControlBox3.IconColor = Color.White;
            guna2ControlBox3.Location = new Point(1654, 0);
            guna2ControlBox3.Name = "guna2ControlBox3";
            guna2ControlBox3.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2ControlBox3.Size = new Size(56, 36);
            guna2ControlBox3.TabIndex = 2;
            // 
            // guna2ControlBox2
            // 
            guna2ControlBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2ControlBox2.BorderRadius = 2;
            guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            guna2ControlBox2.CustomizableEdges = customizableEdges7;
            guna2ControlBox2.FillColor = Color.DodgerBlue;
            guna2ControlBox2.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2ControlBox2.IconColor = Color.White;
            guna2ControlBox2.Location = new Point(1707, 0);
            guna2ControlBox2.Name = "guna2ControlBox2";
            guna2ControlBox2.ShadowDecoration.CustomizableEdges = customizableEdges8;
            guna2ControlBox2.Size = new Size(56, 36);
            guna2ControlBox2.TabIndex = 1;
            // 
            // guna2ControlBox1
            // 
            guna2ControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2ControlBox1.BorderColor = Color.DimGray;
            guna2ControlBox1.BorderRadius = 2;
            guna2ControlBox1.CustomizableEdges = customizableEdges9;
            guna2ControlBox1.FillColor = Color.Firebrick;
            guna2ControlBox1.ForeColor = Color.Black;
            guna2ControlBox1.IconColor = Color.White;
            guna2ControlBox1.Location = new Point(1760, 0);
            guna2ControlBox1.Name = "guna2ControlBox1";
            guna2ControlBox1.ShadowDecoration.CustomizableEdges = customizableEdges10;
            guna2ControlBox1.Size = new Size(56, 36);
            guna2ControlBox1.TabIndex = 0;
            // 
            // layout
            // 
            layout.Dock = DockStyle.Fill;
            layout.Location = new Point(231, 83);
            layout.Name = "layout";
            layout.Size = new Size(1045, 579);
            layout.TabIndex = 11;
            // 
            // btnCP
            // 
            btnCP.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnCP.FlatAppearance.BorderSize = 0;
            btnCP.FlatStyle = FlatStyle.Flat;
            btnCP.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCP.ForeColor = SystemColors.ButtonHighlight;
            btnCP.Image = (Image)resources.GetObject("btnCP.Image");
            btnCP.ImageAlign = ContentAlignment.MiddleLeft;
            btnCP.Location = new Point(0, 510);
            btnCP.Name = "btnCP";
            btnCP.Padding = new Padding(12, 0, 0, 0);
            btnCP.Size = new Size(231, 73);
            btnCP.TabIndex = 9;
            btnCP.Text = "Change Password";
            btnCP.TextAlign = ContentAlignment.MiddleLeft;
            btnCP.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCP.UseVisualStyleBackColor = true;
            btnCP.Click += btnCP_Click;
            // 
            // frm_Admin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1276, 662);
            ControlBox = false;
            Controls.Add(layout);
            Controls.Add(panelTitleBar);
            Controls.Add(panelMenu);
            Name = "frm_Admin";
            Text = "frm_Admin";
            WindowState = FormWindowState.Maximized;
            Load += frm_Admin_Load;
            panelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Avata).EndInit();
            panelTitleBar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Panel panelLogo;
        private Label labelRole;
        private PictureBox Avata;
        private Label labelName;
        private Button btnHistory;
        private Button btnHome;
        private Button btnStockin;
        private Button btnLogout;
        //private Button btnSupport;
        private Panel panelTitleBar;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox3;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Panel layout;
        private Button btnCashier;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox5;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox6;
        private Button btnCP;
    }
}