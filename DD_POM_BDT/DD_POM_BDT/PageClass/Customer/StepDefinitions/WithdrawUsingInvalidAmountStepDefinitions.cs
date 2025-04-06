using System;
using NUnit.Framework;
using OpenQA.Selenium;
using Reqnroll;

namespace DD_POM_BDT.PageClass.Customer.StepDefinitions
{
    [Binding]
    public class WithdrawUsingInvalidAmountStepDefinitions : Customer
    {
        [Given("From Open browser till login")]
        public void GivenFromOpenBrowserTillLogin()
        {
            fromOpenBrowserToLogin();
        }

        [When("Click the withdrawl button and enter invalid amount")]
        public void WhenClickTheWithdrawlButtonAndEnterInvalidAmount()
        {
            Thread.Sleep(1000);
            chromeDriver.FindElement(By.XPath(LocatorClass.withdrawButton)).Click();
            Thread.Sleep(1000);
            chromeDriver.FindElement(By.XPath(LocatorClass.withdrawInput)).SendKeys(jsonData["invalidamountWithdrawl"].ToString());
        }

        [When("Click the withdrawl submit button")]
        public void WhenClickTheWithdrawlSubmitButton()
        {
            chromeDriver.FindElement(By.XPath(LocatorClass.withdrawSubmitButton)).Click();
        }

        [Then("Amount will not be withdrawl from account")]
        public void ThenAmountWillNotBeWithdrawlFromAccount()
        {
            var expectedValue = jsonData["invalidExpectedResultforWithdrawl"].ToString();
            Thread.Sleep(1000);
            string actualValue = chromeDriver.FindElement(By.XPath(LocatorClass.withdrawResultArea)).Text;
            Assert.AreEqual(expectedValue, actualValue);
        }

        [Then("Close the browser window")]
        public void ThenCloseTheBrowserWindow()
        {
            CloseWindow();
        }
    }
}
