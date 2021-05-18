using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Concurrencia
{
    public class Desayuno
    {
        public void ServirCafe()
        {
            Console.WriteLine("Café servido");
        }

        public TimeSpan Tiempo(DateTime inicio)
        {
            TimeSpan resultado = DateTime.Now - inicio;

            return resultado;
        }

        public int FreirHuevos(int huevos)
        {
            // Almaceno la hora de inicio
            DateTime horaInicio = DateTime.Now;

            Console.WriteLine("Calentando la sartén para los huevos...");

            // Simulo 2 segundos de tiempo
            Task.Delay(2000).Wait();

            Console.WriteLine("Romìendo huevos y poniéndolos en la sartén...");

            Task.Delay(2000).Wait();

            TimeSpan haTardado = Tiempo(horaInicio);

            // Escribo la hora de finalización
            Console.WriteLine($"huevos {huevos} ya fritos en {haTardado.TotalSeconds} segundos");

            return huevos;
        }

        public async Task<int> FreirHuevosAsync(int huevos)
        {
            DateTime horaInicio = DateTime.Now;

            Console.WriteLine("Calentando la sartén para los huevos...");

            await Task.Delay(2000);

            Console.WriteLine("Romìendo huevos y poniéndolos en la sartén...");

            await Task.Delay(2000);

            TimeSpan haTardado = Tiempo(horaInicio);

            Console.WriteLine($"huevos {huevos} ya fritos en {haTardado.TotalSeconds} segundos");

            return huevos;
        }

        public int FreirBacon(int tiras)
        {
            DateTime horaInicio = DateTime.Now;

            Console.WriteLine("Calentando la sartén para el bacon...");

            Task.Delay(2000).Wait();

            Console.WriteLine("Caliento las tiras de bacon por un lado...");

            Task.Delay(2000).Wait();

            Console.WriteLine("Caliento las tiras de bacon por el otro lado...");

            Task.Delay(2000).Wait();

            TimeSpan haTardado = Tiempo(horaInicio);

            Console.WriteLine($"{tiras} de bacon ya fritas en {haTardado.TotalSeconds} segundos");

            return tiras;
        }

        public async Task<int> FreirBaconAsync(int tiras)
        {
            DateTime horaInicio = DateTime.Now;

            Console.WriteLine("Calentando la sartén para el bacon...");

            await Task.Delay(2000);

            Console.WriteLine("Caliento las tiras de bacon por un lado...");

            await Task.Delay(2000);

            Console.WriteLine("Caliento las tiras de bacon por el otro lado...");

            Task.Delay(2000).Wait();

            TimeSpan haTardado = Tiempo(horaInicio);

            Console.WriteLine($"{tiras} de bacon ya fritas en {haTardado.TotalSeconds} segundos");

            return tiras;
        }

        public void Preparar(int huevos, int tirasBacon)
        {
            DateTime horaInicio = DateTime.Now;

            ServirCafe();

            int huevosFritos = FreirHuevos(huevos);

            int baconFrito = FreirBacon(tirasBacon);

            TimeSpan haTardado = Tiempo(horaInicio);

            Console.WriteLine($"Desayuno preparado en {haTardado.TotalSeconds} segundos");
        }

        public async Task PreparaAsync(int huevos, int tirasBacon)
        {
            DateTime horaInicio = DateTime.Now;

            ServirCafe();

            // Lanzo los procesos
            Task<int> tareaHuevos = FreirHuevosAsync(huevos);

            // Ojo con esto porque estaré esperando a que acabe de freir los huevos
            //int huevosFritos = await tareaHuevos;

            // Aunque los huevos no han acabado lanzo freir Bacon
            Task<int> tareaBacon = FreirBaconAsync(tirasBacon);

            //int baconFrito = await tareaBacon;

            // Ahora sí me espero a que acaben los dos procesos de freir
            int huevosFritos = await tareaHuevos;

            int baconFrito = await tareaBacon;


            TimeSpan haTardado = Tiempo(horaInicio);

            Console.WriteLine($"Desayuno asíncrono preparado en {haTardado.TotalSeconds} segundos");
        }
    }
}
