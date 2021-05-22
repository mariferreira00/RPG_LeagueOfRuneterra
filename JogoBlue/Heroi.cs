using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoBlue
{
    class Heroi
    {
        public string nome { get; set; }
        public int experiencia { get; set; }
        public int nivel { get; set; }
        public int vida { get; set; }
        public int ataqueBase { get; set; }
        public int ataque { get; set; }

        public Heroi(string n)
        {
            Random numero_aleatorio = new Random();
            nome = n;
            experiencia = 0;
            nivel = 1;
            vida = 10;
            ataqueBase = numero_aleatorio.Next(1, 11); 
            ataque = ataqueBase;
        }

        public void getExp(int xp)
        {
            experiencia = experiencia + xp;

            int novonivel = (experiencia / 10) + 1;

            if(novonivel > nivel)
            {
                vida = novonivel * 10;
                ataque = ataqueBase + nivel;
                Console.WriteLine($"Você subiu do nível {nivel} para o nível {novonivel}");
                nivel = novonivel;
            }
        }

    }
}
