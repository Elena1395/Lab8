using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Lab8
{
    public partial class AddFilter_Form : Form
    {
        Form_Main fm;
        public short filter;
        public AddFilter_Form(short filter,Form_Main fm)
        {
            InitializeComponent();
            this.filter = filter;
            this.fm = fm;
        }

        private void AddFiler_button_Click(object sender, EventArgs e)
        {
            if (Common.TryToLoadXML(Common.fileName))
            {
                XDocument doc = XDocument.Load(Common.fileName);
                string data = textBox_Filter.Text;
                switch (filter)
                {
                    case 1:
                        {
                            if (!Common.CheckFlightNumber(data))
                            {
                                return;
                            }
                            QueryByFlightNumber(doc, data);
                            break;
                        }
                    case 2:
                        {
                            if (!Common.CheckDestination(data))
                            {
                                return;
                            }
                            QueryByDestination(doc, data);
                            break;
                        }
                    case 3:
                        {
                            if (!Common.CheckDate(data))
                            {
                                return;
                            }
                            QueryByDate(doc, data);
                            break;
                        }
                    case 4:
                        {
                            if (!Common.CheckTotalWeight(data))
                            {
                                return;
                            }
                            QueryByTotalWeight(doc, data);
                            break;
                        }
                }
            }
        }
        public void QueryByFlightNumber(XDocument doc,string data) {
            IEnumerable<XElement> lg = doc.Root.Descendants("Luggage");
            try
            {
                var res = from r in lg
                          where r.Element("Flight_number").Value == data
                          select r;
                if (res.Count() == 0)
                {
                    fm.textBox1.Clear();
                    fm.textBox1.Text = "Baggage with the specified flight number does not exist!";
                }
                else
                {
                    fm.ShowXelements(res);
                    Common.BoolForUnitTest = true;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Ошибка при чтении файла xml: \r\n" + e.Message);
            }
        }
        public void QueryByDestination(XDocument doc, string data) {
            IEnumerable<XElement> lg = doc.Root.Descendants("Luggage");
            try
            {
                var res = from r in lg
                          where r.Element("Destination").Value == data
                          select r;
                if (res.Count() == 0)
                {
                    fm.textBox1.Clear();
                    fm.textBox1.Text = "Baggage with the specified destination does not exist!";
                }
                else
                {
                    fm.ShowXelements(res);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Ошибка при чтении файла xml: \r\n" + e.Message);
            }
        }
        public void QueryByDate(XDocument doc, string data) {
            IEnumerable<XElement> lg = doc.Root.Descendants("Luggage");
            try
            {
                var res = from r in lg
                          where r.Element("Date").Value == data
                          select r;
                if (res.Count() == 0)
                {
                    fm.textBox1.Clear();
                    fm.textBox1.Text = "Baggage with the specified date does not exist!";
                }
                else
                {
                    fm.ShowXelements(res);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Ошибка при чтении файла xml: \r\n" + e.Message);
            }
        }
        public void QueryByTotalWeight(XDocument doc, string data){
            IEnumerable<XElement> lg = doc.Root.Descendants("Luggage");
            try
            {
                var res = from r in lg
                          where Convert.ToInt32(r.Element("Total_weight").Value) >= Convert.ToInt32(data)
                          select r;
                if (res.Count() == 0)
                {
                    fm.textBox1.Clear();
                    fm.textBox1.Text = "Baggage with the specified date does not exist!";
                }
                else
                {
                    fm.ShowXelements(res);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Ошибка при чтении файла xml: \r\n" + e.Message);
            }

        }        
    }
}
