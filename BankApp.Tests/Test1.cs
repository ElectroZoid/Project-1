namespace BankApp.Tests
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        // Test to verify whether bank account balance
        // can be initialized using constructor itself
        public void TestMethod1()
        {
            BankAccount account = new BankAccount(1000m);

            Assert.AreEqual(1000m, account.GetBalance());
        }

        [TestMethod]
        // Test to verify if bank account balance is 
        // initialized with negative balance then it
        // presets the balance back to 0
        public void TestMethod2()
        {
            BankAccount account = new BankAccount(-100m);

            Assert.AreEqual(0m, account.GetBalance());
        }

        [TestMethod]
        // Test to verify the working
        // of deposit function
        public void TestMethod3()
        {
            BankAccount account = new BankAccount(1000m);

            account.Deposit(500m);

            Assert.AreEqual(1500m, account.GetBalance());
        }

        [TestMethod]
        // Test to verify if negative deposit is encountered
        // then the deposit fails and no amount is deposited
        public void TestMethod4()
        {
            BankAccount account = new BankAccount(1000m);

            account.Deposit(-500m);

            Assert.AreEqual(1000m, account.GetBalance());
        }

        [TestMethod]
        // Test to verify the correctness of Withdraw function 
        public void TestMethod5()
        {
            BankAccount account = new BankAccount(1000m);

            account.Withdraw(500m);

            Assert.AreEqual(500m, account.GetBalance());
        }

        [TestMethod]
        // Test to verify if negative withdraw is encountered
        // then the withdrawal fails and no amount is withdrawn
        public void TestMethod6()
        {
            BankAccount account = new BankAccount(1000m);

            account.Withdraw(-500m);

            Assert.AreEqual(1000m, account.GetBalance());
        }

        [TestMethod]
        // Test to verify withdrawal amount cant be
        // greater than the account balance
        public void TestMethod7()
        {
            BankAccount account = new BankAccount(1000m);

            account.Withdraw(2000m);

            Assert.AreEqual(1000m, account.GetBalance());
        }
    }
}
