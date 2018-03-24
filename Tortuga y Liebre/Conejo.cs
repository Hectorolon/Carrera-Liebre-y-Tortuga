using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tortuga_y_Liebre
{
    class Conejo : Corredor
    {
        //domir 20% 0 avance
        //salto grande 20% +9 pasos
        //resbalon grande 10 -12 pasos
        //salto pequeño 30 % +1 paso
        //resbalon pequeño 20% -2 pasos

        public override int obtenerAvance()
        {
            int aleatorio = r.Next(10);
            if (aleatorio < 2)
                return 0;
            else if (aleatorio < 4)
                return 9;
            else if (aleatorio < 5)
                return -12;
            else if (aleatorio < 8)
                return 1;
            else
                return-2;
        }
        public override string ToString()
        {
            return "La liebre esta en la posicion " + _posicion;
        }
    }
}
