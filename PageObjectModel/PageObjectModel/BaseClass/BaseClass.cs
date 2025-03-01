using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace PageObjectModel
{
    public class BaseClass
    {
        public static ChromeDriver chromeDriver;
        public void DriverInitialized()
        {
            chromeDriver = new ChromeDriver();
        }

        public void OpenWindow()
        {
            chromeDriver.Manage().Window.Maximize();
            chromeDriver.Navigate().GoToUrl("https://www.saucedemo.com/");
        }
        public void CloseWindow()
        {
            chromeDriver.Close();
        }
    }

}
