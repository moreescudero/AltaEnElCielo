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
using Vista.Properties;

namespace Vista
{
    public partial class frm_Cobranza : Form
    {
        float total;
        string? tarjeta;
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

            ActualizarBackgroundImage();
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

        //private void cmb_Cuotas_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    //pagoElegido = ver como fijarse que es lo que se selecciono por index

        //}

        //botones
        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            if (FormCompleto())
            {
                lbl_VerificarErrores.Text = "";
                foreach (Pasajero pasajero in pasajeros)
                {
                    pasajero.MedioDePago = cmb_MedioDePago.Text;
                }
                if (cmb_MedioDePago.Text == "Efectivo")
                {
                    Aerolinea.gananciaEfectivo += total;
                }
                else
                {
                    if (cmb_MedioDePago.Text == "Tarjeta de crédito")
                    {
                        Aerolinea.gananciaCredito += total;
                    }
                    else
                    {
                        Aerolinea.gananciaDebito += total;
                    }
                }
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                lbl_VerificarErrores.Text = "Hay datos incorrectos";
            }
        }

        //mis funciones

        private bool ValidarTarjetas()
        {
            if (txt_Numero.Text.Length == 16 && txt_VencimientoAñoOPiso.Text.Length == 4 && txt_VencimientoMesONumero.Text.Length >= 2 && (txt_DocumentoOCiudad.Text.Length == 8 || txt_DocumentoOCiudad.Text.Length == 7) && ((cmb_MedioDePago.Text == "Tarjeta de débito") || (cmb_MedioDePago.Text == "Tarjeta de crédito" && ((txt_CodSeguridadODepto.Text.Length == 4 && tarjeta == "amex") || txt_CodSeguridadODepto.Text.Length == 3) && cmb_Cuotas.SelectedIndex > -1)))
            {
                return true;
            }
            return false;
        }

        private bool ValidarEfectivo()
        {
            if (txt_Numero.Text.Length == 11 && txt_VencimientoAñoOPiso.Text != String.Empty && txt_VencimientoMesONumero.Text != String.Empty && txt_DocumentoOCiudad.Text != String.Empty && txt_Calle.Text != String.Empty && cmb_Provincias.SelectedIndex > -1 && cmb_SituacionFiscal.SelectedIndex > -1)
            {
                return true;
            }
            return false;
        }

        private bool FormCompleto()
        {
            if ((ValidarEfectivo()  || ValidarTarjetas()) && txt_Titular.Text != String.Empty)
            {
                return true;
            }
            return false;
        }

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
            txt_VencimientoMesONumero.MaxLength = 2;
            txt_VencimientoAñoOPiso.MaxLength = 4;

            txt_VencimientoMesONumero.PlaceholderText = "mm";
            txt_VencimientoAñoOPiso.PlaceholderText = "aaaa";
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
            txt_CodSeguridadODepto.Enabled = true;
            txt_VencimientoMesONumero.MaxLength = 6;
            txt_VencimientoAñoOPiso.MaxLength = 3;
            pic_LogoTarjeta.Visible = false;

            txt_VencimientoMesONumero.PlaceholderText = "";
            txt_VencimientoAñoOPiso.PlaceholderText = "";

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
            txt_Calle.Clear();
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

        private void CargarCuotasSegunTarjeta()
        {
            cmb_Cuotas.Items.Clear();
            cmb_Cuotas.Items.Add("1 cuota de $" + total);
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
            }
            else
            {
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
            
            if (txt_Numero.Text != String.Empty)
            {
                Size tamaño = new Size(118, 65);
                pic_LogoTarjeta.Visible = true;
                if (cmb_MedioDePago.SelectedIndex != 2)
                {
                    txt_Numero.MaxLength = 16;
                    char[] auxiliarNumero = txt_Numero.Text.ToCharArray();
                    if (auxiliarNumero[0] == '4')
                    {
                        tarjeta = "visa";
                        tamaño.Width = 76;
                        tamaño.Height = 31;
                        pic_LogoTarjeta.Image = Resources.visa_logo;
                    }
                    else if (auxiliarNumero[0] == '5')
                    {
                        tarjeta = "mastercard";
                        tamaño.Width = 92;
                        tamaño.Height = 61;
                        pic_LogoTarjeta.Image = Resources.mastercard_logo;
                    }
                    else if (auxiliarNumero[0] == '3')
                    {
                        tarjeta = "amex";
                        pic_LogoTarjeta.Image = Resources.amex_logo;
                    }
                    pic_LogoTarjeta.Size = tamaño;
                }
                else
                {
                    txt_Numero.MaxLength = 11;
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
                txt_DocumentoOCiudad.MaxLength = 8;
            }
            else
            {
                ProhibirNumeros(e);
                txt_DocumentoOCiudad.MaxLength = 30;
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
                if (lbl_VencimientoONumero.Text == "Vencimiento:" && int.Parse(txt_VencimientoMesONumero.Text) >= 13)
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
            if (txt_VencimientoAñoOPiso.Text.Length == 4)
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

        private void txt_Numero_TextChanged(object sender, EventArgs e)
        {
            CargarCuotasSegunTarjeta();
            txt_CodSeguridadODepto.Enabled = true;
            if(txt_Numero.Text == String.Empty)
            {
                pic_LogoTarjeta.Visible = false;
            }
        }


    }
}
