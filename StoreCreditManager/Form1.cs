/* Author: Jeff Goodhue
 * Date: September 2013
 * 
 * The main window where the program loads
 * This program loads and saves to the file after EACH operation, so there is no need for a "save" button.
 * This is to avoid problems coming up if the program were to ever crash
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Diagnostics;
using System.Reflection;
using System.Drawing.Printing;

namespace StoreCreditManager
{

    public partial class MainWin : Form
    {
        //Default file path is a new folder created in "My Documents"
        static string filepath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\CreditManager\";

        //Default file name. This file should never be moved
        const string filename = "currentDatabase.scb";
        
        //Global variables for printing; pIndex: the current customer being printed, pCount: the current page being printed.
        int pIndex = 0;
        int pCount = 0;
       
        public MainWin()
        {
            InitializeComponent();
        }

        //Loads the database if it exists, otherwise create the file file and folder
        private void MainWin_Load(object sender, EventArgs e)
        {
            //Create database and folder if they do not exist
            
            if (!File.Exists(filepath + filename))
            {
                if (!Directory.Exists(filepath))
                {

                    DirectoryInfo di = Directory.CreateDirectory(filepath);
                    //Make the folder hidden
                    di.Attributes = FileAttributes.Directory | FileAttributes.Hidden;

                }
                FirstDialog dialog = new FirstDialog();
                if (dialog.ShowDialog() == DialogResult.Cancel)
                    this.Close();
            }
            //Sets the title to the version number
            this.Text = "Store Credit Manager " + FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).FileVersion;

            //loads the database to the window
            setUpList();
        }

        //Called when the user loses focus of the price textbox.
        //Formats the textbox into standard USD format.
        private void AmtTxt_Leave(object sender, EventArgs e)
        {
            Decimal val;
            if (Decimal.TryParse(AmtTxt.Text, out val))
            {
                AmtTxt.Text = val.ToString("C");
            }
            else
            {
                AmtTxt.Text = "$0.00";
            }
        }

        //Switches the usability of the place textbox and sets the value to 1st
        private void PlaceRadio_CheckedChanged(object sender, EventArgs e)
        {
            PlacedNum.Enabled = !PlacedNum.Enabled;
            PlacedNum.Value = 1;
        }

        //Switches the usability of the Custom reason textbox and sets the value to null
        private void CustomRadio_CheckedChanged(object sender, EventArgs e)
        {
            CustomText.Enabled = !CustomText.Enabled;
            CustomText.Text = "";
        }

        //Switches the usability of the Custom reason deduction textbox and sets the value to null
        private void CustomReRadio_CheckedChanged(object sender, EventArgs e)
        {
            CustomReText.Enabled = !CustomReText.Enabled;
            CustomReText.Text = "";
        }

        //Returns the list containing all the customer data
        static public List<Customer> load()
        {
            //Gets the path to the database
            string path = filepath + filename;

            //Creates a file reader. The database is saved in binary, not XML
            BinaryFormatter formatter = new BinaryFormatter();

            //Loads the file to a filestream
            FileStream inFile = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read);

            //Reads the file and saves it to a customer list
            List<Customer> custList = (List<Customer>)formatter.Deserialize(inFile);

            //Closes the stream
            inFile.Close();

            //Return the customer list
            return custList;
        }

        //Saves the list containing all the customer data
        static public void save(List<Customer> custList) {
            //Gets the path to the database
            string path = filepath + filename;

            //Creates a file stream to save the list to.
            FileStream outFile = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None);

            //Creates a file writer. The database is saved in binary, not XML.
            BinaryFormatter formatter = new BinaryFormatter();

            //Save the customer list to the file
            formatter.Serialize(outFile, custList);

            //Close the stream
            outFile.Close();
        }

        //Creates another window for the user to add a customer
        private void NewCustButton_Click(object sender, EventArgs e)
        {
            NewCustDialog NewCust = new NewCustDialog();
            NewCust.ShowDialog();

            //If a new customer was successfully created, load the new list.
            if (NewCust.DialogResult == DialogResult.OK)
            {
                setUpList();
            }
        }

        //Clears the textbox when the user focuses on it.
        private void AmtTxt_Enter(object sender, EventArgs e)
        {
            AmtTxt.Text = "";
        }

        //Reads the database and loads it to the list.
        private void setUpList()
        {
            //Retrieves the database
            List<Customer> custList = load();

            //Clears the old list
            CustView.Clear();

            //If the database was empty, we have no more work to do.
            if (custList == null)
                return;

            //Sets up the list to give information about each customer in the neatest way.
            CustView.View = View.Details;
            //Loops through the database
            foreach (Customer cust in custList)
            {
                //Build the customer name to a string
                string name = cust.last + ", " + cust.first;
                if (cust.middle != "")
                    name += " " + cust.middle + ".";

                //Creats an item to be added to the list
                ListViewItem item = new ListViewItem(name);

                //Adds the amount of credit the cusomter has left
                item.SubItems.Add((cust.credit + cust.promo - cust.spent).ToString("C"));
                //Add the customer to the list
                CustView.Items.Add(item);
            }
            //Formats the list to show name and credit in a way that the window can be resized
            CustView.Columns.Add("Name", CustView.Width-70, HorizontalAlignment.Left);
            CustView.Columns.Add("Credit", -2, HorizontalAlignment.Left);
        }


        //Adds the transaction to the customer's history and change's their store credit
        private void AmtButton_Click(object sender, EventArgs e)
        {
            //Create a transaction object
            Transaction trans = new Transaction();
            trans.date = DateTime.Now;

            //Load the customer list
            List<Customer> custList = load();

            //Find what customer the user currently has selected
            int custIndex = getSelectedCustomer(custList);

            //If there was no customer selected, then do nothing
            if (custIndex < 0)
                return;

            //Find what radio button is selected and make the transaction object represent that.

            //If one of these radio buttons are selected, then their store credit is increasing

            //When the customer is selling something to the user
            //This is the only option that adds trade-in credit
            if (CreditRadio.Checked)
            {
                trans.type = Transaction.Seperation.credit;
                trans.reason = "Traded in merchandise";
                trans.amount = AmtTxt.Text;
                custList[custIndex].addCredit(AmtTxt.Text);
            }

            //The rest of the options add promotional credit
            //When the customer placed in a tournament
            else if (PlaceRadio.Checked)
            {
                trans.type = Transaction.Seperation.promo;
                trans.reason = "Came in " + PlacedNum.Value.ToString() + " place";
                trans.amount = AmtTxt.Text;
                custList[custIndex].addPromo(AmtTxt.Text);
            }

            //When the customer split the first and second place prize
            else if (Top2Radio.Checked)
            {
                trans.type = Transaction.Seperation.promo;
                trans.reason = "Top 2";
                trans.amount = AmtTxt.Text;
                custList[custIndex].addPromo(AmtTxt.Text);
            }

            //When the customer split the prize with the top 4
            else if (Top4Radio.Checked)
            {
                trans.type = Transaction.Seperation.promo;
                trans.reason = "Top 4";
                trans.amount = AmtTxt.Text;
                custList[custIndex].addPromo(AmtTxt.Text);
            }

            //When the customer split the prize with the top 8
            else if (Top8Radio.Checked)
            {
                trans.type = Transaction.Seperation.promo;
                trans.reason = "Top 8";
                trans.amount = AmtTxt.Text;
                custList[custIndex].addPromo(AmtTxt.Text);
            }

            //Custom reason
            else if (CustomRadio.Checked)
            {
                trans.type = Transaction.Seperation.promo;
                trans.reason = CustomText.Text;
                trans.amount = AmtTxt.Text;
                custList[custIndex].addPromo(AmtTxt.Text);
            }

            //If one of these radio buttons are selected, then their credit is decreasing

            //If the customer is buying something with their credit
            else if (PurchaseRadio.Checked)
            {
                trans.type = Transaction.Seperation.purchase;
                trans.reason = "Purchased merchandised";
                trans.amount = "-" + AmtTxt.Text;
                custList[custIndex].subCredit(AmtTxt.Text);
            }

            //If the customer is using their credit for an entrance fee
            else if (EntryRadio.Checked)
            {
                trans.type = Transaction.Seperation.purchase;
                trans.reason = "Entry Fee";
                trans.amount = "-" + AmtTxt.Text;
                custList[custIndex].subCredit(AmtTxt.Text);
            }

            //Custom reason for why they lose credit
            else if (CustomReRadio.Checked)
            {
                trans.type = Transaction.Seperation.purchase;
                trans.reason = CustomReText.Text;
                trans.amount = "-" + AmtTxt.Text;
                custList[custIndex].subCredit(AmtTxt.Text);
            }

            //Save the transaction to the customer's history
            custList[custIndex].history.Insert(0, trans);

            //Save the customer list
            save(custList);

            //Load the new list
            setUpList();
        }

        //Returns the currently selected customer's index in the list
        private int getSelectedCustomer(List<Customer> custList)
        {
            //If no customer is selected (or more than one is selected somehow)
            if (CustView.SelectedItems.Count != 1)
                return -1;

            //Gets the customer's name from the list
            string fullName = CustView.SelectedItems[0].SubItems[0].Text;
            
            //Finds the last name of the customer
            string last = fullName.Substring(0, fullName.IndexOf(','));
            string first = "";
            string middle = "";

            //If the customer has a middle name inputted, find both the middle name and first name
            if (fullName.Contains("."))
            {
                middle = fullName[fullName.Length - 2].ToString();
                first = fullName.Substring(fullName.IndexOf(',') + 2, fullName.Length - fullName.IndexOf(',') - 5);
            }
            //Otherwise, just get the first name
            else
                first = fullName.Substring(fullName.IndexOf(',') + 2, fullName.Length - fullName.IndexOf(',') - 2);

            //Compare with the database, and return the customer's index in the database
            return custList.FindIndex(r => (r.first == first && r.middle == middle && r.last == last));

            //This function is needed because of the search bar modifying the list shown. The list and the database might not have the same indexes.
        }

        //Loads the currently selected customer's transaction history
        //Also contains the amount of credit they have spent and earned
        private void HistoryButton_Click(object sender, EventArgs e)
        {
            List<Customer> custList = load();
            int custIndex = getSelectedCustomer(custList);
            if (custIndex < 0)
                return;
            History histWin = new History(custList[custIndex]);
            histWin.ShowDialog();
        }

        //Loads an exported database and replace's the current database.
        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.FileName = "database.scb";
            dlg.DefaultExt = ".scb";
            dlg.Filter = "Manager Database (.scb)|*.scb";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                File.Copy(dlg.FileName, filepath + filename, true);
                setUpList();
            }           
        }

        //File->Close just needs to close the program
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Copies the database to another location, with a time stamp. This allowes for easy back up
        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.FileName = DateTime.Now.Month + "-" + DateTime.Now.Day + "-" + DateTime.Now.Year + " Database.scb";
            dlg.DefaultExt = ".scb";
            dlg.Filter = "Manager Database (.scb)|*.scb";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                File.Copy(filepath + filename, dlg.FileName);
            }
        }

        //Sets the list to only show customers whos last name matches the argument
        //Very similar to the other SetUpList function
        private void setUpList(string lastName)
        {
            List<Customer> custList = load();
            CustView.Clear();
            if (custList == null)
                return;
            CustView.View = View.Details;

            foreach (Customer cust in custList)
            {
                if (cust.last.ToUpper().Contains(lastName.ToUpper()))
                {
                    string name = cust.last + ", " + cust.first;
                    if (cust.middle != "")
                        name += " " + cust.middle + ".";
                    ListViewItem item = new ListViewItem(name);
                    item.SubItems.Add((cust.credit + cust.promo - cust.spent).ToString("C"));
                    CustView.Items.Add(item);
                }
            }
            CustView.Columns.Add("Name", CustView.Width - 70, HorizontalAlignment.Left);
            CustView.Columns.Add("Credit", -2, HorizontalAlignment.Left);
        }

        //Updates the list as the user is typing in the customer's name
        private void SearchText_TextChanged(object sender, EventArgs e)
        {
            setUpList(SearchText.Text);
        }

        //Loads the about window
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }

        //Loads the help menu (When it exists)
        private void viewHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No help document yet! If you have any questions or need to report an error please email me at Goodhue.Jeff@gmail.com");
        }

        //Prints the customer list
        //Only can print to the default printer, using standard 8.5 x 11 paper
        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {          
            //Sets the current page to 0
            pIndex = 0;
            //Sets the page to be displayed on the paper
            pCount = 1;

            //Creates a printer object and prints the page with my function
            PrintDocument pDoc = new PrintDocument();
            pDoc.PrintPage += new PrintPageEventHandler(this.printPage);              
            pDoc.Print();
            
        }

        //Print callback
        private void printPage(object sender, PrintPageEventArgs e) 
        {
            //Loads the database
            List<Customer> custList = load();

            //Sets the font to the List font
            Font font = CustView.Font;

            //How many lines can fit on the page
            float linesPerPage = 0;

            //The current position to print
            float yPos = 0;

            float padding = 10;

            //Current line to print
            int count = 0;

            //margins
            float leftMargin = e.MarginBounds.Left;
            float topMargin = e.MarginBounds.Top;
            float rightMargin = e.MarginBounds.Right;

            //Name and credit of current customer to print
            string name = "";
            string credit = "";

            //Top of the page
            float headY = topMargin / 2;

            //Bottom of the page
            float footY = (e.MarginBounds.Bottom + e.PageBounds.Bottom) / 2;

            //The amount of lines that can fit on the page
            linesPerPage = e.MarginBounds.Height / (font.GetHeight(e.Graphics) + padding);

            //Right alingment print format
            StringFormat cFormat = new StringFormat();
            cFormat.Alignment = StringAlignment.Far;

            //Gets the current date
            DateTime time = DateTime.Now;

            //Writes header and footer the page
            e.Graphics.DrawString("Credit Totals", font, Brushes.Black, rightMargin, headY, cFormat);
            e.Graphics.DrawString(time.Month + "/" + time.Day + "/" + time.Year, font, Brushes.Black, leftMargin, footY, new StringFormat());
            e.Graphics.DrawString("Page " + pCount, font, Brushes.Black, rightMargin, footY, cFormat);

            //Loops through the customers, stops early if no more customers can be printed on the page
            while (count < linesPerPage && pIndex < custList.Count)
            {
                //Sets the current y posistion
                yPos = topMargin + (count * (font.GetHeight(e.Graphics) + padding));

                //Builds the customer's name
                name = custList[pIndex].last + ", " + custList[pIndex].first;
                if (custList[pIndex].middle != "")
                {
                    name += " " + custList[pIndex].middle + ".";
                }

                //Builds the credit information for the customer
                credit = "Credit: " + custList[pIndex].credit.ToString("C") + " Promo: " + custList[pIndex].promo.ToString("C") + " Spent: " + custList[pIndex].spent.ToString("C") + " Total: " + (custList[pIndex].credit + custList[pIndex].promo - custList[pIndex].spent).ToString("C");
                
                //prints the customers
                e.Graphics.DrawString(name, font, Brushes.Black, leftMargin, yPos, new StringFormat());           
                e.Graphics.DrawString(credit, font, Brushes.Black, rightMargin, yPos, cFormat);

                //Adds to the indexes
                count++;
                pIndex++;
            }

            //If there are more customers, print another page
            pCount++;
            e.HasMorePages = pIndex < custList.Count;
        }
    }
}
