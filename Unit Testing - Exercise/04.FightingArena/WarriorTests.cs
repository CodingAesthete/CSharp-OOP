using NUnit.Framework;
using System;

namespace Tests
{
    public class WarriorTests
    {
        private Warrior warrior;
        [SetUp]
        public void SetUp()
        {
            warrior = new Warrior("Mano", 11, 21);
        }

        [Test]
        [TestCase("", 10, 20)]
        [TestCase(" ", 10, 20)]
        [TestCase(null, 10, 20)]
        [TestCase("Alex", -2, 20)]
        [TestCase("Alex", 0, 20)]
        [TestCase("Alex", 10, -6)]
        public void CtorSetIncorrectly(string name, int damage, int hp)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                warrior = new Warrior(name, damage, hp);
            });
        }
        [Test]
        public void CtorSetCorrectly()
        {
            string name = "Mitko";
            int damage = 30;
            int hp = 50;
            warrior = new Warrior(name, damage, hp);
            Assert.AreEqual(name, warrior.Name);
            Assert.AreEqual(damage, warrior.Damage);
            Assert.AreEqual(hp, warrior.HP);
        }
        [Test]
        [TestCase(15)]
        [TestCase(30)]
        public void CannotAttackIfHisHPIsUnder30(int hp)
        {
            Warrior attacker = new Warrior("John", 50, hp);
            Warrior defender = new Warrior("mike", 30, 40);
            Assert.Throws<InvalidOperationException>(() =>
            {
                attacker.Attack(defender);
            });
        }
        [Test]
        [TestCase(15)]
        [TestCase(30)]
        public void CannotAttackTooWeakOpponent(int hp)
        {
            Warrior attacker = new Warrior("John", 50, 40);
            Warrior defender = new Warrior("mike", 30, hp);
            Assert.Throws<InvalidOperationException>(() =>
            {
                attacker.Attack(defender);
            });
        }
        [Test]
        public void FailsToAttackTooStrongEnemy()
        {
            Warrior attacker = new Warrior("John", 50, 40);
            Warrior defender = new Warrior("mike", 50, 50);
            Assert.Throws<InvalidOperationException>(() =>
            {
                attacker.Attack(defender);
            });
        }
        [Test]
        public void ReducesHpCorrectly()
        {
            int initialHp = 40;
            Warrior attacker = new Warrior("John", 50, initialHp);
            Warrior defender = new Warrior("mike", 20, 50);
            attacker.Attack(defender);
            Assert.AreEqual(attacker.HP, initialHp - defender.Damage);
        }
        [Test]
        public void CheckIfHpCannotGoUnderZero()
        {
            int initialHp = 40;
            Warrior attacker = new Warrior("John", 50, initialHp);
            Warrior defender = new Warrior("mike", 20, 40);
            attacker.Attack(defender);
            Assert.AreEqual(defender.HP, 0);
        }
        [Test]
        public void CheckIfHPIsDecreasedCorrectly()
        {
            int initialHp = 40;
            int defHp = 41;
            Warrior attacker = new Warrior("John", 30, initialHp);
            Warrior defender = new Warrior("mike", 20, defHp);
            attacker.Attack(defender);
            Assert.AreEqual(defender.HP, defHp - attacker.Damage);
        }
    }
}