using Microsoft.Playwright;

namespace Playwright_Testing
{
    public class PlaywrightTesting
    {
        IPlaywright playwright;
        IPage page;

        [Test]
        public async Task Test1()
        {
            playwright = await Playwright.CreateAsync();
            {
                var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
                {
                    Headless = false
            });
                page = await browser.NewPageAsync();

                await page.GotoAsync("https://www.saucedemo.com/");
                await page.FillAsync("#user-name", "standard_user");
                await page.FillAsync("#password", "secret_sauce");
                await page.ClickAsync("#login-button");
                Assert.That("Products", Is.EqualTo(await page.InnerTextAsync("//span[@class='title']")));
                //page.CloseAsync();

                await page.ClickAsync("#add-to-cart-sauce-labs-backpack");
                await page.ClickAsync("//span[@class='shopping_cart_badge']");
                await page.ScreenshotAsync(new PageScreenshotOptions { Path = "D:\\FAST\\ST\\Code\\Playwright_Testing\\Playwright_Testing\\screenshot\\Add_product.png" });
                await page.ClickAsync("#checkout");
                await page.ScreenshotAsync(new PageScreenshotOptions { Path = "D:\\FAST\\ST\\Code\\Playwright_Testing\\Playwright_Testing\\screenshot\\Checkout.png" });
                await page.FillAsync("#first-name", "standard_user");
                await page.FillAsync("#last-name", "standard_user");
                await page.FillAsync("#postal-code", "standard_user");
                await page.ScreenshotAsync(new PageScreenshotOptions { Path = "D:\\FAST\\ST\\Code\\Playwright_Testing\\Playwright_Testing\\screenshot\\shipment_details.png" });
                await page.ClickAsync("#continue");
                await page.ScreenshotAsync(new PageScreenshotOptions { Path = "D:\\FAST\\ST\\Code\\Playwright_Testing\\Playwright_Testing\\screenshot\\checkout_overview.png" });
                await page.ClickAsync("#finish");
                await page.ScreenshotAsync(new PageScreenshotOptions { Path = "D:\\FAST\\ST\\Code\\Playwright_Testing\\Playwright_Testing\\screenshot\\order_placed.png" });

                page.CloseAsync();

            }
        }
        [Test]
        public async Task Test2()
        {
            playwright = await Playwright.CreateAsync();
            {
                var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
                {
                    Headless = true
                });
                page = await browser.NewPageAsync();

                await page.GotoAsync("https://www.saucedemo.com/");
                await page.FillAsync("#user-name", "standard_user");
                await page.FillAsync("#password", "secret_sauce");
                await page.ClickAsync("#login-button");
                Assert.That("Products", Is.EqualTo(await page.InnerTextAsync("//span[@class='title']")));
                //page.CloseAsync();

                await page.ClickAsync("#add-to-cart-sauce-labs-backpack");
                await page.ClickAsync("//span[@class='shopping_cart_badge']");
                await page.ScreenshotAsync(new PageScreenshotOptions { Path = "D:\\FAST\\ST\\Code\\Playwright_Testing\\Playwright_Testing\\screenshot\\Add_product.png" });
                await page.ClickAsync("#checkout");
                await page.ScreenshotAsync(new PageScreenshotOptions { Path = "D:\\FAST\\ST\\Code\\Playwright_Testing\\Playwright_Testing\\screenshot\\Checkout.png" });
                await page.FillAsync("#first-name", "standard_user");
                await page.FillAsync("#last-name", "standard_user");
                await page.FillAsync("#postal-code", "standard_user");
                await page.ScreenshotAsync(new PageScreenshotOptions { Path = "D:\\FAST\\ST\\Code\\Playwright_Testing\\Playwright_Testing\\screenshot\\shipment_details.png" });
                await page.ClickAsync("#continue");
                await page.ScreenshotAsync(new PageScreenshotOptions { Path = "D:\\FAST\\ST\\Code\\Playwright_Testing\\Playwright_Testing\\screenshot\\checkout_overview.png" });
                await page.ClickAsync("#finish");
                await page.ScreenshotAsync(new PageScreenshotOptions { Path = "D:\\FAST\\ST\\Code\\Playwright_Testing\\Playwright_Testing\\screenshot\\order_placed.png" });
                page.CloseAsync();


            }
        }
    }
}