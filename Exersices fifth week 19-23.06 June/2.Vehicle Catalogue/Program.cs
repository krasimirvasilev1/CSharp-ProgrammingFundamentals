using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Vehicle_Catalogue
{
    class Vehicle
    {
        public string TypeOfVehicle { get; set; }
        public string Model { get; set; }
        public string Colour { get; set; }
        public double Horsepower { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> allVehicles = new List<Vehicle>();
            var inputContinuous = true;

            while (inputContinuous)
            {
                var input = Console.ReadLine().Split().ToArray();
                if (input[0] == "End")
                {
                    inputContinuous = false;
                    break;
                }

                Vehicle newVehicle = new Vehicle
                {
                    TypeOfVehicle = input[0].ToLower(),
                    Model = input[1],
                    Colour = input[2],
                    Horsepower = int.Parse(input[3])
                };
                allVehicles.Add(newVehicle);
            }
            inputContinuous = true;

            var horsePowerCars = 0.0;
            var numberOfCars = 0.0;

            var horsePowerTrucks = 0.0;
            var numberOfTrucks = 0.0;
            while (inputContinuous)
            {
                var inputModels = Console.ReadLine();
                if (inputModels == "Close the Catalogue")
                {
                    inputContinuous = false;
                    break;
                }

                foreach (var item in allVehicles)
                {
                    if (item.TypeOfVehicle == "car")
                    {
                        horsePowerCars += item.Horsepower;
                        numberOfCars++;
                    }
                    else
                    {
                        horsePowerTrucks += item.Horsepower;
                        numberOfTrucks++;
                    }
                    if (item.Model == inputModels)
                    {
                        if (item.TypeOfVehicle == "car")
                        {
                            Console.WriteLine($"Type: Car");
                        }
                        else
                        {
                            Console.WriteLine($"Type: Truck");
                        }
                        Console.WriteLine($"Model: {item.Model}");
                        Console.WriteLine($"Color: {item.Colour}");
                        Console.WriteLine($"Horsepower: {item.Horsepower}");

                    }
                }
            }

            if (numberOfCars == 0 && numberOfTrucks == 0)
            {
                numberOfCars++;
                numberOfTrucks++;
            }
            else if (numberOfTrucks == 0)
            {
                numberOfTrucks++;
            }
            else if (numberOfCars == 0)
            {
                numberOfCars++;
            }

            var averageHorsePowerCars = horsePowerCars / numberOfCars;
            var averageHorsePowerTrucks = horsePowerTrucks / numberOfTrucks;

            Console.WriteLine($"Cars have average horsepower of: {averageHorsePowerCars:F2}.");
            Console.WriteLine($"Trucks have average horsepower of: {averageHorsePowerTrucks:F2}.");

        }
    }
}
