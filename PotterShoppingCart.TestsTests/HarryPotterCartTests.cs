using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PotterShoppingCart.Tests;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace PotterShoppingCart.Tests.Tests
{

    [TestClass()]
    public class HarryPotterCartTests
    {
        private List<Book> books;

        [TestInitialize()]
        public void MyTestInit() {
            books = new List<Book>();
        }

        
        [TestCleanup()]
        public void MyTestCleanUp()
        {
            books = null;
        }

        [TestMethod()]
        public void 第一集買了一本_價格應100元()
        {
            //Arrange
            var target = new HarryPotterCart();
            books.Add(new Book { Serial = "HarryPotter", Episode= 1, price=100 });
            double expected = 100;

            //Act
            double actual = target.CountPrice(books);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void 第一集買了一本_第二集也買了一本_價格應為190()
        {
            //Arrange
            var target = new HarryPotterCart();
            books.Add(new Book { Serial = "HarryPotter", Episode = 1, price = 100 });
            books.Add(new Book { Serial = "HarryPotter", Episode = 2, price = 100 });
            double expected = 190;

            //Act
            double actual = target.CountPrice(books);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void 一二三集各買了一本_價格應為270()
        {
            //Arrange
            var target = new HarryPotterCart();
            books.Add(new Book { Serial = "HarryPotter", Episode = 1, price = 100 });
            books.Add(new Book { Serial = "HarryPotter", Episode = 2, price = 100 });
            books.Add(new Book { Serial = "HarryPotter", Episode = 3, price = 100 });
            double expected = 270;

            //Act
            double actual = target.CountPrice(books);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void 一二三四集各買了一本_價格應為320()
        {
            //Arrange
            var target = new HarryPotterCart();
            books.Add(new Book { Serial = "HarryPotter", Episode = 1, price = 100 });
            books.Add(new Book { Serial = "HarryPotter", Episode = 2, price = 100 });
            books.Add(new Book { Serial = "HarryPotter", Episode = 3, price = 100 });
            books.Add(new Book { Serial = "HarryPotter", Episode = 4, price = 100 });
            double expected = 320;

            //Act
            double actual = target.CountPrice(books);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void 一二三四五集各買了一本_價格應為375()
        {
            //Arrange
            var target = new HarryPotterCart();
            books.Add(new Book { Serial = "HarryPotter", Episode = 1, price = 100 });
            books.Add(new Book { Serial = "HarryPotter", Episode = 2, price = 100 });
            books.Add(new Book { Serial = "HarryPotter", Episode = 3, price = 100 });
            books.Add(new Book { Serial = "HarryPotter", Episode = 4, price = 100 });
            books.Add(new Book { Serial = "HarryPotter", Episode = 5, price = 100 });
            double expected = 375;

            //Act
            double actual = target.CountPrice(books);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void 一二集各買了一本_第三集買了兩本_價格應為370()
        {
            //Arrange
            var target = new HarryPotterCart();
            books.Add(new Book { Serial = "HarryPotter", Episode = 1, price = 100 });
            books.Add(new Book { Serial = "HarryPotter", Episode = 2, price = 100 });
            books.Add(new Book { Serial = "HarryPotter", Episode = 3, price = 100 });
            books.Add(new Book { Serial = "HarryPotter", Episode = 3, price = 100 });
            double expected = 370;

            //Act
            double actual = target.CountPrice(books);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void 第一集買了一本_第二三集各買了兩本_價格應為460()
        {
            //Arrange
            var target = new HarryPotterCart();
            books.Add(new Book { Serial = "HarryPotter", Episode = 1, price = 100 });
            books.Add(new Book { Serial = "HarryPotter", Episode = 2, price = 100 });
            books.Add(new Book { Serial = "HarryPotter", Episode = 2, price = 100 });
            books.Add(new Book { Serial = "HarryPotter", Episode = 3, price = 100 });
            books.Add(new Book { Serial = "HarryPotter", Episode = 3, price = 100 });
            double expected = 460;

            //Act
            double actual = target.CountPrice(books);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
