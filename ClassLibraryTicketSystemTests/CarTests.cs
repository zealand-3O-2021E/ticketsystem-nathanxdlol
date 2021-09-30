using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibraryTicketSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTicketSystem.Tests
{
    [TestClass()]
    public class CarTests
    {
        [TestMethod()]
        public void priceTest()
        {
            //Arrange
            Car car = new Car("123",new DateTime(2021,09,30));
            //Act
            var expect = 240;
            //Assert
            Assert.AreEqual(expect, car.Price());
        }

        [TestMethod()]
        public void VehicleTypeTest()
        {
            //Arrange
            Car car = new Car("123",new DateTime(2021,09,30));
            //Act
            var expect = "Car";
            //Assert
            Assert.AreEqual(expect, car.VehicleType());
        }
    }
}