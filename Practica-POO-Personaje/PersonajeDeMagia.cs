using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_POO_Personaje
{
    public class PersonajeDeMagia : Personaje
    {
        public PersonajeDeMagia(string nomb, int fuer, int ag, int mag)
        {
            nombre = nomb;
            fuerza = fuer;
            agilidad = ag;
            magia = mag;
        }
        public PersonajeDeMagia(string nomb, int fuer, int ag)
        {
            nombre = nomb;
            fuerza = fuer;
            agilidad = ag;
            magia = 60;
        }
        public override int CalcularDanio()
        {
            return fuerza + agilidad + magia * 4;
        }
        public override void Atacar()
        {
            int dañoMagico = CalcularDanio();
            Console.WriteLine($"{nombre} dominó con {dañoMagico} de daño gracias a su magia");

        }
    }
    public string MoverseEjeX()
    {
        throw new NotImplementedException();
    }

    public string MoverseEjeY()
    {
        throw new NotImplementedException();
    }
}
