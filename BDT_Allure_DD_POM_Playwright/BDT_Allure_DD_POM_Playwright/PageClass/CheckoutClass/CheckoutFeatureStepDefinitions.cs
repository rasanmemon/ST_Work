using System;
using Allure.NUnit;
using Microsoft.Playwright;
using Reqnroll;

namespace BDT_Allure_DD_POM_Playwright.PageClass.CheckoutClass
{
    [Binding]
    [AllureNUnit]
    public class CheckoutFeatureStepDefinitions
    {
        IPage _page;
        LoginClass.LoginClass loginClass;
        CheckoutClass checkoutClass;

        public CheckoutFeatureStepDefinitions(Hooks1 hooks1)
        {
            _page = hooks1.page;
            loginClass = new LoginClass.LoginClass(_page);
            checkoutClass = new CheckoutClass(_page);
            BaseClass._page = hooks1.page;
        }
        [Given("Goto url and login")]
        public async Task GivenGotoUrlAndLogin()
        {
            await checkoutClass.GotoUrl();
            await loginClass.ValidLogin();

        }

        [When("Select products and go to cart and checkout")]
        public async Task WhenSelectProductsAndGoToCartAndCheckout()
        {

            await checkoutClass.AddToCart();
           
        }

        [Then("Checkout information will be overview")]
        public async Task ThenCheckoutInformationWillBeOverview()
        {
            await checkoutClass.AddToCartAssert();
            await loginClass.CloseUrl();
        }
    }
}
