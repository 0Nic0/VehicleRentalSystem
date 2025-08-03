using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRentalSystem
{
     class Car : Vehicle, IRentable
    {
        int numberOfDoors;
        public Car()
        {
            
        }
        public Car(string make, string model, int year, double rentalRatePerDay, bool isAvailable, int numberOfDoors):
            base(make , model, year, rentalRatePerDay, isAvailable)
        {
            this.numberOfDoors = numberOfDoors;
        }

        public int NumberOfDoors { get => numberOfDoors; set => numberOfDoors = value; }

        public override void GetDetails()
        {
            base.GetDetails();
            Console.WriteLine($"This car has {NumberOfDoors} doors");
        }
     
    }
}
