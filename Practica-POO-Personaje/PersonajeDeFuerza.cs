using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_POO_Personaje
{
    internal class PersonajeDeFuerza : Personaje
    {
        public PersonajeDeFuerza(string nom, int mag, int ag)
        {
            nombre = nom;
            magia = mag;
            agilidad = ag;
            fuerza = 100;
        }
        public override int CalcularDanio()
        {
           return fuerza + (fuerza/2) + agilidad + (magia/3) ;
        }
        public override void Atacar()
        {
            int daño = CalcularDanio();
            Console.WriteLine($"{nombre} ha mascrado con {daño} de daño");
        }
    }
}
