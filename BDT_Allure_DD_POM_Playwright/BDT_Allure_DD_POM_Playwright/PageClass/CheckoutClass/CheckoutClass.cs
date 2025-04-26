using Microsoft.Playwright;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDT_Allure_DD_POM_Playwright.PageClass.CheckoutClass
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
            await Product1.ClickAsync();
            await Product2.ClickAsync();
            await CartLink.ClickAsync();
            await _page.ScreenshotAsync(new PageScreenshotOptions { Path = "D:\\FAST\\ST\\Code\\BDT_Allure_DD_POM_Playwright\\BDT_Allure_DD_POM_Playwright\\screenshot\\Cart.png" });
            await CheckoutButton.ClickAsync();
            

        }
        public async Task AddToCartAssert()
        {
            var jsonData = JObject.Parse(File.ReadAllText("D:\\FAST\\ST\\Code\\BDT_Allure_DD_POM_Playwright\\BDT_Allure_DD_POM_Playwright\\data.json"));
            string expectedValue = jsonData["expectedcheckouttext"].ToString();
            Assert.That(expectedValue, Is.EqualTo(await _page.InnerTextAsync(LocatorClass.ExpectedCheckoutText)));
            await _page.ScreenshotAsync(new PageScreenshotOptions { Path = "D:\\FAST\\ST\\Code\\BDT_Allure_DD_POM_Playwright\\BDT_Allure_DD_POM_Playwright\\screenshot\\Checkout.png" });
        }
    }
}
