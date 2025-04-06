using System;
using NUnit.Framework;
using OpenQA.Selenium;
using Reqnroll;

namespace DD_POM_BDT.PageClass.Customer.StepDefinitions
{
    [Binding]
    public class DepositAmountStepDefinitions: Customer
    {
        [Given("User will be open the browser and go to the url and login")]
        public void GivenUserWillBeOpenTheBrowserAndGoToTheUrlAndLogin()
        {
            fromOpenBrowserToLogin();

        }

        [When("Click the deposit button and enter amount")]
        public void WhenClickTheDepositButtonAndEnterAmount()
        {
            Thread.Sleep(1000);
            chromeDriver.FindElement(By.XPath(LocatorClass.depositButton)).Click();
            Thread.Sleep(1000);
            chromeDriver.FindElement(By.XPath(LocatorClass.depositInput)).SendKeys(jsonData["amountDeposited"].ToString());
        }

        [When("Click deposit submit button")]
        public void WhenClickDepositSubmitButton()
        {
            chromeDriver.FindElement(By.XPath(LocatorClass.depositSubmitButton)).Click();
        }


        [Then("Amount will be deposited in account")]
        public void ThenAmountWillBeDepositedInAccount()
        {
            var expectedValue = jsonData["expectedResultforDeposited"].ToString();
            Thread.Sleep(1000);
            string actualValue = chromeDriver.FindElement(By.XPath(LocatorClass.depositResultArea)).Text;
            Assert.AreEqual(expectedValue, actualValue);

        }

        [Then("Close window now")]
        public void ThenCloseWindowNow()
        {
            //CloseWindow();
        }
    }
}
