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

       
    }
}
