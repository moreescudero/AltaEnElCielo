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
        float pagoElegido;
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
            cmb_MedioDePago.Items.Add("Efectivo");

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
                    MostrarEfectivo();
                    break;
            }
        }

        private void cmb_Provincias_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_Calle.Clear();
            LimpiarDomicilio();
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

        private void cmb_Cuotas_SelectedIndexChanged(object sender, EventArgs e)
        {
            //pagoElegido = ver como fijarse que es lo que se selecciono por index
        }

        //botones
        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            foreach (Pasajero pasajero in pasajeros)
            {
                pasajero.MedioDePago = cmb_MedioDePago.Text;
            }
            this.DialogResult = DialogResult.OK;
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
            txt_CodSeguridadODepto.Enabled = false;
            lbl_CodSeguridadODepto.Text = "Cod. Seguridad:";
            lbl_DocumentoOCiudad.Text = "Documento:";
            lbl_VencimientoONumero.Text = "Vencimiento:";
            lbl_Numero.Text = "Numero de la tarjeta:";
            lbl_Titular.Text = "Titular de la tarjeta:";

        }

        private void MostrarEfectivo()
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

            CargarProvincias();
        }

        private void CargarProvincias()
        {
            cmb_Provincias.Items.Clear();
            cmb_Provincias.Items.Add("CABA");
            cmb_Provincias.Items.Add("Buenos Aires");
            cmb_Provincias.Items.Add("Salta");
            cmb_Provincias.Items.Add("Jujuy");
            cmb_Provincias.Items.Add("Formosa");
            cmb_Provincias.Items.Add("Chaco");
            cmb_Provincias.Items.Add("Misiones");
            cmb_Provincias.Items.Add("Corrientes");
            cmb_Provincias.Items.Add("Entre Rios");
            cmb_Provincias.Items.Add("Tucuman");
            cmb_Provincias.Items.Add("Catamarca");
            cmb_Provincias.Items.Add("La Rioja");
            cmb_Provincias.Items.Add("San Luis");
            cmb_Provincias.Items.Add("Córdoba");
            cmb_Provincias.Items.Add("Mendoza");
            cmb_Provincias.Items.Add("San Juan");
            cmb_Provincias.Items.Add("La Pampa");
            cmb_Provincias.Items.Add("Santa Fe");
            cmb_Provincias.Items.Add("Santiago del Estero");
            cmb_Provincias.Items.Add("Neuquen");
            cmb_Provincias.Items.Add("Rio Negro");
            cmb_Provincias.Items.Add("Santa Cruz");
            cmb_Provincias.Items.Add("Chubut");
            cmb_Provincias.Items.Add("Tierra del Fuego");
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

        private void LimpiarDomicilio()
        {
            txt_VencimientoAñoOPiso.Clear();
            txt_CodSeguridadODepto.Clear();
            txt_VencimientoMesONumero.Clear();
            txt_DocumentoOCiudad.Clear();
        }

        private void Limpiar()
        {
            cmb_SituacionFiscal.SelectedIndex = -1;
            cmb_Provincias.SelectedIndex = -1;
            cmb_Cuotas.SelectedIndex = -1;
            txt_Numero.Clear();
            txt_Titular.Clear();

            LimpiarDomicilio();
        }

        private void CargarCuotasSegunTarjeta(string tarjeta)
        {
            cmb_Cuotas.Items.Clear();
            cmb_Cuotas.Items.Add("1 cuota de $" + total);
            //pagoElegido = total;
            txt_CodSeguridadODepto.MaxLength = 3;

            if (tarjeta == "amex")
            {
                txt_CodSeguridadODepto.MaxLength = 4;
                cmb_Cuotas.Items.Add("3 cuotas de $" + (total * 1.1f) / 3 + " - interés 10%");
                cmb_Cuotas.Items.Add("6 cuotas de $" + total / 6);
                cmb_Cuotas.Items.Add("9 cuotas de $" + total / 9 );
            }
            else
            {
                if(tarjeta == "visa")
                {
                    cmb_Cuotas.Items.Add("3 cuotas de $" + (total * 1.2f) / 3 + " - interés 20%");
                    cmb_Cuotas.Items.Add("6 cuotas de $" + (total * 1.3f) / 6 + " - interés 30%");
                    cmb_Cuotas.Items.Add("9 cuotas de $" + total / 9);
                }
                else
                {
                    cmb_Cuotas.Items.Add("3 cuotas de $" + total / 3);
                    cmb_Cuotas.Items.Add("6 cuotas de $" + (total * 1.35f) / 6 + " - interés 35%");
                    cmb_Cuotas.Items.Add("9 cuotas de $" + (total * 1.4f) / 9 + " - interés 40%");
                }
            }

            cmb_Cuotas.Items.Add("12 cuotas de $" + total / 12);
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
            if (cmb_MedioDePago.SelectedIndex != 2 && txt_Numero.Text != String.Empty)
            {
                char[] auxiliarNumero = txt_Numero.Text.ToCharArray();
                if (auxiliarNumero[0] == '4')
                {
                    lbl_Acavaunaimagenowo.Text = "visa";
                }
                else if (auxiliarNumero[0] == '5')
                {
                    lbl_Acavaunaimagenowo.Text = "mastercard";
                }
                else if (auxiliarNumero[0] == '3')
                {
                    lbl_Acavaunaimagenowo.Text = "amex";
                }
            }
        }

        private void txt_Titular_KeyPress(object sender, KeyPressEventArgs e)
        {
            ProhibirNumeros(e);
        }

        private void txt_DocumentoOCiudad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(lbl_DocumentoOCiudad.Text == "Documento:")
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
        private void txt_VencimientoMesONumero_TextChanged(object sender, EventArgs e)
        {
            if (txt_VencimientoMesONumero.Text != String.Empty)
            {
                if (int.Parse(txt_VencimientoMesONumero.Text) >= 32 && lbl_VencimientoONumero.Text == "Vencimiento:")
                {
                    txt_VencimientoMesONumero.Clear();
                }
            }
        }

        private void txt_VencimientoAñoOPiso_KeyPress(object sender, KeyPressEventArgs e)
        {
            ProhibirLetras(e);
        }

        private void txt_VencimientoAñoOPiso_TextChanged(object sender, EventArgs e)
        {
            if (txt_VencimientoAñoOPiso.Text != String.Empty)
            {
                if (int.Parse(txt_VencimientoAñoOPiso.Text) < 2022 && lbl_Piso.Visible == false)
                {
                    txt_VencimientoAñoOPiso.Clear();
                }
            }
        }

        private void txt_CodSeguridadODepto_KeyPress(object sender, KeyPressEventArgs e)
        {
            ProhibirLetras(e);
        }

        //lbl que no va a perdurar, va a ser un imageList
        private void lbl_Acavaunaimagenowo_TextChanged(object sender, EventArgs e)
        {
            CargarCuotasSegunTarjeta(lbl_Acavaunaimagenowo.Text);
            txt_CodSeguridadODepto.Enabled = true;
        }
    }
}
