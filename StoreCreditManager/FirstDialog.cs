using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Microsoft.Win32;

namespace StoreCreditManager
{
    public partial class FirstDialog : Form
    {
        string filepath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\CreditManager\";
        string filename = "currentDatabase.scb";

        public FirstDialog()
        {
            InitializeComponent();
        }

        private void FirstDialog_Load(object sender, EventArgs e)
        {
            msgLabel.Text = "Hello! It seems that this is the first time you have used this program. \n Would you like to create a new database or import a new one?";
            CreateButton.SetBounds((this.Width >> 1) - CreateButton.Width - 10, this.Height - CreateButton.Height - 5, CreateButton.Width, CreateButton.Height);
            ImportButton.SetBounds((this.Width >> 1) + 10, CreateButton.Location.Y, ImportButton.Width, ImportButton.Height);
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            File.Create(filepath + filename).Close();
            List<Customer> custList = new List<Customer>();
            MainWin.save(custList);
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void ImportButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.FileName = "database.scb";
            dlg.DefaultExt = ".scb";
            dlg.Filter = "Manager Database (.scb)|*.scb";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                File.Copy(dlg.FileName, filepath + filename, true);
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
