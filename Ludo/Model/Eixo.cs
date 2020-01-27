using Ludo.Infraestrutura;
using System.Collections.Generic;

namespace Ludo.Model
{
    public class Eixo
    {
        public double PosicaoAmarelo { get; set; }
        public double PosicaoAzul { get; set; }
        public double PosicaoVerde { get; set; }
        public double PosicaoVermelho { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public bool Protegida { get; set; } = false;
        public Cores CorProibida { get; set; }
        public Cores CorPermitida { get; set; }
        public List<Peao> CorEstacionada { get; set; } = new List<Peao>();
        public bool Casa { get; set; }
    }
}
