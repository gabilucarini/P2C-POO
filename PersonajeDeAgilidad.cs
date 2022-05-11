using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personaje
{
    public class PersonajeDeAgilidad : Personaje
    {
        public PersonajeDeAgilidad(string nombre,int fuerza, int agilidad, int magia)
        {
            this.Nombre = nombre;
            this.Fuerza = fuerza;
            this.Agilidad = agilidad;
            this.Magia = magia;
        }

        public override int CalcularDanio()
        {
            return ((this.Agilidad + this.Magia + this.Fuerza) * 2);
        }

        public override int MoverseEjeX()
        {
            return 12;
        }

        public override int MoverseEjeY()
        {
            return 10;
        }
    }
}
