using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRentalSystem
{

    internal class Program
    {
        enum Menu
        {
            Add = 1,
            Cars,
            Motorbikes,
            Exit
        }
        static List<Vehicle> vehicles = new List<Vehicle>(); 
       
        static void Main(string[] args)
        {
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("Welcome to the Vehicle Rental!");
                Console.WriteLine("1. Add Vehicles to the System");
                Console.WriteLine("2. View List of Available Cars");
                Console.WriteLine("3. View List of Available Motorbikes");
                Console.WriteLine("4. Exit");

                int input = int.Parse(Console.ReadLine());
                Menu choice = (Menu)input;

                switch (choice)
                {
                    case Menu.Add:
                        AddVehicle();
                        break;

                    case Menu.Cars:
                        ViewAvailableCars();
                        break;

                    case Menu.Motorbikes:
                        ViewAvailableMotorbikes();
                        break;

                    case Menu.Exit:
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("Invalid choice, please try again.");
                        break;
                }

            }

        }
        static void ViewAvailableCars()
        {
            foreach (var vehicle in vehicles)
            {
                if (vehicle is Car && vehicle.IsAvailable)
                {
                    vehicle.GetDetails();
                }
            }
        }

        static void ViewAvailableMotorbikes()
        {
            foreach (var vehicle in vehicles)
            {
                if (vehicle is Motorbike && vehicle.IsAvailable)
                {
                    vehicle.GetDetails();
                }
            }
        }
        public static void AddVehicle()
        {
            Console.WriteLine("1. Car");
            Console.WriteLine("2. Motorbike");
            Console.WriteLine("Please select the Vehicle you would like to add: ");
            int addVehicle = int.Parse(Console.ReadLine());

            if (addVehicle == 1)
            {
                Car car = new Car();
                Console.Write("Make: ");
                car.Make = Console.ReadLine();
                Console.Write("Model: ");
                car.Model = Console.ReadLine();
                Console.Write("Year: ");
                car.Year = int.Parse(Console.ReadLine());
                Console.Write("Number of Doors: ");
                car.NumberOfDoors = int.Parse(Console.ReadLine());
                car.IsAvailable = true;
                vehicles.Add(car);
                Console.WriteLine("Car added successfully!");
                Console.WriteLine("");
            }
            else if (addVehicle == 2)
            {
                Motorbike motorbike = new Motorbike();
                Console.Write("Make: ");
                motorbike.Make = Console.ReadLine();
                Console.Write("Model: ");
                motorbike.Model = Console.ReadLine();
                Console.Write("Year: ");
                motorbike.Year = int.Parse(Console.ReadLine());
                Console.Write("Rental Rate Per Day: ");
                motorbike.RentalRatePerDay = double.Parse(Console.ReadLine());
                Console.Write("Does it have a side car: ");
                motorbike.HasSideCar = bool.Parse(Console.ReadLine());
                motorbike.IsAvailable = true;

                vehicles.Add(motorbike);
                Console.WriteLine("Motorbike has been added successfully!");
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("Invalid selection. Please try again.");
            }
            Console.WriteLine("");

        }

    }
}
