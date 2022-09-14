using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public abstract class Persona
    {
        protected string nombre;
        protected string apellido;

        public Persona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public string Nombre
        {
            get { return nombre; }
        }

        public string Apellido
        {
            get { return apellido; }
        }
    }
}
