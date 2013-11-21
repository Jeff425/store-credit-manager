/* Author: Jeff Goodhue
 * Date: September 2013
 * 
 * This window is to add a new customer to the database
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StoreCreditManager
{
    public partial class NewCustDialog : Form
    {
        bool first = false, middle = false, last = false, DCI = false;
        public NewCustDialog()
        {
            InitializeComponent();
        }

        //Centers the create button when the window loads
        private void NewCustDialog_Load(object sender, EventArgs e)
        {
            CreateButton.SetBounds((this.Width >> 1) - (CreateButton.Width >> 1), CreateButton.Location.Y, CreateButton.Width, CreateButton.Height);
        }

        //These next functions are to make it more obvious what the user is suppose to do
        //They simply place default text when not focused, and clears when they become focused if the default text was in the textbox
        private void FirstText_Enter(object sender, EventArgs e)
        {
            if (!first)
            {
                first = true;
                FirstText.Text = "";
                FirstText.ForeColor = Color.Black;
            }
        }

        private void MiddleText_Enter(object sender, EventArgs e)
        {
            if (!middle)
            {
                middle = true;
                MiddleText.Text = "";
                MiddleText.ForeColor = Color.Black;
                MiddleText.MaxLength = 1;
            }
        }

        private void LastText_Enter(object sender, EventArgs e)
        {
            if (!last)
            {
                last = true;
                LastText.Text = "";
                LastText.ForeColor = Color.Black;
            }
        }

        private void DCIText_Enter(object sender, EventArgs e)
        {
            if (!DCI)
            {
                DCI = true;
                DCIText.Text = "";
                DCIText.ForeColor = Color.Black;
                DCIText.Mask = "0000-000-000";
                DCIText.Select(0, 0);
            }
        }

        private void InitText_Enter(object sender, EventArgs e)
        {
            InitText.Text = "";
        }

        private void FirstText_Leave(object sender, EventArgs e)
        {
            if (FirstText.Text == "")
            {
                first = false;
                FirstText.Text = "First Name";
                FirstText.ForeColor = Color.Gray;
            }
            else
            {
                FirstText.Text.Replace(" ", "");
                FirstText.Text.Replace(",", "");
            }
        }

        private void MiddleText_Leave(object sender, EventArgs e)
        {
            if (MiddleText.Text == "")
            {
                middle = false;
                MiddleText.MaxLength = 4;
                MiddleText.Text = "M.I.";
                MiddleText.ForeColor = Color.Gray;
            }
            
        }

        private void LastText_Leave(object sender, EventArgs e)
        {
            if (LastText.Text == "")
            {
                last = false;
                LastText.Text = "Last Name";
                LastText.ForeColor = Color.Gray;
            }
            else
            {
                LastText.Text.Replace(" ", "");
                LastText.Text.Replace(",", "");
            }
        }

        private void DCIText_Leave(object sender, EventArgs e)
        {
            if (DCIText.Text.Trim(' ', '-') == "")
            {
                DCI = false;
                DCIText.Mask = "";
                DCIText.Text = "DCI Number";
                DCIText.ForeColor = Color.Gray;
            }
        }

        private void InitText_Leave(object sender, EventArgs e)
        {
            Decimal val;
            if (Decimal.TryParse(InitText.Text, out val))
            {
                InitText.Text = val.ToString("C");
            }
            else
            {
                InitText.Text = "$0.00";
            }
        }

        private void DCIText_Click(object sender, EventArgs e)
        {
            if (DCIText.Text.Trim(' ', '-') == "")
            {
                DCIText.Select(0, 0);
            }
        }

        private void pText_Enter(object sender, EventArgs e)
        {
            pText.Text = "";
        }

        private void pText_Leave(object sender, EventArgs e)
        {
            Decimal val;
            if (Decimal.TryParse(pText.Text, out val))
            {
                pText.Text = val.ToString("C");
            }
            else
            {
                pText.Text = "$0.00";
            }
        }

        //Adds the customer to the database given the information
        private void CreateButton_Click(object sender, EventArgs e)
        {
            //The database needs a first and last name, so the function will not continue
            if (!first || !last)
            {
                MessageBox.Show("Please Enter a First and Last name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Create a customer object with a new transaction history
            Customer nCust = new Customer();
            nCust.history = new List<Transaction>();

            //Create a first time transaction
            Transaction initTrans = new Transaction();

            //Sets the customer's name
            nCust.first = FirstText.Text;
            nCust.last = LastText.Text;

            //Adds optional information
            if (middle)
                nCust.middle = MiddleText.Text;
            if (DCI)
                nCust.DCINum = DCIText.Text;
            else
                nCust.DCINum = "N/A";

            //Gets the starting credit and current time
            Decimal.TryParse(InitText.Text.Remove(0, 1), out nCust.credit);
            Decimal.TryParse(pText.Text.Remove(0, 1), out nCust.promo);
            initTrans.date = DateTime.Now;

            //Sets the reason for the intial transaction
            initTrans.reason = "Created Account - C: " + nCust.credit.ToString("C") + " P: " + nCust.promo.ToString("C");
            initTrans.type = Transaction.Seperation.newCustomer;
            initTrans.amount = "";

            //Adds the transaction to the customer's history
            nCust.history.Add(initTrans);

            //Loads the database
            List<Customer> custList = MainWin.load();

            //Adds the customer to the database
            custList.Add(nCust);

            //Sorts the database to be alphabetical
            custList.Sort(delegate(Customer c1, Customer c2) { return c1.last.CompareTo(c2.last); });

            //Saves the database
            MainWin.save(custList);

            //Process was okay
            DialogResult = DialogResult.OK;

            //Close the window
            this.Close();
        }
    }
}
