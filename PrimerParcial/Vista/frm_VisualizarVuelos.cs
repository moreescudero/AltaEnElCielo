using Biblioteca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class frm_VisualizarVuelos : Form
    {
        List<Vuelo> vuelos = new List<Vuelo>();
        public frm_VisualizarVuelos()
        {
            InitializeComponent();
        }

        public frm_VisualizarVuelos(List<Vuelo> vuelos) : this()
        {
            this.vuelos = vuelos;
        }
        private void frm_VisualizarVuelos_Load(object sender, EventArgs e)
        {
            ActualizarDataGrid();
        }

        private void ActualizarDataGrid()
        {
            dgv_VisualizarVuelos.DataSource = null;
            dgv_VisualizarVuelos.DataSource = vuelos;
        }

        private void btn_AgregarVuelo_Click(object sender, EventArgs e)
        {
            frm_AgregarVuelo agregarVuelo = new frm_AgregarVuelo();
            if(agregarVuelo.ShowDialog() == DialogResult.OK)
            {
                ActualizarDataGrid();
            }
            else
            {

            }
        }
        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void dgv_VisualizarVuelos_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btn_AgregarVuelo.Enabled = true;

        }
    }
}
