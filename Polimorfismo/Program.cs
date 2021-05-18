using System;
using LibreriaVehiculos;

namespace Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Por favor, indique si va a cojer camion o coche");

            string eleccion = Console.ReadLine();

            //// MAAAL: funciona, pero no es una programación eficiente            
            //if ( eleccion=="coche" )
            //{
            //    Coche coche1 = new Coche("Empleado", "Gris");

            //    coche1.EcharGasolina(20);

            //    coche1.Arrancar();
            //}
            //else
            //{
            //    Camion camion1 = new Camion("Empleado", "Gris", 1);

            //    camion1.EcharGasolina(20);

            //    camion1.Arrancar();
            //}

            Vehiculo vehiculoEmpresa;

            if ( eleccion == "coche" )
            {
                vehiculoEmpresa = new Coche("Empresario Negrero", "Rojo");
            }
            else
            {
                vehiculoEmpresa = new Camion("Empresario Negrero", "Rojo", 1);
            }

            vehiculoEmpresa.EcharGasolina(20);

            vehiculoEmpresa.Arrancar();

            Console.WriteLine($"El vehículo de {vehiculoEmpresa.GetDueño()} " +
                $"tiene {vehiculoEmpresa.LitrosEnDeposito} litros en el depósito ");

             Console.ReadKey();
        }
    }
}
