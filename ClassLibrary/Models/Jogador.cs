using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Models
{
    public class Jogador
    {
        public string Nome { get; private set; }
        public Estatisticas Estatisticas { get; private set; } = new Estatisticas();
        public Mao Mao { get; private set; }

        public void GerarMaoAleatoria(List<Carta> cartasDisponiveis, int quantidadeCartas)
        {
            var random = new Random();
            var maoCartas = new List<Carta>();
            for (int i = 0; i < quantidadeCartas; i++)
            {
                if (cartasDisponiveis.Count == 0)
                    break;
                int index = random.Next(cartasDisponiveis.Count);
                maoCartas.Add(cartasDisponiveis[index]);
                cartasDisponiveis.RemoveAt(index); // Remove a carta para evitar duplicatas
            }
            Mao = new Mao(maoCartas);
        }

        public Jogada RealizarJogada(Carta cartaEscolhida)
        {
            Jogada jogada = new Jogada(this, cartaEscolhida);
            Mao.RemoverCarta(cartaEscolhida);
            return jogada;
        }
    }
}
