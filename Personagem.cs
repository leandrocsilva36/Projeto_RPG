using System;

namespace ProjetoRPG
{
    public class Personagem : Entidade
    {
        public string Classe { get; private set; }
        private int curaValor;
        private int vidaMaxima;

        public Personagem(string nome, string classe, int pontosDeVida, int ataque, int curaValor) 
            : base(nome, pontosDeVida, ataque)
        {
            Classe = classe;
            this.curaValor = curaValor;
            vidaMaxima = pontosDeVida;
        }

        public void Curar()
        {
            if (!EstaVivo) return;
            int curaReal = Math.Min(curaValor, vidaMaxima - PontosDeVida);
            PontosDeVida += curaReal;
            Console.WriteLine($"{Nome} usa Curar e recupera {curaReal} pontos de vida. (HP: {PontosDeVida})");
        }
    }
}
