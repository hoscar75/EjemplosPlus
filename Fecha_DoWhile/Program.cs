using System;

namespace Fecha_DoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            bool esCorrecto = false;

            do
            {
                Console.WriteLine("Por favor, introduzca el año");

                string sAño = Console.ReadLine();

                string[] diasSemana = {  "Domingo",
                "Lunes",
                "Martes",
                "Miércoles",
                "Jueves",
                "Viernes",
                "Sábado" };

                // Es correcto, pero falla si el usuario no escribe un número
                //int año = int.Parse(sAño);

                int año;

                esCorrecto = int.TryParse(sAño, out año);

                if (esCorrecto)
                {
                    DateTime fecha = new DateTime(año, 10, 3);


                    Console.WriteLine($"La fecha introducida es {fecha}");

                    Console.WriteLine($"El año de la fecha es {fecha.Year}");


                    string diaEnEspañol = diasSemana[(int)fecha.DayOfWeek];

                    Console.WriteLine($"El día de la semana del " +
                        $"año {fecha.Year} es {diaEnEspañol} / {fecha.DayOfWeek}");
                }
                else
                {
                    Console.WriteLine("No has introducido el año bien");
                }

            } while ( !esCorrecto );


            Console.WriteLine("Pulse una tecla para salir");
            Console.ReadKey();
        }
    }
}
