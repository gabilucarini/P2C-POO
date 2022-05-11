using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personaje
{
    public class Enemigo : IMoverse
    {
        public int Vida { get; set; }
        public int Nivel { get; set; }
        public Enemigo(int vida, int nivel)
        {
            this.Vida = vida;
            this.Nivel = nivel;
        }

        public int MoverseEjeX()
        {
            return 10;
        }

        public int MoverseEjeY()
        {
            return 10;
        }
    }
}
