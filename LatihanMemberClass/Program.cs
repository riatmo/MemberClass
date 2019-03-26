using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanMemberClass
{
    class Program
    {
        static void Main(string[] args)
        {
            //Objek
            Taxi driverku = new Taxi();

            //Properties value
            driverku.DriverName = "Ragil";
            driverku.OnDuty = true;
            driverku.NumPassenger = 16;

           
        

            //Call Method Taxi
            driverku.TaxiInfo();
            if (driverku.OnDuty == true)
            {
                driverku.PickUpPassenger();

            }
            else
            {
                driverku.DropOffPassenger();
            }

            Console.ReadKey();
        }
    }
}
