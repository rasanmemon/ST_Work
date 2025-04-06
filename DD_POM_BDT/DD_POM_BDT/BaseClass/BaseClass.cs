using Newtonsoft.Json.Linq;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DD_POM_BDT
{
    public class BaseClass
    {
        protected JObject? jsonData;
        public static ChromeDriver? chromeDriver;
        public void DriverInitialized()
        {
            chromeDriver = new ChromeDriver();
            jsonData = JObject.Parse(File.ReadAllText("D:\\FAST\\ST\\Code\\DD_POM_BDT\\DD_POM_BDT\\data.json"));

        }

        public void OpenWindow()
        {
            var url = jsonData["url"].ToString();
            chromeDriver.Manage().Window.Maximize();
            chromeDriver.Navigate().GoToUrl(url);
        }
        public void CloseWindow()
        {
            chromeDriver.Close();
            chromeDriver.Quit();
        }
    }
}
