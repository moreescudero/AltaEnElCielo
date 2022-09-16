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
        Destinos origen;
        Destinos destino;
        int cantidadPasajeros;
        DateTime partida;
        DateTime llegada;
        string? clase;

        public frm_AltaPasajero()
        {
            InitializeComponent();
        }
        
        public frm_AltaPasajero(Destinos origen, Destinos destino, int cantidadPasajeros, DateTime partida, DateTime llegada, string? clase) : this()
        {
            this.origen = origen;
            this.destino = destino;
            this.cantidadPasajeros = cantidadPasajeros;
            this.partida = partida;
            this.llegada = llegada;
            this.clase = clase;
        }

        private void nud_CantEquipaje_ValueChanged(object sender, EventArgs e)
        {
            if(nud_CantEquipaje.Value > 0)
            {
                txt_Equipaje.Enabled = true;
            }
            else
            {
                txt_Equipaje.Enabled = false;
            }
        }

        private void frm_AltaPasajero_Load(object sender, EventArgs e)
        {

        }

        private void label1_VisibleChanged(object sender, EventArgs e)
        {
            chk_MenuCeliaco.Enabled = false;
            chk_MenuComun.Enabled = false;
            chk_MenuVegano.Enabled = false;
            chk_MenuVegetariano.Enabled = false;
        }
    }
}
