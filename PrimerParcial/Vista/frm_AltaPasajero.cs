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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Vista
{
    public partial class frm_AltaPasajero : Form
    {
        int cantidadPasajeros;
        int index;
        string clase;
        string? codigoVuelo;
        float precio;
        float total = 0;
        bool banderaSeCargoUno = false;
        bool banderaSeCargoDos = false;
        bool banderaSeCargoTres = false;
        bool banderaSeCargoCuatro = false;
        List<Pasajero> grupoFamiliar = new List<Pasajero>();
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
            }
            else
            {
                nud_Equipaje.Maximum = 25;
            }
            //eleccion de extras todavia trabajando en eso 
            lbl_Clase.Text += "\n" + clase;
            foreach (Vuelo vuelo in Aerolinea.listaVuelos)
            {
                if (codigoVuelo == vuelo.CodigoVuelo)
                {
                    unVuelo = vuelo;
                    if (!unVuelo.HayComida)
                    {
                        cmb_Menu.Items.Add("Sin Menu");
                        cmb_Menu.SelectedIndex = 0;
                        cmb_Menu.Enabled = false;
                        
                    }
                    else
                    {
                        cmb_Menu.Items.Add("Comun");
                        cmb_Menu.Items.Add("Celiaco");
                        cmb_Menu.Items.Add("Vegetariano");
                        cmb_Menu.Items.Add("Vegano");
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
                if (clase == "Premium")
                {
                    if(nud_CantEquipaje.Value == 1)
                    {
                        nud_Equipaje.Maximum = 21;
                    }
                    else
                    {
                        nud_Equipaje.Maximum = 42;
                    }
                }
            }
            else
            {
                nud_Equipaje.Enabled = false;
            }
        }

        //Click imagenes
        private void pic_PasajeroUno_Click(object sender, EventArgs e)
        {
            if(banderaSeCargoUno)
            {
                btn_CargarPasajero.Text = "Modificar Pasajero 1";
                index = 0;
                MostrarParaModificar();
            }
            VisualizarPasajeroElegido(1);
        }
        private void pic_PasajeroDos_Click(object sender, EventArgs e)
        {
            if (!banderaSeCargoDos)
            {
                btn_CargarPasajero.Text = "Cargar Pasajero 2";
                Limpiar();
            }
            else
            {
                btn_CargarPasajero.Text = "Modificar Pasajero 2";
                index = 1;
                MostrarParaModificar();
            }
            VisualizarPasajeroElegido(2);
        }
        private void pic_PasajeroTres_Click(object sender, EventArgs e)
        {
            if (!banderaSeCargoTres)
            {
                btn_CargarPasajero.Text = "Cargar Pasajero 3";
                Limpiar();
            }
            else
            {
                btn_CargarPasajero.Text = "Modificar Pasajero 3";
                index = 2;
                MostrarParaModificar();
            }
            VisualizarPasajeroElegido(3);
        }
        private void pic_PasajeroCuatro_Click(object sender, EventArgs e)
        {
            if (!banderaSeCargoCuatro)
            {
                btn_CargarPasajero.Text = "Cargar Pasajero 4";
                Limpiar();
            }
            else
            {
                btn_CargarPasajero.Text = "Modificar Pasajero 4";
                index = 3;
                MostrarParaModificar();
            }
            VisualizarPasajeroElegido(4);
        }


        //Click botones
        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            if(grupoFamiliar.Count == cantidadPasajeros)
            {
                foreach (Pasajero pasajero in grupoFamiliar)
                {
                    unVuelo.ListaPasajeros.Add(pasajero);
                    unVuelo.AsientosDisponibles--;
                    unVuelo.SumarRecaudacion(pasajero.PrecioBoleto);
                }
                unVuelo.CambiarANoDisponible();
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                lbl_ErrorAlAceptar.Text = "No lleno los datos de todos los pasajeros";
            }
        }
        private void btn_CargarPasajero_Click(object sender, EventArgs e)
        {
            if (VerificarDatosCompletos())
            {
                precio = Pasajero.CalcularPrecio(unVuelo.EsNacional, unVuelo.Duracion, clase);
                float impuestos = precio * 0.90f;
                float impuestoPais = precio * 0.3f;
                float precioTotal = precio + impuestos + impuestoPais;
                Pasajero pasajero = new Pasajero(txt_Nombre.Text, txt_Apellido.Text, int.Parse(txt_Edad.Text), int.Parse(txt_Dni.Text), float.Parse(nud_Equipaje.Value.ToString()), clase, cmb_Menu.Text, precioTotal, chk_BolsoMano.Checked);
                if ((!banderaSeCargoUno && btn_CargarPasajero.Text == "Cargar Pasajero 1") || (!banderaSeCargoDos && btn_CargarPasajero.Text == "Cargar Pasajero 2") || (!banderaSeCargoTres && btn_CargarPasajero.Text == "Cargar Pasajero 3") || (!banderaSeCargoCuatro && btn_CargarPasajero.Text == "Cargar Pasajero 4"))
                {
                    total += precioTotal;
                    grupoFamiliar.Add(pasajero);
                    lbl_Subtotal.Text = "Precio de 1 pasaje: $ " + precio;
                    lbl_Iva.Text = "Impuestos y tasas: $ " + impuestos + "\nImpuesto PAIS: $" + impuestoPais;
                    //Bruto + Impuestos = Neto
                    lbl_Total.Text = "Total: $ " + total;
                    lbl_EstadoCargaPasajero.Text = "Se cargo un pasajero con exito";
                    LevantarBanderas();
                    ActivarImagenes();
                }
                else
                {
                    grupoFamiliar.Insert(index, pasajero);
                    grupoFamiliar.RemoveAt(index + 1);
                    lbl_EstadoCargaPasajero.Text = "Se modifico un pasajero con exito";
                }
            }
            else
            {
                lbl_EstadoCargaPasajero.ForeColor = Color.Red;
                lbl_EstadoCargaPasajero.Text = "Complete todos los datos para cargar un pasajero";
            }
        }

        //mis funciones
        private bool VerificarDatosCompletos()
        {
            if ((nud_CantEquipaje.Value == 0 || (nud_CantEquipaje.Value > 0 && nud_Equipaje.Value > 0)) && txt_Nombre.Text != String.Empty && txt_Apellido.Text != String.Empty && txt_Edad.Text != String.Empty && txt_Dni.Text != String.Empty && cmb_Menu.Text != String.Empty)
            {
                lbl_EstadoCargaPasajero.Text = String.Empty;
                return true;
            }
            return false;
        }

       
        private void MostrarParaModificar()
        {
            txt_Nombre.Text = grupoFamiliar[index].Nombre;
            txt_Apellido.Text = grupoFamiliar[index].Apellido;
            txt_Dni.Text = grupoFamiliar[index].Dni.ToString();
            txt_Edad.Text = grupoFamiliar[index].Edad.ToString();
            nud_Equipaje.Value = decimal.Parse(grupoFamiliar[index].Equipaje.ToString());
            chk_BolsoMano.Checked = grupoFamiliar[index].BolsoMano;
            if (grupoFamiliar[index].MenuElegido != "Sin Menu")
            {
                if (grupoFamiliar[index].MenuElegido == "Comun")
                {
                    cmb_Menu.SelectedIndex = 0;
                }
                else
                {
                    if (grupoFamiliar[index].MenuElegido == "Celiaco")
                    {
                        cmb_Menu.SelectedIndex = 1;
                    }
                    else
                    {
                        if (grupoFamiliar[index].MenuElegido == "Vegetariano")
                        {
                            cmb_Menu.SelectedIndex = 2;
                        }
                        else
                        {
                            cmb_Menu.SelectedIndex = 3;
                        }
                    }
                }
            }
        }

        private void VisualizarPasajeroElegido(int elegido)
        {
            pic_ElegirUno.Visible = false;
            pic_ElegirDos.Visible = false;
            pic_ElegirTres.Visible = false;
            pic_ElegirCuatro.Visible = false;

            switch(elegido)
            {
                case 1:
                    pic_ElegirUno.Visible = true;
                    break;
                case 2:
                    pic_ElegirDos.Visible = true;
                    break;
                case 3:
                    pic_ElegirTres.Visible = true;
                    break;
                default:
                    pic_ElegirCuatro.Visible = true;
                    break;
            }

        }

        private void ActivarImagenes()
        {
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

        private void LevantarBanderas()
        {
            if (btn_CargarPasajero.Text == "Cargar Pasajero 1")
            {
                banderaSeCargoUno = true;
            }
            else
            {
                if (btn_CargarPasajero.Text == "Cargar Pasajero 2")
                {
                    banderaSeCargoDos = true;
                }
                else
                {
                    if (btn_CargarPasajero.Text == "Cargar Pasajero 3")
                    {
                        banderaSeCargoTres = true;
                    }
                    else
                    {
                        banderaSeCargoCuatro = true;
                    }
                }
            }
        }

        private void Limpiar()
        {
            txt_Nombre.Text = String.Empty;
            txt_Apellido.Text = String.Empty;
            txt_Edad.Text = String.Empty;
            txt_Dni.Text = String.Empty;
            chk_BolsoMano.Checked = false;
            nud_CantEquipaje.Value = 0;
            nud_Equipaje.Value = 0;
            if(cmb_Menu.Text != "Sin Menu")
            {
                cmb_Menu.SelectedIndex = -1;
            }
            lbl_EstadoCargaPasajero.Text = String.Empty;
        }

        //visible changed

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
            //buscar si el dni esta en la base de datos y completar el form en caso de que si
            ProhibirLetras(e);
        }

        private void txt_Edad_KeyPress(object sender, KeyPressEventArgs e)
        {
            ProhibirLetras(e);
        }

    }
}
