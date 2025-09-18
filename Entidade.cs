using System;

namespace ProjetoRPG
{
    public abstract class Entidade
    {
        public string Nome { get; protected set; }
        public int PontosDeVida { get; protected set; }
        public int Ataque { get; protected set; }

        public bool EstaVivo => PontosDeVida > 0;

        protected Entidade(string nome, int pontosDeVida, int ataque)
        {
            Nome = nome;
            PontosDeVida = pontosDeVida;
            Ataque = ataque;
        }

        public virtual void Atacar(Entidade alvo)
        {
            if (!EstaVivo) return;
            Console.WriteLine($"{Nome} ataca {alvo.Nome} e causa {Ataque} de dano.");
            alvo.ReceberDano(Ataque);
        }

        public virtual void ReceberDano(int dano)
        {
            PontosDeVida -= dano;
            if (PontosDeVida < 0) PontosDeVida = 0;
            Console.WriteLine($"{Nome} recebeu {dano} de dano. (HP: {PontosDeVida})");
        }
    }
}
