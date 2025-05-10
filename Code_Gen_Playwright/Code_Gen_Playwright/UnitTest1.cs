using Microsoft.Playwright.NUnit;
using Microsoft.Playwright;

namespace Code_Gen_Playwright
{
    
    public class Tests
    {
        [Test]
        public async Task MyTest()
        {
            using var playwright = await Playwright.CreateAsync();
            await using var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
            {
                Headless = false,
            });
            var context = await browser.NewContextAsync();

            var page = await context.NewPageAsync();
            await page.GotoAsync("https://www.saucedemo.com/");
            await page.Locator("[data-test=\"username\"]").ClickAsync();
            await page.Locator("[data-test=\"username\"]").FillAsync("standard_user");
            await page.Locator("[data-test=\"password\"]").ClickAsync();
            await page.Locator("[data-test=\"password\"]").FillAsync("secret_sauce");
            await page.Locator("[data-test=\"login-button\"]").ClickAsync();
            await page.Locator("[data-test=\"add-to-cart-sauce-labs-backpack\"]").ClickAsync();
            await page.Locator("[data-test=\"shopping-cart-link\"]").ClickAsync();
            await page.Locator("[data-test=\"checkout\"]").ClickAsync();
            await page.Locator("[data-test=\"firstName\"]").ClickAsync();
            await page.Locator("[data-test=\"firstName\"]").FillAsync("rasan");
            await page.Locator("[data-test=\"lastName\"]").ClickAsync();
            await page.Locator("[data-test=\"lastName\"]").FillAsync("rafiq");
            await page.Locator("[data-test=\"postalCode\"]").ClickAsync();
            await page.Locator("[data-test=\"postalCode\"]").FillAsync("75800");
            await page.Locator("[data-test=\"continue\"]").ClickAsync();
            await page.Locator("[data-test=\"finish\"]").ClickAsync();
        }
    }
}