using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personaje
{
    public class PersonajeDeFuerza : Personaje
    {
        public PersonajeDeFuerza(string nombre, int agilidad, int magia )
        {
            this.Nombre = nombre;
            this.Fuerza = 100;
            this.Agilidad = agilidad;
            this.Magia = magia;
        }

        public override int CalcularDanio()
        {
            return ((this.Agilidad * 4) + (this.Magia / 3)) + (this.Fuerza);
        }

        public override int MoverseEjeX()
        {
            return 10;
        }

        public override int MoverseEjeY()
        {
            return 12;
        }
    }
}
