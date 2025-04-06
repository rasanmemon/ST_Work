using System;
using NUnit.Framework;
using OpenQA.Selenium;
using Reqnroll;

namespace DD_POM_BDT.PageClass.Customer.StepDefinitions
{
    [Binding]
    public class WithdrawAmountUsingValidStepDefinitions : Customer
    {
        [Given("Open browser till login")]
        public void GivenOpenBrowserTillLogin()
        {
            fromOpenBrowserToLogin();
        }

        [When("Click the withdrawl button and enter amount")]
        public void WhenClickTheWithdrawlButtonAndEnterAmount()
        {
            Thread.Sleep(1000);
            chromeDriver.FindElement(By.XPath(LocatorClass.withdrawButton)).Click();
            Thread.Sleep(1000);
            chromeDriver.FindElement(By.XPath(LocatorClass.withdrawInput)).SendKeys(jsonData["amountWithdrawl"].ToString());
        }

        [When("Click withdrawl submit button")]
        public void WhenClickWithdrawlSubmitButton()
        {
            chromeDriver.FindElement(By.XPath(LocatorClass.withdrawSubmitButton)).Click();
        }

        [Then("Amount will be withdrawl from account")]
        public void ThenAmountWillBeWithdrawlFromAccount()
        {
            var expectedValue = jsonData["validExpectedResultforWithdrawl"].ToString();
            Thread.Sleep(1000);
            string actualValue = chromeDriver.FindElement(By.XPath(LocatorClass.withdrawResultArea)).Text;
            Assert.AreEqual(expectedValue, actualValue);
        }

        [Then("Close the window now")]
        public void ThenCloseTheWindowNow()
        {
            CloseWindow();
        }
    }
}
