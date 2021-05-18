using System;

namespace LibreriaVehiculos
{
    public abstract class Vehiculo
    {
        private string Dueño;

        public string GetDueño()
        {
            return Dueño;
        }

        public string Color { get; private set; }

        public int LitrosEnDeposito { get; protected set; } = 0;

        /// <summary>
        /// Variable estática común para todos los objetos de la clase: capacidad del depósito
        /// </summary>
        public static int CapacidadDeposito = 50;


        public Vehiculo(string _dueño, string _color)
        {
            Dueño = _dueño;
            Color = _color;

            // Es lo mismo
            //this.Dueño = _dueño;
            //this.Color = _color;
        }

        /// <summary>
        /// Echa gasolina en el depósito
        /// </summary>
        /// <param name="litros">los litros a echar</param>
        public void EcharGasolina(int litros)
        {
            if (LitrosEnDeposito + litros <= CapacidadDeposito)
            {
                // Es lo mismo
                //LitrosEnDeposito += litros;
                LitrosEnDeposito = LitrosEnDeposito + litros;
            }
            else
            {
                LitrosEnDeposito = CapacidadDeposito;
            }
        } // EcharGasolina

        public abstract bool Arrancar();

        public virtual int GetRemolques()
        {
            return 0;
        }
    }
}
