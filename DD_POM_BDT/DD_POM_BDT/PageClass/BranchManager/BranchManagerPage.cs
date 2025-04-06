using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DD_POM_BDT.PageClass.BranchManager
{
    public class BranchManagerPage : BaseClass
    {
        public void Login()
        {
            chromeDriver.FindElement(By.XPath(LocatorClass.bmloginbutton)).Click();
        }
        public void addCustomerDetails()
        {
            var firstname = jsonData["firstname"].ToString();
            chromeDriver.FindElement(By.XPath(LocatorClass.firstName)).SendKeys(firstname);
            var lastname = jsonData["lastname"].ToString();
            chromeDriver.FindElement(By.XPath(LocatorClass.lastName)).SendKeys(lastname);
            var postcode = jsonData["postcode"].ToString();
            chromeDriver.FindElement(By.XPath(LocatorClass.postCode)).SendKeys(postcode);
        }
        public void addCustomerSubmit()
        {
            string text = chromeDriver.SwitchTo().Alert().Text;
            Assert.IsTrue(text.Contains(jsonData["expectedAlertAfterAddcustomer"].ToString()));
            chromeDriver.SwitchTo().Alert().Accept();
        }
        public void openAccount()
        {
            var customerdropdown = chromeDriver.FindElement(By.Id(LocatorClass.customernameDropdown));
            customerdropdown.FindElement(By.XPath(LocatorClass.customernameOption)).Click();

            var currencydropdown = chromeDriver.FindElement(By.Id(LocatorClass.currencyDropdown));
            currencydropdown.FindElement(By.XPath(LocatorClass.currencyOption)).Click();
        }
        public void openAccountSubmit()
        {
            string text = chromeDriver.SwitchTo().Alert().Text;
            Assert.IsTrue(text.Contains(jsonData["expectedAlertAfterOpenAccount"].ToString()));
            chromeDriver.SwitchTo().Alert().Accept();
        }
        public void searchCustomer()
        {
            var searchfor = jsonData["searchfor"].ToString();
            chromeDriver.FindElement(By.XPath(LocatorClass.searchbarcustomer)).SendKeys(searchfor);
        }
    }
}
