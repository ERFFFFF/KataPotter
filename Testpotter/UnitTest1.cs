using katapotter;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testpotter
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestDebit()
        {
            double m_balance = 11.99;
            double amount = 11.22;
            double m_balance_end = 0.77;

            BankAccount bank = new BankAccount("Tom", m_balance);

            bank.Debit(amount);

            double test = bank.Balance;
            Assert.AreEqual(m_balance_end, test, 0.001, "Test de débit ok");

           // ca marche pas car on a des double en paramètre a la place d'objets ? -> Assert.Equals(m_balance_end, test);

            
        }
    }
}
