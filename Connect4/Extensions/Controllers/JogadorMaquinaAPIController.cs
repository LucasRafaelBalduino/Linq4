using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Connect4.Models;
using Microsoft.AspNetCore.Http;
using Connect4.Extensions.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace Connect4.Extensions.Controllers
{
    [Produces("application/json")]
    [Route("api/JogadorMaquina")]
    public class JogadorMaquinaAPIController : Controller
    {
       /* [HttpGet(Name ="Obter")]
        [Route("Obter")]
        public Tabuleiro ObterJogo()
        {
            Tabuleiro t = new Tabuleiro();
            return t;
        }*/

        [HttpPost(Name = "Calcular")]
        [Route("Calcular")]
        public int CalcularJogada(Tabuleiro tabuleiro)
        {
            IJogadorComputador computador = new JogadorMaquinaFacil();
            return computador.CalcularJogada(tabuleiro);

        }
    }
}