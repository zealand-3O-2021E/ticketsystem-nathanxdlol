using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTicketSystem
{
        public class MC
    {
        string _Licenseplate;
        DateTime _Date;

        public MC(string Licenseplate, DateTime Date)
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
        public double Price()
        {
            return 125 ;
        }
        public string Vehicle()
        {
            return "MC";
        }

    }
}
