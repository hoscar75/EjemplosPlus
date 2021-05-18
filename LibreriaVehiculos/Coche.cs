using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriaVehiculos
{
    public class Coche : Vehiculo
    {
        public Coche(string _dueño, string _color) : base(_dueño, _color)
        {

        }

        public override bool Arrancar()
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
        }
    }
}
