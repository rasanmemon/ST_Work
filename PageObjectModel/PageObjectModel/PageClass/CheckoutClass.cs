using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectModel
{
    public class CheckoutClass : BaseClass
    {
        public void AddToCart()
        {
            string expectedValue = "Checkout: Your Information";
            chromeDriver.FindElement(By.Id(LocatorClass.Product1)).Click();
            chromeDriver.FindElement(By.Id(LocatorClass.Product2)).Click();
            chromeDriver.FindElement(By.XPath(LocatorClass.CartLink)).Click();
            chromeDriver.FindElement(By.Id(LocatorClass.CheckoutButton)).Click();
            string actualValue = chromeDriver.FindElement(By.XPath(LocatorClass.ExpectedCheckoutText)).Text;
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}
