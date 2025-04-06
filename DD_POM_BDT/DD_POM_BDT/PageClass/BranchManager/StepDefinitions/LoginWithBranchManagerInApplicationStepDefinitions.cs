using System;
using NUnit.Framework;
using OpenQA.Selenium;
using Reqnroll;

namespace DD_POM_BDT.PageClass.BranchManager.StepDefinitions
{
    [Binding]
    public class LoginWithBranchManagerInApplicationStepDefinitions : BranchManagerPage
    {
        [Given("User will be open the browser and go to url")]
        public void GivenUserWillBeOpenTheBrowserAndGoToUrl()
        {
            DriverInitialized();
            OpenWindow();
        }

        [When("Select the branch Manager login button")]
        public void WhenSelectTheBranchManagerLoginButton()
        {
            Thread.Sleep(10000);
            Login();
        }

        [Then("BranchManager should be logged in to the application and application showed three buttons")]
        public void ThenBranchManagerShouldBeLoggedInToTheApplicationAndApplicationShowedThreeButtons()
        {
            Thread.Sleep(10000);
            var button = chromeDriver.FindElement(By.XPath(LocatorClass.addCustomerButton));
            Assert.IsTrue(button.Displayed);
        }

        [Then("Then Close the browser")]
        public void ThenThenCloseTheBrowser()
        {
            CloseWindow();
        }
    }
}
