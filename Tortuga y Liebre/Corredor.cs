using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tortuga_y_Liebre
{
    abstract class Corredor
    {
        protected static Random r = new Random();
        protected int _posicion;
        public int posicion { get { return _posicion; } }
        public Corredor()
        {
            _posicion = 0;
        }
        public void correr()
        {
            _posicion += obtenerAvance();
            if (_posicion < 0)
                _posicion = 0;
        }

        public abstract int obtenerAvance();
    }


}
