using Microsoft.Playwright;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playwright_Nunit.PageClass
{
    public class ShipmentClass : BaseClass
    {
        ILocator firstname;
        ILocator lastname;
        ILocator zipcode;
        ILocator continueButton;
        ILocator finishButton;
        public ShipmentClass(IPage page) {
            _page = page;
            firstname = _page.Locator(LocatorClass.FirstName) ;
            lastname = _page.Locator(LocatorClass.LastName);
            zipcode = _page.Locator(LocatorClass.Zipcode);
            continueButton= _page.Locator(LocatorClass.ContinueButton);
            finishButton = _page.Locator(LocatorClass.FinishButton);
        }
        public async Task ShipInfoAsync()
        {
            var jsonData = JObject.Parse(File.ReadAllText("D:\\FAST\\ST\\Code\\Playwright_Nunit\\Playwright_Nunit\\data.json"));
            string firstName = jsonData["firstname"].ToString();
            await firstname.FillAsync(firstName);

            string lastName = jsonData["lastname"].ToString();
            await lastname.FillAsync(lastName);

            string zipCode = jsonData["zipcode"].ToString();
            await zipcode.FillAsync(zipCode);
            await _page.ScreenshotAsync(new PageScreenshotOptions { Path = "D:\\FAST\\ST\\Code\\Playwright_Nunit\\Playwright_Nunit\\screenshot\\fillDetail.png" });

        }
        public async Task OrderPlaceAsync()
        {
            var jsonData = JObject.Parse(File.ReadAllText("D:\\FAST\\ST\\Code\\Playwright_Nunit\\Playwright_Nunit\\data.json"));

            await continueButton.ClickAsync();
            await _page.ScreenshotAsync(new PageScreenshotOptions { Path = "D:\\FAST\\ST\\Code\\Playwright_Nunit\\Playwright_Nunit\\screenshot\\OrderNumber.png" });
            string expectedValue = jsonData["orderNoConfirmed"].ToString();
            Assert.That(expectedValue, Is.EqualTo(await _page.InnerTextAsync(LocatorClass.OrderNumber)));
            await finishButton.ClickAsync();
            string confirmationMsg = jsonData["orderconfirmationtext"].ToString();
            Assert.That(confirmationMsg, Is.EqualTo(await _page.InnerTextAsync(LocatorClass.OrderConfirmation)));
            await _page.ScreenshotAsync(new PageScreenshotOptions { Path = "D:\\FAST\\ST\\Code\\Playwright_Nunit\\Playwright_Nunit\\screenshot\\orderConfirmation.png" });

        }
    }
}
