using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanMemberClass
{
    class Taxi
    {
        //Properties
        public string DriverName { get; set; }
        public bool OnDuty { get; set; }
        public int NumPassenger { get; set; }
        

        //Method
        public void TaxiInfo()
        {
            Console.WriteLine("Driver Name : {0}", DriverName);
            Console.WriteLine("On Duty : {0}", OnDuty ? "Yes" : "No");
            Console.WriteLine("Number of Passenger : {0}", NumPassenger);

        }

        public void PickUpPassenger()
        {
            Console.WriteLine("\n\nDriver {0} sedang sibuk", DriverName);
        }

        public void DropOffPassenger()
        {
            Console.WriteLine("\n\nDriver {0} tersedia", DriverName);
        }

    }
}
