using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DD_POM_BDT
{
    public class LocatorClass :BaseClass
    {
        //Customer work
            //Login
            public const string customerLoginButton = "//button[normalize-space()='Customer Login']";
            public const string userNameDropdown = "//select[@id='userSelect']";
            public const string usernameOption = "//option[contains(text(),'Hermoine Granger')]";
            public const string loginButton = "//button[@type='submit']";
            public const string welcomePageExpected = "//strong[contains(text(),'Welcome')]";
            //Logout
            public const string logout = "//button[normalize-space()='Logout']";
            //Deposit
            public const string depositButton = "//button[normalize-space()='Deposit']";
            public const string depositInput = "//input[@placeholder='amount']";

            public const string depositSubmitButton = "//button[@type='submit']";
            public const string depositResultArea = "//span[@class='error ng-binding']";
            //WithDrawl
            public const string withdrawButton = "//button[normalize-space()='Withdrawl']";
            public const string withdrawInput = "//input[@placeholder='amount']";

            public const string withdrawSubmitButton = "//button[@type='submit']";
            public const string withdrawResultArea = "//span[@class='error ng-binding']";
            //Transaction
            public const string transactionButton = "//button[normalize-space()='Transactions']";
            public const string transactionResetButton = "//button[normalize-space()='Reset']";
            public const string transactionBackButton = "//button[normalize-space()='Back']";
            public const string transactionTable = "//div[@class='marTop tbStruct border box ng-scope']";
            public const string transactionTableRow0 = " //tr[@id='anchor0']";

            public const string startdate = "start";
            public const string enddate = "end";

       

        //Bank Manager Work
        //Login
        public const string bmloginbutton = "//button[normalize-space()='Bank Manager Login']";
            //Add Customer
            public const string addCustomerButton = "//button[normalize-space()='Add Customer']";
            public const string addCustomerButtonSubmit = "//button[@type='submit']";
            public const string firstName = "//input[@placeholder='First Name']";
            public const string lastName = "//input[@placeholder='Last Name']";
            public const string postCode = "//input[@placeholder='Post Code']";

            //Open Account
            public const string openAccountButton = "//button[normalize-space()='Open Account']";
            public const string customernameDropdown = "userSelect";
            public const string customernameOption = "//option[contains(text(),'Morris Jhon')]";
            public const string currencyDropdown = "currency";
            public const string currencyOption = "//option[contains(text(),'Rupee')]";
            public const string processButton = "//button[normalize-space()='Process']";
            
            //Customer record 
            public const string customersbutton = "//button[normalize-space()='Customers']";
            public const string searchbarcustomer = "//input[@placeholder='Search Customer']";
            public const string searchedrow = "//td[normalize-space()='Morris']";
            public const string deleteButton = "//tbody/tr[1]/td[5]/button[1]";

    }
}
