using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica_Saludar
{
    class Internacion : Medico
    {
        public Internacion(string nombre, int cantDias) : base(nombre, cantDias)
        {
        }

        public override void CalcularPrecio()
        {
            double montoF = CantDias * 20000.00;
            Console.WriteLine("INTERNACION " + Nombre);
            Console.WriteLine("PRECIO FINAL: $" + Math.Round(montoF, 2));
        }
    }
}
