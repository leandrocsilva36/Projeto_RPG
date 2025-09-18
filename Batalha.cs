using System;

namespace ProjetoRPG
{
    public class Batalha
    {
        public void IniciarBatalha(Personagem heroi, Monstro monstro)
        {
            Console.WriteLine("Iniciando batalha...\n");
            Console.WriteLine($"{heroi.Nome} (Classe: {heroi.Classe}) vs {monstro.Nome} (Tipo: {monstro.Tipo})\n");

            var atacanteHeroi = true;

            while (heroi.EstaVivo && monstro.EstaVivo)
            {
                if (atacanteHeroi)
                {
                    ExibirStatus(heroi, monstro);
                    Console.WriteLine("Escolha uma ação:\n1 - Atacar\n2 - Curar");
                    Console.Write("Opção: ");
                    string opcao = Console.ReadLine();

                    if (opcao == "2")
                    {
                        heroi.Curar();
                    }
                    else
                    {
                        heroi.Atacar(monstro);
                    }
                }
                else
                {
                    // Turno do monstro
                    monstro.Atacar(heroi);
                }

                System.Threading.Thread.Sleep(800);
                atacanteHeroi = !atacanteHeroi;
            }

            // Resultado final
            if (heroi.EstaVivo)
            {
                Console.WriteLine($"Parabéns! {heroi.Nome} venceu a batalha!\n");
            }
            else
            {
                Console.WriteLine($"Derrota... {monstro.Nome} venceu a batalha.\n");
            }

            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }

        private void ExibirStatus(Personagem heroi, Monstro monstro)
        {
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine($"{heroi.Nome} - HP: {heroi.PontosDeVida} | Ataque: {heroi.Ataque}");
            Console.WriteLine($"{monstro.Nome} - HP: {monstro.PontosDeVida} | Ataque: {monstro.Ataque}");
            Console.WriteLine("--------------------------------------------------\n");
        }
    }
}
