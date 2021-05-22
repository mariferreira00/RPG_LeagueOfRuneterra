using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoBlue
{
    class Jogo
    {
        Heroi heroi;
        public void Inicio()
        {
            Console.WriteLine("********** Seja Bem vindo a League of Runeterra **********");
            Console.WriteLine("Informe seu nome de invocador: ");
            this.heroi = new Heroi(Console.ReadLine().ToUpper()); 
            Console.Clear();
            Menu();
        }

        public void Menu()
        {
            do
            {
                ExibirHeroi();
                Console.WriteLine("Seja forte invocador, Runeterra depende de sua bravura para vencer!!!");
                Console.WriteLine("Qual monstro você vai enfrentar? ");
                Console.WriteLine("1 - Aronguejo");
                Console.WriteLine("2 - Arauto do vale");
                Console.WriteLine("3 - Dragão Elemental");
                Console.WriteLine("4 - Barão de Na'Shor");
                Console.WriteLine("0 - Sair");

                switch (Console.ReadLine().ToLower())
                {
                    case "1":
                    case "orc":
                        Batalha(new Monstro("Aronguejo", heroi.nivel * 2, heroi.nivel));
                        break;
                    case "2":
                    case "troll":
                        Batalha(new Monstro("Arauto do Vale", heroi.nivel * 5, heroi.nivel * 2));
                        break;
                    case "3":
                    case "goblin":
                        Batalha(new Monstro("Dragão Elemental", heroi.nivel * 10, heroi.nivel * 4));
                        break;
                    case "4":
                    case "Dragão":
                        Batalha(new Monstro("Dragão", 1000, 100));
                        break;
                    case "0":
                    case "sair":
                        Console.WriteLine("Saindo da aplicação...");
                        return;
                    default:
                        Console.WriteLine("Opção inválida!!");
                        break;
                }

                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
                Console.Clear();

            } while (heroi.vida > 0);
        }


        public void Batalha(Monstro m)
        {
            Console.Clear();
            ExibirHeroi();
            Console.WriteLine($"Luta contra {m.nome}");
            Console.WriteLine($"Ataque: {m.ataque}");
            Console.WriteLine($"Vida: {m.vida}");
            Console.WriteLine($"Experiencia: {m.experiencia}");

            Console.WriteLine("\n\nVocê deseja (1) lutar ou (2) fugir ?");
            switch (Console.ReadLine())
            {
                case "1":
                case "lutar":
     
                    m.vida = m.vida - heroi.ataque;
                    heroi.vida = heroi.vida - m.ataque;
                    Console.WriteLine($"Você causou {heroi.ataque} de dano no {m.nome}.");
                    Console.WriteLine($"{m.nome} causou {m.ataque} de dano em você.");
                    if(heroi.vida <= 0)
                    {
                        Console.WriteLine("Você foi derrotado, mas isso é o fim de uma batalha não da guerra, avante invocador!!!");
                        return;
                    }
                    if(m.vida <= 0)
                    {
                        Console.WriteLine($"Runeterra prospera com a sua vitória {heroi.nome} !!! Você derrotou {m.nome}!!");
                        heroi.getExp(m.experiencia);
                        return;
                    }
                    break;
                case "2":
                case "fugir":
                    Console.WriteLine("Você fugiu da luta...");
                    return;
            }


            Console.WriteLine("\nPressione qualquer tecla para continuar");
            Console.ReadKey();
            Batalha(m);

        }

        public void ExibirHeroi()
        {
            Console.WriteLine($"Nome: {heroi.nome} ");
            Console.WriteLine($"Experiência: {heroi.experiencia}");
            Console.WriteLine($"Vida: {heroi.vida}");
            Console.WriteLine($"Nível: {heroi.nivel}");
            Console.WriteLine($"Ataque: {heroi.ataque} \n\n");
        }
    }
}
