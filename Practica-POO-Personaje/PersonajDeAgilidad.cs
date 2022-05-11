using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_POO_Personaje
{
    internal class PersonajeDeAgilidad : Personaje
    {
        public PersonajeDeAgilidad(string nom, int mag, int fuer, int ag)
        {
            nombre = nom;
            magia = mag;
            fuerza = fuer;
            agilidad = ag;
        }
        public override int CalcularDanio()
        {
            return fuerza / 2 * agilidad * magia / 2;
        }
        public override void Atacar()
        {
            int daño = CalcularDanio();
            Console.WriteLine($"{nombre} ha mascrado con {daño} de daño");
        }
    }
}
