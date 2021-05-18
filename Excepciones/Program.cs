using System;
using LibreriaVehiculos;

namespace Excepciones
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Vehiculo miVehiculo = null;

            // Podemos tener capturar Excepciones sin recibir la excepción en ninguna variable dejando el catch vacío
            try
            {
                Console.WriteLine($"El vehículo de color {miVehiculo.Color} pertenece a {miVehiculo.GetDueño()} ");
            }
            catch
            {
                Console.WriteLine("Hay que inicializar el vehículo");
            }

            // Lo suyo, en caso de Excepción, es capturarla en una variable y hace algo con su información
            try
            {
                Console.WriteLine($"El vehículo de color {miVehiculo.Color} pertenece a {miVehiculo.GetDueño()} ");
            }
            catch (Exception ex )
            {
                Console.WriteLine("Se ha producido un error: " + ex.Message);
            }
            

            int[] numeros = { 4, 7, 8 };

            // Podemos capturar distintos tipos de Excepción con distintos catch
            try
            {
                    int estoFalla = numeros[20];                
            }
            catch ( IndexOutOfRangeException ex )
            {
                Console.WriteLine("Acceso a índice fuera de array:" + ex.Message);
            }
            catch ( Exception excepcion )
            {
                Console.WriteLine("Se ha producido un error: " + excepcion.Message);
            }


            Console.ReadKey();
        }
    }
}
