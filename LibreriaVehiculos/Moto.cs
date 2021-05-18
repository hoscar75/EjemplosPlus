using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriaVehiculos
{
    public class Moto : Vehiculo
    {
        public Moto(string _dueño) : base (_dueño, "Negra")
        {

        }

        public override bool Arrancar()
        {
            if ( LitrosEnDeposito > 2 )
            {
                LitrosEnDeposito = LitrosEnDeposito - 1;

                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
