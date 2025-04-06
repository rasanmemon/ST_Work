using System;
using Newtonsoft.Json.Linq;
using NUnit.Framework;
using OpenQA.Selenium;
using Reqnroll;

namespace DD_POM_BDT.PageClass.BranchManager.StepDefinitions
{
    [Binding]
    public class OpenAccountOfCustomerStepDefinitions : BranchManagerPage
    {

        [Given("Steps till Add Customer")]
        public void GivenStepsTillAddCustomer()
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
        }

        [When("Now Click Open Account Button")]
        public void WhenNowClickOpenAccountButton()
        {
            Thread.Sleep(5000);
            chromeDriver.FindElement(By.XPath(LocatorClass.openAccountButton)).Click();
        }

        [When("Select Customer and its Currency")]
        public void WhenSelectCustomerAndItsCurrency()
        {
            Thread.Sleep(5000);
            openAccount();
        }

        [When("Click Process button")]
        public void WhenClickProcessButton()
        {
            chromeDriver.FindElement(By.XPath(LocatorClass.processButton)).Click();

        }

        [Then("Alert will generate which tell account is created.")]
        public void ThenAlertWillGenerateWhichTellAccountIsCreated_()
        {
            Thread.Sleep(5000);

            openAccountSubmit();
        }

        [Then("Now Close browser")]
        public void ThenNowCloseBrowser()
        {
            CloseWindow();
        }
    }
}
