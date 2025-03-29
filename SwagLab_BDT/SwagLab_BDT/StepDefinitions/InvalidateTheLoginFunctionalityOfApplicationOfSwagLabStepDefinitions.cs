using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Reqnroll;

namespace SwagLab_BDT.StepDefinitions
{
    [Binding]
    public class InvalidateTheLoginFunctionalityOfApplicationOfSwagLabStepDefinitions
    {
        //Initialize Chrome Driver
        ChromeDriver chromeDriver = new ChromeDriver();
        string expectedValue = "Epic sadface: Username and password do not match any user in this service";

        [Given("User will be able open the browser and go to the url")]
        public void GivenUserWillBeAbleOpenTheBrowserAndGoToTheUrl()
        {
            //open Browser Window in Maximize mode
            chromeDriver.Manage().Window.Maximize();
            // Open Url in Browser
            chromeDriver.Navigate().GoToUrl("https://www.saucedemo.com/");
        }

        [When("Enter the invalid Login id")]
        public void WhenEnterTheInvalidLoginId()
        {
            // Find element by ID and enter its value
            chromeDriver.FindElement(By.Id("user-name")).SendKeys("abc");
        }

        [When("Enter the invalid password")]
        public void WhenEnterTheInvalidPassword()
        {
            // Find element by ID and enter its value
            chromeDriver.FindElement(By.Id("password")).SendKeys("xyz");
        }

        [When("Click the login button")]
        public void WhenClickTheLoginButton()
        {
            //Find button and click on it
            chromeDriver.FindElement(By.Id("login-button")).Click();

        }

        [Then("User should not be logged in to the application and application showed error")]
        public void ThenUserShouldNotBeLoggedInToTheApplicationAndApplicationShowedError()
        {
            // Get Value from Xpath 
            string actualValue = chromeDriver.FindElement(By.XPath("//h3[@data-test='error']")).Text;
            //Check actual and expected , if test pass chrome will close other will not close
            Assert.AreEqual(expectedValue, actualValue);

            chromeDriver.Close();
        }
    }
}
