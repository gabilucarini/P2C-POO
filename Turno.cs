using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personaje
{
    public static class Turno
    {
        public static void Atacarse(IList<Personaje> personajes)
        {

            foreach (Personaje personaje in personajes)
            {
                personaje.Atacar();
            }
        }

        public static void MoverFichas(IMoverse ficha)
        {
            ficha.MoverseEjeX();
            ficha.MoverseEjeY();

        }

    }
}
