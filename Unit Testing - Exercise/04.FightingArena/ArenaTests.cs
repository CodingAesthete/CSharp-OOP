
using NUnit.Framework;
using System;

namespace Tests
{
    public class ArenaTests
    {
        private Arena arena;
        [SetUp]
        public void Setup()
        {
            arena = new Arena();
        }

        [Test]
        public void CheckIfListWorksProperly()
        {
            Assert.AreNotEqual(arena.Warriors, null);
        }
        [Test]
        public void CheckIfArenaIsZero()
        {
            Assert.AreEqual(arena.Count, 0);
        }
        [Test]
        public void IfThereIsAlreadySuchWarrior()
        {
            Warrior warrior = new Warrior("Alex", 20, 30);
            Warrior warro = new Warrior("Alex", 15, 25);
            arena.Enroll(warrior);
            Assert.Throws<InvalidOperationException>(() =>
            {
                arena.Enroll(warro);
            });
        }
        [Test]
        public void AddTopEnrollCorrectly()
        {
            Warrior warrior = new Warrior("Alex", 20, 30);
            arena.Enroll(warrior);
            Assert.AreEqual(arena.Count, 1);
        }
        [Test]
        public void FightWithUnexistingAttacker()
        {
            string attackerName = "Pesho";
            Warrior warrior = new Warrior(attackerName, 15, 25);
            string defenderName = "Racho";
            Assert.Throws<InvalidOperationException>(() =>
            {
                arena.Fight(attackerName, defenderName);
            });
        }
        [Test]
        public void FightWithUnexistingDefender()
        {
            string attackerName = "Pesho";
            string defenderName = "Racho";
            Warrior warrior = new Warrior(defenderName, 15, 25);
            Assert.Throws<InvalidOperationException>(() =>
            {
                arena.Fight(attackerName, defenderName);
            });
        }
        [Test]
        public void AttackProperly()
        {
            string attackerName = "Pesho";
            string defenderName = "Racho";
            Warrior attacker = new Warrior(attackerName, 50, 40);
            Warrior defender = new Warrior(defenderName, 20, 50);
            arena.Enroll(attacker);
            arena.Enroll(defender);
            arena.Fight(attackerName, defenderName);
            Assert.AreEqual(attacker.HP, 40 - defender.Damage);
        }
    }
}
