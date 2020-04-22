using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Lab8
{
    public partial class DeleteByNumber_Form : System.Windows.Forms.Form
    {
        public DeleteByNumber_Form()
        {
            InitializeComponent();
        }

        private void DeleteByNumber_button_Click(object sender, EventArgs e)
        {
            if (Common.TryToLoadXML(Common.fileName))
            {
                XDocument doc = XDocument.Load(Common.fileName);
                int id;
                if (Int32.TryParse(textBox_LuggageNumber.Text, out id))
                {
                    DeleteQuery(doc,id.ToString());
                }
                else
                {
                    MessageBox.Show("Incorrect number!");
                }
            }
        }

        public void DeleteQuery(XDocument doc, string data){
            IEnumerable<XElement> lg = doc.Root.Descendants("Luggage");
            try
            {
                var res = from r in lg
                          where r.Attribute("id").Value == data
                          select r;
                if (res.Count() == 0)
                {
                    MessageBox.Show("Baggage with the specified number does not exist!");
                }
                else if (res.Count() > 1)
                {
                    DialogResult result = MessageBox.Show("Several luggages with this number were found.\r\n Delete all? ", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        res.Remove();
                        doc.Save(Common.fileName);
                        MessageBox.Show("Baggage with the specified number was successfully deleted");
                        Common.BoolForUnitTest = true;
                    }
                    else if (result == DialogResult.No)
                    {
                        MessageBox.Show("The baggage was not removed.");
                    }
                }
                else
                {
                    res.Remove();
                    doc.Save(Common.fileName);
                    MessageBox.Show("Baggage with the specified number was successfully deleted");
                    Common.BoolForUnitTest = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при чтении файла xml: \r\n" + ex.Message);
            }
        }
    }
}
