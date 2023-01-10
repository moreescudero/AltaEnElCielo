using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using Biblioteca;
using Vista.Properties;

namespace Vista
{
    public partial class frm_Login : Form
    {

        public frm_Login()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            tmr_HoraActual.Start();
            Aerolinea.InicializarAerolinea();
            Aerolinea.QuitarVuelosFinalizados();

            Formulario.Font(this);

            ActualizarBackColor();
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            int contador = 0;
            foreach (KeyValuePair<int, Empleado> item in Aerolinea.diccEmpleados)
            {
                if (item.Value.Usuario == txt_Usuario.Text && item.Value.ValidarContraseña(txt_Contraseña.Text))
                {
                    frm_Menu menu = new frm_Menu(item.Value);
                    this.Hide();
                    if(menu.ShowDialog() == DialogResult.OK)
                    {
                        this.Show();
                    }
                    else
                    {
                        Application.Exit();
                    }
                    break;
                }
                contador++;
            }
            if (contador == 4)
            {
                lbl_Incorrecto.Visible = true;
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
            txt_Usuario.Text = Aerolinea.diccEmpleados[rnd].Usuario;
            txt_Contraseña.Text = "123";
        }

        private void tmr_HoraActual_Tick(object sender, EventArgs e)
        {
            lbl_Hora.Text = DateTime.Now.ToShortDateString();
        }

        private void txt_Usuario_TextChanged(object sender, EventArgs e)
        {
            lbl_Incorrecto.Visible = false;
        }


        private void ActualizarBackColor()
        {
            DateTime tiempo = DateTime.Now;
            //DateTime tiempo = DateTime.Parse("23:00:00");
            DateTime amanecer = DateTime.Parse("06:25:00");
            DateTime tarde = DateTime.Parse("16:50:00");
            DateTime noche = DateTime.Parse("18:57:00");
            if (tiempo.CompareTo(noche) > 0 || tiempo.CompareTo(amanecer) < 0)
            {
                this.BackColor = Color.FromArgb(98, 94, 150);
            }
            else
            {
                if (tiempo.CompareTo(tarde) > 0)
                {
                    this.BackColor = Color.FromArgb(218, 168, 87);
                }
                else
                {
                    this.BackColor = Color.FromArgb(114, 225, 252);
                }
            }
        }
    }
}
