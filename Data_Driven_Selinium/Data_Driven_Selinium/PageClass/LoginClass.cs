using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using OpenQA.Selenium;

namespace Data_Driven_Selinium
{
    public class LoginClass : BaseClass
    {
        public void LoginSuccessful()
        {
            /* For XML
             * XElement xelement = XElement.Load(@"D:\DATA 11-1-2023\SZABIST\DataDriven_JSON_XML_SEL\DataDriven_JSON_XML_SEL\data.xml");
             * string username = xelement.Element("username").Value;
             * string password = xelement.Element("password").Value;
             * string url = xelement.Element("url").Value;
             * string productText = xelement.Element("producttext").Value;
             * string orderConfirmationText = xelement.Element("orderconfirmationtext").Value;
             */

            var jsonData = JObject.Parse(File.ReadAllText("D:\\FAST\\ST\\Code\\Data_Driven_Selinium\\Data_Driven_Selinium\\data.json"));
            string expectedValue = jsonData["expectedproducttext"].ToString();
            string username = jsonData["username"].ToString();
            string password = jsonData["password"].ToString();
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
