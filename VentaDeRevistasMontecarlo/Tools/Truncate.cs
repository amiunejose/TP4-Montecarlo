using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentaDeRevistasMontecarlo.Tools
{
    class Truncate
    {

        public static double truncar(double num, int cantDecim)
        {
            double multiplicador = Math.Pow(10, cantDecim);
            double temp = Convert.ToDouble(Math.Truncate(num * multiplicador));
            double result = temp / multiplicador;

            return result;

        }


    }
}
