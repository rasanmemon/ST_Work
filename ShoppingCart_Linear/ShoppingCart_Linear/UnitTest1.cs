using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace ShoppingCart_Linear
{
    public class SwagLabsTests
    {


        [Test]
        public void LoginTest()
        {
            string expectedValue = "Products";
            //Initialize Chrome Driver
            ChromeDriver chromeDriver = new ChromeDriver();
            //open Browser Window in Maximize mode
            chromeDriver.Manage().Window.Maximize();
            // Open Url in Browser
            chromeDriver.Navigate().GoToUrl("https://www.saucedemo.com/");
            // Find element by ID and enter its value
            chromeDriver.FindElement(By.Id("user-name")).SendKeys("standard_user");
            // Find element by ID and enter its value
            chromeDriver.FindElement(By.Id("password")).SendKeys("secret_sauce");
            //Find button and click on it
            chromeDriver.FindElement(By.Id("login-button")).Click();
            // Get Value from Xpath 
            string actualValue = chromeDriver.FindElement(By.XPath("//span[@class='title']")).Text;
            //Check actual and expected , if test pass chrome will close other will not close
            Assert.AreEqual(expectedValue, actualValue);

            //Click on add to cart
            chromeDriver.FindElement(By.Id("add-to-cart-sauce-labs-backpack")).Click();
            chromeDriver.FindElement(By.Id("add-to-cart-sauce-labs-bike-light")).Click();

            // Click Cart  and cart will open
            chromeDriver.FindElement(By.XPath("//a[@class='shopping_cart_link']")).Click();

            //CLick the check out button
            chromeDriver.FindElement(By.Id("checkout")).Click();

            //Fill values
            chromeDriver.FindElement(By.Id("first-name")).SendKeys("ABC");
            chromeDriver.FindElement(By.Id("last-name")).SendKeys("XYZ");
            chromeDriver.FindElement(By.Id("postal-code")).SendKeys("75800");

            //Click Continue
            chromeDriver.FindElement(By.Id("continue")).Click();

            //Click Finish
            chromeDriver.FindElement(By.Id("finish")).Click(); 

            //Check the heading is same or not
            expectedValue = "Thank you for your order!";
            actualValue = chromeDriver.FindElement(By.XPath("//h2[normalize-space()='Thank you for your order!']")).Text;
            Assert.AreEqual(expectedValue, actualValue);

            //Check the paragraph is same or not
            expectedValue = "Your order has been dispatched, and will arrive just as fast as the pony can get there!";
            actualValue = chromeDriver.FindElement(By.XPath("//div[@class='complete-text']")).Text;
            Assert.AreEqual(expectedValue, actualValue);

            //Click Back to home
            chromeDriver.FindElement(By.Id("back-to-products")).Click();

            // Close the instance
            chromeDriver.Close();

        }
    }
}