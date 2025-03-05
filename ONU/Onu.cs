using AtelierOO_101.ClassesUtil;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtelierOO_101.ONU
{
    class Onu
    {
        Util _u = new();
        public void Exec()
        {
            _u.Titre("Organisation des nations unies");

            CoordGeo coordo1 = new(45.47, 74.00);
            Ville v1 = new();
            v1.Nom = "Saint-Jérôme";
            v1.Position = coordo1;

            /*            
            v1.Afficher();

            //26° 12′ 16″ sud, 28° 02′ 44″ est
            Ville v2 = new("Johannesbourg", new CoordGeo(-26.12, -28.02), 7100000 );   
            v2.Afficher();

            //41° 18′ S, 174° 47′ E.
            Ville v3 = new("Wellington", new CoordGeo(-41.182, -174.47), 202000);
            v3.Afficher();

            Ville v4 = new("Vancouver", new CoordGeo(49.15, 123.06), 706000);
            v4.Afficher();

            Ville v5 = new("Quito", new CoordGeo(0.14, 78.31), 1763000);
            v5.Afficher();

            Ville v6 = new("GreenWich", new CoordGeo(51.28, 0), 1667);
            v6.Afficher();

            Ville v7 = new("Jakarta", new CoordGeo(6.20, -106.84), 11350000);
            v7.Afficher();*/

            List<Ville> vc = new List<Ville>();
            vc.Add(new Ville("Montréal", new CoordGeo(45.50, 73.56), 1792000));
            vc.Add(new Ville("Toronto", new CoordGeo(43.40, 79.23), 3025000));
            vc.Add(new Ville("Calgary", new CoordGeo(51.04, 114.07), 1300000));
            vc.Add(v1);

            Pays Can = new("Canada", vc, new Ville("Ottawa", new CoordGeo(45.25, 75.41), 1480000));

            Can.Afficher();

            _u.Pause();

        }

    }
}
