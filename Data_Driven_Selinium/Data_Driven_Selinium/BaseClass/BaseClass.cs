using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Data_Driven_Selinium
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
            var jsonData = JObject.Parse(File.ReadAllText("D:\\FAST\\ST\\Code\\Data_Driven_Selinium\\Data_Driven_Selinium\\data.json"));
            var url = jsonData["url"].ToString();
            chromeDriver.Manage().Window.Maximize();
            chromeDriver.Navigate().GoToUrl(url);
        }
        public void CloseWindow()
        {
            chromeDriver.Close();
        }
    }

}
