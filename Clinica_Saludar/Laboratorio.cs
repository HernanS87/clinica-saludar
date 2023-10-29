using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica_Saludar
{
    class Laboratorio : Medico
    {
        private int nivelComplejidad;

        public Laboratorio(string nombre, int cantDias, int nivelComplejidad) : base(nombre, cantDias)
        {
            this.NivelComplejidad = nivelComplejidad;
        }

        public int NivelComplejidad { get => nivelComplejidad; set => nivelComplejidad = value; }

        public override void CalcularPrecio()
        {
            double montoF;
            if (nivelComplejidad > 3)
            {
                montoF = CantDias * 10000.00 * 1.25;
            }
            else
            {
                montoF = CantDias * 10000.00;
            }

            Console.WriteLine("LABORATORIO " + Nombre + ", complejidad: " + nivelComplejidad);
            Console.WriteLine("PRECIO FINAL: $" + Math.Round(montoF, 2));
        }
    }
}
