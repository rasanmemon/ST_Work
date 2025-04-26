using System;
using Allure.NUnit;
using BDT_Allure_DD_POM_Playwright.PageClass.LoginClass;
using Microsoft.Playwright;
using Reqnroll;

namespace BDT_Allure_DD_POM_Playwright.PageClass.LoginClass.invalidlogin
{
    [Binding]
    [AllureNUnit]
    public class InvalidLoginUsingUsernameAndPasswordStepDefinitions
    {
        IPage _page;
        LoginClass loginClass;

        public InvalidLoginUsingUsernameAndPasswordStepDefinitions(Hooks1 hooks1)
        {
            _page = hooks1.page;
            loginClass = new LoginClass(_page);
            BaseClass._page = hooks1.page;
        }
        [Given("Goto to url")]
        public async Task GivenGotoToUrl()
        {
            await loginClass.GotoUrl();
        }

        [When("Provide invaid details and click login")]
        public async Task WhenProvideInvaidDetailsAndClickLogin()
        {
            await loginClass.InvalidLogin();
        }

        [Then("Should be unable to login and product page show")]
        public async Task ThenShouldBeUnableToLoginAndProductPageShow()
        {
            await loginClass.InValidLoginAssert();
            await loginClass.CloseUrl();

        }
    }
}
