using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;

namespace BankAccounts
{
    class Account
    {
        //Client Info
        static public string BankName = "Fat $tacks Banking";
        static public string ClientName = "Casey Jones";
        static public string ClientAddress = "   2564 West Hype Ave\n    Eastwood, California 66421";
        static public string ClientPhone = "899-555-555";

        //Method for formating double data type to currency 
        static public string ToCurrency(double nums)
        {

            string curCulture = System.Threading.Thread.CurrentThread.CurrentCulture.ToString();
            System.Globalization.NumberFormatInfo currencyFormat = new System.Globalization.CultureInfo(curCulture).NumberFormat;
            currencyFormat.CurrencyNegativePattern = 1;

            string cash = nums.ToString("C", currencyFormat);
       
            return cash;
        }


    }
}
