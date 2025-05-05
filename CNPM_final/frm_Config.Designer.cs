namespace GUI
{
    partial class frm_Config
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Config));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel2 = new Panel();
            guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            ckW = new Guna.UI2.WinForms.Guna2CheckBox();
            txtPass = new TextBox();
            label4 = new Label();
            txtuid = new TextBox();
            label3 = new Label();
            txtdb = new TextBox();
            label2 = new Label();
            txtserver = new TextBox();
            label1 = new Label();
            btnClear = new Button();
            btnSave = new Button();
            button1 = new Button();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.Controls.Add(guna2ControlBox1);
            panel2.Controls.Add(ckW);
            panel2.Controls.Add(txtPass);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txtuid);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtdb);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txtserver);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(btnClear);
            panel2.Controls.Add(btnSave);
            panel2.Controls.Add(button1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(357, 518);
            panel2.TabIndex = 2;
            // 
            // guna2ControlBox1
            // 
            guna2ControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2ControlBox1.BorderColor = Color.DimGray;
            guna2ControlBox1.BorderRadius = 2;
            guna2ControlBox1.CustomizableEdges = customizableEdges1;
            guna2ControlBox1.FillColor = Color.Firebrick;
            guna2ControlBox1.ForeColor = Color.Black;
            guna2ControlBox1.IconColor = Color.White;
            guna2ControlBox1.Location = new Point(301, 0);
            guna2ControlBox1.Name = "guna2ControlBox1";
            guna2ControlBox1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2ControlBox1.Size = new Size(56, 24);
            guna2ControlBox1.TabIndex = 12;
            // 
            // ckW
            // 
            ckW.AutoSize = true;
            ckW.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            ckW.CheckedState.BorderRadius = 0;
            ckW.CheckedState.BorderThickness = 0;
            ckW.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            ckW.Location = new Point(81, 320);
            ckW.Name = "ckW";
            ckW.Size = new Size(187, 24);
            ckW.TabIndex = 11;
            ckW.Text = "Window Authentication";
            ckW.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            ckW.UncheckedState.BorderRadius = 0;
            ckW.UncheckedState.BorderThickness = 0;
            ckW.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
            ckW.CheckedChanged += ckW_CheckedChanged;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(81, 278);
            txtPass.Margin = new Padding(2);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(193, 27);
            txtPass.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(59, 255);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(76, 20);
            label4.TabIndex = 9;
            label4.Text = "Password";
            // 
            // txtuid
            // 
            txtuid.Location = new Point(81, 226);
            txtuid.Margin = new Padding(2);
            txtuid.Name = "txtuid";
            txtuid.Size = new Size(193, 27);
            txtuid.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(59, 203);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(80, 20);
            label3.TabIndex = 7;
            label3.Text = "Username";
            // 
            // txtdb
            // 
            txtdb.Location = new Point(81, 174);
            txtdb.Margin = new Padding(2);
            txtdb.Name = "txtdb";
            txtdb.Size = new Size(193, 27);
            txtdb.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(59, 150);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 5;
            label2.Text = "Database";
            // 
            // txtserver
            // 
            txtserver.Location = new Point(81, 121);
            txtserver.Margin = new Padding(2);
            txtserver.Name = "txtserver";
            txtserver.Size = new Size(193, 27);
            txtserver.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(59, 99);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 3;
            label1.Text = "Server";
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Brown;
            btnClear.BackgroundImageLayout = ImageLayout.Stretch;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatAppearance.MouseDownBackColor = Color.DarkOrange;
            btnClear.FlatAppearance.MouseOverBackColor = Color.LightSalmon;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(184, 369);
            btnClear.Margin = new Padding(2);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(90, 39);
            btnClear.TabIndex = 2;
            btnClear.Text = "Cancel";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(0, 192, 192);
            btnSave.BackgroundImageLayout = ImageLayout.Stretch;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatAppearance.MouseDownBackColor = Color.DarkOrange;
            btnSave.FlatAppearance.MouseOverBackColor = Color.LightSalmon;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(59, 369);
            btnSave.Margin = new Padding(2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(90, 39);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // button1
            // 
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Yellow;
            button1.Location = new Point(128, 47);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(104, 32);
            button1.TabIndex = 0;
            button1.Text = "CONFIG";
            button1.UseVisualStyleBackColor = true;
            // 
            // frm_Config
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(357, 518);
            Controls.Add(panel2);
            Name = "frm_Config";
            Text = "frm_Config";
            Load += frm_Config_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Guna.UI2.WinForms.Guna2CheckBox ckW;
        private TextBox txtPass;
        private Label label4;
        private TextBox txtuid;
        private Label label3;
        private TextBox txtdb;
        private Label label2;
        private TextBox txtserver;
        private Label label1;
        private Button btnClear;
        private Button btnSave;
        private Button button1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
    }
}