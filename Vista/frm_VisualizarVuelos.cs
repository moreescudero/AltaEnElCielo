using Biblioteca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vista.Properties;

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
            ActualizarBackgroundImage();

            Formulario.Font(this);

        }

        private void ActualizarDataGrid()
        {
            dgv_VisualizarVuelos.DataSource = null;
            dgv_VisualizarVuelos.DataSource = vuelos;
        }

        private void btn_AgregarVuelo_Click(object sender, EventArgs e)
        {
            frm_AgregarVuelo agregarVuelo = new frm_AgregarVuelo();
            this.Hide();
            if(agregarVuelo.ShowDialog() == DialogResult.OK)
            {
                ActualizarDataGrid();
            }
            else
            {
                lbl_AgregarVueloCancelado.Visible = true;
            }
            this.Show();
        }
        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void dgv_VisualizarVuelos_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            index = e.RowIndex;
            if(index >= 0)
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

        private void ActualizarBackgroundImage()
        {
            DateTime tiempo = DateTime.Now;
            //DateTime tiempo = DateTime.Parse("23:00:00");
            DateTime amanecer = DateTime.Parse("06:25:00");
            DateTime tarde = DateTime.Parse("16:50:00");
            DateTime noche = DateTime.Parse("18:57:00");
            if (tiempo.CompareTo(noche) > 0 || tiempo.CompareTo(amanecer) < 0)
            {
                this.BackgroundImage = Resources.cielo_noche;
                lbl_Titulo.ForeColor = Color.White;
                lbl_TituloPasajeros.ForeColor = Color.White;
            }
            else
            {
                lbl_Titulo.ForeColor = Color.Black;
                lbl_TituloPasajeros.ForeColor = Color.Black;

                if (tiempo.CompareTo(tarde) > 0)
                {
                    this.BackgroundImage = Resources.cielo_tarde;
                }
                else
                {
                    this.BackgroundImage = Resources.cielo_dia;
                }
            }
        }
    }
}
