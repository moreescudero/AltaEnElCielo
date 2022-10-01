using Biblioteca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class frm_AgregarVuelo : Form
    {
        Avion unAvion;
        EDestinos origen;
        EDestinos destino;
        DateTime salida;
        bool banderaCalendario = false;
        bool banderaOrigenCargado = false;
        bool banderaDestinoCargado = false;
        bool esNacional;
        bool hayComida;

        public frm_AgregarVuelo()
        {
            InitializeComponent();
        } 
        public frm_AgregarVuelo(EDestinos origen, EDestinos destino, DateTime salida) : this()
        {
            this.origen = origen; 
            this.destino = destino;
            this.salida = salida;
            banderaCalendario = true;
            banderaDestinoCargado = true;
            banderaOrigenCargado = true;
        }

        private void frm_AgregarVuelo_Load(object sender, EventArgs e)
        {
            if(banderaCalendario && banderaDestinoCargado && banderaOrigenCargado)
            {
                MostrarOrigenDestino();
                lbl_AyudaAviones.Visible = false;
                cdr_Salida.SelectionStart = salida;
                cmb_Origen.Enabled = false;
                cmb_Destino.Enabled = false;
                cdr_Salida.Enabled = false;
                cmb_Hora.Enabled = true;
            }
            else
            {
                cdr_Salida.MinDate = DateTime.Now.AddDays(7);
                foreach (string destino in Enum.GetNames(typeof(EDestinos)))
                {
                    cmb_Origen.Items.Add(destino);
                }
            }
            for (int i = 0; i < 24; i++)
            {
                if (i <= 9)
                {
                    cmb_Hora.Items.Add("0" + i + ":00");
                }
                else
                {
                    cmb_Hora.Items.Add(i + ":00");
                }
            }
            txt_CodigoVuelo.Text = Vuelo.GeneradorCodigoVuelo();
        }
        
        private void MostrarOrigenDestino()
        {
            cmb_Origen.Items.Add(origen);
            cmb_Destino.Items.Add(destino);
            cmb_Origen.SelectedIndex = 0;
        }

        private void CargarAvionesDisponibles()
        {
            cmb_Avion.Enabled = true;
            cmb_Avion.Items.Clear();
            List<Avion> aviones = Aerolinea.BuscarAvionesDisponibles(salida);

            foreach (Avion avion in aviones)
            {
                cmb_Avion.Items.Add(avion.Matricula);
            }
        }

        private void cdr_Salida_DateSelected(object sender, DateRangeEventArgs e)
        {
            string? aux = cdr_Salida.SelectionStart.ToString("g");
            lbl_AyudaAviones.Visible = false;
            banderaCalendario = true;
            cmb_Hora.Enabled = true;
            salida = DateTime.Parse(aux);
        }

        private void btn_AgregarVuelo_Click(object sender, EventArgs e)
        {
            Aerolinea.listaVuelos.Add(new Vuelo(txt_CodigoVuelo.Text, cmb_Avion.Text, esNacional, origen, destino, salida, hayComida, unAvion.CantAsientos, unAvion.CapacidadBodega));
            this.DialogResult = DialogResult.OK;
        }

        private void cmb_Origen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_Origen.Items.Count > 1)
            {
                cmb_Destino.Enabled = true;
                cmb_Destino.Items.Clear();

                foreach (string destino in Enum.GetNames(typeof(EDestinos)))
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
            else
            {
                cmb_Destino.SelectedIndex = 0;
            }

            origen = (EDestinos)Enum.Parse(typeof(EDestinos), cmb_Origen.Text);
            banderaOrigenCargado = true;
        }

        private void cmb_Destino_SelectedIndexChanged(object sender, EventArgs e)
        {
            destino = (EDestinos)Enum.Parse(typeof(EDestinos), cmb_Destino.Text);
            banderaDestinoCargado = true;
            if(((int)destino) < 100 && ((int)origen) < 100)
            {
                esNacional = true;
            }
            else
            {
                esNacional = false;
            }
            FormCompleto();
        }

        private void FormCompleto()
        {
            if(banderaOrigenCargado && banderaDestinoCargado && banderaCalendario && cmb_Avion.Text != String.Empty)
            {
                btn_AgregarVuelo.Enabled = true;
            }
        }

        private void chk_SiHay_CheckedChanged(object sender, EventArgs e)
        {
            if(chk_SiHay.Checked)
            {
                hayComida = true;
            }
            else
            {
                hayComida = false;
            }
            FormCompleto();
        }

        private void cmb_Avion_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(Avion avion in Aerolinea.listaAviones)
            {
                if(cmb_Avion.Text == avion.Matricula)
                {
                    unAvion = avion;
                }
            }
            FormCompleto();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void cmb_Hora_SelectedIndexChanged(object sender, EventArgs e)
        {
            string horaStr = "";
            for (int i = 0; i < 2; i++)
            {
                horaStr += cmb_Hora.Text[i];
            }
            int año, mes, dia, hora;
            año = salida.Year;
            mes = salida.Month;
            dia = salida.Day;
            hora = int.Parse(horaStr);

            salida = new DateTime(año, mes, dia, hora, 0, 0);

            CargarAvionesDisponibles();
        }
    }
}
