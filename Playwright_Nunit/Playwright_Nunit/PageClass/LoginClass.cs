using Microsoft.Playwright;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playwright_Nunit.PageClass
{
    public class LoginClass : BaseClass
    {
        ILocator username;
        ILocator password;
        ILocator loginbutton;

        public LoginClass(IPage page)
        {
            _page = page;
            username = _page.Locator(LocatorClass.UserName);
            password = _page.Locator(LocatorClass.Password);
            loginbutton = _page.Locator(LocatorClass.LoginButton);
        }
        public async Task ValidLogin()
        {
            var jsonData = JObject.Parse(File.ReadAllText("D:\\FAST\\ST\\Code\\Playwright_Nunit\\Playwright_Nunit\\data.json"));
            string userName = jsonData["username"].ToString();
            await username.FillAsync(userName);
            string passwrod = jsonData["password"].ToString();
            await password.FillAsync(passwrod);
            await loginbutton.ClickAsync();
            string expectedValue = jsonData["expectedproducttext"].ToString();
            Assert.That(expectedValue, Is.EqualTo(await _page.InnerTextAsync(LocatorClass.ExpectedProductText)));
            await _page.ScreenshotAsync(new PageScreenshotOptions { Path = "D:\\FAST\\ST\\Code\\Playwright_Nunit\\Playwright_Nunit\\screenshot\\login_successfull.png" });

        }
        public async Task InvalidLogin()
        {
            var jsonData = JObject.Parse(File.ReadAllText("D:\\FAST\\ST\\Code\\Playwright_Nunit\\Playwright_Nunit\\data.json"));
            string userName = jsonData["invalidusername"].ToString();
            await username.FillAsync(userName);
            string passwrod = jsonData["invalidpassword"].ToString();
            await password.FillAsync(passwrod);
            await loginbutton.ClickAsync();
            string expectedValue = jsonData["expectedproducttextForinvalid"].ToString();
            Assert.That(expectedValue, Is.EqualTo(await _page.InnerTextAsync(LocatorClass.UnSuccesfulLoginText)));
            await _page.ScreenshotAsync(new PageScreenshotOptions { Path = "D:\\FAST\\ST\\Code\\Playwright_Nunit\\Playwright_Nunit\\screenshot\\login_unsuccessfull.png" });

        }
    }
}
