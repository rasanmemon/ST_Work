using Microsoft.Playwright;
using Reqnroll;

namespace BDT_Allure_DD_POM_Playwright
{
    [Binding]
    public sealed class Hooks1
    {
        IPlaywright playwright;
        public IPage page;

        [BeforeScenario]
        public async Task BeforeScenario()
        {
            playwright = await Playwright.CreateAsync();
            {
                var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
                {
                    Headless = false
                });
                page = await browser.NewPageAsync();
            }
        }
    }
}