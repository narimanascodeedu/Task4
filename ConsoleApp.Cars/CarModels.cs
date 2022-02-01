using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Cars
{
    internal class CarModels
    {
        public string city;
        public string brend;
        public string model;
        public int manufactureYear;
        public string banType;
        public string color;
        public double engine;
        public int horsePower;
        public string fuelType;
        public int mileage;
        public string gearbox;
        public string transmitter;
        public double price;

        public string GetInfo()
        {
            string output = $"{city}\n{brend}\n{model}\n{manufactureYear}\n{banType}\n{color}\n{engine}" +
                $"\n{horsePower}\n{fuelType}\n{mileage}\n{gearbox}\n{transmitter}\n{price}₼";

            return output;
        }


    }
}
