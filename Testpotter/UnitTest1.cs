using katapotter;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testpotter
{
    [TestClass]
    public class UnitTest1
    {
        /*[TestMethod]
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

            
        }*/
        [TestMethod]
        public void Test_GivenOneBookWhenAddingToCartShouldContainOneItem()
        {
            Cart myCart = new Cart();
            myCart.add(new Book("book1"));
            Assert.AreEqual(myCart.getItemCount(), 1);
        }

        [TestMethod]
        public void Test_GivenTwoBookWhenAddingToCartShouldCountainTwoItems()
        {
            Cart myCart = new Cart();
            myCart.add(new Book("book1"));
            myCart.add(new Book("book2"));
            Assert.AreEqual(myCart.getItemCount(), 2);

        }

        [TestMethod]
        public void Test_GivenOneBookToCartShouldAddPrice() {
            Cart myCart = new Cart();
            myCart.add(new Book("book1"));
            Assert.AreEqual(myCart.getTotalPrice(), 8);
        }

        [TestMethod]
        public void Test_GivenTwoBookToCartShouldApplyDiscount()
        {
            Cart myCart = new Cart();
            myCart.add(new Book("book1"));
            myCart.add(new Book("book2"));
            Assert.AreEqual(15.2, myCart.getTotalPrice());
        }
        
        [TestMethod]
        public void Test_GivenTwoBookToCartShoulNotdApplyDiscount()
        {
            Cart myCart = new Cart();
            myCart.add(new Book("book1"));
            myCart.add(new Book("book1"));
            Assert.AreEqual(16, myCart.getTotalPrice());
        }

        [TestMethod]
        public void Test_GivenThreeBookToCartShouldNotApplyDiscount()
        {
            Cart myCart = new Cart();
            myCart.add(new Book("book1"));
            myCart.add(new Book("book2"));
            myCart.add(new Book("book3"));
            Assert.AreEqual(21.6, myCart.getTotalPrice());
        }

        [TestMethod]
        public void Test_GiveThreeBookWithTwoSameBook()
        {
            Cart myCart = new Cart();

            myCart.add(new Book("book1"));
            myCart.add(new Book("book2"));
            myCart.add(new Book("book1"));
            Assert.AreEqual(myCart.ListBook1[0].name, myCart.ListBook1[1].name);
        }
        [TestMethod]
        public void Test_GivenFourBookWith()
        {
            Cart myCart = new Cart();

            myCart.add(new Book("book3"));
            myCart.add(new Book("book3"));
            myCart.add(new Book("book4"));
            myCart.add(new Book("book4"));
            Assert.AreEqual(myCart.ListBook3[0].name, myCart.ListBook3[1].name);
            Assert.AreEqual(myCart.ListBook4[0].name, myCart.ListBook4[1].name);
        }
        [TestMethod]
        public void Test_GivenSerieShouldApplyDiscount()
        {
            Cart myCart = new Cart();

            myCart.add(new Book("book1"));
            myCart.add(new Book("book2"));
            myCart.add(new Book("book3"));
            myCart.add(new Book("book4"));
            myCart.add(new Book("book5"));
            Assert.AreEqual(30, myCart.getTotalPrice());
        }
        [TestMethod]
        public void Test_GivenSerieShouldNotApplyDiscount()
        {
            Cart myCart = new Cart();

            myCart.add(new Book("book2"));
            myCart.add(new Book("book2"));
            myCart.add(new Book("book2"));
            myCart.add(new Book("book2"));
            myCart.add(new Book("book2"));
            Assert.AreEqual(30, myCart.getTotalPrice());
        }
        [TestMethod]
        public void Test_GivenSerieShouldReturn38()
        {
            Cart myCart = new Cart();

            myCart.add(new Book("book1"));
            myCart.add(new Book("book1"));
            myCart.add(new Book("book2"));
            myCart.add(new Book("book3"));
            myCart.add(new Book("book4"));
            myCart.add(new Book("book5"));
            Assert.AreEqual(38, myCart.getTotalPrice());
        }
    }
}
