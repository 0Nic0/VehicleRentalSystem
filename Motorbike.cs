using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRentalSystem
{
     internal class Motorbike: Vehicle, IRentable
    {
        bool hasSideCar;
        public Motorbike()
        {
          
        }
        public Motorbike(string make, string model, int year, double rentalRatePerDay, bool isAvailable, bool hasSideCar) : base(make, model, year, rentalRatePerDay, isAvailable)
        {
            this.hasSideCar = hasSideCar;
        }

       public bool HasSideCar { get => hasSideCar; set => hasSideCar = value; }

        public override void GetDetails()
        {
            base.GetDetails();
            Console.WriteLine($"Has Sidecar: {HasSideCar}");
        }

      
    }
}
