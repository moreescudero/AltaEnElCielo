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
    public partial class frm_EstadisticasHistoricas : Form
    {
        DataTable tabla = new DataTable();

        public frm_EstadisticasHistoricas()
        {
            InitializeComponent();
        }

        private void frm_EstadisticasHistoricas_Load(object sender, EventArgs e)
        {
            dgv_VuelosHistoricos.DataSource = null;
            dgv_VuelosHistoricos.DataSource = Aerolinea.listaVuelosFinalizados;

            cmb_Opciones.Items.Add("Recaudaciones");
            cmb_Opciones.Items.Add("Pasajeros totales");
            cmb_Opciones.Items.Add("Destinos por facturación");
            cmb_Opciones.Items.Add("Pasajeros frecuentes por cantidad de vuelos");
            cmb_Opciones.Items.Add("Horas de vuelo de cada avión");
            cmb_Opciones.Items.Add("Informacion completa de la Aerolinea");


            tabla.Clear();
            tabla.Columns.Add("Destino", typeof(string));
            tabla.Columns.Add("Recaudacion", typeof(float));

            foreach (string destino in Enum.GetNames(typeof(Destinos)))
            {
                tabla.Rows.Add(destino, Aerolinea.BuscarRecaudacionPorDestino(destino));
            }

        }

        private void btn_Volver_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btn_VerEstadisticas_Click(object sender, EventArgs e)
        {
            pnl_VerEstadisticas.Visible = true;
            
        }

        private void btn_CerrarPanel_Click(object sender, EventArgs e)
        {
            pnl_VerEstadisticas.Visible = false;
        }

        private void MostrarRecaudaciones()
        {
            lbl_DestinoMasElegido.Visible = true;
            lbl_GananciasInternacionales.Visible = true;
            lbl_GananciasNacionales.Visible = true;
            lbl_RecaudacionTotal.Visible = true;
            txt_DestinoMasElegido.Visible = true;
            txt_GananciasInternacionales.Visible = true;
            txt_GananciasNacionales.Visible = true;
            txt_RecaudacionTotal.Visible = true;
            dgv_SegunOpcionElegida.Visible = false;
        }

        private void OcultarTodo()
        {
            lbl_DestinoMasElegido.Visible = false;
            lbl_GananciasInternacionales.Visible = false;
            lbl_GananciasNacionales.Visible = false;
            lbl_RecaudacionTotal.Visible = false;
            txt_DestinoMasElegido.Visible = false;
            txt_GananciasInternacionales.Visible = false;
            txt_GananciasNacionales.Visible = false;
            txt_RecaudacionTotal.Visible = false;
            pnl_Informacion.Visible = false;
        }

        private void MostrarInformacionCompleta()
        {
            pnl_Informacion.Visible = true;
            rtx_Info.Text = String.Empty;
            rtx_Info.Text = "Empleados:\n";
            foreach(KeyValuePair<int, Empleado> item in Aerolinea.diccEmpleados)
            {
                rtx_Info.Text += item.Value.ToString() + "\n";
            }
            rtx_Info.Text += "\n\nAviones: \n";
            foreach(Avion avion in Aerolinea.listaAviones)
            {
                rtx_Info.Text += avion.ToString() + "\n";
            }
            rtx_Info.Text += "\nVuelos con mayor recaudacion: \n";
            foreach(Vuelo vuelo in Aerolinea.BuscarVueloMayorRecaudacion())
            {
                rtx_Info.Text += vuelo.ToString() + "\n";
            }
            rtx_Info.Text += "\nPasajeros platino: ";
            foreach (Pasajero pasajero in Aerolinea.CrearListaClientesPlatino())
            {
                rtx_Info.Text += pasajero.ToString() + "\n";
            }
        }

        private void CalcularRecaudaciones()
        {
            txt_RecaudacionTotal.Text = Aerolinea.CalcularGanancia().ToString();
            txt_GananciasInternacionales.Text = Aerolinea.CalcularGanancia(false).ToString();
            txt_GananciasNacionales.Text = Aerolinea.CalcularGanancia(true).ToString();
            txt_DestinoMasElegido.Text = Aerolinea.BuscarDestinoMasPopular();
        }

        private void HacerDataGridPorDestinos()
        {
            dgv_SegunOpcionElegida.DataSource = tabla;
            dgv_SegunOpcionElegida.Sort(dgv_SegunOpcionElegida.Columns[1], ListSortDirection.Descending);
        }

        private void cmb_Opciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgv_SegunOpcionElegida.DataSource = null;
            dgv_SegunOpcionElegida.Visible = true;
            OcultarTodo();
            switch (cmb_Opciones.SelectedIndex)
            {
                case 0:
                    MostrarRecaudaciones();
                    CalcularRecaudaciones();
                    break;
                case 1:
                    dgv_SegunOpcionElegida.DataSource = Aerolinea.listaPasajeros;
                    break;
                case 2:
                    HacerDataGridPorDestinos();
                    break;
                case 3:
                    dgv_SegunOpcionElegida.DataSource = Aerolinea.CrearListaClientes();
                    break;
                case 4:
                    dgv_SegunOpcionElegida.DataSource = Aerolinea.listaAviones;
                    //dgv_SegunOpcionElegida.Sort(dgv_SegunOpcionElegida.Columns["HorasEnVuelo"], ListSortDirection.Descending);
                    break;
                default:
                    MostrarInformacionCompleta();
                    break;
            }
        }

        private void pnl_VerEstadisticas_VisibleChanged(object sender, EventArgs e)
        {
            cmb_Opciones.SelectedIndex = -1;
            dgv_SegunOpcionElegida.Visible = false;
            OcultarTodo();
        }
    }
}
