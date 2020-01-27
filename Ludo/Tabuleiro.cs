using Ludo.Infraestrutura;
using Ludo.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace Ludo
{
    public partial class Tabuleiro : Form
    {
        #region Objetos

        public ApoioJogadas ApoioJogadas { get; set; }

        List<Jogadas> jogadas;
        List<Peao> Jogadores;

        Posicoes posicoes;

        Peao PeaoAzul1;
        Peao PeaoAzul2;
        Peao PeaoAzul3;
        Peao PeaoAzul4;

        Peao PeaoVerde1;
        Peao PeaoVerde2;
        Peao PeaoVerde3;
        Peao PeaoVerde4;

        Peao PeaoAmarelo1;
        Peao PeaoAmarelo2;
        Peao PeaoAmarelo3;
        Peao PeaoAmarelo4;

        Peao PeaoVermelho1;
        Peao PeaoVermelho2;
        Peao PeaoVermelho3;
        Peao PeaoVermelho4;

        public int NumeroSorte { get; set; }
        public double CasaAnterior { get; set; }
        public Cores CorAnterior { get; set; }

        #endregion

        #region Construtor

        public Tabuleiro()
        {
            // tabuleiro setado na posicao 17 x 8 

            InitializeComponent();
            SetaInicio();
        }
        #endregion

        #region Metodos Jogo

        private void SetaInicio()
        {
            jogadas = new List<Jogadas>();
            Jogadores = new List<Peao>();
            dgJogadas.DataSource = jogadas;
            posicoes = new Posicoes();
            ApoioJogadas = new ApoioJogadas();
            CriaPeao();
            DesabilitaPeos();
            DesabilitaJogadores();
            // seto o primeiro a jogar 
            BoxAmarelo.Enabled = true;
        }

        private void CriaPeao()
        {

            //azul 
            PeaoAzul1 = new Peao { Cor = Cores.Azul, Numero = 0.1, pictureBox = BonecoAzul1 };
            PeaoAzul2 = new Peao { Cor = Cores.Azul, Numero = 0.2, pictureBox = BonecoAzul2 };
            PeaoAzul3 = new Peao { Cor = Cores.Azul, Numero = 0.3, pictureBox = BonecoAzul3 };
            PeaoAzul4 = new Peao { Cor = Cores.Azul, Numero = 0.4, pictureBox = BonecoAzul4 };

            SetaPeaoInicio(PeaoAzul1);
            SetaPeaoInicio(PeaoAzul2);
            SetaPeaoInicio(PeaoAzul3);
            SetaPeaoInicio(PeaoAzul4);

            Jogadores.Add(PeaoAzul1);
            Jogadores.Add(PeaoAzul2);
            Jogadores.Add(PeaoAzul3);
            Jogadores.Add(PeaoAzul4);

            // amarelo 
            PeaoAmarelo1 = new Peao { Cor = Cores.Amarelo, Numero = 0.1, pictureBox = BonecoAmarelo1 };
            PeaoAmarelo2 = new Peao { Cor = Cores.Amarelo, Numero = 0.2, pictureBox = BonecoAmarelo2 };
            PeaoAmarelo3 = new Peao { Cor = Cores.Amarelo, Numero = 0.3, pictureBox = BonecoAmarelo3 };
            PeaoAmarelo4 = new Peao { Cor = Cores.Amarelo, Numero = 0.4, pictureBox = BonecoAmarelo4 };

            SetaPeaoInicio(PeaoAmarelo1);
            SetaPeaoInicio(PeaoAmarelo2);
            SetaPeaoInicio(PeaoAmarelo3);
            SetaPeaoInicio(PeaoAmarelo4);

            Jogadores.Add(PeaoAmarelo1);
            Jogadores.Add(PeaoAmarelo2);
            Jogadores.Add(PeaoAmarelo3);
            Jogadores.Add(PeaoAmarelo4);


            // verde
            PeaoVerde1 = new Peao { Cor = Cores.Verde, Numero = 0.1, pictureBox = BonecoVerde1 };
            PeaoVerde2 = new Peao { Cor = Cores.Verde, Numero = 0.2, pictureBox = BonecoVerde2 };
            PeaoVerde3 = new Peao { Cor = Cores.Verde, Numero = 0.3, pictureBox = BonecoVerde3 };
            PeaoVerde4 = new Peao { Cor = Cores.Verde, Numero = 0.4, pictureBox = BonecoVerde4 };

            SetaPeaoInicio(PeaoVerde1);
            SetaPeaoInicio(PeaoVerde2);
            SetaPeaoInicio(PeaoVerde3);
            SetaPeaoInicio(PeaoVerde4);

            Jogadores.Add(PeaoVerde1);
            Jogadores.Add(PeaoVerde2);
            Jogadores.Add(PeaoVerde3);
            Jogadores.Add(PeaoVerde4);

            // vermelho 
            PeaoVermelho1 = new Peao { Cor = Cores.Vermelho, Numero = 0.1, pictureBox = BonecoVermelho1 };
            PeaoVermelho2 = new Peao { Cor = Cores.Vermelho, Numero = 0.2, pictureBox = BonecoVermelho2 };
            PeaoVermelho3 = new Peao { Cor = Cores.Vermelho, Numero = 0.3, pictureBox = BonecoVermelho3 };
            PeaoVermelho4 = new Peao { Cor = Cores.Vermelho, Numero = 0.4, pictureBox = BonecoVermelho4 };

            SetaPeaoInicio(PeaoVermelho1);
            SetaPeaoInicio(PeaoVermelho2);
            SetaPeaoInicio(PeaoVermelho3);
            SetaPeaoInicio(PeaoVermelho4);

            Jogadores.Add(PeaoVermelho1);
            Jogadores.Add(PeaoVermelho2);
            Jogadores.Add(PeaoVermelho3);
            Jogadores.Add(PeaoVermelho4);

        }

        private int JogarDados()
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 7);
            return randomNumber;
        }

        private void SetaPeaoTabuleiro(Peao peao, int Casas)
        {
            Eixo eixo = null;
            switch (peao.Cor)
            {
                case Cores.Azul:
                    eixo = posicoes.PosicoesArea.Where(x => x.PosicaoAzul.Equals(Casas)).FirstOrDefault();
                    break;
                case Cores.Verde:
                    eixo = posicoes.PosicoesArea.Where(x => x.PosicaoVerde.Equals(Casas)).FirstOrDefault();
                    break;
                case Cores.Amarelo:
                    eixo = posicoes.PosicoesArea.Where(x => x.PosicaoAmarelo.Equals(Casas)).FirstOrDefault();
                    break;
                case Cores.Vermelho:
                    eixo = posicoes.PosicoesArea.Where(x => x.PosicaoVermelho.Equals(Casas)).FirstOrDefault();
                    break;
                default:
                    break;
            }

            if (eixo != null)
            {
                RemovePeaoCasaAnterior(peao);

                eixo.CorEstacionada.Add(peao);
                peao.pictureBox.Location = new Point(eixo.X, eixo.Y);

                MataPeao(eixo, peao);

                ResizePeaoCasa(eixo);

            }

        }

        private void SetaPeaoInicio(Peao peao)
        {
            Eixo eixo = null;
            switch (peao.Cor)
            {
                case Cores.Amarelo:
                    eixo = posicoes.PosicoesArea.Where(x => x.PosicaoAmarelo.Equals(peao.Numero)).FirstOrDefault();
                    break;
                case Cores.Verde:
                    eixo = posicoes.PosicoesArea.Where(x => x.PosicaoVerde.Equals(peao.Numero)).FirstOrDefault();
                    break;
                case Cores.Azul:
                    eixo = posicoes.PosicoesArea.Where(x => x.PosicaoAzul.Equals(peao.Numero)).FirstOrDefault();
                    break;
                case Cores.Vermelho:
                    eixo = posicoes.PosicoesArea.Where(x => x.PosicaoVermelho.Equals(peao.Numero)).FirstOrDefault();

                    break;
                default:
                    break;
            }

            eixo.CorEstacionada.Add(peao);
            peao.pictureBox.Location = new Point(eixo.X, eixo.Y);

        }

        private double VerificaCasaEstacionada(Peao peao)
        {

            List<Eixo> Eixo = posicoes.PosicoesArea;
            Eixo = Eixo.Where(x => x.CorEstacionada.Contains(peao)).ToList();

            double posicao = 0;

            switch (peao.Cor)
            {
                case Cores.Azul:
                    posicao = Eixo[0].PosicaoAzul;
                    break;
                case Cores.Verde:
                    posicao = Eixo[0].PosicaoVerde;
                    break;
                case Cores.Amarelo:
                    posicao = Eixo[0].PosicaoAmarelo;
                    break;
                case Cores.Vermelho:
                    posicao = Eixo[0].PosicaoVermelho;
                    break;
                default:
                    break;
            }

            return posicao;
        }

        private void RemovePeaoCasaAnterior(Peao peos)
        {
            List<Eixo> Eixo = posicoes.PosicoesArea;
            Eixo xxx = Eixo.Where(x => x.CorEstacionada.Count > 0 &&
            x.CorEstacionada.Contains(peos)).FirstOrDefault();

            xxx.CorEstacionada.Remove(peos);

        }

        private void AndarPeao(Peao PeaoEscolhido)
        {
            CasaAnterior = VerificaCasaEstacionada(PeaoEscolhido);
            CorAnterior = PeaoEscolhido.Cor;

            if (CasaAnterior < 1 && NumeroSorte.Equals(6))
            {
                SetaPeaoTabuleiro(PeaoEscolhido, 1);
            }
            else
            {
                if (CasaAnterior < 1)
                    CasaAnterior = 1;

                SetaPeaoTabuleiro(PeaoEscolhido, int.Parse(CasaAnterior.ToString()) + NumeroSorte);

                ResizePeaoCasa(VerificaCasaAnterior(CorAnterior, CasaAnterior));

                if ((int.Parse(CasaAnterior.ToString()) + NumeroSorte).Equals(57))
                {
                    ApoioJogadas.GuardouAlgumPeao = true;
                    jogadas.Add(new Jogadas { CasaAnterior = CasaAnterior, DataHora = DateTime.Now, NumeroSorte = NumeroSorte, cores = PeaoEscolhido.Cor, peao = PeaoEscolhido.Numero, acao = Acao.Guardar });
                }

            }

            dgJogadas.DataSource = null;
            Application.DoEvents();
            Thread.Sleep(20);

            if (!ApoioJogadas.GuardouAlgumPeao.Equals(true))
                jogadas.Add(new Jogadas { CasaAnterior = CasaAnterior, DataHora = DateTime.Now, NumeroSorte = NumeroSorte, cores = PeaoEscolhido.Cor, peao = PeaoEscolhido.Numero, acao = Acao.Andar });

            ApoioJogadas.JaJogou = true;

            dgJogadas.DataSource = jogadas;
            try { dgJogadas.FirstDisplayedScrollingRowIndex = dgJogadas.Rows.Count - 1; } catch (Exception) { }

            DesabilitaPeos();

            if (ApoioJogadas.MatouAlgum.Equals(true))
            {
                ApoioJogadas.MatouAlgum = false;
                ApoioJogadas.NumeroX = 0;
                HabilitaJogadorDaVez(7);
            }
            else if (ApoioJogadas.GuardouAlgumPeao.Equals(true))
            {
                ApoioJogadas.GuardouAlgumPeao = false;
                ApoioJogadas.NumeroX = 0;
                ApoioJogadas.PeaoNaGaragem.Add(PeaoEscolhido);

                // verifico se terminou o game 
                var Ganhador = ApoioJogadas.PeaoNaGaragem.GroupBy(x => x.Cor).Select(
                    s => new Peao { Cor = s.Key, Numero = s.Count() }).ToList().Where(d => d.Numero.Equals(4)).FirstOrDefault();

                if (Ganhador != null)
                {
                    MessageBox.Show("O ganhador foi " + Ganhador.Cor, "Ludo VictorDeth", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    DesabilitaJogadores();
                    ApoioJogadas.FimDoJogo = true;
                    return;
                }

                HabilitaJogadorDaVez(8);

            }
            else
                HabilitaJogadorDaVez(NumeroSorte);


            Application.DoEvents();
            Thread.Sleep(50);
        }

        private void ConfiguraJogarDadosNovamente(Cores CorClicado)
        {
            ApoioJogadas.JogadorAtual = CorClicado;

            if (NumeroSorte.Equals(6) && (ApoioJogadas.NumeroX <= 1))
                ApoioJogadas.NumeroX++;
            else if (NumeroSorte.Equals(6) && (ApoioJogadas.NumeroX.Equals(2)))
            {
                ApoioJogadas.NumeroX = 4;
                ApoioJogadas.JaJogou = true;
                //HabilitaJogadorDaVez(1);
                return;

            }
            else
                ApoioJogadas.NumeroX = 0;
        }

        private void ClicaDados(Cores CorClicado)
        {

            DesabilitaJogadores();
            DesabilitaPeos();

            NumeroSorte = JogarDados();
            Application.DoEvents();

            ConfiguraJogarDadosNovamente(CorClicado);

            if (ApoioJogadas.NumeroX.Equals(4))
            {
                HabilitaJogadorDaVez(1);
                return;
            }

            SetaNumeroDaSorte(CorClicado);

            // Peos na casa inicial 
            List<Eixo> Eixo = posicoes.PosicoesArea;
            if (NumeroSorte.Equals(6))
            {
                Eixo = Eixo.Where(x => x.Casa.Equals(true) && x.CorEstacionada.Count > 0 && x.CorPermitida.Equals(CorClicado)).ToList();
                foreach (var item in Eixo)
                {
                    foreach (var itemNaCasaInicial in item.CorEstacionada)
                    {
                        ApoioJogadas.JaJogou = false;
                        itemNaCasaInicial.pictureBox.Enabled = true;
                        switch (CorClicado)
                        {
                            case Cores.Azul:
                                itemNaCasaInicial.pictureBox.Image = Ludo.Properties.Resources.BonecoAzulLiberado;
                                break;
                            case Cores.Verde:
                                itemNaCasaInicial.pictureBox.Image = Ludo.Properties.Resources.BonecoVerdeLiberado;
                                break;
                            case Cores.Amarelo:
                                itemNaCasaInicial.pictureBox.Image = Ludo.Properties.Resources.BonecoAmareloLiberado;
                                break;
                            case Cores.Vermelho:
                                itemNaCasaInicial.pictureBox.Image = Ludo.Properties.Resources.BonecoVermelhoLiberado;
                                break;
                        }
                    }
                }
            }

            // peoes no tabuleiro 
            Eixo = posicoes.PosicoesArea;

            switch (CorClicado)
            {
                case Cores.Azul:
                    Eixo = Eixo.Where(x => x.CorEstacionada.Count > 0 &&
                     (x.CorEstacionada.Contains(PeaoAzul1) || x.CorEstacionada.Contains(PeaoAzul2) || x.CorEstacionada.Contains(PeaoAzul3) || x.CorEstacionada.Contains(PeaoAzul4))
                     && x.PosicaoAzul > 0.5 && (x.PosicaoAzul + NumeroSorte) <= 57).ToList();
                    break;
                case Cores.Verde:
                    Eixo = Eixo.Where(x => x.CorEstacionada.Count > 0 &&
                     (x.CorEstacionada.Contains(PeaoVerde1) || x.CorEstacionada.Contains(PeaoVerde2) || x.CorEstacionada.Contains(PeaoVerde3) || x.CorEstacionada.Contains(PeaoVerde4))
                     && x.PosicaoVerde > 0.5 && (x.PosicaoVerde + NumeroSorte) <= 57).ToList();
                    break;
                case Cores.Amarelo:
                    Eixo = Eixo.Where(x => x.CorEstacionada.Count > 0 &&
                     (x.CorEstacionada.Contains(PeaoAmarelo1) || x.CorEstacionada.Contains(PeaoAmarelo2) || x.CorEstacionada.Contains(PeaoAmarelo3) || x.CorEstacionada.Contains(PeaoAmarelo4))
                     && x.PosicaoAmarelo > 0.5 && (x.PosicaoAmarelo + NumeroSorte) <= 57).ToList();
                    break;
                case Cores.Vermelho:
                    Eixo = Eixo.Where(x => x.CorEstacionada.Count > 0 &&
                     (x.CorEstacionada.Contains(PeaoVermelho1) || x.CorEstacionada.Contains(PeaoVermelho2) || x.CorEstacionada.Contains(PeaoVermelho3) || x.CorEstacionada.Contains(PeaoVermelho4))
                     && x.PosicaoVermelho > 0.5 && (x.PosicaoVermelho + NumeroSorte) <= 57).ToList();
                    break;
            }

            foreach (var SuperItem in Eixo)
            {
                foreach (var itemForaCasa in SuperItem.CorEstacionada)
                {
                    if (itemForaCasa.Cor.Equals(CorClicado))
                    {
                        ApoioJogadas.JaJogou = false;
                        itemForaCasa.pictureBox.Enabled = true;
                        itemForaCasa.pictureBox.BringToFront();

                        switch (CorClicado)
                        {
                            case Cores.Azul:
                                itemForaCasa.pictureBox.Image = Ludo.Properties.Resources.BonecoAzulLiberado;
                                break;
                            case Cores.Verde:
                                itemForaCasa.pictureBox.Image = Ludo.Properties.Resources.BonecoVerdeLiberado;
                                break;
                            case Cores.Amarelo:
                                itemForaCasa.pictureBox.Image = Ludo.Properties.Resources.BonecoAmareloLiberado;
                                break;
                            case Cores.Vermelho:
                                itemForaCasa.pictureBox.Image = Ludo.Properties.Resources.BonecoVermelhoLiberado;
                                break;
                        }
                    }
                }
            }

            if (ApoioJogadas.JaJogou.Equals(true))
            {
                // jogou mais nao andou com nenhum peao 
                dgJogadas.DataSource = null;
                Application.DoEvents();
                jogadas.Add(new Jogadas { CasaAnterior = -1, DataHora = DateTime.Now, NumeroSorte = NumeroSorte, cores = CorClicado, peao = 0, acao = Acao.Esperar });
                dgJogadas.DataSource = jogadas;
                try { dgJogadas.FirstDisplayedScrollingRowIndex = dgJogadas.Rows.Count - 1; } catch (Exception) { }
                Application.DoEvents();
                HabilitaJogadorDaVez(NumeroSorte);

            }

        }

        private void SetaNumeroDaSorte(Cores CorClicado)
        {
            switch (CorClicado)
            {
                case Cores.Azul:
                    lblDadosAzul.Text = NumeroSorte.ToString();
                    break;
                case Cores.Verde:
                    lblDadosVerde.Text = NumeroSorte.ToString();
                    break;
                case Cores.Amarelo:
                    lblDadosAmarelo.Text = NumeroSorte.ToString();
                    break;
                case Cores.Vermelho:
                    lblDadosVermelho.Text = NumeroSorte.ToString();
                    break;
            }
        }

        private void DesabilitaJogadores()
        {
            BoxAmarelo.Enabled = false;
            BoxVerde.Enabled = false;
            BoxVermelho.Enabled = false;
            BoxAzul.Enabled = false;
        }

        private void HabilitaJogadorDaVez(int NumeroSorte)
        {
            DesabilitaJogadores();

            // numero da sorte 7 igual matou peao
            // numero da sorte 8 igual guardou peao na casa final

            if ((NumeroSorte.Equals(6) && ApoioJogadas.NumeroX <= 2) || NumeroSorte.Equals(7) || NumeroSorte.Equals(8))
            {
                switch (ApoioJogadas.JogadorAtual)
                {
                    case Cores.Azul:
                        BoxAzul.Enabled = true;
                        break;
                    case Cores.Verde:
                        BoxVerde.Enabled = true;
                        break;
                    case Cores.Amarelo:
                        BoxAmarelo.Enabled = true;
                        break;
                    case Cores.Vermelho:
                        BoxVermelho.Enabled = true;
                        break;
                }
            }
            else
            {
                ApoioJogadas.NumeroX = 0;
                switch (ApoioJogadas.JogadorAtual)
                {
                    case Cores.Azul:
                        BoxVermelho.Enabled = true;
                        lblDadosVermelho.Text = "";
                        break;
                    case Cores.Verde:
                        BoxAmarelo.Enabled = true;
                        lblDadosAmarelo.Text = "";
                        break;
                    case Cores.Amarelo:
                        BoxAzul.Enabled = true;
                        lblDadosAzul.Text = "";
                        break;
                    case Cores.Vermelho:
                        BoxVerde.Enabled = true;
                        lblDadosVerde.Text = "";
                        break;
                }
            }

            if (!ApoioJogadas.FimDoJogo)
                VerificaAcaoRobo();

        }

        private void DesabilitaPeos()
        {
            BonecoAzul1.Image = Ludo.Properties.Resources.BonecoAzul;
            BonecoAzul2.Image = Ludo.Properties.Resources.BonecoAzul;
            BonecoAzul3.Image = Ludo.Properties.Resources.BonecoAzul;
            BonecoAzul4.Image = Ludo.Properties.Resources.BonecoAzul;

            BonecoAzul1.Enabled = false;
            BonecoAzul2.Enabled = false;
            BonecoAzul3.Enabled = false;
            BonecoAzul4.Enabled = false;

            BonecoVerde1.Image = Ludo.Properties.Resources.BonecoVerde;
            BonecoVerde2.Image = Ludo.Properties.Resources.BonecoVerde;
            BonecoVerde3.Image = Ludo.Properties.Resources.BonecoVerde;
            BonecoVerde4.Image = Ludo.Properties.Resources.BonecoVerde;

            BonecoVerde1.Enabled = false;
            BonecoVerde2.Enabled = false;
            BonecoVerde3.Enabled = false;
            BonecoVerde4.Enabled = false;

            BonecoAmarelo1.Image = Ludo.Properties.Resources.BonecoAmarelo;
            BonecoAmarelo2.Image = Ludo.Properties.Resources.BonecoAmarelo;
            BonecoAmarelo3.Image = Ludo.Properties.Resources.BonecoAmarelo;
            BonecoAmarelo4.Image = Ludo.Properties.Resources.BonecoAmarelo;

            BonecoAmarelo1.Enabled = false;
            BonecoAmarelo2.Enabled = false;
            BonecoAmarelo3.Enabled = false;
            BonecoAmarelo4.Enabled = false;

            BonecoVermelho1.Image = Ludo.Properties.Resources.BonecoVermelho;
            BonecoVermelho2.Image = Ludo.Properties.Resources.BonecoVermelho;
            BonecoVermelho3.Image = Ludo.Properties.Resources.BonecoVermelho;
            BonecoVermelho4.Image = Ludo.Properties.Resources.BonecoVermelho;

            BonecoVermelho1.Enabled = false;
            BonecoVermelho2.Enabled = false;
            BonecoVermelho3.Enabled = false;
            BonecoVermelho4.Enabled = false;
        }

        private void MataPeao(Eixo eixo, Peao peaoUltimoJogador)
        {
            if (!eixo.Protegida && eixo.CorEstacionada.Count() > 1)
            {
                bool MatouAlgum = false;
                foreach (var item in eixo.CorEstacionada.ToList())
                {
                    if (item.Cor != peaoUltimoJogador.Cor)
                    {
                        jogadas.Add(new Jogadas { CasaAnterior = int.Parse(CasaAnterior.ToString()) + NumeroSorte, DataHora = DateTime.Now, NumeroSorte = 0, cores = item.Cor, peao = item.Numero, acao = Acao.Morrer });
                        SetaPeaoInicio(item);
                        eixo.CorEstacionada.Remove(item);
                        MatouAlgum = true;
                    }
                }

                if (MatouAlgum)
                {
                    ApoioJogadas.NumeroX = 1;
                    ApoioJogadas.JaJogou = true;
                    ApoioJogadas.MatouAlgum = true;
                    return;
                }
            }
            else
                ApoioJogadas.MatouAlgum = false;
        }

        private void ResizePeaoCasa(Eixo eixo)
        {
            if (eixo.Casa)
                return;

            if (eixo.CorEstacionada.Count() >= 5)
            {

                int qtd = eixo.CorEstacionada.Count();

                int linhas = 1;
                int QtdPeao = 0;
                foreach (var item in eixo.CorEstacionada.OrderBy(x => x.Cor))
                {
                    QtdPeao++;


                    item.pictureBox.Width = 12;
                    item.pictureBox.Height = 12;


                    if (QtdPeao <= 4)
                    {
                        linhas = 1;
                        item.pictureBox.Location = new Point((eixo.X - 20) + (10 * (QtdPeao)), (eixo.Y - 10) + (7 * linhas));
                    }
                    else if (QtdPeao > 4 && QtdPeao <= 8)
                    {
                        linhas = 2;
                        item.pictureBox.Location = new Point((eixo.X - 20) + (10 * (QtdPeao - 4)), (eixo.Y - 10) + (7 * linhas));
                    }
                    else if (QtdPeao > 8 && QtdPeao <= 12)
                    {
                        linhas = 3;
                        item.pictureBox.Location = new Point((eixo.X - 20) + (10 * (QtdPeao - 8)), (eixo.Y - 10) + (7 * linhas));
                    }
                    else
                    {
                        linhas = 4;
                        item.pictureBox.Location = new Point((eixo.X - 20) + (10 * (QtdPeao - 12)), (eixo.Y - 10) + (7 * linhas));
                    }
                }

            }
            else if (eixo.CorEstacionada.Count() > 1 && eixo.CorEstacionada.Count() <= 4)
            {
                int QtdPeao = 0;
                int linhas = 1;
                foreach (var item in eixo.CorEstacionada.OrderBy(x => x.Cor))
                {
                    QtdPeao++;

                    item.pictureBox.Width = 18;
                    item.pictureBox.Height = 18;

                    if (QtdPeao <= 2)
                    {
                        linhas = 1;
                        item.pictureBox.Location = new Point((eixo.X - 26) + (18 * (QtdPeao)), (eixo.Y - 18) + (10 * linhas));
                    }
                    else
                    {
                        linhas = 3;
                        item.pictureBox.Location = new Point((eixo.X - 26) + (18 * (QtdPeao - 2)), (eixo.Y - 18) + (10 * linhas));
                    }

                }

            }
            else
            {
                foreach (var item in eixo.CorEstacionada)
                {
                    item.pictureBox.Width = 24;
                    item.pictureBox.Height = 23;
                    item.pictureBox.Location = new Point(eixo.X, eixo.Y);


                }

            }
        }

        private Eixo VerificaCasaAnterior(Cores Cor, double CasaAnterior)
        {
            Eixo eixo = null;
            switch (Cor)
            {
                case Cores.Azul:
                    eixo = posicoes.PosicoesArea.Where(x => x.PosicaoAzul.Equals(CasaAnterior)).FirstOrDefault();
                    break;
                case Cores.Verde:
                    eixo = posicoes.PosicoesArea.Where(x => x.PosicaoVerde.Equals(CasaAnterior)).FirstOrDefault();
                    break;
                case Cores.Amarelo:
                    eixo = posicoes.PosicoesArea.Where(x => x.PosicaoAmarelo.Equals(CasaAnterior)).FirstOrDefault();
                    break;
                case Cores.Vermelho:
                    eixo = posicoes.PosicoesArea.Where(x => x.PosicaoVermelho.Equals(CasaAnterior)).FirstOrDefault();
                    break;
                default:
                    break;
            }

            return eixo;
        }

        private int Multiplo(int Valor, int Multiplo)
        {
            var resultado = 0;
            if (Valor % Multiplo == 0)
            {
                resultado = Valor;
            }
            else
            {
                resultado = (Valor - (Valor % Multiplo)) + Multiplo;
            }
            return resultado;
        }

        private void VerificaAcaoRobo()
        {

            Peao PeaoDisponiveis=null;
            if (BoxAzul.Enabled && chkRoboAzul.Checked)
            {

                System.Threading.Thread.Sleep(1000);
                btnDadosAzul_Click(null, null);
                System.Threading.Thread.Sleep(500);
                // fazer aqui a inteligencia de escolher qual peao jogar ( deixei no aleatorio newid ) 
                PeaoDisponiveis = Jogadores.Where(x => x.Cor.Equals(Cores.Azul) && x.pictureBox.Enabled.Equals(true)).OrderBy(q => Guid.NewGuid()).Take(1).FirstOrDefault();
            }
            if (BoxVerde.Enabled && chkRoboVerde.Checked)
            {

                System.Threading.Thread.Sleep(500);
                btnDadosVerde_Click(null, null);
                System.Threading.Thread.Sleep(500);
                // fazer aqui a inteligencia de escolher qual peao jogar ( deixei no aleatorio newid ) 
                PeaoDisponiveis = Jogadores.Where(x => x.Cor.Equals(Cores.Verde) && x.pictureBox.Enabled.Equals(true)).OrderBy(q => Guid.NewGuid()).Take(1).FirstOrDefault();
            }
            if (BoxVermelho.Enabled && chkRoboVermelho.Checked)
            {

                System.Threading.Thread.Sleep(500);
                btnDadosVermelho_Click(null, null);
               System.Threading.Thread.Sleep(500);
                // fazer aqui a inteligencia de escolher qual peao jogar ( deixei no aleatorio newid ) 
                 PeaoDisponiveis = Jogadores.Where(x => x.Cor.Equals(Cores.Vermelho) && x.pictureBox.Enabled.Equals(true)).OrderBy(q => Guid.NewGuid()).Take(1).FirstOrDefault();
            }
            if (BoxAmarelo.Enabled && chkRoboAmarelo.Checked)
            {

                System.Threading.Thread.Sleep(500);
                btnDadosAmarelo_Click(null, null);
                System.Threading.Thread.Sleep(500);
                // fazer aqui a inteligencia de escolher qual peao jogar ( deixei no aleatorio newid ) 
                PeaoDisponiveis = Jogadores.Where(x => x.Cor.Equals(Cores.Amarelo) && x.pictureBox.Enabled.Equals(true)).OrderBy(q => Guid.NewGuid()).Take(1).FirstOrDefault();
            }

            Application.DoEvents();
           if(PeaoDisponiveis!=null)
            {
                System.Threading.Thread.Sleep(2500);
                AndarPeao(PeaoDisponiveis);
                System.Threading.Thread.Sleep(500);
            }

        }

        #endregion

        #region Objeto Peoes

        private void BonecoAzul1_Click(object sender, EventArgs e)
        {
            if(!chkRoboAzul.Checked)
                AndarPeao(PeaoAzul1);
        }

        private void BonecoAzul2_Click(object sender, EventArgs e)
        {
            if (!chkRoboAzul.Checked)
                AndarPeao(PeaoAzul2);
        }

        private void BonecoAzul3_Click(object sender, EventArgs e)
        {
            if (!chkRoboAzul.Checked)
                AndarPeao(PeaoAzul3);
        }

        private void BonecoAzul4_Click(object sender, EventArgs e)
        {
            if (!chkRoboAzul.Checked)
                AndarPeao(PeaoAzul4);
        }

        private void BonecoAmarelo1_Click(object sender, EventArgs e)
        {
            if (!chkRoboAmarelo.Checked)
                AndarPeao(PeaoAmarelo1);
        }

        private void BonecoAmarelo2_Click(object sender, EventArgs e)
        {
            if (!chkRoboAmarelo.Checked)
                AndarPeao(PeaoAmarelo2);
        }

        private void BonecoAmarelo3_Click(object sender, EventArgs e)
        {
            if (!chkRoboAmarelo.Checked)
                AndarPeao(PeaoAmarelo3);
        }

        private void BonecoAmarelo4_Click(object sender, EventArgs e)
        {
            if (!chkRoboAmarelo.Checked)
                AndarPeao(PeaoAmarelo4);
        }

        private void BonecoVerde1_Click(object sender, EventArgs e)
        {
            if (!chkRoboVerde.Checked)
                AndarPeao(PeaoVerde1);
        }

        private void BonecoVerde2_Click(object sender, EventArgs e)
        {
            if (!chkRoboVerde.Checked)
                AndarPeao(PeaoVerde2);
        }

        private void BonecoVerde3_Click(object sender, EventArgs e)
        {
            if (!chkRoboVerde.Checked)
                AndarPeao(PeaoVerde3);
        }

        private void BonecoVerde4_Click(object sender, EventArgs e)
        {
            if (!chkRoboVerde.Checked)
                AndarPeao(PeaoVerde4);
        }

        private void BonecoVermelho1_Click(object sender, EventArgs e)
        {
            if (!chkRoboVermelho.Checked)
                AndarPeao(PeaoVermelho1);
        }

        private void BonecoVermelho2_Click(object sender, EventArgs e)
        {
            if (!chkRoboVermelho.Checked)
                AndarPeao(PeaoVermelho2);
        }

        private void BonecoVermelho3_Click(object sender, EventArgs e)
        {
            if (!chkRoboVermelho.Checked)
                AndarPeao(PeaoVermelho3);
        }

        private void BonecoVermelho4_Click(object sender, EventArgs e)
        {
            if (!chkRoboVermelho.Checked)
                AndarPeao(PeaoVermelho4);
        }

        #endregion

        #region Objetos Dados

        private void btnDadosAzul_Click(object sender, EventArgs e)
        {

            ClicaDados(Cores.Azul);

        }

        private void btnDadosAmarelo_Click(object sender, EventArgs e)
        {
            ClicaDados(Cores.Amarelo);
        }

        private void btnDadosVerde_Click(object sender, EventArgs e)
        {
            ClicaDados(Cores.Verde);
        }

        private void btnDadosVermelho_Click(object sender, EventArgs e)
        {
            ClicaDados(Cores.Vermelho);
        }

        #endregion

        #region Menu

        private void novoJogoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SetaInicio();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSobre frmSobre = new frmSobre();
            frmSobre.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

    }
}
