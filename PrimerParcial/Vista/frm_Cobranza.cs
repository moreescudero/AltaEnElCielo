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
    public partial class frm_Cobranza : Form
    {
        float total;
        List<Pasajero> pasajeros;
        public frm_Cobranza()
        {
            InitializeComponent();
        }
        public frm_Cobranza(float total, List<Pasajero> pasajeros) : this()
        {
            this.pasajeros = pasajeros;
            this.total = total;
        }

        //Load
        private void frm_Cobranza_Load(object sender, EventArgs e)
        {
            cmb_MedioDePago.Items.Clear();
            cmb_MedioDePago.Items.Add("Tarjeta de crédito");
            cmb_MedioDePago.Items.Add("Tarjeta de débito");
            cmb_MedioDePago.Items.Add("Pago fácil");

            cmb_SituacionFiscal.Items.Clear();
            cmb_SituacionFiscal.Items.Add("Consumidor final");
            cmb_SituacionFiscal.Items.Add("IVA excento");
            cmb_SituacionFiscal.Items.Add("Monotributista");
            cmb_SituacionFiscal.Items.Add("Responsable inscripto");
        }
    
        //cmb 
        private void cmb_MedioDePago_SelectedIndexChanged(object sender, EventArgs e)
        {
            Limpiar();
            MostrarTarjetas();

            switch (cmb_MedioDePago.SelectedIndex)
            {
                case 0:
                    MostrarTarjetaCredito();
                    break;
                case 1:
                    MostrarTarjetaDebito();
                    break;
                default:
                    MostrarPagoFacil();
                    break;
            }
        }
        private void cmb_SituacionFiscal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_SituacionFiscal.SelectedIndex == 0)
            {
                lbl_Numero.Text = "CUIL:";
            }
            else
            {
                lbl_Numero.Text = "CUIT:";
            }
        }


        //botones
        private void btn_Cancelar_Click(object sender, EventArgs e)
        {

        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            foreach(Pasajero pasajero in pasajeros)
            {

            }
        }

        //mis funciones
        private void MostrarTarjetas()
        {
            txt_CodSeguridadODepto.Visible = true;
            txt_DocumentoOCiudad.Visible = true;
            txt_Numero.Visible = true;
            txt_Titular.Visible = true;
            txt_VencimientoAñoOPiso.Visible = true;
            txt_VencimientoMesONumero.Visible = true;
            lbl_Barra.Visible = true;
            lbl_Piso.Visible = false;
            lbl_Provincias.Visible = false;
            lbl_SituacionFiscal.Visible = false;
            lbl_Calle.Visible = false;
            cmb_SituacionFiscal.Visible = false;
            cmb_Provincias.Visible = false;
            txt_Calle.Visible = false;
            lbl_CodSeguridadODepto.Text = "Cod. Seguridad:";
            lbl_DocumentoOCiudad.Text = "Documento:";
            lbl_VencimientoONumero.Text = "Vencimiento:";
            lbl_Numero.Text = "Numero de la tarjeta:";
            lbl_Titular.Text = "Titular de la tarjeta:";

        }

        private void MostrarPagoFacil()
        {
            lbl_CodSeguridadODepto.Text = "Depto:";
            lbl_DocumentoOCiudad.Text = "Ciudad:";
            lbl_VencimientoONumero.Text = "Número:";
            lbl_Numero.Text = "CUIL:";
            lbl_Titular.Text = "Nombre o razón social:";
            lbl_Barra.Visible = false;
            lbl_Piso.Visible = true;
            lbl_Provincias.Visible = true;
            lbl_SituacionFiscal.Visible = true;
            lbl_Calle.Visible = true;
            cmb_SituacionFiscal.Visible = true;
            cmb_Provincias.Visible = true;
            txt_Calle.Visible = true;
        }

        private void MostrarTarjetaCredito()
        {
            lbl_Cuotas.Visible = true;
            cmb_Cuotas.Visible = true;
            lbl_Barra.Visible = true;
        }

        private void MostrarTarjetaDebito()
        {
            lbl_Cuotas.Visible = false;
            cmb_Cuotas.Visible = false;
            lbl_Barra.Visible = false;
        }

        private void Limpiar()
        {
            cmb_SituacionFiscal.SelectedIndex = -1;
            cmb_Provincias.SelectedIndex = -1;
            cmb_Cuotas.SelectedIndex = -1;
            txt_Numero.Clear();
            txt_VencimientoAñoOPiso.Clear();
            txt_Titular.Clear();
            txt_CodSeguridadODepto.Clear();
            txt_VencimientoMesONumero.Clear();
            txt_DocumentoOCiudad.Clear();
        }

        //txt
        private void ProhibirNumeros(KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ProhibirLetras(KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_Numero_KeyPress(object sender, KeyPressEventArgs e)
        {
            ProhibirLetras(e);
        }

        private void txt_Titular_KeyPress(object sender, KeyPressEventArgs e)
        {
            ProhibirNumeros(e);
        }

        private void txt_DocumentoOCiudad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(lbl_DocumentoOCiudad.Text == "Documento")
            {
                ProhibirLetras(e);
            }
            else
            {
                ProhibirNumeros(e);
            }
        }

        private void txt_VencimientoMesONumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            ProhibirLetras(e);
        }

        private void txt_VencimientoAñoOPiso_KeyPress(object sender, KeyPressEventArgs e)
        {
            ProhibirLetras(e);
        }

        private void txt_CodSeguridadODepto_KeyPress(object sender, KeyPressEventArgs e)
        {
            ProhibirLetras(e); //limitar digitos hasta 3 excepto amex
        }
    }
}
