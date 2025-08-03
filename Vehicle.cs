using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRentalSystem
{
    class Vehicle
    {
        string make;
        string model;
        int year;
        double rentalRatePerDay;
        bool isAvailable;

        public Vehicle()
        {
          
        }

        public Vehicle(string make, string model, int year, double rentalRatePerDay, bool isAvailable)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.rentalRatePerDay = rentalRatePerDay;
            this.isAvailable = isAvailable;
        }

        public string Make { get => make; set => make = value; }
        public string Model { get => model; set => model = value; }
        public int Year { get => year; set => year = value; }
        public double RentalRatePerDay { get => rentalRatePerDay; set => rentalRatePerDay = value; }
        public bool IsAvailable { get => isAvailable; set => isAvailable = value; }

        public delegate void VehicleRentedEventHandler(Vehicle vehicle);
        public event VehicleRentedEventHandler OnVehicleRented;
        

        public virtual void GetDetails()
        {
            Console.WriteLine($"The Make of this car  {Make}, Model: {Model}, Year: {Year}");
        }

        public void Rent()
        {
            if (IsAvailable)
            {
                IsAvailable = false;
                OnVehicleRented?.Invoke(this);
            }
            else
            {
                Console.WriteLine("This vehicle is not available for rent :(");
            }
        }

        public void Return()
        {
            IsAvailable = true;
        }
    }
}
