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
    public partial class frm_VenderVuelos : Form
    {
        List<Vuelo> filtro = new List<Vuelo>();
        bool banderaCalendario = false;
        int index;
        //usar paneles
        public frm_VenderVuelos()
        {
            InitializeComponent();
        }

        private void frm_VenderVuelos_Load(object sender, EventArgs e)
        {
            cdr_Salida.MinDate = DateTime.Now;
            foreach(string destino in Enum.GetNames(typeof(Destinos)))
            {
                cmb_Origen.Items.Add(destino);
            }
            cmb_Clase.Items.Add("Turista"); 
            cmb_Clase.Items.Add("Premium");

            //en el btn help indicar que arrastrando en el calendario pueden indicar ida y vuelta o solo ida si marcan una sola fecha

        }

        private void cdr_Salida_DateSelected(object sender, DateRangeEventArgs e)
        {
            banderaCalendario = true;
            DateTime ida = cdr_Salida.SelectionStart; // esto para orgenizar el ida y vuelta
            DateTime vuelta = cdr_Salida.SelectionEnd;
            FormCompleto();
        }

        private void cmb_Origen_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_Destino.Enabled = true;
            cmb_Destino.Items.Clear();

            foreach (string destino in Enum.GetNames(typeof(Destinos)))
            {
                if (cmb_Origen.Text != destino)
                {
                    cmb_Destino.Items.Add(destino);

                    if (cmb_Origen.Text != "BuenosAires" && (destino == "Recife" || destino == "Roma" || destino == "Acapulco" || destino == "Miami"))
                    {
                        cmb_Destino.Items.Remove(destino);
                    }
                }
            }
        }
          
        private void nud_CantidadPasajeros_ValueChanged(object sender, EventArgs e)
        {
            FormCompleto();
        }

        private void FormCompleto()
        {
            if(nud_CantidadPasajeros.Value > 0 && banderaCalendario && cmb_Origen.Text != String.Empty && cmb_Destino.Text != String.Empty && cmb_Clase.Text != String.Empty)
            {
                btn_Continuar.Enabled = true;
            }
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            frm_AltaPasajero altaPasajero = new frm_AltaPasajero(filtro[index].CodigoVuelo, int.Parse(nud_CantidadPasajeros.Value.ToString()), cmb_Clase.Text);
            if(altaPasajero.ShowDialog() == DialogResult.OK)
            {
                this.DialogResult = DialogResult.OK; // alta pasajero se va a encargar de terminar de cargar todo
            }
            else
            {
                //informar que ocurrio un error en alta pasajeros SIN message box
            }
        }

        private void cmb_Destino_SelectedIndexChanged(object sender, EventArgs e)
        {
            FormCompleto();
        }

        private void ActualizarDataGrid()
        {
            filtro = Aerolinea.FiltrarVuelos((Destinos)Enum.Parse(typeof(Destinos), cmb_Origen.Text), (Destinos)Enum.Parse(typeof(Destinos), cmb_Destino.Text), int.Parse(nud_CantidadPasajeros.Value.ToString()));
            dgv_HayVuelo.DataSource = null;
            dgv_HayVuelo.DataSource = filtro;
        }

        private void btn_AgregarVuelo_Click(object sender, EventArgs e)
        {
            frm_AgregarVuelo agregarVuelo = new frm_AgregarVuelo((Destinos)Enum.Parse(typeof(Destinos), cmb_Origen.Text), (Destinos)Enum.Parse(typeof(Destinos), cmb_Destino.Text), cdr_Salida.SelectionStart);
            if(agregarVuelo.ShowDialog() == DialogResult.OK)
            {
                ActualizarDataGrid();
                lbl_NoHayVuelos.Visible = false;
            }
        }

        private void dgv_HayVuelo_VisibleChanged(object sender, EventArgs e)
        {
            ActualizarDataGrid();
                //usar un trycatch
            if (filtro.Count == 0)
            {
                lbl_NoHayVuelos.Text = "No hay vuelos que coincidan con el origen y el destino deseado";
            }
            
            btn_Continuar.Enabled = false;
            btn_AgregarVuelo.Visible = true;
        }

        private void dgv_HayVuelo_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            index = e.RowIndex;
            if(index >= 0)
            {
                btn_Aceptar.Enabled = true;
            }
        }

        private void btn_Continuar_Click(object sender, EventArgs e)
        {
            nud_CantidadPasajeros.Visible = false;
            cmb_Origen.Visible = false;
            cmb_Destino.Visible = false;
            cmb_Clase.Visible = false;
            cdr_Salida.Visible = false;
            lbl_Origen.Visible = false;
            lbl_Destino.Visible = false;
            lbl_CantPasajeros.Visible = false;
            lbl_Clase.Visible = false;
            lbl_Fechas.Visible = false;

            dgv_HayVuelo.Visible = true;

        }

    }
}
