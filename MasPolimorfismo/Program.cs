using System;
using LibreriaVehiculos;

namespace MasPolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca el núnero de vehículos");

            string sNumero = Console.ReadLine();

            int numero = int.Parse(sNumero);

            // Creo un array de vehículos
            Vehiculo[] misVehiculos = new Vehiculo[numero];

            for ( int i=0; i<misVehiculos.Length; i++ )
            {
                //if ( i % 2 == 0 )
                if ( i % 3 == 0 )
                {
                    misVehiculos[i] = new Coche("Negrero", "Azul");
                }
                else if ( i % 3 == 1 )
                {
                    misVehiculos[i] = new Moto("Negro");
                }
                else
                {
                    Random r = new Random();

                    int remolques = r.Next(0, 3);

                    misVehiculos[i] = new Camion("Negrero", "Rojo", remolques);
                }

                misVehiculos[i].EcharGasolina(6);

                misVehiculos[i].Arrancar();

                

                Console.WriteLine($"El vehículo {i} {misVehiculos[i].Color} " +
                    $"tiene {misVehiculos[i].LitrosEnDeposito} litros " +
                    $"y {misVehiculos[i].GetRemolques()} remolques");
            }

            Console.ReadKey();
        }
    }
}
