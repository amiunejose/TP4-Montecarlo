using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentaDeRevistasMontecarlo.Logica
{
    class Opcion
    {
        public string nombre;
        public double acum;

        public Opcion(string nombre, double acum)
        {
            this.nombre = nombre;
            this.acum = acum;
        }


    }
}
