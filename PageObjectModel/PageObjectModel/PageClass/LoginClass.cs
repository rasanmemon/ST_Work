using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace PageObjectModel
{
    public  class LoginClass : BaseClass
    {
        public void LoginSuccessful(string username, string password)
        {
            string expectedValue = "Products";
            chromeDriver.FindElement(By.Id(LocatorClass.UserName)).SendKeys(username);
            chromeDriver.FindElement(By.Id(LocatorClass.Password)).SendKeys(password);
            chromeDriver.FindElement(By.Id(LocatorClass.LoginButton)).Click();
            string actualValue = chromeDriver.FindElement(By.XPath(LocatorClass.ExpectedProductText)).Text;
            Assert.AreEqual(expectedValue, actualValue);
        }
        public void LoginUnSuccessful(string username, string password)
        {
            string expectedValue = "Epic sadface: Username and password do not match any user in this service";
            chromeDriver.FindElement(By.Id(LocatorClass.UserName)).SendKeys(username);
            chromeDriver.FindElement(By.Id(LocatorClass.Password)).SendKeys(password);
            chromeDriver.FindElement(By.Id(LocatorClass.LoginButton)).Click();
            string actualValue = chromeDriver.FindElement(By.XPath(LocatorClass.UnSuccesfulLoginText)).Text;
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}
