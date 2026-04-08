using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Models
{
    public class Mao(List<Carta> cartas)
    {
        public List<Carta> Cartas { get; private set; } = cartas;
        public int QuantidadeInicialCartas { get; private set; } = cartas.Count;

        public int ObterQuantidadeCartas()
        {
            return Cartas.Count;
        }

        public void RemoverCarta(Carta cartaEscolhida)
        {
            Cartas.Remove(cartaEscolhida);
        }
    }
}
