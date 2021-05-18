using System;
using System.Collections.Generic;
using System.Text;

namespace Clase
{
    public class SeatIbiza
    {
        /// <summary>
        /// Nombre del dueño
        /// </summary>
        private string Dueño;

        public string GetDueño()
        {
            return Dueño;
        }

        public string Color { get; private set; }

        public int LitrosEnDeposito { get; private set; } = 0;

        /// <summary>
        /// Variable estática común para todos los objetos de la clase: capacidad del depósito
        /// </summary>
        public static int CapacidadDeposito = 50;
       

        public SeatIbiza(string _dueño, string _color)
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


    /// <summary>
    /// Arracna el coche y le resta 2 litros
    /// </summary>
    /// <returns></returns>
        public bool Arrancar()
        {
            if (LitrosEnDeposito < 2)
            {
                return false;
            }
            else
            {
                LitrosEnDeposito = LitrosEnDeposito - 2;

                return true;
            }
        } // Arrancar
    }
}
