using Ludo.Infraestrutura;
using System;

namespace Ludo.Model
{
    public class Jogadas
    {
        public DateTime DataHora { get; set; }
        public int NumeroSorte { get; set; }
        public double CasaAnterior { get; set; }
        public Cores cores { get; set; }
        public double peao { get; set; }
        public Acao acao { get; set; }
    }
}
