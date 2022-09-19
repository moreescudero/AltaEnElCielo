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
    public partial class frm_AltaPasajero : Form
    {
        int cantidadPasajeros;
        int duracion;
        string clase;
        string? codigoVuelo;
        float precio = 0;
        bool banderaSeCargoUno = false;
        bool banderaSeCargoDos = false;
        bool banderaSeCargoTres = false;
        bool banderaSeCargoCuatro = false;
        List<Pasajero> grupoFamiliar;
        Vuelo unVuelo;

        //constructores
        public frm_AltaPasajero()
        {
            InitializeComponent();
        }
        
        public frm_AltaPasajero(string? codigoVuelo, int cantidadPasajeros, string clase) : this()
        {
            this.codigoVuelo = codigoVuelo;
            this.cantidadPasajeros = cantidadPasajeros;
            this.clase = clase;
        }

        //Load

        private void frm_AltaPasajero_Load(object sender, EventArgs e)
        {

            if (cantidadPasajeros >= 2)
            {
                pic_PasajeroDos.Visible = true;
            }

            lbl_ComoGuardar.Text = "Presiona el icono del pasajero que deseas ver o cargar sus datos";

            if (clase == "Premium")
            {
                nud_CantEquipaje.Maximum = 2;
                nud_Equipaje.Maximum = 42;
            }
            else
            {
                nud_Equipaje.Maximum = 25;
            }

            lbl_Clase.Text += "\n" + clase;
            for (int i = 0; i > Aerolinea.listaVuelos.Count; i++)
            { //fijarse si despues necesito todo el vuelo o no mas alla del pasajero (por ahora no)
                if (codigoVuelo == Aerolinea.listaVuelos[i].CodigoVuelo)
                {
                    unVuelo = Aerolinea.listaVuelos[i];
                    duracion = unVuelo.Duracion;
                    if (!unVuelo.HayComida)
                    {
                        lbl_SinMenu.Visible = true;
                    }
                    break;
                }
            }

        }
        //equipaje
        private void nud_CantEquipaje_ValueChanged(object sender, EventArgs e)
        {
            if (nud_CantEquipaje.Value > 0)
            {
                nud_Equipaje.Enabled = true;
            }
            else
            {
                nud_Equipaje.Enabled = false;
            }
        }

        //Click imagenes
        private void pic_PasajeroUno_Click(object sender, EventArgs e)
        {
            if(!banderaSeCargoUno)
            {
                btn_CargarPasajero.Text = "Cargar Pasajero 1";
            }
            else
            {
                btn_CargarPasajero.Text = "Modificar Pasajero 1";
            }
            pic_ElegirUno.Visible = true;
            pic_ElegirDos.Visible = false;
            pic_ElegirTres.Visible = false;
            pic_ElegirCuatro.Visible = false;
        }
        private void pic_PasajeroDos_Click(object sender, EventArgs e)
        {
            if (!banderaSeCargoDos)
            {
                btn_CargarPasajero.Text = "Cargar Pasajero 2";
            }
            else
            {
                btn_CargarPasajero.Text = "Modificar Pasajero 2";
            }
            pic_ElegirUno.Visible = false;
            pic_ElegirDos.Visible = true;
            pic_ElegirTres.Visible = false;
            pic_ElegirCuatro.Visible = false;
            Limpiar();
        }
        private void pic_PasajeroTres_Click(object sender, EventArgs e)
        {
            if (!banderaSeCargoTres)
            {
                btn_CargarPasajero.Text = "Cargar Pasajero 3";
            }
            else
            {
                btn_CargarPasajero.Text = "Modificar Pasajero 3";
            }
            pic_ElegirUno.Visible = false;
            pic_ElegirDos.Visible = false;
            pic_ElegirTres.Visible = true;
            pic_ElegirCuatro.Visible = false;
            Limpiar();
        }
        private void pic_PasajeroCuatro_Click(object sender, EventArgs e)
        {
            if (!banderaSeCargoCuatro)
            {
                btn_CargarPasajero.Text = "Cargar Pasajero 4";
            }
            else
            {
                btn_CargarPasajero.Text = "Modificar Pasajero 4";
            }
            pic_ElegirUno.Visible = false;
            pic_ElegirDos.Visible = false;
            pic_ElegirTres.Visible = false;
            pic_ElegirCuatro.Visible = true;
            Limpiar();
        }


        //Click botones
        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            if(grupoFamiliar.Count == cantidadPasajeros)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                lbl_ErrorAlAceptar.Text = "No lleno los datos de todos los pasajeros";
            }
        }
        private void btn_CargarPasajero_Click(object sender, EventArgs e)
        {
            if (DatosCompletos())
            {
                precio += Pasajero.CalcularPrecio((int)unVuelo.Destino, unVuelo.Duracion, clase);
                grupoFamiliar.Add(new Pasajero(txt_Nombre.Text, txt_Apellido.Text, int.Parse(txt_Edad.Text), int.Parse(txt_Dni.Text), float.Parse(nud_Equipaje.Value.ToString()), clase, precio));
                lbl_EstadoCargaPasajero.Text = "Se cargo un pasajero con exito";
                lbl_Subtotal.Text += " $ " + precio;
                lbl_Total.Text += " $ " + precio;
                if(btn_CargarPasajero.Text == "Cargar Pasajero 1")
                {
                    banderaSeCargoUno = true;
                }
                else
                {
                    if(btn_CargarPasajero.Text == "Cargar Pasajero 2")
                    {
                        banderaSeCargoDos = true;
                    }
                    else
                    {
                        if(btn_CargarPasajero.Text == "Cargar Pasajero 3")
                        {
                            banderaSeCargoTres = true;
                        }
                        else
                        {
                            banderaSeCargoCuatro = true;
                        }
                    }
                }
                if (cantidadPasajeros >= 2 && btn_CargarPasajero.Text == "Cargar Pasajero 1")
                {
                    pic_PasajeroDos.Enabled = true;
                }
                else
                {
                    if (cantidadPasajeros >= 3 && btn_CargarPasajero.Text == "Cargar Pasajero 2")
                    {
                        pic_PasajeroTres.Enabled = true;
                    }
                    else
                    {
                        if (cantidadPasajeros == 4 && btn_CargarPasajero.Text == "Cargar Pasajero 3")
                        {
                            pic_PasajeroCuatro.Enabled = true;
                        }
                    }
                }
            }
            else
            {
                lbl_EstadoCargaPasajero.ForeColor = Color.Red;
                lbl_EstadoCargaPasajero.Text = "Complete todos los datos para cargar un pasajero";
            }
        }

        //mis funciones
        private bool DatosCompletos()
        {
            if ((nud_CantEquipaje.Value == 0 || (nud_CantEquipaje.Value > 0 && nud_Equipaje.Value > 0)) && txt_Nombre.Text != String.Empty && txt_Apellido.Text != String.Empty && txt_Edad.Text != String.Empty && txt_Dni.Text != String.Empty && (!unVuelo.HayComida || (unVuelo.HayComida && (chk_MenuComun.Checked || chk_MenuVegano.Checked || chk_MenuCeliaco.Checked || chk_MenuVegetariano.Checked))))
            {
                return true;
            }
            return false;
        }

        private void Limpiar()
        {
            txt_Nombre.Text = String.Empty;
            txt_Apellido.Text = String.Empty;
            txt_Edad.Text = String.Empty;
            txt_Dni.Text = String.Empty;
            nud_CantEquipaje.Value = 0;
            nud_Equipaje.Value = 0;
            chk_MenuCeliaco.Checked = false;
            chk_MenuComun.Checked = false;
            chk_MenuVegano.Checked = false;
            chk_MenuVegetariano.Checked = false;
        }

        //visible changed
        private void lbl_SinMenu_VisibleChanged(object sender, EventArgs e)
        {
            chk_MenuCeliaco.Enabled = false;
            chk_MenuComun.Enabled = false;
            chk_MenuVegano.Enabled = false;
            chk_MenuVegetariano.Enabled = false;
        }

        private void pic_PasajeroDos_VisibleChanged(object sender, EventArgs e)
        {
            if(cantidadPasajeros >= 3)
            {
                pic_PasajeroTres.Visible = true;
            }
        }

        private void pic_PasasjeroTres_VisibleChanged(object sender, EventArgs e)
        {
            if(cantidadPasajeros == 4)
            {
                pic_PasajeroCuatro.Visible = true;
            }
        }

        //textbox 
        private void ProhibirNumeros(KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ProhibirLetras(KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar == (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txt_Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            ProhibirNumeros(e);
        }

        private void txt_Apellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            ProhibirNumeros(e);
        }

        private void txt_Dni_KeyPress(object sender, KeyPressEventArgs e)
        {
            ProhibirLetras(e);
        }

        private void txt_Edad_KeyPress(object sender, KeyPressEventArgs e)
        {
            ProhibirLetras(e);
        }


    }
}
