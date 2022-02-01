using System;
using System.Text;

namespace ConsoleApp.Cars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            CarModels car1 = new CarModels();

            car1.city = "Bakı";
            car1.brend = "Hyundai";
            car1.model = "i30";
            car1.manufactureYear = 2012;
            car1.banType = "Hetçbek";
            car1.color = "Boz";
            car1.engine = 1.6;
            car1.horsePower = 130;
            car1.fuelType = "Benzin";
            car1.mileage = 118000;
            car1.gearbox = "Avtomat";
            car1.transmitter = "Ön";
            car1.price = 20900;

            CarModels car2 = new CarModels();


            car2.city = "Bakı";
            car2.brend = "Kia";
            car2.model = "Rio";
            car2.manufactureYear = 2010;
            car2.banType = "Hetçbek";
            car2.color = "qara";
            car2.engine = 2.0;
            car2.horsePower = 150;
            car2.fuelType = "Benzin";
            car2.mileage = 145000;
            car2.gearbox = "Mexanika";
            car2.transmitter = "Ön";
            car2.price = 15000;


            CarModels car3 = new CarModels();


            car3.city = "Gəncə";
            car3.brend = "Audi";
            car3.model = "RS7";
            car3.manufactureYear = 2017;
            car3.banType = "Sedan";
            car3.color = "qara";
            car3.engine = 4.5;
            car3.horsePower = 660;
            car3.fuelType = "Benzin";
            car3.mileage = 145000;
            car3.gearbox = "Avtomat";
            car3.transmitter = "Tam";
            car3.price = 87000;

            CarModels[] cars = new CarModels[3];
            cars[0] = car1;
            cars[1] = car2;
            cars[2] = car3;

            foreach (CarModels car in cars)
            {
                Console.WriteLine(car.GetInfo());
            }
        }
    }
}
