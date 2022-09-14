using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public static class Hardcodeo
    {
        public static List<Avion> InicializarAviones(List<Avion> aviones)
        {
            aviones.Add(new Avion("MSDK3278", 529, 11, 15027, true));
            aviones.Add(new Avion("PASD1272", 529, 11, 15027, false));
            aviones.Add(new Avion("ASDP7428", 110, 3, 2772, false));
            aviones.Add(new Avion("MKDF5728", 110, 3, 2772, true));
            aviones.Add(new Avion("UCJV1242", 110, 3, 2772, false));
            aviones.Add(new Avion("KCVK0348", 180, 4, 4536, false));
            aviones.Add(new Avion("PÑAS3554", 180, 4, 4536, true));

            return aviones;
        }

        
    }
}
