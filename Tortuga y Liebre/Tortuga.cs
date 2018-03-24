using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tortuga_y_Liebre
{
    class Tortuga : Corredor
    {
        //paso rapido 50% +3pasos
        //resbalon 20% -6 pasos
        //paso lento 30% +1 paso
        
        public override int obtenerAvance()
        {
            int aleatorio = r.Next(10);
            if (aleatorio < 5)
                return 3;
            else if (aleatorio < 7)
                return -6;
            else
                return 1;
        }
        public override string ToString()
        {
            return "La tortuga esta en la posicion " + _posicion;
        }
    }
}
