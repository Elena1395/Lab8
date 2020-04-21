using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Lab8
{
    public partial class Form_Main : System.Windows.Forms.Form
    {
        DeleteByNumber_Form DBN;
        AddLuggage_Form ALF;
        AddFilter_Form AF;
        public short filter;
        public Form_Main()
        {
            InitializeComponent();
        }

        private void showAllToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            if (Common.TryToLoadXML())
            {
                XDocument doc = XDocument.Load(Common.fileName);
                IEnumerable<XElement> xElem = doc.Root.Elements();
                ShowXelements(xElem);
            }          
        }
        public void ShowXelements(IEnumerable<XElement> xElem) {
            textBox1.Clear();
            try
            {
                foreach (XElement el in xElem)
                {
                    //Выводим имя элемента и значение аттрибута id
                    textBox1.Text += "Luggage № " + el.Attribute("id").Value + Environment.NewLine;
                    //textBox1.Text += ("  Attributes:");
                    textBox1.Text += "   Luggage information:" + Environment.NewLine;
                    //выводим в цикле названия всех дочерних элементов и их значения
                    foreach (XElement element in el.Elements())
                        textBox1.Text += "      " + element.Name + ": " + element.Value + Environment.NewLine;
                }
            }
            catch (Exception e) {
                MessageBox.Show("Ошибка при чтении файла xml: \r\n"+e.Message);
            }
        }

        private void addLuggageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool flag = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "AddLuggage_Form")
                {
                    flag = true;
                    ALF.Visible = true;
                    ALF.Activate();
                }
            }
            if (!flag)
            {
                ALF = new AddLuggage_Form();
                ALF.Show();
            }
        }

        private void deleteByNumberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool flag = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "DeleteByNumber_Form")
                {
                    flag = true;
                    DBN.Visible = true;
                    DBN.Activate();
                }
            }
            if (!flag)
            {
                DBN = new DeleteByNumber_Form();
                DBN.Show();
            }

        }

        private void byFlightNumberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            filter = 1;
            bool flag = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "AddFilter_Form")
                {
                    flag = true;
                    AF.textBox_FilterComment.Text = "Enter flight number "+Environment.NewLine+ "Format: xx000, x - letter, 0 - number";
                    AF.Visible = true;
                    AF.Activate();
                    AF.filter = filter;
                }
            }
            if (!flag)
            {
                AF = new AddFilter_Form(filter,this);
                AF.textBox_FilterComment.Text = "Enter flight number" + Environment.NewLine + "Format: xx000, x - letter, 0 - number";
                AF.Show();
            }
            
        }

        private void byDestinationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            filter = 2;
            bool flag = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "AddFilter_Form")
                {
                    flag = true;
                    AF.textBox_FilterComment.Text = "Enter destination";
                    AF.Visible = true;
                    AF.Activate();
                    AF.filter = filter;
                }
            }
            if (!flag)
            {
                AF = new AddFilter_Form(filter, this);
                AF.textBox_FilterComment.Text = "Enter destination";
                AF.Show();
            }
        }

        private void byDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            filter = 3;
            bool flag = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "AddFilter_Form")
                {
                    flag = true;
                    AF.textBox_FilterComment.Text = "Enter date " + Environment.NewLine + "Format: dd.mm.yyyy";
                    AF.Visible = true;
                    AF.Activate();
                    AF.filter = filter;
                }
            }
            if (!flag)
            {
                AF = new AddFilter_Form(filter, this);
                AF.textBox_FilterComment.Text = "Enter date " + Environment.NewLine + "Format: dd.mm.yyyy";
                AF.Show();
            }
        }

        private void byTotalWeightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            filter = 4;
            bool flag = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "AddFilter_Form")
                {
                    flag = true;
                    AF.textBox_FilterComment.Text = "Enter total weight" + Environment.NewLine + "Luggage exceeding the specified weight will be displayed";
                    AF.Visible = true;
                    AF.Activate();
                    AF.filter = filter;
                }
            }
            if (!flag)
            {
                AF = new AddFilter_Form(filter, this);
                AF.textBox_FilterComment.Text = "Enter total weight" + Environment.NewLine + "Luggage exceeding the specified weight will be displayed";
                AF.Show();
            }
        }
    }
}
