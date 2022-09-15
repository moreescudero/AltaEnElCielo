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

        bool banderaCalendario = false;
        
        public frm_VenderVuelos()
        {
            InitializeComponent();
        }

        private void frm_VenderVuelos_Load(object sender, EventArgs e)
        {
            tmr_HoraActual.Start();
            cdr_Salida.MinDate = DateTime.Now;
            SetHora();
            foreach(string destino in Enum.GetNames(typeof(Destinos)))
            {
                cmb_Origen.Items.Add(destino);
            }
            cmb_Clase.Items.Add("Turista"); // mejorar
            cmb_Clase.Items.Add("Premium");

            //cmb_IdaVuelta.Items.Add("Solo ida"); // hacerlo bien
            //cmb_IdaVuelta.Items.Add("Ida y vuelta"); 

        }
        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void SetHora()
        {
            lbl_HoraActual.Text = DateTime.Now.ToShortTimeString();
        }

        private void tmr_HoraActual_Tick(object sender, EventArgs e)
        {
            SetHora();
        }

        private void cdr_Salida_DateSelected(object sender, DateRangeEventArgs e)
        {
            banderaCalendario = true;
            DateTime ida = cdr_Salida.SelectionStart;
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
            decimal cantPasajeros = nud_CantidadPasajeros.Value;
            FormCompleto();
        }

        private void FormCompleto()
        {
            if(nud_CantidadPasajeros.Value > 0 && banderaCalendario && cmb_Origen.Text != String.Empty && cmb_Destino.Text != String.Empty && cmb_Clase.Text != String.Empty)
            {
                btn_Aceptar.Enabled = true;
            }
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            
        }

        private void cmb_Destino_SelectedIndexChanged(object sender, EventArgs e)
        {
            FormCompleto();
        }
    }
}
