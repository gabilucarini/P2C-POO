namespace Personaje
{

    public class Program
    {
        public static void Main()
        {
            List<Personaje> personajes = new List<Personaje>();
            personajes.Add(new PersonajeDeMagia("Dark Wizard", 25, 29));
            personajes.Add(new PersonajeDeAgilidad("Fairy Elf", 85, 20, 19));
            personajes.Add(new PersonajeDeFuerza("Dark Knight", 49, 50));

            List<Enemigo> enemigos = new List<Enemigo>();
            enemigos.Add(new Enemigo(100, 107));
            enemigos.Add(new Enemigo(120, 57));

            Turno.Atacarse(personajes);

            foreach (IMoverse enemigo in enemigos)
            {
                Turno.MoverFichas(enemigo);
            }

            foreach (IMoverse personaje in personajes)
            {
                Turno.MoverFichas(personaje);
            }

        }
    }
}