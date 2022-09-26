using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca;

namespace Vista
{
    public partial class frm_Login : Form
    {
        Dictionary<int,Empleado> empleados = new Dictionary<int, Empleado>();

        public frm_Login()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            Hardcodeo.InicializarEmpleados(empleados);
            tmr_HoraActual.Start();
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            foreach(KeyValuePair<int,Empleado> item in empleados)
            {
                if(item.Value.Usuario == txt_Usuario.Text && item.Value.ValidarContraseña(txt_Contraseña.Text))
                {
                    frm_Menu menu = new frm_Menu(item.Value.Usuario);
                    menu.ShowDialog();
                    menu.Close();
                    break;
                }
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Autocompletar_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int rnd = random.Next(1, 5);
            txt_Usuario.Text = empleados[rnd].Usuario;
            txt_Contraseña.Text = "123";
        }

        private void tmr_HoraActual_Tick(object sender, EventArgs e)
        {
            lbl_Hora.Text = DateTime.Now.ToShortDateString();
        }
    }
}
