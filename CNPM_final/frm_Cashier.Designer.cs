namespace GUI
{
    partial class frm_Cashier
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            tableLayoutPanel1 = new TableLayoutPanel();
            panelSearch = new TableLayoutPanel();
            panel3 = new Panel();
            cbName = new Guna.UI2.WinForms.Guna2ComboBox();
            label5 = new Label();
            cbSport = new Guna.UI2.WinForms.Guna2ComboBox();
            cbPrice = new Guna.UI2.WinForms.Guna2ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            cbBrand = new Guna.UI2.WinForms.Guna2ComboBox();
            label4 = new Label();
            cbColor = new Guna.UI2.WinForms.Guna2ComboBox();
            panel1 = new Panel();
            btnPayment = new Guna.UI2.WinForms.Guna2Button();
            List = new DataGridView();
            stt = new DataGridViewTextBoxColumn();
            Nameview = new DataGridViewTextBoxColumn();
            Quantityview = new DataGridViewTextBoxColumn();
            grd = new Guna.UI2.WinForms.Guna2DataGridView();
            IDP = new DataGridViewTextBoxColumn();
            PictureP = new DataGridViewImageColumn();
            SportP = new DataGridViewTextBoxColumn();
            NameP = new DataGridViewTextBoxColumn();
            BrandP = new DataGridViewTextBoxColumn();
            ColorP = new DataGridViewTextBoxColumn();
            PriceP = new DataGridViewTextBoxColumn();
            AddP = new DataGridViewButtonColumn();
            Quantity = new DataGridViewTextBoxColumn();
            DeleteP = new DataGridViewButtonColumn();
            tableLayoutPanel1.SuspendLayout();
            panelSearch.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)List).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grd).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panelSearch, 0, 0);
            tableLayoutPanel1.Controls.Add(grd, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 46.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 53.6666679F));
            tableLayoutPanel1.Size = new Size(1179, 702);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // panelSearch
            // 
            panelSearch.BackColor = SystemColors.Control;
            panelSearch.ColumnCount = 2;
            panelSearch.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 36.5927429F));
            panelSearch.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 63.4072571F));
            panelSearch.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 557F));
            panelSearch.Controls.Add(panel3, 0, 0);
            panelSearch.Controls.Add(panel1, 1, 0);
            panelSearch.Dock = DockStyle.Fill;
            panelSearch.Location = new Point(3, 3);
            panelSearch.Name = "panelSearch";
            panelSearch.RowCount = 1;
            panelSearch.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            panelSearch.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            panelSearch.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            panelSearch.Size = new Size(1173, 319);
            panelSearch.TabIndex = 19;
            // 
            // panel3
            // 
            panel3.Controls.Add(cbName);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(cbSport);
            panel3.Controls.Add(cbPrice);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(cbBrand);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(cbColor);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(423, 313);
            panel3.TabIndex = 16;
            // 
            // cbName
            // 
            cbName.BackColor = Color.Transparent;
            cbName.BorderRadius = 7;
            cbName.CustomizableEdges = customizableEdges1;
            cbName.DrawMode = DrawMode.OwnerDrawFixed;
            cbName.DropDownStyle = ComboBoxStyle.DropDownList;
            cbName.FocusedColor = Color.FromArgb(94, 148, 255);
            cbName.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbName.Font = new Font("Segoe UI", 10F);
            cbName.ForeColor = Color.FromArgb(68, 88, 112);
            cbName.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            cbName.ItemHeight = 30;
            cbName.Location = new Point(92, 78);
            cbName.Name = "cbName";
            cbName.ShadowDecoration.CustomizableEdges = customizableEdges2;
            cbName.Size = new Size(284, 36);
            cbName.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(22, 22);
            label5.Name = "label5";
            label5.Size = new Size(61, 28);
            label5.TabIndex = 15;
            label5.Text = "Sport";
            // 
            // cbSport
            // 
            cbSport.BackColor = Color.Transparent;
            cbSport.BorderRadius = 7;
            cbSport.CustomizableEdges = customizableEdges3;
            cbSport.DrawMode = DrawMode.OwnerDrawFixed;
            cbSport.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSport.FocusedColor = Color.FromArgb(94, 148, 255);
            cbSport.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbSport.Font = new Font("Segoe UI", 10F);
            cbSport.ForeColor = Color.FromArgb(68, 88, 112);
            cbSport.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            cbSport.ItemHeight = 30;
            cbSport.Location = new Point(92, 14);
            cbSport.Name = "cbSport";
            cbSport.ShadowDecoration.CustomizableEdges = customizableEdges4;
            cbSport.Size = new Size(284, 36);
            cbSport.TabIndex = 16;
            // 
            // cbPrice
            // 
            cbPrice.BackColor = Color.Transparent;
            cbPrice.BorderRadius = 7;
            cbPrice.CustomizableEdges = customizableEdges5;
            cbPrice.DrawMode = DrawMode.OwnerDrawFixed;
            cbPrice.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPrice.FocusedColor = Color.FromArgb(94, 148, 255);
            cbPrice.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbPrice.Font = new Font("Segoe UI", 10F);
            cbPrice.ForeColor = Color.FromArgb(68, 88, 112);
            cbPrice.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            cbPrice.ItemHeight = 30;
            cbPrice.Location = new Point(92, 254);
            cbPrice.Name = "cbPrice";
            cbPrice.ShadowDecoration.CustomizableEdges = customizableEdges6;
            cbPrice.Size = new Size(284, 36);
            cbPrice.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 86);
            label1.Name = "label1";
            label1.Size = new Size(64, 28);
            label1.TabIndex = 1;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(22, 143);
            label2.Name = "label2";
            label2.Size = new Size(63, 28);
            label2.TabIndex = 2;
            label2.Text = "Brand";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(22, 204);
            label3.Name = "label3";
            label3.Size = new Size(60, 28);
            label3.TabIndex = 4;
            label3.Text = "Color";
            // 
            // cbBrand
            // 
            cbBrand.BackColor = Color.Transparent;
            cbBrand.BorderRadius = 7;
            cbBrand.CustomizableEdges = customizableEdges7;
            cbBrand.DrawMode = DrawMode.OwnerDrawFixed;
            cbBrand.DropDownStyle = ComboBoxStyle.DropDownList;
            cbBrand.FocusedColor = Color.FromArgb(94, 148, 255);
            cbBrand.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbBrand.Font = new Font("Segoe UI", 10F);
            cbBrand.ForeColor = Color.FromArgb(68, 88, 112);
            cbBrand.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            cbBrand.ItemHeight = 30;
            cbBrand.Location = new Point(92, 135);
            cbBrand.Name = "cbBrand";
            cbBrand.ShadowDecoration.CustomizableEdges = customizableEdges8;
            cbBrand.Size = new Size(284, 36);
            cbBrand.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(22, 262);
            label4.Name = "label4";
            label4.Size = new Size(54, 28);
            label4.TabIndex = 11;
            label4.Text = "Price";
            // 
            // cbColor
            // 
            cbColor.BackColor = Color.Transparent;
            cbColor.BorderRadius = 7;
            cbColor.CustomizableEdges = customizableEdges9;
            cbColor.DrawMode = DrawMode.OwnerDrawFixed;
            cbColor.DropDownStyle = ComboBoxStyle.DropDownList;
            cbColor.FocusedColor = Color.FromArgb(94, 148, 255);
            cbColor.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbColor.Font = new Font("Segoe UI", 10F);
            cbColor.ForeColor = Color.FromArgb(68, 88, 112);
            cbColor.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            cbColor.ItemHeight = 30;
            cbColor.Location = new Point(92, 196);
            cbColor.Name = "cbColor";
            cbColor.ShadowDecoration.CustomizableEdges = customizableEdges10;
            cbColor.Size = new Size(284, 36);
            cbColor.TabIndex = 9;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnPayment);
            panel1.Controls.Add(List);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(432, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(738, 313);
            panel1.TabIndex = 18;
            // 
            // btnPayment
            // 
            btnPayment.BorderRadius = 6;
            btnPayment.CustomizableEdges = customizableEdges11;
            btnPayment.DisabledState.BorderColor = Color.DarkGray;
            btnPayment.DisabledState.CustomBorderColor = Color.DarkGray;
            btnPayment.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnPayment.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnPayment.FillColor = Color.FromArgb(255, 128, 0);
            btnPayment.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPayment.ForeColor = Color.White;
            btnPayment.Location = new Point(243, 220);
            btnPayment.Name = "btnPayment";
            btnPayment.ShadowDecoration.CustomizableEdges = customizableEdges12;
            btnPayment.Size = new Size(209, 59);
            btnPayment.TabIndex = 18;
            btnPayment.Text = "Buy";
            btnPayment.Click += btnPayment_Click;
            // 
            // List
            // 
            List.AllowUserToAddRows = false;
            List.AllowUserToDeleteRows = false;
            List.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            List.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            List.Columns.AddRange(new DataGridViewColumn[] { stt, Nameview, Quantityview });
            List.Location = new Point(3, 0);
            List.Name = "List";
            List.ReadOnly = true;
            List.RowHeadersWidth = 51;
            List.Size = new Size(732, 192);
            List.TabIndex = 21;
            List.CellClick += List_CellClick_1;
            // 
            // stt
            // 
            stt.HeaderText = "#";
            stt.MinimumWidth = 6;
            stt.Name = "stt";
            stt.ReadOnly = true;
            stt.Width = 125;
            // 
            // Nameview
            // 
            Nameview.HeaderText = "Name";
            Nameview.MinimumWidth = 6;
            Nameview.Name = "Nameview";
            Nameview.ReadOnly = true;
            Nameview.Width = 125;
            // 
            // Quantityview
            // 
            Quantityview.HeaderText = "Quantity";
            Quantityview.MinimumWidth = 6;
            Quantityview.Name = "Quantityview";
            Quantityview.ReadOnly = true;
            Quantityview.Width = 125;
            // 
            // grd
            // 
            grd.AllowUserToAddRows = false;
            grd.AllowUserToDeleteRows = false;
            grd.AllowUserToResizeColumns = false;
            grd.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            grd.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            grd.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grd.BackgroundColor = Color.LightGray;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.RoyalBlue;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            grd.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            grd.ColumnHeadersHeight = 30;
            grd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            grd.Columns.AddRange(new DataGridViewColumn[] { IDP, PictureP, SportP, NameP, BrandP, ColorP, PriceP, AddP, Quantity, DeleteP });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            grd.DefaultCellStyle = dataGridViewCellStyle5;
            grd.GridColor = Color.FromArgb(231, 229, 255);
            grd.Location = new Point(3, 328);
            grd.MultiSelect = false;
            grd.Name = "grd";
            grd.ReadOnly = true;
            grd.RowHeadersVisible = false;
            grd.RowHeadersWidth = 51;
            grd.ShowEditingIcon = false;
            grd.Size = new Size(1173, 371);
            grd.TabIndex = 18;
            grd.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            grd.ThemeStyle.AlternatingRowsStyle.Font = null;
            grd.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            grd.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            grd.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            grd.ThemeStyle.BackColor = Color.LightGray;
            grd.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            grd.ThemeStyle.HeaderStyle.BackColor = Color.RoyalBlue;
            grd.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            grd.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grd.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            grd.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            grd.ThemeStyle.HeaderStyle.Height = 30;
            grd.ThemeStyle.ReadOnly = true;
            grd.ThemeStyle.RowsStyle.BackColor = Color.White;
            grd.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            grd.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            grd.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            grd.ThemeStyle.RowsStyle.Height = 29;
            grd.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            grd.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            grd.CellClick += grd_CellClick_1;
            // 
            // IDP
            // 
            IDP.FillWeight = 40.94731F;
            IDP.HeaderText = "#";
            IDP.MinimumWidth = 6;
            IDP.Name = "IDP";
            IDP.ReadOnly = true;
            // 
            // PictureP
            // 
            PictureP.FillWeight = 53.36884F;
            PictureP.HeaderText = "Picture";
            PictureP.MinimumWidth = 6;
            PictureP.Name = "PictureP";
            PictureP.ReadOnly = true;
            // 
            // SportP
            // 
            SportP.FillWeight = 40F;
            SportP.HeaderText = "Sport";
            SportP.MinimumWidth = 6;
            SportP.Name = "SportP";
            SportP.ReadOnly = true;
            // 
            // NameP
            // 
            NameP.FillWeight = 40.94731F;
            NameP.HeaderText = "Name";
            NameP.MinimumWidth = 6;
            NameP.Name = "NameP";
            NameP.ReadOnly = true;
            // 
            // BrandP
            // 
            BrandP.FillWeight = 40.94731F;
            BrandP.HeaderText = "Brand";
            BrandP.MinimumWidth = 6;
            BrandP.Name = "BrandP";
            BrandP.ReadOnly = true;
            // 
            // ColorP
            // 
            ColorP.FillWeight = 40.94731F;
            ColorP.HeaderText = "Color";
            ColorP.MinimumWidth = 6;
            ColorP.Name = "ColorP";
            ColorP.ReadOnly = true;
            // 
            // PriceP
            // 
            PriceP.FillWeight = 40.94731F;
            PriceP.HeaderText = "Price";
            PriceP.MinimumWidth = 6;
            PriceP.Name = "PriceP";
            PriceP.ReadOnly = true;
            // 
            // AddP
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(0, 192, 0);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(0, 192, 0);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            AddP.DefaultCellStyle = dataGridViewCellStyle3;
            AddP.FillWeight = 40.94731F;
            AddP.FlatStyle = FlatStyle.Flat;
            AddP.HeaderText = "";
            AddP.MinimumWidth = 6;
            AddP.Name = "AddP";
            AddP.ReadOnly = true;
            AddP.Text = "Add";
            AddP.UseColumnTextForButtonValue = true;
            // 
            // Quantity
            // 
            Quantity.HeaderText = "Quantity";
            Quantity.MinimumWidth = 6;
            Quantity.Name = "Quantity";
            Quantity.ReadOnly = true;
            // 
            // DeleteP
            // 
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(192, 0, 0);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(192, 0, 0);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            DeleteP.DefaultCellStyle = dataGridViewCellStyle4;
            DeleteP.FillWeight = 40.94731F;
            DeleteP.FlatStyle = FlatStyle.Flat;
            DeleteP.HeaderText = "";
            DeleteP.MinimumWidth = 6;
            DeleteP.Name = "DeleteP";
            DeleteP.ReadOnly = true;
            DeleteP.Text = "Delete";
            DeleteP.UseColumnTextForButtonValue = true;
            // 
            // frm_Cashier
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1179, 702);
            Controls.Add(tableLayoutPanel1);
            Name = "frm_Cashier";
            Text = "frm_Cashier";
            Load += frm_Cashier_Load_1;
            tableLayoutPanel1.ResumeLayout(false);
            panelSearch.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)List).EndInit();
            ((System.ComponentModel.ISupportInitialize)grd).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Guna.UI2.WinForms.Guna2DataGridView grd;
        private TableLayoutPanel panelSearch;
        private Panel panel3;
        private Guna.UI2.WinForms.Guna2ComboBox cbName;
        private Label label5;
        private Guna.UI2.WinForms.Guna2ComboBox cbSport;
        private Guna.UI2.WinForms.Guna2ComboBox cbPrice;
        private Label label1;
        private Label label2;
        private Label label3;
        private Guna.UI2.WinForms.Guna2ComboBox cbBrand;
        private Label label4;
        private Guna.UI2.WinForms.Guna2ComboBox cbColor;
        private Guna.UI2.WinForms.Guna2Button btnPayment;
        private Panel panel1;
        private DataGridView List;
        private DataGridViewTextBoxColumn stt;
        private DataGridViewTextBoxColumn Nameview;
        private DataGridViewTextBoxColumn Quantityview;
        private DataGridViewTextBoxColumn IDP;
        private DataGridViewImageColumn PictureP;
        private DataGridViewTextBoxColumn SportP;
        private DataGridViewTextBoxColumn NameP;
        private DataGridViewTextBoxColumn BrandP;
        private DataGridViewTextBoxColumn ColorP;
        private DataGridViewTextBoxColumn PriceP;
        private DataGridViewButtonColumn AddP;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewButtonColumn DeleteP;
    }
}