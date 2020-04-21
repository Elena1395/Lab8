using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Lab8
{
    class Common
    {
        public static string fileName = "Luggage.xml";

        public static bool TryToLoadXML()
        {
            try
            {
                XDocument d = XDocument.Load(fileName);
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Unable to load a file " + fileName + "\r\n" + e.Message);
                return false;
            }

        }

        public static bool CheckFlightNumber(string data)
        {
            Regex regex = new Regex(@"^[a-zA-Z]{2}\d{3,5}$");
            if (!regex.IsMatch(data))
            {
                MessageBox.Show("Incorrect flight number! (format: xx000, x - letter, 0 - number)");
                return false;
            }
            return true;
        }
        public static bool CheckDate(string data)
        {
            Regex regex = new Regex(@"^(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d$");
            if (!regex.IsMatch(data))
            {
                MessageBox.Show("Incorrect date! (format: dd.mm.yyyy)");
                return false;
            }
            return true;
        }
        public static bool CheckTime(string data)
        {
            Regex regex = new Regex(@"^(([0,1][0-9])|(2[0-3])):[0-5][0-9]$");
            if (!regex.IsMatch(data))
            {
                MessageBox.Show("Incorrect time! (format: hh:mm)");
                return false;
            }
            return true;
        }
        public static bool CheckDestination(string data)
        {
            Regex regex = new Regex(@"^[a-zA-Zа-яА-Я -]+$");
            if (!regex.IsMatch(data))
            {
                MessageBox.Show("Incorrect destination!");
                return false;
            }
            return true;
        }
        public static bool CheckLastName(string data)
        {
            Regex regex = new Regex(@"^[a-zA-Zа-яА-Я -]+$");
            if (!regex.IsMatch(data))
            {
                MessageBox.Show("Incorrect last name!");
                return false;
            }
            return true;
        }
        public static bool CheckNumberOfPlaces(string data)
        {
            Regex regex = new Regex(@"^[0-9]+$");
            if (!regex.IsMatch(data))
            {
                MessageBox.Show("Incorrect number of places!");
                return false;
            }
            return true;
        }
        public static bool CheckTotalWeight(string data)
        {
            Regex regex = new Regex(@"^[0-9]+$");
            if (!regex.IsMatch(data))
            {
                MessageBox.Show("Incorrect total weight!");
                return false;
            }
            return true;
        }


    }
}
