using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Newtonsoft.Json.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Data_Driven_Selinium_XML
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
            XElement xelement = XElement.Load(@"D:\FAST\ST\Code\Data_Driven_Selinium_XML\Data_Driven_Selinium_XML\data.xml");
            string url = xelement.Element("url").Value;
            chromeDriver.Manage().Window.Maximize();
            chromeDriver.Navigate().GoToUrl(url);
        }
        public void CloseWindow()
        {
            chromeDriver.Close();
        }
    }

}
