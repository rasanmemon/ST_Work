using PasswordClass;

namespace Password_UT
{
    public class Tests
    {
        [Test]
        public void PasswordTestForLengthLessThen8()
        {
            PasswordVerifier pv = new PasswordVerifier();
            Assert.IsFalse(pv.Verify("abc1342"));
        }
        [Test]
        public void PasswordTestForLengthEqual8()
        {
            PasswordVerifier pv = new PasswordVerifier();
            Assert.IsFalse(pv.Verify("Abc@1234"));
        }

        [Test]
        public void PasswordTestForEmpty()
        {
            PasswordVerifier pv = new PasswordVerifier();
            Assert.IsFalse(pv.Verify(""));
        }

        [Test]
        public void PasswordTestForNotUpperCase()
        {
            PasswordVerifier pv = new PasswordVerifier();
            Assert.IsFalse(pv.Verify("abc1342"));
        }

        [Test]
        public void PasswordTestForNotLowerCase()
        {
            PasswordVerifier pv = new PasswordVerifier();
            Assert.IsFalse(pv.Verify("ABC123456"));
        }
        [Test]
        public void PasswordTestForNoSpecialCharacter()
        {
            PasswordVerifier pv = new PasswordVerifier();
            Assert.IsFalse(pv.Verify("Abc123456"));
        }

        [Test]
        public void PasswordTestForNotHavingNumbers()
        {
            PasswordVerifier pv = new PasswordVerifier();
            Assert.IsFalse(pv.Verify("Abc@"));
        }

        [Test]
        public void PasswordTestForVerifiedPassword()
        {
            PasswordVerifier pv = new PasswordVerifier();
            Assert.IsTrue(pv.Verify("Abc@123456"));
        }

        [Test]
        public void PasswordTestForWrongPassword()
        {
            PasswordVerifier pv = new PasswordVerifier();
            Assert.IsTrue(pv.Verify("dajsd"));
        }

    }
}