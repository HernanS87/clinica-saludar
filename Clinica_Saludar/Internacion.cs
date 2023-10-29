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

        public override double CalcularPrecio()
        {
            double montoF = CantDias * 20000.00 * (1.00 + 21.00 / 200.00);
            return Math.Round(montoF, 2);
        }
    }
}
