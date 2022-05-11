namespace Practica_POO_Personaje
{
    public class Program
    {
        public static void Main()
        {
            List<Personaje> personajes = new List<Personaje>();
            personajes.Add(new PersonajeDeFuerza("Garen", 45, 0));
            personajes.Add(new PersonajeDeAgilidad("Fiora", 75, 90, 0));
            personajes.Add(new PersonajeDeMagia("Lux", 25, 40));

            


            List<Enemigo> enemigos = new List<Enemigo>();
            enemigos.Add(new Enemigo("Darius", 100, 50));

            
        }
    }
}