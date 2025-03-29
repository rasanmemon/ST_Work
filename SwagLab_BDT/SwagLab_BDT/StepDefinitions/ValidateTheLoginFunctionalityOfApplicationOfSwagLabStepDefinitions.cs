using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Reqnroll;

namespace SwagLab_BDT.StepDefinitions
{
    [Binding]
    public class ValidateTheLoginFunctionalityOfApplicationOfSwagLabStepDefinitions
    {
        //Initialize Chrome Driver
        ChromeDriver chromeDriver = new ChromeDriver();
        string expectedValue = "Products";

        [Given("User will be open the browser and go to the url")]
        public void GivenUserWillBeOpenTheBrowserAndGoToTheUrl()
        {            
            //open Browser Window in Maximize mode
            chromeDriver.Manage().Window.Maximize();
            // Open Url in Browser
            chromeDriver.Navigate().GoToUrl("https://www.saucedemo.com/");
        }

        [When("Enter the valid Login id")]
        public void WhenEnterTheValidLoginId()
        {
            // Find element by ID and enter its value
            chromeDriver.FindElement(By.Id("user-name")).SendKeys("standard_user");
        }

        [When("Enter the password")]
        public void WhenEnterThePassword()
        {
            // Find element by ID and enter its value
            chromeDriver.FindElement(By.Id("password")).SendKeys("secret_sauce");
        }

        [When("Click login button")]
        public void WhenClickLoginButton()
        {
            //Find button and click on it
            chromeDriver.FindElement(By.Id("login-button")).Click();
        }

        [Then("User should be logged in to the application and application showed Product page")]
        public void ThenUserShouldBeLoggedInToTheApplicationAndApplicationShowedProductPage()
        {
            // Get Value from Xpath 
            string actualValue = chromeDriver.FindElement(By.XPath("//span[@class='title']")).Text;
            //Check actual and expected , if test pass chrome will close other will not close
            Assert.AreEqual(expectedValue, actualValue);

            chromeDriver.Close();
        }
    }
}
