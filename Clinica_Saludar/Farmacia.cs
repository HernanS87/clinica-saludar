using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica_Saludar
{
     class Farmacia : Servicio
    {
        private double porcentajeGanancia;
        private double precioLista;

        public Farmacia(string nombre, int porcentajeGanancia, double precioLista) : base(nombre)
        {
            this.porcentajeGanancia = porcentajeGanancia;
            this.precioLista = precioLista;
        }

        public override void CalcularPrecio()
        {
            double montoF = (precioLista * (1.0 + porcentajeGanancia/100.0)) * 1.21;
            Console.WriteLine("FARMACIA " + Nombre);
            Console.WriteLine("PRECIO FINAL: $" + Math.Round(montoF, 2));
        }
    }
}
