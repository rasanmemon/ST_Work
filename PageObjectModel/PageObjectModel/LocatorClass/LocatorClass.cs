using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectModel
{
    public static class LocatorClass
    {
        // Login Page Locators
        public const string UserName = "user-name";
        public const string Password = "password";
        public const string LoginButton = "login-button";
        public const string UnSuccesfulLoginText = "//h3[@data-test='error']";
        public const string ExpectedProductText = "//span[@class='title']";

        // Checkout Page Locators
        public const string Product1 = "add-to-cart-sauce-labs-backpack";
        public const string Product2 = "add-to-cart-sauce-labs-bike-light";

        public const string CartLink = "//span[@class='shopping_cart_badge']";
        public const string CheckoutButton = "checkout";
        public const string ExpectedCheckoutText = "//span[@class='title']";

        //Shipment Page Locators
        public const string FirstName = "first-name";
        public const string LastName = "last-name";
        public const string Zipcode = "postal-code";
        public const string ContinueButton = "continue";
        public const string OrderNumber = "//div[contains(text(),'SauceCard #31337')]";
        public const string FinishButton = "finish";
        public const string OrderConfirmation = "//h2[@class='complete-header']";
    }
}
