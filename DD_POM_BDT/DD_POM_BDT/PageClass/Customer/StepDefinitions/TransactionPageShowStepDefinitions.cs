using System;
using NUnit.Framework;
using OpenQA.Selenium;
using Reqnroll;

namespace DD_POM_BDT.PageClass.Customer.StepDefinitions
{
    [Binding]
    public class TransactionPageShowStepDefinitions : Customer
    {
        [Given("Browser open to login")]
        public void GivenBrowserOpenToLogin()
        {
            fromOpenBrowserToLogin();
        }

        [When("Click the Transaction button")]
        public void WhenClickTheTransactionButton()
        {
            Thread.Sleep(1000);
            chromeDriver.FindElement(By.XPath(LocatorClass.transactionButton)).Click();
        }

        [Then("Transaction page shows")]
        public void ThenTransactionPageShows()
        {
            Thread.Sleep(3000);
            var text = chromeDriver.FindElements(By.XPath(LocatorClass.transactionTable)).Count > 0;
            Assert.IsTrue(text);
        }
        [Then("Reset the page")]
        public void ThenResetThePage()
        {
            resetTransaction();
            Thread.Sleep(3000);
            var text = chromeDriver.FindElements(By.XPath(LocatorClass.transactionTableRow0)).Count > 0;
            Assert.IsFalse(text);
        }

        [Then("Back to main page")]
        public void ThenBackToMainPage()
        {
            Thread.Sleep(1000);
            backtomainpage();
            Thread.Sleep(1000);
            var button = chromeDriver.FindElement(By.XPath(LocatorClass.transactionButton));
            Assert.IsTrue(button.Displayed);
        }

        [Then("close window now")]
        public void ThenCloseWindowNow()
        {
            CloseWindow();
        }
    }
}
