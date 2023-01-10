using Biblioteca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vista.Properties;

namespace Vista
{
    public partial class frm_EstadisticasHistoricas : Form
    {
        DataTable tabla = new DataTable();
        int index;
        public frm_EstadisticasHistoricas()
        {
            InitializeComponent();
        }

        private void frm_EstadisticasHistoricas_Load(object sender, EventArgs e)
        {
            ActualizarBackgroundImage();
            dgv_VuelosHistoricos.DataSource = null;
            dgv_VuelosHistoricos.DataSource = Aerolinea.listaVuelosFinalizados;
            MostrarInformacionCompleta();

            btn_VerPasajeros.Enabled = false;

            cmb_Opciones.Items.Add("Recaudaciones"); 
            cmb_Opciones.Items.Add("Pasajeros totales");
            cmb_Opciones.Items.Add("Destinos por facturación");
            cmb_Opciones.Items.Add("Pasajeros frecuentes por cantidad de vuelos");
            cmb_Opciones.Items.Add("Información completa de cada avión");
            cmb_Opciones.Items.Add("Informacion completa de la Aerolinea");


            tabla.Clear();
            tabla.Columns.Add("Destino", typeof(string));
            tabla.Columns.Add("Recaudacion", typeof(float));

            foreach (string destino in Enum.GetNames(typeof(EDestinos)))
            {
                tabla.Rows.Add(destino, Aerolinea.BuscarRecaudacionPorDestino(destino));
            }

            Formulario.Font(this);

        }

        private void btn_Volver_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btn_VerEstadisticas_Click(object sender, EventArgs e)
        {
            pnl_VerEstadisticas.Visible = true;
            
        }
        private void btn_VerPasajeros_Click(object sender, EventArgs e)
        {
            pnl_VerPasajeros.Visible = true;
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
            txt_Credito.Visible = true;
            txt_Debito.Visible = true;
            txt_Efectivo.Visible = true;
            lbl_Credito.Visible = true;
            lbl_Debito.Visible = true;
            lbl_Efectivo.Visible = true;
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
            txt_Credito.Visible = false;
            txt_Debito.Visible = false;
            txt_Efectivo.Visible = false;
            lbl_Credito.Visible = false;
            lbl_Debito.Visible = false;
            lbl_Efectivo.Visible = false;
        }

        private void MostrarInformacionCompleta()
        {
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
            txt_Efectivo.Text = Aerolinea.gananciaEfectivo.ToString();
            txt_Debito.Text = Aerolinea.gananciaDebito.ToString();
            txt_Credito.Text = Aerolinea.gananciaCredito.ToString();
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
                    dgv_SegunOpcionElegida.DataSource = Aerolinea.listaPasajerosFrecuentes;
                    break;
                case 4:
                    dgv_SegunOpcionElegida.DataSource = Aerolinea.listaAviones;
                    break;
                default:
                    pnl_Informacion.Visible = true;
                    break;
            }
        }

        private void pnl_VerEstadisticas_VisibleChanged(object sender, EventArgs e)
        {
            cmb_Opciones.SelectedIndex = -1;
            dgv_SegunOpcionElegida.Visible = false;
            OcultarTodo();
        }

        private void pnl_VerPasajeros_VisibleChanged(object sender, EventArgs e)
        {
            dgv_VerPasajeros.DataSource = null;
            dgv_VerPasajeros.DataSource = Aerolinea.listaVuelosFinalizados[index].ListaPasajeros;
        }

        private void dgv_VuelosHistoricos_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            index = e.RowIndex;
            if (index >= 0)
            {
                btn_VerPasajeros.Enabled = true;
            }
        }

        private void btn_CerrarVerPasajeros_Click_1(object sender, EventArgs e)
        {
            pnl_VerPasajeros.Visible = false;
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
                rtx_Info.BackColor = Color.FromArgb(98, 94, 150);
                lbl_DestinoMasElegido.ForeColor = Color.White;
                lbl_GananciasInternacionales.ForeColor = Color.White;
                lbl_GananciasNacionales.ForeColor = Color.White;
                lbl_RecaudacionTotal.ForeColor = Color.White;
                lbl_TituloPasajeros.ForeColor = Color.White;
                lbl_TituloVuelos.ForeColor = Color.White;
                lbl_Visualizar.ForeColor = Color.White;
            }
            else
            {
                lbl_DestinoMasElegido.ForeColor = Color.Black;
                lbl_GananciasInternacionales.ForeColor = Color.Black;
                lbl_GananciasNacionales.ForeColor = Color.Black;
                lbl_RecaudacionTotal.ForeColor = Color.Black;
                lbl_TituloPasajeros.ForeColor = Color.Black;
                lbl_TituloVuelos.ForeColor = Color.Black;
                lbl_Visualizar.ForeColor = Color.Black;

                if (tiempo.CompareTo(tarde) > 0)
                {
                    this.BackgroundImage = Resources.cielo_tarde;
                    rtx_Info.BackColor = Color.FromArgb(218, 168, 87);
                }
                else
                {
                    this.BackgroundImage = Resources.cielo_dia;
                    rtx_Info.BackColor = Color.FromArgb(114, 225, 252);
                }
            }
        }
    }
}
