
using Newtonsoft.Json.Linq;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Driven_Selinium
{
    public class CheckoutClass : BaseClass
    {
        public void AddToCart()
        {
            var jsonData = JObject.Parse(File.ReadAllText("D:\\FAST\\ST\\Code\\Data_Driven_Selinium\\Data_Driven_Selinium\\data.json"));
            string expectedValue = jsonData["expectedcheckouttext"].ToString();
            chromeDriver.FindElement(By.Id(LocatorClass.Product1)).Click();
            chromeDriver.FindElement(By.Id(LocatorClass.Product2)).Click();
            chromeDriver.FindElement(By.XPath(LocatorClass.CartLink)).Click();
            chromeDriver.FindElement(By.Id(LocatorClass.CheckoutButton)).Click();
            string actualValue = chromeDriver.FindElement(By.XPath(LocatorClass.ExpectedCheckoutText)).Text;
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}
