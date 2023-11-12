// See https://aka.ms/new-console-template for more information
using Clinica_Saludar;
using System;

Console.WriteLine("Bienvenido al Sistema de Facturación de la Clínica Médica");
List<Servicio> servicios = new List<Servicio>();
int opcion;


do
{
    Console.WriteLine("\n1. Agregar un nuevo servicio\n" +
                      "2. Mostrar detalles de los servicios\n" +
                      "3. Salir");
    bool res = int.TryParse(Console.ReadLine(),out opcion);
    if (!res)
    {
        Console.WriteLine("OPCIÓN INCORRECTA");
    } 
    else
    {
        switch (opcion) {
            case 1:
                AgregarServicio();
                break;
            case 2:
                MostrarDetalles();
                break;
            case 3:
                MontoTotalFacturado();
                CantidadServiciosSimples();
                break; 
            default:
                Console.WriteLine("OPCIÓN INCORRECTA");
                break;
        }

    }

} while (opcion != 3);


void AgregarServicio()
{
    string? nombre;
    int cantD;
    int nivelC;
    string? servicioSelec;
    double precioLista;
    double ganancia;


    Console.WriteLine("¿Qué tipo de servicio desea agregar? (Internacion/Laboratorio/Farmacia):");
    servicioSelec = Console.ReadLine().ToUpper();
    ValidarServicio(ref servicioSelec);


    switch (servicioSelec)
    {
        case "LABORATORIO":
            
            Console.WriteLine("Ingrese el nombre del servicio de laboratorio:");
            nombre = Console.ReadLine();
            ValidarNombre(ref nombre);

            Console.WriteLine("Ingrese la cantidad de dias del servicio de laboratorio:");
            int.TryParse(Console.ReadLine(), out cantD);
            ValidarCantDias(ref cantD);

            Console.WriteLine("Ingrese nivel de complejidad (numero del 1 al 5):");                
            int.TryParse(Console.ReadLine(), out nivelC);
            ValidarNivelComp(ref nivelC);

            servicios.Add(new Laboratorio(nombre, cantD, nivelC));
            Console.WriteLine("¡El servicio de LABORATORIO ha sido agregado correctamente!");
            break;

        case "INTERNACION":

            Console.WriteLine("Ingrese el nombre de la especialidad:");
            nombre = Console.ReadLine();
            ValidarNombre(ref nombre);
 
            Console.WriteLine("Ingrese la cantidad de dias de internación:");
            int.TryParse(Console.ReadLine(), out cantD);
            ValidarCantDias(ref cantD);

            servicios.Add(new Internacion(nombre, cantD));
            Console.WriteLine("¡El servicio de INTERNACIÓN ha sido agregado correctamente!");
            break;

        case "FARMACIA":

            Console.WriteLine("Ingrese el nombre del medicamento:");
            nombre = Console.ReadLine();
            ValidarNombre(ref nombre);

            Console.WriteLine("Ingrese el precio de lista:");                
            double.TryParse(Console.ReadLine(), out precioLista);
            ValidarPrecio(ref precioLista);

            Console.WriteLine("Ingrese el porcentaje de ganancia (seleccione un numero del 1 al 100):");
            double.TryParse(Console.ReadLine(), out ganancia);
            ValidarPorcentaje(ref ganancia);

            servicios.Add(new Farmacia(nombre, ganancia, precioLista));
            Console.WriteLine("¡El servicio de FARMACIA ha sido agregado correctamente!");
            break;
        default:
            Console.WriteLine("SERCIVIO INCORRECTO");
            break;
    }

}

void MostrarDetalles()
{
    Console.WriteLine("\nDetalles de los servicios: \n");
    if (servicios.Count > 0)
    {
        foreach (Servicio s in servicios)
        {
            string tipo = s.GetType().Name;
            Console.WriteLine("Tipo: " + tipo);
            Console.WriteLine("Nombre: " + s.Nombre);

            switch (tipo.ToUpper())
            {
                case "INTERNACION":
                    Console.WriteLine("Días de servicio: " + ((Medico)s).CantDias);
                    break;
                case "LABORATORIO":
                    Console.WriteLine("Días de servicio: " + ((Medico)s).CantDias);
                    Console.WriteLine("Nivel de Complejidad: " + ((Laboratorio)s).NivelComplejidad);
                    break;
                case "FARMACIA":
                    Console.WriteLine("Precio de Lista: " + ((Farmacia)s).PrecioLista);
                    Console.WriteLine("Porcentaje de Ganancia: " + ((Farmacia)s).PorcentajeGanancia + "%");
                    break;
                default: break;
            }

            Console.WriteLine("Precio Final: $" + s.CalcularPrecio());
            Console.WriteLine("\n\n");
        }
    }
    else
    {
        Console.WriteLine("No has agregado ningun servicio");
    }
}

void MontoTotalFacturado()
{
    double montoTotal = 0;
    if(servicios.Count > 0)
    {
        foreach (Servicio s in servicios)
        {
            montoTotal += s.CalcularPrecio();
        }
    }
    Console.WriteLine("\nMonto Total Facturado: $" + Math.Round(montoTotal,2));
}

void CantidadServiciosSimples()
{
    double cant = 0;
    if (servicios.Count > 0)
    {
        foreach (Servicio s in servicios)
        {
            if(s.GetType().Name.ToUpper() == "LABORATORIO" && ((Laboratorio)s).NivelComplejidad <= 3)
            {
                cant += 1;
            }
        }
    }
    Console.WriteLine("\nCantidad de Servicios Simples: " + cant);
}


//----------------------------------- VALIDACIONES ------------------------------------

void ValidarServicio(ref string servicio)
{
    while (servicio != "INTERNACION" && servicio != "LABORATORIO" && servicio != "FARMACIA")
    {
        Console.WriteLine("Servicio ingresado no válido. Ingrese el servicio que desea agregar (Internacion/Laboratorio/Farmacia):");
        servicio = Console.ReadLine().ToUpper();
    };
}

void ValidarNombre(ref string nombre)
{
    while (string.IsNullOrEmpty(nombre))
    {
        Console.WriteLine("Nombre no válido. Debe ingresar un nombre.");
        nombre = Console.ReadLine();
    };
}

void ValidarCantDias(ref int cantD)
{
    while (cantD <= 0)
    {
        Console.WriteLine("Cantidad de días no válida. Debe ingresar un número válido mayor a 0");
        int.TryParse(Console.ReadLine(), out cantD);
    };
}

void ValidarNivelComp(ref int nivelC)
{
    while (nivelC < 1 || nivelC > 5)
    {
        Console.WriteLine("Nivel de complejidad no válido. Debe ingresar un número entero entre 1 y 5.");
        int.TryParse(Console.ReadLine(), out nivelC);
    };
}

void ValidarPrecio(ref double precio)
{
    while (precio <= 0)
    {
        Console.WriteLine("Precio no válido. Debe ingresar un número válido mayor a 0");
        double.TryParse(Console.ReadLine(), out precio);
    };
}

void ValidarPorcentaje(ref double porcentaje)
{
    while (porcentaje < 1 || porcentaje > 100)
    {
        Console.WriteLine("Porcentaje no válido. Debe ingresar un número válido entre 1 y 100");
        double.TryParse(Console.ReadLine(), out porcentaje);
    };
}