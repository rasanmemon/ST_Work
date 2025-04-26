using System;
using Microsoft.Playwright;
using Reqnroll;

namespace BDT_Allure_DD_POM_Playwright.PageClass.Shipment
{
    [Binding]
    public class ShipmentFeatureStepDefinitions
    {
        IPage _page;
        LoginClass.LoginClass loginClass;
        CheckoutClass.CheckoutClass checkoutClass;
        ShipmentClass shipmentClass;
        public ShipmentFeatureStepDefinitions(Hooks1 hooks1) {
            _page = hooks1.page;
            loginClass = new LoginClass.LoginClass(_page);
            checkoutClass = new CheckoutClass.CheckoutClass(_page);
            shipmentClass = new ShipmentClass(_page);
            BaseClass._page = hooks1.page;
        }
        [Given("Goto url and login and add products and checkout")]
        public async Task GivenGotoUrlAndLoginAndAddProductsAndCheckout()
        {
            await shipmentClass.GotoUrl();
            await loginClass.ValidLogin();
            await checkoutClass.AddToCart();
        }

        [When("Fill the shipment details")]
        public async Task WhenFillTheShipmentDetails()
        {
            await shipmentClass.ShipInfoAsync();
        }

        [Then("Order will be placed")]
        public async Task ThenOrderWillBePlaced()
        {
            await shipmentClass.OrderPlaceAsync();
            await shipmentClass.CloseUrl();
        }
    }
}
