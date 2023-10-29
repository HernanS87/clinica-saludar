using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica_Saludar
{
    abstract class Medico : Servicio
    {
        private int cantDias;

        protected Medico(string nombre, int cantDias) : base(nombre)
        {
            this.CantDias = cantDias;
        }

        public int CantDias { get => cantDias; set => cantDias = value; }
    }
}
