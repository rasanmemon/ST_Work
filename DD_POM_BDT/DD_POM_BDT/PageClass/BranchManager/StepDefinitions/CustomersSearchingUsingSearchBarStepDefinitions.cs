using System;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using Reqnroll;
using NUnit.Framework;
using static System.Net.Mime.MediaTypeNames;

namespace DD_POM_BDT.PageClass.BranchManager.StepDefinitions
{
    [Binding]
    public class CustomersSearchingUsingSearchBarStepDefinitions : BranchManagerPage
    {
        [Given("Steps till Open Account")]
        public void GivenStepsTillOpenAccount()
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
            Thread.Sleep(5000);
            openAccountSubmit();
        }

        [When("Click on the customer button")]
        public void WhenClickOnTheCustomerButton()
        {
            Thread.Sleep(5000);
            chromeDriver.FindElement(By.XPath(LocatorClass.customersbutton)).Click();
        }

        [When("Select the search bar and search as any detail")]
        public void WhenSelectTheSearchBarAndSearchAsAnyDetail()
        {
            Thread.Sleep(3000);
            searchCustomer();
        }

        [Then("The table show the user data on table")]
        public void ThenTheTableShowTheUserDataOnTable()
        {
            Thread.Sleep(3000);
            string text = chromeDriver.FindElement(By.XPath(LocatorClass.searchedrow)).Text;
            Assert.IsTrue(text.Contains(jsonData["searchfor"].ToString()));
        }

        [Then("Close the window")]
        public void ThenCloseTheWindow()
        {
            CloseWindow();
        }
    }
}
