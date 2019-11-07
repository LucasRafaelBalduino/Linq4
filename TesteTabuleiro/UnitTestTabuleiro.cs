using Connect4.Models;
using System;
using Xunit;

namespace TesteTabuleiro
{
    public class UnitTestTabuleiro
    {
        [Fact]
        public void TestTudoOcupado()
        {

            int[,] valor = new int[7, 6]{
                {0,0,0,0,0,0 },
                {0,0,0,0,0,0  },
                { 0,0,0,0,0,0 },
                { 0,0,0,0,0,0 },
                {0,0,0,0,0,0  },
                {0,0,0,0,0,0  },
                {0,0,0,0,0,0  },
                };
            Tabuleiro t = new Tabuleiro(valor);
            Assert.False(t.isTudoOcupado());
            valor = new int[7, 6]{
                {1,2,1,1,2,1 },
                {1,2,1,1,2,1 },
                {2,1,2,2,1,2 },
                {2,1,2,2,1,2 },
                {1,2,1,1,2,1 },
                {1,2,1,1,2,1 },
                {2,1,2,2,1,2 },
                };
            t = new Tabuleiro(valor);
            Assert.True(t.isTudoOcupado());

        }

        [Fact]
        public void TestVencedorColuna()
        {
            int[,] valor = new int[7, 6]{
                {0,0,0,0,0,0 },
                {0,0,0,0,0,0  },
                { 0,0,0,0,0,0 },
                { 0,0,0,0,0,0 },
                {0,0,0,0,0,0  },
                {0,0,0,0,0,0  },
                {0,0,0,0,0,0  },
                };
            Tabuleiro t = new Tabuleiro(valor);
            Assert.Equal(0, t.VerificarVencedorColuna());
            valor = new int[7, 6]{
                {1,2,1,1,2,1 },
                {1,2,1,1,2,1 },
                {2,1,2,2,1,2 },
                {2,1,2,2,1,2 },
                {1,2,1,1,2,1 },
                {1,2,1,1,1,1 },
                {2,1,2,2,1,2 },
                };
            t = new Tabuleiro(valor);
            Assert.Equal(1, t.VerificarVencedorColuna());


            valor = new int[7, 6]{
                {1,2,1,1,2,1 },
                {1,2,1,1,2,1 },
                {2,1,2,2,1,2 },
                {2,1,2,2,1,2 },
                {1,2,1,1,2,1 },
                {1,2,1,2,1,1 },
                {2,2,2,2,1,2 },
                };
            t = new Tabuleiro(valor);
            Assert.Equal(2, t.VerificarVencedorColuna());

            valor = new int[7, 6]{
                {1,1,1,1,2,1 },
                {1,2,1,1,2,1 },
                {2,1,2,2,1,2 },
                {2,1,2,2,1,2 },
                {1,2,1,1,2,1 },
                {1,2,1,2,1,1 },
                {2,2,1,2,1,2 },
                };
            t = new Tabuleiro(valor);
            Assert.Equal(1, t.VerificarVencedorColuna());
        }



        [Fact]
        public void TestVencedorLinha()
        {
            int[,] valor = new int[7, 6]{
                {0,0,0,0,0,0 },
                {0,0,0,0,0,0  },
                { 0,0,0,0,0,0 },
                { 0,0,0,0,0,0 },
                {0,0,0,0,0,0  },
                {0,0,0,0,0,0  },
                {0,0,0,0,0,0  },
                };
            Tabuleiro t = new Tabuleiro(valor);
            Assert.Equal(0, t.VerificarVencedorLinha());
            valor = new int[7, 6]{
                {1,2,1,1,2,1 },
                {1,2,1,1,2,1 },
                {1,1,2,2,1,2 },
                {1,1,2,2,1,2 },
                {2,2,1,1,2,1 },
                {1,2,1,1,1,1 },
                {2,1,2,2,1,2 },
                };
            t = new Tabuleiro(valor);
            Assert.Equal(1, t.VerificarVencedorLinha());
            valor = new int[7, 6]{
                {1,2,1,1,2,1 },
                {1,2,1,2,1,1 },
                {2,1,2,2,1,2 },
                {1,1,2,2,1,1 },
                {2,2,1,1,2,1 },
                {1,2,1,1,1,1 },
                {2,1,2,2,1,1 },
                };
            t = new Tabuleiro(valor);
            Assert.Equal(1, t.VerificarVencedorLinha());
        }


        [Fact]
        public void TestVerificarVencedorDiagonal()
        {
            int[,] valor = new int[7, 6]{
                {0,0,0,0,0,0 },
                {0,0,0,0,0,0  },
                { 0,0,0,0,0,0 },
                { 0,0,0,0,0,0 },
                {0,0,0,0,0,0  },
                {0,0,0,0,0,0  },
                {0,0,0,0,0,0  },
                };
            Tabuleiro t = new Tabuleiro(valor);
            Assert.Equal(0, t.VerificarVencedorDiagonal());
            valor = new int[7, 6]{
                {1,0,0,0,0,0},
                {1,0,0,0,0,0},
                {2,0,0,0,0,0},
                {1,2,0,0,0,0},
                {2,1,2,0,0,0},
                {1,1,2,2,0,0},
                {1,1,2,0,0,0},
                };
            t = new Tabuleiro(valor);
            Assert.Equal(2, t.VerificarVencedorDiagonal());
            //Existe um vencedor na diagnoal. Posicao [4,0] até [1,3]
            valor = new int[7, 6]{
                {1,0,0,0,0,0},
                {1,1,2,2,0,0},
                {2,1,2,0,0,0},
                {1,2,0,0,0,0},
                {2,1,1,0,0,0},
                {1,1,2,2,0,0},
                {1,1,2,0,0,0},
                };
            t = new Tabuleiro(valor);
            Assert.Equal(2, t.VerificarVencedorDiagonal());
            //Existe um vencedor na diagnoal. Posicao [0,0] até [3,3]
            valor = new int[7, 6]{
                {1,0,0,0,0,0},
                {1,1,2,2,0,0},
                {1,1,1,0,0,0},
                {2,2,2,1,0,0},
                {2,1,2,0,0,0},
                {1,1,1,2,0,0},
                {1,1,2,0,0,0},
                };
            t = new Tabuleiro(valor);
            Assert.Equal(1, t.VerificarVencedorDiagonal());
            //Não existe vencedor na diagonal.
            valor = new int[7, 6]{
                {1,0,0,0,0,0},
                {1,1,2,2,0,0},
                {2,1,2,0,0,0},
                {1,2,2,1,0,0},
                {2,1,2,0,0,0},
                {1,1,1,1,0,0},
                {1,1,2,0,0,0},
                };
            t = new Tabuleiro(valor);
            Assert.Equal(0, t.VerificarVencedorDiagonal());
            //Existe um vencedor na diagonal.
            //Posição [6,1] até Posição [3,4]
            valor = new int[7, 6]{
                {1,0,0,0,0,0},
                {1,1,2,1,0,0},
                {2,1,2,0,0,0},
                {1,2,2,1,1,0},
                {2,1,2,1,0,0},
                {2,1,1,1,0,0},
                {1,1,2,0,0,0},
                };
            t = new Tabuleiro(valor);
            Assert.Equal(0, t.VerificarVencedorDiagonal());
        }
    }
}
