namespace GUI
{
    partial class frm_ChangePassword
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
            panel2 = new Panel();
            guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            show = new CheckBox();
            btnSubmit = new Button();
            label3 = new Label();
            label2 = new Label();
            button1 = new Button();
            label1 = new Label();
            txtConfirmP = new TextBox();
            txtNewP = new TextBox();
            txtCurrentP = new TextBox();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.BackgroundImage = Properties.Resources.login;
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Controls.Add(guna2ControlBox1);
            panel2.Controls.Add(show);
            panel2.Controls.Add(btnSubmit);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txtConfirmP);
            panel2.Controls.Add(txtNewP);
            panel2.Controls.Add(txtCurrentP);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(561, 517);
            panel2.TabIndex = 3;
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
            guna2ControlBox1.Location = new Point(505, 0);
            guna2ControlBox1.Name = "guna2ControlBox1";
            guna2ControlBox1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2ControlBox1.Size = new Size(56, 24);
            guna2ControlBox1.TabIndex = 9;
            // 
            // show
            // 
            show.AutoSize = true;
            show.Location = new Point(142, 359);
            show.Margin = new Padding(2);
            show.Name = "show";
            show.Size = new Size(132, 24);
            show.TabIndex = 8;
            show.Text = "Show Password";
            show.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.FromArgb(255, 128, 0);
            btnSubmit.BackgroundImageLayout = ImageLayout.Stretch;
            btnSubmit.FlatAppearance.BorderSize = 0;
            btnSubmit.FlatAppearance.MouseDownBackColor = Color.DarkOrange;
            btnSubmit.FlatAppearance.MouseOverBackColor = Color.LightSalmon;
            btnSubmit.FlatStyle = FlatStyle.Flat;
            btnSubmit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubmit.ForeColor = Color.Blue;
            btnSubmit.Location = new Point(211, 404);
            btnSubmit.Margin = new Padding(2);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(104, 34);
            btnSubmit.TabIndex = 7;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(122, 286);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(165, 25);
            label3.TabIndex = 6;
            label3.Text = "Confirm Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(122, 213);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(135, 25);
            label2.TabIndex = 5;
            label2.Text = "New Password";
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.FlatAppearance.BorderColor = Color.White;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Gold;
            button1.Location = new Point(131, 32);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(292, 60);
            button1.TabIndex = 4;
            button1.Text = "Change Password";
            button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(122, 133);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(178, 28);
            label1.TabIndex = 3;
            label1.Text = "Current Password";
            // 
            // txtConfirmP
            // 
            txtConfirmP.Location = new Point(142, 318);
            txtConfirmP.Margin = new Padding(2);
            txtConfirmP.Name = "txtConfirmP";
            txtConfirmP.Size = new Size(254, 27);
            txtConfirmP.TabIndex = 2;
            txtConfirmP.UseSystemPasswordChar = true;
            // 
            // txtNewP
            // 
            txtNewP.Location = new Point(142, 242);
            txtNewP.Margin = new Padding(2);
            txtNewP.Name = "txtNewP";
            txtNewP.Size = new Size(254, 27);
            txtNewP.TabIndex = 1;
            txtNewP.UseSystemPasswordChar = true;
            // 
            // txtCurrentP
            // 
            txtCurrentP.Location = new Point(142, 174);
            txtCurrentP.Margin = new Padding(2);
            txtCurrentP.Name = "txtCurrentP";
            txtCurrentP.Size = new Size(254, 27);
            txtCurrentP.TabIndex = 0;
            txtCurrentP.UseSystemPasswordChar = true;
            // 
            // frm_ChangePassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(561, 517);
            Controls.Add(panel2);
            Name = "frm_ChangePassword";
            Text = "frm_ChangePassword";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private CheckBox show;
        private Button btnSubmit;
        private Label label3;
        private Label label2;
        private Button button1;
        private Label label1;
        private TextBox txtConfirmP;
        private TextBox txtNewP;
        private TextBox txtCurrentP;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
    }
}