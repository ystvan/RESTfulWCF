using Microsoft.VisualStudio.TestTools.UnitTesting;
using WCFServiceWebRole1;
using System;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCFServiceWebRole1.Tests
{
    [TestClass()]
    public class UsedCarServiceTests
    {

        private IUsedCarService service;
        private Car car1, car2, car3;

        [TestInitialize]
        public void StartTest()
        {
            service = new UsedCarService();
        }

        [TestMethod]
        public void Implementation()
        {
            Assert.IsInstanceOfType(service, typeof(IUsedCarService));
        }


        [TestMethod()]
        public void GetAllCarsTest()
        {
            IList<Car> testCars = service.GetAllCars();
            Assert.IsNotNull(testCars);
            Assert.AreEqual(testCars.Count, 4);
        }

       
    }
}