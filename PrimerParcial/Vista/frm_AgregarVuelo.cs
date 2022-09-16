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
    public partial class frm_AgregarVuelo : Form
    {
        public frm_AgregarVuelo()
        {
            InitializeComponent();
        } 
        public frm_AgregarVuelo(Destinos origen, Destinos llegada, DateTime salida) : this()
        {

        }
    }
}
