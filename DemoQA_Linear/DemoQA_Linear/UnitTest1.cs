using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace DemoQA_Linear
{
    public class Form_Test
    {
        

        [Test]
        public void Test1()
        {
            ChromeDriver chromeDriver = new ChromeDriver();
            chromeDriver.Manage().Window.Maximize();
            chromeDriver.Navigate().GoToUrl("https://demoqa.com/automation-practice-form");

            Thread.Sleep(2000);
            chromeDriver.FindElement(By.Id("firstName")).SendKeys("standard_user");
            chromeDriver.FindElement(By.Id("lastName")).SendKeys("secret_sauce");
            chromeDriver.FindElement(By.Id("userEmail")).SendKeys("abc@abc.com");
            chromeDriver.FindElement(By.XPath("//label[@for='gender-radio-1']")).Click();
            chromeDriver.FindElement(By.Id("userNumber")).SendKeys("3123456789");

            chromeDriver.FindElement(By.Id("currentAddress")).SendKeys("Karachi");

            chromeDriver.FindElement(By.Id("submit")).Click();
            chromeDriver.Close();
        }
    }
}