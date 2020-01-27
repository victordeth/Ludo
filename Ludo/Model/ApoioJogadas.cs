using Ludo.Infraestrutura;
using System.Collections.Generic;

namespace Ludo.Model
{
    public class ApoioJogadas
    {
        public int NumeroX { get; set; } = 0;
        public Cores JogadorAtual { get; set; }
        public bool JaJogou { get; set; } = true;
        public bool MatouAlgum { get; set; } = false;
        public bool GuardouAlgumPeao { get; set; } = false;
        public List<Peao> PeaoNaGaragem { get; set; } = new List<Peao>();
        public bool FimDoJogo { get; set; } = false;
    }
}
