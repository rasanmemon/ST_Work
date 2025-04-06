using System;
using Reqnroll;

namespace DD_POM_BDT.PageClass.Customer.StepDefinitions
{
    [Binding]
    public class LoginWithCustomerInApplicationStepDefinitions : Customer
    {
        [Given("User will be open the browser and go to the url")]
        public void GivenUserWillBeOpenTheBrowserAndGoToTheUrl()
        {
            DriverInitialized();
            OpenWindow();
        }

        [When("Select the customer login button")]
        public void WhenSelectTheCustomerLoginButton()
        {
            CustomerLoginButtonClick();
        }

        [When("Click dropdown and select user name option and Click the login button")]
        public void WhenClickDropdownAndSelectUserNameOptionAndClickTheLoginButton()
        {
            SelectUserandLogin();
        }

        [Then("Customer should be logged in to the application and application showed welcomePage")]
        public void ThenCustomerShouldBeLoggedInToTheApplicationAndApplicationShowedWelcomePage()
        {
            LoginSubmit();
        }

        [Then("Close the browser")]
        public void ThenCloseTheBrowser()
        {
            CloseWindow();
        }
    }
}
