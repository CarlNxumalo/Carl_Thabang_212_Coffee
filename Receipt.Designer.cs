
namespace Carl_Thabang_212_Coffee
{
    partial class Receipt
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
            this.lstReceipt = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstReceipt
            // 
            this.lstReceipt.FormattingEnabled = true;
            this.lstReceipt.ItemHeight = 16;
            this.lstReceipt.Location = new System.Drawing.Point(218, 31);
            this.lstReceipt.Name = "lstReceipt";
            this.lstReceipt.Size = new System.Drawing.Size(294, 388);
            this.lstReceipt.TabIndex = 0;
            // 
            // Receipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(176)))), ((int)(((byte)(148)))));
            this.ClientSize = new System.Drawing.Size(774, 497);
            this.Controls.Add(this.lstReceipt);
            this.Name = "Receipt";
            this.Text = "Receipt";
            this.Load += new System.EventHandler(this.Receipt_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstReceipt;
    }
}