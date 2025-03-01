using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace PageObjectModel
{
    public class ShipmentClass : BaseClass
    {
        public void ShipInfo(string firstname,string lastname,string zipcode)
        {
            chromeDriver.FindElement(By.Id(LocatorClass.FirstName)).SendKeys(firstname);
            chromeDriver.FindElement(By.Id(LocatorClass.LastName)).SendKeys(lastname);
            chromeDriver.FindElement(By.Id(LocatorClass.Zipcode)).SendKeys(zipcode);

        }
        public void OrderPlace()
        {
            string orderNoConfirmed = "SauceCard #31337";
            string confirmationMsg = "Thank you for your order!";
            chromeDriver.FindElement(By.Id(LocatorClass.ContinueButton)).Click();
            string orderNo = chromeDriver.FindElement(By.XPath(LocatorClass.OrderNumber)).Text;
            Assert.AreEqual(orderNoConfirmed, orderNo);
            chromeDriver.FindElement(By.Id(LocatorClass.FinishButton)).Click();
            string orderConfirmationMsg = chromeDriver.FindElement(By.XPath(LocatorClass.OrderConfirmation)).Text;
            Assert.AreEqual(confirmationMsg, orderConfirmationMsg);
        }
    }
}
