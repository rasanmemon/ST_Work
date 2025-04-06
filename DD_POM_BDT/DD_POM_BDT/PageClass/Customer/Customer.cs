using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DD_POM_BDT.PageClass.Customer
{
    public class Customer : BaseClass
    {
        public void CustomerLoginButtonClick()
        {
            Thread.Sleep(5000);
            chromeDriver.FindElement(By.XPath(LocatorClass.customerLoginButton)).Click();
        }
        public void SelectUserandLogin()
        {
            Thread.Sleep(5000);
            var dropdown = chromeDriver.FindElement(By.XPath(LocatorClass.userNameDropdown));
            dropdown.FindElement(By.XPath(LocatorClass.usernameOption)).Click();
            chromeDriver.FindElement(By.XPath(LocatorClass.loginButton)).Click();

        }
        public void LoginSubmit()
        {
            var expectedValue = jsonData["expectedValueCustomerlogin"].ToString();
            Thread.Sleep(1000);
            string actualValue = chromeDriver.FindElement(By.XPath(LocatorClass.welcomePageExpected)).Text;
            Assert.AreEqual(expectedValue, actualValue);
        }
        public void Logout()
        {
            chromeDriver.FindElement(By.XPath(LocatorClass.logout)).Click();

        }
        public void resetTransaction()
        {
            chromeDriver.FindElement(By.XPath(LocatorClass.transactionResetButton)).Click();

        }
        public void backtomainpage()
        {
            chromeDriver.FindElement(By.XPath(LocatorClass.transactionBackButton)).Click();

        }
        public void fromOpenBrowserToLogin()
        {
            DriverInitialized();
            OpenWindow();
            CustomerLoginButtonClick();
            SelectUserandLogin();
            LoginSubmit();
        }
        public void changeStartDate()
        {
            chromeDriver.ExecuteScript($"document.getElementById('{LocatorClass.startdate}').focus();");
            chromeDriver.ExecuteScript($@"
                var input = document.getElementById('{LocatorClass.startdate}');
                input.value = '{jsonData["startDate"]}';
                input.dispatchEvent(new Event('input'));
                input.dispatchEvent(new Event('change'));
            ");
        }
        public void changeendDate()
        {
            chromeDriver.ExecuteScript($"document.getElementById('{LocatorClass.enddate}').focus();");
            chromeDriver.ExecuteScript($@"
                var input = document.getElementById('{LocatorClass.enddate}');
                input.value = '{jsonData["endDate"]}';
                input.dispatchEvent(new Event('input'));
                input.dispatchEvent(new Event('change'));
            ");
        }
    }
}
