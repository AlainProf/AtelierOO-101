using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtelierOO_101.ONU
{
    class CoordGeo
    {
        public double Latitude { get; }   
        public double Longitude { get; set; } 

        public CoordGeo(double la, double lo) 
        {
            Latitude = la;  
            Longitude = lo; 
        }

        public void Afficher()
        {
            // 45° 47′ nord, 74° 00′ ouest
            char hemis = 'N';
            char occid = 'O';
            if (Latitude < 0)
            {
                hemis = 'S';
            }

            if (Longitude < 0)
            {
                occid = 'E';
            }

            Console.WriteLine($"{Math.Abs(Latitude).ToString("N2")} {hemis}, " +
                              $"{Math.Abs(Longitude).ToString("N2")} {occid}");
        }
    }
}
