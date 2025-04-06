using System;
using NUnit.Framework;
using OpenQA.Selenium;
using Reqnroll;

namespace DD_POM_BDT.PageClass.BranchManager.StepDefinitions
{
    [Binding]
    public class AddCustomerStepDefinitions : BranchManagerPage
    {
        [Given("User will be open the browser and go to url and login")]
        public void GivenUserWillBeOpenTheBrowserAndGoToUrlAndLogin()
        {

            DriverInitialized();
            OpenWindow();
            Thread.Sleep(5000);
            Login();
        }

        [When("User click the add user button")]
        public void WhenUserClickTheAddUserButton()
        {
            Thread.Sleep(5000);
            chromeDriver.FindElement(By.XPath(LocatorClass.addCustomerButton)).Click();
        }

        [When("Enter details")]
        public void WhenEnterDetails()
        {
            Thread.Sleep(5000);
            addCustomerDetails();

        }

        [When("Click add customer button")]
        public void WhenClickAddCustomerButton()
        {
            chromeDriver.FindElement(By.XPath(LocatorClass.addCustomerButtonSubmit)).Click();
        }

        [Then("User will be added in application")]
        public void ThenUserWillBeAddedInApplication()
        {
            Thread.Sleep(5000);
            addCustomerSubmit();
        }

        [Then("Close the browser now")]
        public void ThenCloseTheBrowserNow()
        {
            CloseWindow();
        }
    }
}
