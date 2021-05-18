using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriaVehiculos
{
    public class Camion : Vehiculo
    {
        public int NumeroRemolques { get; private set; }

        public Camion(string dueño, string color, int remolques) : base(dueño, color)
        {
            NumeroRemolques = remolques;
        }

        public void EngancharRemolque()
        {
            if ( NumeroRemolques < 3 )
            {
                NumeroRemolques++;
            }
        }

        public override bool Arrancar()
        {
            int gasolinaNecesaria = 5 + NumeroRemolques;

            if ( gasolinaNecesaria > LitrosEnDeposito )
            {
                return false;
            }
            else
            {
                LitrosEnDeposito = LitrosEnDeposito - gasolinaNecesaria;

                return true;
            }
        }

        public override int GetRemolques()
        {
            return NumeroRemolques;
        }
    }
}
