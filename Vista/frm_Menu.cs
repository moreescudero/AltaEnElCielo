using Biblioteca;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class frm_Menu : Form
    {
        Empleado usuario;
        public frm_Menu()
        {
            InitializeComponent();
        }
        public frm_Menu(Empleado usuario): this()
        {
            this.usuario = usuario;
        }

        private void frm_Menu_Load(object sender, EventArgs e)
        {
            lbl_Bienvenido.Text = "Usuario: " + usuario.Usuario;
            tmr_Fondo.Start();
            SetHora();
            ActualizarBackgroundImage();

            Formulario.Font(this);

        }
        private void btn_CerrarSesion_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void SetHora()
        {
            lbl_HoraActual.Text = DateTime.Now.ToShortDateString();
        }

        private void ActualizarBackgroundImage()
        {
            DateTime tiempo = DateTime.Now;
            //DateTime tiempo = DateTime.Parse("17:00:00");
            DateTime amanecer = DateTime.Parse("06:25:00");
            DateTime tarde = DateTime.Parse("16:50:00");
            DateTime noche = DateTime.Parse("18:57:00");
            if (tiempo.CompareTo(noche) > 0 || tiempo.CompareTo(amanecer) < 0)
            {
                this.BackgroundImage = Resources.cielo_noche;
                lbl_Estadisticas.ForeColor = Color.White;
                lbl_VenderVuelos.ForeColor = Color.White;
                lbl_VisualizarVuelos.ForeColor = Color.White;
            }
            else
            {
                lbl_Estadisticas.ForeColor = Color.Black;
                lbl_VenderVuelos.ForeColor = Color.Black;
                lbl_VisualizarVuelos.ForeColor = Color.Black;
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            SetHora();
            ActualizarBackgroundImage();
        }

        private void pic_Vender_Click(object sender, EventArgs e)
        {
            frm_VenderVuelos formVender = new frm_VenderVuelos(usuario);
            this.Hide();
            formVender.ShowDialog();
            this.Show();
        }

        private void pic_VisualizarVuelos_Click(object sender, EventArgs e)
        {
            frm_VisualizarVuelos formVisualizar = new frm_VisualizarVuelos(Aerolinea.listaVuelos);
            this.Hide();
            formVisualizar.ShowDialog();
            this.Show();
        }

        private void pic_Estadisticas_Click(object sender, EventArgs e)
        {
            frm_EstadisticasHistoricas formEstadisticas = new frm_EstadisticasHistoricas();
            this.Hide();
            formEstadisticas.ShowDialog();
            this.Show();
        }

    }
}
