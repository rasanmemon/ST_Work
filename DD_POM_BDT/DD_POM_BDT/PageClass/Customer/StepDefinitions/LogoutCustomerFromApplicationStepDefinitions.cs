using System;
using NUnit.Framework;
using OpenQA.Selenium;
using Reqnroll;

namespace DD_POM_BDT.PageClass.Customer.StepDefinitions
{
    [Binding]
    public class LogoutCustomerFromApplicationStepDefinitions : Customer
    {
        [Given("From browser to login")]
        public void GivenFromBrowserToLogin()
        {
            fromOpenBrowserToLogin();
        }

        [When("Click the logout button")]
        public void WhenClickTheLogoutButton()
        {
            Logout();
        }

        [Then("User will be logout from application")]
        public void ThenUserWillBeLogoutFromApplication()
        {
            Thread.Sleep(3000);
            var text = chromeDriver.FindElements(By.XPath(LocatorClass.userNameDropdown)).Count > 0;
            Assert.IsTrue(text);
        }

        [Then("close browser")]
        public void ThenCloseBrowser()
        {
            CloseWindow();
        }
    }
}
