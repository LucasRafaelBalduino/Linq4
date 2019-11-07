using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Connect4.Models
{
    public class JogadorMaquinaFacil : IJogadorComputador
    {
        public int CalcularJogada(Tabuleiro tabuleiro)
        {
            int jogada = new Random().Next(Tabuleiro.NUMERO_COLUNAS);

            return jogada;
        }
    }
}
