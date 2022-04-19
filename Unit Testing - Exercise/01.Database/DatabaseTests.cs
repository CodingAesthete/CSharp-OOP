using NUnit.Framework;
using System;
using System.Linq;

namespace Tests
{
    [TestFixture]
    public class DatabaseTests
    {
        private Database database;
        [SetUp]
        public void Setup()
        {
            database = new Database();
        }

        [Test]
        public void CheckIfCtrIsoKay()
        {
            database = new Database(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16);
            Assert.AreEqual(database.Count, 16);
        }
        [Test]
        public void CheckIfCtrIsNotOkay()
        {
            Assert.Throws<InvalidOperationException>(() 
                => database= new Database(1, 2, 3, 4, 5, 7, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17) ) ;
        }
        [Test]
        public void AddElements()
        {
            var num = 4;
            for (int i = 0; i < num; i++)
            {
                database.Add(i);
            }
            Assert.AreEqual(database.Count, num);
        }
        [Test]
        public void FailToAddElements()
        {
            for (int i = 0; i < 16; i++)
            {
                database.Add(i);
            }
            Assert.Throws<InvalidOperationException>(() => database.Add(17));
        }
        [Test]
        public void RemoveElementCorrectly()
        {
            for (int i = 0; i < 3; i++)
            {
                database.Add(i);
            }
            database.Remove();
            Assert.AreEqual(database.Count, 2);
        }
        [Test]
        public void CannotRemove()
        {
            Assert.Throws<InvalidOperationException>(() => database.Remove());
        }
        [Test]
        public void FetchReturnsDbCopy()
        {
            database.Add(1);
            database.Add(2);
            var firstcopy = database.Fetch();
            database.Add(3);
            var secondcopy = database.Fetch();
            Assert.That(firstcopy, Is.Not.EqualTo(secondcopy));
        }
    }
}