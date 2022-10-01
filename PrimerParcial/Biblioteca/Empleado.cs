using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Empleado : Persona
    {
        string usuario;
        string contraseña;
        float comision = 0;

        public Empleado(string nombre, string apellido, string usuario, string contraseña) : base(nombre, apellido)
        {
            this.usuario = usuario;
            this.contraseña = contraseña;
        }

        public string Usuario
        {
            get { return usuario; }
        }

        public bool ValidarContraseña(string contIngresada)
        {
            if(contIngresada == contraseña)
            {
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return base.ToString() + " Comision total: $" + comision;
        }

        public override void Calcular(float precio)
        {
            //Calcular la comision de cada empleado que es un 1 %
            this.comision += (precio * 0.1f);
        }
    }
}
