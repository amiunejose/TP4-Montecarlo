using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VentaDeRevistasMontecarlo.Tools;

namespace VentaDeRevistasMontecarlo.Logica
{
    class SimuladorRevistas2
    {
        private DistribucionDeProb AbrePuerta;
        private DistribucionDeProb AtiendePuerta;
        private DistribucionDeProb VentaMujer;
        private DistribucionDeProb VentaHombre;
        private DistribucionDeProb SuscripcionMujer;
        private DistribucionDeProb SuscripcionHombre;

        public SimuladorRevistas2()
        {

            AbrePuerta = new DistribucionDeProb("AbrePuerta");

            Opcion AbrePuertaOp1 = new Opcion("NO", 0);
            Opcion AbrePuertaOp2 = new Opcion("SI", 0.3);
            AbrePuerta.AddOpcion(AbrePuertaOp1);
            AbrePuerta.AddOpcion(AbrePuertaOp2);


            AtiendePuerta = new DistribucionDeProb("AtiendePuerta");

            Opcion AtiendePuertaOp1 = new Opcion("Mujer", 0);
            Opcion AtiendePuertaOp2 = new Opcion("Hombre", 0.8);
            AtiendePuerta.AddOpcion(AtiendePuertaOp1);
            AtiendePuerta.AddOpcion(AtiendePuertaOp2);


            VentaMujer = new DistribucionDeProb("VentaMujer");

            Opcion VentaMujerOp1 = new Opcion("SI", 0);
            Opcion VentaMujerOp2 = new Opcion("NO", 0.15);
            VentaMujer.AddOpcion(VentaMujerOp1);
            VentaMujer.AddOpcion(VentaMujerOp2);


            VentaHombre = new DistribucionDeProb("VentaHombre");

            Opcion VentaHombreOp1 = new Opcion("SI", 0);
            Opcion VentaHombreOp2 = new Opcion("NO", 0.25);
            VentaHombre.AddOpcion(VentaHombreOp1);
            VentaHombre.AddOpcion(VentaHombreOp2);


            SuscripcionMujer = new DistribucionDeProb("SuscripcionMujer");

            Opcion SuscripcionMujerOp1 = new Opcion("1", 0);
            Opcion SuscripcionMujerOp2 = new Opcion("2", 0.6);
            Opcion SuscripcionMujerOp3 = new Opcion("3", 0.9);
            SuscripcionMujer.AddOpcion(SuscripcionMujerOp1);
            SuscripcionMujer.AddOpcion(SuscripcionMujerOp2);
            SuscripcionMujer.AddOpcion(SuscripcionMujerOp3);


            SuscripcionHombre = new DistribucionDeProb("SuscripcionHombre");

            Opcion SuscripcionHombreOp1 = new Opcion("1", 0);
            Opcion SuscripcionHombreOp2 = new Opcion("2", 0.1);
            Opcion SuscripcionHombreOp3 = new Opcion("3", 0.5);
            Opcion SuscripcionHombreOp4 = new Opcion("4", 0.8);
            SuscripcionHombre.AddOpcion(SuscripcionHombreOp1);
            SuscripcionHombre.AddOpcion(SuscripcionHombreOp2);
            SuscripcionHombre.AddOpcion(SuscripcionHombreOp3);
            SuscripcionHombre.AddOpcion(SuscripcionHombreOp4);
        }

        public string[][] ObtenerSimulacion(int cantidad, int limInf, int limSup)
        {
            // Los 2 vectores con los que vamos a trabajar.
            string[] vectorSimulacion = new string[11];
            string[] vectorSimulacion_menos1 = new string[11];

            // Cantidad de filas que vamos a mostrar.
            int simul_a_mostrar = (limSup - limInf) + 1;

            // Creo el vector que contendra las simulaciones a mostrar
            string[][] simulaciones = new string[simul_a_mostrar][];


            // Variables varias
            Random aleatorio = new Random(); // Valor RND
            int num;
            int z = 0;


            for (int a = 0; a < vectorSimulacion_menos1.Length; a++)
            {
                if (a == 7 || a == 10)
                {
                    vectorSimulacion_menos1[a] = "0";
                }
                else vectorSimulacion_menos1[a] = " ";
            }


            for (int i = 1; i <= cantidad; i++)
            {

                // Reseteo el vector para cada simulacion
                for (int j = 0; j < vectorSimulacion.Length; j++)
                {
                    if (j == 7 || j == 10)
                    {
                        // Conservo los valores de los acumuladores
                        vectorSimulacion[j] = vectorSimulacion_menos1[j];
                    }
                    else vectorSimulacion[j] = " ";
                    
                }



                // Visitas
                vectorSimulacion[0] = (i).ToString();



                // RND AbrePuerta (si abre la puerta o no)
                double RND = Truncate.truncar(aleatorio.NextDouble(), 3);
                vectorSimulacion[1] = RND.ToString();

                foreach (Opcion opcion in AbrePuerta.opciones)
                {
                    if (RND > opcion.acum)
                    {
                        vectorSimulacion[2] = opcion.nombre;
                    }
                }



                // RND HombreMujer (Si es mujer o hombre)
                RND = Truncate.truncar(aleatorio.NextDouble(), 3);
                vectorSimulacion[3] = RND.ToString();

                if (vectorSimulacion[2] == "SI")
                {
                    foreach (Opcion opcion in AtiendePuerta.opciones)
                    {
                        if (RND > opcion.acum)
                        {
                            vectorSimulacion[4] = opcion.nombre;
                        }
                    }



                    // RND Venta (si vendio o no vendio)
                    RND = Truncate.truncar(aleatorio.NextDouble(), 3);
                    vectorSimulacion[5] = RND.ToString();

                    if (vectorSimulacion[4] == "Mujer")
                    {
                        foreach (Opcion opcion in VentaMujer.opciones)
                        {
                            if (RND > opcion.acum)
                            {
                                vectorSimulacion[6] = opcion.nombre;
                            }

                        }
                    }
                    else
                    {
                        foreach (Opcion opcion in VentaHombre.opciones)
                        {
                            if (RND > opcion.acum)
                            {
                                vectorSimulacion[6] = opcion.nombre;
                            }
                        }
                    }





                    // Cuento las ventas realizadas.
                    if (vectorSimulacion[6] == "SI")
                    {
                        vectorSimulacion[7] = (Convert.ToInt32(vectorSimulacion[7]) + 1).ToString();
                    }








                    // RND Suscripcion (Cuantas suscripciones compro dependiendo el sexo)
                    RND = Truncate.truncar(aleatorio.NextDouble(), 3);
                    vectorSimulacion[8] = RND.ToString();

                    if (vectorSimulacion[6] == "SI")
                    {

                        if (vectorSimulacion[4] == "Mujer")
                        {
                            foreach (Opcion opcion in SuscripcionMujer.opciones)
                            {
                                if (RND > opcion.acum)
                                {
                                    vectorSimulacion[9] = opcion.nombre;
                                }
                            }
                        }
                        else
                        {
                            foreach (Opcion opcion in SuscripcionHombre.opciones)
                            {
                                if (RND > opcion.acum)
                                {
                                    vectorSimulacion[9] = opcion.nombre;
                                }
                            }
                        }
                    }
                }




                // Acumulo las suscripciones vendidas
                if (vectorSimulacion[9] == " ")
                {
                    num = 0;
                }
                else
                {
                    num = Convert.ToInt32(vectorSimulacion[9]);
                }
                vectorSimulacion[10] = (Convert.ToInt32(vectorSimulacion_menos1[10]) + num).ToString();





                // Copio el vector simulacion al vector menos 1 para la proxima simulacion.
                for ( int r = 0 ; r < vectorSimulacion.Length ; r++ )
                {
                    vectorSimulacion_menos1[r] = vectorSimulacion[r];
                }



                // Pregunto si debo mostrar la informacion de la simulacion actual o no.
                if (i >= limInf && i <= limSup)
                {
                    simulaciones[z] = new string[11];
                    for (int u = 0; u < 11; u++)
                    {

                        simulaciones[z][u] = vectorSimulacion[u];

                    }
                    z++;

                }

            }

            return simulaciones;
        }





    }
}
