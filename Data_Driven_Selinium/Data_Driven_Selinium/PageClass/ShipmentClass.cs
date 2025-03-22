using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using OpenQA.Selenium;

namespace Data_Driven_Selinium
{
    public class ShipmentClass : BaseClass
    {

        public void ShipInfo()
        {
            var jsonData = JObject.Parse(File.ReadAllText("D:\\FAST\\ST\\Code\\Data_Driven_Selinium\\Data_Driven_Selinium\\data.json"));
            string firstname = jsonData["firstname"].ToString();
            string lastname = jsonData["lastname"].ToString();
            string zipcode = jsonData["zipcode"].ToString();
            chromeDriver.FindElement(By.Id(LocatorClass.FirstName)).SendKeys(firstname);
            chromeDriver.FindElement(By.Id(LocatorClass.LastName)).SendKeys(lastname);
            chromeDriver.FindElement(By.Id(LocatorClass.Zipcode)).SendKeys(zipcode);

        }
        public void OrderPlace()
        {
            var jsonData = JObject.Parse(File.ReadAllText("D:\\FAST\\ST\\Code\\Data_Driven_Selinium\\Data_Driven_Selinium\\data.json"));
            string orderNoConfirmed = jsonData["orderNoConfirmed"].ToString(); ;
            string confirmationMsg = jsonData["orderconfirmationtext"].ToString();
            chromeDriver.FindElement(By.Id(LocatorClass.ContinueButton)).Click();
            string orderNo = chromeDriver.FindElement(By.XPath(LocatorClass.OrderNumber)).Text;
            Assert.AreEqual(orderNoConfirmed, orderNo);
            chromeDriver.FindElement(By.Id(LocatorClass.FinishButton)).Click();
            string orderConfirmationMsg = chromeDriver.FindElement(By.XPath(LocatorClass.OrderConfirmation)).Text;
            Assert.AreEqual(confirmationMsg, orderConfirmationMsg);
        }
    }
}
