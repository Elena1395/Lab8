using System;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Lab8
{
    public partial class AddLuggage_Form : System.Windows.Forms.Form
    {
        
        public AddLuggage_Form()
        {
            InitializeComponent();
        }

        private void AddData_Click(object sender, EventArgs e)
        {
            if (Common.TryToLoadXML())
            {
                XDocument doc = XDocument.Load(Common.fileName);
                if (CheckAddLuggageForm())
                {
                    int maxId = doc.Root.Elements("Luggage").Max(t => Int32.Parse(t.Attribute("id").Value));
                    XElement Luggage = new XElement("Luggage",
                        new XAttribute("id", ++maxId),
                        new XElement("Flight_number", textBox_FlightNumber.Text),
                        new XElement("Date", textBox_Date.Text),
                        new XElement("Time", textBox_Time.Text),
                        new XElement("Destination", textBox_Destination.Text),
                        new XElement("Last_name", textBox_LastName.Text),
                        new XElement("NumberOfPlaces", textBox_NumberOfPlaces.Text),
                        new XElement("Total_weight", textBox_TotalWeigh.Text)
                        );
                    doc.Root.Add(Luggage);
                    doc.Save(Common.fileName);
                    MessageBox.Show("Successfully!");
                }
            }
        }
        public bool CheckAddLuggageForm()
        {
            string data;
            foreach (TextBox tb in tableLayoutPanel1.Controls.OfType<TextBox>())
            {
                data=tb.Text;
                switch (tb.Name)
                {
                    case "textBox_FlightNumber":
                        {
                            if (!Common.CheckFlightNumber(data)) {
                                return false;
                            };
                            break;
                        }
                    case "textBox_Date":
                        {
                            if (!Common.CheckDate(data)){
                                return false;
                            };
                            break;
                        }
                    case "textBox_Time":
                        {
                            if (!Common.CheckTime(data)) {
                                return false;
                            }
                            break;
                        }
                    case "textBox_Destination":
                        {
                            if (!Common.CheckDestination(data)) {
                                return false;
                            }
                            break;
                        }
                    case "textBox_LastName":
                        {
                            if (!Common.CheckLastName(data)) {
                                return false;
                            }
                            break;
                        }
                    case "textBox_NumberOfPlaces":
                        {
                            if (!Common.CheckNumberOfPlaces(data)) {
                                return false;
                            }
                            break;
                        }
                    case "textBox_TotalWeigh":
                        {
                            if (!Common.CheckTotalWeight(data)){
                                return false;
                            }
                            break;
                        }
                }
            }
            return true;           
        }      
    }
}
