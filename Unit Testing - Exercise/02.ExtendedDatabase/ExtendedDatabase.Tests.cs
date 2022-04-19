
using NUnit.Framework;
using System;

namespace Tests
{
    public class ExtendedDatabaseTests
    {
        private ExtendedDatabase extendedDatabase;
        [SetUp]
        public void Setup()
        {
            extendedDatabase = new ExtendedDatabase();
        }

        [Test]
        public void AddPeoplesCorrectlyToCtor()
        {
            var persons = new Person[5];
            for (int i = 0; i < persons.Length; i++)
            {
                persons[i] = new Person(i, $"Name:{i}");
            }
            extendedDatabase = new ExtendedDatabase(persons);
            Assert.AreEqual(extendedDatabase.Count, persons.Length);
            foreach (var person in persons)
            {
                Person persono = extendedDatabase.FindById(person.Id);
                Assert.AreEqual(person, persono);
            }
        }
        [Test]
        public void CtorIsNotWorkingProperly()
        {
            var persons = new Person[17];
            for (int i = 0; i < persons.Length; i++)
            {
                persons[i] = new Person(i, $"Name:{i}");
            }
            Assert.Throws<ArgumentException>(() =>
            {
                extendedDatabase = new ExtendedDatabase(persons);
            }
            );
        }
        [Test]
        public void AddThrowsExceptionWhneCountIsExceeded()
        {
            for (int i = 0; i < 16; i++)
            {
                extendedDatabase.Add(new Person(i, $"Name: {i}"));
            }
            Assert.Throws<InvalidOperationException>(() =>
            {
                extendedDatabase.Add(new Person(17, $"Name: {17}"));
            }
            );
        }
        [Test]
        public void AddThroswsExceptionWhenNameIsAlreadyThere()
        {
            extendedDatabase.Add(new Person(1, "Pesho"));
            Assert.Throws<InvalidOperationException>(() =>
            {
                extendedDatabase.Add(new Person(2, "Pesho"));
            });
        }
        [Test]
        public void AddThrowsExceptionWhenIdIsAlreadyThere()
        {
            extendedDatabase.Add(new Person(1, "Pesho"));
            Assert.Throws<InvalidOperationException>(() =>
            {
                extendedDatabase.Add(new Person(1, "Dako"));
            });
        }
        [Test]
        public void AddPersonNormally()
        {
            extendedDatabase.Add(new Person(1, "Alex"));
            extendedDatabase.Add(new Person(2, "Mano"));
            Assert.AreEqual(extendedDatabase.Count, 2);
        }
        [Test]
        public void RemoveFromEmptyArray()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                extendedDatabase.Remove();
            });
        }
        [Test]
        public void RemoveCorrectly()
        {
            extendedDatabase.Add(new Person(1, "Mano"));
            extendedDatabase.Add(new Person(2, "Alex"));
            extendedDatabase.Remove();
            Assert.AreEqual(extendedDatabase.Count, 1);
            Assert.Throws<InvalidOperationException>(() =>
            {
                extendedDatabase.FindById(2);
            });
        }
        [Test]
        [TestCase("")]
        [TestCase(null)]
        public void NullOrEmptyStringName(string username)
        {
            Assert.Throws<ArgumentNullException>(() =>
            {
                extendedDatabase.FindByUsername(username);
            });
        }
        [Test]
        public void IfUserNameAlreadyExists()
        {
            extendedDatabase.Add(new Person(1, "Misho"));
            Assert.Throws<InvalidOperationException>(() =>
            {
                extendedDatabase.FindByUsername("Alexcho");
            });
        }
        [Test]
        public void FindNormallyStringUsername()
        {
            var person = new Person(1, "Alex");
            extendedDatabase.Add(person);
            extendedDatabase.Add(new Person(2, "Mano"));
            Person curr = extendedDatabase.FindByUsername(person.UserName);
            Assert.AreEqual(curr, person);
        }
        [Test]
        public void FindIdIsUnderZero()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                extendedDatabase.FindById(-1);
            });
        }
        [Test]
        public void FindUnExistingId()
        {
            extendedDatabase.Add(new Person(1, "Alex"));
            extendedDatabase.Add(new Person(2, "Mano"));
            Assert.Throws<InvalidOperationException>(() =>
            {
                extendedDatabase.FindById(3);
            });
        }
        [Test]
        public void CheckACorrectId()
        {
            var person = new Person(1, "Mano");
            extendedDatabase.Add(person);
            var curr = extendedDatabase.FindById(person.Id);
            Assert.AreEqual(person, curr);
        }
    }
}