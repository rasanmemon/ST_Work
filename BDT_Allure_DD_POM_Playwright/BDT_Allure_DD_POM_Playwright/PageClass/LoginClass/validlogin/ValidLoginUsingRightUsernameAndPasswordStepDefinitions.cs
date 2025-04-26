using System;
using Allure.NUnit;
using BDT_Allure_DD_POM_Playwright.PageClass.LoginClass;
using Microsoft.Playwright;
using Reqnroll;

namespace BDT_Allure_DD_POM_Playwright.PageClass.LoginClass.validlogin
{
    [Binding]
    [AllureNUnit]
    public class ValidLoginUsingRightUsernameAndPasswordStepDefinitions
    {
        IPage _page;
        LoginClass loginClass;

        public ValidLoginUsingRightUsernameAndPasswordStepDefinitions(Hooks1 hooks1)
        {
            _page = hooks1.page;
            loginClass = new LoginClass(_page);
            BaseClass._page = hooks1.page;
        }
        [Given("Goto url")]
        public async Task GivenGotoUrl()
        {

            await loginClass.GotoUrl();
        }

        [When("Provide details and click login")]
        public async Task WhenProvideDetailsAndClickLogin()
        {
            await loginClass.ValidLogin();
        }

        [Then("Should be able to login and product page show")]
        public async Task ThenShouldBeAbleToLoginAndProductPageShow()
        {
            await loginClass.ValidLoginAssert();

            await loginClass.CloseUrl();
        }
    }
}
