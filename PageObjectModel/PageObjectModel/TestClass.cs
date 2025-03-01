namespace PageObjectModel
{
    public class TestClass
    {

        [Test]
        public void LoginSuccessful()
        {

            LoginClass loginClass = new LoginClass();
            loginClass.DriverInitialized();
            loginClass.OpenWindow();
            loginClass.LoginSuccessful("standard_user", "secret_sauce");
            loginClass.CloseWindow();

        }

        [Test]
        public void LoginUnSuccessful()
        {

            LoginClass loginClass = new LoginClass();
            loginClass.DriverInitialized();
            loginClass.OpenWindow();
            loginClass.LoginUnSuccessful("standard_user", "secret_sauce1");
            loginClass.CloseWindow();

        }

        [Test]
        public void CheckoutSuccessful()
        {
            LoginClass loginClass = new LoginClass();
            CheckoutClass checkoutClass = new CheckoutClass();
            checkoutClass.DriverInitialized();
            checkoutClass.OpenWindow();
            loginClass.LoginSuccessful("standard_user", "secret_sauce");
            checkoutClass.AddToCart();
            checkoutClass.CloseWindow();

        }
        [Test]
        public void ShipmentSuccessful()
        {
            LoginClass loginClass = new LoginClass();
            CheckoutClass checkoutClass = new CheckoutClass();
            ShipmentClass shipmentClass = new ShipmentClass();
            shipmentClass.DriverInitialized();
            shipmentClass.OpenWindow();
            loginClass.LoginSuccessful("standard_user", "secret_sauce");
            checkoutClass.AddToCart();
            shipmentClass.ShipInfo("ABC", "XYZ", "75800");
            shipmentClass.OrderPlace();
            shipmentClass.CloseWindow();

        }
    }
}