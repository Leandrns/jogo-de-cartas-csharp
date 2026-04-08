using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Models
{
    public class Carta
    {
        public string Valor { get; private set; } // Futuro: Pode ser um enum para valores como Ás, 2, 3, ..., Rei (se for um baralho convencional)
        public string Tipo { get; private set; } // Futuro: Pode ser um enum para tipos como Copas, Ouros, Paus, Espadas (se for um baralho convencional)
        public bool IsVisivel { get; private set; } // Indica se a carta está virada para cima (visível) ou para baixo (oculta)

        public Carta(string valor, string tipo, bool isVisivel = false)
        {
            Valor = valor;
            Tipo = tipo;
            IsVisivel = isVisivel;
        }

        public void VirarCarta()
        {
            IsVisivel = !IsVisivel; // Alterna o estado de visibilidade da carta
        }
    }
}
