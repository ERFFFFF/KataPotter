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
            double amountStart = 11.99;
            double amountDebit = 11.22;
            double amountEnd = 0.77;

            BankAccount bank = new BankAccount("oui", amountStart);
        }
    }
}
