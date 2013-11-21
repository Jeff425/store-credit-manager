namespace StoreCreditManager
{
    partial class History
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
            this.HistBox = new System.Windows.Forms.ListBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.DCILabel = new System.Windows.Forms.Label();
            this.CreditLabel = new System.Windows.Forms.Label();
            this.PromoLabel = new System.Windows.Forms.Label();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.SpentLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // HistBox
            // 
            this.HistBox.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HistBox.FormattingEnabled = true;
            this.HistBox.ItemHeight = 14;
            this.HistBox.Location = new System.Drawing.Point(12, 117);
            this.HistBox.Name = "HistBox";
            this.HistBox.Size = new System.Drawing.Size(489, 452);
            this.HistBox.TabIndex = 0;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(12, 13);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "label1";
            // 
            // DCILabel
            // 
            this.DCILabel.AutoSize = true;
            this.DCILabel.Location = new System.Drawing.Point(466, 13);
            this.DCILabel.Name = "DCILabel";
            this.DCILabel.Size = new System.Drawing.Size(35, 13);
            this.DCILabel.TabIndex = 2;
            this.DCILabel.Text = "label1";
            this.DCILabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // CreditLabel
            // 
            this.CreditLabel.AutoSize = true;
            this.CreditLabel.Location = new System.Drawing.Point(12, 43);
            this.CreditLabel.Name = "CreditLabel";
            this.CreditLabel.Size = new System.Drawing.Size(35, 13);
            this.CreditLabel.TabIndex = 3;
            this.CreditLabel.Text = "label1";
            // 
            // PromoLabel
            // 
            this.PromoLabel.AutoSize = true;
            this.PromoLabel.Location = new System.Drawing.Point(12, 65);
            this.PromoLabel.Name = "PromoLabel";
            this.PromoLabel.Size = new System.Drawing.Size(35, 13);
            this.PromoLabel.TabIndex = 4;
            this.PromoLabel.Text = "label2";
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Location = new System.Drawing.Point(12, 87);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(35, 13);
            this.TotalLabel.TabIndex = 5;
            this.TotalLabel.Text = "label3";
            // 
            // SpentLabel
            // 
            this.SpentLabel.AutoSize = true;
            this.SpentLabel.Location = new System.Drawing.Point(466, 43);
            this.SpentLabel.Name = "SpentLabel";
            this.SpentLabel.Size = new System.Drawing.Size(35, 13);
            this.SpentLabel.TabIndex = 6;
            this.SpentLabel.Text = "label4";
            // 
            // History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 593);
            this.Controls.Add(this.SpentLabel);
            this.Controls.Add(this.TotalLabel);
            this.Controls.Add(this.PromoLabel);
            this.Controls.Add(this.CreditLabel);
            this.Controls.Add(this.DCILabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.HistBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "History";
            this.Text = "History";
            this.Load += new System.EventHandler(this.History_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox HistBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label DCILabel;
        private System.Windows.Forms.Label CreditLabel;
        private System.Windows.Forms.Label PromoLabel;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.Label SpentLabel;
    }
}