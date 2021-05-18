using System;

namespace DiasSemana
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] diasSemana = { "Lunes", "Martes", "Miércoles",
                "Jueves", "Viernes", "Sábado", "Domingo" };

            // Solución con for
            for (int dia = 0; dia < diasSemana.Length; dia++)
            //for ( int dia=0; dia <= 6; dia++)
            {
                Console.WriteLine(diasSemana[dia]);
            } // for


            // Lo mismo con un bucle while
            Console.WriteLine();
            Console.WriteLine("Ejecución del while");
            int dia2 = 0;

            while ( dia2 < diasSemana.Length )
            {
                Console.WriteLine( diasSemana[dia2] );

                //dia2++;
                dia2 = dia2 + 1;
            }


        


            Console.WriteLine("Pulse una tecla para cerrar");
            Console.ReadKey();
        } // Main
    } // class
}
