using Microsoft.Playwright;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDT_Allure_DD_POM_Playwright
{
    public class BaseClass
    {
        public static IPage? _page;

        public async Task GotoUrl()
        {
            var jsonData = JObject.Parse(File.ReadAllText("D:\\FAST\\ST\\Code\\BDT_Allure_DD_POM_Playwright\\BDT_Allure_DD_POM_Playwright\\data.json"));
            var url = jsonData["url"].ToString();

            await _page.GotoAsync(url);
        }
        public async Task CloseUrl()
        {
            await _page.CloseAsync();
        }
    }
}
