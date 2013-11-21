/* Author: Jeff Goodhue
 * Date: September 2013
 * 
 * Object to store a customer's information
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StoreCreditManager
{
    //[Serializable] allows it to be saved
    [Serializable]
    public class Customer
    {
        public decimal credit = 0;
        public decimal promo = 0;
        public decimal spent = 0;

        public string first = "", middle = "", last = "", DCINum = "";

        //List of their transaction history
        public List<Transaction> history;

        public void addCredit(string amt)
        {
            credit += Decimal.Parse(amt.Replace("$", ""));
        }

        public void addPromo(string amt)
        {
            promo += Decimal.Parse(amt.Replace("$", ""));
        }

        public void subCredit(string amt)
        {
            spent += Decimal.Parse(amt.Replace("$", ""));
        }
    }
}
