using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Reqnroll;

namespace SwagLab_BDT.StepDefinitions
{
    [Binding]
    public class CompleteOrderPlacementOnSwagLabWebApplicationStepDefinitions
    {
        ChromeDriver chromeDriver = new ChromeDriver();
        string expectedValue;
        string actualValue;
        [Given("User will be open the browser and go to url")]
        public void GivenUserWillBeOpenTheBrowserAndGoToUrl()
        {
            chromeDriver.Manage().Window.Maximize();
            chromeDriver.Navigate().GoToUrl("https://www.saucedemo.com/");
        }

        [When("Enter the Login id and Password and click login button")]
        public void WhenEnterTheLoginIdAndPasswordAndClickLoginButton()
        {
            chromeDriver.FindElement(By.Id("user-name")).SendKeys("standard_user");
            chromeDriver.FindElement(By.Id("password")).SendKeys("secret_sauce");
            chromeDriver.FindElement(By.Id("login-button")).Click();
        }

        [When("Add a Product in cart and proceed to check out")]
        public void WhenAddAProductInCartAndProceedToCheckOut()
        {
            chromeDriver.FindElement(By.Id("add-to-cart-sauce-labs-backpack")).Click();
            chromeDriver.FindElement(By.Id("add-to-cart-sauce-labs-bike-light")).Click();
            chromeDriver.FindElement(By.XPath("//a[@class='shopping_cart_link']")).Click();
        }

        [When("Click the checkout button")]
        public void WhenClickTheCheckoutButton()
        {
            chromeDriver.FindElement(By.Id("checkout")).Click();
        }

        [When("Enter shipping Details")]
        public void WhenEnterShippingDetails()
        {
            chromeDriver.FindElement(By.Id("first-name")).SendKeys("ABC");
            chromeDriver.FindElement(By.Id("last-name")).SendKeys("XYZ");
            chromeDriver.FindElement(By.Id("postal-code")).SendKeys("75800");
            chromeDriver.FindElement(By.Id("continue")).Click();
        }

        [Then("Validate the order information  and total amount and finish order")]
        public void ThenValidateTheOrderInformationAndTotalAmountAndFinishOrder()
        {
            expectedValue = "SauceCard #31337";
            actualValue = chromeDriver.FindElement(By.XPath("//div[contains(text(),'SauceCard #31337')]")).Text;
            Assert.AreEqual(expectedValue, actualValue);
            chromeDriver.FindElement(By.Id("finish")).Click();
        }

        [Then("Validate the order has been placed")]
        public void ThenValidateTheOrderHasBeenPlaced()
        {
            expectedValue = "Thank you for your order!";
            actualValue = chromeDriver.FindElement(By.XPath("//h2[@class='complete-header']")).Text;
            Assert.AreEqual(expectedValue, actualValue);
        }

        [Then("close the browser")]
        public void ThenCloseTheBrowser()
        {
            chromeDriver.Close();
        }
    }
}
