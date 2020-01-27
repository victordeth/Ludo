using Ludo.Model;
using System.Collections.Generic;

namespace Ludo.Infraestrutura
{
    public class Posicoes
    {
        // tabuleiro setado na posicao 17 x 8 

        public List<Eixo> PosicoesArea { get; set; }

        public Posicoes()
        {
            PosicoesArea = new List<Eixo>();

            PosicaoAmarela();
            PosicaoAzul();
            PosicaoVermelha();
            PosicaoVerde();
        }

        private void PosicaoAzul()
        {
            // casa peao inicio 
            PosicoesArea.Add(new Eixo { PosicaoAzul = 0.1, X = 177, Y = 87, Protegida = true, Casa = true, CorPermitida = Cores.Azul });
            PosicoesArea.Add(new Eixo { PosicaoAzul = 0.2, X = 282, Y = 87, Protegida = true, Casa = true, CorPermitida = Cores.Azul });
            PosicoesArea.Add(new Eixo { PosicaoAzul = 0.3, X = 177, Y = 172, Protegida = true, Casa = true, CorPermitida = Cores.Azul });
            PosicoesArea.Add(new Eixo { PosicaoAzul = 0.4, X = 282, Y = 172, Protegida = true, Casa = true, CorPermitida = Cores.Azul });
            // fim 

            // Inicio casa Azul 
            PosicoesArea.Add(new Eixo { PosicaoVerde = 27, PosicaoVermelho = 40, PosicaoAzul = 1, PosicaoAmarelo = 14, X = 183, Y = 266, Protegida = true });
            PosicoesArea.Add(new Eixo { PosicaoVerde = 28, PosicaoVermelho = 41, PosicaoAzul = 2, PosicaoAmarelo = 15, X = 220, Y = 266 });
            PosicoesArea.Add(new Eixo { PosicaoVerde = 29, PosicaoVermelho = 42, PosicaoAzul = 3, PosicaoAmarelo = 16, X = 257, Y = 266 });
            PosicoesArea.Add(new Eixo { PosicaoVerde = 30, PosicaoVermelho = 43, PosicaoAzul = 4, PosicaoAmarelo = 17, X = 294, Y = 266 });
            PosicoesArea.Add(new Eixo { PosicaoVerde = 31, PosicaoVermelho = 44, PosicaoAzul = 5, PosicaoAmarelo = 18, X = 330, Y = 266 });
            // fim casa azul

            PosicoesArea.Add(new Eixo { PosicaoVerde = 32, PosicaoVermelho = 45, PosicaoAzul = 6, PosicaoAmarelo = 19, X = 366, Y = 229 });
            PosicoesArea.Add(new Eixo { PosicaoVerde = 33, PosicaoVermelho = 46, PosicaoAzul = 7, PosicaoAmarelo = 20, X = 366, Y = 192 });
            PosicoesArea.Add(new Eixo { PosicaoVerde = 34, PosicaoVermelho = 47, PosicaoAzul = 8, PosicaoAmarelo = 21, X = 366, Y = 155 });
            PosicoesArea.Add(new Eixo { PosicaoVerde = 35, PosicaoVermelho = 48, PosicaoAzul = 9, PosicaoAmarelo = 22, X = 366, Y = 118, Protegida = true });
            PosicoesArea.Add(new Eixo { PosicaoVerde = 36, PosicaoVermelho = 49, PosicaoAzul = 10, PosicaoAmarelo = 23, X = 366, Y = 81 });

            PosicoesArea.Add(new Eixo { PosicaoVerde = 37, PosicaoVermelho = 50, PosicaoAzul = 11, PosicaoAmarelo = 24, X = 366, Y = 45 });
            PosicoesArea.Add(new Eixo { PosicaoVerde = 38, PosicaoVermelho = 51, PosicaoAzul = 12, PosicaoAmarelo = 25, X = 403, Y = 45 });

            // garagem Vermelha 

            PosicoesArea.Add(new Eixo { PosicaoVermelho = 52, X = 403, Y = 81, CorPermitida = Cores.Vermelho });
            PosicoesArea.Add(new Eixo { PosicaoVermelho = 53, X = 403, Y = 118, CorPermitida = Cores.Vermelho });
            PosicoesArea.Add(new Eixo { PosicaoVermelho = 54, X = 403, Y = 155, CorPermitida = Cores.Vermelho });
            PosicoesArea.Add(new Eixo { PosicaoVermelho = 55, X = 403, Y = 192, CorPermitida = Cores.Vermelho });
            PosicoesArea.Add(new Eixo { PosicaoVermelho = 56, X = 403, Y = 229, CorPermitida = Cores.Vermelho });
            PosicoesArea.Add(new Eixo { PosicaoVermelho = 57, X = 403, Y = 265, CorPermitida = Cores.Vermelho });

            // Fim 

            PosicoesArea.Add(new Eixo { PosicaoVerde = 39, PosicaoAzul = 13, PosicaoAmarelo = 26, X = 435, Y = 45, CorProibida = Cores.Vermelho });
        }

        private void PosicaoAmarela()
        {


            // casa peao inicio 
            PosicoesArea.Add(new Eixo { PosicaoAmarelo = 0.1, X = 177, Y = 429, Protegida = true, Casa = true, CorPermitida = Cores.Amarelo });
            PosicoesArea.Add(new Eixo { PosicaoAmarelo = 0.2, X = 282, Y = 429, Protegida = true, Casa = true, CorPermitida = Cores.Amarelo });
            PosicoesArea.Add(new Eixo { PosicaoAmarelo = 0.3, X = 177, Y = 516, Protegida = true, Casa = true, CorPermitida = Cores.Amarelo });
            PosicoesArea.Add(new Eixo { PosicaoAmarelo = 0.4, X = 282, Y = 516, Protegida = true, Casa = true, CorPermitida = Cores.Amarelo });
            // fim 


            // inicio casa amarela do mapa 

            PosicoesArea.Add(new Eixo { PosicaoVerde = 14, PosicaoVermelho = 27, PosicaoAzul = 40, PosicaoAmarelo = 1, X = 367, Y = 521, Protegida = true });
            PosicoesArea.Add(new Eixo { PosicaoVerde = 15, PosicaoVermelho = 28, PosicaoAzul = 41, PosicaoAmarelo = 2, X = 367, Y = 484 });
            PosicoesArea.Add(new Eixo { PosicaoVerde = 16, PosicaoVermelho = 29, PosicaoAzul = 42, PosicaoAmarelo = 3, X = 367, Y = 447 });
            PosicoesArea.Add(new Eixo { PosicaoVerde = 17, PosicaoVermelho = 30, PosicaoAzul = 43, PosicaoAmarelo = 4, X = 367, Y = 410 });
            PosicoesArea.Add(new Eixo { PosicaoVerde = 18, PosicaoVermelho = 31, PosicaoAzul = 44, PosicaoAmarelo = 5, X = 367, Y = 373 });

            PosicoesArea.Add(new Eixo { PosicaoVerde = 19, PosicaoVermelho = 32, PosicaoAzul = 45, PosicaoAmarelo = 6, X = 330, Y = 337 });
            PosicoesArea.Add(new Eixo { PosicaoVerde = 20, PosicaoVermelho = 33, PosicaoAzul = 46, PosicaoAmarelo = 7, X = 294, Y = 337 });
            PosicoesArea.Add(new Eixo { PosicaoVerde = 21, PosicaoVermelho = 34, PosicaoAzul = 47, PosicaoAmarelo = 8, X = 257, Y = 337 });
            PosicoesArea.Add(new Eixo { PosicaoVerde = 22, PosicaoVermelho = 35, PosicaoAzul = 48, PosicaoAmarelo = 9, X = 219, Y = 337, Protegida = true });
            PosicoesArea.Add(new Eixo { PosicaoVerde = 23, PosicaoVermelho = 36, PosicaoAzul = 49, PosicaoAmarelo = 10, X = 182, Y = 337 });
            PosicoesArea.Add(new Eixo { PosicaoVerde = 24, PosicaoVermelho = 37, PosicaoAzul = 50, PosicaoAmarelo = 11, X = 145, Y = 337 });
            PosicoesArea.Add(new Eixo { PosicaoVerde = 25, PosicaoVermelho = 38, PosicaoAzul = 51, PosicaoAmarelo = 12, X = 145, Y = 302 });

            // garagem Azul            Posicao = 1,

            PosicoesArea.Add(new Eixo { PosicaoAzul = 52, X = 183, Y = 302, CorPermitida = Cores.Azul });
            PosicoesArea.Add(new Eixo { PosicaoAzul = 53, X = 220, Y = 302, CorPermitida = Cores.Azul });
            PosicoesArea.Add(new Eixo { PosicaoAzul = 54, X = 257, Y = 302, CorPermitida = Cores.Azul });
            PosicoesArea.Add(new Eixo { PosicaoAzul = 55, X = 294, Y = 302, CorPermitida = Cores.Azul });
            PosicoesArea.Add(new Eixo { PosicaoAzul = 56, X = 330, Y = 302, CorPermitida = Cores.Azul });
            PosicoesArea.Add(new Eixo { PosicaoAzul = 57, X = 365, Y = 302, CorPermitida = Cores.Azul });

            // Fim                     Posicao = 1,

            PosicoesArea.Add(new Eixo { PosicaoVerde = 26, PosicaoVermelho = 39, PosicaoAmarelo = 13, X = 145, Y = 266, CorProibida = Cores.Azul });
        }

        private void PosicaoVermelha()
        {
            // casa peao inicio 
            PosicoesArea.Add(new Eixo { PosicaoVermelho = 0.1, X = 519, Y = 87, Protegida = true, Casa = true, CorPermitida = Cores.Vermelho });
            PosicoesArea.Add(new Eixo { PosicaoVermelho = 0.2, X = 625, Y = 87, Protegida = true, Casa = true, CorPermitida = Cores.Vermelho });
            PosicoesArea.Add(new Eixo { PosicaoVermelho = 0.3, X = 520, Y = 172, Protegida = true, Casa = true, CorPermitida = Cores.Vermelho });
            PosicoesArea.Add(new Eixo { PosicaoVermelho = 0.4, X = 625, Y = 172, Protegida = true, Casa = true, CorPermitida = Cores.Vermelho });
            // fim 

            // Inicio casa Vermelha 
            PosicoesArea.Add(new Eixo { PosicaoVerde = 40, PosicaoVermelho = 1, PosicaoAzul = 14, PosicaoAmarelo = 27, X = 437, Y = 82, Protegida = true });
            PosicoesArea.Add(new Eixo { PosicaoVerde = 41, PosicaoVermelho = 2, PosicaoAzul = 15, PosicaoAmarelo = 28, X = 437, Y = 119 });
            PosicoesArea.Add(new Eixo { PosicaoVerde = 42, PosicaoVermelho = 3, PosicaoAzul = 16, PosicaoAmarelo = 29, X = 437, Y = 156 });
            PosicoesArea.Add(new Eixo { PosicaoVerde = 43, PosicaoVermelho = 4, PosicaoAzul = 17, PosicaoAmarelo = 30, X = 437, Y = 193 });
            PosicoesArea.Add(new Eixo { PosicaoVerde = 44, PosicaoVermelho = 5, PosicaoAzul = 18, PosicaoAmarelo = 31, X = 437, Y = 230 });

            PosicoesArea.Add(new Eixo { PosicaoVerde = 45, PosicaoVermelho = 6, PosicaoAzul = 19, PosicaoAmarelo = 32, X = 473, Y = 265 });
            PosicoesArea.Add(new Eixo { PosicaoVerde = 46, PosicaoVermelho = 7, PosicaoAzul = 20, PosicaoAmarelo = 33, X = 510, Y = 265 });
            PosicoesArea.Add(new Eixo { PosicaoVerde = 47, PosicaoVermelho = 8, PosicaoAzul = 21, PosicaoAmarelo = 34, X = 547, Y = 265 });
            PosicoesArea.Add(new Eixo { PosicaoVerde = 48, PosicaoVermelho = 9, PosicaoAzul = 22, PosicaoAmarelo = 35, X = 584, Y = 265, Protegida = true });
            PosicoesArea.Add(new Eixo { PosicaoVerde = 49, PosicaoVermelho = 10, PosicaoAzul = 23, PosicaoAmarelo = 36, X = 621, Y = 265 });

            PosicoesArea.Add(new Eixo { PosicaoVerde = 50, PosicaoVermelho = 11, PosicaoAzul = 24, PosicaoAmarelo = 37, X = 658, Y = 265 });
            PosicoesArea.Add(new Eixo { PosicaoVerde = 51, PosicaoVermelho = 12, PosicaoAzul = 25, PosicaoAmarelo = 38, X = 658, Y = 301 });

            // garagem Verde 

            PosicoesArea.Add(new Eixo { PosicaoVerde = 52, X = 621, Y = 301, CorPermitida = Cores.Verde });
            PosicoesArea.Add(new Eixo { PosicaoVerde = 53, X = 584, Y = 301, CorPermitida = Cores.Verde });
            PosicoesArea.Add(new Eixo { PosicaoVerde = 54, X = 547, Y = 301, CorPermitida = Cores.Verde });
            PosicoesArea.Add(new Eixo { PosicaoVerde = 55, X = 510, Y = 301, CorPermitida = Cores.Verde });
            PosicoesArea.Add(new Eixo { PosicaoVerde = 56, X = 473, Y = 301, CorPermitida = Cores.Verde });
            PosicoesArea.Add(new Eixo { PosicaoVerde = 57, X = 436, Y = 301, CorPermitida = Cores.Verde });

            // Fim 

            PosicoesArea.Add(new Eixo { PosicaoVermelho = 13, PosicaoAzul = 26, PosicaoAmarelo = 39, X = 658, Y = 336, CorProibida = Cores.Verde });
        }

        private void PosicaoVerde()
        {
            // casa peao inicio 
            PosicoesArea.Add(new Eixo { PosicaoVerde = 0.1, X = 519, Y = 431, Protegida = true, Casa = true, CorPermitida = Cores.Verde });
            PosicoesArea.Add(new Eixo { PosicaoVerde = 0.2, X = 625, Y = 431, Protegida = true, Casa = true, CorPermitida = Cores.Verde });
            PosicoesArea.Add(new Eixo { PosicaoVerde = 0.3, X = 520, Y = 516, Protegida = true, Casa = true, CorPermitida = Cores.Verde });
            PosicoesArea.Add(new Eixo { PosicaoVerde = 0.4, X = 625, Y = 516, Protegida = true, Casa = true, CorPermitida = Cores.Verde });
            // fim 

            // Inicio casa verde 
            PosicoesArea.Add(new Eixo { PosicaoVerde = 1, PosicaoVermelho = 14, PosicaoAzul = 27, PosicaoAmarelo = 40, X = 621, Y = 336, Protegida = true });
            PosicoesArea.Add(new Eixo { PosicaoVerde = 2, PosicaoVermelho = 15, PosicaoAzul = 28, PosicaoAmarelo = 41, X = 584, Y = 336 });
            PosicoesArea.Add(new Eixo { PosicaoVerde = 3, PosicaoVermelho = 16, PosicaoAzul = 29, PosicaoAmarelo = 42, X = 547, Y = 336 });
            PosicoesArea.Add(new Eixo { PosicaoVerde = 4, PosicaoVermelho = 17, PosicaoAzul = 30, PosicaoAmarelo = 43, X = 510, Y = 336 });
            PosicoesArea.Add(new Eixo { PosicaoVerde = 5, PosicaoVermelho = 18, PosicaoAzul = 31, PosicaoAmarelo = 44, X = 473, Y = 336 });

            PosicoesArea.Add(new Eixo { PosicaoVerde = 6, PosicaoVermelho = 19, PosicaoAzul = 32, PosicaoAmarelo = 45, X = 438, Y = 374 });
            PosicoesArea.Add(new Eixo { PosicaoVerde = 7, PosicaoVermelho = 20, PosicaoAzul = 33, PosicaoAmarelo = 46, X = 438, Y = 411 });
            PosicoesArea.Add(new Eixo { PosicaoVerde = 8, PosicaoVermelho = 21, PosicaoAzul = 34, PosicaoAmarelo = 47, X = 438, Y = 448 });
            PosicoesArea.Add(new Eixo { PosicaoVerde = 9, PosicaoVermelho = 22, PosicaoAzul = 35, PosicaoAmarelo = 48, X = 438, Y = 485, Protegida = true });
            PosicoesArea.Add(new Eixo { PosicaoVerde = 10, PosicaoVermelho = 23, PosicaoAzul = 36, PosicaoAmarelo = 49, X = 438, Y = 522 });

            PosicoesArea.Add(new Eixo { PosicaoVerde = 11, PosicaoVermelho = 24, PosicaoAzul = 37, PosicaoAmarelo = 50, X = 438, Y = 559 });
            PosicoesArea.Add(new Eixo { PosicaoVerde = 12, PosicaoVermelho = 25, PosicaoAzul = 38, PosicaoAmarelo = 51, X = 402, Y = 559 });

            // garagem Amarelo 

            PosicoesArea.Add(new Eixo { PosicaoAmarelo = 52, X = 402, Y = 522, CorPermitida = Cores.Amarelo });
            PosicoesArea.Add(new Eixo { PosicaoAmarelo = 53, X = 402, Y = 485, CorPermitida = Cores.Amarelo });
            PosicoesArea.Add(new Eixo { PosicaoAmarelo = 54, X = 402, Y = 448, CorPermitida = Cores.Amarelo });
            PosicoesArea.Add(new Eixo { PosicaoAmarelo = 55, X = 402, Y = 411, CorPermitida = Cores.Amarelo });
            PosicoesArea.Add(new Eixo { PosicaoAmarelo = 56, X = 402, Y = 374, CorPermitida = Cores.Amarelo });
            PosicoesArea.Add(new Eixo { PosicaoAmarelo = 57, X = 402, Y = 337, CorPermitida = Cores.Amarelo });

            // Fim 

            PosicoesArea.Add(new Eixo { PosicaoVerde = 13, PosicaoVermelho = 26, PosicaoAzul = 39, X = 365, Y = 559, CorProibida = Cores.Amarelo });
        }
    }

   
}
