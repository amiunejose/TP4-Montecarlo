using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentaDeRevistasMontecarlo.Logica
{
    class DistribucionDeProb
    {

        private string descripcion;
        public List<Opcion> opciones;

        public DistribucionDeProb(string descripcion)
        {
            this.descripcion = descripcion;
            opciones = new List<Opcion>();
        }

        public void AddOpcion (Opcion opcion)
        {
            opciones.Add(opcion);
        }


    }
}
