using System;
using System.Collections.Generic;
using System.Linq;

namespace Ejemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            //2
           // Tarea.Que el programa diga si un día es fin de semana o no

           ////
           //Que escriba el dia que queremos comprobar

            Console.WriteLine();

            Console.WriteLine("Por favor Escribe un día de la semana: ");           

            string diaSemana = Console.ReadLine();

            diaSemana = diaSemana.ToLower();

            //Creamos
            //el array de fines de semana para comprobar
             string []aSemana = { "lunes", "martes", "miercoles", "miércoles", 
                "jueves", "viernes", "sabado", "sábado", "domingo"};

            string[] aFinde = { "sabado", "sábado", "domingo"};

            List<string> listaFinde = aFinde.ToList();
            
            //if ( diaSemana ==  aSemana[0 - 5] )           
            //if ( listaFinde.Contains( diaSemana ) )
            if ( diaSemana=="sábado" || diaSemana=="sabado" || diaSemana=="domingo" )
            {
                Console.WriteLine("El día es en fin de semana");                
            }//iff
            else if ( aSemana.ToList().Contains( diaSemana) )
            {
                Console.WriteLine("No es en fin de semana");
            }
            else
            {
                Console.WriteLine("No es ningún día");
            }//else
        }
    }
}
