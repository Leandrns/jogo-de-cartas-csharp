using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Models
{
    public class Estatisticas
    {
        public int Vitorias { get; private set; }
        public int Derrotas { get; private set; }
        public int Empates { get; private set; }

        public void RegistrarVitoria()
        {
            Vitorias++;
        }

        public void RegistrarDerrota()
        {
            Derrotas++;
        }

        public void RegistrarEmpate()
        {
            Empates++;
        }

        public override string ToString()
        {
            return $"Vitórias: {Vitorias}, Derrotas: {Derrotas}, Empates: {Empates}";
        }
    }
}
