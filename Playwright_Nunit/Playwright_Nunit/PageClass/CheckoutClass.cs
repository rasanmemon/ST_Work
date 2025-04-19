using Microsoft.Playwright;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playwright_Nunit.PageClass
{
    public class CheckoutClass : BaseClass
    {
        ILocator Product1;
        ILocator Product2;
        ILocator CartLink;
        ILocator CheckoutButton;

        public CheckoutClass(IPage page)
        {
            _page = page;
            Product1 = _page.Locator(LocatorClass.product1);
            Product2 = _page.Locator(LocatorClass.product2);
            CartLink = _page.Locator(LocatorClass.CartLink);
            CheckoutButton = _page.Locator(LocatorClass.CheckoutButton);


        }
        public async Task AddToCart()
        {
            var jsonData = JObject.Parse(File.ReadAllText("D:\\FAST\\ST\\Code\\Playwright_Nunit\\Playwright_Nunit\\data.json"));
            await Product1.ClickAsync();
            await Product2.ClickAsync();
            await CartLink.ClickAsync();
            await _page.ScreenshotAsync(new PageScreenshotOptions { Path = "D:\\FAST\\ST\\Code\\Playwright_Nunit\\Playwright_Nunit\\screenshot\\Cart.png" });
            await CheckoutButton.ClickAsync();
            string expectedValue = jsonData["expectedcheckouttext"].ToString();
            Assert.That(expectedValue, Is.EqualTo(await _page.InnerTextAsync(LocatorClass.ExpectedCheckoutText)));
            await _page.ScreenshotAsync(new PageScreenshotOptions { Path = "D:\\FAST\\ST\\Code\\Playwright_Nunit\\Playwright_Nunit\\screenshot\\Checkout.png" });

        }
    }
}
