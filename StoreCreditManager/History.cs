/* Author: Jeff Goodhue
 * Date: September 2013
 * 
 * This window is to view the customer's history
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
    public partial class History : Form
    {
        //For alignment in the transaction history list
        const int LEN = 69;

        //Customer to view history
        private Customer cust = null;
        public History(Customer customer)
        {
            InitializeComponent();
            cust = customer;
        }

        //Gets and Sets for customer
        public void setCustomer(Customer customer)
        {
            cust = customer;
        }

        public Customer getCustomer()
        {
            return cust;
        }

        //Loads the customer's information into the window
        private void History_Load(object sender, EventArgs e)
        {
            //If the customer is null, then close the window
            if (cust == null)
            {
                this.Close();
            }

            //Change's the title of the window and the name
            this.Text = cust.first + " " + cust.last + "'s history";

            //Add's the customer's information to the window
            nameLabel.Text = "Name: " + cust.first + " ";
            if (cust.middle != "")
                nameLabel.Text += cust.middle + ". ";
            nameLabel.Text += cust.last;
            DCILabel.Text = "DCI #: " + cust.DCINum;
            DCILabel.SetBounds(this.Width - DCILabel.Width - 12, DCILabel.Location.Y, DCILabel.Width, DCILabel.Height);
            CreditLabel.Text = "Credit: " + cust.credit.ToString("C");
            PromoLabel.Text = "Promo Credit: " + cust.promo.ToString("C");
            SpentLabel.Text = "Spent: " + cust.spent.ToString("C");
            SpentLabel.SetBounds(this.Width - SpentLabel.Width - 12, SpentLabel.Location.Y, SpentLabel.Width, SpentLabel.Height);
            TotalLabel.Text = "Remaining Credit: " + (cust.credit + cust.promo - cust.spent).ToString("C");

            //Loads the transaction history of the customer to the list
            foreach (Transaction trans in cust.history)
            {
                string data = trans.date.Month + "/" + trans.date.Day + "/" + trans.date.Year + "; " + trans.date.Hour + ":" + trans.date.Minute;
                data += " -- " + trans.reason;
                int size = LEN - trans.amount.Length - data.Length;
                for (int i = 0; i < size; i++)
                {
                    data += " ";
                }
                data += trans.amount;
                HistBox.Items.Add(data);
            }
        }
    }
}
