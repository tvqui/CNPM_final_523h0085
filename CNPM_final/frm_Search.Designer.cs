namespace GUI
{
    partial class frm_Search
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            grd = new Guna.UI2.WinForms.Guna2DataGridView();
            cbPrice = new Guna.UI2.WinForms.Guna2ComboBox();
            panel3 = new Panel();
            cbName = new Guna.UI2.WinForms.Guna2ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            cbBrand = new Guna.UI2.WinForms.Guna2ComboBox();
            label4 = new Label();
            cbColor = new Guna.UI2.WinForms.Guna2ComboBox();
            panel4 = new Panel();
            Return = new Guna.UI2.WinForms.Guna2CircleButton();
            btnPayment = new Guna.UI2.WinForms.Guna2Button();
            List = new Guna.UI2.WinForms.Guna2DataGridView();
            tableLayoutPanel1 = new TableLayoutPanel();
            panelSearch = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)grd).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)List).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            panelSearch.SuspendLayout();
            SuspendLayout();
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
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            grd.DefaultCellStyle = dataGridViewCellStyle3;
            grd.GridColor = Color.FromArgb(231, 229, 255);
            grd.Location = new Point(3, 331);
            grd.MultiSelect = false;
            grd.Name = "grd";
            grd.ReadOnly = true;
            grd.RowHeadersVisible = false;
            grd.RowHeadersWidth = 51;
            grd.ShowEditingIcon = false;
            grd.Size = new Size(1161, 374);
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
            grd.CellClick += grd_CellClick;
            // 
            // cbPrice
            // 
            cbPrice.BackColor = Color.Transparent;
            cbPrice.BorderRadius = 7;
            cbPrice.CustomizableEdges = customizableEdges1;
            cbPrice.DrawMode = DrawMode.OwnerDrawFixed;
            cbPrice.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPrice.FocusedColor = Color.FromArgb(94, 148, 255);
            cbPrice.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbPrice.Font = new Font("Segoe UI", 10F);
            cbPrice.ForeColor = Color.FromArgb(68, 88, 112);
            cbPrice.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            cbPrice.ItemHeight = 30;
            cbPrice.Location = new Point(86, 197);
            cbPrice.Name = "cbPrice";
            cbPrice.ShadowDecoration.CustomizableEdges = customizableEdges2;
            cbPrice.Size = new Size(310, 36);
            cbPrice.TabIndex = 6;
            cbPrice.SelectedIndexChanged += cbPrice_SelectedIndexChanged;
            // 
            // panel3
            // 
            panel3.Controls.Add(cbName);
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
            panel3.Size = new Size(455, 316);
            panel3.TabIndex = 16;
            // 
            // cbName
            // 
            cbName.BackColor = Color.Transparent;
            cbName.BorderRadius = 7;
            cbName.CustomizableEdges = customizableEdges3;
            cbName.DrawMode = DrawMode.OwnerDrawFixed;
            cbName.DropDownStyle = ComboBoxStyle.DropDownList;
            cbName.FocusedColor = Color.FromArgb(94, 148, 255);
            cbName.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbName.Font = new Font("Segoe UI", 10F);
            cbName.ForeColor = Color.FromArgb(68, 88, 112);
            cbName.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            cbName.ItemHeight = 30;
            cbName.Location = new Point(86, 21);
            cbName.Name = "cbName";
            cbName.ShadowDecoration.CustomizableEdges = customizableEdges4;
            cbName.Size = new Size(310, 36);
            cbName.TabIndex = 12;
            cbName.SelectedIndexChanged += cbName_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(16, 29);
            label1.Name = "label1";
            label1.Size = new Size(64, 28);
            label1.TabIndex = 1;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(16, 86);
            label2.Name = "label2";
            label2.Size = new Size(63, 28);
            label2.TabIndex = 2;
            label2.Text = "Brand";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(16, 147);
            label3.Name = "label3";
            label3.Size = new Size(60, 28);
            label3.TabIndex = 4;
            label3.Text = "Color";
            // 
            // cbBrand
            // 
            cbBrand.BackColor = Color.Transparent;
            cbBrand.BorderRadius = 7;
            cbBrand.CustomizableEdges = customizableEdges5;
            cbBrand.DrawMode = DrawMode.OwnerDrawFixed;
            cbBrand.DropDownStyle = ComboBoxStyle.DropDownList;
            cbBrand.FocusedColor = Color.FromArgb(94, 148, 255);
            cbBrand.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbBrand.Font = new Font("Segoe UI", 10F);
            cbBrand.ForeColor = Color.FromArgb(68, 88, 112);
            cbBrand.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            cbBrand.ItemHeight = 30;
            cbBrand.Location = new Point(86, 78);
            cbBrand.Name = "cbBrand";
            cbBrand.ShadowDecoration.CustomizableEdges = customizableEdges6;
            cbBrand.Size = new Size(310, 36);
            cbBrand.TabIndex = 8;
            cbBrand.SelectedIndexChanged += cbBrand_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(16, 205);
            label4.Name = "label4";
            label4.Size = new Size(54, 28);
            label4.TabIndex = 11;
            label4.Text = "Price";
            // 
            // cbColor
            // 
            cbColor.BackColor = Color.Transparent;
            cbColor.BorderRadius = 7;
            cbColor.CustomizableEdges = customizableEdges7;
            cbColor.DrawMode = DrawMode.OwnerDrawFixed;
            cbColor.DropDownStyle = ComboBoxStyle.DropDownList;
            cbColor.FocusedColor = Color.FromArgb(94, 148, 255);
            cbColor.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbColor.Font = new Font("Segoe UI", 10F);
            cbColor.ForeColor = Color.FromArgb(68, 88, 112);
            cbColor.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            cbColor.ItemHeight = 30;
            cbColor.Location = new Point(86, 139);
            cbColor.Name = "cbColor";
            cbColor.ShadowDecoration.CustomizableEdges = customizableEdges8;
            cbColor.Size = new Size(310, 36);
            cbColor.TabIndex = 9;
            cbColor.SelectedIndexChanged += cbColor_SelectedIndexChanged;
            // 
            // panel4
            // 
            panel4.Controls.Add(Return);
            panel4.Controls.Add(btnPayment);
            panel4.Controls.Add(List);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(464, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(694, 316);
            panel4.TabIndex = 17;
            // 
            // Return
            // 
            Return.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Return.DisabledState.BorderColor = Color.DarkGray;
            Return.DisabledState.CustomBorderColor = Color.DarkGray;
            Return.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Return.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Return.Font = new Font("Segoe UI", 9F);
            Return.ForeColor = Color.White;
            Return.Image = Properties.Resources.Return;
            Return.Location = new Point(668, 0);
            Return.Name = "Return";
            Return.ShadowDecoration.CustomizableEdges = customizableEdges9;
            Return.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            Return.Size = new Size(26, 26);
            Return.TabIndex = 17;
            Return.Click += Return_Click;
            // 
            // btnPayment
            // 
            btnPayment.BorderRadius = 6;
            btnPayment.CustomizableEdges = customizableEdges10;
            btnPayment.DisabledState.BorderColor = Color.DarkGray;
            btnPayment.DisabledState.CustomBorderColor = Color.DarkGray;
            btnPayment.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnPayment.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnPayment.FillColor = Color.FromArgb(255, 128, 0);
            btnPayment.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPayment.ForeColor = Color.White;
            btnPayment.Location = new Point(222, 242);
            btnPayment.Name = "btnPayment";
            btnPayment.ShadowDecoration.CustomizableEdges = customizableEdges11;
            btnPayment.Size = new Size(225, 56);
            btnPayment.TabIndex = 15;
            btnPayment.Text = "Complete your purchase";
            btnPayment.Click += btnPayment_Click;
            // 
            // List
            // 
            List.AllowUserToAddRows = false;
            List.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = Color.White;
            List.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            List.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            List.ColumnHeadersHeight = 22;
            List.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            List.DefaultCellStyle = dataGridViewCellStyle6;
            List.GridColor = Color.FromArgb(231, 229, 255);
            List.Location = new Point(15, 21);
            List.Name = "List";
            List.ReadOnly = true;
            List.RowHeadersVisible = false;
            List.RowHeadersWidth = 51;
            List.Size = new Size(647, 200);
            List.TabIndex = 13;
            List.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            List.ThemeStyle.AlternatingRowsStyle.Font = null;
            List.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            List.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            List.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            List.ThemeStyle.BackColor = Color.White;
            List.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            List.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            List.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            List.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            List.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            List.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            List.ThemeStyle.HeaderStyle.Height = 22;
            List.ThemeStyle.ReadOnly = true;
            List.ThemeStyle.RowsStyle.BackColor = Color.White;
            List.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            List.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            List.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            List.ThemeStyle.RowsStyle.Height = 29;
            List.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            List.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            List.CellClick += List_CellClick;
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
            tableLayoutPanel1.Size = new Size(1167, 708);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // panelSearch
            // 
            panelSearch.BackColor = SystemColors.Control;
            panelSearch.ColumnCount = 2;
            panelSearch.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 39.710144F));
            panelSearch.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60.289856F));
            panelSearch.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 557F));
            panelSearch.Controls.Add(panel4, 2, 0);
            panelSearch.Controls.Add(panel3, 0, 0);
            panelSearch.Dock = DockStyle.Fill;
            panelSearch.Location = new Point(3, 3);
            panelSearch.Name = "panelSearch";
            panelSearch.RowCount = 1;
            panelSearch.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            panelSearch.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            panelSearch.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            panelSearch.Size = new Size(1161, 322);
            panelSearch.TabIndex = 19;
            // 
            // frm_Search
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1167, 708);
            ControlBox = false;
            Controls.Add(tableLayoutPanel1);
            Name = "frm_Search";
            ShowIcon = false;
            Text = "frm_Badminton";
            Load += frm_Search_Load;
            ((System.ComponentModel.ISupportInitialize)grd).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)List).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            panelSearch.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Guna.UI2.WinForms.Guna2DataGridView grd;
        private Guna.UI2.WinForms.Guna2ComboBox cbPrice;
        private Panel panel3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Guna.UI2.WinForms.Guna2ComboBox cbBrand;
        private Label label4;
        private Guna.UI2.WinForms.Guna2ComboBox cbColor;
        private Panel panel4;
        
        private Guna.UI2.WinForms.Guna2Button btnPayment;
        
        private Guna.UI2.WinForms.Guna2DataGridView List;
        //private DataGridViewTextBoxColumn NamePList;
        //private DataGridViewTextBoxColumn ColorPList;
        //private DataGridViewButtonColumn AddPList;
        //private DataGridViewTextBoxColumn QuantityPList;
       // private DataGridViewButtonColumn DeletePList;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel panelSearch;
        private Guna.UI2.WinForms.Guna2CircleButton Return;
        private Guna.UI2.WinForms.Guna2ComboBox cbName;
    }
}