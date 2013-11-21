namespace StoreCreditManager
{
    partial class NewCustDialog
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
            this.FirstText = new System.Windows.Forms.TextBox();
            this.MiddleText = new System.Windows.Forms.TextBox();
            this.LastText = new System.Windows.Forms.TextBox();
            this.DCIText = new System.Windows.Forms.MaskedTextBox();
            this.InitText = new System.Windows.Forms.TextBox();
            this.initAmtLabel = new System.Windows.Forms.Label();
            this.reqLabel1 = new System.Windows.Forms.Label();
            this.reqLabel2 = new System.Windows.Forms.Label();
            this.CreateButton = new System.Windows.Forms.Button();
            this.ReqFieldLabel = new System.Windows.Forms.Label();
            this.pLabel = new System.Windows.Forms.Label();
            this.pText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // FirstText
            // 
            this.FirstText.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.FirstText.Location = new System.Drawing.Point(13, 13);
            this.FirstText.Name = "FirstText";
            this.FirstText.Size = new System.Drawing.Size(168, 20);
            this.FirstText.TabIndex = 1;
            this.FirstText.Text = "First Name";
            this.FirstText.Enter += new System.EventHandler(this.FirstText_Enter);
            this.FirstText.Leave += new System.EventHandler(this.FirstText_Leave);
            // 
            // MiddleText
            // 
            this.MiddleText.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.MiddleText.Location = new System.Drawing.Point(204, 13);
            this.MiddleText.Name = "MiddleText";
            this.MiddleText.Size = new System.Drawing.Size(23, 20);
            this.MiddleText.TabIndex = 2;
            this.MiddleText.Text = "M.I.";
            this.MiddleText.Enter += new System.EventHandler(this.MiddleText_Enter);
            this.MiddleText.Leave += new System.EventHandler(this.MiddleText_Leave);
            // 
            // LastText
            // 
            this.LastText.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.LastText.Location = new System.Drawing.Point(233, 13);
            this.LastText.Name = "LastText";
            this.LastText.Size = new System.Drawing.Size(180, 20);
            this.LastText.TabIndex = 3;
            this.LastText.Text = "Last Name";
            this.LastText.Enter += new System.EventHandler(this.LastText_Enter);
            this.LastText.Leave += new System.EventHandler(this.LastText_Leave);
            // 
            // DCIText
            // 
            this.DCIText.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.DCIText.Location = new System.Drawing.Point(13, 40);
            this.DCIText.Name = "DCIText";
            this.DCIText.Size = new System.Drawing.Size(214, 20);
            this.DCIText.TabIndex = 4;
            this.DCIText.Text = "DCI Number";
            this.DCIText.Click += new System.EventHandler(this.DCIText_Click);
            this.DCIText.Enter += new System.EventHandler(this.DCIText_Enter);
            this.DCIText.Leave += new System.EventHandler(this.DCIText_Leave);
            // 
            // InitText
            // 
            this.InitText.Location = new System.Drawing.Point(276, 40);
            this.InitText.Name = "InitText";
            this.InitText.Size = new System.Drawing.Size(158, 20);
            this.InitText.TabIndex = 5;
            this.InitText.Text = "$0.00";
            this.InitText.Enter += new System.EventHandler(this.InitText_Enter);
            this.InitText.Leave += new System.EventHandler(this.InitText_Leave);
            // 
            // initAmtLabel
            // 
            this.initAmtLabel.AutoSize = true;
            this.initAmtLabel.Location = new System.Drawing.Point(233, 43);
            this.initAmtLabel.Name = "initAmtLabel";
            this.initAmtLabel.Size = new System.Drawing.Size(37, 13);
            this.initAmtLabel.TabIndex = 5;
            this.initAmtLabel.Text = "Credit:";
            // 
            // reqLabel1
            // 
            this.reqLabel1.AutoSize = true;
            this.reqLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reqLabel1.Location = new System.Drawing.Point(187, 9);
            this.reqLabel1.Name = "reqLabel1";
            this.reqLabel1.Size = new System.Drawing.Size(15, 18);
            this.reqLabel1.TabIndex = 6;
            this.reqLabel1.Text = "*";
            // 
            // reqLabel2
            // 
            this.reqLabel2.AutoSize = true;
            this.reqLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reqLabel2.Location = new System.Drawing.Point(419, 9);
            this.reqLabel2.Name = "reqLabel2";
            this.reqLabel2.Size = new System.Drawing.Size(15, 18);
            this.reqLabel2.TabIndex = 7;
            this.reqLabel2.Text = "*";
            // 
            // CreateButton
            // 
            this.CreateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateButton.Location = new System.Drawing.Point(141, 98);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(156, 57);
            this.CreateButton.TabIndex = 0;
            this.CreateButton.Text = "Create Customer";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // ReqFieldLabel
            // 
            this.ReqFieldLabel.AutoSize = true;
            this.ReqFieldLabel.Location = new System.Drawing.Point(343, 145);
            this.ReqFieldLabel.Name = "ReqFieldLabel";
            this.ReqFieldLabel.Size = new System.Drawing.Size(91, 13);
            this.ReqFieldLabel.TabIndex = 9;
            this.ReqFieldLabel.Text = "* = Required Field";
            // 
            // pLabel
            // 
            this.pLabel.AutoSize = true;
            this.pLabel.Location = new System.Drawing.Point(233, 70);
            this.pLabel.Name = "pLabel";
            this.pLabel.Size = new System.Drawing.Size(40, 13);
            this.pLabel.TabIndex = 10;
            this.pLabel.Text = "Promo:";
            // 
            // pText
            // 
            this.pText.Location = new System.Drawing.Point(276, 67);
            this.pText.Name = "pText";
            this.pText.Size = new System.Drawing.Size(158, 20);
            this.pText.TabIndex = 11;
            this.pText.Text = "$0.00";
            this.pText.Enter += new System.EventHandler(this.pText_Enter);
            this.pText.Leave += new System.EventHandler(this.pText_Leave);
            // 
            // NewCustDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 167);
            this.Controls.Add(this.pText);
            this.Controls.Add(this.pLabel);
            this.Controls.Add(this.ReqFieldLabel);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.reqLabel2);
            this.Controls.Add(this.reqLabel1);
            this.Controls.Add(this.initAmtLabel);
            this.Controls.Add(this.InitText);
            this.Controls.Add(this.DCIText);
            this.Controls.Add(this.LastText);
            this.Controls.Add(this.MiddleText);
            this.Controls.Add(this.FirstText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewCustDialog";
            this.Text = "New Customer";
            this.Load += new System.EventHandler(this.NewCustDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FirstText;
        private System.Windows.Forms.TextBox MiddleText;
        private System.Windows.Forms.TextBox LastText;
        private System.Windows.Forms.MaskedTextBox DCIText;
        private System.Windows.Forms.TextBox InitText;
        private System.Windows.Forms.Label initAmtLabel;
        private System.Windows.Forms.Label reqLabel1;
        private System.Windows.Forms.Label reqLabel2;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.Label ReqFieldLabel;
        private System.Windows.Forms.Label pLabel;
        private System.Windows.Forms.TextBox pText;
    }
}