namespace Data_Driven_Selinium
{
    public class Tests
    {
        [Test]
        public void LoginSuccessful()
        {

            LoginClass loginClass = new LoginClass();
            loginClass.DriverInitialized();
            loginClass.OpenWindow();
            loginClass.LoginSuccessful();
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
            loginClass.LoginSuccessful();
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
            loginClass.LoginSuccessful();
            checkoutClass.AddToCart();
            shipmentClass.ShipInfo();
            shipmentClass.OrderPlace();
            shipmentClass.CloseWindow();

        }
    }
}