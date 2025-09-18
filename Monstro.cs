using System;

namespace ProjetoRPG
{
    public class Monstro : Entidade
    {
        public string Tipo { get; private set; }

        public Monstro(string nome, string tipo, int pontosDeVida, int ataque)
            : base(nome, pontosDeVida, ataque)
        {
            Tipo = tipo;
        }

        public override void ReceberDano(int dano)
        {
            base.ReceberDano(dano);
            if (EstaVivo)
            {
                Console.WriteLine($"O {Tipo} " + Nome + " rosna de dor!\n");
            }
            else
            {
                Console.WriteLine($"O {Tipo} " + Nome + " caiu derrotado!\n");
            }
        }
    }
}
