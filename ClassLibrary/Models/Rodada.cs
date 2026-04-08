using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Models
{
    public class Rodada
    {
        public List<Jogada> Jogadas { get; private set; }
        public int NumeroRodada { get; private set; }
        public Jogador? Vencedor { get; private set; }

        public Rodada(int numeroRodada)
        {
            NumeroRodada = numeroRodada;
            Jogadas = new List<Jogada>();
        }

        public void RegistrarJogada(Jogada jogada)
        {
            Jogadas.Add(jogada);
        }

        public void DeterminarVencedor()
        {
            // Será desenvolvida a lógica para determinar o vencedor da rodada com base nas jogadas registradas
            // Isso vai depender do jogo que será implementado
        }
    }
}
