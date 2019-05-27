using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tabuleiro;

namespace xadrez
{
    class PartidaDeXadrex
    {
        public Tabuleiro tab { get; private set; }
        public int turno { get; private set; }
        public Cor JogadorAtual { get; private set; }
        public bool terminada { get; set; }
        private HashSet<Peca> pecas;
        private HashSet<Peca> capturadas;

        public PartidaDeXadrex()
        {
            tab = new Tabuleiro(8, 8);
            turno = 1;
            JogadorAtual = Cor.Branca;
            terminada = false;
            pecas = new HashSet<Peca>();
            capturadas = new HashSet<Peca>();
            colocarPecas();
        }

        public void executaMovimento(Posicao oritem, Posicao destino)
        {
            Peca p = tab.retirarPeca(oritem);
            p.incrementarQtdMovimento();
            Peca pecaCapturada = tab.retirarPeca(destino);
            tab.colocarPeca(p, destino);

            if (pecaCapturada != null)
            {
                capturadas.Add(pecaCapturada);
            }
        }

        public void realizaJogada(Posicao origem, Posicao destino)
        {
            executaMovimento(origem, destino);
            turno++;
            mudaJogador();
        }

        public void validarPosicaoOrigem(Posicao pos)
        {
            if (tab.peca(pos) == null)
            {
                throw new TabulerioException("Não existe peça na posição de origem escolhida");
            }
            if (JogadorAtual != tab.peca(pos).cor)
            {
                throw new TabulerioException("A peça de origem escolhida não é sua");
            }
            if (!tab.peca(pos).existeMovimentosPossiveis())
            {
                throw new TabulerioException("Não há movimentos possiveis para a peça escolhida");
            }
            {

            }
        }

        public void validarPosicaoDestino(Posicao origem, Posicao destino)
        {
            if (!tab.peca(origem).podeMoverPara(destino))
            {
                throw new TabulerioException("Posição de destino inválida;");
            }
        }

        private void mudaJogador()
        {
            if (JogadorAtual == Cor.Branca)
            {
                JogadorAtual = Cor.Preta;
            }
            else
            {
                JogadorAtual = Cor.Branca;
            }
        }

        public HashSet<Peca> pecasCapturas(Cor cor)
        {
            HashSet<Peca> aux = new HashSet<Peca>();
            foreach (Peca x in capturadas)
            {
                if (x.cor == cor)
                {
                    aux.Add(x);
                }
            }
            return aux;
        }

        public HashSet<Peca> pecasEmJogo(Cor cor)
        {
            HashSet<Peca> aux = new HashSet<Peca>();
            foreach (Peca x in capturadas)
            {
                if (x.cor == cor)
                {
                    aux.Add(x);
                }
            }
            aux.ExceptWith(pecasCapturas(cor));
            return aux;

        }

        public void colorcarNovaPeca(char coluna, int linha, Peca peca)
        {
            tab.colocarPeca(peca, new PosicaoXadrez(coluna, linha).toPosicao());
            pecas.Add(peca); 
        }
        private void colocarPecas()
        {
      
            colorcarNovaPeca('c', 1, new Torre(tab, Cor.Branca));
            colorcarNovaPeca('c', 2, new Torre(tab, Cor.Branca));
            colorcarNovaPeca('d', 2, new Torre(tab, Cor.Branca));
            colorcarNovaPeca('e', 2, new Torre(tab, Cor.Branca));
            colorcarNovaPeca('e', 1, new Torre(tab, Cor.Branca));
            colorcarNovaPeca('d', 1, new Rei(tab, Cor.Branca));


            colorcarNovaPeca('c', 7, new Torre(tab, Cor.Preta));
            colorcarNovaPeca('c', 8, new Torre(tab, Cor.Preta));
            colorcarNovaPeca('d', 7, new Torre(tab, Cor.Preta));
            colorcarNovaPeca('e', 7, new Torre(tab, Cor.Preta));
            colorcarNovaPeca('e', 8, new Torre(tab, Cor.Preta));
            colorcarNovaPeca('d', 8, new Rei(tab, Cor.Preta));

        }
    }
}
