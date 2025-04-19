using Microsoft.Playwright;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playwright_Nunit
{
    public class BaseClass
    {
        public static IPage? _page;

        public async Task GotoUrl()
        {
            var jsonData = JObject.Parse(File.ReadAllText("D:\\FAST\\ST\\Code\\Playwright_Nunit\\Playwright_Nunit\\data.json"));
            var url = jsonData["url"].ToString();

            await _page.GotoAsync(url);
        }
        public async Task CloseUrl()
        {
            await _page.CloseAsync();
        }
    }
}
