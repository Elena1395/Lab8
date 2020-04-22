using System;
using Lab8;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Xml.Linq;
using System.Collections.Generic;
using System.Xml;

namespace TestLab8
{
    [TestClass]
    public class UnitTest1
    {
        Form_Main fm = new Form_Main();
        DeleteByNumber_Form dn = new DeleteByNumber_Form();
        AddFilter_Form af;

        [TestMethod]
        public void Test_incorrectXML_File()
        {
            bool expected = false;
            string filename1 = "Test_incorrectXML.xml";
            bool actual = Common.TryToLoadXML(filename1);
            Assert.AreEqual(expected, actual);
        }

        [DataTestMethod]
        [DataRow("AR234", true)]
        [DataRow("ar234", true)]
        [DataRow("aR234", true)]
        [DataRow("aR2345", true)]
        [DataRow("aR23456", true)]
        [DataRow("ПР123", false)]
        [DataRow("1231", false)]
        [DataRow("ляля", false)]
        [DataRow("aR234521", false)]
        [DataRow("aR23", false)]
        [DataRow("", false)]
        public void Test_CheckFlightNumber(string input, bool expected)
        {
            var result = Common.CheckFlightNumber(input);

            Assert.AreEqual(expected, result);
        }

        [DataTestMethod]
        [DataRow("31.12.2006", true)]
        [DataRow("12 12 2018", true)]
        [DataRow("01-01/1900", true)]
        [DataRow("21.10/1973", true)]
        [DataRow("20.00.2012", false)]
        [DataRow("01.12.1899", false)]
        [DataRow("00.12.1922", false)]
        [DataRow("01.13.2013", false)]
        [DataRow("01.02.3012", false)]
        [DataRow("12  12/2012", false)]
        [DataRow("", false)]
        public void Test_CheckDate(string input, bool expected)
        {
            var result = Common.CheckDate(input);

            Assert.AreEqual(expected, result);
        }

        [DataTestMethod]
        [DataRow("12:00", true)]
        [DataRow("23:59", true)]
        [DataRow("00:01", true)]
        [DataRow("14 00", false)]
        [DataRow("03/23", false)]
        [DataRow("15-17", false)]
        [DataRow("14:15:10", false)]
        [DataRow("25:13", false)]
        [DataRow("00:00", true)]
        [DataRow("", false)]
        public void Test_CheckTime(string input, bool expected)
        {
            var result = Common.CheckTime(input);

            Assert.AreEqual(expected, result);
        }

        [DataTestMethod]
        [DataRow("Moscow", true)]
        [DataRow("Москва", true)]
        [DataRow("Ростов-на-Дону", true)]
        [DataRow("Великий Новгород", true)]
        [DataRow("14340", false)]
        [DataRow("Город03", false)]
        [DataRow("15", false)]
        [DataRow("", false)]
        public void Test_CheckDestination(string input, bool expected)
        {
            var result = Common.CheckDestination(input);

            Assert.AreEqual(expected, result);
        }

        [DataTestMethod]
        [DataRow("Ivanov", true)]
        [DataRow("Иванов", true)]
        [DataRow("Ива нов", true)]
        [DataRow("Ива-нов", true)]
        [DataRow("1321", false)]
        [DataRow("Иван1ов", false)]
        [DataRow("", false)]
        public void Test_CheckLastName(string input, bool expected)
        {
            var result = Common.CheckLastName(input);

            Assert.AreEqual(expected, result);
        }

        [DataTestMethod]
        [DataRow("1", true)]
        [DataRow("123123", true)]
        [DataRow("Иванов", false)]
        [DataRow("12 3", false)]
        [DataRow("0", true)]
        [DataRow("", false)]
        public void Test_CheckNumberOfPlaces(string input, bool expected)
        {
            var result = Common.CheckNumberOfPlaces(input);

            Assert.AreEqual(expected, result);
        }

        [DataTestMethod]
        [DataRow("0", true)]
        [DataRow("123123", true)]
        [DataRow("Иванов", false)]
        [DataRow("12 3", false)]
        [DataRow("", false)]
        public void Test_CheckTotalWeight(string input, bool expected)
        {
            var result = Common.CheckTotalWeight(input);

            Assert.AreEqual(expected, result);
        }


        
        [DataTestMethod]
        [DataRow("Test_LuggageWithoutId.xml", false)]
        [DataRow("Test_NoLuggage.xml", false)]
        [DataRow("Test_NotFullLuggage.xml", true)]
        public void Test_MainForm_ShowXelements(string filename, bool expected)
        {
            XDocument doc = XDocument.Load(filename);
            IEnumerable<XElement> xElem = doc.Root.Elements();          
            fm.ShowXelements(xElem);

            Assert.AreEqual(expected, Common.BoolForUnitTest);
        }


        [DataTestMethod]
        [DataRow("123", false)]//Нет такого id
        [DataRow("1234", false)]//Есть несколько таких id (надо не подтверждать удаление)
        public void Test_DeleteByNumber_Form_DeleteQuery(string data, bool expected)
        {
            string filename = "Test_DeleteQuery.xml";
            XDocument doc = XDocument.Load(filename);
            IEnumerable<XElement> xElem = doc.Root.Elements();

            dn.DeleteQuery(doc,data);

            Assert.AreEqual(expected, Common.BoolForUnitTest);
        }


        [DataTestMethod]
        [DataRow("ww123", false)]//Нет такого flight number
        [DataRow("ww111", true)]//Есть несколько таких рейсов
        [DataRow("ww222", true)]//Один рейс
        public void Test_AddFilter_Form_QueryByFlightNumber(string data, bool expected)
        {
            string filename = "Test_Queries.xml";
            XDocument doc = XDocument.Load(filename);
            IEnumerable<XElement> xElem = doc.Root.Elements();

            af = new AddFilter_Form(1, fm);
            af.QueryByFlightNumber(doc, data);

            Assert.AreEqual(expected, Common.BoolForUnitTest);
        }

        [DataTestMethod]
        [DataRow("hello", false)]//Нет такого пункта назначения
        [DataRow("Los-Angeles", true)]//Есть несколько таких пунктов назначения
        [DataRow("Moscow", true)]//Один пункт назначения
        public void Test_AddFilter_Form_QueryByDestination(string data, bool expected)
        {
            string filename = "Test_Queries.xml";
            XDocument doc = XDocument.Load(filename);
            IEnumerable<XElement> xElem = doc.Root.Elements();

            af = new AddFilter_Form(2, fm);
            af.QueryByDestination(doc, data);

            Assert.AreEqual(expected, Common.BoolForUnitTest);
        }

        [DataTestMethod]
        [DataRow("12.12.2000", false)]//Нет такой даты
        [DataRow("12.12.2009", true)]//Есть несколько дат
        [DataRow("12.12.2010", true)]//Одна дата
        public void Test_AddFilter_Form_QueryByDate(string data, bool expected)
        {
            string filename = "Test_Queries.xml";
            XDocument doc = XDocument.Load(filename);
            IEnumerable<XElement> xElem = doc.Root.Elements();

            af = new AddFilter_Form(3, fm);
            af.QueryByDate(doc, data);

            Assert.AreEqual(expected, Common.BoolForUnitTest);
        }

        [DataTestMethod]
        [DataRow("100", false)]//Нет такого веса
        [DataRow("42", true)]//Есть несколько весов
        [DataRow("20", true)]//Один вес
        public void Test_AddFilter_Form_QueryByTotalWeight(string data, bool expected)
        {
            string filename = "Test_Queries.xml";
            XDocument doc = XDocument.Load(filename);
            IEnumerable<XElement> xElem = doc.Root.Elements();

            af = new AddFilter_Form(4, fm);
            af.QueryByTotalWeight(doc, data);

            Assert.AreEqual(expected, Common.BoolForUnitTest);
        }



        [DataTestMethod]
        [DataRow("123", false)]
        public void Test_DeleteByNumber_Form_DeleteQuery_incorrectXml(string data, bool expected)
        {
            string filename = "Test_LuggageWithoutId.xml";
            XDocument doc = XDocument.Load(filename);
            IEnumerable<XElement> xElem = doc.Root.Elements();

            dn.DeleteQuery(doc, data);

            Assert.AreEqual(expected, Common.BoolForUnitTest);
        }


        [DataTestMethod]
        [DataRow("ww222", false)]
        public void Test_AddFilter_Form_QueryByFlightNumber_incorrectXml(string data, bool expected)
        {
            string filename = "Test_LuggageWithoutFlightNumber.xml";
            XDocument doc = XDocument.Load(filename);
            IEnumerable<XElement> xElem = doc.Root.Elements();

            af = new AddFilter_Form(1, fm);
            af.QueryByFlightNumber(doc, data);

            Assert.AreEqual(expected, Common.BoolForUnitTest);
        }

        [DataTestMethod]
        [DataRow("hello", false)]
        public void Test_AddFilter_Form_QueryByDestination_incorrectXml(string data, bool expected)
        {
            string filename = "Test_LuggageWithoutDestination.xml";
            XDocument doc = XDocument.Load(filename);
            IEnumerable<XElement> xElem = doc.Root.Elements();

            af = new AddFilter_Form(2, fm);
            af.QueryByDestination(doc, data);

            Assert.AreEqual(expected, Common.BoolForUnitTest);
        }

        [DataTestMethod]
        [DataRow("12.12.2000", false)]
        public void Test_AddFilter_Form_QueryByDate_incorrectXml(string data, bool expected)
        {
            string filename = "Test_LuggageWithoutDate.xml";
            XDocument doc = XDocument.Load(filename);
            IEnumerable<XElement> xElem = doc.Root.Elements();

            af = new AddFilter_Form(3, fm);
            af.QueryByDate(doc, data);

            Assert.AreEqual(expected, Common.BoolForUnitTest);
        }

        [DataTestMethod]
        [DataRow("100", false)]
        public void Test_AddFilter_Form_QueryByTotalWeight_incorrectXml(string data, bool expected)
        {
            string filename = "Test_LuggageWithoutTotalWeight.xml";
            XDocument doc = XDocument.Load(filename);
            IEnumerable<XElement> xElem = doc.Root.Elements();

            af = new AddFilter_Form(4, fm);
            af.QueryByTotalWeight(doc, data);

            Assert.AreEqual(expected, Common.BoolForUnitTest);
        }
    }
}
