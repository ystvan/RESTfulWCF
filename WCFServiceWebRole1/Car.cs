using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WCFServiceWebRole1
{
    [DataContract]
    public class Car
    {
        /// <summary>
        /// Properties with public access modifiers
        /// </summary>
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public int Price { get; set; }
        [DataMember]
        public int Year { get; set; }
        [DataMember]
        public string Model { get; set; }

        /// <summary>
        /// Constructor of the Car class
        /// </summary>
        /// <param name="id">ID of the car</param>
        /// <param name="price">Price of the car</param>
        /// <param name="year">Year of made</param>
        /// <param name="model">Model or brand name of the car</param>
        public Car(int id, int price, int year, string model)
        {
            Id = id;
            Price = price;
            Year = year;
            Model = model;
        }

        /// <summary>
        /// Default, empty constructor of Car class
        /// </summary>
        public Car()
        {
            
        }
    }
}