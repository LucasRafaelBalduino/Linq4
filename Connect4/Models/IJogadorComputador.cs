using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Connect4.Models
{
    interface IJogadorComputador
    {
        int CalcularJogada(Tabuleiro tabuleiro);
    }
}
