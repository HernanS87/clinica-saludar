using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica_Saludar
{
    abstract class Servicio
    {
        private string nombre;

        protected Servicio(string nombre)
        {
            this.Nombre = nombre;
        }

        public string Nombre { get => nombre; set => nombre = value; }

        public abstract void CalcularPrecio();
    }
}
