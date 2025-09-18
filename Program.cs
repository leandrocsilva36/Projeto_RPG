using System;

namespace ProjetoRPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Projeto RPG - Batalha por Turnos";
            Console.WriteLine("=== Projeto RPG - ==\n");

            Console.Write("Digite o nome do herói: ");
            string nomeHeroi = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(nomeHeroi)) nomeHeroi = "Herói";

            Console.Write("Escolha a classe do herói (ex: Guerreiro, Mago): ");
            string classe = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(classe)) classe = "Guerreiro";

            // Cria personagem e monstro (valores exemplo)
            var heroi = new Personagem(nomeHeroi, classe, pontosDeVida: 100, ataque: 20, curaValor: 25);

            Console.WriteLine();
            Console.Write("Digite o nome do monstro inimigo: ");
            string nomeMonstro = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(nomeMonstro)) nomeMonstro = "Orc Selvagem";

            Console.Write("Escolha o tipo do monstro (ex: Orc, Goblin): ");
            string tipoMonstro = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(tipoMonstro)) tipoMonstro = "Orc";

            var monstro = new Monstro(nomeMonstro, tipoMonstro, pontosDeVida: 80, ataque: 15);

            Console.Clear();
            var batalha = new Batalha();
            batalha.IniciarBatalha(heroi, monstro);
        }
    }
}
