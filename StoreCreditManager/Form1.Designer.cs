namespace StoreCreditManager
{
    partial class MainWin
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.SearchText = new System.Windows.Forms.TextBox();
            this.HistoryButton = new System.Windows.Forms.Button();
            this.NewCustButton = new System.Windows.Forms.Button();
            this.AmtLabel = new System.Windows.Forms.Label();
            this.AmtButton = new System.Windows.Forms.Button();
            this.AddLabel = new System.Windows.Forms.Label();
            this.CreditRadio = new System.Windows.Forms.RadioButton();
            this.PlaceRadio = new System.Windows.Forms.RadioButton();
            this.Top2Radio = new System.Windows.Forms.RadioButton();
            this.Top4Radio = new System.Windows.Forms.RadioButton();
            this.Top8Radio = new System.Windows.Forms.RadioButton();
            this.CustomRadio = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.PurchaseRadio = new System.Windows.Forms.RadioButton();
            this.EntryRadio = new System.Windows.Forms.RadioButton();
            this.CustomReRadio = new System.Windows.Forms.RadioButton();
            this.CustomReText = new System.Windows.Forms.TextBox();
            this.CustomText = new System.Windows.Forms.TextBox();
            this.AmtTxt = new System.Windows.Forms.TextBox();
            this.CustView = new System.Windows.Forms.ListView();
            this.PlacedNum = new System.Windows.Forms.NumericUpDown();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlacedNum)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(634, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "ManagerMenu";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printToolStripMenuItem,
            this.importToolStripMenuItem,
            this.exportToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.importToolStripMenuItem.Text = "Import";
            this.importToolStripMenuItem.Click += new System.EventHandler(this.importToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exportToolStripMenuItem.Text = "Export";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewHelpToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // viewHelpToolStripMenuItem
            // 
            this.viewHelpToolStripMenuItem.Name = "viewHelpToolStripMenuItem";
            this.viewHelpToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.viewHelpToolStripMenuItem.Text = "View Help";
            this.viewHelpToolStripMenuItem.Click += new System.EventHandler(this.viewHelpToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Location = new System.Drawing.Point(10, 29);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(44, 13);
            this.SearchLabel.TabIndex = 1;
            this.SearchLabel.Text = "Search:";
            // 
            // SearchText
            // 
            this.SearchText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchText.Location = new System.Drawing.Point(61, 28);
            this.SearchText.Name = "SearchText";
            this.SearchText.Size = new System.Drawing.Size(227, 20);
            this.SearchText.TabIndex = 3;
            this.SearchText.TextChanged += new System.EventHandler(this.SearchText_TextChanged);
            // 
            // HistoryButton
            // 
            this.HistoryButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.HistoryButton.Location = new System.Drawing.Point(13, 402);
            this.HistoryButton.Name = "HistoryButton";
            this.HistoryButton.Size = new System.Drawing.Size(132, 23);
            this.HistoryButton.TabIndex = 4;
            this.HistoryButton.Text = "View History";
            this.HistoryButton.UseVisualStyleBackColor = true;
            this.HistoryButton.Click += new System.EventHandler(this.HistoryButton_Click);
            // 
            // NewCustButton
            // 
            this.NewCustButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.NewCustButton.Location = new System.Drawing.Point(151, 402);
            this.NewCustButton.Name = "NewCustButton";
            this.NewCustButton.Size = new System.Drawing.Size(137, 23);
            this.NewCustButton.TabIndex = 5;
            this.NewCustButton.Text = "New Customer";
            this.NewCustButton.UseVisualStyleBackColor = true;
            this.NewCustButton.Click += new System.EventHandler(this.NewCustButton_Click);
            // 
            // AmtLabel
            // 
            this.AmtLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AmtLabel.AutoSize = true;
            this.AmtLabel.Location = new System.Drawing.Point(305, 407);
            this.AmtLabel.Name = "AmtLabel";
            this.AmtLabel.Size = new System.Drawing.Size(46, 13);
            this.AmtLabel.TabIndex = 6;
            this.AmtLabel.Text = "Amount:";
            // 
            // AmtButton
            // 
            this.AmtButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AmtButton.Location = new System.Drawing.Point(547, 403);
            this.AmtButton.Name = "AmtButton";
            this.AmtButton.Size = new System.Drawing.Size(75, 23);
            this.AmtButton.TabIndex = 7;
            this.AmtButton.Text = "Apply";
            this.AmtButton.UseVisualStyleBackColor = true;
            this.AmtButton.Click += new System.EventHandler(this.AmtButton_Click);
            // 
            // AddLabel
            // 
            this.AddLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddLabel.AutoSize = true;
            this.AddLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddLabel.Location = new System.Drawing.Point(294, 39);
            this.AddLabel.Name = "AddLabel";
            this.AddLabel.Size = new System.Drawing.Size(84, 20);
            this.AddLabel.TabIndex = 9;
            this.AddLabel.Text = "Add Credit";
            // 
            // CreditRadio
            // 
            this.CreditRadio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CreditRadio.AutoSize = true;
            this.CreditRadio.Checked = true;
            this.CreditRadio.Location = new System.Drawing.Point(308, 63);
            this.CreditRadio.Name = "CreditRadio";
            this.CreditRadio.Size = new System.Drawing.Size(94, 17);
            this.CreditRadio.TabIndex = 10;
            this.CreditRadio.TabStop = true;
            this.CreditRadio.Text = "Trade-in Credit";
            this.CreditRadio.UseVisualStyleBackColor = true;
            // 
            // PlaceRadio
            // 
            this.PlaceRadio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PlaceRadio.AutoSize = true;
            this.PlaceRadio.Location = new System.Drawing.Point(308, 86);
            this.PlaceRadio.Name = "PlaceRadio";
            this.PlaceRadio.Size = new System.Drawing.Size(61, 17);
            this.PlaceRadio.TabIndex = 11;
            this.PlaceRadio.Text = "Placed:";
            this.PlaceRadio.UseVisualStyleBackColor = true;
            this.PlaceRadio.CheckedChanged += new System.EventHandler(this.PlaceRadio_CheckedChanged);
            // 
            // Top2Radio
            // 
            this.Top2Radio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Top2Radio.AutoSize = true;
            this.Top2Radio.Location = new System.Drawing.Point(308, 109);
            this.Top2Radio.Name = "Top2Radio";
            this.Top2Radio.Size = new System.Drawing.Size(53, 17);
            this.Top2Radio.TabIndex = 12;
            this.Top2Radio.TabStop = true;
            this.Top2Radio.Text = "Top 2";
            this.Top2Radio.UseVisualStyleBackColor = true;
            // 
            // Top4Radio
            // 
            this.Top4Radio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Top4Radio.AutoSize = true;
            this.Top4Radio.Location = new System.Drawing.Point(308, 132);
            this.Top4Radio.Name = "Top4Radio";
            this.Top4Radio.Size = new System.Drawing.Size(53, 17);
            this.Top4Radio.TabIndex = 13;
            this.Top4Radio.TabStop = true;
            this.Top4Radio.Text = "Top 4";
            this.Top4Radio.UseVisualStyleBackColor = true;
            // 
            // Top8Radio
            // 
            this.Top8Radio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Top8Radio.AutoSize = true;
            this.Top8Radio.Location = new System.Drawing.Point(308, 155);
            this.Top8Radio.Name = "Top8Radio";
            this.Top8Radio.Size = new System.Drawing.Size(53, 17);
            this.Top8Radio.TabIndex = 14;
            this.Top8Radio.TabStop = true;
            this.Top8Radio.Text = "Top 8";
            this.Top8Radio.UseVisualStyleBackColor = true;
            // 
            // CustomRadio
            // 
            this.CustomRadio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomRadio.AutoSize = true;
            this.CustomRadio.Location = new System.Drawing.Point(308, 178);
            this.CustomRadio.Name = "CustomRadio";
            this.CustomRadio.Size = new System.Drawing.Size(63, 17);
            this.CustomRadio.TabIndex = 15;
            this.CustomRadio.Text = "Custom:";
            this.CustomRadio.UseVisualStyleBackColor = true;
            this.CustomRadio.CheckedChanged += new System.EventHandler(this.CustomRadio_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(294, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Remove Credit";
            // 
            // PurchaseRadio
            // 
            this.PurchaseRadio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PurchaseRadio.AutoSize = true;
            this.PurchaseRadio.Location = new System.Drawing.Point(308, 238);
            this.PurchaseRadio.Name = "PurchaseRadio";
            this.PurchaseRadio.Size = new System.Drawing.Size(70, 17);
            this.PurchaseRadio.TabIndex = 17;
            this.PurchaseRadio.TabStop = true;
            this.PurchaseRadio.Text = "Purchase";
            this.PurchaseRadio.UseVisualStyleBackColor = true;
            // 
            // EntryRadio
            // 
            this.EntryRadio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EntryRadio.AutoSize = true;
            this.EntryRadio.Location = new System.Drawing.Point(308, 262);
            this.EntryRadio.Name = "EntryRadio";
            this.EntryRadio.Size = new System.Drawing.Size(70, 17);
            this.EntryRadio.TabIndex = 18;
            this.EntryRadio.TabStop = true;
            this.EntryRadio.Text = "Entry Fee";
            this.EntryRadio.UseVisualStyleBackColor = true;
            // 
            // CustomReRadio
            // 
            this.CustomReRadio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomReRadio.AutoSize = true;
            this.CustomReRadio.Location = new System.Drawing.Point(308, 286);
            this.CustomReRadio.Name = "CustomReRadio";
            this.CustomReRadio.Size = new System.Drawing.Size(63, 17);
            this.CustomReRadio.TabIndex = 19;
            this.CustomReRadio.Text = "Custom:";
            this.CustomReRadio.UseVisualStyleBackColor = true;
            this.CustomReRadio.CheckedChanged += new System.EventHandler(this.CustomReRadio_CheckedChanged);
            // 
            // CustomReText
            // 
            this.CustomReText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomReText.Enabled = false;
            this.CustomReText.Location = new System.Drawing.Point(377, 286);
            this.CustomReText.Name = "CustomReText";
            this.CustomReText.Size = new System.Drawing.Size(245, 20);
            this.CustomReText.TabIndex = 20;
            // 
            // CustomText
            // 
            this.CustomText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomText.Enabled = false;
            this.CustomText.Location = new System.Drawing.Point(378, 178);
            this.CustomText.Name = "CustomText";
            this.CustomText.Size = new System.Drawing.Size(244, 20);
            this.CustomText.TabIndex = 21;
            // 
            // AmtTxt
            // 
            this.AmtTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AmtTxt.Location = new System.Drawing.Point(357, 405);
            this.AmtTxt.Name = "AmtTxt";
            this.AmtTxt.Size = new System.Drawing.Size(184, 20);
            this.AmtTxt.TabIndex = 23;
            this.AmtTxt.Text = "$0.00";
            this.AmtTxt.Enter += new System.EventHandler(this.AmtTxt_Enter);
            this.AmtTxt.Leave += new System.EventHandler(this.AmtTxt_Leave);
            // 
            // CustView
            // 
            this.CustView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.CustView.FullRowSelect = true;
            this.CustView.HideSelection = false;
            this.CustView.Location = new System.Drawing.Point(13, 54);
            this.CustView.MultiSelect = false;
            this.CustView.Name = "CustView";
            this.CustView.Size = new System.Drawing.Size(275, 342);
            this.CustView.TabIndex = 24;
            this.CustView.UseCompatibleStateImageBehavior = false;
            // 
            // PlacedNum
            // 
            this.PlacedNum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PlacedNum.Enabled = false;
            this.PlacedNum.Location = new System.Drawing.Point(376, 86);
            this.PlacedNum.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.PlacedNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PlacedNum.Name = "PlacedNum";
            this.PlacedNum.Size = new System.Drawing.Size(246, 20);
            this.PlacedNum.TabIndex = 25;
            this.PlacedNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.printToolStripMenuItem.Text = "Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // MainWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 437);
            this.Controls.Add(this.PlacedNum);
            this.Controls.Add(this.CustView);
            this.Controls.Add(this.AmtTxt);
            this.Controls.Add(this.CustomText);
            this.Controls.Add(this.CustomReText);
            this.Controls.Add(this.CustomReRadio);
            this.Controls.Add(this.EntryRadio);
            this.Controls.Add(this.PurchaseRadio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CustomRadio);
            this.Controls.Add(this.Top8Radio);
            this.Controls.Add(this.Top4Radio);
            this.Controls.Add(this.Top2Radio);
            this.Controls.Add(this.PlaceRadio);
            this.Controls.Add(this.CreditRadio);
            this.Controls.Add(this.AddLabel);
            this.Controls.Add(this.AmtButton);
            this.Controls.Add(this.AmtLabel);
            this.Controls.Add(this.NewCustButton);
            this.Controls.Add(this.HistoryButton);
            this.Controls.Add(this.SearchText);
            this.Controls.Add(this.SearchLabel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(650, 475);
            this.Name = "MainWin";
            this.ShowIcon = false;
            this.Text = "Store Credit Manager";
            this.Load += new System.EventHandler(this.MainWin_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlacedNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label SearchLabel;
        private System.Windows.Forms.TextBox SearchText;
        private System.Windows.Forms.Button HistoryButton;
        private System.Windows.Forms.Button NewCustButton;
        private System.Windows.Forms.Label AmtLabel;
        private System.Windows.Forms.Button AmtButton;
        private System.Windows.Forms.Label AddLabel;
        private System.Windows.Forms.RadioButton CreditRadio;
        private System.Windows.Forms.RadioButton PlaceRadio;
        private System.Windows.Forms.RadioButton Top2Radio;
        private System.Windows.Forms.RadioButton Top4Radio;
        private System.Windows.Forms.RadioButton Top8Radio;
        private System.Windows.Forms.RadioButton CustomRadio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton PurchaseRadio;
        private System.Windows.Forms.RadioButton EntryRadio;
        private System.Windows.Forms.RadioButton CustomReRadio;
        private System.Windows.Forms.TextBox CustomReText;
        private System.Windows.Forms.TextBox CustomText;
        private System.Windows.Forms.TextBox AmtTxt;
        private System.Windows.Forms.ToolStripMenuItem viewHelpToolStripMenuItem;
        private System.Windows.Forms.ListView CustView;
        private System.Windows.Forms.NumericUpDown PlacedNum;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
    }
}

