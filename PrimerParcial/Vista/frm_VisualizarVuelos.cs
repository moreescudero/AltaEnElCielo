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
        int index;
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
                lbl_AgregarVueloCancelado.Visible = true;
            }
        }
        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void dgv_VisualizarVuelos_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            index = e.RowIndex;
            if(index != 0)
            {
                btn_VerPasajeros.Enabled = true;
                lbl_AgregarVueloCancelado.Visible = false;
            }
        }

        private void btn_VerPasajeros_Click(object sender, EventArgs e)
        {
            pnl_VerPasajeros.Visible = true;
        }

        private void pnl_VerPasajeros_VisibleChanged(object sender, EventArgs e)
        {
            dgv_Pasajeros.DataSource = null;
            dgv_Pasajeros.DataSource = vuelos[index].ListaPasajeros;
        }

        private void btn_Volver_Click(object sender, EventArgs e)
        {
            pnl_VerPasajeros.Visible = false;
            lbl_AgregarVueloCancelado.Visible = false;
        }
    }
}
