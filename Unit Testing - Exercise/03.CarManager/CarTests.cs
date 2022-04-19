using NUnit.Framework;
using System;

namespace Tests
{
    public class CarTests
    {
        private Car car;
        [SetUp]
        public void Setup()
        {
            car = new Car("Mara", "Sara", 10, 100);
        }
        [Test]
        [TestCase("", "Mezda", 10, 100)]
        [TestCase(null, "Mezda", 10, 100)]
        [TestCase("Ban", "", 10, 100)]
        [TestCase("Ban", null, 10, 100)]
        [TestCase("Ban", "Mezda", 0, 100)]
        [TestCase("Ban", "Mezda", -100, 100)]
        [TestCase("Ban", "Mezda", 10, 0)]
        [TestCase("Ban", "Mezda", 10, -100)]
        public void TestConstructor(string make, string model, double fuelConsumption, double fuelCapacity)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                car = new Car(make, model, fuelConsumption, fuelCapacity);
            });
        }
        [Test]
        public void TestCtorWhenValid()
        {
            string make = "mara";
            string model = "Saraa";
            int fuelConsumption = 50;
            int fuelCapacity = 60;
            car = new Car(make,model,fuelConsumption,fuelCapacity);
            Assert.AreEqual(car.Make, make);
            Assert.AreEqual(car.Model, model);
            Assert.AreEqual(car.FuelConsumption, fuelConsumption);
            Assert.AreEqual(car.FuelCapacity, fuelCapacity);
        }
        [Test]
        [TestCase(0)]
        [TestCase(-1)]
        public void FuelWithWrongFuel(int fuel)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                car.Refuel(fuel);
            });
        }
        [Test]
        public void AddNormalAmountOfFuel()
        {
            car.Refuel(car.FuelCapacity / 2);
            Assert.AreEqual(car.FuelAmount, car.FuelCapacity / 2);
        }
        [Test]
        public void AddTooMuchFuel()
        {
            car.Refuel(car.FuelCapacity);
            car.Refuel(car.FuelCapacity / 2);
            Assert.AreEqual(car.FuelCapacity, car.FuelAmount);
        }
        [Test]
        public void DriveWithNoFuel()
        {
            Assert.Throws<InvalidOperationException>(()=>car.Drive(100));
        }
        [Test]
        public void DriveWithNormalLength()
        {
            var intialFuel = car.FuelCapacity;
            car.Refuel(intialFuel);
            car.Drive(100);
            Assert.That(car.FuelAmount, Is.EqualTo(intialFuel - car.FuelConsumption));
        }
    }
}