using NUnit.Framework;
using System;

namespace Tests
{
    [TestFixture]
    public class AxeTests
    {
        private int attackPoints = 5;
        private int durabilityPoints = 6;
        private int health = 5;
        private int experience = 6;
        private Axe axe;
        private Dummy dummy;
        [SetUp]
        public void SetUp()
        {
            axe = new Axe(attackPoints, durabilityPoints);
            dummy = new Dummy(health, experience);
        }
        [Test]
        public void CheckIfValueAreRight_WhenYouSetUPThem()
        {
            Assert.AreEqual(axe.AttackPoints, attackPoints);
            Assert.AreEqual(axe.DurabilityPoints, durabilityPoints);
        }
        [Test]
        public void CheckIfWeraponLosesDurability_WhenEachOneAttacks()
        {
            axe.Attack(dummy);
            Assert.AreEqual(axe.DurabilityPoints, durabilityPoints - 1);
        }
        [Test]
        public void CheckIfWeaponDoesNotWork_WhenDurabilityPointsAreZero()
        {
            dummy = new Dummy(1111, 1111);
            InvalidOperationException ex=Assert.Throws<InvalidOperationException>(() =>
            {
                for (int i = 0; i < 7; i++)
                {
                    axe.Attack(dummy);
                }
            });
            Assert.AreEqual(ex.Message, "Axe is broken.");
        }
        [Test]
        public void CheckIfThrowNullReference_WhenAttackisNull()
        {
            Assert.Throws<NullReferenceException>(() =>
            {
                axe.Attack(null);
            });
            
        }
    }
}
