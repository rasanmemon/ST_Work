using Microsoft.Playwright;
using static System.Net.Mime.MediaTypeNames;

namespace Playwright_XYZBank
{
    public class Tests
    {
        IPlaywright playwright;
        IPage page;
        

        [Test]
        public async Task AddCustomer()
        {
            playwright = await Playwright.CreateAsync();
            {
                var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
                {
                    Headless = false
                });
                //Open Browser
                page = await browser.NewPageAsync();
                //Open URl
                await page.GotoAsync("https://www.globalsqa.com/angularJs-protractor/BankingProject/#/login");
                // Login as Bank Manager
                await page.ClickAsync("//button[normalize-space()='Bank Manager Login']");
                // Click Add Customer
                await page.ClickAsync("//button[normalize-space()='Add Customer']");
                //Fill details
                await page.FillAsync("//input[@placeholder='First Name']", "Morris");
                await page.FillAsync("//input[@placeholder='Last Name']", "Jhon");
                await page.FillAsync("//input[@placeholder='Post Code']", "56981");
                Thread.Sleep(2000);
                //Click Submit
                await page.ClickAsync("//button[@type='submit']");
            }
        }
        [Test]
        public async Task OpenAccount()
        {
            playwright = await Playwright.CreateAsync();
            {
                var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
                {
                    Headless = false
                });

                //Open Browser
                page = await browser.NewPageAsync();
                //Open URl
                await page.GotoAsync("https://www.globalsqa.com/angularJs-protractor/BankingProject/#/login");
                // Login as Bank Manager
                await page.ClickAsync("//button[normalize-space()='Bank Manager Login']");
                // Click Add Customer
                await page.ClickAsync("//button[normalize-space()='Add Customer']");
                //Fill details
                await page.FillAsync("//input[@placeholder='First Name']", "Morris");
                await page.FillAsync("//input[@placeholder='Last Name']", "Jhon");
                await page.FillAsync("//input[@placeholder='Post Code']", "56981");
                Thread.Sleep(2000);
                //Click Submit
                await page.ClickAsync("//button[@type='submit']");
                //CLick Open Account button
                await page.ClickAsync("//button[normalize-space()='Open Account']");
                // Select user name and current
                await page.SelectOptionAsync("#userSelect", "Morris Jhon");
                await page.SelectOptionAsync("#currency", "Rupee");
                // Click process button
                await page.ClickAsync("//button[normalize-space()='Process']");

            }
        }
        [Test]
        public async Task CustomersSearchandDelete()
        {
            playwright = await Playwright.CreateAsync();
            {
                var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
                {
                    Headless = false
                });

                //Open Browser
                page = await browser.NewPageAsync();
                //Open URl
                await page.GotoAsync("https://www.globalsqa.com/angularJs-protractor/BankingProject/#/login");
                // Login as Bank Manager
                await page.ClickAsync("//button[normalize-space()='Bank Manager Login']");
                // Click Add Customer
                await page.ClickAsync("//button[normalize-space()='Add Customer']");
                //Fill details
                await page.FillAsync("//input[@placeholder='First Name']", "Morris");
                await page.FillAsync("//input[@placeholder='Last Name']", "Jhon");
                await page.FillAsync("//input[@placeholder='Post Code']", "56981");
                Thread.Sleep(2000);
                //Click Submit
                await page.ClickAsync("//button[@type='submit']");

                //CLick Open Account button
                await page.ClickAsync("//button[normalize-space()='Open Account']");
                // Select user name and current
                await page.SelectOptionAsync("#userSelect", "Morris Jhon");
                await page.SelectOptionAsync("#currency", "Rupee");
                // Click process button
                await page.ClickAsync("//button[normalize-space()='Process']");
                //Click Customer Button
                await page.ClickAsync("//button[normalize-space()='Customers']");
                //Write name on search bar
                await page.FillAsync("//input[@placeholder='Search Customer']", "Morris");
                // Delete user
                await page.ClickAsync("//tbody/tr[1]/td[5]/button[1]");


            }
        }
    }
}