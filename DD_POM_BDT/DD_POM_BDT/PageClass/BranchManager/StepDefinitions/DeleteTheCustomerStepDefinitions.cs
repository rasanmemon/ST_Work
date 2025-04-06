using System;
using NUnit.Framework;
using OpenQA.Selenium;
using Reqnroll;

namespace DD_POM_BDT.PageClass.BranchManager.StepDefinitions
{
    [Binding]
    public class DeleteTheCustomerStepDefinitions : BranchManagerPage
    {
        [Given("Steps till Search Customer")]
        public void GivenStepsTillSearchCustomer()
        {
            DriverInitialized();
            OpenWindow();
            Thread.Sleep(5000);
            Login();
            Thread.Sleep(5000);
            chromeDriver.FindElement(By.XPath(LocatorClass.addCustomerButton)).Click();
            Thread.Sleep(5000);
            addCustomerDetails();
            Thread.Sleep(5000);
            chromeDriver.FindElement(By.XPath(LocatorClass.addCustomerButtonSubmit)).Click();
            addCustomerSubmit();
            Thread.Sleep(5000);
            chromeDriver.FindElement(By.XPath(LocatorClass.openAccountButton)).Click();
            Thread.Sleep(5000);
            openAccount();
            chromeDriver.FindElement(By.XPath(LocatorClass.processButton)).Click();
            Thread.Sleep(3000);
            openAccountSubmit();
            Thread.Sleep(1000);
            chromeDriver.FindElement(By.XPath(LocatorClass.customersbutton)).Click();
            Thread.Sleep(3000);
            searchCustomer();
            string text = chromeDriver.FindElement(By.XPath(LocatorClass.searchedrow)).Text;
            Assert.IsTrue(text.Contains(jsonData["searchfor"].ToString()));
        }

        [When("Click the delete button of user want to delete")]
        public void WhenClickTheDeleteButtonOfUserWantToDelete()
        {
            Thread.Sleep(3000);

            chromeDriver.FindElement(By.XPath(LocatorClass.deleteButton)).Click();

        }

        [Then("Customers data will be deleted")]
        public void ThenCustomersDataWillBeDeleted()
        {
            Thread.Sleep(3000);
            var text = chromeDriver.FindElements(By.XPath(LocatorClass.searchedrow)).Count > 0;
            Assert.IsFalse(text);
        }

        [Then("Close window")]
        public void ThenCloseWindow()
        {
            CloseWindow();
        }
    }
}
