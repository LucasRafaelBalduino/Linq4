using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Connect4.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Connect4.Extensions.Controllers
{
    [Produces("application/json")]
    [Route("api/Jogo")]
    public class JogoAPIController : Controller
    {
        [HttpGet(Name = "Obter")]
        [Route("Obter")]
        public Tabuleiro ObterJogo()
        {
            Tabuleiro t = new Tabuleiro();
            return t;
        }

        [HttpPost(Name = "Vencedor")]
        [Route("Vencedor")]
        public int Vencedor(Tabuleiro t)
        {
            return t.Vencedor();
        }

        [HttpPost(Name = "Jogar")]
        [Route("Jogar")]
        public Tabuleiro Jogar([FromBody]Tabuleiro t, [FromQuery]int jogador,[FromQuery] int Pos)
        {

            t.Jogar(jogador, Pos);

            return t;

        }
    }
}