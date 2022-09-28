using Biblioteca;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class frm_Menu : Form
    {
        public frm_Menu()
        {
            InitializeComponent();
        }
        public frm_Menu(Empleado usuario): this()
        {
            lbl_Bienvenido.Text = "Usuario: " + usuario.ToString();
        }

        private void frm_Menu_Load(object sender, EventArgs e)
        {
            tmr_Fondo.Start();
            Aerolinea.InicializarAerolinea();
            Aerolinea.QuitarVuelosFinalizados();
            SetHora();
            SetBackgroundImage();
        }
        private void btn_CerrarSesion_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SetHora()
        {
            lbl_HoraActual.Text = DateTime.Now.ToShortDateString();
        }

        private void SetBackgroundImage()
        {
            DateTime tiempo = DateTime.Now;
            //DateTime tiempo = DateTime.Parse("23:00:00");
            DateTime amanecer = DateTime.Parse("06:55:00");
            DateTime tarde = DateTime.Parse("16:30:00");
            DateTime noche = DateTime.Parse("18:30:00");
            if (tiempo.CompareTo(noche) > 0 || tiempo.CompareTo(amanecer) < 0)
            {
                this.BackgroundImage = Image.FromFile(@"C:\Users\more\Pictures\Cielo noche.jpg");
            }
            else
            {
                if (tiempo.CompareTo(tarde) > 0)
                {
                    this.BackgroundImage = Image.FromFile(@"C:\Users\more\Pictures\Cielo tarde.jpg");
                }
                else
                {
                    this.BackgroundImage = Image.FromFile(@"C:\Users\more\Pictures\Cielo dia.jpg");
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            SetHora();
            SetBackgroundImage();
        }

        private void pic_Vender_Click(object sender, EventArgs e)
        {
            frm_VenderVuelos formVender = new frm_VenderVuelos();
            formVender.ShowDialog();
            formVender.Close();
        }

        private void pic_VisualizarVuelos_Click(object sender, EventArgs e)
        {
            frm_VisualizarVuelos formVisualizar = new frm_VisualizarVuelos(Aerolinea.listaVuelos);
            formVisualizar.ShowDialog();
            formVisualizar.Close();
        }

        private void pic_Estadisticas_Click(object sender, EventArgs e)
        {
            frm_EstadisticasHistoricas formEstadisticas = new frm_EstadisticasHistoricas();
            formEstadisticas.ShowDialog();
            formEstadisticas.Close();
        }

    }
}
