namespace GUI
{
    partial class frm_Choosesport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Choosesport));
            MenuLayout = new TableLayoutPanel();
            btnRun = new FontAwesome.Sharp.IconButton();
            btnGyF = new FontAwesome.Sharp.IconButton();
            btnSwim = new FontAwesome.Sharp.IconButton();
            btnGF = new FontAwesome.Sharp.IconButton();
            btnTN = new FontAwesome.Sharp.IconButton();
            btnBMT = new FontAwesome.Sharp.IconButton();
            btnMA = new FontAwesome.Sharp.IconButton();
            btnBasketball = new FontAwesome.Sharp.IconButton();
            btnSoccer = new FontAwesome.Sharp.IconButton();
            MenuLayout.SuspendLayout();
            SuspendLayout();
            // 
            // MenuLayout
            // 
            MenuLayout.BackColor = Color.Transparent;
            MenuLayout.BackgroundImage = Properties.Resources.background;
            MenuLayout.BackgroundImageLayout = ImageLayout.Stretch;
            MenuLayout.ColumnCount = 3;
            MenuLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            MenuLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            MenuLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            MenuLayout.Controls.Add(btnRun, 2, 2);
            MenuLayout.Controls.Add(btnGyF, 1, 2);
            MenuLayout.Controls.Add(btnSwim, 0, 2);
            MenuLayout.Controls.Add(btnGF, 2, 1);
            MenuLayout.Controls.Add(btnTN, 1, 1);
            MenuLayout.Controls.Add(btnBMT, 0, 1);
            MenuLayout.Controls.Add(btnMA, 2, 0);
            MenuLayout.Controls.Add(btnBasketball, 1, 0);
            MenuLayout.Controls.Add(btnSoccer, 0, 0);
            MenuLayout.Dock = DockStyle.Fill;
            MenuLayout.Location = new Point(0, 0);
            MenuLayout.Name = "MenuLayout";
            MenuLayout.RowCount = 3;
            MenuLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33333F));
            MenuLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            MenuLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            MenuLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            MenuLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            MenuLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            MenuLayout.Size = new Size(985, 597);
            MenuLayout.TabIndex = 9;
            // 
            // btnRun
            // 
            btnRun.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnRun.AutoSize = true;
            btnRun.BackgroundImage = (Image)resources.GetObject("btnRun.BackgroundImage");
            btnRun.BackgroundImageLayout = ImageLayout.Stretch;
            btnRun.Cursor = Cursors.Hand;
            btnRun.IconChar = FontAwesome.Sharp.IconChar.None;
            btnRun.IconColor = Color.Black;
            btnRun.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRun.Location = new Point(756, 427);
            btnRun.Margin = new Padding(100, 30, 100, 30);
            btnRun.Name = "btnRun";
            btnRun.Size = new Size(129, 140);
            btnRun.TabIndex = 18;
            btnRun.UseVisualStyleBackColor = true;
            btnRun.Click += btnRun_Click;
            // 
            // btnGyF
            // 
            btnGyF.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnGyF.AutoSize = true;
            btnGyF.BackgroundImage = (Image)resources.GetObject("btnGyF.BackgroundImage");
            btnGyF.BackgroundImageLayout = ImageLayout.Stretch;
            btnGyF.Cursor = Cursors.Hand;
            btnGyF.IconChar = FontAwesome.Sharp.IconChar.None;
            btnGyF.IconColor = Color.Black;
            btnGyF.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGyF.Location = new Point(428, 427);
            btnGyF.Margin = new Padding(100, 30, 100, 30);
            btnGyF.Name = "btnGyF";
            btnGyF.Size = new Size(128, 140);
            btnGyF.TabIndex = 17;
            btnGyF.UseVisualStyleBackColor = true;
            btnGyF.Click += btnGyF_Click;
            // 
            // btnSwim
            // 
            btnSwim.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnSwim.AutoSize = true;
            btnSwim.BackgroundImage = (Image)resources.GetObject("btnSwim.BackgroundImage");
            btnSwim.BackgroundImageLayout = ImageLayout.Stretch;
            btnSwim.Cursor = Cursors.Hand;
            btnSwim.IconChar = FontAwesome.Sharp.IconChar.None;
            btnSwim.IconColor = Color.Black;
            btnSwim.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSwim.Location = new Point(100, 427);
            btnSwim.Margin = new Padding(100, 30, 100, 30);
            btnSwim.Name = "btnSwim";
            btnSwim.Size = new Size(128, 140);
            btnSwim.TabIndex = 16;
            btnSwim.UseVisualStyleBackColor = true;
            btnSwim.Click += btnSwim_Click;
            // 
            // btnGF
            // 
            btnGF.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnGF.AutoSize = true;
            btnGF.BackgroundImage = (Image)resources.GetObject("btnGF.BackgroundImage");
            btnGF.BackgroundImageLayout = ImageLayout.Stretch;
            btnGF.Cursor = Cursors.Hand;
            btnGF.IconChar = FontAwesome.Sharp.IconChar.None;
            btnGF.IconColor = Color.Black;
            btnGF.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGF.Location = new Point(756, 228);
            btnGF.Margin = new Padding(100, 30, 100, 30);
            btnGF.Name = "btnGF";
            btnGF.Size = new Size(129, 139);
            btnGF.TabIndex = 15;
            btnGF.UseVisualStyleBackColor = true;
            btnGF.Click += btnGF_Click;
            // 
            // btnTN
            // 
            btnTN.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnTN.AutoSize = true;
            btnTN.BackgroundImage = (Image)resources.GetObject("btnTN.BackgroundImage");
            btnTN.BackgroundImageLayout = ImageLayout.Stretch;
            btnTN.Cursor = Cursors.Hand;
            btnTN.IconChar = FontAwesome.Sharp.IconChar.None;
            btnTN.IconColor = Color.Black;
            btnTN.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnTN.Location = new Point(428, 228);
            btnTN.Margin = new Padding(100, 30, 100, 30);
            btnTN.Name = "btnTN";
            btnTN.Size = new Size(128, 139);
            btnTN.TabIndex = 14;
            btnTN.UseVisualStyleBackColor = true;
            btnTN.Click += btnTN_Click;
            // 
            // btnBMT
            // 
            btnBMT.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnBMT.AutoSize = true;
            btnBMT.BackgroundImage = (Image)resources.GetObject("btnBMT.BackgroundImage");
            btnBMT.BackgroundImageLayout = ImageLayout.Stretch;
            btnBMT.Cursor = Cursors.Hand;
            btnBMT.IconChar = FontAwesome.Sharp.IconChar.None;
            btnBMT.IconColor = Color.Black;
            btnBMT.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBMT.Location = new Point(100, 228);
            btnBMT.Margin = new Padding(100, 30, 100, 30);
            btnBMT.Name = "btnBMT";
            btnBMT.Size = new Size(128, 139);
            btnBMT.TabIndex = 13;
            btnBMT.UseVisualStyleBackColor = true;
            btnBMT.Click += btnBMT_Click;
            // 
            // btnMA
            // 
            btnMA.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnMA.AutoSize = true;
            btnMA.BackgroundImage = (Image)resources.GetObject("btnMA.BackgroundImage");
            btnMA.BackgroundImageLayout = ImageLayout.Stretch;
            btnMA.Cursor = Cursors.Hand;
            btnMA.IconChar = FontAwesome.Sharp.IconChar.None;
            btnMA.IconColor = Color.Black;
            btnMA.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMA.Location = new Point(756, 30);
            btnMA.Margin = new Padding(100, 30, 100, 30);
            btnMA.Name = "btnMA";
            btnMA.Size = new Size(129, 138);
            btnMA.TabIndex = 12;
            btnMA.UseVisualStyleBackColor = true;
            btnMA.Click += btnMA_Click;
            // 
            // btnBasketball
            // 
            btnBasketball.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnBasketball.AutoSize = true;
            btnBasketball.BackgroundImage = (Image)resources.GetObject("btnBasketball.BackgroundImage");
            btnBasketball.BackgroundImageLayout = ImageLayout.Stretch;
            btnBasketball.Cursor = Cursors.Hand;
            btnBasketball.IconChar = FontAwesome.Sharp.IconChar.None;
            btnBasketball.IconColor = Color.Black;
            btnBasketball.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBasketball.Location = new Point(428, 30);
            btnBasketball.Margin = new Padding(100, 30, 100, 30);
            btnBasketball.Name = "btnBasketball";
            btnBasketball.Size = new Size(128, 138);
            btnBasketball.TabIndex = 11;
            btnBasketball.UseVisualStyleBackColor = true;
            btnBasketball.Click += btnBasketball_Click;
            // 
            // btnSoccer
            // 
            btnSoccer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnSoccer.AutoSize = true;
            btnSoccer.BackgroundImage = (Image)resources.GetObject("btnSoccer.BackgroundImage");
            btnSoccer.BackgroundImageLayout = ImageLayout.Stretch;
            btnSoccer.Cursor = Cursors.Hand;
            btnSoccer.IconChar = FontAwesome.Sharp.IconChar.None;
            btnSoccer.IconColor = Color.Black;
            btnSoccer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSoccer.Location = new Point(100, 30);
            btnSoccer.Margin = new Padding(100, 30, 100, 30);
            btnSoccer.Name = "btnSoccer";
            btnSoccer.Size = new Size(128, 138);
            btnSoccer.TabIndex = 10;
            btnSoccer.UseVisualStyleBackColor = true;
            btnSoccer.Click += btnSoccer_Click;
            // 
            // frm_Choosesport
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(985, 597);
            Controls.Add(MenuLayout);
            Name = "frm_Choosesport";
            Text = "frm_Choosesport";
            MenuLayout.ResumeLayout(false);
            MenuLayout.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel MenuLayout;
        private FontAwesome.Sharp.IconButton btnRun;
        private FontAwesome.Sharp.IconButton btnGyF;
        private FontAwesome.Sharp.IconButton btnSwim;
        private FontAwesome.Sharp.IconButton btnGF;
        private FontAwesome.Sharp.IconButton btnTN;
        private FontAwesome.Sharp.IconButton btnBMT;
        private FontAwesome.Sharp.IconButton btnMA;
        private FontAwesome.Sharp.IconButton btnBasketball;
        private FontAwesome.Sharp.IconButton btnSoccer;
    }
}