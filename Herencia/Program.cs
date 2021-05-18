using LibreriaVehiculos;
using System;


namespace Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            // No puedo crear instancias de una clase abstracta
            //Vehiculo v = new Vehiculo("fulano", "rojo");

            Coche coche1 = new Coche("Fulano", "Rojo");

            Camion camion1 = new Camion("Manolo", "Verde", 2);

            //coche1.LitrosEnDeposito = 8;
            //camion1.NumeroRemolques = 8;
            //int r = camion1.NumeroRemolques;

            camion1.EngancharRemolque();

            camion1.EcharGasolina(20);

            if ( camion1.Arrancar() )
            {
                Console.WriteLine($"El camion de {camion1.GetDueño()} ha arrancado y le quedan {camion1.LitrosEnDeposito} litros ");
            }
            else
            {
                Console.WriteLine($"El camion de {camion1.GetDueño()} NO ha arrancado");
            }


            coche1.EcharGasolina(10);

            bool haArrancadoCoche = coche1.Arrancar();

            if ( haArrancadoCoche )
            {
                Console.WriteLine($"El coche de {coche1.GetDueño()} ha arrancado y le quedan {coche1.LitrosEnDeposito} litros ");
            }
            else
            {
                Console.WriteLine($"El coche de {coche1.GetDueño()} NO ha arrancado");
            }

            Console.ReadKey();
        }
    }
}
