using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personaje
{
    public class PersonajeDeMagia : Personaje
    {
        public PersonajeDeMagia(string nombre, int agilidad, int magia, int fuerza)
        {
            this.Nombre = nombre;
            this.Fuerza = fuerza;
            this.Agilidad = agilidad;
            this.Magia = magia;
        }

        public PersonajeDeMagia(string nombre, int agilidad, int fuerza)
        {
            this.Nombre = nombre;
            this.Fuerza = fuerza;
            this.Agilidad = agilidad;
            this.Magia = 60;
        }
        public override int CalcularDanio()
        {
            return ((this.Agilidad + this.Magia + this.Fuerza) * 4);
        }

        public override void Atacar()
        {
            Console.WriteLine($"{this.Nombre} hizo {CalcularDanio()} de daño gracias a su magia");
        }

        public override int MoverseEjeX()
        {
            return 9;
        }

        public override int MoverseEjeY()
        {
            return 6;
        }
    }
}
