namespace BankApp.Tests
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            BankAccount account = new BankAccount(1000m);

            Assert.AreEqual(1000m, account.GetBalance());
        }

        [TestMethod]
        public void TestMethod2()
        {
            BankAccount account = new BankAccount(-100m);

            Assert.AreEqual(0m, account.GetBalance());
        }

        [TestMethod]
        public void TestMethod3()
        {
            BankAccount account = new BankAccount(1000m);

            account.Deposit(500m);

            Assert.AreEqual(1500m, account.GetBalance());
        }

        [TestMethod]
        public void TestMethod4()
        {
            BankAccount account = new BankAccount(1000m);

            account.Deposit(-500m);

            Assert.AreEqual(1000m, account.GetBalance());
        }

        [TestMethod]
        public void TestMethod5()
        {
            BankAccount account = new BankAccount(1000m);

            account.Withdraw(500m);

            Assert.AreEqual(500m, account.GetBalance());
        }

        [TestMethod]
        public void TestMethod6()
        {
            BankAccount account = new BankAccount(1000m);

            account.Withdraw(-500m);

            Assert.AreEqual(1000m, account.GetBalance());
        }

        [TestMethod]
        public void TestMethod7()
        {
            BankAccount account = new BankAccount(1000m);

            account.Withdraw(2000m);

            Assert.AreEqual(1000m, account.GetBalance());
        }
    }
}
