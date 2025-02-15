
using ATMClassLibrary;

namespace ATM_UT
{
    public class Tests
    {

        [Test]
        public void ATMTestForWithdrawal()
        {
            string actualMessage = "Your current amount now is: 40000";
            ATM atm = new ATM();
            Params parame = new Params();
            parame.amount = 50000;
            parame.choice = 2;
            parame.withdraw = 10000;
            parame.pin = 123;
            string expectedMessage = atm.BankTransaction(parame);
            Assert.AreEqual(expectedMessage, actualMessage);
        }

        [Test]
        public void ATMTestForDeposit()
        {
            string actualMessage = "Your amount now has been deposited successfully: 60000";
            ATM atm = new ATM();
            Params parame = new Params();
            parame.amount = 50000;
            parame.choice = 3;
            parame.deposit = 10000;
            parame.pin = 123;
            string expectedMessage = atm.BankTransaction(parame);
            Assert.AreEqual(expectedMessage, actualMessage);
        }

        [Test]
        public void ATMTestForCurrentAmount()
        {
            string actualMessage = "Your current balance is: 50000";
            ATM atm = new ATM();
            Params parame = new Params();
            parame.amount = 50000;
            parame.choice = 1;
            parame.pin = 123;
            string expectedMessage = atm.BankTransaction(parame);
            Assert.AreEqual(expectedMessage, actualMessage);
        }

        [Test]
        public void ATMTestForWrongPin()
        {
            string actualMessage = "InCorrect Pin";
            ATM atm = new ATM();
            Params parame = new Params();
            parame.pin = 1233;
            string expectedMessage = atm.BankTransaction(parame);
            Assert.AreEqual(expectedMessage, actualMessage);
        }

        [Test]
        public void ATMTestForExitSystem()
        {
            string actualMessage = "Thank You";
            ATM atm = new ATM();
            Params parame = new Params();
            parame.pin = 123;
            parame.choice = 4;
            string expectedMessage = atm.BankTransaction(parame);
            Assert.AreEqual(expectedMessage, actualMessage);
        }

    }
}