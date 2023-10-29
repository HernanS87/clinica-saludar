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

        public Farmacia(string nombre, double porcentajeGanancia, double precioLista) : base(nombre)
        {
            this.PorcentajeGanancia = porcentajeGanancia;
            this.PrecioLista = precioLista;
        }

        public double PorcentajeGanancia { get => porcentajeGanancia; set => porcentajeGanancia = value; }
        public double PrecioLista { get => precioLista; set => precioLista = value; }

        public override double CalcularPrecio()
        {
            double montoF = (PrecioLista * (1.0 + PorcentajeGanancia/100.0)) * 1.21;
            return Math.Round(montoF, 2);
        }
    }
}
