using System;



namespace Clase
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variable estática: existe aunque no haya instanciado/creado objetos de la clase
            int capacidad = SeatIbiza.CapacidadDeposito;

            SeatIbiza coche1 = new SeatIbiza("Emilio", "Gris");

            SeatIbiza coche2 = new SeatIbiza("Juan", "Rojo");

                        
            coche1.EcharGasolina(5);

            // Si los miembros/variables son públicos permite mal uso
            //coche1.LitrosEnDeposito = 10000000;
            //coche1.Color = "Rosa";
            //coche1.Dueño = "Oscar";

            coche1.Arrancar();

            Console.WriteLine($"El coche de color {coche1.Color} de" +
                $" {coche1.GetDueño()} tiene {coche1.LitrosEnDeposito} litros ");

            Console.ReadKey();
        }
    }
}
