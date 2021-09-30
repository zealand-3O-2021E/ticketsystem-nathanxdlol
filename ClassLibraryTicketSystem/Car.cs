using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTicketSystem
{
    public class Car
    {
        string _Licenseplate;
        DateTime _Date;



        public Car(string Licenseplate, DateTime Date)
        {
            _Licenseplate = Licenseplate;
            _Date = Date;
        }
        public string Licenseplate
        {
            get => _Licenseplate;
            set => _Licenseplate = value;
        }
        public DateTime date
        {
            get => _Date;
            set => _Date = value;

        }
        /// <summary>
        /// return the price of car
        /// </summary>
        /// <returns> 240 </returns>
        public double Price()
        {
            return 240;
        }
        /// <summary>
        /// return the vehicle type
        /// </summary>
        /// <returns> Car </returns>
        public string VehicleType()
        {
            return "Car";
        }

    }
}
