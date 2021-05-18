using System;
using System.Threading.Tasks;

namespace Concurrencia
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Desayuno miDesayuno = new Desayuno();

            // Prepara un desayuno secuencial (paso a paso) con 2 huevos y 3 tiras de bacon
            miDesayuno.Preparar(2, 3);

            Console.WriteLine();

            // Prepara un desayuno concurrente con 2 huevos y 3 tiras de bacon
            await miDesayuno.PreparaAsync(2, 3);

            Console.ReadKey();
        }
    }
}
