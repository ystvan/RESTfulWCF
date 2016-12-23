using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFServiceWebRole1
{
    public class UsedCarService : IUsedCarService
    {
        private static int _nextId = 4;
        private static IList<Car> usedCars = new List<Car>()
        {
            new Car(){Id = 1, Model = "Ford Mustang", Price = 120000, Year = 1976},
            new Car(){Id = 2, Model = "VW Golf", Price = 28000, Year = 1989},
            new Car(){Id = 3, Model = "Lada 1500", Price = 100, Year = 1966},
            new Car(){Id = 4, Model = "Ferrari Testarosa", Price = 6000000, Year = 1995}
        };

        /// <summary>
        /// Returns all of the Car objects
        /// </summary>
        /// <returns>List of cars</returns>
        public IList<Car> GetAllCars()
        {
            return usedCars;
        }

        /// <summary>
        /// Returns a Car by based on matching Id number
        /// </summary>
        /// <param name="id">The search criteria by Id number</param>
        /// <returns>A Car found by Id or the default</returns>
        public Car GetCarById(string id)
        {
            int idNumber = int.Parse(id);
            Car match = usedCars.FirstOrDefault(c => c.Id == idNumber);
            return match;
        }

        /// <summary>
        /// Adds a Car to the generic collection
        /// </summary>
        /// <param name="newCar">The Car object to be added</param>
        /// <returns>The new car which has been added currently</returns>
        public Car AddCar(Car newCar)
        {
            if (newCar == null)
            {
                throw new ArgumentNullException(nameof(newCar));
            }
            newCar.Id = _nextId++;
            usedCars.Add(newCar);
            return newCar;

        }

        /// <summary>
        /// Updates the matching Car object in the generic collection
        /// </summary>
        /// <param name="updatedCar">Car to be uodated</param>
        public bool UpdateCar(Car updatedCar)
        {
            if (updatedCar == null)
            {
                throw new ArgumentNullException(nameof(updatedCar));
                return false;
            }
            string idString = updatedCar.Id.ToString();
            Car matching = GetCarById(idString);

            matching.Model = updatedCar.Model;
            matching.Price = updatedCar.Price;
            matching.Year = updatedCar.Year;

            return true;

        }

        /// <summary>
        /// Deletes a Car from the generic collection
        /// </summary>
        /// <param name="id">The id of the Car to be deleted</param>
        /// <returns>True if successful, false in case of error</returns>
        public bool DeleteCar(string id)
        {
            Car matching = GetCarById(id);
            if (matching == null)
            {
                throw new ArgumentNullException(nameof(matching));
                return false;
            }
            var idx = usedCars.IndexOf(matching);
            usedCars.RemoveAt(idx);

            return true;

        }
    }
}
