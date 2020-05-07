using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VentaDeRevistasMontecarlo.Tools;

namespace VentaDeRevistasMontecarlo.Logica
{
    class SimuladorRevistas
    {
        private DistribucionDeProb AbrePuerta;
        private DistribucionDeProb AtiendePuerta;
        private DistribucionDeProb VentaMujer;
        private DistribucionDeProb VentaHombre;
        private DistribucionDeProb SuscripcionMujer;
        private DistribucionDeProb SuscripcionHombre;

        public SimuladorRevistas()
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
            string[] vectorSimulacion = new string[11];
            int cant = (limSup - limInf) + 1;
            string[][] simulaciones = new string[cant][];


            for (int i = 0; i < 10; i++)
            {
                vectorSimulacion[i] = " ";
            }
            Random aleatorio = new Random();
            int acumSusc = 0;
            int acumVentas = 0;
            int num = 0;
            int z = 0;






            for (int i = 1; i <= cantidad; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    vectorSimulacion[j] = " ";
                }

                

                // Visitas
                vectorSimulacion[0] = (i).ToString();
                // RND AbrePuerta
                double RND = Truncate.truncar(aleatorio.NextDouble(), 3);
                vectorSimulacion[1] = RND.ToString();
                // AbrePuerta
                foreach (Opcion opcion in AbrePuerta.opciones)
                {
                    if (RND > opcion.acum)
                    {
                        vectorSimulacion[2] = opcion.nombre;
                    }
                }



                // RND HombreMujer
                RND = Truncate.truncar(aleatorio.NextDouble(), 3);
                vectorSimulacion[3] = RND.ToString();
                // Hombre/Mujer
                if (vectorSimulacion[2] == "SI")
                {
                    foreach (Opcion opcion in AtiendePuerta.opciones)
                    {
                        if (RND > opcion.acum)
                        {
                            vectorSimulacion[4] = opcion.nombre;
                        }
                    }



                    // RND Venta
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

                    if (vectorSimulacion[6] == "SI")
                    {
                        acumVentas++;
                    }

                    // RND Suscripcion
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

                if (vectorSimulacion[9] == " ")
                {
                    num = 0;
                }
                else
                {
                    num = Convert.ToInt32(vectorSimulacion[9]);
                }
                acumSusc += num;
                vectorSimulacion[10] = acumSusc.ToString();

                vectorSimulacion[7] = acumVentas.ToString();

                

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
