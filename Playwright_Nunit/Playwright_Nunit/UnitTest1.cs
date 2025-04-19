using Allure.NUnit;
using Allure.NUnit.Attributes;
using Playwright_Nunit.PageClass;

namespace Playwright_Nunit
{
    [Parallelizable(ParallelScope.Self)]
    [TestFixture]
    [AllureNUnit]
    public class Tests : PageTest
    {
        [Test]
        [AllureStep]
        public async Task ValidLogin()
        {
            LoginClass loginClass = new LoginClass(Page);
            BaseClass._page = Page;
            await loginClass.GotoUrl();
            await loginClass.ValidLogin();
            await loginClass.CloseUrl();
        }
        [Test]
        [AllureStep]
        public async Task InValidLogin()
        {
            LoginClass loginClass = new LoginClass(Page);
            BaseClass._page = Page;
            await loginClass.GotoUrl();
            await loginClass.InvalidLogin();
            await loginClass.CloseUrl();
        }

        [Test]
        [AllureStep]
        public async Task Checkout()
        {
            LoginClass loginClass = new LoginClass(Page);
            CheckoutClass checkoutClass = new CheckoutClass(Page);
            BaseClass._page = Page;
            await loginClass.GotoUrl();
            await loginClass.ValidLogin();
            await checkoutClass.AddToCart();
            await loginClass.CloseUrl();
        }

        [Test]
        [AllureStep]
        public async Task Shipment()
        {
            LoginClass loginClass = new LoginClass(Page);
            CheckoutClass checkoutClass = new CheckoutClass(Page);
            ShipmentClass shipmentClass = new ShipmentClass(Page);
            BaseClass._page = Page;
            await loginClass.GotoUrl();
            await loginClass.ValidLogin();
            await checkoutClass.AddToCart();
            await shipmentClass.ShipInfoAsync();
            await shipmentClass.OrderPlaceAsync();
            await loginClass.CloseUrl();
        }
    }
}
