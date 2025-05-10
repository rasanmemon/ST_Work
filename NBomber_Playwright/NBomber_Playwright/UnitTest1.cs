using Microsoft.Playwright;
using NBomber.Contracts;
using NBomber.Contracts.Stats;
using NBomber.CSharp;
using NBomber.Http;

namespace NBomber_Playwright
{
    public class Tests
    {
        [Test]
        public async Task LoadTestWebApplicationRampInject()
        {
            var playwright = await Playwright.CreateAsync();
            var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
            {
                Headless = false
            });

            var scenario = Scenario.Create("Load Test with Playwright in SwagLab", async context =>
            {
                var page = await browser.NewPageAsync();

                await page.GotoAsync("https://www.saucedemo.com/");
                await page.FillAsync("#user-name", "standard_user");
                await page.FillAsync("#password", "secret_sauce");
                await page.ClickAsync("#login-button");

                return Response.Ok();
            })
            .WithLoadSimulations(LoadSimulation.NewRampingInject(50, TimeSpan.FromSeconds(40), TimeSpan.FromMinutes(1)));
            var result = NBomberRunner.RegisterScenarios(scenario)
                .WithReportFolder("ReportsRampInject")
                .WithReportFormats(ReportFormat.Html, ReportFormat.Txt, ReportFormat.Csv)
                .WithWorkerPlugins(new HttpMetricsPlugin(new[] { HttpVersion.Version1 }))
                .Run();
            Assert.True(result.ScenarioStats.Get("Load Test with Playwright in SwagLab").Ok.Latency.Percent75 < 45000);
        }

        [Test]
        public async Task LoadTestWebApplicationInject()
        {
             var playwright = await Playwright.CreateAsync();
            var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
            {
                    Headless = false
            });

            var scenario = Scenario.Create("Load Test with Playwright in SwagLab", async context =>
            {
                var page = await browser.NewPageAsync();

                await page.GotoAsync("https://www.saucedemo.com/");
                await page.FillAsync("#user-name", "standard_user");
                await page.FillAsync("#password", "secret_sauce");
                await page.ClickAsync("#login-button");

                return Response.Ok();
            })
            .WithLoadSimulations(LoadSimulation.NewInject(50, TimeSpan.FromSeconds(40), TimeSpan.FromMinutes(1)));
            var result = NBomberRunner.RegisterScenarios(scenario)
                .WithReportFolder("ReportsInject")
                .WithReportFormats(ReportFormat.Html, ReportFormat.Txt, ReportFormat.Csv)
                .WithWorkerPlugins(new HttpMetricsPlugin(new[] { HttpVersion.Version1 }))
                .Run();
            Assert.True(result.ScenarioStats.Get("Load Test with Playwright in SwagLab").Ok.Latency.Percent75 < 64000);
        }

        [Test]
        public async Task LoadTestWebApplicationRampingConstant()
        {
            var playwright = await Playwright.CreateAsync();
            var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
            {
                Headless = false
            });

            var scenario = Scenario.Create("Load Test with Playwright in SwagLab", async context =>
            {
                var page = await browser.NewPageAsync();

                await page.GotoAsync("https://www.saucedemo.com/");
                await page.FillAsync("#user-name", "standard_user");
                await page.FillAsync("#password", "secret_sauce");
                await page.ClickAsync("#login-button");

                return Response.Ok();
            })
            .WithLoadSimulations(LoadSimulation.NewRampingConstant(50, TimeSpan.FromMinutes(1)));
            var result = NBomberRunner.RegisterScenarios(scenario)
                .WithReportFolder("ReportsRampingConstant")
                .WithReportFormats(ReportFormat.Html, ReportFormat.Txt, ReportFormat.Csv)
                .WithWorkerPlugins(new HttpMetricsPlugin(new[] { HttpVersion.Version1 }))
                .Run();
            Assert.True(result.ScenarioStats.Get("Load Test with Playwright in SwagLab").Ok.Latency.Percent75 < 65000);
        }

        [Test]
        public async Task LoadTestWebApplicationKeepConstant()
        {
             var playwright = await Playwright.CreateAsync();
            var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
            {
                    Headless = false
            });

            var scenario = Scenario.Create("Load Test with Playwright in SwagLab", async context =>
            {
                var page = await browser.NewPageAsync();

                await page.GotoAsync("https://www.saucedemo.com/");
                await page.FillAsync("#user-name", "standard_user");
                await page.FillAsync("#password", "secret_sauce");
                await page.ClickAsync("#login-button");

                return Response.Ok();
            })
            .WithLoadSimulations(LoadSimulation.NewKeepConstant(50, TimeSpan.FromMinutes(1)));
            var result = NBomberRunner.RegisterScenarios(scenario)
                .WithReportFolder("ReportsKeepConstant")
                .WithReportFormats(ReportFormat.Html, ReportFormat.Txt, ReportFormat.Csv)
                .WithWorkerPlugins(new HttpMetricsPlugin(new[] { HttpVersion.Version1 }))
                .Run();

            Assert.True(result.ScenarioStats.Get("Load Test with Playwright in SwagLab").Ok.Latency.Percent75 < 65000);
        }

        
    }
}