/* Author: Jeff Goodhue
 * Date: September 2013
 * 
 * Object to store transaction information
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StoreCreditManager
{
    //[Serializable] allows it to be saved
    [Serializable]
    public class Transaction
    {
        public DateTime date;
        public string reason;

        //What type of transaction it was. Will be used in the future.
        public enum Seperation { credit, promo, purchase, newCustomer };
        public Seperation type;

        public string amount;

    }
}
