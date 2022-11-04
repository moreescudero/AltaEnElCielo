using Entidades;
using Entidades.Presentador;
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
    public partial class Frm_MenuPrincipal : Form, IMenuPrincipal
    {
        PresentadorMenuPrincipal presentador;
        //bool jugadorUnoElegido = false;
        //bool jugadorDosElegido = false;


        public Frm_MenuPrincipal()
        {
            InitializeComponent();
            presentador = new PresentadorMenuPrincipal(this);
        }

        public string? Bienvenido { get { return lbl_BienvenidoJugador.Text; } set { lbl_BienvenidoJugador.Text = value; } }    
        public string? UsuariosCargados { get { return lbl_UsuariosCargados.Text; } set { lbl_UsuariosCargados.Text = value; } }
        public bool HabilitarBotonAbrirSala { get { return btn_AbirSala.Enabled; } set { btn_AbirSala.Enabled = value; } }
        public bool HabilitarPanel { set { pnl_ErrorPartidas.Enabled = value; } }
        public string? ErrorPanel { set { lbl_ErrorPartidasBaseDeDatos.Text = value; } }

        private void Frm_MenuPrincipal_Load(object sender, EventArgs e)
        {
            //jugadorUnoElegido = false;
            //jugadorDosElegido = false;
            presentador.MostrarJugadorActivo();
            presentador.CargarDataGrid();
        }

        private void btn_AbirSala_Click(object sender, EventArgs e)
        {
            Frm_Sala frm_Sala = new Frm_Sala();
            frm_Sala.ShowDialog();
        }

        private void dgv_JugadoresDisponibles_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //try
            //{
            //    presentador.CargarUsuarios(e.RowIndex);
            //}
            //catch (Exception ex)
            //{
            //    lbl_UsuariosCargados.Text = ex.Message;
            //}
            ////if (!jugadorUnoElegido)
            ////{
            ////    index = e.RowIndex;
            ////    jugadorUnoElegido = true;
            ////}
            ////else if (!jugadorDosElegido)
            ////{

            ////    jugadorDosElegido = true;
            ////}
        }

        public void CargarDgv(Object fuente)
        {
            dgv_JugadoresDisponibles.DataSource = null;
            dgv_JugadoresDisponibles.DataSource = fuente;
        }

        private void btn_Volver_Click(object sender, EventArgs e)
        {
            pnl_ErrorPartidas.Enabled = false;
        }

        private void Frm_MenuPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
