using System;
using NUnit.Framework;
using OpenQA.Selenium;
using Reqnroll;

namespace DD_POM_BDT.PageClass.Customer.StepDefinitions
{
    [Binding]
    public class CheckTransactionBetweenDatesStepDefinitions : Customer
    {
        [Given("Open Browser to Transaction option")]
        public void GivenOpenBrowserToTransactionOption()
        {
            fromOpenBrowserToLogin();
            Thread.Sleep(1000);
            chromeDriver.FindElement(By.XPath(LocatorClass.transactionButton)).Click();
        }

        [When("Set Start and End Date")]
        public void WhenSetStartAndEndDate()
        {
            Thread.Sleep(3000);
            changeStartDate();
            Thread.Sleep(3000);
            changeendDate();
        }

        [Then("Get records of between dates")]
        public void ThenGetRecordsOfBetweenDates()
        {
            Thread.Sleep(5000);
            var text = chromeDriver.FindElements(By.XPath(LocatorClass.transactionTableRow0)).Count > 0;
            Assert.IsTrue(text);
        }

        [Then("close the window now")]
        public void ThenCloseTheWindowNow()
        {
            CloseWindow();
        }
    }
}
