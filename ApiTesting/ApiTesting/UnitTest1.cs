using Allure.NUnit;
using Allure.NUnit.Attributes;
using Microsoft.Playwright;
namespace ApiTesting
{
    [AllureNUnit]
    public class Tests
    {
        IPlaywright playwright;
        IPage page;

        [Test]
        [AllureStep]
        public async Task APITestWithGet()
        {
            string apiUrl = "http://localhost:3000/posts";
            playwright = await Playwright.CreateAsync();
            var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
            {
                Headless = false
            });
             page = await browser.NewPageAsync();
            var response = await page.APIRequest.GetAsync(apiUrl);
            if(response.Status == 200)
            {
                TestContext.WriteLine("Get Api worked");
            }
            else
            {
                throw new Exception("API Failed in Get");
            }

        }
        [Test]
        [AllureStep]
        public async Task APITestWithPost()
        {
            string apiUrl = "http://localhost:3000/posts";
            playwright = await Playwright.CreateAsync();
            var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
            {
                Headless = false
            });
            page = await browser.NewPageAsync();
            var apiBody = new
            {
                id = "4",
                title = "Software Engineering",
                marks = 100
            };

            var response = await page.APIRequest.PostAsync(apiUrl, new APIRequestContextOptions
            {
                DataObject = apiBody
            });;
            if (response.Status == 201)
            {
                TestContext.WriteLine("Post Api worked");
            }
            else
            {
                throw new Exception("API Failed in Post");
            }

        }

        [Test]
        [AllureStep]
        public async Task APITestWithPut()
        {
            string apiUrl = "http://localhost:3000/posts/4";
            playwright = await Playwright.CreateAsync();
            var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
            {
                Headless = false
            });
            page = await browser.NewPageAsync();
            var apiBody = new
            {
                title = "Software Requirement",
                marks = 70
            };

            var response = await page.APIRequest.PutAsync(apiUrl, new APIRequestContextOptions
            {
                DataObject = apiBody
            });
            if (response.Status == 200)
            {

                TestContext.WriteLine("Put Api worked");
            }
            else
            {
                throw new Exception("API Failed in Put");
            }

        }

        [Test]
        [AllureStep]
        public async Task APITestWithDelete()
        {
            string apiUrl = "http://localhost:3000/posts/4";
            playwright = await Playwright.CreateAsync();
            var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
            {
                Headless = false
            });
            page = await browser.NewPageAsync();
            
            var response = await page.APIRequest.DeleteAsync(apiUrl);
            if (response.Status == 200)
            {
                TestContext.WriteLine("Delete Api worked");
            }
            else
            {
                throw new Exception("API Failed in Put");
            }

        }
    }
}