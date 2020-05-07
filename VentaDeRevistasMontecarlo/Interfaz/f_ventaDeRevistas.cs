using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VentaDeRevistasMontecarlo.Logica;

namespace VentaDeRevistasMontecarlo
{
    public partial class f_ventaDeRevistas : Form
    {

        private int cantidad;
        private string[][] simulacion;
        private int limInf;
        private int limSup;



        public f_ventaDeRevistas()
        {
            InitializeComponent();
        }

        private void F_ventaDeRevistas_Load(object sender, EventArgs e)
        {

        }

        private void llenarGrilla()
        {
            DataTable myDataTable = new DataTable();

            myDataTable.Columns.Add("Visitas", typeof(string));
            myDataTable.Columns.Add("RND1", typeof(string));
            myDataTable.Columns.Add("AbrenPuerta", typeof(string));
            myDataTable.Columns.Add("RND2", typeof(string));
            myDataTable.Columns.Add("Hombre/Mujer", typeof(string));
            myDataTable.Columns.Add("RND3", typeof(string));
            myDataTable.Columns.Add("Vende", typeof(string));
            myDataTable.Columns.Add("CantVentas", typeof(string));
            myDataTable.Columns.Add("RND4", typeof(string));
            myDataTable.Columns.Add("Suscipciones", typeof(string));
            myDataTable.Columns.Add("AcumSuscrip", typeof(string));


            foreach (string[] vectorSimulacion in simulacion)
            {
                myDataTable.Rows.Add(vectorSimulacion[0], vectorSimulacion[1], vectorSimulacion[2],
                    vectorSimulacion[3], vectorSimulacion[4], vectorSimulacion[5], vectorSimulacion[6],
                    vectorSimulacion[7], vectorSimulacion[8], vectorSimulacion[9],vectorSimulacion[10]);
            }

            grid_simulacion.DataSource = myDataTable;
        }

        private void Btn_generar_Click(object sender, EventArgs e)
        {
            cantidad = Convert.ToInt32(txt_cant_sim.Text);
            limInf = Convert.ToInt32(txt_limInf.Text);
            limSup = Convert.ToInt32(txt_limSup.Text);
            SimuladorRevistas simulador = new SimuladorRevistas();
            simulacion = simulador.ObtenerSimulacion(cantidad, limInf, limSup);
            llenarGrilla();


        }
    }
}
