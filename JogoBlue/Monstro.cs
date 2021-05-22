using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoBlue
{
    class Monstro
    {
        public string nome { get; set; }
        public int vida { get; set; } 
        public int experiencia { get; set; }
        public int ataque { get; set; }

        public Monstro(string nome, int vida, int ataque)
        {
            this.nome = nome;
            this.vida = vida;
            this.experiencia = vida + ataque;
            this.ataque = ataque;
        }
    }
}
