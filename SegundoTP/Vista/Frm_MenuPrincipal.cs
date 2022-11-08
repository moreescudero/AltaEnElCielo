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
        List<Task> listaTareas;

        public Frm_MenuPrincipal()
        {
            InitializeComponent();
            presentador = new PresentadorMenuPrincipal(this);
            listaTareas = new List<Task>();
        }

        public string? Bienvenido { get { return lbl_BienvenidoJugador.Text; } set { lbl_BienvenidoJugador.Text = value; } }    
        public string? UsuariosCargados { get { return lbl_UsuariosCargados.Text; } set { lbl_UsuariosCargados.Text = value; } }
        public bool HabilitarBotonAbrirSala { get { return btn_AbirSala.Enabled; } set { btn_AbirSala.Enabled = value; } }
        public bool HabilitarPanel { set { pnl_ErrorPartidas.Enabled = value; } }
        public string? ErrorPanel { set { lbl_ErrorPartidasBaseDeDatos.Text = value; } }

        private void Frm_MenuPrincipal_Load(object sender, EventArgs e)
        {
            presentador.MostrarJugadorActivo();
            presentador.CargarDataGrid();
        }

        private async void btn_AbirSala_Click(object sender, EventArgs e)
        {
            //cuando haga multihilo este boton va a abrir segun partida existente en el dgv
            //Frm_Sala frm_Sala = new Frm_Sala();
            //frm_Sala.ShowDialog();
            //presentador.CargarDataGrid();

            listaTareas.Add(new Task(() =>
            {
                Frm_Sala frm_sala = new Frm_Sala();
                frm_sala.ShowDialog();
            }
            ));
            await CrearPartida();
            presentador.CargarDataGrid();
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

        /// <summary>
        /// Carga el DataGridView según el objeto que le pasa el presentador como parámetro
        /// </summary>
        /// <param name="fuente"></param>
        public void CargarDgv(Object fuente)
        {
            dgv_JugadoresDisponibles.DataSource = null;
            dgv_JugadoresDisponibles.DataSource = fuente;
        }

        public async Task CrearPartida()
        {
            listaTareas.Last().Start();
        }

        private void btn_Volver_Click(object sender, EventArgs e)
        {
            pnl_ErrorPartidas.Enabled = false;
        }

        private void Frm_MenuPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            presentador.GuardarInfoUsuarios();
        }


        private void btn_Estadistica_Click(object sender, EventArgs e)
        {
            Frm_Estadistica frm_Estadistica = new Frm_Estadistica();
            this.Hide();
            frm_Estadistica.ShowDialog();
            this.Show();
        }

        private void btn_AgregarSala_Click(object sender, EventArgs e)
        {
            //jugar contra la máquina 
        }
    }
}
