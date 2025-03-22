using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Newtonsoft.Json.Linq;
using OpenQA.Selenium;

namespace Data_Driven_Selinium_XML
{
    public class ShipmentClass : BaseClass
    {

        public void ShipInfo()
        {
            XElement xelement = XElement.Load(@"D:\FAST\ST\Code\Data_Driven_Selinium_XML\Data_Driven_Selinium_XML\data.xml");
            string firstname = xelement.Element("firstname").Value;
            string lastname = xelement.Element("lastname").Value;
            string zipcode = xelement.Element("zipcode").Value;
            chromeDriver.FindElement(By.Id(LocatorClass.FirstName)).SendKeys(firstname);
            chromeDriver.FindElement(By.Id(LocatorClass.LastName)).SendKeys(lastname);
            chromeDriver.FindElement(By.Id(LocatorClass.Zipcode)).SendKeys(zipcode);

        }
        public void OrderPlace()
        {
            XElement xelement = XElement.Load(@"D:\FAST\ST\Code\Data_Driven_Selinium_XML\Data_Driven_Selinium_XML\data.xml");
            string orderNoConfirmed = xelement.Element("orderNoConfirmed").Value;
            string confirmationMsg = xelement.Element("orderconfirmationtext").Value;
            chromeDriver.FindElement(By.Id(LocatorClass.ContinueButton)).Click();
            string orderNo = chromeDriver.FindElement(By.XPath(LocatorClass.OrderNumber)).Text;
            Assert.AreEqual(orderNoConfirmed, orderNo);
            chromeDriver.FindElement(By.Id(LocatorClass.FinishButton)).Click();
            string orderConfirmationMsg = chromeDriver.FindElement(By.XPath(LocatorClass.OrderConfirmation)).Text;
            Assert.AreEqual(confirmationMsg, orderConfirmationMsg);
        }
    }
}
