using Biblioteca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vista.Properties;

namespace Vista
{
    public partial class frm_VenderVuelos : Form
    {
        List<Vuelo> filtro = new List<Vuelo>();
        Empleado usuario;
        bool banderaCalendario = false;
        int index;

        public frm_VenderVuelos()
        {
            InitializeComponent();
        }
        public frm_VenderVuelos(Empleado usuario) : this ()
        {
            this.usuario = usuario;
        }

        private void frm_VenderVuelos_Load(object sender, EventArgs e)
        {
            ActualizarBackgroundImage();
            cdr_Salida.MinDate = DateTime.Now;
            foreach(string destino in Enum.GetNames(typeof(EDestinos)))
            {
                cmb_Origen.Items.Add(destino);
            }
            cmb_Clase.Items.Add("Turista"); 
            cmb_Clase.Items.Add("Premium");

            Formulario.Font(this);

        }

        private void cdr_Salida_DateSelected(object sender, DateRangeEventArgs e)
        {
            banderaCalendario = true;
            DateTime ida = cdr_Salida.SelectionStart; // esto para orgenizar el ida y vuelta
            DateTime vuelta = cdr_Salida.SelectionEnd;
            FormCompleto();
        }

        private void cmb_Origen_SelectedIndexChanged(object sender, EventArgs e)
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
          
        private void nud_CantidadPasajeros_ValueChanged(object sender, EventArgs e)
        {
            FormCompleto();
        }

        private void FormCompleto()
        {
            if(nud_CantidadPasajeros.Value > 0 && banderaCalendario && cmb_Origen.Text != String.Empty && cmb_Destino.Text != String.Empty && cmb_Clase.Text != String.Empty)
            {
                btn_Continuar.Enabled = true;
            }
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            frm_AltaPasajero altaPasajero = new frm_AltaPasajero(filtro[index].CodigoVuelo, int.Parse(nud_CantidadPasajeros.Value.ToString()), cmb_Clase.Text, usuario);
            this.Hide();
            if(altaPasajero.ShowDialog() == DialogResult.OK)
            {
                this.DialogResult = DialogResult.OK; 
            }
            else
            {
                this.Show();
                lbl_DenegarAgregarVuelo.Text = "No se agregó el vuelo";
            }
        }

        private void cmb_Destino_SelectedIndexChanged(object sender, EventArgs e)
        {
            FormCompleto();
        }

        private void ActualizarDataGrid()
        {
            filtro = Aerolinea.FiltrarVuelos((EDestinos)Enum.Parse(typeof(EDestinos), cmb_Origen.Text), (EDestinos)Enum.Parse(typeof(EDestinos), cmb_Destino.Text), int.Parse(nud_CantidadPasajeros.Value.ToString()), cmb_Clase.Text);
            dgv_HayVuelo.DataSource = null;
            dgv_HayVuelo.DataSource = filtro;
        }

        private void btn_AgregarVuelo_Click(object sender, EventArgs e)
        {
            frm_AgregarVuelo agregarVuelo = new frm_AgregarVuelo((EDestinos)Enum.Parse(typeof(EDestinos), cmb_Origen.Text), (EDestinos)Enum.Parse(typeof(EDestinos), cmb_Destino.Text), cdr_Salida.SelectionStart);
            this.Hide();
            if (agregarVuelo.ShowDialog() == DialogResult.OK)
            {
                ActualizarDataGrid();
                lbl_NoHayVuelos.Visible = false;
            }
            this.Show();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void dgv_HayVuelo_VisibleChanged(object sender, EventArgs e)
        {
            ActualizarDataGrid();
            if (filtro.Count == 0)
            {
                lbl_NoHayVuelos.Text = "No hay vuelos que coincidan con el origen y el destino deseado";
            }
            
            btn_Continuar.Enabled = false;

            if (cdr_Salida.SelectionStart.CompareTo(DateTime.Now.AddDays(7)) < 0)
            {
                lbl_DenegarAgregarVuelo.Text = "No podes crear un vuelo\ncon una antelación menor a 1 semana";
                btn_AgregarVuelo.Enabled = false;
            }
            else
            {
                btn_AgregarVuelo.Visible = true;
            }
        }

        private void dgv_HayVuelo_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            index = e.RowIndex;
            if(index >= 0)
            {
                btn_Aceptar.Enabled = true;
            }
        }

        private void btn_Continuar_Click(object sender, EventArgs e)
        {
            nud_CantidadPasajeros.Visible = false;
            cmb_Origen.Visible = false;
            cmb_Destino.Visible = false;
            cmb_Clase.Visible = false;
            cdr_Salida.Visible = false;
            lbl_Origen.Visible = false;
            lbl_Destino.Visible = false;
            lbl_CantPasajeros.Visible = false;
            lbl_Clase.Visible = false;
            lbl_Fechas.Visible = false;

            dgv_HayVuelo.Visible = true;
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
                lbl_CantPasajeros.ForeColor = Color.White;
                lbl_Clase.ForeColor = Color.White;
                lbl_DenegarAgregarVuelo.ForeColor = Color.White;
                lbl_Destino.ForeColor = Color.White;
                lbl_Fechas.ForeColor = Color.White;
                lbl_NoHayVuelos.ForeColor = Color.White;
                lbl_Origen.ForeColor = Color.White;
                lbl_Titulo.ForeColor = Color.White;
            }
            else
            {
                lbl_CantPasajeros.ForeColor = Color.Black;
                lbl_Clase.ForeColor = Color.Black;
                lbl_DenegarAgregarVuelo.ForeColor = Color.Black;
                lbl_Destino.ForeColor = Color.Black;
                lbl_Fechas.ForeColor = Color.Black;
                lbl_NoHayVuelos.ForeColor = Color.Black;
                lbl_Origen.ForeColor = Color.Black;
                lbl_Titulo.ForeColor = Color.Black;

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
    }
}
