namespace GUI
{
    partial class frm_Print
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
            rtbInvoice = new RichTextBox();
            SuspendLayout();
            // 
            // rtbInvoice
            // 
            rtbInvoice.Dock = DockStyle.Fill;
            rtbInvoice.Location = new Point(0, 0);
            rtbInvoice.Name = "rtbInvoice";
            rtbInvoice.Size = new Size(840, 633);
            rtbInvoice.TabIndex = 0;
            rtbInvoice.Text = "";
            // 
            // frm_Print
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(840, 633);
            Controls.Add(rtbInvoice);
            Name = "frm_Print";
            Text = "frm_Print";
            Load += frm_Print_Load;
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox rtbInvoice;
    }
}