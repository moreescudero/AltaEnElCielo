﻿using Biblioteca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vista.Properties;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Vista
{
    public partial class frm_AltaPasajero : Form
    {
        int cantidadPasajeros;
        int index;
        string clase;
        string? codigoVuelo;
        Empleado usuario;
        float precio;
        float total = 0;
        float precioTotal;
        float impuestos;
        float impuestoPais;
        bool banderaSeCargoUno = false;
        bool banderaSeCargoDos = false;
        bool banderaSeCargoTres = false;
        bool banderaSeCargoCuatro = false;
        bool banderaAdultoResponsable = false;
        List<Pasajero> grupoFamiliar = new List<Pasajero>();
        Vuelo unVuelo;

        //constructores
        public frm_AltaPasajero()
        {
            InitializeComponent();
        }
        
        public frm_AltaPasajero(string? codigoVuelo, int cantidadPasajeros, string clase, Empleado usuario) : this()
        {
            this.codigoVuelo = codigoVuelo;
            this.cantidadPasajeros = cantidadPasajeros;
            this.clase = clase;
            this.usuario = usuario;
        }

        //Load

        private void frm_AltaPasajero_Load(object sender, EventArgs e)
        {
            ActualizarBackgroundImage();
            txt_Dni.MaxLength = 8;
            if (cantidadPasajeros >= 2)
            {
                pic_PasajeroDos.Visible = true;
            }

            Formulario.Font(this);

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
                    pasajero.Calcular(pasajero.PrecioBoleto);
                    Aerolinea.listaPasajeros.Add(pasajero);
                    unVuelo.ListaPasajeros.Add(pasajero);
                    unVuelo.SumarRecaudacion(pasajero.PrecioBoleto);
                }
                unVuelo.CambiarANoDisponible();

                frm_Cobranza formCobranza = new frm_Cobranza(precioTotal, grupoFamiliar);
                this.Hide();
                if(formCobranza.ShowDialog() == DialogResult.OK)
                {
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    this.Show();
                }
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
                if (!banderaAdultoResponsable && int.Parse(txt_Edad.Text) < 12)
                {
                    lbl_EstadoCargaPasajero.Text = "No podes cargar un menor \nde 12 años sin un adulto";
                }
                else
                {
                    CargarImpuestosYTasas();
                    Pasajero pasajero = new Pasajero(txt_Nombre.Text, txt_Apellido.Text, int.Parse(txt_Edad.Text), int.Parse(txt_Dni.Text), (float)nud_Equipaje.Value, clase, cmb_Menu.Text, precioTotal, chk_BolsoMano.Checked, usuario);
                    unVuelo.RestarAsientosYBodega(pasajero.Clase, pasajero.Equipaje);
                    if ((!banderaSeCargoUno && btn_CargarPasajero.Text == "Cargar Pasajero 1") || (!banderaSeCargoDos && btn_CargarPasajero.Text == "Cargar Pasajero 2") || (!banderaSeCargoTres && btn_CargarPasajero.Text == "Cargar Pasajero 3") || (!banderaSeCargoCuatro && btn_CargarPasajero.Text == "Cargar Pasajero 4"))
                    {
                        total += precioTotal;
                        grupoFamiliar.Add(pasajero);
                        lbl_Subtotal.Text = "Precio de 1 pasaje: $ " + precio.ToString();
                        lbl_Iva.Text = "Impuestos y tasas: $ " + impuestos.ToString() + "\nImpuesto PAIS: $" + impuestoPais.ToString();
                        //Bruto + Impuestos = Neto
                        lbl_Total.Text = "Total: $ " + total.ToString();
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
            }
            else
            {
                lbl_EstadoCargaPasajero.Text = "Complete todos los datos\n para cargar un pasajero";
            }
        }
        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        //mis funciones
        private bool VerificarDatosCompletos()
        {
            if ((nud_CantEquipaje.Value == 0 || (nud_CantEquipaje.Value > 0 && nud_Equipaje.Value > 0)) && txt_Nombre.Text != String.Empty && txt_Apellido.Text != String.Empty && txt_Edad.Text != String.Empty && (txt_Dni.Text.Length == 7 || txt_Dni.Text.Length == 8) && cmb_Menu.Text != String.Empty)
            {
                lbl_EstadoCargaPasajero.Text = String.Empty;
                if(int.Parse(txt_Edad.Text) > 18)
                {
                    banderaAdultoResponsable = true;
                }
                return true;
            }
            return false;
        }

        private void CargarImpuestosYTasas()
        {
            precio = Pasajero.CalcularPrecio(unVuelo.EsNacional, unVuelo.Duracion, clase);
            impuestos = precio * 0.9f;
            impuestoPais = precio * 0.3f;
            precioTotal = precio + impuestos + impuestoPais;
            if (int.Parse(txt_Edad.Text) <= 2)
            {
                precioTotal = 0;
                lbl_BonificacionPorEdad.Text = "Descuento por menor de 2 años aplicado:\nbonificación 100%";
            }
            else if (int.Parse(txt_Edad.Text) <= 12)
            {
                precioTotal *= 0.5f;
                lbl_BonificacionPorEdad.Text = "Descuento por menor de 12 años aplicado:\nbonificación 50%";
            }
        }
       
        private void MostrarParaModificar()
        {
            txt_Nombre.Text = grupoFamiliar[index].Nombre;
            txt_Apellido.Text = grupoFamiliar[index].Apellido;
            txt_Dni.Text = grupoFamiliar[index].GetHashCode().ToString();
            txt_Edad.Text = grupoFamiliar[index].Edad.ToString();
            nud_Equipaje.Value = (decimal)grupoFamiliar[index].Equipaje;
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
            lbl_BonificacionPorEdad.Text = String.Empty;
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
                chk_BolsoMano.ForeColor = Color.White;
                lbl_Apellido.ForeColor = Color.White;
                lbl_CantEquipaje.ForeColor = Color.White;
                lbl_ComoGuardar.ForeColor = Color.White;
                lbl_Dni.ForeColor = Color.White;
                lbl_Edad.ForeColor = Color.White;
                lbl_Equipaje.ForeColor = Color.White;
                lbl_EquipajeBodega.ForeColor = Color.White;
                lbl_Kilos.ForeColor = Color.White;
                lbl_Menu.ForeColor = Color.White;
                lbl_Nombre.ForeColor = Color.White;
            }
            else
            {
                chk_BolsoMano.ForeColor = Color.Black;
                lbl_Apellido.ForeColor = Color.Black;
                lbl_CantEquipaje.ForeColor = Color.Black;
                lbl_ComoGuardar.ForeColor = Color.Black;
                lbl_Dni.ForeColor = Color.Black;
                lbl_Edad.ForeColor = Color.Black;
                lbl_Equipaje.ForeColor = Color.Black;
                lbl_EquipajeBodega.ForeColor = Color.Black;
                lbl_Kilos.ForeColor = Color.Black;
                lbl_Menu.ForeColor = Color.Black;
                lbl_Nombre.ForeColor = Color.Black;

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

        //nud
        private void nud_Equipaje_ValueChanged(object sender, EventArgs e)
        {
            if (unVuelo.BodegaDisponible < (float)nud_Equipaje.Value)
            {
                lbl_EquipajeBodega.Visible = true;
                nud_Equipaje.Value = 0;
            }
            else
            {
                lbl_EquipajeBodega.Visible = false;
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
            ProhibirLetras(e);
        }

        private void txt_Edad_KeyPress(object sender, KeyPressEventArgs e)
        {
            ProhibirLetras(e);
        }

        private void txt_Dni_TextChanged(object sender, EventArgs e)
        {
            foreach (Pasajero pasajero in Aerolinea.listaPasajeros)
            {
                if (txt_Dni.Text == pasajero.Dni.ToString())
                {
                    txt_Nombre.Text = pasajero.Nombre;
                    txt_Apellido.Text = pasajero.Apellido;
                    txt_Edad.Text = pasajero.Edad.ToString();
                    break;
                } 
            }
        }
    }
}
